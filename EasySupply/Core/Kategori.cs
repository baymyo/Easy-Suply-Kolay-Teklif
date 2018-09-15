using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BAYMYO.MultiSQLClient;

namespace EasySupply
{
    public partial class KategoriCollection : CollectionBase, IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Kategori this[int index]
        {
            get { return (Kategori)this.List[index]; }
            set { this.List[index] = value; }
        }

        public object SyncRoot { get { return this.List.SyncRoot; } }

        public int Add(Kategori obj)
        {
            return this.List.Add(obj);
        }

        public void Insert(int index, Kategori obj)
        {
            this.List.Insert(index, obj);
        }

        public bool Contains(Kategori obj)
        {
            return this.List.Contains(obj);
        }

        public int IndexOf(Kategori obj)
        {
            return this.List.IndexOf(obj);
        }

        public void Remove(Kategori obj)
        {
            this.List.Remove(obj);
        }
    }

    public partial class Kategori : IDisposable
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
        private string m_Adi;
        public string Adi
        {
            get { return m_Adi; }
            set { m_Adi = value; }
        }

        #endregion

        public Kategori()
        {
        }

        public Kategori(int pID, string pKod, string pAdi)
        {
            this.m_ID = pID;
            this.m_Kod = pKod;
            this.m_Adi = pAdi;
        }
    }

    public partial class KategoriMethods
    {
        public static Kategori GetKategori(int pID)
        {
            Kategori rvKategori = new Kategori();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from Kategori where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", pID, MSqlDbType.Int);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvKategori = new Kategori(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToString(IDR["Adi"]));
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
            return rvKategori;
        }
        public static Kategori GetKategori(Kategori p)
        {
            Kategori rvKategori = new Kategori();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from Kategori where Adi=@Adi", conneciton))
                {
                    cmd.Parameters.Add("Adi", p.Adi, MSqlDbType.NVarChar);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvKategori = new Kategori(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToString(IDR["Adi"]));
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
            return rvKategori;
        }

        public static KategoriCollection GetSelect()
        {
            KategoriCollection rvKategori = new KategoriCollection();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select * from Kategori order by Adi asc", conneciton))
                {

                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvKategori.Add(new Kategori(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToString(IDR["Adi"])));
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
            return rvKategori;
        }

        public static int Insert(Kategori p)
        {
            using (Kategori temp = KategoriMethods.GetKategori(p))
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
                using (MCommand cmd = new MCommand(CommandType.Text, "insert into Kategori (Kod,Adi) values(@Kod,@Adi)", conneciton))
                {
                    cmd.Parameters.Add("Kod", p.Kod, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Adi", p.Adi.ToUpper(), MSqlDbType.NVarChar);
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
        public static int Update(Kategori p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "Update Kategori SET Kod=@Kod,Adi=@Adi where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("Kod", p.Kod, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Adi", p.Adi, MSqlDbType.NVarChar);
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
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Kategori where ID=@ID", conneciton))
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
        public static int Delete(Kategori p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Kategori where ID=@ID", conneciton))
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
