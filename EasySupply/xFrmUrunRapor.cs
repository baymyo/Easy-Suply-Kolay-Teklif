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
    public partial class xFrmUrunRapor : DevExpress.XtraEditors.XtraForm
    {
        public void SetCurrencyAndLangs()
        {
            try
            {
                fieldFirmaKod1.Caption = L.TedarikciFirma;
                fieldKategoriAdi1.Caption = L.Kategori;
                fieldUrunAdi1.Caption = L.UrunAciklama;
                fieldFiyat1.Caption = L.AlisFiyati;
                fieldTutar.Caption = L.SatisFiyati;
                fieldKarOran.Caption = L.KarOrani;

                this.fieldFiyat1.CellFormat.FormatString = this.fieldTutar.CellFormat.FormatString = Commons.Kur0Format;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUR", 1) + ex.Message);
            }
        }

        public void CreateFile(string path, FileType type)
        {
            try
            {
                switch (type)
                {
                    case FileType.PDF:
                        this.urunlerPivotGridControl.ExportToPdf(path);
                        break;
                    case FileType.Excel:
                        this.urunlerPivotGridControl.ExportToXls(path);
                        break;
                    case FileType.ExcelX:
                        this.urunlerPivotGridControl.ExportToXlsx(path);
                        break;
                    case FileType.Word:
                        this.urunlerPivotGridControl.ExportToRtf(path);
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUR", 2) + ex.Message);
            }
        }
        public void GetUrunRapor()
        {
            try
            {
                this.urunRaporBindingSource.DataSource = UrunRaporMethods.GetSelect();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUR", 2) + ex.Message);
            }
        }

        public xFrmUrunRapor()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        private void xFrmUrunRapor_Load(object sender, EventArgs e)
        {
            Commons.Status(this.Text + " ekranı açıldı.");
            GetUrunRapor();
        }

        private void xFrmUrunRapor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}