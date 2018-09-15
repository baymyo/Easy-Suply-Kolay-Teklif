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
    public partial class xFrmHakkimizda : DevExpress.XtraEditors.XtraForm
    {
        public xFrmHakkimizda()
        {
            InitializeComponent();
        }

        private void xFrmHakkimizda_Load(object sender, EventArgs e)
        {
            lblProductVersion.Text = "Product Version: " + ProductVersion;
            lblProductSerialKey.Text = "Product Serial: " + Commons.MySerialKey;
        }
    }
}