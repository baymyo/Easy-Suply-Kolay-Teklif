using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace EasySupply
{
    public partial class xrpTeklifFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public Teklif t;
        public System.Collections.Generic.List<TeklifDetay> Data { set { this.teklifDetayBindingSource.DataSource = value; } }

        public xrpTeklifFormu(Teklif p, FormType ft, float grandTotal, float discountTotal)
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
                    this.reportHeaderBand1.HeightF = 285f;
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

                    this.xrDESC_TR.BackColor = Commons.DESC_TR_BACKCOLOR;
                    this.xrDESC_TR.ForeColor = Commons.DESC_TR_FORECOLOR;
                    this.xrDESC_EN.BackColor = Commons.DESC_EN_BACKCOLOR;
                    this.xrDESC_EN.ForeColor = Commons.DESC_EN_FORECOLOR;

                    this.xrHeaderTitle.Text = Commons.AppSettings.HEADER_TITLE;
                    this.xrDESC_TR.Text = Commons.AppSettings.DESC_TR;
                    this.xrDESC_EN.Text = Commons.AppSettings.DESC_EN;
                    this.xrOfficePhone.Text = Commons.AppSettings.OFISPHONE;
                    this.xrFax.Text = Commons.AppSettings.FAX;
                    this.xrGsm.Text = Commons.AppSettings.GSM;
                    this.xrAddress.Text = Commons.AppSettings.ADDRESS;
                    this.xrMail.Text = Commons.AppSettings.MAIL;
                    this.xrWeb.Text = Commons.AppSettings.WEB;
                }
                this.t = p;
                this.ghDicount.Visible = this.xrDiscount.Visible = (t.Iskonto > 0);
                if (!this.xrDiscount.Visible)
                {
                    this.ghDeliveryExpenses.LocationFloat = new DevExpress.Utils.PointFloat(445.33F, 20.00001F);
                    this.xrDeliveryExpenses.LocationFloat = new DevExpress.Utils.PointFloat(593.81F, 20.00008F);
                    this.ghGrandTotal.LocationFloat = new DevExpress.Utils.PointFloat(445.33F, 40.00003F);
                    this.xrGrandTotals.LocationFloat = new DevExpress.Utils.PointFloat(593.81F, 40.00009F);
                }
                else
                    this.ghDicount.Text = "DISCOUNT (" + t.Iskonto.ToString("%##0") + ")";
                switch (ft)
                {
                    case FormType.Offer:
                        this.DisplayName = t.GemiAdi.Replace("/", "").Replace("\\", "") + " - " + L.TeklifVermeTutanagi + " - " + t.Tarih.ToString("yyyy-MM-dd");
                        this.xrFormTitle.Text = "TEKLİF VERME TUTANAĞI / DOCUMENT OF OFFER";
                        this.xrFormRevNo.Text = Commons.AppSettings.TEKLIF_VERME_FORMU;
                        this.xrPayment.Text = "PAYMENT: " + t.OdemeSekli;
                        this.xrDelivery.Text = "DELIVERY: " + t.TeslimSuresi;
                        this.xrNote.Text = "NOTE: " + t.Aciklama;
                        switch (t.ParaBirimi)
                        {
                            case "KUR1":
                            case "KUR2":
                                this.xrDeliverySignature.Text = "OFFERED BY\nUNSIGNED DUE TO ELECTRONICALLY PREPARED.";   // TARAFINDAN SUNULAN
                                break;
                            default:
                                switch (Commons.AppSettings.DEFAULT_CURRENCY.Code)
                                {
                                    case "TRY":
                                        this.xrDeliverySignature.Text = "OFFERED BY\nELEKTRONİK ORTAMDA HAZIRLANDIĞI İÇİN İMZASIZDIR.";   // TARAFINDAN SUNULAN
                                        break;
                                    default:
                                        this.xrDeliverySignature.Text = "OFFERED BY\nUNSIGNED DUE TO ELECTRONICALLY PREPARED.";   // TARAFINDAN SUNULAN
                                        break;
                                }
                                break;
                        }
                        this.xrOfferSignature.Text = "ORDERED BY";      // TARAFINDAN SİPARİŞ
                        break;
                    case FormType.Delivery:
                        this.DisplayName = t.GemiAdi.Replace("/", "").Replace("\\", "") + " - " + L.TeslimVermeTutanagi + " - " + t.Tarih.ToString("yyyy-MM-dd");
                        this.xrFormTitle.Text = "MAZLEME TESLİM TUTANAĞI / DOCUMENT OF DELIVERY";
                        this.xrFormRevNo.Text = Commons.AppSettings.MALZEME_TESLIM_FORMU;

                        this.xrPayment.Dispose();
                        this.xrDelivery.Dispose();
                        this.xrNote.Dispose();

                        this.xrDeliverySignature.Text = "TAKEN DELIVERY BY / TESLİM ALAN";   // TESLİM ALAN
                        this.xrOfferSignature.Text = "DELIVERED BY / TESLİM EDEN";           // TESLİM EDEN

                        this.xrDeliverySignature.LocationFloat = new DevExpress.Utils.PointFloat(9.999935F, 85.999974F);
                        this.xrFormRevNo.LocationFloat = new DevExpress.Utils.PointFloat(9.999935F, 145F);
                        this.xrOfferSignature.LocationFloat = new DevExpress.Utils.PointFloat(406.1256F, 85.999974F);
                        this.xrReferans.LocationFloat = new DevExpress.Utils.PointFloat(406.1256F, 145F);
                        this.ReportFooter.HeightF = 190F;
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
                string
                    currencyFormat = Commons.Kur0Format,
                    currencyFormatCustom = Commons.Kur0FormatCustom;
                float deliveryExpenses = t.TasimaUcreti;
                switch (t.ParaBirimi)
                {
                    case "KUR1":
                        currencyFormat = Commons.Kur1Format;
                        currencyFormatCustom = Commons.Kur1FormatCustom;
                        this.xrSatisFiyati.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "SatisFiyatiKur1", currencyFormatCustom) });
                        this.xrSatisTutari.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "SatisTutarKur1", currencyFormatCustom) });
                        this.xrTotals.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "SatisTutarKur1") });
                        this.xrTotals.Summary.FormatString = currencyFormatCustom;
                        deliveryExpenses = (t.TasimaUcreti / t.Kur1);
                        if (this.xrDiscount.Visible)
                            this.xrDiscount.Text = (discountTotal / t.Kur1).ToString(currencyFormat);
                        this.xrGrandTotals.Text = grandTotal.ToString(currencyFormat);
                        break;
                    case "KUR2":
                        currencyFormat = Commons.Kur2Format;
                        currencyFormatCustom = Commons.Kur2FormatCustom;
                        this.xrSatisFiyati.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "SatisFiyatiKur2", currencyFormatCustom) });
                        this.xrSatisTutari.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "SatisTutarKur2", currencyFormatCustom) });
                        this.xrTotals.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "SatisTutarKur2") });
                        deliveryExpenses = (t.TasimaUcreti / t.Kur2);
                        if (this.xrDiscount.Visible)
                            this.xrDiscount.Text = (discountTotal / t.Kur2).ToString(currencyFormat);
                        this.xrGrandTotals.Text = grandTotal.ToString(currencyFormat);
                        break;
                    default:
                        this.xrSatisFiyati.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "SatisFiyati", currencyFormatCustom) });
                        this.xrSatisTutari.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", null, "SatisTutar", currencyFormatCustom) });
                        if (this.xrDiscount.Visible)
                            this.xrDiscount.Text = discountTotal.ToString(currencyFormat);
                        this.xrGrandTotals.Text = grandTotal.ToString(currencyFormat);
                        break;
                }
                if (t.TasimaUcreti > 0)
                    this.xrDeliveryExpenses.Text = deliveryExpenses.ToString(currencyFormat);
                else
                    this.xrDeliveryExpenses.Text = t.TasimaUcretiNotu;
                this.xrTotals.Summary.FormatString = currencyFormatCustom;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("RFR", 1) + ex.Message);
            }
            finally
            {
                Commons.Loaded();
            }
        }
    }
}
