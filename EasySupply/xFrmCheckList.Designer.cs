namespace EasySupply
{
    partial class xFrmCheckList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmCheckList));
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.DataListCheckhed = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.unCheckButton = new DevExpress.XtraEditors.SimpleButton();
            this.checkButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataListCheckhed)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.okButton.Appearance.Options.UseFont = true;
            this.okButton.Location = new System.Drawing.Point(119, 240);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 29);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Tamam";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Appearance.Options.UseFont = true;
            this.cancelButton.Location = new System.Drawing.Point(200, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 29);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Vazgeç";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DataListCheckhed
            // 
            this.DataListCheckhed.DisplayMember = "Value";
            this.DataListCheckhed.Location = new System.Drawing.Point(6, 6);
            this.DataListCheckhed.Name = "DataListCheckhed";
            this.DataListCheckhed.Size = new System.Drawing.Size(269, 228);
            this.DataListCheckhed.TabIndex = 6;
            this.DataListCheckhed.ValueMember = "ID";
            // 
            // unCheckButton
            // 
            this.unCheckButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.unCheckButton.Appearance.Options.UseFont = true;
            this.unCheckButton.Image = global::EasySupply.Properties.Resources.check_all_delete;
            this.unCheckButton.Location = new System.Drawing.Point(41, 240);
            this.unCheckButton.Name = "unCheckButton";
            this.unCheckButton.Size = new System.Drawing.Size(29, 29);
            this.unCheckButton.TabIndex = 7;
            this.unCheckButton.Click += new System.EventHandler(this.unCheckButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkButton.Appearance.Options.UseFont = true;
            this.checkButton.Image = global::EasySupply.Properties.Resources.check_all;
            this.checkButton.Location = new System.Drawing.Point(6, 240);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(29, 29);
            this.checkButton.TabIndex = 7;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // xFrmCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 276);
            this.Controls.Add(this.unCheckButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.DataListCheckhed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(290, 310);
            this.Name = "xFrmCheckList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkbox List";
            this.Load += new System.EventHandler(this.xFrmCheckList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListCheckhed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        public DevExpress.XtraEditors.CheckedListBoxControl DataListCheckhed;
        private DevExpress.XtraEditors.SimpleButton checkButton;
        private DevExpress.XtraEditors.SimpleButton unCheckButton;
    }
}