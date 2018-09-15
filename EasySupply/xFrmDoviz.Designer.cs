namespace EasySupply
{
    partial class xFrmDoviz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmDoviz));
            this.kaydetButton = new DevExpress.XtraEditors.SimpleButton();
            this.kur1CalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.kur1CodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.kur2CalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.kur2CodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.dovizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kur1DescLabel = new DevExpress.XtraEditors.LabelControl();
            this.kur2DescLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.kur1CalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kur2CalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kaydetButton
            // 
            this.kaydetButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kaydetButton.Appearance.Options.UseFont = true;
            this.kaydetButton.Location = new System.Drawing.Point(58, 105);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(124, 26);
            this.kaydetButton.TabIndex = 0;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // kur1CalcEdit
            // 
            this.kur1CalcEdit.Location = new System.Drawing.Point(58, 12);
            this.kur1CalcEdit.Name = "kur1CalcEdit";
            this.kur1CalcEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kur1CalcEdit.Properties.Appearance.Options.UseFont = true;
            this.kur1CalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kur1CalcEdit.Properties.DisplayFormat.FormatString = "##0.0000";
            this.kur1CalcEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.kur1CalcEdit.Properties.EditFormat.FormatString = "##0.0000";
            this.kur1CalcEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.kur1CalcEdit.Size = new System.Drawing.Size(124, 20);
            this.kur1CalcEdit.TabIndex = 1;
            this.kur1CalcEdit.Tag = "";
            // 
            // kur1CodeLabel
            // 
            this.kur1CodeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kur1CodeLabel.Location = new System.Drawing.Point(16, 15);
            this.kur1CodeLabel.Name = "kur1CodeLabel";
            this.kur1CodeLabel.Size = new System.Drawing.Size(23, 13);
            this.kur1CodeLabel.TabIndex = 2;
            this.kur1CodeLabel.Tag = "USD";
            this.kur1CodeLabel.Text = "USD";
            // 
            // kur2CalcEdit
            // 
            this.kur2CalcEdit.Location = new System.Drawing.Point(58, 57);
            this.kur2CalcEdit.Name = "kur2CalcEdit";
            this.kur2CalcEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kur2CalcEdit.Properties.Appearance.Options.UseFont = true;
            this.kur2CalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kur2CalcEdit.Properties.DisplayFormat.FormatString = "##0.0000";
            this.kur2CalcEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.kur2CalcEdit.Properties.EditFormat.FormatString = "##0.0000";
            this.kur2CalcEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.kur2CalcEdit.Size = new System.Drawing.Size(124, 20);
            this.kur2CalcEdit.TabIndex = 1;
            this.kur2CalcEdit.Tag = "";
            // 
            // kur2CodeLabel
            // 
            this.kur2CodeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kur2CodeLabel.Location = new System.Drawing.Point(16, 60);
            this.kur2CodeLabel.Name = "kur2CodeLabel";
            this.kur2CodeLabel.Size = new System.Drawing.Size(22, 13);
            this.kur2CodeLabel.TabIndex = 2;
            this.kur2CodeLabel.Tag = "EUR";
            this.kur2CodeLabel.Text = "EUR";
            // 
            // dovizBindingSource
            // 
            this.dovizBindingSource.DataSource = typeof(EasySupply.Doviz);
            // 
            // kur1DescLabel
            // 
            this.kur1DescLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.kur1DescLabel.Location = new System.Drawing.Point(62, 35);
            this.kur1DescLabel.Name = "kur1DescLabel";
            this.kur1DescLabel.Size = new System.Drawing.Size(95, 13);
            this.kur1DescLabel.TabIndex = 2;
            this.kur1DescLabel.Tag = "EUR";
            this.kur1DescLabel.Text = "AMERİKAN DOLARI";
            // 
            // kur2DescLabel
            // 
            this.kur2DescLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.kur2DescLabel.Location = new System.Drawing.Point(62, 80);
            this.kur2DescLabel.Name = "kur2DescLabel";
            this.kur2DescLabel.Size = new System.Drawing.Size(82, 13);
            this.kur2DescLabel.TabIndex = 2;
            this.kur2DescLabel.Tag = "EUR";
            this.kur2DescLabel.Text = "AVRUPA BİRLİĞİ";
            // 
            // xFrmDoviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 143);
            this.Controls.Add(this.kur2DescLabel);
            this.Controls.Add(this.kur1DescLabel);
            this.Controls.Add(this.kur2CodeLabel);
            this.Controls.Add(this.kur1CodeLabel);
            this.Controls.Add(this.kur2CalcEdit);
            this.Controls.Add(this.kur1CalcEdit);
            this.Controls.Add(this.kaydetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "xFrmDoviz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doviz Kurları";
            this.Load += new System.EventHandler(this.xFrmDoviz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kur1CalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kur2CalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dovizBindingSource;
        private DevExpress.XtraEditors.SimpleButton kaydetButton;
        private DevExpress.XtraEditors.CalcEdit kur1CalcEdit;
        private DevExpress.XtraEditors.LabelControl kur1CodeLabel;
        private DevExpress.XtraEditors.CalcEdit kur2CalcEdit;
        private DevExpress.XtraEditors.LabelControl kur2CodeLabel;
        private DevExpress.XtraEditors.LabelControl kur1DescLabel;
        private DevExpress.XtraEditors.LabelControl kur2DescLabel;
    }
}