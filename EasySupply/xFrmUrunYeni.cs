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
    public partial class xFrmUrunYeni : DevExpress.XtraEditors.XtraForm
    {
        public void SetCurrencyAndLangs()
        {
            try
            {
                colAdi.Caption = L.UrunAciklama;
                colMiktar.Caption = L.Miktar;
                colBirim.Caption = L.Birim;
                colKdv.Caption = L.KDV;

                this.onaylaButton.Text = L.Tamam;
                this.vazgecButton.Text = L.Vazgec;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUY", 1) + ex.Message);
            }
        }

        public List<Urun> Data { get; set; }
        public string Mesaj { set { this.infoLabel.Text = value; } }

        public xFrmUrunYeni()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        private void xFrmUrunYeni_Load(object sender, EventArgs e)
        {
            urunBindingSource.DataSource = Data;
        }

        private void urunGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Delete:
                        this.urunGridView.DeleteSelectedRows();
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUY", 2) + ex.Message);
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