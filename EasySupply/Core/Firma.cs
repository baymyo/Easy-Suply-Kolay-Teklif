using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BAYMYO.MultiSQLClient;

namespace EasySupply
{
    public partial class Firma : IDisposable
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
        private string m_Yetkili;
        public string Yetkili
        {
            get { return m_Yetkili; }
            set { m_Yetkili = value; }
        }
        private string m_Telefon;
        public string Telefon
        {
            get { return m_Telefon; }
            set { m_Telefon = value; }
        }
        private string m_Mail;
        public string Mail
        {
            get { return m_Mail; }
            set { m_Mail = value; }
        }
        private string m_Adres;
        public string Adres
        {
            get { return m_Adres; }
            set { m_Adres = value; }
        }
        private byte m_Period;
        public byte Period
        {
            get { return m_Period; }
            set { m_Period = value; }
        }

        #endregion

        public Firma()
        {
        }

        /// <summary>
        /// Firma Nesnesi Oluþtur
        /// </summary>
        public Firma(int pID, string pKod, string pAdi, string pYetkili, string pTelefon, string pMail, string pAdres, byte pPeriod)
        {
            this.m_ID = pID;
            this.m_Kod = pKod;
            this.m_Adi = pAdi;
            this.m_Yetkili = pYetkili;
            this.m_Telefon = pTelefon;
            this.m_Mail = pMail;
            this.m_Adres = pAdres;
            this.m_Period = pPeriod;
        }
    }

    public partial class FirmaMethods
    {
        public static Firma GetFirma(int pID)
        {
            Firma rvFirma = new Firma();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1  * from Firma where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("ID", pID, MSqlDbType.Int);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvFirma = new Firma(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToString(IDR["Adi"]), MConvert.NullToString(IDR["Yetkili"]), MConvert.NullToString(IDR["Telefon"]), MConvert.NullToString(IDR["Mail"]), MConvert.NullToString(IDR["Adres"]), MConvert.NullToByte(IDR["Period"]));
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
            return rvFirma;
        }
        public static Firma GetFirma(Firma p)
        {
            Firma rvFirma = new Firma();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select top 1 * from Firma where Adi=@Adi", conneciton))
                {
                    cmd.Parameters.Add("Adi", p.Adi, MSqlDbType.NVarChar);
                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvFirma = new Firma(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToString(IDR["Adi"]), MConvert.NullToString(IDR["Yetkili"]), MConvert.NullToString(IDR["Telefon"]), MConvert.NullToString(IDR["Mail"]), MConvert.NullToString(IDR["Adres"]), MConvert.NullToByte(IDR["Period"]));
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
            return rvFirma;
        }

        public static List<Firma> GetSelect()
        {
            List<Firma> rvFirma = new List<Firma>();
            using (MConnection conneciton = new MConnection(MClientProvider.OleDb, Commons.ConnectionStringName))
            {
                switch (conneciton.State)
                {
                    case System.Data.ConnectionState.Closed:
                        conneciton.Open();
                        break;
                }
                using (MCommand cmd = new MCommand(CommandType.Text, "select * from Firma", conneciton))
                {

                    using (IDataReader IDR = cmd.ExecuteReader())
                    {
                        while (IDR.Read())
                            rvFirma.Add(new Firma(MConvert.NullToInt(IDR["ID"]), MConvert.NullToString(IDR["Kod"]), MConvert.NullToString(IDR["Adi"]), MConvert.NullToString(IDR["Yetkili"]), MConvert.NullToString(IDR["Telefon"]), MConvert.NullToString(IDR["Mail"]), MConvert.NullToString(IDR["Adres"]), MConvert.NullToByte(IDR["Period"])));
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
            return rvFirma;
        }

        public static int Insert(Firma p)
        {
            using (Firma temp = FirmaMethods.GetFirma(p))
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
                using (MCommand cmd = new MCommand(CommandType.Text, "insert into Firma (Kod,Adi,Yetkili,Telefon,Mail,Adres,Period) values(@Kod,@Adi,@Yetkili,@Telefon,@Mail,@Adres,@Period)", conneciton))
                {
                    cmd.Parameters.Add("Kod", p.Kod, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Adi", p.Adi, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Yetkili", p.Yetkili, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Telefon", p.Telefon, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Mail", p.Mail, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Adres", p.Adres, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Period", p.Period, MSqlDbType.TinyInt);
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
        public static int Update(Firma p)
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
                using (MCommand cmd = new MCommand(CommandType.Text, "Update Firma SET Kod=@Kod,Adi=@Adi,Yetkili=@Yetkili,Telefon=@Telefon,Mail=@Mail,Adres=@Adres,Period=@Period where ID=@ID", conneciton))
                {
                    cmd.Parameters.Add("Kod", p.Kod, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Adi", p.Adi, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Yetkili", p.Yetkili, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Telefon", p.Telefon, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Mail", p.Mail, MSqlDbType.VarChar);
                    cmd.Parameters.Add("Adres", p.Adres, MSqlDbType.NVarChar);
                    cmd.Parameters.Add("Period", p.Period, MSqlDbType.TinyInt);
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
        public static int Delete(Firma p)
        {
            int rowsAffected = 0;
            if (StokMethods.GetFirmaCount(p.ID) > 0)
            {
                System.Windows.Forms.MessageBox.Show(string.Format(L.FirmaninStoklariVarSilinemez, p.Adi), "Warning");
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
                using (MCommand cmd = new MCommand(CommandType.Text, "delete from Firma where ID=@ID", conneciton))
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