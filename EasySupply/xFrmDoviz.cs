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
    public partial class xFrmDoviz : DevExpress.XtraEditors.XtraForm
    {
        public void GetData()
        {
            try
            {
                DovizCollection dc = DovizMethods.GetSelect();
                foreach (Doviz d in dc)
                    if (this.kur1CodeLabel.Text.Equals(d.Cinsi))
                    {
                        this.kur1CalcEdit.Tag = d;
                        this.kur1CalcEdit.Value = (decimal)d.Kuru;
                    }
                    else if (this.kur2CodeLabel.Text.Equals(d.Cinsi))
                    {
                        this.kur2CalcEdit.Tag = d;
                        this.kur2CalcEdit.Value = (decimal)d.Kuru;
                    }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FDV", 1) + ex.Message);
            }
        }

        public xFrmDoviz()
        {
            InitializeComponent();
        }

        private void xFrmDoviz_Load(object sender, EventArgs e)
        {
            try
            {
                Commons.Status(this.Text + " ekranı açıldı.");

                this.kur1CodeLabel.Text = Commons.AppSettings.CROSS_CURRENCY_1.Code;
                this.kur1DescLabel.Text = Commons.AppSettings.CROSS_CURRENCY_1.Description;
                this.kur1CalcEdit.Tag = new Doviz { ID = 0, Cinsi = Commons.AppSettings.CROSS_CURRENCY_1.Code };

                this.kur2CodeLabel.Text = Commons.AppSettings.CROSS_CURRENCY_2.Code;
                this.kur2DescLabel.Text = Commons.AppSettings.CROSS_CURRENCY_2.Description;
                this.kur2CalcEdit.Tag = new Doviz { ID = 0, Cinsi = Commons.AppSettings.CROSS_CURRENCY_2.Code };

                GetData();
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FDV", 2) + ex.Message);
            }
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isOkey = false;
                Doviz kur1 = this.kur1CalcEdit.Tag as Doviz;
                if ((decimal)kur1.Kuru != this.kur1CalcEdit.Value)
                {
                    kur1.Kuru = BAYMYO.UI.Converts.NullToFloat(this.kur1CalcEdit.Value);
                    kur1.Tarih = DateTime.Now;
                    if (kur1.ID > 0)
                        isOkey = DovizMethods.Update(kur1) > 0;
                    else
                        isOkey = DovizMethods.Insert(kur1) > 0;
                }
                Doviz kur2 = this.kur2CalcEdit.Tag as Doviz;
                if ((decimal)kur2.Kuru != this.kur2CalcEdit.Value)
                {
                    kur2.Kuru = BAYMYO.UI.Converts.NullToFloat(this.kur2CalcEdit.Value);
                    kur2.Tarih = DateTime.Now;
                    if (kur2.ID > 0)
                        isOkey = DovizMethods.Update(kur2) > 0;
                    else
                        isOkey = DovizMethods.Insert(kur2) > 0;
                }
                if (isOkey)
                {
                    Commons.Status("Doviz kayıt işlemi gerçekleştirildi!");
                    Commons.CurrentDoviz();
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FDV", 3) + ex.Message);
            }
        }
    }
}