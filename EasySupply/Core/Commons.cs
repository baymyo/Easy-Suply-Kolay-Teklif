using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Security.Cryptography;
using System.Linq;

namespace EasySupply
{
    public enum FormType
    {
        None,
        Offer,
        Delivery
    }
    public enum FileType
    {
        None,
        PDF,
        Excel,
        ExcelX,
        Word
    }
    public enum TableNames
    {
        None,
        Kategori,
        Urun,
        Firma,
        Stok,
        Teklif,
        Doviz
    }
    public enum QuestionType
    {
        None,
        UrunKatalogu,
        TeklifFormu,
        TeslimFormu,
        SiparisToplama,
        SipariMaliyet,
        VeritabaniOnar,
        StokGirisi
    }

    internal static class Commons
    {
        internal const string PrivateMessage = "-&-BAYMYO-YAZILIM-URUNUDUR-";

        #region --- Loading Methods ---
        private static DevExpress.Utils.WaitDialogForm dlg = null;
        public static void Loading(string description)
        {
            if (dlg == null)
                dlg = new DevExpress.Utils.WaitDialogForm(description, "Lütfen bekleyiniz!");
            else
                dlg.Caption = description;
        }
        public static void Loaded()
        {
            if (dlg != null) dlg.Close();
        }
        #endregion

        #region --- My Authentication Key ---
        internal static void AuthenticationKey()
        {
            try
            {
                ManagementClass mgmt = new ManagementClass("Win32_Processor");
                ManagementObjectCollection objCol = mgmt.GetInstances();
                foreach (ManagementObject obj in objCol)
                    if (m_MySerialKey == null)
                        m_MySerialKey = ComputeHashAlgorithm(obj.Properties["ProcessorId"].Value.ToString(), HashAlgorithm.Create());
            }
            catch (Exception)
            {
                m_MySerialKey = "CODE-ERROR";
            }
        }
        #endregion

        #region --- Private Properties ---
        private static readonly string CryptoKey = "baymyo";
        internal static string LicenseKeyFile { get { return FolderPath + "LicenseKey.myo"; } }
        private static string m_MySerialKey;
        internal static string MySerialKey { get { return m_MySerialKey; } }
        private static string m_GetSerialKey;
        internal static string GetSerialKey { get { return m_GetSerialKey; } }
        private static DateTime m_StartDate;
        internal static DateTime StartDate { get { return m_StartDate; } }
        private static DateTime m_ExpariedDate;
        internal static DateTime ExpariedDate { get { return m_ExpariedDate; } }
        private static DateTime m_LastDate;
        internal static DateTime LastDate { get { return m_LastDate; } }
        internal static int ExpariedDay { get; set; }
        internal static bool IsLicenseValid { get; set; }
        internal static bool IsLicenseLoad { get; set; }
        #endregion

        #region --- Public Properties ---
        public static string Kur0Code { get { return Commons.AppSettings.DEFAULT_CURRENCY.Code; } }
        public static string Kur1Code { get { return Commons.AppSettings.CROSS_CURRENCY_1.Code; } }
        public static string Kur2Code { get { return Commons.AppSettings.CROSS_CURRENCY_2.Code; } }

        public static string Kur0Format { get { return Commons.AppSettings.DEFAULT_CURRENCY.Format; } }
        public static string Kur1Format { get { return Commons.AppSettings.CROSS_CURRENCY_1.Format; } }
        public static string Kur2Format { get { return Commons.AppSettings.CROSS_CURRENCY_2.Format; } }

        public static string Kur0FormatCustom { get { return "{0:" + Commons.AppSettings.DEFAULT_CURRENCY.Format + "}"; } }
        public static string Kur1FormatCustom { get { return "{0:" + Commons.AppSettings.CROSS_CURRENCY_1.Format + "}"; } }
        public static string Kur2FormatCustom { get { return "{0:" + Commons.AppSettings.CROSS_CURRENCY_2.Format + "}"; } }

        public static string Kur0Symbol { get { return Commons.AppSettings.DEFAULT_CURRENCY.Symbol; } }
        public static string Kur1Symbol { get { return Commons.AppSettings.CROSS_CURRENCY_1.Symbol; } }
        public static string Kur2Symbol { get { return Commons.AppSettings.CROSS_CURRENCY_2.Symbol; } }

        private static float m_Kur1 = 1;
        public static float Kur1
        {
            get { return Commons.m_Kur1; }
        }
        private static float m_Kur2 = 1;
        public static float Kur2
        {
            get { return Commons.m_Kur2; }
        }

        public static Settings AppSettings { get; set; }
        public static string ConnectionStringName { get; set; }

        internal static void GetFromFiles()
        {
            try
            {
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(CryptoKey + m_MySerialKey.Split('-')[0], new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                if (System.IO.File.Exists(LicenseKeyFile))
                {
                    byte[] buffer = null;
                    using (System.IO.FileStream sr = new System.IO.FileStream(LicenseKeyFile, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        buffer = new byte[sr.Length];
                        sr.Read(buffer, 0, buffer.Length);
                        sr.Close();
                    }
                    m_GetSerialKey = System.Text.Encoding.Unicode.GetString(Decrypt(buffer, pdb.GetBytes(32), pdb.GetBytes(16)));
                }
            }
            catch (Exception)
            {
                m_GetSerialKey = "ERROR_KEY_FILE";
            }
        }

        public static string AppFilePath { get { return System.Windows.Forms.Application.StartupPath + "\\Files\\"; } }
        public static string FolderPath { get { return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Easy Supply System\\"; } }
        public static string DataBasePath { get { return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Easy Supply System\\DB\\"; } }

        public static string HeaderFacturaFile { get { return FolderPath + "faturaHeader.bmp"; } }
        public static string HeaderImageFile { get { return FolderPath + "formHeader.bmp"; } }
        public static string LogoFile { get { return FolderPath + "companyLogo.bmp"; } }
        public static string LogoOtherFile { get { return FolderPath + "otherLogoHeader.bmp"; } }

        public static System.Drawing.Image HeaderFactura { get; set; }
        public static System.Drawing.Image HeaderImage { get; set; }
        public static System.Drawing.Image LogoCompany { get; set; }
        public static System.Drawing.Image LogoOther { get; set; }

        public static System.Drawing.Color HEADER_BACKCOLOR { get; set; }
        public static System.Drawing.Color HEADER_BORDERCOLOR { get; set; }
        public static System.Drawing.Color HEADER_TITLECOLOR { get; set; }
        public static System.Drawing.Color HEADER_DESCCOLOR { get; set; }
        public static System.Drawing.Color COMPANY_FORECOLOR { get; set; }
        public static System.Drawing.Color DESC_TR_BACKCOLOR { get; set; }
        public static System.Drawing.Color DESC_EN_BACKCOLOR { get; set; }
        public static System.Drawing.Color DESC_TR_FORECOLOR { get; set; }
        public static System.Drawing.Color DESC_EN_FORECOLOR { get; set; }
        #endregion

        #region --- Color AND Image ---
        public static System.Drawing.Color RGBToColor(string color)
        {
            try
            {
                string[] argb = color.Split(',');
                return System.Drawing.Color.FromArgb(BAYMYO.UI.Converts.NullToInt(argb[0]), BAYMYO.UI.Converts.NullToInt(argb[1]), BAYMYO.UI.Converts.NullToInt(argb[2]));
            }
            catch (Exception)
            {
                return new System.Drawing.Color();
            }
        }
        public static string RGBToString(System.Drawing.Color color)
        {
            try
            {
                return string.Format("{0},{1},{2}", color.R, color.G, color.B);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 1) + ex.Message);
                return "0,0,0";
            }
        }
        public static void ColorLoad()
        {
            try
            {
                if (Commons.AppSettings.HEADER_BACKCOLOR.Contains(","))
                    Commons.HEADER_BACKCOLOR = RGBToColor(Commons.AppSettings.HEADER_BACKCOLOR);
                if (Commons.AppSettings.HEADER_BORDERCOLOR.Contains(","))
                    Commons.HEADER_BORDERCOLOR = RGBToColor(Commons.AppSettings.HEADER_BORDERCOLOR);
                if (Commons.AppSettings.HEADER_TITLECOLOR.Contains(","))
                    Commons.HEADER_TITLECOLOR = RGBToColor(Commons.AppSettings.HEADER_TITLECOLOR);
                if (Commons.AppSettings.HEADER_DESCCOLOR.Contains(","))
                    Commons.HEADER_DESCCOLOR = RGBToColor(Commons.AppSettings.HEADER_DESCCOLOR);
                if (Commons.AppSettings.COMPANY_FORECOLOR.Contains(","))
                    Commons.COMPANY_FORECOLOR = RGBToColor(Commons.AppSettings.COMPANY_FORECOLOR);
                if (Commons.AppSettings.DESC_TR_BACKCOLOR.Contains(","))
                    Commons.DESC_TR_BACKCOLOR = RGBToColor(Commons.AppSettings.DESC_TR_BACKCOLOR);
                if (Commons.AppSettings.DESC_TR_FORECOLOR.Contains(","))
                    Commons.DESC_TR_FORECOLOR = RGBToColor(Commons.AppSettings.DESC_TR_FORECOLOR);
                if (Commons.AppSettings.DESC_EN_BACKCOLOR.Contains(","))
                    Commons.DESC_EN_BACKCOLOR = RGBToColor(Commons.AppSettings.DESC_EN_BACKCOLOR);
                if (Commons.AppSettings.DESC_EN_FORECOLOR.Contains(","))
                    Commons.DESC_EN_FORECOLOR = RGBToColor(Commons.AppSettings.DESC_EN_FORECOLOR);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 2) + ex.Message);
            }
        }
        public static void ImageLoad()
        {
            try
            {
                if (System.IO.File.Exists(Commons.HeaderImageFile))
                    using (System.Drawing.Bitmap i = new System.Drawing.Bitmap(Commons.HeaderImageFile))
                    {
                        Commons.HeaderImage = BAYMYO.UI.Converts.ByteArrayToImage(BAYMYO.UI.FileIO.ResizeImage(i, 790));
                    }
                if (System.IO.File.Exists(Commons.HeaderFacturaFile))
                    using (System.Drawing.Bitmap i = new System.Drawing.Bitmap(Commons.HeaderFacturaFile))
                    {
                        Commons.HeaderFactura = BAYMYO.UI.Converts.ByteArrayToImage(BAYMYO.UI.FileIO.ResizeImage(i, 790));
                    }
                if (System.IO.File.Exists(Commons.LogoFile))
                    using (System.Drawing.Bitmap i = new System.Drawing.Bitmap(Commons.LogoFile))
                    {
                        Commons.LogoCompany = BAYMYO.UI.Converts.ByteArrayToImage(BAYMYO.UI.FileIO.ResizeImage(i, 140));
                    }
                if (System.IO.File.Exists(Commons.LogoOtherFile))
                    using (System.Drawing.Bitmap i = new System.Drawing.Bitmap(Commons.LogoOtherFile))
                    {
                        Commons.LogoOther = BAYMYO.UI.Converts.ByteArrayToImage(BAYMYO.UI.FileIO.ResizeImage(i, 140));
                    }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 3) + ex.Message);
            }
        }
        #endregion

        #region --- Private Methods ---
        static private bool ValidateDate(string p)
        {
            try
            {
                p = p.Split('=')[1];
                m_StartDate = BAYMYO.UI.Converts.NullToDateTime(string.Format("{0}/{1}/20{2} 00:00:00", p.Substring(1, 2), p.Substring(11, 2), p.Substring(6, 2)));
                m_ExpariedDate = BAYMYO.UI.Converts.NullToDateTime(string.Format("{0}/{1}/20{2} 00:00:00", p.Substring(8, 2), p.Substring(3, 2), p.Substring(13, 2)));
                TimeSpan ts = m_ExpariedDate - m_LastDate;
                bool isOkey = (m_StartDate <= DateTime.Now) & (m_LastDate <= m_ExpariedDate);
                if (isOkey)
                    ExpariedDay = ts.Days;
                else
                    ExpariedDay = -1;
                return isOkey;
            }
            catch (Exception)
            {
                m_StartDate = DateTime.Now;
                m_ExpariedDate = m_StartDate;
                return false;
            }
        }
        internal static bool ValidateApplication()
        {
            bool rValid = false;
            try
            {
                Commons.AuthenticationKey();
                Commons.GetFromFiles();
                if (ValidateDate(m_GetSerialKey))
                {
                    rValid = m_GetSerialKey.StartsWith(Commons.ComputeSHA1(GetMachineID() + PrivateMessage + System.Windows.Forms.Application.ProductVersion));
                    if (!rValid)
                        return false;
                    else if (ExpariedDay <= 0)
                        rValid = false;
                    else if (rValid & ExpariedDay <= 10 & !IsLicenseLoad)
                    {
                        xFrmTrial t = new xFrmTrial();
                        t.Name = "frmTrialMesaj";
                        t.Mesaj = "Demo kullanım için '" + ExpariedDay + " günlük' kullanım süreniz kaldı! Programı satın almak için aşağıdaki butona tıklayın!";
                        Commons.IsOpenForm(t);
                    }
                    else if (rValid & ExpariedDay <= 20 & !IsLicenseLoad)
                    {
                        xFrmTrial t = new xFrmTrial();
                        t.Name = "frmTrialMesaj";
                        t.Mesaj = "Tam sürüm lisans sürenizin bitmesi için '" + (ExpariedDay - 10) + " gün kullanım süreniz kaldı! Lisans sürenizi uzatmak için aşağıdaki butona tıklayın!";
                        Commons.IsOpenForm(t);
                    }
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                IsLicenseValid = rValid;
                IsLicenseLoad = false;
            }
            return rValid;
        }
        internal static void GetLastAccessTime()
        {
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(Commons.AppSettings.DATABASE);
                if (fi.LastWriteTime > fi.LastAccessTime)
                    m_LastDate = fi.LastWriteTime;
                else
                    m_LastDate = fi.LastAccessTime;
                if (m_LastDate < DateTime.Now)
                    m_LastDate = DateTime.Now;
                fi = null;
            }
            catch (Exception)
            {
                m_LastDate = DateTime.Now;
            }
        }
        internal static DateTime GetLastWriteTime()
        {
            DateTime n;
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(Commons.AppSettings.DATABASE);
                n = fi.LastWriteTime;
                fi = null;
            }
            catch (Exception)
            {
                n = DateTime.Now.AddMinutes(-1);
            }
            return n;
        }

        static private string GetMachineID()
        {
            return m_MySerialKey.Replace("-", "%").ToUpper();
        }
        static private string ComputeSHA1(string textToHash)
        {
            SHA1CryptoServiceProvider SHA1 = new SHA1CryptoServiceProvider();
            byte[] byteH = SHA1.ComputeHash(System.Text.Encoding.UTF8.GetBytes(textToHash));
            SHA1.Clear();
            return Convert.ToBase64String(byteH);
        }
        static private string ComputeHashAlgorithm(string text, HashAlgorithm alg)
        {
            byte[] hiddenByte = alg.ComputeHash(System.Text.Encoding.UTF8.GetBytes(text));
            return Convert.ToBase64String(hiddenByte).ToString().Substring(0, 20).Insert(5, "-").Insert(11, "-").Insert(17, "-").ToUpper();
        }
        static private byte[] Decrypt(byte[] enData, byte[] Key, byte[] IV)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(enData, 0, enData.Length);
            cs.Close();
            byte[] deData = ms.ToArray();
            return deData;
        }
        #endregion

        #region --- Number To Text ---
        public static string NumberToText(int n)
        {
            try
            {
                int birler, onlar, yuzler, binler, onbinler, milyonlar;
                birler = n % 10;
                onlar = (n / 10) % 10;
                yuzler = (n / 100) % 10;
                binler = (n / 1000) % 10;
                onbinler = (n / 10000) % 10;
                milyonlar = (n / 100000) % 10;

                string[] birlik = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
                string[] Onluk = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
                string[] Yuzluk = { "", "Yüz", "İkiyüz", "Üçyüz", "Dörtyüz", "Beşyüz", "Altıyüz", "Yediyüz", "Sekizyüz", "Dokuzyüz" };
                string[] binlik = { "", "Bin", "İkibin", "Üçbin", "Dörtbin", "Beşbin", "Altıbin", "Yedibin", "Sekizbin", "Dokuzbin" };
                string[] onbinlik = { "", "Onbin", "Yirmibin", "Otuzbin", "Kırkbin", "Ellibin", "Altmışbin", "Yetmişbin", "Seksenbin", "Doksanbin" };
                string[] milyon = { "", "Bir Milyon", "İki Milyon", "Üç Milyon", "Dört Milyon", "Beş Milyon", "Altı Milyon", "Yedi Milyon", "Sekiz Milyon", "Dokuz Milyon" };

                return milyon[milyonlar] + " " + onbinlik[onbinler] + " " + binlik[binler] + " " + Yuzluk[yuzler] + " " + Onluk[onlar] + " " + birlik[birler];
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 4) + ex.Message);
            }
            return string.Empty;
        }
        public static string NumberToEnglishText(int n)
        {
            try
            {
                int birler, onlar, yuzler, binler, onbinler, milyonlar;
                birler = n % 10;
                onlar = (n / 10) % 10;
                yuzler = (n / 100) % 10;
                binler = (n / 1000) % 10;
                onbinler = (n / 10000) % 10;
                milyonlar = (n / 100000) % 10;

                string[] birlik = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                string[] Onluk = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                string[] Yuzluk = { "", "One Hundred", "Two Hundred", "Three Hundred", "Four Hundred", "Five Hundred", "Six Hundred", "Seven Hundred", "Eight Hundred", "Nine Hundred" };
                string[] binlik = { "", "One Thousand", "Two Thousand", "Three Thousand", "Four Thousand", "Five Thousand", "Six Thousand", "Seven Thousand", "Eight Thousand", "Nine Thousand" };
                string[] onbinlik = { "", "Ten Thousand", "Twenty Thousand", "Thirty Thousand", "Forty Thousand", "Fifty Thousand", "Sixty Thousand", "Seventy Thousand", "Eighty Thousand", "Ninety Thousand" };
                string[] milyon = { "", "A Million", "Two Million", "Three Million", "Four Million", "Five Million", "Six Million", "Seven Million", "Eight Million", "Nine Million" };

                return milyon[milyonlar] + " " + onbinlik[onbinler] + " " + binlik[binler] + " " + Yuzluk[yuzler] + " " + Onluk[onlar] + " " + birlik[birler];
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 5) + ex.Message);
            }
            return string.Empty;
        }
        public static string NumberToText(double d)
        {
            try
            {
                string a = d.ToString("#0.00");
                string[] textArray = (a.Contains(".")) ? a.Split('.') : a.Split(',');
                if (textArray.Length > 0)
                {
                    int ilkSayi = int.Parse(textArray[0]), ikinciSayi = int.Parse(textArray[1]);
                    string yaziIle = Commons.NumberToText(ilkSayi) + " TL";
                    if (ikinciSayi > 0)
                        yaziIle += Commons.NumberToText(ikinciSayi) + " Kuruş";
                    return yaziIle;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 6) + ex.Message);
            }
            return string.Empty;
        }
        public static string NumberToEnglishText(double d)
        {
            try
            {
                string a = d.ToString("#0.00");
                string[] textArray = (a.Contains(".")) ? a.Split('.') : a.Split(',');
                if (textArray.Length > 0)
                {
                    int ilkSayi = int.Parse(textArray[0]), ikinciSayi = int.Parse(textArray[1]);
                    string yaziIle = Commons.NumberToEnglishText(ilkSayi) + " Dollars";
                    if (ikinciSayi > 0)
                        yaziIle += Commons.NumberToEnglishText(ikinciSayi) + " Cent";
                    return yaziIle;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 7) + ex.Message);
            }
            return string.Empty;
        }
        public static string NumberToDeutchText(double d)
        {
            try
            {
                string a = d.ToString("#0.00");
                string[] textArray = (a.Contains(".")) ? a.Split('.') : a.Split(',');
                if (textArray.Length > 0)
                {
                    int ilkSayi = int.Parse(textArray[0]), ikinciSayi = int.Parse(textArray[1]);
                    string yaziIle = Commons.NumberToEnglishText(ilkSayi) + " Euro";
                    if (ikinciSayi > 0)
                        yaziIle += Commons.NumberToEnglishText(ikinciSayi) + " Cent";
                    return yaziIle;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 8) + ex.Message);
            }
            return string.Empty;
        }
        #endregion

        internal static string GetErrorCode(string prefix, byte code)
        {
            return "[" + prefix + code.ToString("000") + "] ";
        }
        internal static bool ConnectionStates()
        {
            bool rv = false;
            try
            {
                Commons.ConnectionStringName = string.Format("Provider=Microsoft.Jet.Oledb.4.0;Data Source={0};Persist Security Info=False;", Commons.AppSettings.DATABASE);
                using (BAYMYO.MultiSQLClient.MConnection cnn = new BAYMYO.MultiSQLClient.MConnection(BAYMYO.MultiSQLClient.MClientProvider.OleDb, Commons.ConnectionStringName))
                {
                    cnn.Open();
                    switch (cnn.State)
                    {
                        case System.Data.ConnectionState.Broken:
                        case System.Data.ConnectionState.Closed:
                        case System.Data.ConnectionState.Fetching:
                            rv = false;
                            break;
                        case System.Data.ConnectionState.Open:
                            rv = true;
                            cnn.Close();
                            break;
                    }
                }
                return rv;
            }
            catch (Exception)
            {
                return false;
            }
        }
        internal static void CurrentDoviz()
        {
            Commons.m_Kur1 = DovizMethods.GetDoviz(System.Data.CommandType.Text, string.Format("select top 1  * from Doviz where Cinsi='{0}' order by Tarih desc", Commons.AppSettings.CROSS_CURRENCY_1.Code), null).Kuru;
            Commons.m_Kur2 = DovizMethods.GetDoviz(System.Data.CommandType.Text, string.Format("select top 1  * from Doviz where Cinsi='{0}' order by Tarih desc", Commons.AppSettings.CROSS_CURRENCY_2.Code), null).Kuru;
            Commons.Update(TableNames.Doviz);
        }
        internal static string CurrencySelected(string p)
        {
            switch (p)
            {
                case "KUR1":
                    return Commons.Kur1Code;
                case "KUR2":
                    return Commons.Kur2Code;
                default:
                    return Commons.Kur0Code;
            }
        }
        public static string GetTax(byte p)
        {
            switch (p.ToString())
            {
                case "2":
                    return "KDV HARİÇ";
                case "3":
                    return "KDV DAHİL";
                default:
                    return "TAX FREE";
            }
        }
        public static System.Data.DataTable GetTax()
        {
            System.Data.DataTable dt = new System.Data.DataTable("Tax");
            dt.Columns.Add("Key", typeof(byte));
            dt.Columns.Add("Value", typeof(string));

            System.Data.DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "TAX FREE";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "KDV HARİÇ";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 3;
            dr[1] = "KDV DAHİL";
            dt.Rows.Add(dr);

            return dt;
        }
        public static System.Data.DataTable GetStatus()
        {
            System.Data.DataTable dt = new System.Data.DataTable("States");
            dt.Columns.Add("Key", typeof(byte));
            dt.Columns.Add("Value", typeof(string));

            System.Data.DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "TEKLİF HAZIRLANIYOR";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "TEKLİF ONAY BEKLİYOR";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 3;
            dr[1] = "TEKLİF ONAYLANDI";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 4;
            dr[1] = "TEKLİF İPTAL EDİLDİ";
            dt.Rows.Add(dr);

            return dt;
        }

        #region --- System Request ---
        public static void CreateDatabase()
        {
            string
                fileName = Commons.AppFilePath + "EasySupplyDatabase.mdb";
            try
            {
                BAYMYO.UI.FileIO.CreateDirectory(Commons.FolderPath);
                if (!System.IO.File.Exists(Commons.AppSettings.DATABASE))
                {
                    System.IO.File.Copy(fileName, Commons.AppSettings.DATABASE);
                    Commons.Status(L.VeritabaniOlusturmaIslemi);
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 9) + ex.Message);
            }
        }
        public static void GeneralImportFile()
        {
            string
                fileName = Commons.AppFilePath + "TFAK.dat",
                desktopName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                System.IO.File.Copy(fileName, desktopName + "\\Excel Import File.xls", true);
                Commons.Status(L.ExcelAktarimDosyasiMesaji);
                System.Windows.Forms.MessageBox.Show(L.ExcelAktarimDosyasiMesaji, "Info");
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 10) + ex.Message);
            }
        }
        public static void ProductImportFile()
        {
            string
                fileName = Commons.AppFilePath + "CTGPRD.dat",
                desktopName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                System.IO.File.Copy(fileName, desktopName + "\\New Products Import File.xls", true);
                Commons.Status(L.ExcelAktarimDosyasiMesaji);
                System.Windows.Forms.MessageBox.Show(L.ExcelAktarimDosyasiMesaji, "Info");
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 11) + ex.Message);
            }
        }
        public static void RestoreHeader()
        {
            try
            {
                BAYMYO.UI.FileIO.CreateDirectory(Commons.FolderPath);
                if (!System.IO.File.Exists(HeaderImageFile))
                    System.IO.File.Copy(AppFilePath + "formHeader.bmp", HeaderImageFile, true);
                if (!System.IO.File.Exists(HeaderFacturaFile))
                    System.IO.File.Copy(AppFilePath + "faturaHeader.bmp", HeaderFacturaFile, true);
                if (!System.IO.File.Exists(LogoFile))
                    System.IO.File.Copy(AppFilePath + "companyLogo.bmp", LogoFile, true);
                Commons.ImageLoad();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 12) + ex.Message);
            }
        }

        public static void BackupDatabase()
        {
            string
                backupFileName = Commons.DataBasePath + DateTime.Now.ToString("yyyy-MM-") + "BackupDatabase.mdb",
                repariFileName = Commons.DataBasePath + "RepairDatabase.mdb";
            try
            {
                BAYMYO.UI.FileIO.CreateDirectory(Commons.DataBasePath);
                //YEDEKLEME YAPMADAN ONCE VERITABANININ YEDEGINI ALIYORUZ!
                if (System.IO.File.Exists(backupFileName))
                    System.IO.File.Delete(backupFileName);
                System.IO.File.Copy(Commons.AppSettings.DATABASE, backupFileName, true);
                //REPAIR ISLEMI
                JRO.JetEngine je = new JRO.JetEngine();
                je.CompactDatabase(ConnectionStringName,
                    string.Format("Provider=Microsoft.Jet.Oledb.4.0;Data Source={0};Jet OLEDB:Engine Type=5", repariFileName));
                //YEDEKLEME YAPILAN DB TEKRAR ALMA ISLEMI
                if (System.IO.File.Exists(backupFileName))
                    System.IO.File.Delete(backupFileName);
                System.IO.File.Move(repariFileName, backupFileName);
                Commons.Status(L.VeritabaniYedeklemeIslemi);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 13) + ex.Message);
            }
        }
        public static void RestoreDatabase()
        {
            string
                backupFileName = Commons.DataBasePath + DateTime.Now.ToString("yyyy-MM-") + "BackupDatabase.mdb";
            try
            {
                if (!System.IO.File.Exists(backupFileName))
                {
                    System.Windows.Forms.OpenFileDialog fd = new System.Windows.Forms.OpenFileDialog();
                    fd.Title = "Veritabanı Seçiniz";
                    fd.Filter = "Backup Database (Access)|*.mdb";
                    switch (fd.ShowDialog())
                    {
                        case System.Windows.Forms.DialogResult.OK:
                        case System.Windows.Forms.DialogResult.Retry:
                        case System.Windows.Forms.DialogResult.Yes:
                            backupFileName = fd.FileName;
                            break;
                    }

                }
                if (System.IO.File.Exists(Commons.AppSettings.DATABASE))
                    System.IO.File.Delete(Commons.AppSettings.DATABASE);
                System.IO.File.Copy(backupFileName, Commons.AppSettings.DATABASE, true);
                Commons.Status(L.VeritabaniGeriAlmaIslemi);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 14) + ex.Message);
            }
        }
        public static void RepairDatabase()
        {
            if (!Commons.ShowBox(QuestionType.VeritabaniOnar))
                return;
            string
                backupFileName = Commons.DataBasePath + DateTime.Now.ToString("yyyy-MM-") + "RepairDatabase.mdb",
                repariFileName = Commons.DataBasePath + "RepairDatabase.mdb";
            try
            {
                BAYMYO.UI.FileIO.CreateDirectory(Commons.DataBasePath);
                //YEDEKLEME YAPMADAN ONCE VERITABANININ YEDEGINI ALIYORUZ!
                if (System.IO.File.Exists(backupFileName))
                    System.IO.File.Delete(backupFileName);
                System.IO.File.Copy(Commons.AppSettings.DATABASE, backupFileName, true);
                //REPAIR ISLEMI
                JRO.JetEngine je = new JRO.JetEngine();
                je.CompactDatabase(ConnectionStringName,
                    string.Format("Provider=Microsoft.Jet.Oledb.4.0;Data Source={0};Jet OLEDB:Engine Type=5", repariFileName));
                //REPAIR YAPILAN DB TEKRAR ALMA ISLEMI
                if (System.IO.File.Exists(Commons.AppSettings.DATABASE))
                    System.IO.File.Delete(Commons.AppSettings.DATABASE);
                System.IO.File.Move(repariFileName, Commons.AppSettings.DATABASE);
                Commons.Status(L.VeritabaniOnarmaIslemi);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 15) + ex.Message);
                System.IO.File.Copy(backupFileName, Commons.AppSettings.DATABASE, true);
            }
        }
        #endregion

        internal static void CreateFile(object form, FileType type)
        {
            try
            {
                System.Windows.Forms.SaveFileDialog sf = new System.Windows.Forms.SaveFileDialog();
                sf.FileName = L.YeniDosyaAdi;
                switch (type)
                {
                    case FileType.PDF:
                        sf.Filter = "PDF Seçiniz|*.pdf";
                        break;
                    case FileType.Excel:
                        sf.Filter = "Excel Seçiniz|*.xls";
                        break;
                    case FileType.ExcelX:
                        sf.Filter = "Excel Seçiniz|*.xlsx";
                        break;
                    case FileType.Word:
                        sf.Filter = "Word Seçiniz|*.rtf";
                        break;
                }
                switch (sf.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                    case System.Windows.Forms.DialogResult.Retry:
                    case System.Windows.Forms.DialogResult.Yes:
                        if (form is xFrmUrunRapor)
                            (form as xFrmUrunRapor).CreateFile(sf.FileName, type);
                        else if (form is xFrmUrun)
                            (form as xFrmUrun).CreateFile(sf.FileName, type);
                        else if (form is xFrmStok)
                            (form as xFrmStok).CreateFile(sf.FileName, type);
                        else if (form is xFrmTeklif)
                            (form as xFrmTeklif).CreateFile(sf.FileName, type);
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 16) + ex.Message);
            }
        }
        internal static void CreateCatalog(List<UrunKatalog> obj)
        {
            try
            {
                using (xFrmCheckList chk = new xFrmCheckList())
                {
                    chk.Text = "Kategori Seçiniz!";
                    chk.DataListCheckhed.ValueMember = "ID";
                    chk.DataListCheckhed.DisplayMember = "Adi";
                    chk.DataListCheckhed.DataSource = KategoriMethods.GetSelect();
                    switch (chk.ShowDialog())
                    {
                        case System.Windows.Forms.DialogResult.OK:
                            int[] ids = new int[chk.DataListCheckhed.CheckedItems.Count];
                            for (int i = 0; i < chk.DataListCheckhed.CheckedItems.Count; i++)
                                ids[i] = int.Parse(chk.DataListCheckhed.CheckedItems[i].ToString());
                            xrpUrunKatalog rptKatalog = new xrpUrunKatalog(Commons.ShowBox(QuestionType.UrunKatalogu));
                            rptKatalog.Data = obj.Where(p => ids.Contains(p.KategoriID)).ToList();
                            rptKatalog.ShowPreview();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 17) + ex.Message);
            }
        }
        internal static void CreateCatalogBarkod(List<UrunKatalog> obj)
        {
            try
            {
                using (xFrmCheckList chk = new xFrmCheckList())
                {
                    chk.Text = "Kategori Seçiniz!";
                    chk.DataListCheckhed.ValueMember = "ID";
                    chk.DataListCheckhed.DisplayMember = "Adi";
                    chk.DataListCheckhed.DataSource = KategoriMethods.GetSelect();
                    switch (chk.ShowDialog())
                    {
                        case System.Windows.Forms.DialogResult.OK:
                            int[] ids = new int[chk.DataListCheckhed.CheckedItems.Count];
                            for (int i = 0; i < chk.DataListCheckhed.CheckedItems.Count; i++)
                                ids[i] = int.Parse(chk.DataListCheckhed.CheckedItems[i].ToString());
                            xrpUrunKatalogID rptKatalog = new xrpUrunKatalogID();
                            rptKatalog.Data = obj.Where(p => ids.Contains(p.KategoriID)).ToList();
                            rptKatalog.ShowPreview();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 18) + ex.Message);
            }
        }

        internal static void Update(TableNames table)
        {
            try
            {
                xFrmStok stokForm = System.Windows.Forms.Application.OpenForms["xFrmStok"] as xFrmStok;
                xFrmHizliStokGirisi stokFormHizli = System.Windows.Forms.Application.OpenForms["xFrmHizliStokGirisi"] as xFrmHizliStokGirisi;
                switch (table)
                {
                    case TableNames.Kategori:
                        if (stokForm != null)
                            stokForm.GetKategoriler();
                        if (stokFormHizli != null)
                            stokFormHizli.GetKategoriler();
                        xFrmUrun urunForm = System.Windows.Forms.Application.OpenForms["xFrmUrun"] as xFrmUrun;
                        if (urunForm != null)
                            urunForm.GetKategoriler();
                        foreach (System.Windows.Forms.Form item in System.Windows.Forms.Application.OpenForms)
                            if (item is xFrmTeklif)
                            {
                                xFrmTeklif teklifForm = item as xFrmTeklif;
                                teklifForm.GetKategoriler();
                            }
                        break;
                    case TableNames.Urun:
                        if (stokForm != null)
                        {
                            stokForm.GetUrunler();
                            stokForm.GetUrunlerForKategori();
                        }
                        if (stokFormHizli != null)
                            stokFormHizli.GetUrunlerForKategori();
                        break;
                    case TableNames.Firma:
                        if (stokForm != null)
                            stokForm.GetFirmalar();
                        if (stokFormHizli != null)
                            stokFormHizli.GetFirmalar();
                        break;
                    case TableNames.Stok:
                        xFrmUrunRapor urunRaporForm = System.Windows.Forms.Application.OpenForms["xFrmUrunRapor"] as xFrmUrunRapor;
                        if (urunRaporForm != null)
                            urunRaporForm.GetUrunRapor();
                        foreach (System.Windows.Forms.Form item in System.Windows.Forms.Application.OpenForms)
                            if (item is xFrmTeklif)
                            {
                                xFrmTeklif teklifForm = item as xFrmTeklif;
                                teklifForm.GetStokListe();
                            }
                        break;
                    case TableNames.Teklif:
                        xFrmTeklifDetay teklifDetayForm = System.Windows.Forms.Application.OpenForms["xFrmTeklifDetay"] as xFrmTeklifDetay;
                        if (teklifDetayForm != null)
                            teklifDetayForm.GetTeklifler();
                        break;
                    case TableNames.Doviz:
                        foreach (System.Windows.Forms.Form item in System.Windows.Forms.Application.OpenForms)
                            if (item is xFrmTeklif)
                            {
                                xFrmTeklif teklifForm = item as xFrmTeklif;
                                teklifForm.GetDoviz();
                            }
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 19) + ex.Message);
            }
        }
        internal static void Status(string message)
        {
            try
            {
                rFrmMain rf = (System.Windows.Forms.Application.OpenForms["rFrmMain"] as rFrmMain);
                if (rf != null)
                {
                    if (message.Contains("[") & message.Contains("]"))
                    {
                        rf.statusLabel.Tag = message;
                        rf.statusLabel.Caption = message + " * " + L.HataBildirimiYap;
                    }
                    else
                    {
                        rf.Tag = null;
                        rf.statusLabel.Caption = message;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 20) + ex.Message);
            }
        }

        internal static void IsOpenForm(DevExpress.XtraEditors.XtraForm p)
        {
            try
            {
                foreach (System.Windows.Forms.Form item in System.Windows.Forms.Application.OpenForms)
                    if (item.Name.Equals(p.Name))
                    {
                        item.Activate();
                        p.Dispose();
                        return;
                    }
                p.Show();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 21) + ex.Message);
            }
        }
        internal static bool ShowBox(QuestionType p)
        {
            try
            {
                using (xFrmMessageBox frm = new xFrmMessageBox())
                {
                    frm.QuestionForm = p;
                    return frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 22) + ex.Message);
                return false;
            }
        }
        internal static bool IsNullOrEmpty(DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dx, System.Windows.Forms.Control.ControlCollection p)
        {
            try
            {
                foreach (System.Windows.Forms.Control item in p)
                {
                    if (item.Tag != null & string.IsNullOrWhiteSpace(item.Text))
                    {
                        dx.SetError(item, L.BosGecilemez);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CMN", 23) + ex.Message);
                return true;
            }
        }

        internal static string CreateImpaCode(object p)
        {
            string rvImpaCode = string.Empty;
            try
            {
                rvImpaCode = BAYMYO.UI.Converts.NullToString(p).Replace(",", "").Replace(".", "").Replace("-", "").Replace(" ", "");
                if (!string.IsNullOrWhiteSpace(rvImpaCode))
                {
                    int outCode = 0;
                    if (int.TryParse(rvImpaCode, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.CurrentCulture, out outCode))
                        return outCode.ToString("00 00 00");
                    else
                    {
                        using (System.Windows.Forms.MaskedTextBox m = new System.Windows.Forms.MaskedTextBox("AA AA AA"))
                        {
                            m.Text = rvImpaCode;
                            rvImpaCode = m.Text;
                        }
                        return rvImpaCode.ToUpper();
                    }
                }
                return rvImpaCode;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}