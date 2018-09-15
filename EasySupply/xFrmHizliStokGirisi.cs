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
    public partial class xFrmHizliStokGirisi : DevExpress.XtraEditors.XtraForm
    {
        #region --- METHODS ---
        public void SetCurrencyAndLangs()
        {
            try
            {
                categoryGroupControl.Text = L.Kategori;
                productGroupControl.Text = L.UrunAciklama;
                supplierGroupControl.Text = L.TedarikciFirma;
                storesGroupControl.Text = L.StokGirisi;

                lblKategoriKod.Text = L.Kod;
                lblYeniKategoriAdi.Text = L.YeniKategori + " *";
                lblYeniUrunAdi.Text = L.YeniUrun + " *";
                lblUrunBirim.Text = L.Birim + " *";
                lblUrunKdv.Text = L.KDV + " *";
                lblYeniFirmaAdi.Text = L.YeniTedarikciFirma + " *";
                lblTelefon.Text = L.Telefon;
                lblPeriod.Text = L.Period + " *";
                lblBirimFiyat.Text = L.AlisFiyati + " (" + Commons.Kur0Code + ")";
                lblCurrency.Text = Commons.AppSettings.DEFAULT_CURRENCY.Description;
                lblBirimKarOrani.Text = L.KarOrani;

                temizleButton.Text = L.Temizle;
                kaydetButton.Text = L.Kaydet;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 15) + ex.Message);
            }
        }
        public void GetKategoriler()
        {
            try
            {
                KategoriCollection k = KategoriMethods.GetSelect();
                k.Add(new Kategori { ID = 0, Adi = L.YeniKategori });
                this.kategoriBindingSource.DataSource = k;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 16) + ex.Message);
            }
        }
        public void GetUrunlerForKategori()
        {
            try
            {
                List<Urun> u = UrunMethods.GetSelect(Convert.ToInt32(this.kategoriLookUpEdit.EditValue));
                u.Add(new Urun { ID = 0, Adi = L.YeniUrun });
                this.urunBindingSource.DataSource = u;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 17) + ex.Message);
            }
        }
        public void GetFirmalar()
        {
            try
            {
                List<Firma> f = FirmaMethods.GetSelect();
                f.Add(new Firma { ID = 0, Adi = L.YeniTedarikciFirma });
                this.firmaBindingSource.DataSource = f;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 18) + ex.Message);
            }
        }
        void Temizle()
        {
            this.kategoriKodTextEdit.Text = "";
            this.kategoriAdiTextEdit.Text = "";
            this.urunAdiTextEdit.Text = "";
            this.urunBirimComboBoxEdit.Text = "";
            this.urunKdvCalcEdit.Value = 0;
            this.firmaAdiTextEdit.Text = "";
            this.stokFiyatCalcEdit.Value = 0;
        }
        #endregion

        public xFrmHizliStokGirisi()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        void xFrmHizliStokGirisi_Load(object sender, EventArgs e)
        {
            try
            {
                Commons.Status(this.Text + " ekranı açıldı.");
                if (Commons.AppSettings.UNITS.Contains(","))
                    this.urunBirimComboBoxEdit.Properties.Items.AddRange(Commons.AppSettings.UNITS.Split(','));
                GetKategoriler();
                GetUrunlerForKategori();
                GetFirmalar();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 19) + ex.Message);
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

        void kategoriLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            GetUrunlerForKategori();
        }

        void kaydetButton_Click(object sender, EventArgs e)
        {
            try
            {
                int kategoriID = BAYMYO.UI.Converts.NullToInt(this.kategoriLookUpEdit.EditValue);
                if (kategoriID <= 0)
                {
                    if (string.IsNullOrEmpty(this.kategoriAdiTextEdit.Text))
                    {
                        MessageBox.Show("Lütfen kategori adı giriniz.", "Uyarı");
                        return;
                    }
                    kategoriID = KategoriMethods.Insert(new Kategori { Kod = this.kategoriKodTextEdit.Text, Adi = this.kategoriAdiTextEdit.Text });
                    Commons.Update(TableNames.Kategori);
                    this.kategoriLookUpEdit.EditValue = kategoriID;
                }
                int urunID = BAYMYO.UI.Converts.NullToInt(this.urunLookUpEdit.EditValue);
                if (urunID <= 0)
                {
                    if (string.IsNullOrEmpty(this.urunAdiTextEdit.Text) || string.IsNullOrEmpty(this.urunBirimComboBoxEdit.Text) || this.urunKdvCalcEdit.Value <= 0)
                    {
                        MessageBox.Show("Lütfen 'Ürün Adı','Birim' ve 'K.D.V.' alanlarını boş geçmeyiniz.", "Uyarı");
                        return;
                    }
                    urunID = UrunMethods.Insert(new Urun { KategoriID = kategoriID, Adi = this.urunAdiTextEdit.Text, Miktar = 1, Birim = this.urunBirimComboBoxEdit.Text, Kdv = BAYMYO.UI.Converts.NullToFloat(this.urunKdvCalcEdit.Value), Tarih = DateTime.Now });
                    Commons.Update(TableNames.Urun);
                    this.urunLookUpEdit.EditValue = urunID;
                }
                int firmaID = BAYMYO.UI.Converts.NullToInt(this.firmaLookUpEdit.EditValue);
                if (firmaID <= 0)
                {
                    if (string.IsNullOrEmpty(this.firmaAdiTextEdit.Text) || this.firmaPeriodCalcEdit.Value <= 0)
                    {
                        MessageBox.Show("Lütfen 'Firma Adı' ve 'Period' alanlarını boş geçmeyiniz.", "Uyarı");
                        return;
                    }
                    firmaID = FirmaMethods.Insert(new Firma { Adi = this.firmaAdiTextEdit.Text, Telefon = this.firmaTelefonTextEdit.Text, Period = BAYMYO.UI.Converts.NullToByte(this.firmaPeriodCalcEdit.Value) });
                    Commons.Update(TableNames.Firma);
                    this.firmaLookUpEdit.EditValue = firmaID;
                }

                if (kategoriID <= 0 || urunID <= 0 || firmaID <= 0 || this.stokFiyatCalcEdit.Value <= 0 || this.stokKarOranCalcEdit.Value <= 0)
                {
                    MessageBox.Show("Ürün bilgisi kaydedilemedi lütfen fiyat ve kar oranına bakınız.", "Uyarı");
                    return;
                }
                Stok s = new Stok();
                s.KategoriID = kategoriID;
                s.UrunID = urunID;
                s.FirmaID = firmaID;
                s.Fiyat = BAYMYO.UI.Converts.NullToFloat(this.stokFiyatCalcEdit.Value);
                s.KarOran = BAYMYO.UI.Converts.NullToFloat(this.stokKarOranCalcEdit.Value);
                s.GuncellemeTarihi = DateTime.Now;
                if (StokMethods.Insert(s) > 0)
                {
                    Commons.Update(TableNames.Stok);
                    MessageBox.Show("İşlem başarılı bir şekilde gerçekleştirildi.", "Bilgi");
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FST", 20) + ex.Message);
            }
        }
        void temizleButton_Click(object sender, EventArgs e)
        {
            this.kategoriLookUpEdit.EditValue = 0;
            this.urunLookUpEdit.EditValue = 0;
            this.firmaLookUpEdit.EditValue = 0;
            Temizle();
        }
    }
}