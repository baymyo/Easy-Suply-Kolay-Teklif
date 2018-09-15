using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EasySupply
{
    public partial class xFrmStokKarDegisiklik : DevExpress.XtraEditors.XtraForm
    {
        #region --- METHODS ---
        public void SetCurrencyAndLangs()
        {
            try
            {
                this.Text = L.KarOraniDegistir;
                this.lblBirimKarOrani.Text = L.KarOraniYeni;
                this.guncelleButton.Text = L.Guncelle;
                this.vazgecButton.Text = L.Vazgec;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKS", 1) + ex.Message);
            }
        }
        public void GetFirmalar()
        {
            try
            {
                List<Firma> f = FirmaMethods.GetSelect();
                f.Add(new Firma { ID = 0, Kod = "...", Adi = L.TumFirmalaraUygula });
                this.firmaBindingSource.DataSource = f;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKS", 2) + ex.Message);
            }
        }
        public void GetKategoriler()
        {
            try
            {
                KategoriCollection k = KategoriMethods.GetSelect();
                k.Add(new Kategori { ID = 0, Kod = "...", Adi = L.TumKategorilereUygula });
                this.kategoriBindingSource.DataSource = k;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKS", 3) + ex.Message);
            }
        }
        #endregion

        public xFrmStokKarDegisiklik()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        private void xFrmStokKarDegisiklik_Load(object sender, EventArgs e)
        {
            try
            {
                GetKategoriler();
                GetFirmalar();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKS", 4) + ex.Message);
            }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            try
            {
                int kategoriID = BAYMYO.UI.Converts.NullToInt(this.kategoriLookUpEdit.EditValue),
                    firmaID = BAYMYO.UI.Converts.NullToInt(this.firmaLookUpEdit.EditValue);

                if (this.karOraniFilitreRadioGrup.SelectedIndex != 4 && kategoriID == 0 && firmaID == 0)
                {
                    string msg = "Belirtiğiniz filitre seçeneğine göre lütfen kategori yada firma seçiniz.";
                    MessageBox.Show(msg, "Uyarı");
                    Commons.Status(msg);
                    return;
                }

                using (BAYMYO.UI.Window.CustomSqlQuery q = new BAYMYO.UI.Window.CustomSqlQuery())
                {
                    q.ConnectionString = Commons.ConnectionStringName;
                    q.ClientProvider = BAYMYO.MultiSQLClient.MClientProvider.OleDb;
                    q.CommandText = "Update Stok Set KarOran=@KarOran where 1=1 ";
                    q.Parameters.Add("KarOran", Convert.ToSingle(this.karOranCalcEdit.Value), BAYMYO.MultiSQLClient.MSqlDbType.Float);

                    switch (this.karOraniFilitreRadioGrup.SelectedIndex)
                    {
                        case 0:
                            if (kategoriID > 0)
                            {
                                q.CommandText += " and KategoriID=@KategoriID ";
                                q.Parameters.Add("KategoriID", this.kategoriLookUpEdit.EditValue, BAYMYO.MultiSQLClient.MSqlDbType.Int);
                            }
                            if (firmaID > 0)
                            {
                                q.CommandText += " and FirmaID=@FirmaID ";
                                q.Parameters.Add("FirmaID", this.firmaLookUpEdit.EditValue, BAYMYO.MultiSQLClient.MSqlDbType.Int);
                            }
                            break;
                        case 1:
                            if (kategoriID > 0)
                            {
                                q.CommandText += " and KategoriID<>@KategoriID ";
                                q.Parameters.Add("KategoriID", this.kategoriLookUpEdit.EditValue, BAYMYO.MultiSQLClient.MSqlDbType.Int);
                            }
                            if (firmaID > 0)
                            {
                                q.CommandText += " and FirmaID<>@FirmaID ";
                                q.Parameters.Add("FirmaID", this.firmaLookUpEdit.EditValue, BAYMYO.MultiSQLClient.MSqlDbType.Int);
                            }
                            break;
                        case 2:
                            if (kategoriID > 0)
                            {
                                q.CommandText += " and KategoriID<>@KategoriID ";
                                q.Parameters.Add("KategoriID", this.kategoriLookUpEdit.EditValue, BAYMYO.MultiSQLClient.MSqlDbType.Int);
                            }
                            if (firmaID > 0)
                            {
                                q.CommandText += " and FirmaID=@FirmaID ";
                                q.Parameters.Add("FirmaID", this.firmaLookUpEdit.EditValue, BAYMYO.MultiSQLClient.MSqlDbType.Int);
                            }
                            break;
                        case 3:
                            if (kategoriID > 0)
                            {
                                q.CommandText += " and KategoriID=@KategoriID ";
                                q.Parameters.Add("KategoriID", this.kategoriLookUpEdit.EditValue, BAYMYO.MultiSQLClient.MSqlDbType.Int);
                            }
                            if (firmaID > 0)
                            {
                                q.CommandText += " and FirmaID<>@FirmaID ";
                                q.Parameters.Add("FirmaID", this.firmaLookUpEdit.EditValue, BAYMYO.MultiSQLClient.MSqlDbType.Int);
                            }
                            break;
                    }

                    if (q.Execute())
                        this.DialogResult = DialogResult.OK;
                    else
                    {
                        Commons.Status("İşleminiz gerçekleştirilemedi lütfen tekrar deneyiniz.");
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKS", 5) + ex.Message);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void vazgecButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}