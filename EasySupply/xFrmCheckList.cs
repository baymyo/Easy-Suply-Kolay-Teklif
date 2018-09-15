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
    public partial class xFrmCheckList : DevExpress.XtraEditors.XtraForm
    {
        public void SetCurrencyAndLangs()
        {
            try
            {
                this.okButton.Text = L.Tamam;
                this.cancelButton.Text = L.Vazgec;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FCL", 1) + ex.Message);
            }
        }

        public xFrmCheckList()
        {
            InitializeComponent();
        }

        void xFrmCheckList_Load(object sender, EventArgs e)
        {
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            this.DataListCheckhed.CheckAll();
        }

        private void unCheckButton_Click(object sender, EventArgs e)
        {
            this.DataListCheckhed.UnCheckAll();
        }
    }
}