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
    public partial class xFrmKategori : DevExpress.XtraEditors.XtraForm
    {
        public void SetCurrencyAndLangs()
        {
            try
            {
                kategoriGroupControl.Text = L.YeniKategori;

                colKod.Caption = lblKod.Text = L.Kod;
                colAdi.Caption = lblKategoriAdi.Text = L.Adi;

                kaydetButton.Text = L.Kaydet;
                yeniButton.Text = L.YeniKayit;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKT", 1) + ex.Message);
            }
        }

        public void GetData()
        {
            try
            {
                kategoriBindingSource.DataSource = KategoriMethods.GetSelect();
                isRecord = false;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKT", 2) + ex.Message);
            }
        }

        public xFrmKategori()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        void xFrmKategori_Load(object sender, EventArgs e)
        {
            Commons.Status(this.Text + " ekranı açıldı.");
            GetData();
        }
        void kategoriGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Delete:
                        Kategori k = kategoriGridView.GetFocusedRow() as Kategori;
                        if (MessageBox.Show("\"" + k.Adi + "\" isimli kategori silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            if (KategoriMethods.Delete(k) > 0)
                            {
                                kategoriGridView.DeleteSelectedRows();
                                Commons.Status("\"" + k.Adi + "\" isimli kategori silme işlemi gerçekleştirildi!");
                                Commons.Update(TableNames.Kategori);
                            }
                            else
                                Commons.Status("\"" + k.Adi + "\" isimli kategori silme işleminiz başarısz!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKT", 3) + ex.Message);
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
                if (kategoriGridView.GetFocusedRow() != null)
                {
                    Kategori k = kategoriGridView.GetFocusedRow() as Kategori;
                    if (string.IsNullOrWhiteSpace(k.Kod) || string.IsNullOrWhiteSpace(k.Adi) || k.Adi.Length < 3)
                        return;
                    if (k.ID <= 0)
                    {
                        k.ID = KategoriMethods.Insert(k);
                        isRecord = k.ID > 0;
                    }
                    else
                        isRecord = KategoriMethods.Update(k) > 0;
                    if (isRecord)
                    {
                        Commons.Status("\"" + k.Adi + "\" isimli kategori ile ilgili işleminiz başarılı bir şekilde gerçekleştirildi!");
                        Commons.Update(TableNames.Kategori);
                        isRecord = false;
                    }
                    else
                        Commons.Status("\"" + k.Adi + "\" isimli kategori ile ilgili işleminiz başarısz!");
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKT", 4) + ex.Message);
            }
        }
        void yeniButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isRecord)
                {
                    kategoriBindingSource.AddNew();
                    txtKod.Focus();
                    isRecord = true;
                }
                else
                    kategoriGridView.FocusedRowHandle = kategoriGridView.RowCount - 1;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FKT", 5) + ex.Message);
            }
        }
        void splitterControl1_DoubleClick(object sender, EventArgs e)
        {
            if (kategoriGroupControl.Width < 280 || kategoriGroupControl.Width > 280)
                kategoriGroupControl.Width = 280;
            else
                kategoriGroupControl.Width = 25;
        }
    }
}