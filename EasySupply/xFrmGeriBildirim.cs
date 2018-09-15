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
    public partial class xFrmGeriBildirim : DevExpress.XtraEditors.XtraForm
    {
        public string Konu { set { konuMemoEdit.Text = value; } }

        public void SetCurrencyAndLangs()
        {
            try
            {
                this.Text = L.DestekHatti;
                lblKonu.Text = L.Konu;
                lblMesaj.Text = L.MesajDetaylari;
                gonderButton.Text = L.Gonder;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FGB", 1) + ex.Message);
            }
        }

        public xFrmGeriBildirim()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        private void xFrmGeriBildirim_Load(object sender, EventArgs e)
        {

        }

        private void gonderButton_Click(object sender, EventArgs e)
        {
            try
            {
                string mesaj = BAYMYO.UI.FileIO.ReadText(Commons.AppFilePath + "GBM.dat")
                    .Replace("{SUBJECT}", konuMemoEdit.Text)
                    .Replace("{MESSAGE}", mesajMemoEdit.Text)
                    .Replace("{COMPANY}", Commons.AppSettings.COMPANY_NAME)
                    .Replace("{TICARIUNVAN}", Commons.AppSettings.COMPANY_DESC)
                    .Replace("{PHONE}", Commons.AppSettings.OFISPHONE)
                    .Replace("{GSM}", Commons.AppSettings.GSM)
                    .Replace("{MAIL}", Commons.AppSettings.MAIL)
                    .Replace("{WEB}", Commons.AppSettings.WEB)
                    .Replace("{ADDRESS}", Commons.AppSettings.ADDRESS)
                    .Replace("{VK}", Commons.MySerialKey)
                    .Replace("{PV}", System.Windows.Forms.Application.ProductVersion);
                Application.DoEvents();
                if (Mail.SendInfo("Feedback to Easy Supply! " + Commons.AppSettings.COMPANY_NAME, mesaj))
                {
                    Commons.Status(L.DestekBildirimIletildi);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    lblStatus.Text = L.DestekBildirimBasarisiz;
            }
            catch (Exception ex)
            {
                lblStatus.Text = L.DestekBildirimBasarisiz;
                Commons.Status(Commons.GetErrorCode("FGB", 2) + ex.Message);
            }
        }
    }
}