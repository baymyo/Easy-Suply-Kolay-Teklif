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
    public partial class xFrmUrunKatalog : DevExpress.XtraEditors.XtraForm
    {
        Teklif t = new Teklif();
        public Teklif TeklifObject
        {
            get { return t; }
            set { t = value; }
        }
        public List<TeklifDetay> TeklifDetayObject { get; set; }

        DialogResult dlg = DialogResult.Cancel;
        static List<UrunKatalog> m_UrunKatalogListe = null;

        public void SetCurrencyAndLangs()
        {
            try
            {
                kriterGroupControl.Text = L.UrunleriFlitrele;
                colSiraNo.Caption = L.SiraNo;
                colAdet.Caption = L.Adet;
                colUrunAdi.Caption = L.UrunAciklama;
                colFirmaAdi.Caption = L.TedarikciFirma;
                colTelefon.Caption = L.Telefon;
                colMiktar.Caption = L.Miktar;
                colBirim.Caption = L.Birim;
                colFiyat.Caption = L.AlisFiyati + " (" + Commons.Kur0Symbol + ")";
                colKarOran.Caption = L.KarOrani;
                colTutar.Caption = L.SatisFiyati + " (" + Commons.Kur0Symbol + ")";

                colFiyat.DisplayFormat.FormatString = colTutar.DisplayFormat.FormatString = Commons.Kur0Format;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUK", 1) + ex.Message);
            }
        }

        public xFrmUrunKatalog()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        void GetUrunKatalog()
        {
            try
            {
                switch (this.katalogTipiRadioGroup.EditValue.ToString())
                {
                    case "Hepsi":
                        m_UrunKatalogListe = UrunKatalogMethods.GetUrunKatalog();
                        break;
                    default:
                        m_UrunKatalogListe = UrunKatalogMethods.GetEnUcuzUrunler();
                        break;
                }
                if (TeklifDetayObject != null)
                    foreach (TeklifDetay td in TeklifDetayObject)
                    {
                        UrunKatalog k = m_UrunKatalogListe.Find(x => x.StokID.Equals(td.StokID));
                        if (k != null)
                            k.Adet = td.Adet;
                    }
                this.urunKatalogBindingSource.DataSource = m_UrunKatalogListe;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUK", 2) + ex.Message);
            }
        }

        void xFrmUrunKatalog_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}: {1} - {2}: {3} - {4}: {5:##0.0000} | {6}: {7:##0.0000}", L.GemiAdi, t.GemiAdi, L.ParaBirimi, Commons.CurrencySelected(t.ParaBirimi), Commons.Kur1Code, t.Kur1, Commons.Kur2Code, t.Kur2);
            this.popupFilterModeComboBox.EditValue = "STARTS WITH";
            GetUrunKatalog();
        }
        void xFrmUrunKatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dlg;
        }

        void katalogTipiRadioGroup_EditValueChanged(object sender, EventArgs e)
        {
            GetUrunKatalog();
        }
        void urunTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                switch (this.popupFilterModeComboBox.EditValue.ToString().ToLower())
                {
                    case "contain":
                    case "contains":
                    case "contaıns":
                        this.urunKatalogBindingSource.DataSource = m_UrunKatalogListe.FindAll(x => x.UrunAdi.Contains(this.urunTextEdit.Text.Trim()));
                        break;
                    default:
                        this.urunKatalogBindingSource.DataSource = m_UrunKatalogListe.FindAll(x => x.UrunAdi.StartsWith(this.urunTextEdit.Text.Trim(), StringComparison.CurrentCultureIgnoreCase));
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUK", 3) + ex.Message);
            }
        }

        void urunKatalogGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                UrunKatalog sl = this.urunKatalogGridView.GetFocusedRow() as UrunKatalog;
                switch (e.Column.FieldName)
                {
                    case "Adet":
                        if (sl != null)
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
                                Adet = BAYMYO.UI.Converts.NullToFloat(e.Value)
                            })
                            {
                                if (td.BirimFiyati <= 0)
                                {
                                    sl.Adet = 0;
                                    MessageBox.Show(td.UrunAdi + " isimli ürünün birim fiyatı '0.00' olarak görülmekte!", "Uyarı");
                                    return;
                                }
                                if (td.Adet > 0)
                                    if (TeklifDetayMethods.Insert(td) > 0)
                                    {
                                        Commons.Update(TableNames.Teklif);
                                        Commons.Status(td.UrunAdi + " isimli üründen sepete '" + td.Adet + "' adet başarılı bir şekilde eklendi.");
                                        dlg = DialogResult.OK;
                                    }
                            }
                        break;
                    case "Fiyat":
                        if (sl != null)
                        {
                            Stok u = StokMethods.GetStok(sl.StokID);
                            u.Fiyat = sl.Fiyat;
                            u.GuncellemeTarihi = DateTime.Now;
                            if (StokMethods.Update(u) > 0)
                            {
                                sl.Updated = false;
                                Commons.Update(TableNames.Stok);
                                Commons.Status(sl.UrunAdi + " isimli ürünün stok fiyatı '" + sl.Fiyat.ToString(Commons.Kur0Format) + "' olarak başarılı bir şekilde değiştirildi.");
                                dlg = DialogResult.OK;
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FUK", 4) + ex.Message);
            }
        }

        void urunKatalogGridControl_EditorKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    int index = this.urunKatalogGridView.FocusedRowHandle + 1;
                    if (index >= this.urunKatalogGridView.RowCount)
                        index = 0;
                    this.urunKatalogGridView.FocusedRowHandle = index;
                    break;
            }
        }
    }
}