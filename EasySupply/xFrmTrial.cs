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
    public partial class xFrmTrial : DevExpress.XtraEditors.XtraForm
    {
        public string Mesaj { set { MessageTextLabel.Text = value; } }

        public xFrmTrial()
        {
            InitializeComponent();
        }

        void xFrmTrial_Load(object sender, EventArgs e)
        {

        }

        void lisansDosyasiYukle_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                using (xFrmValidate v = new xFrmValidate())
                {
                    switch (v.ShowDialog())
                    {
                        case DialogResult.OK:
                            this.DialogResult = DialogResult.OK;
                            return;
                        default:
                            Application.Exit();
                            return;
                    }
                }
            }
            catch (Exception)
            {
                Commons.Status(Commons.GetErrorCode("FTL", 1) + " TRIAL VERSION");
            }
        }
    }
}