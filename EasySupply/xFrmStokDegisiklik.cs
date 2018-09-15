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
    public partial class xFrmStokDegisiklik : DevExpress.XtraEditors.XtraForm
    {
        public List<Stok> Data { get; set; }
        public string Mesaj { set { this.infoLabel.Text = value; } }

        public object KategoriData { set { this.kategoriBindingSource.DataSource = value; } }
        public object UrunData { set { this.urunBindingSource.DataSource = value; } }
        public object FirmaData { set { this.firmaBindingSource.DataSource = value; } }

        public void SetCurrencyAndLangs()
        {
            try
            {
                string
                    symbolKur0 = " (" + Commons.Kur0Symbol + ")",
                    formatKur0 = Commons.Kur0Format;

                this.colUrunID.Caption = L.UrunAciklama;
                this.colKategoriID.Caption = L.Kategori;
                this.colKarOran.Caption = L.KarOrani;
                this.colGuncellemeTarihi.Caption = L.GuncellemeTarihi;
                this.colFiyat.Caption = L.AlisFiyati + symbolKur0;
                this.colTutar.Caption = L.SatisFiyati + symbolKur0;

                this.colFiyat.DisplayFormat.FormatString = this.colTutar.DisplayFormat.FormatString = formatKur0;
                this.colFiyat.DisplayFormat.FormatType = this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;

                this.onaylaButton.Text = L.Tamam;
                this.vazgecButton.Text = L.Vazgec;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FDS", 1) + ex.Message);
            }
        }

        public xFrmStokDegisiklik()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        private void xFrmStokDegisiklik_Load(object sender, EventArgs e)
        {
            this.stokBindingSource.DataSource = Data;
        }

        private void stokGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Delete:
                    this.stokGridView.DeleteSelectedRows();
                    break;
            }
        }

        private void onaylaButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void vazgecButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}