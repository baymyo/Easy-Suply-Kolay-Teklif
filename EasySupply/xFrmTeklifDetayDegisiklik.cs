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
    public partial class xFrmTeklifDetayDegisiklik : DevExpress.XtraEditors.XtraForm
    {
        public List<TeklifDetay> Data { get; set; }
        public string Mesaj { set { this.infoLabel.Text = value; } }

        public void SetCurrencyAndLangs()
        {
            try
            {
                string
                    symbolKur0 = " (" + Commons.Kur0Symbol + ")",
                    formatKur0 = Commons.Kur0Format;
                this.colUrunAdi.Caption = L.UrunAciklama;
                this.colFirmaAdi.Caption = L.TedarikciFirma;
                this.colAdet.Caption = L.Miktar;
                this.colKarOrani.Caption = L.KarOrani;
                this.colKdv.Caption = L.KDV;
                this.colBirimFiyati.Caption = L.AlisFiyati + symbolKur0;
                this.colAlisTutar.Caption = L.AlisTutar + symbolKur0;
                this.colSatisFiyati.Caption = L.SatisFiyati + symbolKur0;
                this.colSatisTutar.Caption = L.SatisTutar + symbolKur0;
                this.colKazanc.Caption = L.NetKar + symbolKur0;
                this.colBirimFiyati.DisplayFormat.FormatString = this.colAlisTutar.DisplayFormat.FormatString = this.colSatisFiyati.DisplayFormat.FormatString = this.colSatisTutar.DisplayFormat.FormatString = this.colKazanc.DisplayFormat.FormatString = formatKur0;
                this.colBirimFiyati.DisplayFormat.FormatType = this.colAlisTutar.DisplayFormat.FormatType = this.colSatisFiyati.DisplayFormat.FormatType = this.colSatisTutar.DisplayFormat.FormatType = this.colKazanc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FDT", 1) + ex.Message);
            }
        }

        public xFrmTeklifDetayDegisiklik()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        void xFrmTeklifDetayDegisiklik_Load(object sender, EventArgs e)
        {
            try
            {
                this.teklifDetayBindingSource.DataSource = Data;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FDT", 2) + ex.Message);
            }
        }

        void teklifDetayGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Delete:
                        this.teklifDetayGridView.DeleteSelectedRows();
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FDT", 3) + ex.Message);
            }
        }

        void onaylaButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        void vazgecButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}