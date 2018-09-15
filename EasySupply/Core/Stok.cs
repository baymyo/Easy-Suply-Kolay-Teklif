using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BAYMYO.MultiSQLClient;

namespace EasySupply
{
    public partial class Stok : IDisposable
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
        private int m_KategoriID;
        public int KategoriID
        {
            get { return m_KategoriID; }
            set { m_KategoriID = value; }
        }
        private int m_UrunID;
        public int UrunID
        {
            get { return m_UrunID; }
            set { m_UrunID = value; }
        }
        private int m_FirmaID;
        public int FirmaID
        {
            get { return m_FirmaID; }
            set { m_FirmaID = value; }
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
            set { m_KarOran = value; }
        }
        private DateTime m_EklenmeTarihi;
        public DateTime EklenmeTarihi
        {
            get { return m_EklenmeTarihi; }
            set { m_EklenmeTarihi = value; }
        }
        private DateTime m_GuncellemeTarihi;
        public DateTime GuncellemeTarihi
        {
            get { return m_GuncellemeTarihi; }
            set { m_GuncellemeTarihi = value; }
        }

        // Özel Alanlar
        private Firma m_FirmaObject;
        public Firma FirmaObject
        {
            get { return m_FirmaObject; }
            set { m_FirmaObject = value; }
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
        private bool m_Updated;
        public bool Updated
        {
            get { return m_Updated; }
        }
        public bool Changed { get; set; }
        #endregion

        public Stok()
        {
            this.m_Fiyat = this.m_KarOran = 0;
            this.m_EklenmeTarihi = this.m_GuncellemeTarihi = DateTime.Now;
        }

        /// <summary>
        /// Stok Nesnesi Oluþtur
        /// </summary>
        public Stok(int pID, int pKategoriID, int pUrunID, int pFirmaID, float pFiyat, float pKarOran, DateTime pEklenmeTarihi, DateTime pGuncellemeTarihi, Firma pFirmaObject)
        {
            this.m_ID = pID;
            this.m_KategoriID = pKategoriID;
            this.m_UrunID = pUrunID;
            this.m_FirmaID = pFirmaID;
            this.m_Fiyat = pFiyat;
            this.m_KarOran = pKarOran;
            this.m_EklenmeTarihi = pEklenmeTarihi;
            this.m_GuncellemeTarihi = pGuncellemeTarihi;
            this.m_FirmaObject = pFirmaObject;
            this.m_Updated = (DateTime.Now - pGuncellemeTarihi).Days >= pFirmaObject.Period;
        }
    }

    public partial class StokMethods
    {
        public static Stok GetStok(int pID)
        {
            Stok rvStok = new Stok();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from Stok where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", pID, MSqlDbType.Int);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvStok = new Stok(MConvert.NullToInt(IDR["ID"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToInt(IDR["UrunID"]), MConvert.NullToInt(IDR["FirmaID"]), MConvert.NullToFloat(IDR["Fiyat"]), MConvert.NullToFloat(IDR["KarOran"]), MConvert.NullToDateTime(IDR["EklenmeTarihi"]), MConvert.NullToDateTime(IDR["GuncellemeTarihi"]), FirmaMethods.GetFirma(MConvert.NullToInt(IDR["FirmaID"])));
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
            return rvStok;
        }
        public static Stok GetStok(Stok p)
        {
            Stok rvStok = new Stok();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from Stok where KategoriID=@KategoriID and UrunID=@UrunID and FirmaID=@FirmaID", conneciton))
                {
                    cmd.Parameters.Add("KategoriID", p.KategoriID, MSqlDbType.Int);
                    cmd.Parameters.Add("UrunID", p.UrunID, MSqlDbType.Int);
                    cmd.Parameters.Add("FirmaID", p.FirmaID, MSqlDbType.Int);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        List<Firma> pFirmalar = FirmaMethods.GetSelect();
                        while (IDR.Read())
                            rvStok = new Stok(MConvert.NullToInt(IDR["ID"]), MConvert.NullToInt(IDR["KategoriID"]), MConvert.NullToInt(IDR["UrunID"]), MConvert.NullToInt(IDR["FirmaID"]), MConvert.NullToFloat(IDR["Fiyat"]), MConvert.NullToFloat(IDR["KarOran"]), MConvert.NullToDateTime(IDR["EklenmeTarihi"]), MConvert.NullToDateTime(IDR["GuncellemeTarihi"]),
                                pFirmalar.Find(x => x.ID.Equals(MConvert.NullToInt(IDR["FirmaID"]))));
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
            return rvStok;
        }

        public static List<Stok> GetSelect()
        {
            List<Stok> rvStok = new List<Stok>();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select * from Stok", conneciton))
                {
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        List<Firma> pFirmalar = FirmaMethods.GetSelect();
                        Firma f = null;
                        while (IDR.Read())
                        {
                            f = pFirmalar.Find(x => x.ID.Equals(MConvert.NullToInt(IDR["FirmaID"])));
                            if (f == null)
                            {
                                f = new Firma();
                                f.Adi = L.Bilinmeyen;
                            }
                            rvStok.Add(new Stok(
                                MConvert.NullToInt(IDR["ID"]),
                                MConvert.NullToInt(IDR["KategoriID"]),
                                MConvert.NullToInt(IDR["UrunID"]),
                                MConvert.NullToInt(IDR["FirmaID"]),
                                MConvert.NullToFloat(IDR["Fiyat"]),
                                MConvert.NullToFloat(IDR["KarOran"]),
                                MConvert.NullToDateTime(IDR["EklenmeTarihi"]),
                                MConvert.NullToDateTime(IDR["GuncellemeTarihi"]),
                                f));
                        }
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
            return rvStok;
        }
        public static int GetUrunCount(int pUrunID)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "select COUNT(UrunID) from Stok where UrunID=@UrunID", conneciton))
                {
                    cmd.Parameters.Add("UrunID", pUrunID, MSqlDbType.Int);
                    rowsAffected = BAYMYO.UI.Converts.NullToInt(cmd.ExecuteScalar());
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
        public static int GetFirmaCount(int pFirmaID)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "select COUNT(FirmaID) from Stok where FirmaID=@FirmaID", conneciton))
                {
                    cmd.Parameters.Add("FirmaID", pFirmaID, MSqlDbType.Int);
                    rowsAffected = BAYMYO.UI.Converts.NullToInt(cmd.ExecuteScalar());
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

        public static int Insert(Stok p)
        {
            using (Stok temp = StokMethods.GetStok(p))
            {
                if (temp != null & temp.ID > 0)
                    if (System.Windows.Forms.MessageBox.Show("Belirtiðiniz Firma ve Ürün bilgisine göre ürün stoklarýnýzda bulunmaktadýr! Yapacaðýnýz bu iþlem ile Ürün bilgilerinden 'Fiyat' ve 'Kar Oran'ý deðiþtirilecek istiyormusunuz?", "Uyarý", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        temp.Fiyat = p.Fiyat;
                        temp.KarOran = p.KarOran;
                        temp.GuncellemeTarihi = temp.GuncellemeTarihi;
                        return StokMethods.Update(temp);
                    }
                    else
                        return 0;
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
                using (MCommand cmd = new MCommand(CommandType.Text, "insert into Stok (KategoriID,UrunID,FirmaID,Fiyat,KarOran,EklenmeTarihi,GuncellemeTarihi) values(@KategoriID,@UrunID,@FirmaID,@Fiyat,@KarOran,@EklenmeTarihi,@GuncellemeTarihi)", conneciton))
                {
                    cmd.Parameters.Add("KategoriID", p.KategoriID, MSqlDbType.Int);
                    cmd.Parameters.Add("UrunID", p.UrunID, MSqlDbType.Int);
                    cmd.Parameters.Add("FirmaID", p.FirmaID, MSqlDbType.Int);
                    cmd.Parameters.Add("Fiyat", p.Fiyat, MSqlDbType.Float);
                    cmd.Parameters.Add("KarOran", p.KarOran, MSqlDbType.Float);
                    cmd.Parameters.Add("EklenmeTarihi", p.EklenmeTarihi, MSqlDbType.DateTime);
                    cmd.Parameters.Add("GuncellemeTarihi", p.GuncellemeTarihi, MSqlDbType.DateTime);
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
        public static int Update(Stok p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "Update Stok SET KategoriID=@KategoriID,UrunID=@UrunID,FirmaID=@FirmaID,Fiyat=@Fiyat,KarOran=@KarOran,EklenmeTarihi=@EklenmeTarihi,GuncellemeTarihi=@GuncellemeTarihi where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("KategoriID", p.KategoriID, MSqlDbType.Int);
                    cmd.Parameters.Add("UrunID", p.UrunID, MSqlDbType.Int);
                    cmd.Parameters.Add("FirmaID", p.FirmaID, MSqlDbType.Int);
                    cmd.Parameters.Add("Fiyat", p.Fiyat, MSqlDbType.Float);
                    cmd.Parameters.Add("KarOran", p.KarOran, MSqlDbType.Float);
                    cmd.Parameters.Add("EklenmeTarihi", p.EklenmeTarihi, MSqlDbType.DateTime);
                    cmd.Parameters.Add("GuncellemeTarihi", p.GuncellemeTarihi, MSqlDbType.DateTime);
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
        public static int Delete(int pID)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Stok where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", pID, MSqlDbType.Int);
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
        public static int Delete(Stok p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Stok where ID=@ID", conneciton))
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
