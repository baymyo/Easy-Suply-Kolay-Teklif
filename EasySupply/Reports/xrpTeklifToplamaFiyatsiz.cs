using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace EasySupply
{
    public partial class xrpTeklifToplamaFiyatsiz : DevExpress.XtraReports.UI.XtraReport
    {
        public Teklif t;
        public System.Collections.Generic.List<TeklifDetay> Data { set { this.teklifDetayBindingSource.DataSource = value; } }

        public xrpTeklifToplamaFiyatsiz(Teklif p)
        {
            InitializeComponent();

            try
            {
                if (Commons.ExpariedDay <= 10)
                    this.Watermark.Text = "CREATED BY TRIAL VERSION!";
                else
                    this.Watermark.Text = string.Empty;
                this.xrLogo.Image = Commons.LogoCompany;
                this.xrTitle.Text = Commons.AppSettings.COMPANY_NAME;
                this.xrSubTitle.Text = Commons.AppSettings.COMPANY_DESC;
                this.xrTitle.ForeColor = this.xrSubTitle.ForeColor = Commons.COMPANY_FORECOLOR;
                this.xrFormRevNo.Text = Commons.AppSettings.SIPARIS_TOPLAMA_FORMU;

                this.t = p;
                this.DisplayName = t.GemiAdi.Replace("/", "").Replace("\\", "") + " - ÜRÜN TOPLAMA TUTNAĞI - " + t.Tarih.ToString("yyyy-MM-dd");
                this.xrReferans.Text = "Reference Number: " + t.ID;
                this.xrGemiAdi.Text = t.GemiAdi;
                this.xrBaglamaLimani.Text = t.BaglamaLimani;
                this.xrAcenta.Text = t.Acenta;
                this.xrFirma.Text = t.Manager;
                this.xrTarih.Text = t.GuncellemeTarihi.ToShortDateString();
                this.xrParaBirimi.Text = Commons.CurrencySelected(t.ParaBirimi);
                this.xrKdv.Text = Commons.GetTax(t.Kdv);
                this.xrHazirlayan.Text = t.Hazirlayan;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("RFR", 4) + ex.Message);
            }
        }
    }
}
