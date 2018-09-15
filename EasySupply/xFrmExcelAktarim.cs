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
    public partial class xFrmExcelAktarim : DevExpress.XtraEditors.XtraForm
    {
        Teklif t = new Teklif();
        public Teklif TeklifObject
        {
            get { return t; }
            set { t = value; }
        }
        public List<TeklifDetay> TeklifDetaylari { get; set; }
        public List<UrunKatalog> Urunler { get; set; }

        public void SetCurrencyAndLangs()
        {
            try
            {
                turlerRadioGroup.Properties.Items[0].Description = L.TeklifleriBirlestir;
                turlerRadioGroup.Properties.Items[1].Description = L.IDAktarimi;
                turlerRadioGroup.Properties.Items[2].Description = L.DegisiklikAlgila;
                excelAktarimButton.Text = L.IceriAktar;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FEA", 1) + ex.Message);
            }
        }

        public xFrmExcelAktarim()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        void xFrmExcelAktarim_Load(object sender, EventArgs e)
        {

        }

        void excelUrunButton_Click(object sender, EventArgs e)
        {
            bool isOkey = false;
            try
            {
                if (this.excelKarOranCalcEdit.Enabled)
                {
                    if (this.excelKarOranCalcEdit.Value <= 0)
                    {
                        Commons.Status(L.KarOraniBelirle);
                        MessageBox.Show(L.KarOraniBelirle, "Warning");
                        return;
                    }
                }
                using (OpenFileDialog file = new OpenFileDialog())
                {
                    file.Title = L.AktarilacakExcelDosyasi;
                    file.FileName = L.YeniDosyaAdi;
                    file.Filter = "Excel (2003)|*.xls";
                    switch (file.ShowDialog())
                    {
                        case System.Windows.Forms.DialogResult.OK:
                        case System.Windows.Forms.DialogResult.Yes:
                            //0:UrunAdi1 - 1:UrunAdi2 - 2:BirimFiyat - 3:Miktar - 4:Birim - 5:KarOran - 6:ParaBirimi - 7:Tedarikci - 8:KdvOran
                            using (BAYMYO.MultiSQLClient.MDataAdapter dap = new BAYMYO.MultiSQLClient.MDataAdapter("select * from [DATA$A:I]", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file.FileName + ";Extended Properties=Excel 8.0", BAYMYO.MultiSQLClient.MClientProvider.OleDb))
                            {
                                using (DataTable dt = new DataTable("ProductList"))
                                {
                                    dap.Fill(dt);
                                    if (dt.Rows.Count > 0)
                                    {
                                        this.loadProgress.Properties.Maximum = dt.Rows.Count;
                                        int index = 0;
                                        float adet = 0;
                                        using (xFrmTeklifDetayDegisiklik sd = new xFrmTeklifDetayDegisiklik())
                                        {
                                            sd.Text = string.Format("{8}: {9} - {10}: {11} - {0} {2}:{4:##0.0000}|{3}:{5:##0.0000} {1} {2}:{6:##0.0000}|{3}:{7:##0.0000}", L.KurKaydedilen, L.KurYeni, Commons.Kur1Code, Commons.Kur2Code, t.Kur1, t.Kur2, Commons.Kur1, Commons.Kur2, L.GemiAdi, t.GemiAdi, L.BaglamaLimani, t.BaglamaLimani);
                                            sd.Data = new List<TeklifDetay>();
                                            switch (this.turlerRadioGroup.SelectedIndex)
                                            {
                                                case 1:
                                                    sd.Mesaj = L.IDileAktarimMesaji;
                                                    #region --- Urun ID ile Aktarım ---
                                                    foreach (DataRow dr in dt.Rows)
                                                    {
                                                        adet = BAYMYO.UI.Converts.NullToFloat(dr[3]);
                                                        if (adet > 0)
                                                        {
                                                            UrunKatalog sl = Urunler.FindAll(x => x.UrunID.Equals(BAYMYO.UI.Converts.NullToInt(dr[0]))).OrderBy(x => x.Fiyat).Take(1).ElementAt(0);
                                                            if (sl != null)
                                                            {
                                                                using (TeklifDetay td = new TeklifDetay
                                                                {
                                                                    TeklifID = t.ID,
                                                                    StokID = sl.StokID,
                                                                    KategoriID = sl.KategoriID,
                                                                    FirmaID = sl.FirmaID,
                                                                    UrunAdi = sl.UrunAdi,
                                                                    BirimFiyati = sl.Fiyat,
                                                                    KarOrani = sl.KarOran,
                                                                    Miktar = sl.Miktar,
                                                                    Birim = sl.Birim,
                                                                    Kdv = sl.Kdv,
                                                                    Adet = adet
                                                                })
                                                                {
                                                                    sd.Data.Add(td);
                                                                    Application.DoEvents();
                                                                    this.loadProgress.Increment(++index);
                                                                }
                                                            }
                                                        }
                                                    }
                                                    #endregion
                                                    break;
                                                case 2:
                                                    sd.Mesaj = L.MusteriDegisikligiAktarim;
                                                    #region --- Ürün Adı ile Aktarım ---
                                                    foreach (DataRow dr in dt.Rows)
                                                    {
                                                        TeklifDetay td = TeklifDetaylari.Find(x => x.UrunAdi.ToLower().Trim().Equals(BAYMYO.UI.Converts.NullToString(dr[0]).ToLower().Trim(), StringComparison.CurrentCultureIgnoreCase));
                                                        if (td != null)
                                                        {
                                                            adet = BAYMYO.UI.Converts.NullToFloat(dr[3]);
                                                            if (!adet.Equals(td.Adet) || adet.Equals(0))
                                                            {
                                                                td.Adet = adet;
                                                                sd.Data.Add(td);
                                                                Application.DoEvents();
                                                                this.loadProgress.Increment(++index);
                                                            }
                                                            adet = 0;
                                                        }
                                                    }
                                                    #endregion
                                                    break;
                                                default:
                                                    sd.Mesaj = L.DigerFirmadanTeklifAktarim;
                                                    #region --- Genel Aktarım ---
                                                    string paraBirimi = "dft";
                                                    float excelKarOran = BAYMYO.UI.Converts.NullToFloat(this.excelKarOranCalcEdit.Value);
                                                    foreach (DataRow dr in dt.Rows)
                                                    {
                                                        adet = BAYMYO.UI.Converts.NullToFloat(dr[3]);
                                                        if (adet > 0)
                                                        {
                                                            using (TeklifDetay td = new TeklifDetay
                                                            {
                                                                TeklifID = t.ID,
                                                                UrunAdi = BAYMYO.UI.Converts.NullToString(dr[0]) + " " + BAYMYO.UI.Converts.NullToString(dr[1]),
                                                                FirmaAdi = BAYMYO.UI.Converts.NullToString(dr[7]),
                                                                BirimFiyati = BAYMYO.UI.Converts.NullToFloat(dr[2]),
                                                                KarOrani = BAYMYO.UI.Converts.NullToFloat(dr[5]),
                                                                Miktar = 1,
                                                                Birim = BAYMYO.UI.Converts.NullToString(dr[4]),
                                                                Kdv = BAYMYO.UI.Converts.NullToFloat(dr[8]),
                                                                Adet = adet
                                                            })
                                                            {
                                                                if (!string.IsNullOrWhiteSpace(td.UrunAdi) & td.BirimFiyati > 0)
                                                                {
                                                                    paraBirimi = BAYMYO.UI.Converts.NullToString(dr[6]);
                                                                    if (string.IsNullOrWhiteSpace(paraBirimi))
                                                                        paraBirimi = this.excelDovizTipiComboBoxEdit.Text;
                                                                    switch (paraBirimi.ToLower())
                                                                    {
                                                                        case "u":
                                                                        case "$":
                                                                        case "a":
                                                                        case "1":
                                                                            td.BirimFiyati = td.BirimFiyati * Commons.Kur1;
                                                                            break;
                                                                        case "e":
                                                                        case "€":
                                                                        case "b":
                                                                        case "2":
                                                                            td.BirimFiyati = td.BirimFiyati * Commons.Kur2;
                                                                            break;
                                                                    }
                                                                    if (td.KarOrani <= 0)
                                                                        td.KarOrani = excelKarOran;
                                                                    sd.Data.Add(td);
                                                                    Application.DoEvents();
                                                                    this.loadProgress.Increment(++index);
                                                                }
                                                            }
                                                        }
                                                    }
                                                    paraBirimi = null;
                                                    #endregion
                                                    break;
                                            }
                                            #region --- Aktarım Yap ---
                                            switch (sd.ShowDialog())
                                            {
                                                case DialogResult.Yes:
                                                    this.loadProgress.Properties.Maximum = sd.Data.Count;
                                                    this.loadProgress.Increment(0);
                                                    foreach (TeklifDetay td in sd.Data)
                                                    {
                                                        if (td.ID <= 0)
                                                        {
                                                            if (TeklifDetayMethods.Insert(td) > 0)
                                                            {
                                                                Application.DoEvents();
                                                                this.loadProgress.Increment(++index);
                                                                isOkey = true;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (td.Adet.Equals(0))
                                                            {
                                                                if (TeklifDetayMethods.Delete(td) > 0)
                                                                {
                                                                    Application.DoEvents();
                                                                    this.loadProgress.Increment(++index);
                                                                    isOkey = true;
                                                                }
                                                            }
                                                            else if (TeklifDetayMethods.Update(td) > 0)
                                                            {
                                                                Application.DoEvents();
                                                                this.loadProgress.Increment(++index);
                                                                isOkey = true;
                                                            }
                                                        }
                                                    }
                                                    break;
                                            }
                                            if (isOkey)
                                                Commons.Status(string.Format(L.ExcelDekiUrunAktarildi, sd.Data.Count));
                                            #endregion
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
                Commons.Status(Commons.GetErrorCode("FEA", 2) + ex.Message);
            }
            finally
            {
                if (isOkey)
                {
                    Commons.Update(TableNames.Teklif);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        void turlerRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.turlerRadioGroup.SelectedIndex)
            {
                case 0:
                    this.excelKarOranCalcEdit.Enabled = true;
                    this.excelDovizTipiComboBoxEdit.Enabled = true;
                    break;
                default:
                    this.excelKarOranCalcEdit.Enabled = false;
                    this.excelDovizTipiComboBoxEdit.Enabled = false;
                    break;
            }
        }

        void excelAktarimButton_Click(object sender, EventArgs e)
        {
            Commons.GeneralImportFile();
        }
    }
}