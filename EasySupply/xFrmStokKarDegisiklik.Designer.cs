namespace EasySupply
{
    partial class xFrmStokKarDegisiklik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmStokKarDegisiklik));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.karOranCalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.lblBirimKarOrani = new DevExpress.XtraEditors.LabelControl();
            this.firmaLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTedarikciFirma = new DevExpress.XtraEditors.LabelControl();
            this.lblKategori = new DevExpress.XtraEditors.LabelControl();
            this.guncelleButton = new DevExpress.XtraEditors.SimpleButton();
            this.karOraniFilitreRadioGrup = new DevExpress.XtraEditors.RadioGroup();
            this.vazgecButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.karOranCalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karOraniFilitreRadioGrup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // karOranCalcEdit
            // 
            this.karOranCalcEdit.EditValue = new decimal(new int[] {
            45,
            0,
            0,
            131072});
            this.karOranCalcEdit.Location = new System.Drawing.Point(278, 103);
            this.karOranCalcEdit.Name = "karOranCalcEdit";
            this.karOranCalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.karOranCalcEdit.Properties.DisplayFormat.FormatString = "% ##0";
            this.karOranCalcEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.karOranCalcEdit.Properties.EditFormat.FormatString = "##0.00";
            this.karOranCalcEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.karOranCalcEdit.Size = new System.Drawing.Size(75, 20);
            this.karOranCalcEdit.TabIndex = 2;
            // 
            // lblBirimKarOrani
            // 
            this.lblBirimKarOrani.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBirimKarOrani.Location = new System.Drawing.Point(15, 106);
            this.lblBirimKarOrani.Name = "lblBirimKarOrani";
            this.lblBirimKarOrani.Size = new System.Drawing.Size(116, 13);
            this.lblBirimKarOrani.TabIndex = 8;
            this.lblBirimKarOrani.Text = "Yeni Kâr Oranı (0,00)";
            // 
            // firmaLookUpEdit
            // 
            this.firmaLookUpEdit.Location = new System.Drawing.Point(12, 75);
            this.firmaLookUpEdit.Name = "firmaLookUpEdit";
            this.firmaLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("firmaLookUpEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.firmaLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kod", global::EasySupply.L.Kod, 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Adi", global::EasySupply.L.Adi, 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Yetkili", global::EasySupply.L.Yetkili, 125, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Telefon", global::EasySupply.L.Telefon, 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mail", "Mail", 140, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Adres", global::EasySupply.L.Adres, 110, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Period", global::EasySupply.L.Period, 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.firmaLookUpEdit.Properties.DataSource = this.firmaBindingSource;
            this.firmaLookUpEdit.Properties.DisplayMember = "Adi";
            this.firmaLookUpEdit.Properties.NullText = "[...]";
            this.firmaLookUpEdit.Properties.PopupWidth = 620;
            this.firmaLookUpEdit.Properties.ValueMember = "ID";
            this.firmaLookUpEdit.Size = new System.Drawing.Size(341, 20);
            this.firmaLookUpEdit.TabIndex = 1;
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataSource = typeof(EasySupply.Firma);
            // 
            // kategoriLookUpEdit
            // 
            this.kategoriLookUpEdit.Location = new System.Drawing.Point(12, 30);
            this.kategoriLookUpEdit.Name = "kategoriLookUpEdit";
            this.kategoriLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kategoriLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kod", global::EasySupply.L.Kod, 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Adi", global::EasySupply.L.Adi, 238, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.kategoriLookUpEdit.Properties.DataSource = this.kategoriBindingSource;
            this.kategoriLookUpEdit.Properties.DisplayMember = "Adi";
            this.kategoriLookUpEdit.Properties.NullText = "[...]";
            this.kategoriLookUpEdit.Properties.PopupWidth = 268;
            this.kategoriLookUpEdit.Properties.ValueMember = "ID";
            this.kategoriLookUpEdit.Size = new System.Drawing.Size(341, 20);
            this.kategoriLookUpEdit.TabIndex = 0;
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataSource = typeof(EasySupply.Kategori);
            // 
            // lblTedarikciFirma
            // 
            this.lblTedarikciFirma.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTedarikciFirma.Location = new System.Drawing.Point(15, 56);
            this.lblTedarikciFirma.Name = "lblTedarikciFirma";
            this.lblTedarikciFirma.Size = new System.Drawing.Size(87, 13);
            this.lblTedarikciFirma.TabIndex = 7;
            this.lblTedarikciFirma.Text = "Tedarikçi Firma";
            // 
            // lblKategori
            // 
            this.lblKategori.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKategori.Location = new System.Drawing.Point(15, 11);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(48, 13);
            this.lblKategori.TabIndex = 6;
            this.lblKategori.Text = "Kategori";
            // 
            // guncelleButton
            // 
            this.guncelleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.guncelleButton.Appearance.Options.UseFont = true;
            this.guncelleButton.Location = new System.Drawing.Point(188, 271);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(84, 29);
            this.guncelleButton.TabIndex = 4;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // karOraniFilitreRadioGrup
            // 
            this.karOraniFilitreRadioGrup.EditValue = ((byte)(0));
            this.karOraniFilitreRadioGrup.Location = new System.Drawing.Point(12, 137);
            this.karOraniFilitreRadioGrup.Name = "karOraniFilitreRadioGrup";
            this.karOraniFilitreRadioGrup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.karOraniFilitreRadioGrup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.karOraniFilitreRadioGrup.Properties.Appearance.Options.UseBackColor = true;
            this.karOraniFilitreRadioGrup.Properties.Appearance.Options.UseFont = true;
            this.karOraniFilitreRadioGrup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(1)), global::EasySupply.L.KarOraniSecileneUygula),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(2)), global::EasySupply.L.KarOraniSecilenDisindakilereUygula),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(3)), global::EasySupply.L.KarOraniKategoriDisindakilere),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(4)), global::EasySupply.L.KarOraniFirmaDisindakilere),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(0)), global::EasySupply.L.KarOraniTumuneUygula)});
            this.karOraniFilitreRadioGrup.Size = new System.Drawing.Size(341, 128);
            toolTipTitleItem1.Appearance.Image = global::EasySupply.Properties.Resources.question16x;
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = global::EasySupply.Properties.Resources.question16x;
            toolTipTitleItem1.Text = "Filitreleme Yaparak Değiştir";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Belirleyeceğiniz filitreleme seçeneğine göre kâr oranı değişikliği sağlanmaktadır" +
    ".\r\n\r\nÖrnek: Sadece belirteceğiniz kategorilerin tümününe yada haricindekilere uy" +
    "gulayabilirsiniz.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.karOraniFilitreRadioGrup.SuperTip = superToolTip1;
            this.karOraniFilitreRadioGrup.TabIndex = 3;
            // 
            // vazgecButton
            // 
            this.vazgecButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vazgecButton.Appearance.Options.UseFont = true;
            this.vazgecButton.Location = new System.Drawing.Point(278, 271);
            this.vazgecButton.Name = "vazgecButton";
            this.vazgecButton.Size = new System.Drawing.Size(75, 29);
            this.vazgecButton.TabIndex = 5;
            this.vazgecButton.Text = "Vazgeç";
            this.vazgecButton.Click += new System.EventHandler(this.vazgecButton_Click);
            // 
            // xFrmStokKarDegisiklik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 312);
            this.Controls.Add(this.vazgecButton);
            this.Controls.Add(this.karOraniFilitreRadioGrup);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.firmaLookUpEdit);
            this.Controls.Add(this.kategoriLookUpEdit);
            this.Controls.Add(this.lblTedarikciFirma);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.karOranCalcEdit);
            this.Controls.Add(this.lblBirimKarOrani);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 350);
            this.Name = "xFrmStokKarDegisiklik";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kâr Oranı Belirle";
            this.Load += new System.EventHandler(this.xFrmStokKarDegisiklik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.karOranCalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karOraniFilitreRadioGrup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CalcEdit karOranCalcEdit;
        private DevExpress.XtraEditors.LabelControl lblBirimKarOrani;
        private DevExpress.XtraEditors.LookUpEdit firmaLookUpEdit;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private DevExpress.XtraEditors.LookUpEdit kategoriLookUpEdit;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private DevExpress.XtraEditors.LabelControl lblTedarikciFirma;
        private DevExpress.XtraEditors.LabelControl lblKategori;
        private DevExpress.XtraEditors.SimpleButton guncelleButton;
        private DevExpress.XtraEditors.RadioGroup karOraniFilitreRadioGrup;
        private DevExpress.XtraEditors.SimpleButton vazgecButton;
    }
}