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
    public partial class xFrmFirma : DevExpress.XtraEditors.XtraForm
    {
        public void SetCurrencyAndLangs()
        {
            try
            {
                firmaGroupControl.Text = L.YeniTedarikciFirma;

                colKod.Caption = lblKod.Text = L.Kod;
                colAdi.Caption = lblFirmaAdi.Text = L.Adi;
                colYetkili.Caption = lblYetkili.Text = L.Yetkili;
                colTelefon.Caption = lblTelefon.Text = L.Telefon;
                colAdres.Caption = lblAdres.Text = L.Adres;
                colPeriod.Caption = lblPeriod.Text = L.Period;

                kaydetButton.Text = L.Kaydet;
                yeniButton.Text = L.YeniKayit;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FFR", 1) + ex.Message);
            }
        }
        public void GetData()
        {
            try
            {
                this.firmaBindingSource.DataSource = FirmaMethods.GetSelect();
                isRecord = false;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FFR", 2) + ex.Message);
            }
        }

        public xFrmFirma()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        void xFrmFirma_Load(object sender, EventArgs e)
        {
            Commons.Status(this.Text + " ekranı açıldı.");
            GetData();
        }

        void firmaGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Delete:
                        Firma f = firmaGridView.GetFocusedRow() as Firma;
                        if (MessageBox.Show("\"" + f.Adi + "\" isimli firma silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            if (FirmaMethods.Delete(f) > 0)
                            {
                                firmaGridView.DeleteSelectedRows();
                                Commons.Status("\"" + f.Adi + "\" isimli firma silme işlemi gerçekleştirildi!");
                                Commons.Update(TableNames.Firma);
                            }
                            else
                                Commons.Status("\"" + f.Adi + "\" isimli firma silme işlemi başarısız!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FFR", 3) + ex.Message);
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
        bool isRecord;
        void kaydetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (firmaGridView.GetFocusedRow() != null)
                {
                    Firma f = firmaGridView.GetFocusedRow() as Firma;
                    if (string.IsNullOrWhiteSpace(f.Adi) || string.IsNullOrWhiteSpace(f.Yetkili))
                        return;
                    f.Mail = f.Mail.ToLowerInvariant();
                    if (f.ID <= 0)
                    {
                        f.ID = FirmaMethods.Insert(f);
                        isRecord = f.ID > 0;
                    }
                    else
                        isRecord = FirmaMethods.Update(f) > 0;
                    if (isRecord)
                    {
                        Commons.Status("\"" + f.Adi + "\" isimli firma kayıt işlemi gerçekleştirildi!");
                        Commons.Update(TableNames.Firma);
                        isRecord = false;
                    }
                    else
                        Commons.Status("\"" + f.Adi + "\" isimli firma kayıt işlemi başarısız!");
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FFR", 4) + ex.Message);
            }
        }
        void yeniButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isRecord)
                {
                    firmaBindingSource.AddNew();
                    txtFirmaAdi.Focus();
                    isRecord = true;
                }
                else
                    firmaGridView.FocusedRowHandle = firmaGridView.RowCount - 1;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FFR", 5) + ex.Message);
            }
        }
        void splitterControl1_DoubleClick(object sender, EventArgs e)
        {
            if (firmaGroupControl.Width < 280 || firmaGroupControl.Width > 280)
                firmaGroupControl.Width = 280;
            else
                firmaGroupControl.Width = 25;
        }
    }
}