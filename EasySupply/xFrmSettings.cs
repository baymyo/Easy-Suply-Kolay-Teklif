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
    public partial class xFrmSettings : DevExpress.XtraEditors.XtraForm
    {
        public void SetCurrencyAndLangs()
        {
            try
            {
                networkSettingButton.Text = L.AyarlariAgdanAl;
                savedButton.Text = L.AyarlariKaydet;

                lblOnemliUyari.Text = L.OnemliUyari;

                lblTeklifVermeFormu.Text = L.TeklifVermeTutanagi;
                lblMalzemeTeslimFormu.Text = L.TeslimVermeTutanagi;
                lblSiparisToplamaListesi.Text = L.SiparisToplamaListesi;
                lblSiparisMaliyetRaporu.Text = L.SiparisMaliyetListesi;

                veritabaniGeriAlGroupControl.Text = L.VeritabaniGeriAl;
                veritabaniGeriAlButton.Text = L.KabulEdiyorum;
                veritabaniNetworkButton.Text = L.VeritabaniAgdanSec;
                veritabaniOlusturButton.Text = L.VeritabaniOlustur;
                veritabaniOnarButton.Text = L.VeritabaniOnar;
                veritabaniYedekeButton.Text = L.VeritabaniYedekle;

                currencyCheck.Text = L.KabulEtmek;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 1) + ex.Message);
            }
        }
        void CreateCode()
        {
            this.dbPasswordLabel.Text = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 3).ToUpper();
        }
        void IsDatabase()
        {
            this.veritabaniOlusturButton.Enabled = !System.IO.File.Exists(Commons.AppSettings.DATABASE);
        }
        void GetSettings()
        {
            try
            {
                if (Commons.AppSettings == null)
                    Commons.AppSettings = new Settings();

                Commons.ColorLoad();
                Commons.ImageLoad();

                this.currentPriceFormatBindingSource.DataSource = CurrentPriceFormat.GetCurrencyFormats();

                IsDatabase();
                if (this.veritabaniOlusturButton.Enabled)
                    this.xtbSettings.SelectedTabPage = this.xtbDatabaseSettings;
                CreateCode();

                this.picHeader.Image = Commons.HeaderImage;
                this.picFatura.Image = Commons.HeaderFactura;
                this.picLogo.Image = Commons.LogoCompany;
                this.picOtherLogos.Image = Commons.LogoOther;
                this.imageFormHeaderCheck.Checked = Commons.AppSettings.IS_IMAGE_HEADER;

                this.txtTitle.Text = Commons.AppSettings.COMPANY_NAME;
                this.txtSubTitle.Text = Commons.AppSettings.COMPANY_DESC;
                this.txtHeaderLine.Text = Commons.AppSettings.HEADER_TITLE;
                this.txtDescTR.Text = Commons.AppSettings.DESC_TR;
                this.txtDescEN.Text = Commons.AppSettings.DESC_EN;
                this.txtOfficePhone.Text = Commons.AppSettings.OFISPHONE;
                this.txtGSM.Text = Commons.AppSettings.GSM;
                this.txtFAX.Text = Commons.AppSettings.FAX;
                this.txtAddress.Text = Commons.AppSettings.ADDRESS;
                this.txtMail.Text = Commons.AppSettings.MAIL;
                this.txtWeb.Text = Commons.AppSettings.WEB;

                this.txtPreparedBy.Text = Commons.AppSettings.PREPAREDBY;
                this.txtUnits.Text = Commons.AppSettings.UNITS;

                this.txtTeklifVerme.Text = Commons.AppSettings.TEKLIF_VERME_FORMU;
                this.txtMalzemeTeslimi.Text = Commons.AppSettings.MALZEME_TESLIM_FORMU;
                this.txtSiparisToplama.Text = Commons.AppSettings.SIPARIS_TOPLAMA_FORMU;
                this.txtSiparisFiyatListesi.Text = Commons.AppSettings.SIPARIS_LISTESI_FORMU;
                this.txtUrunKatalogForm.Text = Commons.AppSettings.URUN_KATALOG_FORMU;

                this.headerTitleBgColor.Color = Commons.HEADER_BACKCOLOR;
                this.headerTitleBrdColor.Color = Commons.HEADER_BORDERCOLOR;
                this.headerTitleFgColor.Color = Commons.HEADER_TITLECOLOR;
                this.headerDescColor.Color = Commons.HEADER_DESCCOLOR;
                this.companyForeColor.Color = Commons.COMPANY_FORECOLOR;
                this.descTRbackColor.Color = Commons.DESC_TR_BACKCOLOR;
                this.descTRforeColor.Color = Commons.DESC_TR_FORECOLOR;
                this.descENbackColor.Color = Commons.DESC_EN_BACKCOLOR;
                this.descENforeColor.Color = Commons.DESC_EN_FORECOLOR;

                this.defaultCurrencyLookUpEdit.EditValue = Commons.AppSettings.DEFAULT_CURRENCY.Code;
                this.defaultCurrencyFormatTextEdit.Text = Commons.AppSettings.DEFAULT_CURRENCY.Format;
                this.defaultCurrencySymbolTextEdit.Text = Commons.AppSettings.DEFAULT_CURRENCY.Symbol;

                this.crossCurrency1LookUpEdit.EditValue = Commons.AppSettings.CROSS_CURRENCY_1.Code;
                this.crossCurrency1TextEdit.Text = Commons.AppSettings.CROSS_CURRENCY_1.Format;
                this.crossSymbol1TextEdit.Text = Commons.AppSettings.CROSS_CURRENCY_1.Symbol;

                this.crossCurrency2LookUpEdit.EditValue = Commons.AppSettings.CROSS_CURRENCY_2.Code;
                this.crossCurrency2TextEdit.Text = Commons.AppSettings.CROSS_CURRENCY_2.Format;
                this.crossSymbol2TextEdit.Text = Commons.AppSettings.CROSS_CURRENCY_2.Symbol;

                this.networkDatabase.Text = Commons.AppSettings.DATABASE;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 2) + ex.Message);
            }
        }

        public xFrmSettings()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        void xFrmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                GetSettings();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 3) + ex.Message);
            }
        }

        void picHeader_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    fd.Title = "Header Seçiniz";
                    fd.FileName = "Yeni Header Seçiniz!";
                    fd.Filter = "BMP File|*.bmp|Jpeg File|*.jpg|PNG File|*.png";
                    switch (fd.ShowDialog())
                    {
                        case DialogResult.OK:
                        case DialogResult.Retry:
                        case DialogResult.Yes:
                            if (!System.IO.File.Exists(Commons.HeaderImageFile))
                                System.IO.File.Delete(Commons.HeaderImageFile);
                            System.IO.File.Copy(fd.FileName, Commons.HeaderImageFile, true);
                            Commons.ImageLoad();
                            this.picHeader.Image = Commons.HeaderImage;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 4) + ex.Message);
            }
        }
        void picFatura_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    fd.Title = "Fatura Başlığı Seçiniz";
                    fd.FileName = "Yeni Fatura Başlığı Seçiniz!";
                    fd.Filter = "BMP File|*.bmp|Jpeg File|*.jpg|PNG File|*.png";
                    switch (fd.ShowDialog())
                    {
                        case DialogResult.OK:
                        case DialogResult.Retry:
                        case DialogResult.Yes:
                            if (!System.IO.File.Exists(Commons.HeaderFacturaFile))
                                System.IO.File.Delete(Commons.HeaderFacturaFile);
                            System.IO.File.Copy(fd.FileName, Commons.HeaderFacturaFile, true);
                            Commons.ImageLoad();
                            this.picFatura.Image = Commons.HeaderFactura;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 5) + ex.Message);
            }
        }
        void picLogo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    fd.Title = "Logo Seçiniz";
                    fd.FileName = "Yeni Logo Seçiniz!";
                    fd.Filter = "BMP File|*.bmp|Jpeg File|*.jpg|PNG File|*.png";
                    switch (fd.ShowDialog())
                    {
                        case DialogResult.OK:
                        case DialogResult.Retry:
                        case DialogResult.Yes:
                            if (!System.IO.File.Exists(Commons.LogoFile))
                                System.IO.File.Delete(Commons.LogoFile);
                            System.IO.File.Copy(fd.FileName, Commons.LogoFile, true);
                            Commons.ImageLoad();
                            this.picLogo.Image = Commons.LogoCompany;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 6) + ex.Message);
            }
        }
        void picOtherLogos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    fd.Title = "Diğer Logolar Seçiniz";
                    fd.FileName = "Yeni Diğer Logo Seçiniz!";
                    fd.Filter = "BMP File|*.bmp|Jpeg File|*.jpg|PNG File|*.png";
                    switch (fd.ShowDialog())
                    {
                        case DialogResult.OK:
                        case DialogResult.Retry:
                        case DialogResult.Yes:
                            if (!System.IO.File.Exists(Commons.LogoOtherFile))
                                System.IO.File.Delete(Commons.LogoOtherFile);
                            System.IO.File.Copy(fd.FileName, Commons.LogoOtherFile, true);
                            Commons.ImageLoad();
                            this.picOtherLogos.Image = Commons.LogoOther;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 7) + ex.Message);
            }
        }

        void backupButton_Click(object sender, EventArgs e)
        {
            Commons.BackupDatabase();
        }
        void restoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.dbPasswordTextEdit.Text))
                    return;
                if (!this.dbPasswordTextEdit.Text.ToLower().Equals(this.dbPasswordLabel.Text.ToLower()))
                {
                    MessageBox.Show(L.VeritabaniGerialIslemiSifre, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                switch (MessageBox.Show(L.VeritabaniGerialIslemiUyari, "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
                {
                    case DialogResult.Yes:
                        Commons.RestoreDatabase();
                        CreateCode();
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 8) + ex.Message);
            }
        }
        void repairButton_Click(object sender, EventArgs e)
        {
            Commons.RepairDatabase();
        }

        void createDatabaseButton_Click(object sender, EventArgs e)
        {
            Commons.CreateDatabase();
            IsDatabase();
        }
        void networkDatabase_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.veritabaniNetworkButton.PerformClick();
        }
        void veritabaniNetworkButton_Click(object sender, EventArgs e)
        {
            switch (openFileDialog1.ShowDialog())
            {
                case DialogResult.OK:
                case DialogResult.Retry:
                case DialogResult.Yes:
                    this.networkDatabase.Text = openFileDialog1.FileName;
                    break;
            }
        }

        void savedButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.networkDatabase.Text))
                {
                    MessageBox.Show("Veritabanı ayarları boş bırakılamaz.", "Uyarı");
                    return;
                }
                Application.DoEvents();
                Commons.Loading("Ayarlar bölümünde yaptığınız değişiklikler kaydediliyor.. .");
                Commons.AppSettings.IS_IMAGE_HEADER = this.imageFormHeaderCheck.Checked;
                Commons.AppSettings.COMPANY_NAME = this.txtTitle.Text;
                Commons.AppSettings.COMPANY_DESC = this.txtSubTitle.Text;
                Commons.AppSettings.HEADER_TITLE = this.txtHeaderLine.Text;
                Commons.AppSettings.DESC_TR = this.txtDescTR.Text;
                Commons.AppSettings.DESC_EN = this.txtDescEN.Text;
                Commons.AppSettings.OFISPHONE = this.txtOfficePhone.Text;
                Commons.AppSettings.GSM = this.txtGSM.Text;
                Commons.AppSettings.FAX = this.txtFAX.Text;
                Commons.AppSettings.ADDRESS = this.txtAddress.Text;
                Commons.AppSettings.MAIL = this.txtMail.Text;
                Commons.AppSettings.WEB = this.txtWeb.Text;

                Commons.AppSettings.PREPAREDBY = this.txtPreparedBy.Text.Trim().ToUpper();
                Commons.AppSettings.UNITS = this.txtUnits.Text.Trim();

                Commons.AppSettings.TEKLIF_VERME_FORMU = this.txtTeklifVerme.Text;
                Commons.AppSettings.MALZEME_TESLIM_FORMU = this.txtMalzemeTeslimi.Text;
                Commons.AppSettings.SIPARIS_TOPLAMA_FORMU = this.txtSiparisToplama.Text;
                Commons.AppSettings.SIPARIS_LISTESI_FORMU = this.txtSiparisFiyatListesi.Text;
                Commons.AppSettings.URUN_KATALOG_FORMU = this.txtUrunKatalogForm.Text;

                Commons.AppSettings.HEADER_BACKCOLOR = Commons.RGBToString(this.headerTitleBgColor.Color);
                Commons.AppSettings.HEADER_BORDERCOLOR = Commons.RGBToString(this.headerTitleBrdColor.Color);
                Commons.AppSettings.HEADER_TITLECOLOR = Commons.RGBToString(this.headerTitleFgColor.Color);
                Commons.AppSettings.HEADER_DESCCOLOR = Commons.RGBToString(this.headerDescColor.Color);
                Commons.AppSettings.COMPANY_FORECOLOR = Commons.RGBToString(this.companyForeColor.Color);
                Commons.AppSettings.DESC_TR_BACKCOLOR = Commons.RGBToString(this.descTRbackColor.Color);
                Commons.AppSettings.DESC_TR_FORECOLOR = Commons.RGBToString(this.descTRforeColor.Color);
                Commons.AppSettings.DESC_EN_BACKCOLOR = Commons.RGBToString(this.descENbackColor.Color);
                Commons.AppSettings.DESC_EN_FORECOLOR = Commons.RGBToString(this.descENforeColor.Color);
                if (this.currencyCheck.Checked)
                {
                    CurrentPriceFormat c = this.defaultCurrencyLookUpEdit.GetSelectedDataRow() as CurrentPriceFormat;
                    CurrentPriceFormat c1 = this.crossCurrency1LookUpEdit.GetSelectedDataRow() as CurrentPriceFormat;
                    CurrentPriceFormat c2 = this.crossCurrency2LookUpEdit.GetSelectedDataRow() as CurrentPriceFormat;
                    if (c.Code.Equals(c1.Code) || c.Code.Equals(c2.Code))
                    {
                        dxErrorProvider1.SetError(defaultCurrencyLookUpEdit, L.DovizKuruBelirtilmis);
                        return;
                    }
                    else if (c1.Code.Equals(c.Code) || c1.Code.Equals(c2.Code))
                    {
                        dxErrorProvider1.SetError(crossCurrency1LookUpEdit, L.DovizKuruBelirtilmis);
                        return;
                    }
                    else if (c2.Code.Equals(c.Code) || c2.Code.Equals(c1.Code))
                    {
                        dxErrorProvider1.SetError(crossCurrency2LookUpEdit, L.DovizKuruBelirtilmis);
                        return;
                    }
                    else
                    {
                        Commons.AppSettings.DEFAULT_CURRENCY = c;
                        if (!string.IsNullOrWhiteSpace(this.defaultCurrencyFormatTextEdit.Text))
                            Commons.AppSettings.DEFAULT_CURRENCY.Format = this.defaultCurrencyFormatTextEdit.Text;
                        if (!string.IsNullOrWhiteSpace(this.defaultCurrencySymbolTextEdit.Text))
                            Commons.AppSettings.DEFAULT_CURRENCY.Symbol = this.defaultCurrencySymbolTextEdit.Text;
                        Commons.AppSettings.CROSS_CURRENCY_1 = c1;
                        if (!string.IsNullOrWhiteSpace(this.crossCurrency1TextEdit.Text))
                            Commons.AppSettings.CROSS_CURRENCY_1.Format = this.crossCurrency1TextEdit.Text;
                        if (!string.IsNullOrWhiteSpace(this.crossSymbol1TextEdit.Text))
                            Commons.AppSettings.CROSS_CURRENCY_1.Symbol = this.crossSymbol1TextEdit.Text;
                        Commons.AppSettings.CROSS_CURRENCY_2 = c2;
                        if (!string.IsNullOrWhiteSpace(this.crossCurrency2TextEdit.Text))
                            Commons.AppSettings.CROSS_CURRENCY_2.Format = this.crossCurrency2TextEdit.Text;
                        if (!string.IsNullOrWhiteSpace(this.crossSymbol2TextEdit.Text))
                            Commons.AppSettings.CROSS_CURRENCY_2.Symbol = this.crossSymbol2TextEdit.Text;
                    }
                }
                dxErrorProvider1.ClearErrors();
                Commons.AppSettings.DATABASE = this.networkDatabase.Text;
                if (!Commons.ConnectionStates())
                {
                    Commons.Loaded();
                    MessageBox.Show("Lütfen veritabanı bilgilerinin doğru olduğundan emin olunuz bu ayarı doğru yapmadığınız sürece bilgilerinize erişim sağlayamazsınız!", "Önemli Uyarı");
                    return;
                }
                if (jSonData.CreateFile(Commons.AppSettings))
                {
                    Commons.ColorLoad();
                    Commons.Loaded();
                    MessageBox.Show("Ayarlarınız başarılı bir şekilde kaydedildi.", "Bilgi");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 9) + ex.Message);
                Commons.Loaded();
            }
        }
        void networkSettingButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    fd.Title = "Selected Setting File";
                    fd.FileName = "settings.set";
                    fd.Filter = "Setting File|*.set";
                    switch (fd.ShowDialog())
                    {
                        case DialogResult.OK:
                        case DialogResult.Retry:
                        case DialogResult.Yes:
                            if (!System.IO.File.Exists(jSonData.SettingFile))
                            {
                                System.IO.File.Copy(jSonData.SettingFile, Commons.FolderPath + "settings_backup.set", true);
                                System.IO.File.Delete(jSonData.SettingFile);
                            }
                            System.IO.File.Copy(fd.FileName, jSonData.SettingFile, true);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                System.IO.File.Copy(Commons.FolderPath + "settings_backup.set", jSonData.SettingFile, true);
                Commons.Status(Commons.GetErrorCode("FSG", 10) + ex.Message);
            }
            finally
            {
                jSonData.ReadFile();
                GetSettings();
            }
        }

        void currencyCheck_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (currencyCheck.Checked)
                    currencyCheck.Text = L.KabulEdiyorum;
                else
                    currencyCheck.Text = L.KabulEtmek;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 11) + ex.Message);
            }
        }
        void imageFormHeaderCheck_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (imageFormHeaderCheck.Checked)
                    imageFormHeaderCheck.Text = L.BasliktaResimKullaniliyor;
                else
                    imageFormHeaderCheck.Text = L.BasliktaResimKullanin;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 12) + ex.Message);
            }
        }

        void defaultCurrencyLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentPriceFormat c = defaultCurrencyLookUpEdit.GetSelectedDataRow() as CurrentPriceFormat;
                if (c != null)
                {
                    defaultCurrencyFormatTextEdit.Text = c.Format;
                    defaultCurrencySymbolTextEdit.Text = c.Symbol;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 13) + ex.Message);
            }
        }
        void crossCurrency1LookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentPriceFormat c = crossCurrency1LookUpEdit.GetSelectedDataRow() as CurrentPriceFormat;
                if (c != null)
                {
                    crossCurrency1TextEdit.Text = c.Format;
                    crossSymbol1TextEdit.Text = c.Symbol;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 14) + ex.Message);
            }
        }
        void crossCurrency2LookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentPriceFormat c = crossCurrency2LookUpEdit.GetSelectedDataRow() as CurrentPriceFormat;
                if (c != null)
                {
                    crossCurrency2TextEdit.Text = c.Format;
                    crossSymbol2TextEdit.Text = c.Symbol;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FSG", 15) + ex.Message);
            }
        }
    }
}