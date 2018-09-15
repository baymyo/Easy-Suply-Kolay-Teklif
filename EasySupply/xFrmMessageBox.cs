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
    public partial class xFrmMessageBox : DevExpress.XtraEditors.XtraForm
    {
        public QuestionType QuestionForm { get; set; }

        public xFrmMessageBox()
        {
            InitializeComponent();
        }

        private void xFrmMessageBox_Load(object sender, EventArgs e)
        {
            switch (QuestionForm)
            {
                case QuestionType.UrunKatalogu:
                    this.Text = "Ürün Katalog Belgesi Hazırla!";
                    this.YesPictureBox.Image = Properties.Resources.catalogNumber;
                    this.YesButton.Text = "SIRA NO İLE GÖSTER";
                    this.NoPictureBox.Image = Properties.Resources.catalogID;
                    this.NoButton.Text = "ID İLE GÖSTER";
                    break;
                case QuestionType.TeklifFormu:
                    this.Text = "Teklif Belgesi Hazırla!";
                    this.YesPictureBox.Image = Properties.Resources.offerFormSingle;
                    this.YesButton.Text = "TEK TEKLİF BELGESİ";
                    this.NoPictureBox.Image = Properties.Resources.offerFormMulti;
                    this.NoButton.Text = "ÇİFT TEKLİF BELGESİ";
                    break;
                case QuestionType.TeslimFormu:
                    this.Text = "Teslim Belgesi Hazırla!";
                    this.YesPictureBox.Image = Properties.Resources.offerFormSingle;
                    this.YesButton.Text = "TEK TESLİM BELGESİ";
                    this.NoPictureBox.Image = Properties.Resources.offerFormMulti;
                    this.NoButton.Text = "ÇİFT TESLİM BELGESİ";
                    break;
                case QuestionType.SiparisToplama:
                    this.Text = "Sipariş Toplama Belgesi Hazırla!";
                    this.YesPictureBox.Image = Properties.Resources.orderSingle;
                    this.YesButton.Text = "TÜM FİRMALAR TEK BELGE";
                    this.NoPictureBox.Image = Properties.Resources.orderMulti;
                    this.NoButton.Text = "FİRMA BAZINDA AYRI BELGE";
                    break;
                case QuestionType.SipariMaliyet:
                    this.Text = "Sipariş Maliyet Belgesi Hazırla!";
                    this.YesPictureBox.Image = Properties.Resources.orderCostSingle;
                    this.YesButton.Text = "FİRMA MALİYETLERİ TEK BELGE";
                    this.NoPictureBox.Image = Properties.Resources.orderCostMulti;
                    this.NoButton.Text = "MALİYET FİRMA BAZINDA BELGE";
                    break;
                case QuestionType.VeritabaniOnar:
                    this.Text = "Veritabanı Onarma İşlemi!";
                    this.YesPictureBox.Image = Properties.Resources.databaseRepair;
                    this.YesButton.Text = "ONAR (TAVSİYE EDİLEN)";
                    this.NoPictureBox.Image = Properties.Resources.databaseNotRepair;
                    this.NoButton.Text = "VAZGEÇ";
                    break;
                case QuestionType.StokGirisi:
                    this.Text = "Stok Giriş İşlemi!";
                    this.YesPictureBox.Image = Properties.Resources.productUpdateList;
                    this.YesButton.Text = "GÜNCEL FİYAT LİSTESİ";
                    this.NoPictureBox.Image = Properties.Resources.productNewList;
                    this.NoButton.Text = "YENİ ÜRÜN LİSTESİ";
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}