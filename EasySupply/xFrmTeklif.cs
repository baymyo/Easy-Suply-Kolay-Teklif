using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace EasySupply
{
    public partial class xFrmTeklif : DevExpress.XtraEditors.XtraForm
    {
        #region --- Properties ---
        Teklif t = new Teklif();
        public Teklif TeklifObject
        {
            get { return t; }
            set { t = value; }
        }
        public bool IsTempValue { get; set; }
        public bool IsValueChanged { get; set; }
        bool IsFormLoad = true, IsReferanceNoChange = false;
        string DovizForeColor = "0,0,0";

        static List<UrunKatalog> m_UrunKatalog = null;
        List<TeklifDetay> m_TeklifDetaySepet = null;
        List<TeklifDetay> m_TeklifDetaySilinen = null;
        #endregion

        #region --- Method/Fonksiyon ---
        public void SetCurrencyAndLangs()
        {
            try
            {
                this.aliciGroupControl.Text = L.Musteri;
                this.urunGroupControl.Text = L.SepeteUrunEkle;
                this.detayGroupControl.Text = L.Detaylar;
                this.dovizGroupControl.Text = L.KurKaydedilen;

                this.paraBirimiRadioGroup.Properties.Items[0].Description = Commons.Kur0Code;
                this.paraBirimiRadioGroup.Properties.Items[1].Description = Commons.Kur1Code;
                this.paraBirimiRadioGroup.Properties.Items[2].Description = Commons.Kur2Code;

                this.kur1CodeLabel.Text = Commons.Kur1Code;
                this.kur2CodeLabel.Text = Commons.Kur2Code;
                this.dovizCheckButton.Text = L.KurYeni;

                this.lblKur1.Text = Commons.Kur1Code + " Total";
                this.lblKur2.Text = Commons.Kur2Code + " Total";

                string
                    symbolKur0 = " (" + Commons.Kur0Symbol + ")",
                    symbolKur1 = " (" + Commons.Kur1Symbol + ")",
                    symbolKur2 = " (" + Commons.Kur2Symbol + ")",
                    formatKur0 = Commons.Kur0Format,
                    formatKur1 = Commons.Kur1Format,
                    formatKur2 = Commons.Kur2Format;

                this.colUrunAdi.Caption = this.colUrunAdi1.Caption = L.UrunAciklama;
                this.colFirmaAdi.Caption = this.colFirmaAdi1.Caption = L.TedarikciFirma;
                this.colTelefon.Caption = L.Telefon;
                this.colMiktar.Caption = L.Miktar;
                this.colAdet.Caption = lblAdet.Text = L.Adet;
                this.colKarOran.Caption = this.colKarOrani.Caption = L.KarOrani;
                this.colKdv.Caption = L.KDV;

                this.colFiyat.Caption = this.colBirimFiyati.Caption = L.AlisFiyati + symbolKur0;
                this.colFiyatKur1.Caption = this.colBirimFiyatiKur1.Caption = L.AlisFiyati + symbolKur1;
                this.colFiyatKur2.Caption = this.colBirimFiyatiKur2.Caption = L.AlisFiyati + symbolKur2;

                this.colAlisTutar.Caption = L.AlisTutar + symbolKur0;
                this.colAlisTutarKur1.Caption = L.AlisTutar + symbolKur1;
                this.colAlisTutarKur2.Caption = L.AlisTutar + symbolKur2;

                this.colSatisFiyati.Caption = L.SatisFiyati + symbolKur0;
                this.colSatisFiyatiKur1.Caption = L.SatisFiyati + symbolKur1;
                this.colSatisFiyatiKur2.Caption = L.SatisFiyati + symbolKur2;

                this.colTutar.Caption = this.colSatisTutar.Caption = L.SatisTutar + symbolKur0;
                this.colTutarKur1.Caption = this.colSatisTutarKur1.Caption = L.SatisTutar + symbolKur1;
                this.colTutarKur2.Caption = this.colSatisTutarKur2.Caption = L.SatisTutar + symbolKur2;

                this.colKazanc.Caption = L.NetKar + symbolKur0;
                this.colKazancKur1.Caption = L.NetKar + symbolKur1;
                this.colKazancKur2.Caption = L.NetKar + symbolKur2;

                this.iskontoTextEdit.Properties.DisplayFormat.FormatString = this.tasimaUcretiCalcEdit.Properties.DisplayFormat.FormatString = this.toplamTutar.Properties.DisplayFormat.FormatString = this.toplamTutar.Properties.EditFormat.FormatString = this.colFiyat.DisplayFormat.FormatString = this.colTutar.DisplayFormat.FormatString = this.colBirimFiyati.DisplayFormat.FormatString = this.colAlisTutar.DisplayFormat.FormatString = this.colSatisFiyati.DisplayFormat.FormatString = this.colSatisTutar.DisplayFormat.FormatString = this.colKazanc.DisplayFormat.FormatString = formatKur0;
                this.toplamTutarKur1.Properties.DisplayFormat.FormatString = this.toplamTutarKur1.Properties.EditFormat.FormatString = this.colFiyatKur1.DisplayFormat.FormatString = this.colTutarKur1.DisplayFormat.FormatString = this.colBirimFiyatiKur1.DisplayFormat.FormatString = this.colAlisTutarKur1.DisplayFormat.FormatString = this.colSatisFiyatiKur1.DisplayFormat.FormatString = this.colSatisTutarKur1.DisplayFormat.FormatString = this.colKazancKur1.DisplayFormat.FormatString = formatKur1;
                this.toplamTutarKur2.Properties.DisplayFormat.FormatString = this.toplamTutarKur2.Properties.EditFormat.FormatString = this.colFiyatKur2.DisplayFormat.FormatString = this.colTutarKur2.DisplayFormat.FormatString = this.colBirimFiyatiKur2.DisplayFormat.FormatString = this.colAlisTutarKur2.DisplayFormat.FormatString = this.colSatisFiyatiKur2.DisplayFormat.FormatString = this.colSatisTutarKur2.DisplayFormat.FormatString = this.colKazancKur2.DisplayFormat.FormatString = formatKur2;

                this.iskontoTextEdit.Properties.DisplayFormat.FormatType = this.tasimaUcretiCalcEdit.Properties.DisplayFormat.FormatType = this.toplamTutar.Properties.DisplayFormat.FormatType = this.toplamTutarKur1.Properties.DisplayFormat.FormatType = this.toplamTutarKur2.Properties.DisplayFormat.FormatType = this.toplamTutar.Properties.EditFormat.FormatType = this.toplamTutarKur1.Properties.EditFormat.FormatType = this.toplamTutarKur2.Properties.EditFormat.FormatType =
                    this.colFiyat.DisplayFormat.FormatType = this.colTutar.DisplayFormat.FormatType = this.colBirimFiyati.DisplayFormat.FormatType = this.colAlisTutar.DisplayFormat.FormatType = this.colSatisFiyati.DisplayFormat.FormatType = this.colSatisTutar.DisplayFormat.FormatType =
                    this.colFiyatKur1.DisplayFormat.FormatType = this.colTutarKur1.DisplayFormat.FormatType = this.colBirimFiyatiKur1.DisplayFormat.FormatType = this.colAlisTutarKur1.DisplayFormat.FormatType = this.colSatisFiyatiKur1.DisplayFormat.FormatType = this.colSatisTutarKur1.DisplayFormat.FormatType =
                    this.colFiyatKur2.DisplayFormat.FormatType = this.colTutarKur2.DisplayFormat.FormatType = this.colBirimFiyatiKur2.DisplayFormat.FormatType = this.colAlisTutarKur2.DisplayFormat.FormatType = this.colSatisFiyatiKur2.DisplayFormat.FormatType = this.colSatisTutarKur2.DisplayFormat.FormatType =
                    this.colKazanc.DisplayFormat.FormatType = this.colKazancKur1.DisplayFormat.FormatType = this.colKazancKur2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 1) + ex.Message);
            }
        }

        public void CreateFile(string path, FileType type)
        {
            try
            {
                switch (type)
                {
                    case FileType.PDF:
                        teklifDetayGridControl.ExportToPdf(path);
                        break;
                    case FileType.Excel:
                        teklifDetayGridControl.ExportToXls(path);
                        break;
                    case FileType.ExcelX:
                        teklifDetayGridControl.ExportToXlsx(path);
                        break;
                    case FileType.Word:
                        teklifDetayGridControl.ExportToRtf(path);
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 2) + ex.Message);
            }
        }
        public void FaturaHazirla()
        {
            try
            {
                if (ChangedSaved()) return;
                float iskontoToplam = 0, iskonto = 0, kdvToplam = 0, kdv = 0, genelToplam = 0, teslimanUcreti = 0;
                List<Fatura> ftr = new List<Fatura>();
                switch (t.Kdv)
                {
                    case 2:
                        foreach (TeklifDetay td in m_TeklifDetaySepet)
                        {
                            Fatura f = new Fatura
                            {
                                SiraNo = td.SiraNo,
                                UrunAdi = td.UrunAdi,
                                Kdv = td.Kdv,
                                Adet = td.Adet,
                                Birim = td.Birim,
                                BirimFiyat = td.SatisFiyati,
                            };
                            switch (t.ParaBirimi)
                            {
                                case "KUR1":
                                    f.BirimFiyat /= t.Kur1;
                                    break;
                                case "KUR2":
                                    f.BirimFiyat /= t.Kur2;
                                    break;
                            }
                            //İSKONTO HESAPLA
                            if (t.Iskonto > 0)
                            {
                                iskonto = f.BirimFiyat * t.Iskonto;
                                f.BirimFiyat -= iskonto;
                                iskontoToplam += (iskonto * td.Adet);
                            }
                            //KDV HESAPLA
                            if (td.Kdv > 0)
                            {
                                kdv = (f.BirimFiyat * td.Kdv);
                                kdvToplam += (kdv * td.Adet);
                            }
                            //TUTAR HESAPLA
                            f.Tutar = (f.BirimFiyat * f.Adet);
                            genelToplam += f.Tutar;
                            //FATURAYA EKLE
                            ftr.Add(f);
                        }
                        break;
                    case 3:
                        foreach (TeklifDetay td in m_TeklifDetaySepet)
                        {
                            Fatura f = new Fatura
                            {
                                SiraNo = td.SiraNo,
                                UrunAdi = td.UrunAdi,
                                Kdv = td.Kdv,
                                Adet = td.Adet,
                                Birim = td.Birim,
                                BirimFiyat = td.SatisFiyati,
                            };
                            switch (t.ParaBirimi)
                            {
                                case "KUR1":
                                    f.BirimFiyat /= t.Kur1;
                                    break;
                                case "KUR2":
                                    f.BirimFiyat /= t.Kur2;
                                    break;
                            }
                            //İSKONTO HESAPLA
                            if (t.Iskonto > 0)
                            {
                                iskonto = f.BirimFiyat * t.Iskonto;
                                f.BirimFiyat -= iskonto;
                                iskontoToplam += (iskonto * td.Adet);
                            }
                            //KDV HESAPLA
                            if (td.Kdv > 0)
                            {
                                kdv = f.BirimFiyat - (f.BirimFiyat / (td.Kdv + 1));
                                f.BirimFiyat -= kdv;
                                kdvToplam += (kdv * td.Adet);
                            }
                            //TUTAR HESAPLA
                            f.Tutar = (f.BirimFiyat * f.Adet);
                            genelToplam += f.Tutar;
                            //FATURAYA EKLE
                            ftr.Add(f);
                        }
                        break;
                    default:
                        foreach (TeklifDetay td in m_TeklifDetaySepet)
                        {
                            Fatura f = new Fatura
                            {
                                SiraNo = td.SiraNo,
                                UrunAdi = td.UrunAdi,
                                Adet = td.Adet,
                                Birim = td.Birim,
                                BirimFiyat = td.SatisFiyati,
                                Tutar = td.SatisTutar
                            };
                            //TUTAR HESAPLA
                            switch (t.ParaBirimi)
                            {
                                case "KUR1":
                                    f.BirimFiyat /= t.Kur1;
                                    break;
                                case "KUR2":
                                    f.BirimFiyat /= t.Kur2;
                                    break;
                            }
                            f.Tutar = (f.BirimFiyat * f.Adet);
                            ftr.Add(f);
                        }
                        //GENEL TUTAR HESAPLA
                        genelToplam = BAYMYO.UI.Converts.NullToFloat(this.toplamTutar.EditValue);
                        iskontoToplam = BAYMYO.UI.Converts.NullToFloat(this.iskontoTextEdit.EditValue);
                        switch (t.ParaBirimi)
                        {
                            case "KUR1":
                                genelToplam = BAYMYO.UI.Converts.NullToFloat(this.toplamTutarKur1.EditValue);
                                if (iskontoToplam > 0)
                                    iskontoToplam /= t.Kur1;
                                break;
                            case "KUR2":
                                genelToplam = BAYMYO.UI.Converts.NullToFloat(this.toplamTutarKur2.EditValue);
                                if (iskontoToplam > 0)
                                    iskontoToplam /= t.Kur2;
                                break;
                        }
                        kdvToplam = 0;
                        break;
                }
                if (t.TasimaUcreti > 0)
                {
                    teslimanUcreti = t.TasimaUcreti;
                    switch (t.Kdv)
                    {
                        case 2:
                            kdv = teslimanUcreti * 0.18f;
                            kdvToplam += kdv;
                            break;
                        case 3:
                            kdv = teslimanUcreti - (teslimanUcreti / 1.18f);
                            teslimanUcreti -= kdv;
                            kdvToplam += kdv;
                            break;
                    }
                    switch (t.ParaBirimi)
                    {
                        case "KUR1":
                            teslimanUcreti /= t.Kur1;
                            break;
                        case "KUR2":
                            teslimanUcreti /= t.Kur2;
                            break;
                    }
                    switch (t.Kdv)
                    {
                        case 2:
                        case 3:
                            genelToplam += teslimanUcreti;
                            break;
                    }
                    ftr.Add(new Fatura
                    {
                        SiraNo = m_TeklifDetaySepet.Count + 1,
                        UrunAdi = L.TasimaHizmetBedeli,
                        BirimFiyat = teslimanUcreti,
                        Tutar = teslimanUcreti,
                        Adet = 1f,
                        Kdv = (kdvToplam > 0) ? 0.18f : 0.0f,
                        Birim = "NAK"
                    });
                }
                xrpTeklifFatura rptFatura = new xrpTeklifFatura(t, genelToplam, kdvToplam, t.Iskonto, iskontoToplam);
                rptFatura.Data = ftr;
                rptFatura.ShowPreview();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 3) + ex.Message);
            }
        }
        public void SiparisFormu(FormType ft)
        {
            try
            {
                if (ChangedSaved()) return;
                #region --- GRANT TOTAL ---
                object grandTotal = 0;
                switch (t.ParaBirimi)
                {
                    case "KUR1":
                        grandTotal = this.toplamTutarKur1.EditValue;
                        break;
                    case "KUR2":
                        grandTotal = this.toplamTutarKur2.EditValue;
                        break;
                    default:
                        grandTotal = this.toplamTutar.EditValue;
                        break;
                }
                #endregion
                xrpTeklifFormu rptFiyatli = new xrpTeklifFormu(t, ft, BAYMYO.UI.Converts.NullToFloat(grandTotal), BAYMYO.UI.Converts.NullToFloat(this.iskontoTextEdit.EditValue));
                rptFiyatli.Data = m_TeklifDetaySepet;
                rptFiyatli.ShowPreview();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 4) + ex.Message);
            }
        }
        public void SiparisFormuFiyatsiz(FormType ft)
        {
            try
            {
                if (ChangedSaved()) return;
                xrpTeklifFormuFiyatsiz rptFiyatsiz = new xrpTeklifFormuFiyatsiz(t, ft);
                rptFiyatsiz.Data = m_TeklifDetaySepet;
                rptFiyatsiz.ShowPreview();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 5) + ex.Message);
            }
        }
        public void SiparisToplamaListesi()
        {
            try
            {
                if (ChangedSaved()) return;
                if (!Commons.ShowBox(QuestionType.SiparisToplama))
                {
                    var groupFirmalar = (from x in m_TeklifDetaySepet
                                         group x by x.FirmaAdi into g
                                         select new { ID = g.Key, Value = g.Key }).ToList();
                    using (xFrmCheckList chk = new xFrmCheckList())
                    {
                        chk.Text = "Firma Seçiniz!";
                        chk.DataListCheckhed.DataSource = groupFirmalar;
                        switch (chk.ShowDialog())
                        {
                            case DialogResult.OK:
                                for (int i = 0; i < chk.DataListCheckhed.CheckedItems.Count; i++)
                                {
                                    xrpTeklifToplamaFiyatsiz rpt = new xrpTeklifToplamaFiyatsiz(t);
                                    rpt.Data = m_TeklifDetaySepet.FindAll(p => p.FirmaAdi.Equals(chk.DataListCheckhed.CheckedItems[i].ToString(), StringComparison.CurrentCultureIgnoreCase));
                                    rpt.ShowPreview();
                                }
                                break;
                        }
                    }
                }
                else
                {
                    xrpTeklifToplamaFiyatsiz rpt = new xrpTeklifToplamaFiyatsiz(t);
                    rpt.Data = m_TeklifDetaySepet;
                    rpt.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 6) + ex.Message);
            }
        }
        public void SiparisMaliyetListesi()
        {
            try
            {
                if (ChangedSaved()) return;
                if (!Commons.ShowBox(QuestionType.SipariMaliyet))
                {
                    var groupFirmalar = (from x in m_TeklifDetaySepet
                                         group x by x.FirmaAdi into g
                                         select new { ID = g.Key, Value = g.Key }).ToList();
                    using (xFrmCheckList chk = new xFrmCheckList())
                    {
                        chk.Text = "Firma Seçiniz!";
                        chk.DataListCheckhed.DataSource = groupFirmalar;
                        switch (chk.ShowDialog())
                        {
                            case DialogResult.OK:
                                for (int i = 0; i < chk.DataListCheckhed.CheckedItems.Count; i++)
                                {
                                    xrpTeklifMaliyetRapor rpt = new xrpTeklifMaliyetRapor(t);
                                    rpt.Data = m_TeklifDetaySepet.FindAll(p => p.FirmaAdi.Equals(chk.DataListCheckhed.CheckedItems[i].ToString(), StringComparison.CurrentCultureIgnoreCase));
                                    rpt.ShowPreview();
                                }
                                break;
                        }
                    }
                }
                else
                {
                    xrpTeklifMaliyetRapor rpt = new xrpTeklifMaliyetRapor(t);
                    rpt.Data = m_TeklifDetaySepet;
                    rpt.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 7) + ex.Message);
            }
        }
        public void SiparisIceriAktar()
        {
            try
            {
                if (StatusCheck())
                    return;
                #region --- Teklif Formu Başlıklarını Kaydet ---
                if (t.ID <= 0)
                    this.Saved();
                if (t.ID <= 0)
                {
                    Commons.Status("Uyarı: Teklif formu işlemi başlığı kaydedilemedi lütfen tekrar deneyiniz.");
                    MessageBox.Show("Teklif formu işlemi başlığı kaydedilemedi lütfen tekrar deneyiniz.", "Uyarı");
                    return;
                }
                #endregion
                using (xFrmExcelAktarim frm = new xFrmExcelAktarim())
                {
                    frm.TeklifObject = t;
                    frm.TeklifDetaylari = m_TeklifDetaySepet;
                    frm.Urunler = m_UrunKatalog;
                    switch (frm.ShowDialog())
                    {
                        case DialogResult.OK:
                        case DialogResult.Retry:
                        case DialogResult.Yes:
                            GetTeklifler();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 8) + ex.Message);
            }
        }
        public void SepetiGeriAl()
        {
            try
            {
                if (StatusCheck())
                    return;
                if (m_TeklifDetaySilinen == null) return;
                bool isOkey = false;
                try
                {
                    foreach (TeklifDetay t in m_TeklifDetaySilinen)
                        isOkey = TeklifDetayMethods.Insert(t) > 0;
                    m_TeklifDetaySilinen = null;
                }
                catch (Exception ex)
                {
                    Commons.Status(Commons.GetErrorCode("FTK", 9) + ex.Message);
                }
                finally
                {
                    IsTempValue = false;
                    (this.MdiParent as rFrmMain).sepetiGeriAlButton.Enabled = IsTempValue;
                    if (isOkey)
                        GetTeklifler();
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 10) + ex.Message);
            }
        }

        public void GetDefault()
        {
            this.adetCalcEdit.EditValue = 1;
            this.tarihDateEdit.DateTime = DateTime.Now;
            this.kdvBindingSource.DataSource = Commons.GetTax();
            this.statusBindingSource.DataSource = Commons.GetStatus();
            this.popupFilterModeComboBox.EditValue = "STARTS WITH";
        }
        public void GetDoviz()
        {
            this.kur1CalcEdit.Value = BAYMYO.UI.Converts.NullToDecimal(t.Kur1);
            this.kur1DescLabel.Text = Commons.Kur1Symbol + " " + Commons.Kur1.ToString("##0.0000");
            this.kur2CalcEdit.Value = BAYMYO.UI.Converts.NullToDecimal(t.Kur2);
            this.kur2DescLabel.Text = Commons.Kur2Symbol + " " + Commons.Kur2.ToString("##0.0000");

            //this.dovizCheckButton.Text = string.Format("{0}\n{2}: {4:##0.0000} | {3}: {5:##0.0000}\n\n{1}\n{2}: {6:##0.0000} | {3}: {7:##0.0000}",
            //    L.KurKaydedilen, L.KurYeni, Commons.Kur1Code, Commons.Kur2Code, t.Kur1, t.Kur2, Commons.Kur1, Commons.Kur2);
        }
        public void GetKategoriler()
        {
            KategoriCollection k = KategoriMethods.GetSelect();
            k.Add(new Kategori { ID = 0, Kod = "...", Adi = L.TumKategorilereUygula });
            this.kategoriBindingSource.DataSource = k;
        }
        public void GetStokListe()
        {
            m_UrunKatalog = UrunKatalogMethods.GetUrunKatalog();
            this.urunKatalogBindingSource.DataSource = m_UrunKatalog;
        }
        public void GetTeklif()
        {
            try
            {
                GetDoviz();
                if (t.ID > 0)
                {
                    this.Name = "frm" + t.ID;
                    this.Text = t.GemiAdi;
                    GetTeklifler();
                    DovizDegisti(t.ParaBirimi);
                    #region --- Açılan Teklif ---
                    IsReferanceNoChange = true;
                    this.referNoCalcEdit.Value = t.ID;
                    IsReferanceNoChange = false;
                    this.gemiAdiTextEdit.Text = t.GemiAdi;
                    this.baglamaLimaniTextEdit.Text = t.BaglamaLimani;
                    this.acentaTextEdit.Text = t.Acenta;
                    this.firmaTextEdit.Text = t.Manager;
                    this.tarihDateEdit.DateTime = t.Tarih;
                    this.paraBirimiRadioGroup.EditValue = t.ParaBirimi;
                    this.kdvLookUpEdit.EditValue = t.Kdv;
                    this.tasimaUcretiCalcEdit.EditValue = t.TasimaUcreti;
                    this.iskontoCalcEdit.EditValue = t.Iskonto;
                    this.hazirlayanComboBoxEdit.Text = t.Hazirlayan;
                    this.paymentComboBoxEdit.EditValue = t.OdemeSekli;
                    this.deliveryComboBoxEdit.EditValue = t.TeslimSuresi;
                    this.noteMemoEdit.Text = t.Aciklama;
                    this.statusNotsMemoExEdit.EditValue = t.DurumNotu;
                    this.statusLookUpEdit.EditValue = t.Durum;
                    this.tasimaUcretiMemoExEdit.EditValue = t.TasimaUcretiNotu;
                    DurumDegisti();
                    #endregion
                    #region --- Main Form ---
                    rFrmMain frm = this.MdiParent as rFrmMain;
                    frm.faturaHazirlaButton.Enabled = true;
                    frm.teklifVermeButton.Enabled = true;
                    frm.teslimEtmeButton.Enabled = true;
                    frm.siparisMaliyetButton.Enabled = true;
                    frm.siparisToplamaButton.Enabled = true;
                    #endregion
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 11) + ex.Message);
            }
        }
        public void Saved()
        {
            try
            {
                if (StatusCheck())
                    return;
                if (Commons.IsNullOrEmpty(dxErrorProvider1, this.aliciGroupControl.Controls))
                    return;
                else if (this.kdvLookUpEdit.EditValue == null)
                {
                    dxErrorProvider1.SetError(this.kdvLookUpEdit, L.BosGecilemez);
                    return;
                }
                if (t == null)
                    t = new Teklif();
                t.GemiAdi = this.gemiAdiTextEdit.Text.ToUpper();
                t.BaglamaLimani = this.baglamaLimaniTextEdit.Text.ToUpper();
                t.Acenta = this.acentaTextEdit.Text.ToUpper();
                t.Manager = this.firmaTextEdit.Text;
                t.Tarih = this.tarihDateEdit.DateTime;
                t.ParaBirimi = this.paraBirimiRadioGroup.EditValue.ToString();
                t.Kdv = BAYMYO.UI.Converts.NullToByte(this.kdvLookUpEdit.EditValue);
                t.TasimaUcreti = BAYMYO.UI.Converts.NullToFloat(this.tasimaUcretiCalcEdit.Value);
                t.Iskonto = BAYMYO.UI.Converts.NullToFloat(this.iskontoCalcEdit.Value);
                t.Hazirlayan = this.hazirlayanComboBoxEdit.Text;
                t.OdemeSekli = this.paymentComboBoxEdit.Text;
                t.TeslimSuresi = this.deliveryComboBoxEdit.Text;
                t.Aciklama = this.noteMemoEdit.Text;
                t.GuncellemeTarihi = DateTime.Now;
                t.DurumNotu = BAYMYO.UI.Converts.NullToString(this.statusNotsMemoExEdit.EditValue);
                t.Durum = BAYMYO.UI.Converts.NullToByte(this.statusLookUpEdit.EditValue);
                t.TasimaUcretiNotu = BAYMYO.UI.Converts.NullToString(this.tasimaUcretiMemoExEdit.EditValue);
                //KUR GÜNCELLEME BİLGİSİ
                t.Kur1 = BAYMYO.UI.Converts.NullToFloat(this.kur1CalcEdit.Value);
                t.Kur2 = BAYMYO.UI.Converts.NullToFloat(this.kur2CalcEdit.Value);
                if (t.Iskonto >= 1)
                    t.Iskonto = t.Iskonto / 100;
                if (this.paraBirimiRadioGroup.Text.Equals(Commons.AppSettings.DEFAULT_CURRENCY.Code) & t.Kdv.Equals(1))
                    if (MessageBox.Show("Teklif'de \"TAX FREE\" seçili onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                if (this.dovizCheckButton.Checked 
                    || BAYMYO.UI.Converts.NullToBool(this.dovizCheckButton.Tag))
                    GetTeklifler();
                if (t.ID <= 0)
                {
                    Commons.Status("\"" + t.GemiAdi + "\" gemi için hazırlanan teklif formundaki bilgiler başarılı bir şekilde kaydedildi.");
                    t.ID = TeklifMethods.Insert(t);
                    IsTempValue = false;
                }
                else if (t.ID > 0)
                {
                    Commons.Status("\"" + t.GemiAdi + "\" gemi için hazırlanan teklif formundaki bilgiler başarılı bir şekilde güncellendi.");
                    IsTempValue = !(TeklifMethods.Update(t) > 0);
                }
                dxErrorProvider1.ClearErrors();
                Commons.Update(TableNames.Teklif);
                this.Name = "frm" + t.ID;
                this.Text = t.GemiAdi;
                this.IsReferanceNoChange = true;
                this.referNoCalcEdit.Value = t.ID;
                this.IsReferanceNoChange = false;
                this.dovizCheckButton.Tag = 0;
                this.dovizCheckButton.Checked = false;
                DurumDegisti();
                #region --- Main Form ---
                rFrmMain frm = this.MdiParent as rFrmMain;
                frm.teklifVermeButton.Enabled = !IsTempValue;
                frm.teslimEtmeButton.Enabled = !IsTempValue;
                frm.siparisMaliyetButton.Enabled = !IsTempValue;
                frm.siparisToplamaButton.Enabled = !IsTempValue;
                frm.faturaHazirlaButton.Enabled = !IsTempValue;
                frm.iceriAktarButton.Enabled = !IsTempValue;
                frm.teklifKaydetButton.Enabled = IsTempValue;
                #endregion
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 12) + ex.Message);
            }
        }

        bool ChangedSaved()
        {
            if (t.ID > 0 & IsTempValue)
                switch (MessageBox.Show("\"" + t.GemiAdi + "\" gemi için hazırlanan teklif formu üzerinde değişiklik yaptınız bu değişiklikleri kaydetmek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Cancel:
                        return true;
                    case DialogResult.Retry:
                    case DialogResult.Yes:
                        this.Saved();
                        return false;
                }
            return false;
        }
        bool StatusCheck()
        {
            if (t.Durum == 3)
            {
                MessageBox.Show("'ONAYLANAN' teklif üzerinde herhangi bir işlem gerçekleştirilemez! Onayı kaldırabilmeniz için durumunu değiştirmeniz gereklidir.", "Uyarı");
                return true;
            }
            else if (t.Durum == 4)
            {
                MessageBox.Show("'İPTAL EDİLEN' teklif üzerinde herhangi bir işlem gerçekleştirilmez! İptal'i kaldırabilmeniz için durumunu değiştirmeniz gereklidir.", "Uyarı");
                return true;
            }
            return false;
        }
        void GetTeklifler()
        {
            m_TeklifDetaySepet = TeklifDetayMethods.GetSelect(t);
            this.teklifDetayBindingSource.DataSource = m_TeklifDetaySepet;
        }
        void GetToplamlar()
        {
            try
            {
                decimal
                    totalPrice = BAYMYO.UI.Converts.NullToDecimal(this.colSatisTutar.SummaryItem.SummaryValue),
                    totalPriceKur1 = BAYMYO.UI.Converts.NullToDecimal(this.colSatisTutarKur1.SummaryItem.SummaryValue),
                    totalPriceKur2 = BAYMYO.UI.Converts.NullToDecimal(this.colSatisTutarKur2.SummaryItem.SummaryValue);
                if (this.iskontoCalcEdit.Value > 0)
                {
                    decimal discountPriceTL = (totalPrice * this.iskontoCalcEdit.Value);
                    totalPrice -= discountPriceTL;
                    totalPriceKur1 -= (discountPriceTL / (decimal)t.Kur1);
                    totalPriceKur2 -= (discountPriceTL / (decimal)t.Kur2);
                    this.iskontoTextEdit.EditValue = discountPriceTL;
                }
                else
                    this.iskontoTextEdit.EditValue = 0;
                if (this.tasimaUcretiCalcEdit.Value > 0)
                {
                    decimal deliveryPriceTL = this.tasimaUcretiCalcEdit.Value;
                    totalPrice += deliveryPriceTL;
                    totalPriceKur1 += (deliveryPriceTL / (decimal)t.Kur1);
                    totalPriceKur2 += (deliveryPriceTL / (decimal)t.Kur2);
                }
                this.toplamTutar.EditValue = totalPrice;
                this.toplamTutarKur1.EditValue = totalPriceKur1;
                this.toplamTutarKur2.EditValue = totalPriceKur2;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 13) + ex.Message);
            }
        }
        void DurumDegisti()
        {
            bool isEnable = !(t.Durum == 3 || t.Durum == 4);
            this.iskontoCalcEdit.Enabled = isEnable;
            this.tasimaUcretiCalcEdit.Enabled = isEnable;
            this.aliciGroupControl.Enabled = isEnable;
            this.urunGroupControl.Enabled = isEnable;
            this.karOraniGroupControl.Enabled = isEnable;
            this.dovizCheckButton.Tag = isEnable;
            this.dovizCheckButton.Enabled = isEnable;
            this.paymentComboBoxEdit.Enabled = isEnable;
            this.deliveryComboBoxEdit.Enabled = isEnable;
            this.noteMemoEdit.Enabled = isEnable;
            this.tasimaUcretiMemoExEdit.Enabled = isEnable;
            this.teklifDetayGridView.OptionsBehavior.Editable = isEnable;
            this.teklifDetayGridView.OptionsView.NewItemRowPosition = !isEnable
                ? DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None : DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
        }
        void DovizDegisti(string paraBirimi)
        {
            #region --- Visible ---
            //TL
            colBirimFiyati.VisibleIndex = -1;
            colSatisFiyati.VisibleIndex = -1;
            colAlisTutar.VisibleIndex = -1;
            colSatisTutar.VisibleIndex = -1;
            colKazanc.VisibleIndex = -1;
            //DOLAR
            colBirimFiyatiKur1.VisibleIndex = -1;
            colSatisFiyatiKur1.VisibleIndex = -1;
            colAlisTutarKur1.VisibleIndex = -1;
            colSatisTutarKur1.VisibleIndex = -1;
            colKazancKur1.VisibleIndex = -1;
            //EURO
            colBirimFiyatiKur2.VisibleIndex = -1;
            colSatisFiyatiKur2.VisibleIndex = -1;
            colAlisTutarKur2.VisibleIndex = -1;
            colSatisTutarKur2.VisibleIndex = -1;
            colKazancKur2.VisibleIndex = -1;
            #endregion

            byte index = 0;
            colSiraNo.VisibleIndex = index++;
            colStokObject.VisibleIndex = index++;
            colUrunAdi1.VisibleIndex = index++;
            colFirmaAdi1.VisibleIndex = index++;
            colAdet.VisibleIndex = index++;
            colBirim1.VisibleIndex = index++;
            colKarOrani.VisibleIndex = 7;
            index++;
            index++;
            switch (paraBirimi)
            {
                case "KUR1":
                    colBirimFiyatiKur1.VisibleIndex = 6;
                    colSatisFiyatiKur1.VisibleIndex = index++;
                    //colAlisTutarDolar.VisibleIndex = index++;
                    colSatisTutarKur1.VisibleIndex = index++;
                    colKazancKur1.VisibleIndex = index++;
                    break;
                case "KUR2":
                    colBirimFiyatiKur2.VisibleIndex = 6;
                    colSatisFiyatiKur2.VisibleIndex = index++;
                    //colAlisTutarEuro.VisibleIndex = index++;
                    colSatisTutarKur2.VisibleIndex = index++;
                    colKazancKur2.VisibleIndex = index++;
                    break;
                default:
                    colBirimFiyati.VisibleIndex = 6;
                    colSatisFiyati.VisibleIndex = index++;
                    //colAlisTutar.VisibleIndex = index++;
                    colSatisTutar.VisibleIndex = index++;
                    colKazanc.VisibleIndex = index++;
                    break;
            }
        }
        #endregion

        public xFrmTeklif()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        #region --- Events/Olaylar ---
        void xFrmTeklif_Load(object sender, EventArgs e)
        {
            try
            {
                Commons.Status(this.Text + " ekranı açıldı.");
                if (Commons.AppSettings.PREPAREDBY.Contains(","))
                    this.hazirlayanComboBoxEdit.Properties.Items.AddRange(Commons.AppSettings.PREPAREDBY.Split(','));
                GetDefault();
                GetKategoriler();
                GetStokListe();
                GetTeklif();
                IsFormLoad = false;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 14) + ex.Message);
            }
        }
        void xFrmTeklif_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            if (ChangedSaved()) e.Cancel = true;
        }

        void all_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsFormLoad)
            {
                IsTempValue = true;
                Commons.Status("\"" + t.GemiAdi + "\" gemi için hazırlanan teklif formunda güncellenecek kayıtlar mevcut bilgilerinizi kaybetmemek için kaydet butonuna basınız!");
                (this.MdiParent as rFrmMain).teklifKaydetButton.Enabled = IsTempValue;
                if (!this.Text.Contains("(*)"))
                    this.Text = this.Text + " (*)";
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

        void impaCodeText_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    this.adetCalcEdit.Focus();
                    break;
            }
        }
        void idCalcEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    this.adetCalcEdit.Focus();
                    break;
            }
        }
        void adetCalcEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    this.urunEkleButton.PerformClick();
                    if (this.idCalcEdit.Value > 0)
                    {
                        this.idCalcEdit.Value = 0;
                        this.idCalcEdit.EditValue = null;
                        this.idCalcEdit.Focus();
                    }
                    else if (!string.IsNullOrWhiteSpace(BAYMYO.UI.Converts.NullToString(this.impaCodeText.EditValue)))
                    {
                        this.impaCodeText.EditValue = null;
                        this.impaCodeText.Focus();
                    }
                    else if (this.stokSearchLookUp.EditValue != null)
                    {
                        this.stokSearchLookUp.EditValue = null;
                        this.stokSearchLookUp.Focus();
                    }
                    break;
            }
        }

        void urunEkleButton_Click(object sender, EventArgs e)
        {
            try
            {
                UrunKatalog sl = null;
                if (this.adetCalcEdit.Value <= 0)
                {
                    Commons.Status("Uyarı: Ürün eklemek için \"Adet\" kutusunu boş bırakmayınız!");
                    return;
                }
                if (this.idCalcEdit.Value > 0)
                {
                    var r = m_UrunKatalog.FindAll(x => x.UrunID.Equals(BAYMYO.UI.Converts.NullToInt(this.idCalcEdit.Value))).OrderBy(x => x.Fiyat).Take(1);
                    if (r.Count() > 0)
                        sl = r.ElementAt(0);
                }
                else if (!string.IsNullOrWhiteSpace(BAYMYO.UI.Converts.NullToString(this.impaCodeText.EditValue)))
                {
                    var r = m_UrunKatalog.FindAll(x => x.ImpaCode.Equals(BAYMYO.UI.Converts.NullToString(this.impaCodeText.EditValue))).OrderBy(x => x.Fiyat).Take(1);
                    if (r.Count() > 0)
                        sl = r.ElementAt(0);
                }
                else
                    sl = this.stokSearchLookUpView.GetFocusedRow() as UrunKatalog;
                if (sl == null)
                {
                    Commons.Status("Uyarı: Eklemek istediğiniz ürün bulunamadı lütfen ürün kodunu yada seçilebilir sepeti kontrol ediniz!");
                    return;
                }
                #region --- Teklif Formu Başlıklarını Kaydet ---
                if (t.ID <= 0)
                    this.Saved();
                if (t.ID <= 0)
                {
                    Commons.Status("Uyarı: Teklif formu işlemi başlığı kaydedilemedi lütfen tekrar deneyiniz.");
                    return;
                }
                #endregion
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
                     Adet = BAYMYO.UI.Converts.NullToFloat(this.adetCalcEdit.Value)
                 })
                {
                    if (TeklifDetayMethods.Insert(td) > 0)
                    {
                        Commons.Update(TableNames.Teklif);
                        Commons.Status("\"" + td.UrunAdi + "\" isimli üründen sepete '" + td.Adet + "' adet başarılı bir şekilde eklendi.");
                        this.adetCalcEdit.Value = 0;
                        this.adetCalcEdit.EditValue = null;
                        GetTeklifler();
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 15) + ex.Message);
            }
        }
        void urunKatalogButton_Click(object sender, EventArgs e)
        {
            try
            {
                #region --- Teklif Formu Başlıklarını Kaydet ---
                if (t.ID <= 0)
                    this.Saved();
                if (t.ID <= 0)
                {
                    Commons.Status("Uyarı: Teklif formu işlemi başlığı kaydedilemedi lütfen tekrar deneyiniz.");
                    MessageBox.Show("Teklif formu işlemi başlığı kaydedilemedi lütfen tekrar deneyiniz.", "Uyarı");
                    return;
                }
                #endregion
                using (xFrmUrunKatalog frm = new xFrmUrunKatalog())
                {
                    frm.TeklifObject = t;
                    if (m_TeklifDetaySepet != null)
                        frm.TeklifDetayObject = m_TeklifDetaySepet.FindAll(x => x.StokID > 0);
                    switch (frm.ShowDialog())
                    {
                        case DialogResult.OK:
                            GetTeklifler();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 16) + ex.Message);
            }
        }

        void karEkleButton_Click(object sender, EventArgs e)
        {
            try
            {
                int kategoriID = BAYMYO.UI.Converts.NullToInt(categoriesLookUpEdit.EditValue);
                List<TeklifDetay> teklifDetaylari = null;
                if (kategoriID > 0)
                    teklifDetaylari = m_TeklifDetaySepet.FindAll(x => x.KategoriID.Equals(kategoriID));
                else
                    teklifDetaylari = m_TeklifDetaySepet;
                foreach (TeklifDetay td in teklifDetaylari)
                {
                    td.KarOrani += ((float)this.karOranCalcEdit.Value);
                    TeklifDetayMethods.Update(td);
                }
                GetTeklifler();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 17) + ex.Message);
            }
        }
        void karCikarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int kategoriID = BAYMYO.UI.Converts.NullToInt(this.categoriesLookUpEdit.EditValue);
                List<TeklifDetay> teklifDetaylari = null;
                if (kategoriID > 0)
                    teklifDetaylari = m_TeklifDetaySepet.FindAll(x => x.KategoriID.Equals(kategoriID));
                else
                    teklifDetaylari = m_TeklifDetaySepet;
                foreach (TeklifDetay td in teklifDetaylari)
                {
                    td.KarOrani -= ((float)this.karOranCalcEdit.Value);
                    TeklifDetayMethods.Update(td);
                }
                GetTeklifler();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 18) + ex.Message);
            }
        }
        void karAyniButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.karOranCalcEdit.Value <= 0
                    || MessageBox.Show("Kâr " + this.karOranCalcEdit.Value.ToString("% ##0") + " olarak değiştirilecek kabul ediyor musunuz?", "Kâr Oranı Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
                int kategoriID = BAYMYO.UI.Converts.NullToInt(this.categoriesLookUpEdit.EditValue);
                List<TeklifDetay> teklifDetaylari = null;
                if (kategoriID > 0)
                    teklifDetaylari = m_TeklifDetaySepet.FindAll(x => x.KategoriID.Equals(kategoriID));
                else
                    teklifDetaylari = m_TeklifDetaySepet;
                if (teklifDetaylari != null)
                {
                    foreach (TeklifDetay td in teklifDetaylari)
                    {
                        td.KarOrani = ((float)this.karOranCalcEdit.Value);
                        TeklifDetayMethods.Update(td);
                    }
                    GetTeklifler();
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 19) + ex.Message);
            }
        }

        void teklifDetayGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Delete:
                        if (StatusCheck())
                            return;
                        int[] indexs = this.teklifDetayGridView.GetSelectedRows();
                        bool isOkey = false;
                        if (indexs.Length > 1)
                        {
                            if (MessageBox.Show("Sepetteki \"" + indexs.Length + "\" adet ürününü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                return;
                            Commons.Loading("Sepetinizden silinmesi için seçtiğiniz ürünler siliniyor...");
                            m_TeklifDetaySilinen = null;
                            m_TeklifDetaySilinen = new List<TeklifDetay>();
                            foreach (int i in indexs)
                            {
                                TeklifDetay td = this.teklifDetayGridView.GetRow(i) as TeklifDetay;
                                if (TeklifDetayMethods.Delete(td) > 0)
                                {
                                    m_TeklifDetaySilinen.Add(td);
                                    isOkey = true;
                                }
                            }
                            IsTempValue = (m_TeklifDetaySilinen.Count > 0);
                            (this.MdiParent as rFrmMain).sepetiGeriAlButton.Enabled = IsTempValue;
                        }
                        else
                        {
                            TeklifDetay td = this.teklifDetayGridView.GetFocusedRow() as TeklifDetay;
                            if (MessageBox.Show("\"" + td.FirmaAdi + "\" firmasının sepetteki \"" + td.UrunAdi + "\" isimli ürününü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                if (TeklifDetayMethods.Delete(td) > 0)
                                {
                                    Commons.Status("\"" + td.FirmaAdi + "\" firmasının sepetteki \"" + td.UrunAdi + "\" isimli ürünü silme işlemi gerçekleştirildi!");
                                    isOkey = true;
                                }
                        }
                        if (isOkey)
                        {
                            Commons.Update(TableNames.Teklif);
                            GetTeklifler();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 20) + ex.Message);
            }
            finally
            {
                Commons.Loaded();
            }
        }
        void teklifDetayGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName)
                {
                    case "UrunAdi":
                        TeklifDetay td = this.teklifDetayGridView.GetFocusedRow() as TeklifDetay;
                        if (td.SiraNo <= 0)
                            td.SiraNo = m_TeklifDetaySepet.Count;
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 21) + ex.Message);
            }
        }
        void teklifDetayGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool isOkey = false;
            try
            {
                if (StatusCheck())
                    return;
                TeklifDetay td = this.teklifDetayGridView.GetFocusedRow() as TeklifDetay;
                if (td.ID > 0)
                {
                    if (TeklifDetayMethods.Update(td) > 0)
                    {
                        Commons.Status("\"" + td.FirmaAdi + "\" firmasının sepetteki \"" + td.UrunAdi + "\" isimli ürünü güncelleme işlemi gerçekleştirildi!");
                        isOkey = true;
                    }
                }
                else if (!string.IsNullOrEmpty(td.UrunAdi) & !string.IsNullOrEmpty(td.FirmaAdi) & td.Adet > 0)
                {
                    #region --- Teklif Formu Başlıklarını Kaydet ---
                    if (t.ID <= 0)
                        this.Saved();
                    if (t.ID <= 0)
                    {
                        Commons.Status("Uyarı: Teklif formu işlemi başlığı kaydedilemedi lütfen tekrar deneyiniz.");
                        return;
                    }
                    #endregion
                    td.TeklifID = t.ID;
                    td.Miktar = 1;
                    if (td.Adet <= 0)
                        td.Adet = 1;
                    if (td.KarOrani <= 0)
                        td.KarOrani = 0.45f;
                    if (TeklifDetayMethods.Insert(td) > 0)
                    {
                        Commons.Status("\"" + td.FirmaAdi + "\" firmadan \"" + td.UrunAdi + "\" isimli stoklarınızda olmayan ürün eklediniz!");
                        isOkey = true;
                    }
                }
                else
                    Commons.Status("Sepetinize stoklarda olmayan ürün eklerken 'Ürün Adı', 'Tedarikçi Firma' ve Adet alanları boş bırakılamaz!");
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 22) + ex.Message);
            }
            finally
            {
                if (isOkey)
                {
                    Commons.Update(TableNames.Teklif);
                    GetTeklifler();
                }
                else
                    e.Valid = false;
            }
        }
        void teklifDetayGridView_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GetToplamlar();
        }

        void dovizCalcEdit_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CalcEdit clc = sender as DevExpress.XtraEditors.CalcEdit;
            switch (clc.Name)
            {
                case "kur1CalcEdit":
                    if (clc.Value != BAYMYO.UI.Converts.NullToDecimal(t.Kur1))
                    {
                        this.dovizCheckButton.Tag = 1;
                        all_EditValueChanged(sender, e);
                    }
                    break;
                case "kur2CalcEdit":
                    if (clc.Value != BAYMYO.UI.Converts.NullToDecimal(t.Kur2))
                    {
                        this.dovizCheckButton.Tag = 1;
                        all_EditValueChanged(sender, e);
                    }
                    break;
            }

        }
        void dovizCheckButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dovizCheckButton.Checked)
            {
                this.kur1CalcEdit.Value = BAYMYO.UI.Converts.NullToDecimal(Commons.Kur1);
                this.kur2CalcEdit.Value = BAYMYO.UI.Converts.NullToDecimal(Commons.Kur2);
                all_EditValueChanged(sender, e);
            }
            else
            {
                this.kur1CalcEdit.Value = BAYMYO.UI.Converts.NullToDecimal(t.Kur1);
                this.kur2CalcEdit.Value = BAYMYO.UI.Converts.NullToDecimal(t.Kur2);
            }
        }

        void stokSearchLookUp_EditValueChanged(object sender, EventArgs e)
        {
            this.adetCalcEdit.Focus();
        }
        void paraBirimiRadioGroup_EditValueChanged(object sender, EventArgs e)
        {
            DovizDegisti(this.paraBirimiRadioGroup.EditValue.ToString());
            all_EditValueChanged(sender, e);
        }
        void toplamCalcEdit_EditValueChanged(object sender, EventArgs e)
        {
            GetToplamlar();
            all_EditValueChanged(sender, e);
        }

        void popupFilterModeComboBox_EditValueChanged(object sender, EventArgs e)
        {
            switch (popupFilterModeComboBox.EditValue.ToString().ToLower())
            {
                case "default":
                    this.stokSearchLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Default;
                    break;
                case "contains":
                case "contaıns":
                    this.stokSearchLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                    break;
                default:
                    this.stokSearchLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
                    break;
            }
        }
        void statusLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (t.ID <= 0)
                    return;
                if (t.Durum == 3 || t.Durum == 4)
                {
                    byte durum = BAYMYO.UI.Converts.NullToByte(this.statusLookUpEdit.EditValue);
                    string mesaj = null;
                    switch (t.Durum)
                    {
                        case 3:
                            mesaj = "Onaylı teklif üzerindeki durum değişikliğini kabul ediyor musunuz?";
                            break;
                        case 4:
                            mesaj = "İptal edilen teklif üzerindeki durum değişikliğini kabul ediyor musunuz?";
                            break;
                    }
                    if (t.Durum != durum)
                        if (MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            t.Durum = durum;
                            TeklifMethods.Update(t);
                            DurumDegisti();
                        }
                        else
                            this.statusLookUpEdit.EditValue = t.Durum;
                    mesaj = null;
                }
                else
                    all_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 23) + ex.Message);
            }
        }
        void referNoCalcEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Enter:
                        if (t.ID > 0 & IsTempValue & !IsReferanceNoChange)
                            switch (MessageBox.Show("\"" + t.GemiAdi + "\" isimli gemi için oluşturulan teklif formu üzerinde değişiklik yaptınız bu değişiklikleri kaydetmek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                            {
                                case DialogResult.Cancel:
                                    IsReferanceNoChange = true;
                                    this.referNoCalcEdit.Value = t.ID;
                                    return;
                                case DialogResult.Retry:
                                case DialogResult.Yes:
                                    this.Saved();
                                    break;
                            }
                        if (this.referNoCalcEdit.Value > 0 & !IsFormLoad & !IsReferanceNoChange)
                        {
                            IsFormLoad = true;
                            using (Teklif temp = TeklifMethods.GetTeklif(BAYMYO.UI.Converts.NullToInt64(this.referNoCalcEdit.Value)))
                            {
                                if (temp.ID <= 0)
                                {
                                    IsReferanceNoChange = true;
                                    this.referNoCalcEdit.Value = t.ID;
                                    MessageBox.Show("Referans numarası '" + t.ID + "' olan teklif bulunamadı lütfen tekrar deneyiniz.", "Uyarı");
                                    return;
                                }
                                t = temp;
                                GetTeklif();
                                Commons.Status("Referans numarası '" + t.ID + "' olan ilgili teklif ekrana geldi!");
                                this.stokSearchLookUp.Focus();
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTK", 24) + ex.Message);
            }
            finally
            {
                IsReferanceNoChange = false;
                IsFormLoad = false;
            }
        }
        #endregion
    }
}