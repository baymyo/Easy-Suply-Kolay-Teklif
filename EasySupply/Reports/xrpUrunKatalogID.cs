using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace EasySupply
{
    public partial class xrpUrunKatalogID : DevExpress.XtraReports.UI.XtraReport
    {
        public System.Collections.Generic.List<UrunKatalog> Data { set { this.urunKatalogBindingSource.DataSource = value; } }

        public xrpUrunKatalogID()
        {
            InitializeComponent();
            try
            {
                if (Commons.ExpariedDay <= 10)
                    this.Watermark.Text = "CREATED BY TRIAL VERSION!";
                else
                    this.Watermark.Text = string.Empty;
                Commons.Loading("Belge hazırlanıyor. ..");
                this.DisplayName = "PRODUCT CATALOG - CODE - " + DateTime.Now.ToString("yyyy-MM-dd");
                #region --- Header ---
                if (Commons.AppSettings.IS_IMAGE_HEADER)
                {
                    this.reportHeaderBand1.HeightF = 225f;
                    foreach (XRControl item in this.reportHeaderBand1.Controls)
                        switch (BAYMYO.UI.Converts.NullToString(item.Tag))
                        {
                            case "T":
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

                    this.xrTitle_TR.BackColor = Commons.DESC_TR_BACKCOLOR;
                    this.xrTitle_TR.ForeColor = Commons.DESC_TR_FORECOLOR;
                    this.xrTitle_EN.BackColor = Commons.DESC_EN_BACKCOLOR;
                    this.xrTitle_EN.ForeColor = Commons.DESC_EN_FORECOLOR;

                    this.xrTitle_TR.Text = Commons.AppSettings.DESC_TR;
                    this.xrTitle_EN.Text = Commons.AppSettings.DESC_EN;
                    this.xrOfficePhone.Text = Commons.AppSettings.OFISPHONE;
                    this.xrFax.Text = Commons.AppSettings.FAX;
                    this.xrGsm.Text = Commons.AppSettings.GSM;
                    this.xrAddress.Text = Commons.AppSettings.ADDRESS;
                    this.xrMail.Text = Commons.AppSettings.MAIL;
                    this.xrWeb.Text = Commons.AppSettings.WEB;
                    this.xrFormRevNo.Text = Commons.AppSettings.URUN_KATALOG_FORMU;
                }
                this.xrhSalesPrice.Text = string.Format("Sales Price ({0}) ({1}) ({2})",
                    Commons.AppSettings.DEFAULT_CURRENCY.Code,
                    Commons.AppSettings.CROSS_CURRENCY_1.Code,
                    Commons.AppSettings.CROSS_CURRENCY_2.Code);
                #endregion
                this.xrKur0.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tutar", Commons.Kur0FormatCustom ) });
                this.xrKur1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TutarKur1", Commons.Kur1FormatCustom ) });
                this.xrKur2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TutarKur2", Commons.Kur2FormatCustom ) });
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("RFR", 6) + ex.Message);
            }
            finally
            {
                Commons.Loaded();
            }
        }
    }
}
