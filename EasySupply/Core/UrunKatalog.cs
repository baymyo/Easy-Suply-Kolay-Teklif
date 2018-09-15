using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BAYMYO.MultiSQLClient;
using System.Linq;

namespace EasySupply
{
    public partial class UrunKatalog : IDisposable
    {
        #region ---IDisposable Members---
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

        #region ---Properties/Field - Özellikler/Alanlar---
        private int m_StokID;
        public int StokID
        {
            get { return m_StokID; }
        }
        private int m_KategoriID;
        public int KategoriID
        {
            get { return m_KategoriID; }
        }
        private int m_UrunID;
        public int UrunID
        {
            get { return m_UrunID; }
        }
        private int m_FirmaID;
        public int FirmaID
        {
            get { return m_FirmaID; }
        }
        private string m_KategoriAdi;
        public string KategoriAdi
        {
            get { return m_KategoriAdi; }
        }
        private string m_ImpaCode;
        public string ImpaCode
        {
            get { return m_ImpaCode; }
        }
        private string m_UrunAdi;
        public string UrunAdi
        {
            get { return m_UrunAdi; }
        }
        private string m_FirmaAdi;
        public string FirmaAdi
        {
            get { return m_FirmaAdi; }
        }
        private string m_Telefon;
        public string Telefon
        {
            get { return m_Telefon; }
        }
        private float m_Miktar;
        public float Miktar
        {
            get { return m_Miktar; }
        }
        private string m_Birim;
        public string Birim
        {
            get { return m_Birim; }
        }
        private float m_Kdv;
        public float Kdv
        {
            get { return m_Kdv; }
        }
        private float m_Fiyat;
        public float Fiyat
        {
            get { return m_Fiyat; }
            set { m_Fiyat = value; }
        }
        private float m_KarOran;
        public float KarOran
        {
            get { return m_KarOran; }
        }
        private DateTime m_GuncellemeTarihi;
        public DateTime GuncellemeTarihi
        {
            get { return m_GuncellemeTarihi; }
        }
        private byte m_Period;
        public byte Period
        {
            get { return m_Period; }
        }
        // ÖZEL TUTAR HESAPLAMA KOLONUMUZU YAZDIK!
        private int m_SiraNo = 0;
        public int SiraNo
        {
            get { return m_SiraNo; }
            set { m_SiraNo = value; }
        }
        private float m_Adet;
        public float Adet
        {
            get { return m_Adet; }
            set { m_Adet = value; }
        }
        public float FiyatKur1
        {
            get { return this.m_Fiyat / Commons.Kur1; }
        }
        public float FiyatKur2
        {
            get { return this.m_Fiyat / Commons.Kur2; }
        }
        public float Tutar
        {
            get { return this.m_Fiyat + (this.m_Fiyat * this.m_KarOran); }
        }
        public float TutarKur1
        {
            get { return Tutar / Commons.Kur1; }
        }
        public float TutarKur2
        {
            get { return Tutar / Commons.Kur2; }
        }
        private string m_DisplayName;
        public string DisplayName
        {
            get { return m_DisplayName; }
        }
        private bool m_Updated;
        public bool Updated
        {
            get { return m_Updated; }
            set { m_Updated = value; }
        }
        #endregion

        public UrunKatalog()
        {
        }

        public UrunKatalog(int pSiraNo, UrunKatalog p)
        {
            this.m_SiraNo = pSiraNo;
            this.m_StokID = p.StokID;
            this.m_KategoriID = p.KategoriID;
            this.m_UrunID = p.UrunID;
            this.m_FirmaID = p.FirmaID;
            this.m_KategoriAdi = p.KategoriAdi;
            this.m_ImpaCode = p.ImpaCode;
            this.m_UrunAdi = p.UrunAdi;
            this.m_FirmaAdi = p.FirmaAdi;
            this.m_Telefon = p.Telefon;
            this.m_Miktar = p.Miktar;
            this.m_Birim = p.Birim;
            this.m_Kdv = p.Kdv;
            this.m_Fiyat = p.Fiyat;
            this.m_KarOran = p.KarOran;
            this.m_GuncellemeTarihi = p.GuncellemeTarihi;
            this.m_Period = p.Period;
            this.m_Updated = p.Updated;
        }
        public UrunKatalog(int pSiraNo, int pStokID, int pKategoriID, int pUrunID, int pFirmaID, string pKategoriAdi, string pImpaCode, string pUrunAdi, string pFirmaAdi, string pTelefon, float pMiktar, string pBirim, float pKdv, float pFiyat, float pKarOran, DateTime pGuncellemeTarihi, byte pPeriod)
        {
            try
            {
                this.m_SiraNo = pSiraNo;
                this.m_StokID = pStokID;
                this.m_KategoriID = pKategoriID;
                this.m_UrunID = pUrunID;
                this.m_FirmaID = pFirmaID;
                this.m_KategoriAdi = pKategoriAdi;
                this.m_ImpaCode = pImpaCode;
                this.m_UrunAdi = pUrunAdi;
                this.m_FirmaAdi = pFirmaAdi;
                this.m_Telefon = pTelefon;
                this.m_Miktar = pMiktar;
                this.m_Birim = pBirim;
                this.m_Kdv = pKdv;
                this.m_Fiyat = pFiyat;
                this.m_KarOran = pKarOran;
                this.m_GuncellemeTarihi = pGuncellemeTarihi;
                this.m_Period = pPeriod;
                this.m_Updated = (DateTime.Now - pGuncellemeTarihi).Days >= pPeriod;
                this.m_DisplayName = string.Format("{0} | FÝRMA: {1} | MÝKTAR: {2:##0.00} {3} | ALIÞ: {4:###,###,##0.00} TL - $ {5:###,##0.00} - € {6:###,##0.00} | SATIÞ: {7:###,###,##0.00} TL - $ {8:###,##0.00} - € {9:###,##0.00}",
                    pUrunAdi, pFirmaAdi, pMiktar, pBirim, this.m_Fiyat, this.FiyatKur1, this.FiyatKur2, this.Tutar, this.TutarKur1, this.TutarKur2);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("UKT", 1) + ex.Message);
            }
        }

        public override string ToString()
        {
            return this.m_DisplayName;
        }
    }

    public partial class UrunKatalogMethods
    {
        public static List<UrunKatalog> GetUrunKatalog()
        {
            List<UrunKatalog> rvUrunKatalog = new List<UrunKatalog>();
            try
            {
                using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
                {
                    switch (conneciton.State)
                    {
                        case System.Data.ConnectionState.Closed:
                            conneciton.Open();
                            break;
                    }
                    using (MCommand cmd = new MCommand(CommandType.Text, "SELECT * FROM UrunKatalog ORDER BY KategoriAdi ASC, UrunAdi ASC, Fiyat ASC", conneciton))
                    {
                        using (IDataReader IDR = cmd.ExecuteReader())
                        {
                            int siraNo = 0;
                            while (IDR.Read())
                                rvUrunKatalog.Add(new UrunKatalog(++siraNo, MConvert.NullToInt(IDR["StokID"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToInt(IDR["UrunID"]), MConvert.NullToInt(IDR["FirmaID"]), MConvert.NullToString(IDR["KategoriAdi"]), MConvert.NullToString(IDR["ImpaCode"]), MConvert.NullToString(IDR["UrunAdi"]), MConvert.NullToString(IDR["FirmaAdi"]), MConvert.NullToString(IDR["Telefon"]), MConvert.NullToFloat(IDR["Miktar"]), MConvert.NullToString(IDR["Birim"]), MConvert.NullToFloat(IDR["Kdv"]), MConvert.NullToFloat(IDR["Fiyat"]), MConvert.NullToFloat(IDR["KarOran"]), MConvert.NullToDateTime(IDR["GuncellemeTarihi"]), MConvert.NullToByte(IDR["Period"])));
                            IDR.Close();
                        }
                    }
                    switch (conneciton.State)
                    {
                        case System.Data.ConnectionState.Open:
                            conneciton.Close();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("UKT", 2) + ex.Message);
            }
            return rvUrunKatalog;
        }
        public static List<UrunKatalog> GetEnUcuzUrunler()
        {
            List<UrunKatalog> tumUrunler = GetUrunKatalog();
            try
            {
                int i = 0;
                var result = (from t1 in tumUrunler
                              where t1.StokID == (from t2 in tumUrunler
                                                  where t2.UrunID == t1.UrunID
                                                  orderby t2.Fiyat ascending
                                                  select new { t2.StokID }).Take(1).ElementAt(0).StokID
                              select new UrunKatalog(++i, t1) { }).ToList();
                return result;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("UKT", 3) + ex.Message);
            }
            return tumUrunler;
        }
    }
}
