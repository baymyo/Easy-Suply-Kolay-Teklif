using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Web;

namespace EasySupply
{
    public class Settings
    {
        public string COMPANY_NAME { get; set; }
        public string COMPANY_DESC { get; set; }
        public string HEADER_TITLE { get; set; }
        public string DESC_TR { get; set; }
        public string DESC_EN { get; set; }
        public string OFISPHONE { get; set; }
        public string GSM { get; set; }
        public string FAX { get; set; }
        public string ADDRESS { get; set; }
        public string MAIL { get; set; }
        public string WEB { get; set; }

        public string PREPAREDBY { get; set; }
        public string UNITS { get; set; }

        // COLOR
        public string HEADER_BACKCOLOR { get; set; }
        public string HEADER_BORDERCOLOR { get; set; }
        public string HEADER_TITLECOLOR { get; set; }
        public string HEADER_DESCCOLOR { get; set; }
        public string COMPANY_FORECOLOR { get; set; }
        public string DESC_TR_BACKCOLOR { get; set; }
        public string DESC_EN_BACKCOLOR { get; set; }
        public string DESC_TR_FORECOLOR { get; set; }
        public string DESC_EN_FORECOLOR { get; set; }

        public string TEKLIF_VERME_FORMU { get; set; }
        public string MALZEME_TESLIM_FORMU { get; set; }
        public string SIPARIS_TOPLAMA_FORMU { get; set; }
        public string SIPARIS_LISTESI_FORMU { get; set; }
        public string URUN_KATALOG_FORMU { get; set; }

        public CurrentPriceFormat DEFAULT_CURRENCY { get; set; }
        public CurrentPriceFormat CROSS_CURRENCY_1 { get; set; }
        public CurrentPriceFormat CROSS_CURRENCY_2 { get; set; }

        public bool IS_IMAGE_HEADER { get; set; }

        public string DATABASE { get; set; }

        public Settings()
        {
            try
            {
                this.COMPANY_NAME = "COMPANY NAME";
                this.COMPANY_DESC = "TİCARET VE SANAYİ LTD. ŞTİ.";
                this.HEADER_TITLE = "GENERAL SHIP SERVICE";
                this.DESC_TR = "KUMANYA/MOTOR MALZ/KABYN MALZ/ELEKTRİK MALZ/GÜVENLİK MALZ/KİMYASALLAR/IMO SEMBOLLERİ";
                this.DESC_EN = "PROVISION/ENGINE STORES/CABIN STORES/ELECTRICAL STORES/SAFETY EQUIPMENT/CHEMICALS/IMO SEMBOLS";
                this.OFISPHONE = "+90 326 61X XX XX / +90 326 61X XX XX";
                this.GSM = "+90 536 4XX 3X 2X / +90 532 7XX 8X 9X";
                this.FAX = "+90 326 61X 5X 4X / TELEX: 3XXX1";
                this.ADDRESS = "Çay Mah. Raifpaşa Cad. No: 18 İSKENDERUN/TÜRKİYE";
                this.MAIL = "info@baymyo.com / market@baymyo.com";
                this.WEB = "www.baymyo.com";

                this.PREPAREDBY = "MUSTAFA YAŞAR ÖZKAN,GÖKHAN ODUNCU,EMRE SEÇER";
                this.UNITS = "pcs,pck,box,tin,jar,kg,adet,ltr";

                this.TEKLIF_VERME_FORMU = "FR: 08 - RV: 01";
                this.MALZEME_TESLIM_FORMU = "FR: 29 - RV: 01";
                this.SIPARIS_TOPLAMA_FORMU = "FR: 30 - RV: 00";
                this.SIPARIS_LISTESI_FORMU = "FR: 32 - RV: 00";
                this.URUN_KATALOG_FORMU = "FR: 33 - RV: 00";

                this.HEADER_BACKCOLOR = Commons.RGBToString(System.Drawing.Color.Gainsboro);
                this.HEADER_BORDERCOLOR = Commons.RGBToString(System.Drawing.Color.Silver);
                this.HEADER_TITLECOLOR = this.HEADER_DESCCOLOR = "64,64,64";
                this.COMPANY_FORECOLOR = this.DESC_TR_BACKCOLOR = "0,0,64";
                this.DESC_EN_BACKCOLOR = Commons.RGBToString(System.Drawing.Color.Navy);
                this.DESC_TR_FORECOLOR = this.DESC_EN_FORECOLOR = Commons.RGBToString(System.Drawing.Color.White);

                this.DEFAULT_CURRENCY = CurrentPriceFormat.GetCurrency("TRY");
                this.CROSS_CURRENCY_1 = CurrentPriceFormat.GetCurrency("USD");
                this.CROSS_CURRENCY_2 = CurrentPriceFormat.GetCurrency("EUR");

                this.IS_IMAGE_HEADER = false;

                this.DATABASE = Commons.FolderPath + "EasySupplyDatabase.mdb";
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("STG", 1) + ex.Message);
            }
        }
    }

    internal class jSonData
    {
        public static string SettingFile = ConfigurationManager.AppSettings["SettingsFileName"].ToString().Replace("{FilePath}", Commons.FolderPath);

        public static bool CreateFile(object data)
        {
            try
            {
                if (data != null)
                {
                    System.Windows.Forms.Application.DoEvents();
                    System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    string jsondata = javaScriptSerializer.Serialize(data);
                    if (!string.IsNullOrEmpty(jsondata))
                    {
                        BAYMYO.UI.FileIO.CreateDirectory(Commons.FolderPath);
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(SettingFile))
                        {
                            sw.Write(jsondata);
                            sw.Close();
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("STG", 2) + ex.Message);
                return false;
            }
        }
        public static bool ReadFile()
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(SettingFile))
                {
                    string data = sr.ReadToEnd();
                    if (!string.IsNullOrEmpty(data))
                    {
                        System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                        Commons.AppSettings = javaScriptSerializer.Deserialize(data, typeof(Settings)) as Settings;
                        sr.Close();
                        return true;
                    }
                }
                Commons.AppSettings = new Settings();
                return false;
            }
            catch (Exception ex)
            {
                Commons.AppSettings = new Settings();
                Commons.Status(Commons.GetErrorCode("STG", 3) + ex.Message);
                return false;
            }
        }
    }
}
