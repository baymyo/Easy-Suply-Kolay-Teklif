using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BAYMYO.MultiSQLClient;

namespace EasySupply
{
    public partial class UrunRaporCollection : CollectionBase, IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public UrunRapor this[int index]
        {
            get { return (UrunRapor)this.List[index]; }
            set { this.List[index] = value; }
        }

        public object SyncRoot { get { return this.List.SyncRoot; } }

        public int Add(UrunRapor obj)
        {
            return this.List.Add(obj);
        }

        public void Insert(int index, UrunRapor obj)
        {
            this.List.Insert(index, obj);
        }

        public bool Contains(UrunRapor obj)
        {
            return this.List.Contains(obj);
        }

        public int IndexOf(UrunRapor obj)
        {
            return this.List.IndexOf(obj);
        }

        public void Remove(UrunRapor obj)
        {
            this.List.Remove(obj);
        }
    }

    public partial class UrunRapor : IDisposable
    {
        #region ---IDisposable Members---
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

        #region ---Properties/Field - Özellikler Alanlar---
        private float m_Fiyat;
        public float Fiyat
        {
            get { return m_Fiyat; }
        }
        private float m_KarOran;
        public float KarOran
        {
            get { return m_KarOran; }
        }
        private string m_FirmaKod;
        public string FirmaKod
        {
            get { return m_FirmaKod; }
        }
        private string m_UrunAdi;
        public string UrunAdi
        {
            get { return m_UrunAdi; }
        }
        private string m_KategoriAdi;
        public string KategoriAdi
        {
            get { return m_KategoriAdi; }
        }
        public float Tutar
        {
            get { return m_Fiyat + (m_Fiyat * m_KarOran); }
        }
        #endregion

        public UrunRapor()
        {
        }

        public UrunRapor(float pFiyat, float pKarOran, string pFirmaKod, string pUrunAdi, string pKategoriAdi)
        {
            this.m_Fiyat = pFiyat;
            this.m_KarOran = pKarOran;
            this.m_FirmaKod = pFirmaKod;
            this.m_UrunAdi = pUrunAdi;
            this.m_KategoriAdi = pKategoriAdi;
        }
    }

    public partial class UrunRaporMethods
    {
        public static UrunRaporCollection GetSelect()
        {
            UrunRaporCollection rvUrunRapor = new UrunRaporCollection();
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
                    using (MCommand cmd = new MCommand(CommandType.Text, "select * from UrunRapor order by KategoriAdi, Fiyat", conneciton))
                    {
                        using (IDataReader IDR = cmd.ExecuteReader())
                        {
                            while (IDR.Read())
                                rvUrunRapor.Add(new UrunRapor(MConvert.NullToFloat(IDR["Fiyat"]), MConvert.NullToFloat(IDR["KarOran"]), MConvert.NullToString(IDR["FirmaKod"]), MConvert.NullToString(IDR["UrunAdi"]), MConvert.NullToString(IDR["KategoriAdi"])));
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
                Commons.Status(Commons.GetErrorCode("URP", 1) + ex.Message);
            }
            return rvUrunRapor;
        }
    }
}
