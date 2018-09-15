namespace EasySupply
{
    partial class xFrmHakkimizda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmHakkimizda));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.baymyoHyperLinkEdit = new DevExpress.XtraEditors.HyperLinkEdit();
            this.lblProductVersion = new DevExpress.XtraEditors.LabelControl();
            this.lblProductSerialKey = new DevExpress.XtraEditors.LabelControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baymyoHyperLinkEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitle.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(203)))), ((int)(((byte)(1)))));
            this.lblTitle.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Location = new System.Drawing.Point(-4, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(366, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Easy Supply v1.1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::EasySupply.Properties.Resources.applicationIcon;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 7);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(48, 48);
            this.pictureEdit1.TabIndex = 1;
            // 
            // baymyoHyperLinkEdit
            // 
            this.baymyoHyperLinkEdit.EditValue = "http://www.baymyo.com";
            this.baymyoHyperLinkEdit.Location = new System.Drawing.Point(12, 150);
            this.baymyoHyperLinkEdit.Name = "baymyoHyperLinkEdit";
            this.baymyoHyperLinkEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.baymyoHyperLinkEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.baymyoHyperLinkEdit.Properties.Appearance.Options.UseBackColor = true;
            this.baymyoHyperLinkEdit.Properties.Appearance.Options.UseFont = true;
            this.baymyoHyperLinkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.baymyoHyperLinkEdit.Size = new System.Drawing.Size(155, 18);
            toolTipTitleItem1.Text = "baymyo yazılım";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Uygulama lisans dosyası için direk bu bağlantı üzerinden yetkililer ile iletişim " +
    "kurabilirsiniz!";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.baymyoHyperLinkEdit.SuperTip = superToolTip1;
            this.baymyoHyperLinkEdit.TabIndex = 7;
            // 
            // lblProductVersion
            // 
            this.lblProductVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProductVersion.Location = new System.Drawing.Point(13, 99);
            this.lblProductVersion.Name = "lblProductVersion";
            this.lblProductVersion.Size = new System.Drawing.Size(9, 13);
            this.lblProductVersion.TabIndex = 9;
            this.lblProductVersion.Text = "...";
            // 
            // lblProductSerialKey
            // 
            this.lblProductSerialKey.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProductSerialKey.Location = new System.Drawing.Point(13, 121);
            this.lblProductSerialKey.Name = "lblProductSerialKey";
            this.lblProductSerialKey.Size = new System.Drawing.Size(9, 13);
            this.lblProductSerialKey.TabIndex = 9;
            this.lblProductSerialKey.Text = "...";
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(12, 77);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(305, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Bu uygulama baymyo yazılım iş hızlandırma grişimidir!";
            // 
            // xFrmHakkimizda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 179);
            this.Controls.Add(this.lblProductSerialKey);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProductVersion);
            this.Controls.Add(this.baymyoHyperLinkEdit);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(367, 213);
            this.Name = "xFrmHakkimizda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hakkımızda";
            this.Load += new System.EventHandler(this.xFrmHakkimizda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baymyoHyperLinkEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.HyperLinkEdit baymyoHyperLinkEdit;
        private DevExpress.XtraEditors.LabelControl lblProductVersion;
        private DevExpress.XtraEditors.LabelControl lblProductSerialKey;
        private DevExpress.XtraEditors.LabelControl lblDescription;
    }
}