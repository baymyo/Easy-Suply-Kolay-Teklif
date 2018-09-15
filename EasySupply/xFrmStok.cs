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
    public partial class xFrmStok : DevExpress.XtraEditors.XtraForm
    {
        List<Stok> m_StokData = null;
        List<Urun> m_UrunData = null;
        #region --- METHODS ---
        public void SetCurrencyAndLangs()
        {
            try
            {
                string
                    symbolKur0 = " (" + Commons.Kur0Symbol + ")",
                    symbolKur1 = " (" + Commons.Kur1Symbol + ")",
                    symbolKur2 = " (" + Commons.Kur2Symbol + ")",
                    formatKur0 = Commons.Kur0Format,
                    formatKur1 = Commons.Kur1Format,
                    formatKur2 = Commons.Kur2Format;

                this.stokGirisGrupControl.Text = L.StokGirisi;
                this.lblTedarikciFirma.Text = this.tedarikciFirmaGroupControl.Text = L.TedarikciFirma;
                this.lblBirimFiyat.Text = L.AlisFiyati + " (" + Commons.Kur0Code + ")";
                this.lblCurrency.Text = Commons.AppSettings.DEFAULT_CURRENCY.Description;
                this.firmaDisaAktarButton.Text = L.DisariAktar;
                this.firmaIceAktarButton.Text = L.IceriAktar;
                this.firmaSuzButton.Text = L.Suz;
                this.colUrunID.Caption = this.lblUrun.Text = L.UrunAciklama;
                this.colKategoriID.Caption = this.lblKategori.Text = L.Kategori;
                this.colKarOran.Caption = this.lblBirimKarOrani.Text = L.KarOrani;
                this.colEklenmeTarihi.Caption = L.EklenmeTarihi;
                this.colGuncellemeTarihi.Caption = L.GuncellemeTarihi;
                this.colFiyat.Caption = L.AlisFiyati + symbolKur0;
                this.colTutar.Caption = L.SatisFiyati + symbolKur0;
                this.colFiyatKur1.Caption = this.colTutarKur1.Caption = Commons.Kur1Code + symbolKur1;
                this.colFiyatKur2.Caption = this.colTutarKur2.Caption = Commons.Kur2Code + symbolKur2;

                this.colFiyat.DisplayFormat.FormatString = this.colTutar.DisplayFormat.FormatString = formatKur0;
                this.colFiyatKur1.DisplayFormat.FormatString = this.colTutarKur1.DisplayFormat.FormatString = formatKur1;
                this.colFiyatKur2.DisplayFormat.FormatString = this.colTutarKur2.DisplayFormat.FormatString = formatKur2;

                this.colFiyat.DisplayFormat.FormatType = this.colTutar.DisplayFormat.FormatType =
                this.colFiyatKur1.DisplayFormat.FormatType = this.colTutarKur1.DisplayFormat.FormatType =
                this.colFiyatKur2.DisplayFormat.FormatType = this.colTutarKur2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 1) + ex.Message);
            }
        }
        public void CreateFile(string path, FileType type)
        {
            switch (type)
            {
                case FileType.PDF:
                    this.stokGridView.ExportToPdf(path);
                    break;
                case FileType.Excel:
                    DevExpress.XtraPrinting.XlsExportOptions opt = new DevExpress.XtraPrinting.XlsExportOptions();
                    opt.SheetName = "DATA";
                    this.stokGridView.ExportToXls(path, opt);
                    break;
                case FileType.ExcelX:
                    this.stokGridView.ExportToXlsx(path);
                    break;
                case FileType.Word:
                    this.stokGridView.ExportToRtf(path);
                    break;
            }
        }
        public void GetFirmalar()
        {
            try
            {
                this.firmaBindingSource.DataSource = FirmaMethods.GetSelect();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 2) + ex.Message);
            }
        }
        public void GetUrunler()
        {
            this.m_UrunData = UrunMethods.GetSelect();
            this.urunGridBindingSource.DataSource = m_UrunData;
        }
        public void GetUrunlerForKategori()
        {
            this.urunBindingSource.DataSource = UrunMethods.GetSelect(Convert.ToInt32(this.kategoriLookUpEdit.EditValue));
        }
        public void GetKategoriler()
        {
            this.kategoriBindingSource.DataSource = KategoriMethods.GetSelect();
        }
        public void GetData()
        {
            try
            {
                isExcelOkey = false;
                GridChange("DATA");
                this.m_StokData = StokMethods.GetSelect();
                this.stokBindingSource.DataSource = m_StokData;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 3) + ex.Message);
            }
        }
        public void GetDataExcel()
        {
            try
            {
                GridChange("EXCEL");
                this.m_StokData = StokMethods.GetSelect();
                Firma f = this.firmaStokLookUpEdit.GetSelectedDataRow() as Firma;
                if (f != null)
                {
                    this.stokBindingSource.DataSource = this.m_StokData.Where(x => x.FirmaID.Equals(f.ID)).ToList();
                    Commons.Status(string.Format(L.FirmaninFiyatListesi, f.Adi));
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 4) + ex.Message);
            }
        }
        void GridChange(string p)
        {
            byte index = 0;
            switch (p)
            {
                case "EXCEL":
                    this.stokGridView.OptionsView.ShowGroupPanel = false;
                    this.stokGridView.ClearGrouping();
                    foreach (DevExpress.XtraGrid.Columns.GridColumn item in this.stokGridView.Columns)
                    {
                        switch (item.FieldName)
                        {
                            case "ID":
                            case "UrunID":
                            case "Fiyat":
                            case "GuncellemeTarihi":
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
                    foreach (DevExpress.XtraGrid.Columns.GridColumn item in this.stokGridView.Columns)
                    {
                        switch (item.FieldName)
                        {
                            case "ID":
                            case "EklenmeTarihi":
                            case "Updated":
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
                    this.stokGridView.OptionsView.ShowGroupPanel = true;
                    this.stokGridView.GroupCount = 2;
                    this.stokGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
                        new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKategoriID, DevExpress.Data.ColumnSortOrder.Ascending),
                        new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFirmaID, DevExpress.Data.ColumnSortOrder.Ascending)});
                    break;
            }
        }
        #endregion

        public xFrmStok()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        void xFrmStok_Load(object sender, EventArgs e)
        {
            try
            {
                Commons.Status(this.Text + " ekranı açıldı.");
                GetKategoriler();
                GetUrunler();
                GetFirmalar();
                GetData();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 4) + ex.Message);
            }
        }

        void kategoriLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            GetUrunlerForKategori();
        }
        void urunLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Urun u = this.urunLookUpEdit.GetSelectedDataRow() as Urun;
                if (u != null)
                    this.infoLabel.Text = u.Miktar + " " + u.Birim;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 5) + ex.Message);
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
        void karOranCalcEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    this.kaydetButton.PerformClick();
                    break;
            }
        }

        Stok s = null;
        void kaydetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (s == null)
                    s = new Stok();
                s.KategoriID = Convert.ToInt32(this.kategoriLookUpEdit.EditValue);
                s.UrunID = Convert.ToInt32(this.urunLookUpEdit.EditValue);
                s.FirmaID = Convert.ToInt32(this.firmaLookUpEdit.EditValue);
                s.Fiyat = Convert.ToSingle(this.fiyatCalcEdit.Value);
                s.KarOran = Convert.ToSingle(this.karOranCalcEdit.Value);
                s.GuncellemeTarihi = DateTime.Now;
                if (s.KategoriID <= 0 || s.UrunID <= 0 || s.FirmaID <= 0 || s.Fiyat <= 0)
                {
                    Commons.Status("Lütfen bilgi giriş alanlarınızın tamamının eksiksiz olduğundan emin olunuz!");
                    return;
                }
                bool isOkey;
                if (s.ID <= 0)
                {
                    s.EklenmeTarihi = s.GuncellemeTarihi;
                    isOkey = StokMethods.Insert(s) > 0;
                }
                else
                    isOkey = StokMethods.Update(s) > 0;
                if (isOkey)
                {
                    Commons.Update(TableNames.Stok);
                    Commons.Status("\"" + this.stokGridView.GetFocusedRowCellDisplayText("UrunID") + "\" ürün için stok kayıt işlemi başarılı bir şekilde gerçekleştirildi.");
                    if (isExcelOkey)
                        GetDataExcel();
                    else
                        GetData();
                }
                else
                    Commons.Status("Stok kayıt işlemi gerçekleştirilemedi.");
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 6) + ex.Message);
            }
            finally
            {
                s = null;
            }
        }
        void stokGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                s = this.stokGridView.GetFocusedRow() as Stok;
                this.kategoriLookUpEdit.EditValue = s.KategoriID;
                this.urunLookUpEdit.EditValue = s.UrunID;
                this.firmaLookUpEdit.EditValue = s.FirmaID;
                this.fiyatCalcEdit.EditValue = s.Fiyat;
                this.karOranCalcEdit.EditValue = s.KarOran;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 7) + ex.Message);
            }
        }
        void stokGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Enter:
                        int index = this.stokGridView.FocusedRowHandle + 1;
                        if (index >= this.stokGridView.RowCount)
                            index = 0;
                        this.stokGridView.FocusedRowHandle = index;
                        break;
                    case Keys.Delete:
                        if (MessageBox.Show("Stokdaki \"" + this.stokGridView.GetFocusedRowCellDisplayText("UrunID") + "\" isimli ürünü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            if (StokMethods.Delete(this.stokGridView.GetFocusedRow() as Stok) > 0)
                            {
                                Commons.Update(TableNames.Stok);
                                Commons.Status("Stokdaki \"" + this.stokGridView.GetFocusedRowCellDisplayText("UrunID") + "\" isimli ürünü silme işlemi gerçekleştirildi!");
                                if (isExcelOkey)
                                    GetDataExcel();
                                else
                                    GetData();
                            }
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 8) + ex.Message);
            }
        }
        void stokGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                Stok s = this.stokGridView.GetFocusedRow() as Stok;
                if (s.ID > 0)
                {
                    s.GuncellemeTarihi = DateTime.Now;
                    if (StokMethods.Update(s) > 0)
                    {
                        Commons.Update(TableNames.Stok);
                        Commons.Status("Stokdaki \"" + this.stokGridView.GetFocusedRowCellDisplayText("UrunID") + "\" isimli ürünü bilgisini güncelleme işlemi başarılı bir şekilde gerçekleştirildi!");
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 9) + ex.Message);
            }
        }

        bool isExcelOkey = false;
        void firmaSuzButton_Click(object sender, EventArgs e)
        {
            try
            {
                Firma f = this.firmaStokLookUpEdit.GetSelectedDataRow() as Firma;
                if (f != null)
                {
                    isExcelOkey = true;
                    GridChange("EXCEL");
                    this.stokBindingSource.DataSource = this.m_StokData.Where(x => x.FirmaID.Equals(f.ID)).ToList();
                    Commons.Status(string.Format(L.FirmaninFiyatListesi, f.Adi));
                }
                else
                    Commons.Status("Lütfen süzülecek tedarikçi firmayı seçiniz.");
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 10) + ex.Message);
            }
        }
        void firmaIceAktarButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isUpdate = Commons.ShowBox(QuestionType.StokGirisi);
                using (OpenFileDialog file = new OpenFileDialog())
                {
                    file.Title = L.AktarilacakExcelDosyasi;
                    Firma f = (this.firmaStokLookUpEdit.GetSelectedDataRow() as Firma);
                    if (f != null & isUpdate)
                        file.FileName = f.Adi + " - " + L.AlisFiyati + " - " + DateTime.Now.ToString("yyyy-MM-dd") + ".xls";
                    else
                        file.FileName = L.AlisFiyati + " - " + DateTime.Now.ToString("yyyy-MM-dd") + ".xls";
                    file.Filter = "Excel (2003)|*.xls";
                    switch (file.ShowDialog())
                    {
                        case System.Windows.Forms.DialogResult.OK:
                        case System.Windows.Forms.DialogResult.Yes:
                            if (isUpdate)
                            {
                                #region --- Güncel Fiyat Listesi ---
                                // 0:ID	- 1:Ürün Açıklaması	- 2:Birim Fiyatı - 3:Güncelleme Tarihi
                                using (BAYMYO.MultiSQLClient.MDataAdapter dap = new BAYMYO.MultiSQLClient.MDataAdapter("select * from [DATA$A:D]", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file.FileName + ";Extended Properties=Excel 8.0", BAYMYO.MultiSQLClient.MClientProvider.OleDb))
                                {
                                    using (DataTable dt = new DataTable("ProductList"))
                                    {
                                        dap.Fill(dt);
                                        if (dt.Rows.Count > 0)
                                        {
                                            using (xFrmStokDegisiklik sd = new xFrmStokDegisiklik())
                                            {
                                                sd.Text = string.Format(L.FirmaninFiyatListesi, f.Adi);
                                                sd.Mesaj = L.AlgilananDegisiklikler;
                                                sd.Data = new List<Stok>();
                                                sd.KategoriData = this.kategoriBindingSource.DataSource;
                                                sd.UrunData = this.urunGridBindingSource.DataSource;
                                                sd.FirmaData = this.firmaBindingSource.DataSource;
                                                Stok s = null;
                                                float fiyat = 0;
                                                foreach (DataRow dr in dt.Rows)
                                                {
                                                    s = this.m_StokData.Find(x => x.ID.Equals(BAYMYO.UI.Converts.NullToInt(dr[0])));
                                                    if (s != null)
                                                    {
                                                        fiyat = BAYMYO.UI.Converts.NullToFloat(dr[2]);
                                                        s.GuncellemeTarihi = DateTime.Now;
                                                        s.Changed = false;
                                                        if (s.Fiyat != fiyat)
                                                        {
                                                            s.Fiyat = fiyat;
                                                            s.Changed = true;
                                                        }
                                                        sd.Data.Add(s);
                                                    }
                                                }
                                                switch (sd.ShowDialog())
                                                {
                                                    case DialogResult.Yes:
                                                        Commons.Loading("Product updates.. .");
                                                        bool isOkey = false;
                                                        foreach (Stok stk in sd.Data)
                                                            isOkey = StokMethods.Update(stk) > 0;
                                                        if (isOkey)
                                                        {
                                                            GetDataExcel();
                                                            Commons.Status(L.UrunlerGuncellendi);
                                                        }
                                                        break;
                                                }
                                            }
                                        }
                                    }
                                }
                                #endregion
                            }
                            else
                            {
                                #region --- Yeni Ürün Listesi ---
                                // 0:Urun ID - 1:Ürün Açıklaması - 2:Birim Fiyatı - 3:Kar Orani
                                using (BAYMYO.MultiSQLClient.MDataAdapter dap = new BAYMYO.MultiSQLClient.MDataAdapter("select * from [DATA$A:E]", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file.FileName + ";Extended Properties=Excel 8.0", BAYMYO.MultiSQLClient.MClientProvider.OleDb))
                                {
                                    using (DataTable dt = new DataTable("ProductList"))
                                    {
                                        dap.Fill(dt);
                                        using (xFrmStokDegisiklik sd = new xFrmStokDegisiklik())
                                        {
                                            sd.Text = string.Format(L.FirmaninFiyatListesi, f.Adi);
                                            sd.Mesaj = L.AlgilananDegisiklikler;
                                            sd.Data = new List<Stok>();
                                            sd.KategoriData = this.kategoriBindingSource.DataSource;
                                            sd.UrunData = this.urunGridBindingSource.DataSource;
                                            sd.FirmaData = this.firmaBindingSource.DataSource;
                                            Urun u = null;
                                            float fiyat = 0, karOrani = 0;
                                            int firmaID = Convert.ToInt32(this.firmaStokLookUpEdit.EditValue);
                                            foreach (DataRow dr in dt.Rows)
                                            {
                                                u = this.m_UrunData.Find(x => x.ID.Equals(BAYMYO.UI.Converts.NullToInt(dr[0])));
                                                fiyat = BAYMYO.UI.Converts.NullToFloat(dr[2]);
                                                if (u != null & fiyat > 0)
                                                {
                                                    karOrani = BAYMYO.UI.Converts.NullToFloat(dr[3]);
                                                    Stok s = this.m_StokData.Find(p => p.FirmaID.Equals(firmaID) & p.KategoriID.Equals(u.KategoriID) & p.UrunID.Equals(u.ID));
                                                    if (s == null)
                                                        s = new Stok
                                                        {
                                                            KategoriID = u.KategoriID,
                                                            UrunID = u.ID,
                                                            FirmaID = firmaID,
                                                            Fiyat = fiyat,
                                                            KarOran = (karOrani > 0 ? karOrani : 0.45f),
                                                            GuncellemeTarihi = DateTime.Now
                                                        };
                                                    else
                                                    {
                                                        s.Fiyat = fiyat;
                                                        s.KarOran = (karOrani > 0 ? karOrani : 0.45f);
                                                        s.GuncellemeTarihi = DateTime.Now;
                                                        s.Changed = true;
                                                    }
                                                    sd.Data.Add(s);
                                                }
                                            }
                                            switch (sd.ShowDialog())
                                            {
                                                case DialogResult.Yes:
                                                    Commons.Loading("Product updates.. .");
                                                    bool isOkey = false;
                                                    foreach (Stok stk in sd.Data)
                                                    {
                                                        if (stk.ID > 0)
                                                            isOkey = StokMethods.Update(stk) > 0;
                                                        else
                                                            isOkey = StokMethods.Insert(stk) > 0;
                                                    }
                                                    if (isOkey)
                                                    {
                                                        GetDataExcel();
                                                        Commons.Status(L.UrunlerGuncellendi);
                                                    }
                                                    break;
                                            }
                                            sd.Data = null;
                                        }
                                    }
                                }
                                #endregion
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 11) + ex.Message);
            }
            finally
            {
                Commons.Loaded();
            }
        }
        void firmaDisaAktarButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog file = new SaveFileDialog())
                {
                    file.Title = L.AktarilacakExcelDosyasi;
                    Firma f = (this.firmaStokLookUpEdit.GetSelectedDataRow() as Firma);
                    if (f != null)
                        file.FileName = f.Adi + " - " + L.AlisFiyati + " - " + DateTime.Now.ToString("yyyy-MM-dd") + ".xls";
                    else
                        file.FileName = L.AlisFiyati + " - " + DateTime.Now.ToString("yyyy-MM-dd") + ".xls";
                    file.Filter = "Excel (2003)|*.xls";
                    switch (file.ShowDialog())
                    {
                        case System.Windows.Forms.DialogResult.OK:
                        case System.Windows.Forms.DialogResult.Yes:
                            DevExpress.XtraPrinting.XlsExportOptions opt = new DevExpress.XtraPrinting.XlsExportOptions();
                            opt.SheetName = "DATA";
                            this.stokGridView.ExportToXls(file.FileName, opt);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 12) + ex.Message);
            }
        }

        private void karOraniDegistirPictureEdit_Click(object sender, EventArgs e)
        {
            try
            {
                xFrmStokKarDegisiklik s = new xFrmStokKarDegisiklik();
                switch (s.ShowDialog())
                {
                    case DialogResult.Cancel:
                    case DialogResult.Ignore:
                    case DialogResult.No:
                        Commons.Status("Stok tablosunda kâr oranları değiştirilme işlemi iptal edildi.");
                        break;
                    case DialogResult.OK:
                    case DialogResult.Retry:
                    case DialogResult.Yes:
                        GetData();
                        Commons.Status("Stok tablosunda kâr oranları değiştirildi.");
                        break;
                }  
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 13) + ex.Message);
            }
            finally
            {
                Commons.Loaded();
            }
        }
    }
}