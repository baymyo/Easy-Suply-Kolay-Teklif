using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BAYMYO.MultiSQLClient;

namespace EasySupply
{
    public partial class Urun : IDisposable
    {
        #region ---IDisposable Members---
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

        #region ---Properties/Field - Özellikler Alanlar---
        private int m_ID;
        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }
        private string m_Kod;
        public string Kod
        {
            get { return m_Kod; }
            set { m_Kod = value; }
        }
        private int m_KategoriID;
        public int KategoriID
        {
            get { return m_KategoriID; }
            set { m_KategoriID = value; }
        }
        private string m_Adi;
        public string Adi
        {
            get { return m_Adi; }
            set { m_Adi = value; }
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
        private float m_Kdv;
        public float Kdv
        {
            get { return m_Kdv; }
            set { m_Kdv = value; }
        }
        private DateTime m_Tarih;
        public DateTime Tarih
        {
            get { return m_Tarih; }
            set { m_Tarih = value; }
        }
        #endregion

        public Urun()
        {
        }
        public Urun(int pID, string pKod, int pKategoriID, string pAdi, float pMiktar, string pBirim, float pKdv, DateTime pTarih)
        {
            this.m_ID = pID;
            this.m_Kod = pKod;
            this.m_KategoriID = pKategoriID;
            this.m_Adi = pAdi;
            this.m_Miktar = pMiktar;
            this.m_Birim = pBirim;
            this.m_Kdv = pKdv;
            this.m_Tarih = pTarih;
        }
    }

    public partial class UrunMethods
    {
        public static Urun GetUrun(int pID)
        {
            Urun rvUrun = new Urun();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1 * from Urun where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", pID, MSqlDbType.Int);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvUrun = new Urun(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToString(IDR["Adi"]), MConvert.NullToFloat(IDR["Miktar"]), MConvert.NullToString(IDR["Birim"]), MConvert.NullToFloat(IDR["Kdv"]), MConvert.NullToDateTime(IDR["Tarih"]));
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
            return rvUrun;
        }
        public static Urun GetUrun(Urun p)
        {
            Urun rvUrun = new Urun();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1 * from Urun where KategoriID=@KategoriID and Adi=@Adi", conneciton))
                {
                    cmd.Parameters.Add("KategoriID", p.KategoriID, MSqlDbType.Int);
                    cmd.Parameters.Add("Adi", p.Adi, MSqlDbType.NVarChar);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvUrun = new Urun(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToString(IDR["Adi"]), MConvert.NullToFloat(IDR["Miktar"]), MConvert.NullToString(IDR["Birim"]), MConvert.NullToFloat(IDR["Kdv"]), MConvert.NullToDateTime(IDR["Tarih"]));
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
            return rvUrun;
        }
        public static Urun GetLast(int pKategoriID)
        {
            Urun rvUrun = new Urun();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from Urun where KategoriID=@KategoriID order by Kod desc", conneciton))
                {
                    cmd.Parameters.Add("KategoriID", pKategoriID, MSqlDbType.Int);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvUrun = new Urun(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToString(IDR["Adi"]), MConvert.NullToFloat(IDR["Miktar"]), MConvert.NullToString(IDR["Birim"]), MConvert.NullToFloat(IDR["Kdv"]), MConvert.NullToDateTime(IDR["Tarih"]));
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
            return rvUrun;
        }

        public static List<Urun> GetSelect()
        {
            List<Urun> rvUrun = new List<Urun>();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select * from Urun", conneciton))
                {
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvUrun.Add(new Urun(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToString(IDR["Adi"]), MConvert.NullToFloat(IDR["Miktar"]), MConvert.NullToString(IDR["Birim"]), MConvert.NullToFloat(IDR["Kdv"]), MConvert.NullToDateTime(IDR["Tarih"])));
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
            return rvUrun;
        }
        public static List<Urun> GetSelect(int pKategoriID)
        {
            List<Urun> rvUrun = new List<Urun>();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select * from Urun where KategoriID=@KategoriID", conneciton))
                {
                    cmd.Parameters.Add("KategoriID", pKategoriID, MSqlDbType.Int);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvUrun.Add(new Urun(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToString(IDR["Adi"]), MConvert.NullToFloat(IDR["Miktar"]), MConvert.NullToString(IDR["Birim"]), MConvert.NullToFloat(IDR["Kdv"]), MConvert.NullToDateTime(IDR["Tarih"])));
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
            return rvUrun;
        }

        public static int Insert(Urun p)
        {
            using (Urun temp = UrunMethods.GetUrun(p))
            {
                if (temp != null & temp.ID > 0)
                    return temp.ID;
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
                using (MCommand cmd = new MCommand(CommandType.Text, "insert into Urun (Kod,KategoriID,Adi,Miktar,Birim,Kdv,Tarih) values(@Kod,@KategoriID,@Adi,@Miktar,@Birim,@Kdv,@Tarih)", conneciton))
                {
                    cmd.Parameters.Add("Kod", p.Kod, MSqlDbType.VarChar);
                    cmd.Parameters.Add("KategoriID", p.KategoriID, MSqlDbType.Int);
                    cmd.Parameters.Add("Adi", p.Adi, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Miktar", p.Miktar, MSqlDbType.Float);
                    cmd.Parameters.Add("Birim", p.Birim, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Kdv", p.Kdv, MSqlDbType.Float);
                    cmd.Parameters.Add("Tarih", p.Tarih, MSqlDbType.DateTime);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT @@IDENTITY";
                        rowsAffected = MConvert.NullToInt(cmd.ExecuteScalar());
                    }
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
        public static int Update(Urun p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "Update Urun SET Kod=@Kod,KategoriID=@KategoriID,Adi=@Adi,Miktar=@Miktar,Birim=@Birim,Kdv=@Kdv,Tarih=@Tarih where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("Kod", p.Kod, MSqlDbType.VarChar);
                    cmd.Parameters.Add("KategoriID", p.KategoriID, MSqlDbType.Int);
                    cmd.Parameters.Add("Adi", p.Adi, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Miktar", p.Miktar, MSqlDbType.Float);
                    cmd.Parameters.Add("Birim", p.Birim, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Kdv", p.Kdv, MSqlDbType.Float);
                    cmd.Parameters.Add("Tarih", p.Tarih, MSqlDbType.DateTime);
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
        public static int Delete(Urun p)
        {
            int rowsAffected = 0;
            if (StokMethods.GetUrunCount(p.ID) > 0)
            {
                System.Windows.Forms.MessageBox.Show(string.Format(L.UrunStokdaVarSilinmez, p.Adi), "Warning");
                return 0;
            }
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Urun where ID=@ID", conneciton))
                {
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
    }
}