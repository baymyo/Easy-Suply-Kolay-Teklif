using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EasySupply
{
    public partial class xFrmUrun : DevExpress.XtraEditors.XtraForm
    {
        public void SetCurrencyAndLangs()
        {
            try
            {
                urunGroupControl.Text = L.YeniUrun;
                yeniUrunGroupControl.Text = L.YeniUrunKategoriBazinda;

                colKategoriID.Caption = lblKategori.Text = L.Kategori;
                colAdi.Caption = lblUrunAdi.Text = L.UrunAciklama;
                colMiktar.Caption = lblMiktar.Text = L.Miktar;
                colBirim.Caption = lblBirim.Text = L.Birim;
                colKdv.Caption = lblKdv.Text = L.KDV;

                kaydetButton.Text = L.Kaydet;
                yeniButton.Text = L.YeniKayit;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUN", 1) + ex.Message);
            }
        }

        public void CreateFile(string path, FileType type)
        {
            try
            {
                switch (type)
                {
                    case FileType.PDF:
                        this.urunGridControl.ExportToPdf(path);
                        break;
                    case FileType.Excel:
                        DevExpress.XtraPrinting.XlsExportOptions opt = new DevExpress.XtraPrinting.XlsExportOptions();
                        opt.SheetName = "DATA";
                        this.urunGridControl.ExportToXls(path, opt);
                        break;
                    case FileType.ExcelX:
                        this.urunGridControl.ExportToXlsx(path);
                        break;
                    case FileType.Word:
                        this.urunGridControl.ExportToRtf(path);
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUN", 2) + ex.Message);
            }
        }
        public void GetKategoriler()
        {
            this.kategoriBindingSource.DataSource = KategoriMethods.GetSelect();
        }
        public void GetData()
        {
            this.urunBindingSource.DataSource = UrunMethods.GetSelect();
            isRecord = false;
        }
        public void GetData(int kategoriID)
        {
            this.urunBindingSource.DataSource = UrunMethods.GetSelect(kategoriID);
            isRecord = false;
        }

        public xFrmUrun()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }
        void xFrmUrun_Load(object sender, EventArgs e)
        {
            try
            {
                Commons.Status(this.Text + " ekranı açıldı.");
                if (Commons.AppSettings.UNITS.Contains(","))
                {
                    string[] b = Commons.AppSettings.UNITS.Split(',');
                    if (b.Length > 0)
                    {
                        this.rpsBirimComboBox.Items.AddRange(b);
                        this.cmbBirim.Properties.Items.AddRange(b);
                    }
                }
                GetKategoriler();
                GetData();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUN", 3) + ex.Message);
            }
        }

        void enterTab_KeyDown(object sender, KeyEventArgs e)
        {
            // Tüm metin kutusu ve seçilebilir kutu alanlarımızın KeyDown olay(event)ında
            // çalıştırmak üzere bu event kod bloğunu atadık...
            switch (e.KeyData)
            {
                // Metin kutusu içerisinde Enter'a basılma anı kontrolü
                case Keys.Enter:
                    // Bu aşamada sanki tab'a tıklanmış gibi işlem gerçekleşiyor
                    // Ve tab sırasına göre sonraki kutuya gidiyor.
                    SelectNextControl(this.ActiveControl, true, true, true, true);
                    break;
            }
        }
        void urunGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Delete:
                        Urun u = urunGridView.GetFocusedRow() as Urun;
                        if (MessageBox.Show("\"" + u.Adi + "\" isimli ürünü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            if (UrunMethods.Delete(u) > 0)
                            {
                                urunGridView.DeleteSelectedRows();
                                Commons.Status("\"" + u.Adi + "\" isimli ürünü silme işlemi gerçekleştirildi!");
                                Commons.Update(TableNames.Urun);
                            }
                            else
                                Commons.Status("\"" + u.Adi + "\" isimli ürünü silme işleminiz başarısız!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUN", 4) + ex.Message);
            }
        }

        bool isRecord;
        void kaydetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.urunGridView.GetFocusedRow() != null)
                {
                    Urun u = urunGridView.GetFocusedRow() as Urun;
                    if (Commons.IsNullOrEmpty(dxErrorProvider1, this.urunGroupControl.Controls))
                        return;
                    else if (u.KategoriID <= 0)
                    {
                        dxErrorProvider1.SetError(kategoriAktarimLookUpEdit, L.BosGecilemez);
                        return;
                    }
                    if (u.Miktar < 0)
                        u.Miktar = 1;
                    u.Tarih = DateTime.Now;
                    if (u.ID <= 0)
                    {
                        u.ID = UrunMethods.Insert(u);
                        isRecord = u.ID > 0;
                    }
                    else
                        isRecord = UrunMethods.Update(u) > 0;
                    if (isRecord)
                    {
                        Commons.Status("\"" + u.Adi + "\" isimli ürün ile ilgili işleminiz başarılı bir şekilde gerçekleştirildi!");
                        Commons.Update(TableNames.Urun);
                        isRecord = false;
                    }
                    else
                        Commons.Status("\"" + u.Adi + "\" isimli ürün ile ilgili işleminiz başarısız!");
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUN", 5) + ex.Message);
            }
        }
        void yeniButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isRecord)
                {
                    urunBindingSource.AddNew();
                    kategoriAktarimLookUpEdit.Focus();
                    isRecord = true;
                }
                else
                    urunGridView.FocusedRowHandle = urunGridView.RowCount - 1;
                clcMiktar.EditValue = 1;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUN", 6) + ex.Message);
            }
        }
        void splitterControl1_DoubleClick(object sender, EventArgs e)
        {
            if (urunGroupControl.Width < 280 || urunGroupControl.Width > 280)
                urunGroupControl.Width = 280;
            else
                urunGroupControl.Width = 25;
        }

        void GridChange(string p)
        {
            byte index = 0;
            switch (p)
            {
                case "EXCEL":
                    this.urunGridView.OptionsView.ShowGroupPanel = false;
                    this.urunGridView.ClearGrouping();
                    foreach (DevExpress.XtraGrid.Columns.GridColumn item in this.urunGridView.Columns)
                    {
                        switch (item.FieldName)
                        {
                            case "ID":
                            case "Adi":
                            case "":
                                item.VisibleIndex = index++;
                                item.Visible = true;
                                break;
                            default:
                                item.VisibleIndex = -1;
                                item.Visible = false;
                                break;
                        }
                    }
                    index = 0;
                    break;
                default:
                    foreach (DevExpress.XtraGrid.Columns.GridColumn item in this.urunGridView.Columns)
                    {
                        switch (item.FieldName)
                        {
                            case "KategoriID":
                            case "Tarih":
                            case "":
                                item.VisibleIndex = -1;
                                item.Visible = false;
                                break;
                            default:
                                item.VisibleIndex = index++;
                                item.Visible = true;
                                break;
                        }
                    }
                    index = 0;
                    break;
            }
        }
        void urunSuzButton_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori k = this.kategoriAktarimLookUpEdit.GetSelectedDataRow() as Kategori;
                if (k != null)
                {
                    GetData(k.ID);
                    Commons.Status(string.Format(L.KategoridekiUrunListesi, k.Adi));
                }
                else
                    Commons.Status("Lütfen süzülecek kategoriyi seçiniz.");
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUN", 7) + ex.Message);
            }
        }
        void urunIceAktarButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog file = new OpenFileDialog())
                {
                    file.Title = L.AktarilacakExcelDosyasi;
                    Kategori k = (this.kategoriAktarimLookUpEdit.GetSelectedDataRow() as Kategori);
                    if (k != null)
                        file.FileName = k.Adi.Replace("/", "").Replace("\\", "") + " - " + L.AlisFiyati + " - " + DateTime.Now.ToString("yyyy-MM-dd") + ".xls";
                    else
                    {
                        dxErrorProvider1.SetError(kategoriAktarimLookUpEdit, L.BosGecilemez);
                        return;
                    }
                    file.Filter = "Excel (2003)|*.xls";
                    switch (file.ShowDialog())
                    {
                        case System.Windows.Forms.DialogResult.OK:
                        case System.Windows.Forms.DialogResult.Yes:
                            using (BAYMYO.MultiSQLClient.MDataAdapter dap = new BAYMYO.MultiSQLClient.MDataAdapter("select * from [DATA$A:D]", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file.FileName + ";Extended Properties=Excel 8.0", BAYMYO.MultiSQLClient.MClientProvider.OleDb))
                            {
                                using (DataTable dt = new DataTable("ProductList"))
                                {
                                    dap.Fill(dt);
                                    if (dt.Rows.Count > 0)
                                    {
                                        using (xFrmUrunYeni sd = new xFrmUrunYeni())
                                        {
                                            sd.Text = L.YeniUrunKategoriBazinda;
                                            sd.Mesaj = string.Format(L.KategoridekiUrunListesi, k.Adi);
                                            sd.Data = new List<Urun>();
                                            foreach (DataRow dr in dt.Rows)
                                            {
                                                Urun u = new Urun
                                                {
                                                    KategoriID = k.ID,
                                                    Kod = Commons.CreateImpaCode(dr[0]),//BAYMYO.UI.Converts.NullToInt(BAYMYO.UI.Converts.NullToString(dr[0]).Replace(" ", "").Trim()).ToString("00 00 00"),
                                                    Adi = BAYMYO.UI.Converts.NullToString(dr[1]),
                                                    Miktar = 1,
                                                    Birim = BAYMYO.UI.Converts.NullToString(dr[2]),
                                                    Kdv = BAYMYO.UI.Converts.NullToFloat(dr[3]),
                                                    Tarih = DateTime.Now
                                                };
                                                if (!string.IsNullOrWhiteSpace(u.Adi))
                                                    sd.Data.Add(u);
                                            }
                                            switch (sd.ShowDialog())
                                            {
                                                case DialogResult.Yes:
                                                    Commons.Loading("Product updates.. .");
                                                    foreach (Urun stk in sd.Data)
                                                        UrunMethods.Insert(stk);
                                                    Commons.Update(TableNames.Urun);
                                                    Commons.Status(string.Format(L.KategoriUrunlerEklendi, k.Adi));
                                                    dxErrorProvider1.ClearErrors();
                                                    GetData(k.ID);
                                                    break;
                                            }
                                            sd.Data = null;
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUN", 8) + ex.Message);
            }
            finally
            {
                Commons.Loaded();
            }
        }
        void urunDisaAktarButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog file = new SaveFileDialog())
                {
                    file.Title = L.AktarilacakExcelDosyasi;
                    Kategori k = this.kategoriAktarimLookUpEdit.GetSelectedDataRow() as Kategori;
                    if (k != null)
                        file.FileName = k.Adi.Replace("/", "").Replace("\\", "") + " - " + L.AlisFiyati + " - " + DateTime.Now.ToString("yyyy-MM-dd") + ".xls";
                    else
                        file.FileName = "ALL PRODUCTS " + L.AlisFiyati + " - " + DateTime.Now.ToString("yyyy-MM-dd") + ".xls";
                    file.Filter = "Excel (2003)|*.xls";
                    switch (file.ShowDialog())
                    {
                        case System.Windows.Forms.DialogResult.OK:
                        case System.Windows.Forms.DialogResult.Yes:
                            DevExpress.XtraPrinting.XlsExportOptions opt = new DevExpress.XtraPrinting.XlsExportOptions();
                            opt.SheetName = "DATA";
                            GridChange("EXCEL");
                            this.urunGridView.ExportToXls(file.FileName, opt);
                            GridChange("");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUN", 9) + ex.Message);
            }
        }

        void excelAktarimButton_Click(object sender, EventArgs e)
        {
            Commons.ProductImportFile();
        }
    }
}