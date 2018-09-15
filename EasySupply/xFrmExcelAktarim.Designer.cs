namespace EasySupply
{
    partial class xFrmExcelAktarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmExcelAktarim));
            this.excelUrunButton = new DevExpress.XtraEditors.SimpleButton();
            this.excelDovizTipiComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.excelKarOranCalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.turlerRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.loadProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.excelAktarimButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.excelDovizTipiComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelKarOranCalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadProgress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // excelUrunButton
            // 
            this.excelUrunButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.excelUrunButton.Appearance.Options.UseFont = true;
            this.excelUrunButton.Location = new System.Drawing.Point(192, 49);
            this.excelUrunButton.Name = "excelUrunButton";
            this.excelUrunButton.Size = new System.Drawing.Size(208, 23);
            this.excelUrunButton.TabIndex = 2;
            this.excelUrunButton.TabStop = false;
            this.excelUrunButton.Text = "Aktarılacak Dosya Seç!";
            this.excelUrunButton.Click += new System.EventHandler(this.excelUrunButton_Click);
            // 
            // excelDovizTipiComboBoxEdit
            // 
            this.excelDovizTipiComboBoxEdit.EditValue = "USD";
            this.excelDovizTipiComboBoxEdit.Location = new System.Drawing.Point(132, 51);
            this.excelDovizTipiComboBoxEdit.Name = "excelDovizTipiComboBoxEdit";
            this.excelDovizTipiComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.excelDovizTipiComboBoxEdit.Properties.Items.AddRange(new object[] {
            "TL",
            "USD",
            "EURO"});
            this.excelDovizTipiComboBoxEdit.Properties.MaxLength = 50;
            this.excelDovizTipiComboBoxEdit.Size = new System.Drawing.Size(54, 20);
            this.excelDovizTipiComboBoxEdit.TabIndex = 1;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl21.Location = new System.Drawing.Point(115, 54);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(13, 13);
            this.labelControl21.TabIndex = 18;
            this.labelControl21.Text = "%";
            // 
            // excelKarOranCalcEdit
            // 
            this.excelKarOranCalcEdit.AllowDrop = true;
            this.excelKarOranCalcEdit.Location = new System.Drawing.Point(12, 51);
            this.excelKarOranCalcEdit.Name = "excelKarOranCalcEdit";
            this.excelKarOranCalcEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.excelKarOranCalcEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.excelKarOranCalcEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.excelKarOranCalcEdit.Properties.Appearance.Options.UseBackColor = true;
            this.excelKarOranCalcEdit.Properties.Appearance.Options.UseFont = true;
            this.excelKarOranCalcEdit.Properties.Appearance.Options.UseForeColor = true;
            this.excelKarOranCalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.excelKarOranCalcEdit.Properties.DisplayFormat.FormatString = "% ##0 Kâr";
            this.excelKarOranCalcEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.excelKarOranCalcEdit.Properties.Precision = 2;
            this.excelKarOranCalcEdit.Size = new System.Drawing.Size(100, 20);
            this.excelKarOranCalcEdit.TabIndex = 0;
            this.excelKarOranCalcEdit.TabStop = false;
            this.excelKarOranCalcEdit.ToolTip = "Kâr oranı girilirken \"%5\" için \"0,05\" olarak girilmelidir!";
            this.excelKarOranCalcEdit.ToolTipTitle = "Kâr Oranı (Excel)";
            // 
            // turlerRadioGroup
            // 
            this.turlerRadioGroup.EditValue = ((byte)(1));
            this.turlerRadioGroup.Location = new System.Drawing.Point(12, 11);
            this.turlerRadioGroup.Name = "turlerRadioGroup";
            this.turlerRadioGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.turlerRadioGroup.Properties.Appearance.Options.UseFont = true;
            this.turlerRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(1)), "Teklifleri Birleştir!"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(2)), "Stok ID ile Aktar!"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(3)), "Değişiklikleri Algıla!")});
            this.turlerRadioGroup.Size = new System.Drawing.Size(418, 32);
            this.turlerRadioGroup.TabIndex = 4;
            this.turlerRadioGroup.SelectedIndexChanged += new System.EventHandler(this.turlerRadioGroup_SelectedIndexChanged);
            // 
            // loadProgress
            // 
            this.loadProgress.Location = new System.Drawing.Point(12, 78);
            this.loadProgress.Name = "loadProgress";
            this.loadProgress.Size = new System.Drawing.Size(418, 18);
            this.loadProgress.TabIndex = 4;
            // 
            // excelAktarimButton
            // 
            this.excelAktarimButton.Image = global::EasySupply.Properties.Resources.excellExport16x;
            this.excelAktarimButton.Location = new System.Drawing.Point(406, 49);
            this.excelAktarimButton.Name = "excelAktarimButton";
            this.excelAktarimButton.Size = new System.Drawing.Size(24, 23);
            superToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem1.Text = "Aktarım Dosyası Ne Yapar?";
            toolTipItem1.Appearance.Image = global::EasySupply.Properties.Resources.excellExport48x;
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.Image = global::EasySupply.Properties.Resources.excellExport48x;
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Standart <b>Excel Aktarım Kalıbı</b> kaybetmeniz durumunda geri alabilmeniz için " +
    "bu butona tıklayınız!\r\n\r\nBu işlemden sonra aktarım dosyanız bilgisayarınızın mas" +
    "aüstüne kaydedilecektir.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.excelAktarimButton.SuperTip = superToolTip1;
            this.excelAktarimButton.TabIndex = 3;
            this.excelAktarimButton.Click += new System.EventHandler(this.excelAktarimButton_Click);
            // 
            // xFrmExcelAktarim
            // 
            this.AcceptButton = this.excelUrunButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 106);
            this.Controls.Add(this.excelAktarimButton);
            this.Controls.Add(this.loadProgress);
            this.Controls.Add(this.turlerRadioGroup);
            this.Controls.Add(this.excelUrunButton);
            this.Controls.Add(this.excelDovizTipiComboBoxEdit);
            this.Controls.Add(this.labelControl21);
            this.Controls.Add(this.excelKarOranCalcEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(458, 142);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 140);
            this.Name = "xFrmExcelAktarim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Imports!";
            this.Load += new System.EventHandler(this.xFrmExcelAktarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.excelDovizTipiComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelKarOranCalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadProgress.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton excelUrunButton;
        private DevExpress.XtraEditors.ComboBoxEdit excelDovizTipiComboBoxEdit;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.CalcEdit excelKarOranCalcEdit;
        private DevExpress.XtraEditors.RadioGroup turlerRadioGroup;
        private DevExpress.XtraEditors.ProgressBarControl loadProgress;
        private DevExpress.XtraEditors.SimpleButton excelAktarimButton;
    }
}