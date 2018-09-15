using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BAYMYO.MultiSQLClient;

namespace EasySupply
{
    public partial class TeklifDetay : IDisposable
    {
        #region ---IDisposable Members---
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

        private float m_Kur1;
        private float m_Kur2;

        #region ---Properties/Field - Özellikler/Alanlar---
        private Int64 m_ID;
        public Int64 ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }
        private Int64 m_TeklifID;
        public Int64 TeklifID
        {
            get { return m_TeklifID; }
            set { m_TeklifID = value; }
        }
        private int m_StokID;
        public int StokID
        {
            get { return m_StokID; }
            set { m_StokID = value; }
        }
        private int m_KategoriID;
        public int KategoriID
        {
            get { return m_KategoriID; }
            set { m_KategoriID = value; }
        }
        private int m_FirmaID;
        public int FirmaID
        {
            get { return m_FirmaID; }
            set { m_FirmaID = value; }
        }
        private string m_FirmaAdi;
        public string FirmaAdi
        {
            get { return m_FirmaAdi; }
            set { m_FirmaAdi = value; }
        }
        private string m_UrunAdi;
        public string UrunAdi
        {
            get { return m_UrunAdi; }
            set { m_UrunAdi = value; }
        }
        private float m_BirimFiyati;
        public float BirimFiyati
        {
            get { return m_BirimFiyati; }
            set { m_BirimFiyati = value; }
        }
        private float m_KarOrani;
        public float KarOrani
        {
            get { return m_KarOrani; }
            set { m_KarOrani = value; }
        }
        private float m_Miktar;
        public float Miktar
        {
            get { return m_Miktar; }
            set { m_Miktar = value; }
        }
        private string m_Birim;
        public string Birim
        {
            get { return m_Birim; }
            set { m_Birim = value; }
        }
        private float m_Adet;
        public float Adet
        {
            get { return m_Adet; }
            set { m_Adet = value; }
        }
        private float m_Kdv;
        public float Kdv
        {
            get { return m_Kdv; }
            set { m_Kdv = value; }
        }
        // Özel Alanlar
        private Stok m_StokObject;
        public Stok StokObject
        {
            get { return m_StokObject; }
        }
        private Firma m_FirmaObject;
        public Firma FirmaObject
        {
            get { return m_FirmaObject; }
        }
        private int m_SiraNo = 0;
        public int SiraNo
        {
            get { return m_SiraNo; }
            set { m_SiraNo = value; }
        }
        public float BirimFiyatiTutar
        {
            get { return this.m_BirimFiyati * this.m_Adet; }
        }
        public float BirimFiyatiKur1
        {
            get { return this.m_BirimFiyati / this.m_Kur1; }
        }
        public float BirimFiyatiKur2
        {
            get { return this.m_BirimFiyati / this.m_Kur2; }
        }
        public float SatisFiyati
        {
            get { return (this.m_BirimFiyati + (this.m_BirimFiyati * this.m_KarOrani)); }
        }
        public float SatisFiyatiKur1
        {
            get { return SatisFiyati / this.m_Kur1; }
        }
        public float SatisFiyatiKur2
        {
            get { return SatisFiyati / this.m_Kur2; }
        }
        public float SatisTutar
        {
            get { return this.SatisFiyati * this.m_Adet; }
        }
        public float SatisTutarKur1
        {
            get { return this.SatisFiyatiKur1 * this.m_Adet; }
        }
        public float SatisTutarKur2
        {
            get { return this.SatisFiyatiKur2 * this.m_Adet; }
        }
        #endregion

        public TeklifDetay()
        {
            this.m_Kur1 = Commons.Kur1;
            this.m_Kur2 = Commons.Kur2;
        }

        public TeklifDetay(int pSiraNo, Int64 pID, Int64 pTeklifID, int pStokID, int pKategoriID, int pFirmaID, string pFirmaAdi, string pUrunAdi, float pBirimFiyati, float pKarOrani, float pMiktar, string pBirim, float pAdet, float pKdv, float pKur1, float pKur2)
        {
            this.m_SiraNo = pSiraNo;
            this.m_ID = pID;
            this.m_TeklifID = pTeklifID;
            this.m_StokID = pStokID;
            this.m_KategoriID = pKategoriID;
            this.m_FirmaID = pFirmaID;
            this.m_FirmaAdi = pFirmaAdi;
            this.m_UrunAdi = pUrunAdi;
            this.m_BirimFiyati = pBirimFiyati;
            this.m_KarOrani = pKarOrani;
            this.m_Miktar = pMiktar;
            this.m_Birim = pBirim;
            this.m_Adet = pAdet;
            this.m_Kdv = pKdv;
            this.m_Kur1 = pKur1;
            this.m_Kur2 = pKur2;
            if (this.m_StokID > 0)
                this.m_StokObject = StokMethods.GetStok(this.m_StokID);
            else
                this.m_StokObject = new Stok();
            if (this.m_FirmaID > 0)
            {
                this.m_FirmaObject = FirmaMethods.GetFirma(this.m_FirmaID);
                this.m_FirmaAdi = this.m_FirmaObject.Adi;
            }
            else
            {
                this.m_FirmaObject = new Firma();
                this.m_FirmaObject.Adi = this.FirmaAdi;
                this.m_FirmaObject.Telefon = " --- ";
                this.m_FirmaObject.Adres = " --- ";
            }
        }
    }

    public partial class TeklifDetayMethods
    {
        public static TeklifDetay GetTeklifDetay(Int64 pID)
        {
            TeklifDetay rvTeklifDetay = new TeklifDetay();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from TeklifDetay where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", pID, MSqlDbType.BigInt);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        int siraNo = 0;
                        while (IDR.Read())
                            rvTeklifDetay = new TeklifDetay(++siraNo, MConvert.NullToInt64(IDR["ID"]), MConvert.NullToInt64(IDR["TeklifID"]), MConvert.NullToInt(IDR["StokID"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToInt(IDR["FirmaID"]), MConvert.NullToString(IDR["FirmaAdi"]), MConvert.NullToString(IDR["UrunAdi"]), MConvert.NullToFloat(IDR["BirimFiyati"]), MConvert.NullToFloat(IDR["KarOrani"]), MConvert.NullToFloat(IDR["Miktar"]), MConvert.NullToString(IDR["Birim"]), MConvert.NullToFloat(IDR["Adet"]), MConvert.NullToFloat(IDR["Kdv"]), 0, 0);
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
            return rvTeklifDetay;
        }
        public static TeklifDetay GetTeklifDetay(TeklifDetay p)
        {
            TeklifDetay rvTeklifDetay = new TeklifDetay();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from TeklifDetay where TeklifID=@TeklifID and StokID=@StokID and UrunAdi=@UrunAdi", conneciton))
                {
                    cmd.Parameters.Add("TeklifID", p.TeklifID, MSqlDbType.BigInt);
                    cmd.Parameters.Add("StokID", p.StokID, MSqlDbType.Int);
                    cmd.Parameters.Add("UrunAdi", p.UrunAdi, MSqlDbType.NVarChar);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        int siraNo = 0;
                        while (IDR.Read())
                            rvTeklifDetay = new TeklifDetay(++siraNo, MConvert.NullToInt64(IDR["ID"]), MConvert.NullToInt64(IDR["TeklifID"]), MConvert.NullToInt(IDR["StokID"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToInt(IDR["FirmaID"]), MConvert.NullToString(IDR["FirmaAdi"]), MConvert.NullToString(IDR["UrunAdi"]), MConvert.NullToFloat(IDR["BirimFiyati"]), MConvert.NullToFloat(IDR["KarOrani"]), MConvert.NullToFloat(IDR["Miktar"]), MConvert.NullToString(IDR["Birim"]), MConvert.NullToFloat(IDR["Adet"]), MConvert.NullToFloat(IDR["Kdv"]), 0, 0);
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
            return rvTeklifDetay;
        }

        public static List<TeklifDetay> GetSelect(Teklif p)
        {
            List<TeklifDetay> rvTeklifDetay = new List<TeklifDetay>();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select * from TeklifDetay where TeklifID=@TeklifID order by ID asc", conneciton))
                {
                    cmd.Parameters.Add("TeklifID", p.ID, MSqlDbType.BigInt);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        int siraNo = 0;
                        while (IDR.Read())
                            rvTeklifDetay.Add(new TeklifDetay(++siraNo, MConvert.NullToInt64(IDR["ID"]), MConvert.NullToInt64(IDR["TeklifID"]), MConvert.NullToInt(IDR["StokID"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToInt(IDR["FirmaID"]), MConvert.NullToString(IDR["FirmaAdi"]), MConvert.NullToString(IDR["UrunAdi"]), MConvert.NullToFloat(IDR["BirimFiyati"]), MConvert.NullToFloat(IDR["KarOrani"]), MConvert.NullToFloat(IDR["Miktar"]), MConvert.NullToString(IDR["Birim"]), MConvert.NullToFloat(IDR["Adet"]), MConvert.NullToFloat(IDR["Kdv"]), p.Kur1, p.Kur2));
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
            return rvTeklifDetay;
        }

        public static int Insert(TeklifDetay p)
        {
            using (TeklifDetay temp = TeklifDetayMethods.GetTeklifDetay(p))
            {
                if (temp != null & temp.ID > 0)
                {
                    if (temp.Equals(p.Adet))
                        return 1;
                    if (System.Windows.Forms.MessageBox.Show(string.Format("{0} isimli üründen sepetinizde '{1}' adet var! Ürünün sepetteki adetini '{2}' adet olarak deðiþtirmek istiyormusunuz?", temp.UrunAdi, temp.Adet, p.Adet), "Uyarý", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        temp.Adet = p.Adet;
                        return TeklifDetayMethods.Update(temp);
                    }
                    else
                        return 0;
                }
            }
            int rowsAffected = 0;
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "insert into TeklifDetay (TeklifID,StokID,KategoriID,FirmaID,FirmaAdi,UrunAdi,BirimFiyati,KarOrani,Miktar,Birim,Adet,Kdv) values(@TeklifID,@StokID,@KategoriID,@FirmaID,@FirmaAdi,@UrunAdi,@BirimFiyati,@KarOrani,@Miktar,@Birim,@Adet,@Kdv)", conneciton))
                {
                    cmd.Parameters.Add("TeklifID", p.TeklifID, MSqlDbType.BigInt);
                    cmd.Parameters.Add("StokID", p.StokID, MSqlDbType.Int);
                    cmd.Parameters.Add("KategoriID", p.KategoriID, MSqlDbType.Int);
                    cmd.Parameters.Add("FirmaID", p.FirmaID, MSqlDbType.Int);
                    if (p.FirmaID > 0)
                        cmd.Parameters.Add("FirmaAdi", DBNull.Value, MSqlDbType.NVarChar);
                    else
                        cmd.Parameters.Add("FirmaAdi", MConvert.NullToString(p.FirmaAdi).ToUpper(), MSqlDbType.NVarChar);
                    cmd.Parameters.Add("UrunAdi", p.UrunAdi.Trim(), MSqlDbType.NVarChar);
                    cmd.Parameters.Add("BirimFiyati", p.BirimFiyati, MSqlDbType.Float);
                    cmd.Parameters.Add("KarOrani", p.KarOrani, MSqlDbType.Float);
                    cmd.Parameters.Add("Miktar", p.Miktar, MSqlDbType.Float);
                    cmd.Parameters.Add("Birim", p.Birim, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Adet", p.Adet, MSqlDbType.Float);
                    cmd.Parameters.Add("Kdv", p.Kdv, MSqlDbType.Float);
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Open:
                        conneciton.Close();
                        break;
                }
            }
            return rowsAffected;
        }
        public static int Update(TeklifDetay p)
        {
            int rowsAffected = 0;
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "Update TeklifDetay SET FirmaAdi=@FirmaAdi,UrunAdi=@UrunAdi,BirimFiyati=@BirimFiyati,KarOrani=@KarOrani,Miktar=@Miktar,Birim=@Birim,Adet=@Adet,Kdv=@Kdv WHERE ID=@ID", conneciton))
                {
                    if (p.FirmaID > 0)
                        cmd.Parameters.Add("FirmaAdi", DBNull.Value, MSqlDbType.NVarChar);
                    else
                        cmd.Parameters.Add("FirmaAdi", MConvert.NullToString(p.FirmaAdi).ToUpper(), MSqlDbType.NVarChar);
                    cmd.Parameters.Add("UrunAdi", p.UrunAdi.Trim(), MSqlDbType.NVarChar);
                    cmd.Parameters.Add("BirimFiyati", p.BirimFiyati, MSqlDbType.Float);
                    cmd.Parameters.Add("KarOrani", p.KarOrani, MSqlDbType.Float);
                    cmd.Parameters.Add("Miktar", p.Miktar, MSqlDbType.Float);
                    cmd.Parameters.Add("Birim", p.Birim, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Adet", p.Adet, MSqlDbType.Float);
                    cmd.Parameters.Add("Kdv", p.Kdv, MSqlDbType.Float);
                    cmd.Parameters.Add("ID", p.ID, MSqlDbType.Int);
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Open:
                        conneciton.Close();
                        break;
                }
            }
            return rowsAffected;
        }
        public static int Delete(Int64 pID)
        {
            int rowsAffected = 0;
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from TeklifDetay where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", pID, MSqlDbType.BigInt);
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Open:
                        conneciton.Close();
                        break;
                }
            }
            return rowsAffected;
        }
        public static int Delete(TeklifDetay p)
        {
            int rowsAffected = 0;
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from TeklifDetay where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", p.ID, MSqlDbType.BigInt);
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Open:
                        conneciton.Close();
                        break;
                }
            }
            return rowsAffected;
        }
    }
}
