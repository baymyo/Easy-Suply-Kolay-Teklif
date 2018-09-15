using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace EasySupply
{
    public partial class xrpTeklifFormuFiyatsiz : DevExpress.XtraReports.UI.XtraReport
    {
        public Teklif t;
        public System.Collections.Generic.List<TeklifDetay> Data { set { this.teklifDetayBindingSource.DataSource = value; } }

        public xrpTeklifFormuFiyatsiz(Teklif p, FormType ft)
        {
            InitializeComponent();
            try
            {
                if (Commons.ExpariedDay <= 10)
                    this.Watermark.Text = "CREATED BY TRIAL VERSION!";
                else
                    this.Watermark.Text = string.Empty;
                Commons.Loading("Belge hazırlanıyor. ..");
                foreach (XRControl item in this.reportHeaderBand1.Controls)
                    switch (BAYMYO.UI.Converts.NullToString(item.Tag))
                    {
                        case "T":
                            item.BorderColor = Commons.HEADER_BORDERCOLOR;
                            item.ForeColor = Commons.HEADER_DESCCOLOR;
                            break;
                        case "TC":
                            item.BackColor = Commons.HEADER_BACKCOLOR;
                            item.BorderColor = Commons.HEADER_BORDERCOLOR;
                            item.ForeColor = Commons.HEADER_TITLECOLOR;
                            break;
                    }
                if (Commons.AppSettings.IS_IMAGE_HEADER)
                {
                    this.reportHeaderBand1.HeightF = 290f;
                    foreach (XRControl item in this.reportHeaderBand1.Controls)
                        switch (BAYMYO.UI.Converts.NullToString(item.Tag))
                        {
                            case "T":
                            case "TC":
                                item.LocationFloat = new DevExpress.Utils.PointFloat(item.LocationF.X, item.LocationF.Y + 53);
                                break;
                            case "V":
                                item.Visible = false;
                                break;
                        }
                    this.xrLogo.Image = Commons.HeaderImage;
                    this.xrLogo.WidthF = 788f;
                    this.xrLogo.HeightF = 200f;
                }
                else
                {
                    this.xrLogo.Image = Commons.LogoCompany;
                    this.xrOtherLogos.Image = Commons.LogoOther;
                    this.xrTitle.ForeColor = this.xrSubTitle.ForeColor = Commons.COMPANY_FORECOLOR;

                    this.xrDesc_TR.BackColor = Commons.DESC_TR_BACKCOLOR;
                    this.xrDesc_TR.ForeColor = Commons.DESC_TR_FORECOLOR;
                    this.xrDesc_EN.BackColor = Commons.DESC_EN_BACKCOLOR;
                    this.xrDesc_EN.ForeColor = Commons.DESC_EN_FORECOLOR;

                    this.xrHeaderTitle.Text = Commons.AppSettings.HEADER_TITLE;
                    this.xrDesc_TR.Text = Commons.AppSettings.DESC_TR;
                    this.xrDesc_EN.Text = Commons.AppSettings.DESC_EN;
                    this.xrOfficePhone.Text = Commons.AppSettings.OFISPHONE;
                    this.xrFax.Text = Commons.AppSettings.FAX;
                    this.xrGsm.Text = Commons.AppSettings.GSM;
                    this.xrAddress.Text = Commons.AppSettings.ADDRESS;
                    this.xrMail.Text = Commons.AppSettings.MAIL;
                    this.xrWeb.Text = Commons.AppSettings.WEB;
                }
                this.t = p;
                switch (ft)
                {
                    case FormType.Offer:
                        this.DisplayName = t.GemiAdi.Replace("/", "").Replace("\\", "") + " - " + L.TeklifVermeTutanagi + " (2) - " + t.Tarih.ToString("yyyy-MM-dd");
                        this.xrFormTitle.Text = "TEKLİF VERME TUTANAĞI / DOCUMENT OF OFFER";
                        this.xrFormRevNo.Text = Commons.AppSettings.TEKLIF_VERME_FORMU;
                        this.xrPayment.Text = "PAYMENT: " + t.OdemeSekli;
                        this.xrDelivery.Text = "DELIVERY: " + t.TeslimSuresi;
                        this.xrNote.Text = "NOTE: " + t.Aciklama;
                        break;
                    case FormType.Delivery:
                        this.DisplayName = t.GemiAdi.Replace("/", "").Replace("\\", "") + " - " + L.TeslimVermeTutanagi + " (2) - " + t.Tarih.ToString("yyyy-MM-dd");
                        this.xrFormTitle.Text = "MAZLEME TESLİM TUTANAĞI / DOCUMENT OF DELIVERY";
                        this.xrFormRevNo.Text = Commons.AppSettings.MALZEME_TESLIM_FORMU;

                        this.xrPayment.Dispose();
                        this.xrDelivery.Dispose();
                        this.xrNote.Dispose();

                        this.xrFormRevNo.LocationFloat = new DevExpress.Utils.PointFloat(9.999935F, 9.999974F);
                        this.xrReferans.LocationFloat = new DevExpress.Utils.PointFloat(406.1256F, 9.999974F);
                        this.ReportFooter.HeightF = 35F;
                        break;
                }
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
                Commons.Status(Commons.GetErrorCode("RFR", 2) + ex.Message);
            }
            finally
            {
                Commons.Loaded();
            }
        }
    }
}
