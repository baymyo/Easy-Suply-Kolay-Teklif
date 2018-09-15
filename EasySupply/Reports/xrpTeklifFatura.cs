using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace EasySupply
{
    public partial class xrpTeklifFatura : DevExpress.XtraReports.UI.XtraReport
    {
        public System.Collections.Generic.List<Fatura> Data { set { this.faturaBindingSource.DataSource = value; } }

        public xrpTeklifFatura(Teklif t, float grandTotal, float taxTotal, float discount, float discountTotal)
        {
            InitializeComponent();

            try
            {
                if (Commons.ExpariedDay <= 10)
                    this.Watermark.Text = "CREATED BY TRIAL VERSION!";
                else
                    this.Watermark.Text = string.Empty;
                this.DisplayName = t.GemiAdi.Replace("/", "").Replace("\\", "") + " - " + L.Fatura + " - " + t.Tarih.ToString("yyyy-MM-dd");
                this.xrLogo.Image = Commons.HeaderFactura;
                string
                    currencyFormat = Commons.Kur0Format,
                    currencyCode = Commons.Kur0Code;
                switch (t.ParaBirimi)
                {
                    case "KUR1":
                        currencyFormat = Commons.Kur1Format;
                        currencyCode = Commons.Kur1Code;
                        this.xrBirimFiyat.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { 
                        new DevExpress.XtraReports.UI.XRBinding("Text", null, "BirimFiyat", Commons.Kur1FormatCustom) });
                        this.xrTutar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                        new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tutar", Commons.Kur1FormatCustom)});
                        break;
                    case "KUR2":
                        currencyFormat = Commons.Kur2Format;
                        currencyCode = Commons.Kur2Code;
                        this.xrBirimFiyat.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { 
                        new DevExpress.XtraReports.UI.XRBinding("Text", null, "BirimFiyat", Commons.Kur2FormatCustom) });
                        this.xrTutar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                        new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tutar", Commons.Kur2FormatCustom)});
                        break;
                    default:
                        this.xrBirimFiyat.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { 
                        new DevExpress.XtraReports.UI.XRBinding("Text", null, "BirimFiyat", Commons.Kur0FormatCustom) });
                        this.xrTutar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                        new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tutar", Commons.Kur0FormatCustom)});
                        break;
                }
                switch (currencyCode)
                {
                    case "TRY":
                        this.xrYaziylaTutar.Text = "Yalnız: " + Commons.NumberToText(grandTotal + taxTotal);
                        break;
                    case "EUR":
                        this.xrYaziylaTutar.Text = "Single: " + Commons.NumberToDeutchText(grandTotal + taxTotal);
                        break;
                    default:
                        this.xrYaziylaTutar.Text = "Single: " + Commons.NumberToEnglishText(grandTotal + taxTotal);
                        break;
                }
                if (discountTotal <= 0)
                {
                    this.ghGrandTotal.Visible = this.xrGenelToplam.Visible = false;

                    this.ghDicount.Text = this.ghSubTotal.Text;
                    this.ghSubTotal.Text = this.ghTax.Text;
                    this.ghTax.Text = this.ghGrandTotal.Text;

                    this.xrIskonto.Text = grandTotal.ToString(currencyFormat);
                    this.xrAraToplam.Text = taxTotal.ToString(currencyFormat);
                    this.xrKdv.Text = (grandTotal + taxTotal).ToString(currencyFormat);
                }
                else
                {
                    this.ghDicount.Text = "İSKONTO " + discount.ToString("%##0");
                    this.xrIskonto.Text = discountTotal.ToString(currencyFormat);
                    this.xrAraToplam.Text = (grandTotal).ToString(currencyFormat);
                    this.xrKdv.Text = taxTotal.ToString(currencyFormat);
                    this.xrGenelToplam.Text = (grandTotal + taxTotal).ToString(currencyFormat);
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("RFT", 1) + ex.Message);
            }
        }
    }
}
