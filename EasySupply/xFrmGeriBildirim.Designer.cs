namespace EasySupply
{
    partial class xFrmGeriBildirim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmGeriBildirim));
            this.konuMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.lblKonu = new DevExpress.XtraEditors.LabelControl();
            this.mesajMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.lblMesaj = new DevExpress.XtraEditors.LabelControl();
            this.gonderButton = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.konuMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // konuMemoEdit
            // 
            this.konuMemoEdit.Location = new System.Drawing.Point(12, 32);
            this.konuMemoEdit.Name = "konuMemoEdit";
            this.konuMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.konuMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.konuMemoEdit.Properties.ReadOnly = true;
            this.konuMemoEdit.Size = new System.Drawing.Size(439, 33);
            this.konuMemoEdit.TabIndex = 0;
            // 
            // lblKonu
            // 
            this.lblKonu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKonu.Location = new System.Drawing.Point(12, 12);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(28, 13);
            this.lblKonu.TabIndex = 1;
            this.lblKonu.Text = "Konu";
            // 
            // mesajMemoEdit
            // 
            this.mesajMemoEdit.Location = new System.Drawing.Point(12, 90);
            this.mesajMemoEdit.Name = "mesajMemoEdit";
            this.mesajMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.mesajMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.mesajMemoEdit.Properties.MaxLength = 2500;
            this.mesajMemoEdit.Size = new System.Drawing.Size(439, 157);
            this.mesajMemoEdit.TabIndex = 0;
            // 
            // lblMesaj
            // 
            this.lblMesaj.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMesaj.Location = new System.Drawing.Point(12, 71);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(34, 13);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "Mesaj";
            // 
            // gonderButton
            // 
            this.gonderButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gonderButton.Appearance.Options.UseFont = true;
            this.gonderButton.Location = new System.Drawing.Point(352, 253);
            this.gonderButton.Name = "gonderButton";
            this.gonderButton.Size = new System.Drawing.Size(99, 30);
            this.gonderButton.TabIndex = 2;
            this.gonderButton.Text = "Gönder";
            this.gonderButton.Click += new System.EventHandler(this.gonderButton_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(13, 259);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(9, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "...";
            // 
            // xFrmGeriBildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 288);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gonderButton);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.mesajMemoEdit);
            this.Controls.Add(this.konuMemoEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(479, 324);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(479, 324);
            this.Name = "xFrmGeriBildirim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geri Bildirim";
            this.Load += new System.EventHandler(this.xFrmGeriBildirim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.konuMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit konuMemoEdit;
        private DevExpress.XtraEditors.LabelControl lblKonu;
        private DevExpress.XtraEditors.MemoEdit mesajMemoEdit;
        private DevExpress.XtraEditors.LabelControl lblMesaj;
        private DevExpress.XtraEditors.SimpleButton gonderButton;
        private DevExpress.XtraEditors.LabelControl lblStatus;

    }
}