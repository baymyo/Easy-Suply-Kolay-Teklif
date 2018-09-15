namespace EasySupply
{
    partial class xFrmTrial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmTrial));
            this.MessageTextLabel = new DevExpress.XtraEditors.LabelControl();
            this.lisansDosyasiYukleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // MessageTextLabel
            // 
            this.MessageTextLabel.Appearance.BackColor = System.Drawing.Color.Red;
            this.MessageTextLabel.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MessageTextLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.MessageTextLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.MessageTextLabel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.MessageTextLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.MessageTextLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MessageTextLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MessageTextLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.MessageTextLabel.Location = new System.Drawing.Point(-2, -2);
            this.MessageTextLabel.Name = "MessageTextLabel";
            this.MessageTextLabel.Padding = new System.Windows.Forms.Padding(10);
            this.MessageTextLabel.Size = new System.Drawing.Size(347, 91);
            this.MessageTextLabel.TabIndex = 0;
            this.MessageTextLabel.Text = "Uygulamanın sonlanması için son 10 gün kaldı!";
            // 
            // lisansDosyasiYukleButton
            // 
            this.lisansDosyasiYukleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lisansDosyasiYukleButton.Appearance.Options.UseFont = true;
            this.lisansDosyasiYukleButton.Location = new System.Drawing.Point(19, 103);
            this.lisansDosyasiYukleButton.Name = "lisansDosyasiYukleButton";
            this.lisansDosyasiYukleButton.Size = new System.Drawing.Size(311, 51);
            this.lisansDosyasiYukleButton.TabIndex = 1;
            this.lisansDosyasiYukleButton.Text = "UYGULAMAYI SATIN ALMAK İÇİN TIKLA";
            this.lisansDosyasiYukleButton.Click += new System.EventHandler(this.lisansDosyasiYukle_Click);
            // 
            // xFrmTrial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 166);
            this.Controls.Add(this.lisansDosyasiYukleButton);
            this.Controls.Add(this.MessageTextLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(358, 202);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "xFrmTrial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trial Version";
            this.Load += new System.EventHandler(this.xFrmTrial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl MessageTextLabel;
        private DevExpress.XtraEditors.SimpleButton lisansDosyasiYukleButton;
    }
}