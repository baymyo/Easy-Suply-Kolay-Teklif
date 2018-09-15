using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BAYMYO.MultiSQLClient;

namespace EasySupply
{
    public partial class DovizCollection : CollectionBase, IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Doviz this[int index]
        {
            get { return (Doviz)this.List[index]; }
            set { this.List[index] = value; }
        }

        public object SyncRoot { get { return this.List.SyncRoot; } }

        public int Add(Doviz obj)
        {
            return this.List.Add(obj);
        }

        public void Insert(int index, Doviz obj)
        {
            this.List.Insert(index, obj);
        }

        public bool Contains(Doviz obj)
        {
            return this.List.Contains(obj);
        }

        public int IndexOf(Doviz obj)
        {
            return this.List.IndexOf(obj);
        }

        public void Remove(Doviz obj)
        {
            this.List.Remove(obj);
        }
    }

    public partial class Doviz : IDisposable
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
        private string m_Cinsi;
        public string Cinsi
        {
            get { return m_Cinsi; }
            set { m_Cinsi = value; }
        }
        private float m_Kuru;
        public float Kuru
        {
            get { return m_Kuru; }
            set { m_Kuru = value; }
        }
        private DateTime m_Tarih;
        public DateTime Tarih
        {
            get { return m_Tarih; }
            set { m_Tarih = value; }
        }

        #endregion

        public Doviz()
        {
        }

        public Doviz(int pID, string pCinsi, float pKuru, DateTime pTarih)
        {
            this.m_ID = pID;
            this.m_Cinsi = pCinsi;
            this.m_Kuru = pKuru;
            this.m_Tarih = pTarih;
        }
    }

    public partial class DovizMethods
    {
        public static Doviz GetDoviz(int pID)
        {
            Doviz rvDoviz = new Doviz();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from Doviz where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", pID, MSqlDbType.Int);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvDoviz = new Doviz(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Cinsi"]), MConvert.NullToFloat(IDR["Kuru"]), MConvert.NullToDateTime(IDR["Tarih"]));
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
            return rvDoviz;
        }
        public static Doviz GetDoviz(CommandType cmdType, string sqlQuery, MParameterCollection parameters)
        {
            Doviz rvDoviz = new Doviz();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(cmdType, sqlQuery, conneciton))
                {
                    if (parameters != null)
                        foreach (MParameter item in parameters)
                            cmd.Parameters.Add(item);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvDoviz = new Doviz(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Cinsi"]), MConvert.NullToFloat(IDR["Kuru"]), MConvert.NullToDateTime(IDR["Tarih"]));
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
            return rvDoviz;
        }

        public static DovizCollection GetSelect()
        {
            DovizCollection rvDoviz = new DovizCollection();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select * from Doviz", conneciton))
                {
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvDoviz.Add(new Doviz(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Cinsi"]), MConvert.NullToFloat(IDR["Kuru"]), MConvert.NullToDateTime(IDR["Tarih"])));
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
            return rvDoviz;
        }

        public static int Insert(Doviz p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "insert into Doviz (Cinsi,Kuru,Tarih) values(@Cinsi,@Kuru,@Tarih)", conneciton))
                {
                    cmd.Parameters.Add("Cinsi", p.Cinsi.ToUpper(), MSqlDbType.VarChar);
                    cmd.Parameters.Add("Kuru", p.Kuru, MSqlDbType.Float);
                    cmd.Parameters.Add("Tarih", p.Tarih, MSqlDbType.DateTime);
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
        public static int Update(Doviz p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "Update Doviz SET Cinsi=@Cinsi,Kuru=@Kuru,Tarih=@Tarih where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("Cinsi", p.Cinsi.ToUpper(), MSqlDbType.VarChar);
                    cmd.Parameters.Add("Kuru", p.Kuru, MSqlDbType.Float);
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
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Doviz where ID=@ID", conneciton))
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
        public static int Delete(Doviz p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Doviz where ID=@ID", conneciton))
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
