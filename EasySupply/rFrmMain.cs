using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace EasySupply
{
    public partial class rFrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DateTime m_TrialVersionWarning;
        bool m_LisansKeyValidate = false;

        public void SetCurrencyAndLangs()
        {
            try
            {
                yeniLisanSatinAlButton.Caption = L.YeniLisansSatinAl;
                formuYenileButton.Caption = L.FormuYenile;
                sepetiGeriAlButton.Caption = L.SepetiGeriAl;
                teklifKaydetButton.Caption = L.TeklifKaydet;
                iceriAktarButton.Caption = L.IceriAktar;
                yeniTeklifHazirlaButton.Caption = L.YeniTeklifHazirla;
                teklifArsivButton.Caption = L.TeklifArsivi;
                enUcuzUrunSecenekliButton.Caption = L.EnUcuzUrunListesi + " (**)";
                enUcuzUrunIDButton.Caption = L.EnUcuzUrunListesi;
                faturaHazirlaButton.Caption = L.FaturaHazirla;
                teklifVermeButton.Caption = L.TeklifVermeTutanagi;
                teslimEtmeButton.Caption = L.TeslimVermeTutanagi;
                siparisToplamaButton.Caption = L.SiparisToplamaListesi;
                siparisMaliyetButton.Caption = L.SiparisMaliyetListesi;
                hizliStokGirisiButton.Caption = L.HizliStokGirisi;
                stokTanimlaButton.Caption = L.StokTanimla;
                urunTanimlaButton.Caption = L.YeniUrunTanimla;
                kategoriTanimlaButton.Caption = L.KategoriTanimla;
                firmaTanimlaButton.Caption = L.FirmaTanimla;
                dovizKurlariButton.Caption = L.DovizKurlari;
                urunFiyatKarsilasitirmaButton.Caption = L.UrunFiyatKarislastirma;
                tumUrunlerSecenekliButton.Caption = L.TumUrunListesi + " (**)";
                tumUrunlerIDButton.Caption = L.TumUrunListesi;
                aktarimDosyasiButton.Caption = L.AktarimDosyasi;
                veritabaniOnarButton.Caption = L.VeritabaniOnar;
                veritabaniYedekleButton.Caption = L.VeritabaniYedekle;
                destekHattiButton.Caption = L.DestekHatti;
                uygulamaAyarlariButton.Caption = L.UygulamAyarlari;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 1) + ex.Message);
            }
        }

        public rFrmMain()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
            LookAndFeelSettings.Load("LookAndFeelSettings.dat");
        }

        void rFrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "EasySupply v" + Application.ProductVersion;
                this.ribbon.SelectedPage = FaturaHazir;

                #region --- Application Loading ---
                Commons.Loading("Uygulama başlatılıyor. ..");
                bool isJSonFile = jSonData.ReadFile();
                Commons.GetLastAccessTime();
                #endregion

                #region --- Validate Design Control ---
                if (!Commons.ValidateApplication())
                {
                    Commons.Loaded();
                    using (xFrmValidate v = new xFrmValidate())
                    {
                        switch (v.ShowDialog())
                        {
                            case DialogResult.OK:
                                m_LisansKeyValidate = true;
                                Application.Restart();
                                return;
                            default:
                                Application.ExitThread();
                                Application.Exit();
                                return;
                        }
                    }
                }
                #endregion

                #region --- Trial Version Warning ---
                if (Commons.ExpariedDay <= 10)
                    this.yeniLisanSatinAlButton.Visibility = BarItemVisibility.Always;
                else
                    this.yeniLisanSatinAlButton.Visibility = BarItemVisibility.Never;
                this.m_TrialVersionWarning = this.m_TrialVersionWarning.AddHours(1);
                this.timer1.Start();
                #endregion

                #region --- Default Settings ---
                Commons.Loading("Uygulama ayarları okunuyor. ..");
                DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbTemalar, true);
                if (!isJSonFile)
                {
                    Commons.Loaded();
                    xFrmSettings settings = new xFrmSettings();
                    settings.ShowDialog();
                }
                Commons.ColorLoad();
                Commons.RestoreHeader();
                Commons.Loading("Bağlantı ayarları kontrol ediliyor.. .");
                if (!Commons.ConnectionStates())
                {
                    Commons.Loaded();
                    xFrmSettings settings = new xFrmSettings();
                    settings.ShowDialog();
                }
                Commons.Loading("Güncel doviz kurları ve datalar getiriliyor.. .");
                Commons.CurrentDoviz();
                #endregion

                this.urunFiyatKarsilasitirmaButton.PerformClick();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 2) + ex.Message);
            }
            finally
            {
                Commons.Loaded();
            }
        }
        void rFrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!m_LisansKeyValidate)
                    if (Commons.ValidateApplication())
                    {
                        LookAndFeelSettings.Save("LookAndFeelSettings.dat");
                        Commons.BackupDatabase();
                    }
                e.Cancel = false;
                Application.Exit();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 3) + ex.Message);
                e.Cancel = false;
                Application.Exit();
            }
        }

        void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            try
            {
                this.teklifVermeButton.Enabled = false;
                this.teslimEtmeButton.Enabled = false;
                this.siparisMaliyetButton.Enabled = false;
                this.siparisToplamaButton.Enabled = false;
                this.faturaHazirlaButton.Enabled = false;
                this.sepetiGeriAlButton.Enabled = false;
                this.teklifKaydetButton.Enabled = false;
                this.iceriAktarButton.Enabled = false;

                if ((this.ActiveMdiChild is xFrmTeklif))
                {
                    xFrmTeklif frm = this.ActiveMdiChild as xFrmTeklif;
                    if (frm.TeklifObject.ID > 0)
                    {
                        this.teklifVermeButton.Enabled = true;
                        this.teslimEtmeButton.Enabled = true;
                        this.siparisMaliyetButton.Enabled = true;
                        this.siparisToplamaButton.Enabled = true;
                        this.faturaHazirlaButton.Enabled = true;
                        this.sepetiGeriAlButton.Enabled = frm.IsTempValue;
                        this.teklifKaydetButton.Enabled = frm.IsValueChanged;
                        this.iceriAktarButton.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 4) + ex.Message);
            }
        }

        void teklifHazirlaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmTeklif frm = new xFrmTeklif();
            frm.Text = L.YeniTeklifHazirla;
            frm.MdiParent = this;
            Commons.IsOpenForm(frm);
        }
        void teklifArsivButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmTeklifDetay frm = new xFrmTeklifDetay();
            frm.Text = L.TeklifArsivi;
            frm.MdiParent = this;
            Commons.IsOpenForm(frm);
        }
        void kategoriTanimlaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmKategori frm = new xFrmKategori();
            frm.Text = L.KategoriTanimla;
            frm.MdiParent = this;
            Commons.IsOpenForm(frm);
        }
        void hizliStokGirisiButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmHizliStokGirisi frm = new xFrmHizliStokGirisi();
            frm.Text = L.HizliStokGirisi;
            Commons.IsOpenForm(frm);
        }
        void stokTanimlaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmStok frm = new xFrmStok();
            frm.Text = L.StokTanimla;
            frm.MdiParent = this;
            Commons.IsOpenForm(frm);
        }
        void urunTanimlaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmUrun frm = new xFrmUrun();
            frm.Text = L.YeniUrunTanimla;
            frm.MdiParent = this;
            Commons.IsOpenForm(frm);
        }
        void urunFiyatKarsilastirmaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                xFrmUrunRapor frm = new xFrmUrunRapor();
                frm.Text = L.UrunFiyatKarislastirma;
                frm.MdiParent = this;
                Commons.IsOpenForm(frm);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 5) + ex.Message);
            }
        }
        void firmaTanimlaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmFirma frm = new xFrmFirma();
            frm.Text = L.FirmaTanimla;
            frm.MdiParent = this;
            Commons.IsOpenForm(frm);
        }
        void dovizKurlariButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmDoviz frm = new xFrmDoviz();
            frm.Text = L.DovizKurlari;
            Commons.IsOpenForm(frm);
        }

        void yeniLisanSatinAlButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.m_TrialVersionWarning = this.m_TrialVersionWarning.AddHours(1);
            Commons.ValidateApplication();
        }

        void formuYenileButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Commons.Loading(this.ActiveMdiChild.Text + " ekranındaki bilgiler güncelleniyor. ..");
                if (this.ActiveMdiChild is xFrmUrunRapor)
                {
                    xFrmUrunRapor frm = this.ActiveMdiChild as xFrmUrunRapor;
                    frm.GetUrunRapor();
                }
                else if (this.ActiveMdiChild is xFrmStok)
                {
                    xFrmStok frm = this.ActiveMdiChild as xFrmStok;
                    frm.GetKategoriler();
                    frm.GetUrunler();
                    frm.GetFirmalar();
                    frm.GetData();
                }
                else if (this.ActiveMdiChild is xFrmTeklif)
                {
                    xFrmTeklif frm = this.ActiveMdiChild as xFrmTeklif;
                    frm.GetDefault();
                    frm.GetStokListe();
                    frm.GetTeklif();
                }
                else if (this.ActiveMdiChild is xFrmTeklifDetay)
                {
                    xFrmTeklifDetay frm = this.ActiveMdiChild as xFrmTeklifDetay;
                    frm.GetTeklifler();
                }
                else if (this.ActiveMdiChild is xFrmUrun)
                {
                    xFrmUrun frm = this.ActiveMdiChild as xFrmUrun;
                    frm.GetKategoriler();
                    frm.GetData();
                }
                else if (this.ActiveMdiChild is xFrmKategori)
                {
                    xFrmKategori frm = this.ActiveMdiChild as xFrmKategori;
                    frm.GetData();
                }
                else if (this.ActiveMdiChild is xFrmFirma)
                {
                    xFrmFirma frm = this.ActiveMdiChild as xFrmFirma;
                    frm.GetData();
                }
                else if (this.ActiveMdiChild is xFrmDoviz)
                {
                    xFrmDoviz frm = this.ActiveMdiChild as xFrmDoviz;
                    frm.GetData();
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 6) + ex.Message);
            }
            finally
            {
                Commons.Status(this.ActiveMdiChild.Text + " ekranındaki bilgiler güncellendi!");
                Commons.Loaded();
            }
        }
        void sepetiGeriAlButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmTeklif temp = this.ActiveMdiChild as xFrmTeklif;
            temp.SepetiGeriAl();
        }
        void teklifKaydetButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                xFrmTeklif temp = this.ActiveMdiChild as xFrmTeklif;
                temp.Saved();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 7) + ex.Message);
            }
        }
        void iceriAktarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmTeklif temp = this.ActiveMdiChild as xFrmTeklif;
            temp.SiparisIceriAktar();
        }

        void teklifVermeButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                xFrmTeklif temp = this.ActiveMdiChild as xFrmTeklif;
                if (!Commons.ShowBox(QuestionType.TeklifFormu))
                    temp.SiparisFormuFiyatsiz(FormType.Offer);
                temp.SiparisFormu(FormType.Offer);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 8) + ex.Message);
            }
        }
        void teslimEtmeButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                xFrmTeklif temp = this.ActiveMdiChild as xFrmTeklif;
                if (!Commons.ShowBox(QuestionType.TeslimFormu))
                    temp.SiparisFormuFiyatsiz(FormType.Delivery);
                temp.SiparisFormu(FormType.Delivery);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 9) + ex.Message);
            }
        }
        void siparisToplamaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                xFrmTeklif temp = this.ActiveMdiChild as xFrmTeklif;
                temp.SiparisToplamaListesi();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 10) + ex.Message);
            }
        }
        void siparisMaliyetButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                xFrmTeklif temp = this.ActiveMdiChild as xFrmTeklif;
                temp.SiparisMaliyetListesi();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 11) + ex.Message);
            }
        }
        void faturaHazirlaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                xFrmTeklif temp = this.ActiveMdiChild as xFrmTeklif;
                temp.FaturaHazirla();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 12) + ex.Message);
            }
        }

        void enUcuzUrunButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Commons.CreateCatalog(UrunKatalogMethods.GetEnUcuzUrunler());
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 13) + ex.Message);
            }
        }
        void tumUrunlerButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Commons.CreateCatalog(UrunKatalogMethods.GetUrunKatalog());
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 14) + ex.Message);
            }
        }

        void barkodKatalogEnUcuzButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Commons.CreateCatalogBarkod(UrunKatalogMethods.GetEnUcuzUrunler());
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 15) + ex.Message);
            }
        }
        void barkodTumUrunlerButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Commons.CreateCatalogBarkod(UrunKatalogMethods.GetUrunKatalog());
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 16) + ex.Message);
            }
        }

        void pdfButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commons.CreateFile(this.ActiveMdiChild, FileType.PDF);
        }
        void excelButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commons.CreateFile(this.ActiveMdiChild, FileType.Excel);
        }
        void excelxButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commons.CreateFile(this.ActiveMdiChild, FileType.ExcelX);
        }
        void wordButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commons.CreateFile(this.ActiveMdiChild, FileType.Word);
        }

        void veritabaniOnarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commons.RepairDatabase();
        }
        void veritabaniYedekleButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commons.BackupDatabase();
            MessageBox.Show(statusLabel.Caption, "Info");
        }

        void settingsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmSettings settings = new xFrmSettings();
            settings.Text = L.UygulamAyarlari;
            settings.ShowDialog();
        }
        void excelFileButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commons.GeneralImportFile();
        }

        void abutUsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            xFrmHakkimizda about = new xFrmHakkimizda();
            about.Text = "About Us";
            about.ShowDialog();
        }

        void destekHattiButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                using (xFrmGeriBildirim frm = new xFrmGeriBildirim())
                {
                    frm.Text = L.DestekHatti;
                    frm.Konu = L.DestekBildirimKonusu;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 17) + ex.Message);
            }
        }

        DateTime lastWrite = DateTime.Now;
        void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.timeStatic.Caption = DateTime.Now.ToString("dd MMMM yyyy dddd HH:mm:ss");
                if (m_TrialVersionWarning <= DateTime.Now & (Commons.ExpariedDay < 10))
                    this.m_TrialVersionWarning = this.m_TrialVersionWarning.AddHours(1);
                else if (this.ActiveMdiChild is xFrmTeklifDetay & lastWrite < Commons.GetLastWriteTime())
                {
                    lastWrite = Commons.GetLastWriteTime().AddSeconds(5);
                    (this.ActiveMdiChild as xFrmTeklifDetay).GetTeklifler();
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 18) + ex.Message);
            }
        }

        void statusLabel_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (statusLabel.Tag != null)
                    using (xFrmGeriBildirim frm = new xFrmGeriBildirim())
                    {
                        frm.Text = L.DestekHatti;
                        frm.Konu = BAYMYO.UI.Converts.NullToString(statusLabel.Tag);
                        switch (frm.ShowDialog())
                        {
                            case System.Windows.Forms.DialogResult.OK:
                                statusLabel.Tag = null;
                                break;
                        }
                    }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FMN", 19) + ex.Message);
            }
        }
    }
}