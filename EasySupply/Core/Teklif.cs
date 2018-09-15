using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BAYMYO.MultiSQLClient;

namespace EasySupply
{
    public partial class TeklifCollection : CollectionBase, IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Teklif this[int index]
        {
            get { return (Teklif)this.List[index]; }
            set { this.List[index] = value; }
        }

        public object SyncRoot { get { return this.List.SyncRoot; } }

        public int Add(Teklif obj)
        {
            return this.List.Add(obj);
        }

        public void Insert(int index, Teklif obj)
        {
            this.List.Insert(index, obj);
        }

        public bool Contains(Teklif obj)
        {
            return this.List.Contains(obj);
        }

        public int IndexOf(Teklif obj)
        {
            return this.List.IndexOf(obj);
        }

        public void Remove(Teklif obj)
        {
            this.List.Remove(obj);
        }
    }

    public partial class Teklif : IDisposable
    {
        #region ---IDisposable Members---
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

        #region ---Properties/Field - Özellikler/Alanlar---
        private Int64 m_ID;
        public Int64 ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }
        private string m_GemiAdi;
        public string GemiAdi
        {
            get { return m_GemiAdi; }
            set { m_GemiAdi = value; }
        }
        private string m_BaglamaLimani;
        public string BaglamaLimani
        {
            get { return m_BaglamaLimani; }
            set { m_BaglamaLimani = value; }
        }
        private string m_Acenta;
        public string Acenta
        {
            get { return m_Acenta; }
            set { m_Acenta = value; }
        }
        private string m_Manager;
        public string Manager
        {
            get { return m_Manager; }
            set { m_Manager = value; }
        }
        private DateTime m_Tarih;
        public DateTime Tarih
        {
            get { return m_Tarih; }
            set { m_Tarih = value; }
        }
        private float m_Kur1;
        public float Kur1
        {
            get { return m_Kur1; }
            set { m_Kur1 = value; }
        }
        private float m_Kur2;
        public float Kur2
        {
            get { return m_Kur2; }
            set { m_Kur2 = value; }
        }
        private string m_ParaBirimi;
        public string ParaBirimi
        {
            get { return m_ParaBirimi; }
            set { m_ParaBirimi = value; }
        }
        private byte m_Kdv;
        public byte Kdv
        {
            get { return m_Kdv; }
            set { m_Kdv = value; }
        }
        private float m_TasimaUcreti;
        public float TasimaUcreti
        {
            get { return m_TasimaUcreti; }
            set { m_TasimaUcreti = value; }
        }
        private float m_Iskonto;
        public float Iskonto
        {
            get { return m_Iskonto; }
            set { m_Iskonto = value; }
        }
        private string m_Hazirlayan;
        public string Hazirlayan
        {
            get { return m_Hazirlayan; }
            set { m_Hazirlayan = value; }
        }
        private string m_OdemeSekli;
        public string OdemeSekli
        {
            get { return m_OdemeSekli; }
            set { m_OdemeSekli = value; }
        }
        private string m_TeslimSuresi;
        public string TeslimSuresi
        {
            get { return m_TeslimSuresi; }
            set { m_TeslimSuresi = value; }
        }
        private string m_Aciklama;
        public string Aciklama
        {
            get { return m_Aciklama; }
            set { m_Aciklama = value; }
        }
        private DateTime m_GuncellemeTarihi;
        public DateTime GuncellemeTarihi
        {
            get { return m_GuncellemeTarihi; }
            set { m_GuncellemeTarihi = value; }
        }
        private byte m_Durum;
        public byte Durum
        {
            get { return m_Durum; }
            set { m_Durum = value; }
        }
        private string m_DurumNotu;
        public string DurumNotu
        {
            get { return m_DurumNotu; }
            set { m_DurumNotu = value; }
        }
        private string m_TasimaUcretiNotu;
        public string TasimaUcretiNotu
        {
            get { return m_TasimaUcretiNotu; }
            set { m_TasimaUcretiNotu = value; }
        }
        #endregion

        public Teklif()
        {
            this.m_ID = -1;
            this.m_ParaBirimi = "TRY";
            this.m_Kur1 = Commons.Kur1;
            this.m_Kur2 = Commons.Kur2;
            this.m_Kdv = 0;
            this.m_Durum = 0;
        }

        public Teklif(Int64 pID, string pGemiAdi, string pBaglamaLimani, string pAcenta, string pManager, DateTime pTarih, float pKur1, float pKur2, string pParaBirimi, byte pKdv, float pTasimaUcreti, float pIskonto, string pHazirlayan, string pOdemeSekli, string pTeslimSuresi, string pAciklama, DateTime pGuncellemeTarihi, byte pDurum, string pDurumNotu, string pTasimaUcretiNotu)
        {
            this.m_ID = pID;
            this.m_GemiAdi = pGemiAdi;
            this.m_BaglamaLimani = pBaglamaLimani;
            this.m_Acenta = pAcenta;
            this.m_Manager = pManager;
            this.m_Tarih = pTarih;
            this.m_Kur1 = pKur1 <= 0 ? Commons.Kur1 : pKur1;
            this.m_Kur2 = pKur2 <= 0 ? Commons.Kur2 : pKur2;
            this.m_ParaBirimi = pParaBirimi;
            this.m_Kdv = pKdv;
            this.m_TasimaUcreti = pTasimaUcreti;
            this.m_Iskonto = pIskonto;
            this.m_Hazirlayan = pHazirlayan;
            this.m_OdemeSekli = pOdemeSekli;
            this.m_TeslimSuresi = pTeslimSuresi;
            this.m_Aciklama = pAciklama;
            this.m_GuncellemeTarihi = pGuncellemeTarihi;
            this.m_Durum = pDurum;
            this.m_DurumNotu = pDurumNotu;
            this.m_TasimaUcretiNotu = pTasimaUcretiNotu;
        }
    }

    public partial class TeklifMethods
    {
        public static DataSet GetRelation(DateTime ilkTarih, DateTime sonTarih, string gemiAdi)
        {
            DataSet rvDs = new DataSet();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                using (MCommand cmd = new MCommand("select * from Teklif where Tarih between @ilkTarih and @sonTarih and GemiAdi like @gemiAdi", conneciton))
                {
                    cmd.Parameters.Add("ilkTarih", ilkTarih.ToString("dd/MM/yyyy 00:00:00"), MSqlDbType.DateTime);
                    cmd.Parameters.Add("sonTarih", sonTarih.ToString("dd/MM/yyyy 23:59:00"), MSqlDbType.DateTime);
                    cmd.Parameters.Add("gemiAdi", (string.IsNullOrWhiteSpace(gemiAdi) ? "%%" : gemiAdi.Replace("*", "%")), MSqlDbType.NVarChar);
                    using (MDataAdapter dap = new MDataAdapter(cmd))
                    {
                        using (DataTable t = new DataTable("Teklif"))
                        {
                            dap.Fill(t);
                            rvDs.Tables.Add(t);
                        }
                    }
                    //DETAY TABLOSU
                    cmd.CommandText = "select TeklifID,UrunAdi, IIf(IsNull(FirmaAdi),(select top 1 f.Adi from Firma f where ID=FirmaID),FirmaAdi) as FirmaBilgi,Adet,Birim,BirimFiyati,KarOrani from TeklifDetay where TeklifID IN(select ID from Teklif where Tarih between @ilkTarih and @sonTarih and GemiAdi like @gemiAdi) order by ID asc";
                    using (MDataAdapter dap = new MDataAdapter(cmd))
                    {
                        using (DataTable d = new DataTable("Detay"))
                        {
                            dap.Fill(d);
                            rvDs.Tables.Add(d);
                        }
                    }
                    rvDs.Relations.Add("FK_Teklif_TO_Detay", rvDs.Tables[0].Columns[0], rvDs.Tables[1].Columns[0]);
                }
            }
            return rvDs;
        }

        public static Teklif GetTeklif(Int64 pID)
        {
            Teklif rvTeklif = new Teklif();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from Teklif where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", pID, MSqlDbType.BigInt);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvTeklif = new Teklif(MConvert.NullToInt64(IDR["ID"]), MConvert.NullToString(IDR["GemiAdi"]), MConvert.NullToString(IDR["BaglamaLimani"]), MConvert.NullToString(IDR["Acenta"]), MConvert.NullToString(IDR["Manager"]), MConvert.NullToDateTime(IDR["Tarih"]), MConvert.NullToFloat(IDR["Kur1"]), MConvert.NullToFloat(IDR["Kur2"]), MConvert.NullToString(IDR["ParaBirimi"]), MConvert.NullToByte(IDR["Kdv"]), MConvert.NullToFloat(IDR["TasimaUcreti"]), MConvert.NullToFloat(IDR["Iskonto"]), MConvert.NullToString(IDR["Hazirlayan"]), MConvert.NullToString(IDR["OdemeSekli"]), MConvert.NullToString(IDR["TeslimSuresi"]), MConvert.NullToString(IDR["Aciklama"]), MConvert.NullToDateTime(IDR["GuncellemeTarihi"]), MConvert.NullToByte(IDR["Durum"]), MConvert.NullToString(IDR["DurumNotu"]), MConvert.NullToString(IDR["TasimaUcretiNotu"]));
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
            return rvTeklif;
        }

        public static TeklifCollection GetSelect()
        {
            TeklifCollection rvTeklif = new TeklifCollection();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select * from Teklif", conneciton))
                {

                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvTeklif.Add(new Teklif(MConvert.NullToInt64(IDR["ID"]), MConvert.NullToString(IDR["GemiAdi"]), MConvert.NullToString(IDR["BaglamaLimani"]), MConvert.NullToString(IDR["Acenta"]), MConvert.NullToString(IDR["Manager"]), MConvert.NullToDateTime(IDR["Tarih"]), MConvert.NullToFloat(IDR["Kur1"]), MConvert.NullToFloat(IDR["Kur2"]), MConvert.NullToString(IDR["ParaBirimi"]), MConvert.NullToByte(IDR["Kdv"]), MConvert.NullToFloat(IDR["TasimaUcreti"]), MConvert.NullToFloat(IDR["Iskonto"]), MConvert.NullToString(IDR["Hazirlayan"]), MConvert.NullToString(IDR["OdemeSekli"]), MConvert.NullToString(IDR["TeslimSuresi"]), MConvert.NullToString(IDR["Aciklama"]), MConvert.NullToDateTime(IDR["GuncellemeTarihi"]), MConvert.NullToByte(IDR["Durum"]), MConvert.NullToString(IDR["DurumNotu"]), MConvert.NullToString(IDR["TasimaUcretiNotu"])));
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
            return rvTeklif;
        }
        public static Int64 GetCount()
        {
            Int64 rowsAffected = 0;
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select count(ID) from Teklif", conneciton))
                {
                    rowsAffected = BAYMYO.UI.Converts.NullToInt64(cmd.ExecuteScalar());
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

        public static Int64 Insert(Teklif p)
        {
            Int64 rowsAffected = 0;
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "insert into Teklif (GemiAdi,BaglamaLimani,Acenta,Manager,Tarih,Kur1,Kur2,ParaBirimi,Kdv,TasimaUcreti,Iskonto,Hazirlayan,OdemeSekli,TeslimSuresi,Aciklama,GuncellemeTarihi,Durum,DurumNotu,TasimaUcretiNotu) values(@GemiAdi,@BaglamaLimani,@Acenta,@Manager,@Tarih,@Kur1,@Kur2,@ParaBirimi,@Kdv,@TasimaUcreti,@Iskonto,@Hazirlayan,@OdemeSekli,@TeslimSuresi,@Aciklama,@GuncellemeTarihi,@Durum,@DurumNotu,@TasimaUcretiNotu)", conneciton))
                {
                    cmd.Parameters.Add("GemiAdi", p.GemiAdi, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("BaglamaLimani", p.BaglamaLimani, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Acenta", p.Acenta, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Manager", p.Manager, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Tarih", p.Tarih, MSqlDbType.DateTime);
                    cmd.Parameters.Add("Kur1", p.Kur1, MSqlDbType.Float);
                    cmd.Parameters.Add("Kur2", p.Kur2, MSqlDbType.Float);
                    cmd.Parameters.Add("ParaBirimi", p.ParaBirimi, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Kdv", p.Kdv, MSqlDbType.TinyInt);
                    cmd.Parameters.Add("TasimaUcreti", p.TasimaUcreti, MSqlDbType.Float);
                    cmd.Parameters.Add("Iskonto", p.Iskonto, MSqlDbType.Float);
                    cmd.Parameters.Add("Hazirlayan", p.Hazirlayan, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("OdemeSekli", p.OdemeSekli, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("TeslimSuresi", p.TeslimSuresi, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Aciklama", p.Aciklama, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("GuncellemeTarihi", p.GuncellemeTarihi, MSqlDbType.DateTime);
                    cmd.Parameters.Add("Durum", p.Durum, MSqlDbType.Number);
                    cmd.Parameters.Add("DurumNotu", p.DurumNotu, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("TasimaUcretiNotu", p.DurumNotu, MSqlDbType.NVarChar);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cmd.Parameters.Clear();
                        //;select top 1 ID from Teklif where GemiAdi=@GemiAdi and BaglamaLimani=@BaglamaLimani and Acenta=@Acenta and Manager=@Manager and Tarih=@Tarih;
                        cmd.CommandText = "SELECT @@IDENTITY";
                        rowsAffected = MConvert.NullToInt64(cmd.ExecuteScalar());
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
        public static int Update(Teklif p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "Update Teklif SET GemiAdi=@GemiAdi,BaglamaLimani=@BaglamaLimani,Acenta=@Acenta,Manager=@Manager,Tarih=@Tarih,Kur1=@Kur1,Kur2=@Kur2,ParaBirimi=@ParaBirimi,Kdv=@Kdv,TasimaUcreti=@TasimaUcreti,Iskonto=@Iskonto,Hazirlayan=@Hazirlayan,OdemeSekli=@OdemeSekli,TeslimSuresi=@TeslimSuresi,Aciklama=@Aciklama,GuncellemeTarihi=@GuncellemeTarihi,Durum=@Durum,DurumNotu=@DurumNotu,TasimaUcretiNotu=@TasimaUcretiNotu where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("GemiAdi", p.GemiAdi, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("BaglamaLimani", p.BaglamaLimani, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Acenta", p.Acenta, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Manager", p.Manager, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Tarih", p.Tarih, MSqlDbType.DateTime);
                    cmd.Parameters.Add("Kur1", p.Kur1, MSqlDbType.Float);
                    cmd.Parameters.Add("Kur2", p.Kur2, MSqlDbType.Float);
                    cmd.Parameters.Add("ParaBirimi", p.ParaBirimi, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Kdv", p.Kdv, MSqlDbType.TinyInt);
                    cmd.Parameters.Add("TasimaUcreti", p.TasimaUcreti, MSqlDbType.Float);
                    cmd.Parameters.Add("Iskonto", p.Iskonto, MSqlDbType.Float);
                    cmd.Parameters.Add("Hazirlayan", p.Hazirlayan, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("OdemeSekli", p.OdemeSekli, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("TeslimSuresi", p.TeslimSuresi, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Aciklama", p.Aciklama, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("GuncellemeTarihi", p.GuncellemeTarihi, MSqlDbType.DateTime);
                    cmd.Parameters.Add("Durum", p.Durum, MSqlDbType.Number);
                    cmd.Parameters.Add("DurumNotu", p.DurumNotu, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("TasimaUcretiNotu", p.TasimaUcretiNotu, MSqlDbType.NVarChar);
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
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Teklif where ID=@ID", conneciton))
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
        public static int Delete(Teklif p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Teklif where ID=@ID", conneciton))
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
