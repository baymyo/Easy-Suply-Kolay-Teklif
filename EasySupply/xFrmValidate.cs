using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EasySupply
{
    public partial class xFrmValidate : DevExpress.XtraEditors.XtraForm
    {
        public xFrmValidate()
        {
            InitializeComponent();
        }

        void xFrmValidate_Load(object sender, EventArgs e)
        {
            this.demoButton.Enabled = !Commons.IsLicenseValid;
            this.validateKeyText.Text = Commons.MySerialKey;
            this.productVersionText.Text = System.Windows.Forms.Application.ProductVersion;
        }

        void openLisanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    fd.Title = "License Key File";
                    fd.FileName = "LicenseKey.zip";
                    fd.Filter = "New License Key|*.zip";
                    switch (fd.ShowDialog())
                    {
                        case DialogResult.OK:
                        case DialogResult.Retry:
                        case DialogResult.Yes:
                            this.lisanceFilePath.Text = fd.FileName;
                            if (string.IsNullOrEmpty(this.lisanceFilePath.Text))
                            {
                                MessageBox.Show(L.LisansDosyasiSec, "License Load");
                                return;
                            }
                            if (System.IO.File.Exists(Commons.LicenseKeyFile))
                                System.IO.File.Delete(Commons.LicenseKeyFile);
                            BAYMYO.UI.FileIO.CreateDirectory(Commons.FolderPath);
                            System.IO.File.Copy(this.lisanceFilePath.Text, Commons.LicenseKeyFile);
                            Commons.IsLicenseLoad = true;
                            if (Commons.ValidateApplication())
                                this.DialogResult = DialogResult.OK;
                            else
                                MessageBox.Show(L.LisansGecersiz, "License Warning");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Commons.Status(Commons.GetErrorCode("FTL", 2) + " LICENSE ERROR");
            }
        }

        void talepButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Commons.IsNullOrEmpty(dxErrorProvider1, this.mailGroupControl.Controls))
                    return;
                else if (!Mail.IsAddressValid(this.mailTextEdit.Text))
                {
                    dxErrorProvider1.SetError(this.mailTextEdit, L.MailGecersiz);
                    return;
                }
                string mesaj = BAYMYO.UI.FileIO.ReadText(Commons.AppFilePath + "FL.dat")
                    .Replace("{COMPANY}", firmaAdiTextEdit.Text.Trim())
                    .Replace("{PHONE}", telefonTextEdit.Text)
                    .Replace("{MAIL}", mailTextEdit.Text)
                    .Replace("{VK}", validateKeyText.Text)
                    .Replace("{PV}", productVersionText.Text);
                Application.DoEvents();
                bool mailSendBaymyo = Mail.SendBaymyo(this.mailTextEdit.Text, this.firmaAdiTextEdit.Text, "Full License! Easy Supply Application.", mesaj + "<br/><br/> * Aynı mail SonayNet'de gitti!");
                bool mailSendSonay = Mail.SendSonay(this.mailTextEdit.Text, this.firmaAdiTextEdit.Text, "Full License! Easy Supply Application.", mesaj + "<br/><br/> * Aynı mail baymyo yazılma'da gitti!");
                if (mailSendBaymyo || mailSendSonay)
                {
                    this.telefonTextEdit.Text = string.Empty;
                    this.firmaAdiTextEdit.Text = string.Empty;
                    this.mailTextEdit.Text = string.Empty;
                    MessageBox.Show(L.FullLisansTalebi, "Succesful");
                }
                else
                    MessageBox.Show(L.FullLisansTalebiHata, "Mail Error");
            }
            catch (Exception)
            {
                MessageBox.Show(Commons.GetErrorCode("FTL", 3) + " LICENSE ERROR!", "Warning");
            }
        }

        void demoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Commons.IsNullOrEmpty(dxErrorProvider1, this.mailGroupControl.Controls))
                    return;
                else
                    dxErrorProvider1.ClearErrors();
                if (!Mail.IsAddressValid(this.mailTextEdit.Text))
                {
                    dxErrorProvider1.SetError(this.mailTextEdit, L.MailGecersiz);
                    return;
                }
                string mesaj = BAYMYO.UI.FileIO.ReadText(Commons.AppFilePath + "DL.dat")
                    .Replace("{COMPANY}", firmaAdiTextEdit.Text.Trim())
                    .Replace("{PHONE}", telefonTextEdit.Text)
                    .Replace("{MAIL}", mailTextEdit.Text)
                    .Replace("{VK}", validateKeyText.Text)
                    .Replace("{PV}", productVersionText.Text);
                Commons.Loading("License downloading .. .");
                Application.DoEvents();
                using (System.Net.WebClient cln = new System.Net.WebClient())
                {
                    System.IO.Stream s = cln.OpenRead(string.Format("http://service.baymyo.com/license.ashx?key={0}&v={1}", validateKeyText.Text, productVersionText.Text));
                    bool baymyoMail = Mail.SendBaymyo(this.mailTextEdit.Text, this.firmaAdiTextEdit.Text, "Demo License! Easy Supply Application.", mesaj + "<br/><br/> * Aynı mail SonayNet'de gitti!");
                    bool sonayMail = Mail.SendSonay(this.mailTextEdit.Text, this.firmaAdiTextEdit.Text, "Demo License! Easy Supply Application.", mesaj + "<br/><br/> * Aynı mail baymyo yazılma'da gitti!");
                    if ((baymyoMail || sonayMail) & s != null)
                    {
                        this.telefonTextEdit.Text = string.Empty;
                        this.firmaAdiTextEdit.Text = string.Empty;
                        this.mailTextEdit.Text = string.Empty;
                        if (!System.IO.File.Exists(Commons.LicenseKeyFile))
                        {
                            BAYMYO.UI.FileIO.CreateDirectory(Commons.FolderPath);
                            cln.DownloadFile(string.Format("http://service.baymyo.com/keys/{0}-{1}.zip", validateKeyText.Text, productVersionText.Text.Replace(".", "-")), Commons.LicenseKeyFile);
                            Commons.IsLicenseLoad = true;
                            if (Commons.ValidateApplication())
                                this.DialogResult = DialogResult.OK;
                            else
                                MessageBox.Show(L.LisansGecersiz, "License Warning");
                        }
                        else
                            MessageBox.Show("Şuan sisteminizde bir adet lisans dosyası bulunmaktadır.", "Info");
                    }
                    else
                        MessageBox.Show("Lisans dosyası indirilemiyor lütfen internet bağlantınızı yada proxy ayarlarınızı kontrol ediniz.", "Warning");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Commons.GetErrorCode("FTL", 4) + " DEMO LICENSE ERROR!", "Warning");
            }
            finally
            {
                Commons.Loaded();
            }
        }
    }
}