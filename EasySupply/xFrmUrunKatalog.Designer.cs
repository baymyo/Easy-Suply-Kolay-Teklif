namespace EasySupply
{
    partial class xFrmUrunKatalog
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmUrunKatalog));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urunKatalogGridControl = new DevExpress.XtraGrid.GridControl();
            this.urunKatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunKatalogGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategoriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKarOran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kriterGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.popupFilterModeComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.katalogTipiRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.urunTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKatalogGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKatalogGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kriterGroupControl)).BeginInit();
            this.kriterGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupFilterModeComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogTipiRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colAdet
            // 
            this.colAdet.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAdet.AppearanceCell.Options.UseFont = true;
            this.colAdet.AppearanceCell.Options.UseTextOptions = true;
            this.colAdet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdet.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAdet.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colAdet.AppearanceHeader.Options.UseFont = true;
            this.colAdet.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdet.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAdet.FieldName = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 1;
            this.colAdet.Width = 73;
            // 
            // colFiyat
            // 
            this.colFiyat.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colFiyat.AppearanceCell.Options.UseFont = true;
            this.colFiyat.AppearanceHeader.Options.UseTextOptions = true;
            this.colFiyat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colFiyat.Caption = "Alış Fiyat";
            this.colFiyat.DisplayFormat.FormatString = "###,###,##0.00 TL";
            this.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 6;
            this.colFiyat.Width = 87;
            // 
            // urunKatalogGridControl
            // 
            this.urunKatalogGridControl.DataSource = this.urunKatalogBindingSource;
            this.urunKatalogGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunKatalogGridControl.Location = new System.Drawing.Point(0, 59);
            this.urunKatalogGridControl.MainView = this.urunKatalogGridView;
            this.urunKatalogGridControl.Name = "urunKatalogGridControl";
            this.urunKatalogGridControl.Size = new System.Drawing.Size(1011, 605);
            this.urunKatalogGridControl.TabIndex = 0;
            this.urunKatalogGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.urunKatalogGridView});
            this.urunKatalogGridControl.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.urunKatalogGridControl_EditorKeyDown);
            // 
            // urunKatalogBindingSource
            // 
            this.urunKatalogBindingSource.DataSource = typeof(EasySupply.UrunKatalog);
            // 
            // urunKatalogGridView
            // 
            this.urunKatalogGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSiraNo,
            this.colKategoriAdi,
            this.colUrunAdi,
            this.colFirmaAdi,
            this.colTelefon,
            this.colMiktar,
            this.colBirim,
            this.colFiyat,
            this.colKarOran,
            this.colAdet,
            this.colTutar,
            this.colUpdated});
            this.urunKatalogGridView.CustomizationFormBounds = new System.Drawing.Rectangle(822, 817, 208, 177);
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colAdet;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "0";
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.colAdet;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition2.Value1 = "0";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Column = this.colFiyat;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition3.Expression = "[Updated] == True";
            this.urunKatalogGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.urunKatalogGridView.GridControl = this.urunKatalogGridControl;
            this.urunKatalogGridView.GroupCount = 1;
            this.urunKatalogGridView.Name = "urunKatalogGridView";
            this.urunKatalogGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.urunKatalogGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.urunKatalogGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKategoriAdi, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSiraNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.urunKatalogGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.urunKatalogGridView_CellValueChanged);
            // 
            // colSiraNo
            // 
            this.colSiraNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colSiraNo.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSiraNo.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colSiraNo.AppearanceCell.Options.UseBackColor = true;
            this.colSiraNo.AppearanceCell.Options.UseFont = true;
            this.colSiraNo.AppearanceCell.Options.UseForeColor = true;
            this.colSiraNo.Caption = "Sıra No";
            this.colSiraNo.FieldName = "SiraNo";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.OptionsColumn.AllowEdit = false;
            this.colSiraNo.OptionsColumn.AllowFocus = false;
            this.colSiraNo.OptionsColumn.AllowSize = false;
            this.colSiraNo.OptionsColumn.ReadOnly = true;
            this.colSiraNo.Visible = true;
            this.colSiraNo.VisibleIndex = 0;
            this.colSiraNo.Width = 71;
            // 
            // colKategoriAdi
            // 
            this.colKategoriAdi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colKategoriAdi.AppearanceHeader.Options.UseFont = true;
            this.colKategoriAdi.Caption = "Kategori";
            this.colKategoriAdi.FieldName = "KategoriAdi";
            this.colKategoriAdi.Name = "colKategoriAdi";
            this.colKategoriAdi.OptionsColumn.ReadOnly = true;
            this.colKategoriAdi.Width = 82;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUrunAdi.AppearanceCell.Options.UseFont = true;
            this.colUrunAdi.Caption = "Ürün";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.OptionsColumn.AllowFocus = false;
            this.colUrunAdi.OptionsColumn.ReadOnly = true;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 2;
            this.colUrunAdi.Width = 375;
            // 
            // colFirmaAdi
            // 
            this.colFirmaAdi.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colFirmaAdi.AppearanceCell.Options.UseFont = true;
            this.colFirmaAdi.Caption = "Firma";
            this.colFirmaAdi.FieldName = "FirmaAdi";
            this.colFirmaAdi.Name = "colFirmaAdi";
            this.colFirmaAdi.OptionsColumn.AllowEdit = false;
            this.colFirmaAdi.OptionsColumn.AllowFocus = false;
            this.colFirmaAdi.OptionsColumn.ReadOnly = true;
            this.colFirmaAdi.Visible = true;
            this.colFirmaAdi.VisibleIndex = 3;
            this.colFirmaAdi.Width = 177;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            // 
            // colMiktar
            // 
            this.colMiktar.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colMiktar.AppearanceCell.Options.UseFont = true;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.OptionsColumn.AllowFocus = false;
            this.colMiktar.OptionsColumn.AllowSize = false;
            this.colMiktar.OptionsColumn.ReadOnly = true;
            this.colMiktar.OptionsFilter.AllowAutoFilter = false;
            this.colMiktar.OptionsFilter.AllowFilter = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 4;
            this.colMiktar.Width = 47;
            // 
            // colBirim
            // 
            this.colBirim.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colBirim.AppearanceCell.Options.UseFont = true;
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.OptionsColumn.AllowFocus = false;
            this.colBirim.OptionsColumn.AllowSize = false;
            this.colBirim.OptionsColumn.ReadOnly = true;
            this.colBirim.OptionsFilter.AllowAutoFilter = false;
            this.colBirim.OptionsFilter.AllowFilter = false;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 5;
            this.colBirim.Width = 37;
            // 
            // colKarOran
            // 
            this.colKarOran.Caption = "Kar %";
            this.colKarOran.FieldName = "KarOran";
            this.colKarOran.Name = "colKarOran";
            this.colKarOran.OptionsColumn.AllowEdit = false;
            this.colKarOran.OptionsColumn.AllowFocus = false;
            this.colKarOran.OptionsColumn.AllowSize = false;
            this.colKarOran.OptionsColumn.ReadOnly = true;
            this.colKarOran.Width = 45;
            // 
            // colTutar
            // 
            this.colTutar.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTutar.AppearanceCell.Options.UseFont = true;
            this.colTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTutar.AppearanceHeader.Options.UseFont = true;
            this.colTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTutar.Caption = "Satış Fiyat";
            this.colTutar.DisplayFormat.FormatString = "###,###,##0.00";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.OptionsColumn.AllowFocus = false;
            this.colTutar.OptionsColumn.AllowSize = false;
            this.colTutar.OptionsColumn.ReadOnly = true;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 7;
            this.colTutar.Width = 99;
            // 
            // colUpdated
            // 
            this.colUpdated.FieldName = "Updated";
            this.colUpdated.Name = "colUpdated";
            // 
            // kriterGroupControl
            // 
            this.kriterGroupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kriterGroupControl.AppearanceCaption.Options.UseFont = true;
            this.kriterGroupControl.Controls.Add(this.popupFilterModeComboBox);
            this.kriterGroupControl.Controls.Add(this.katalogTipiRadioGroup);
            this.kriterGroupControl.Controls.Add(this.urunTextEdit);
            this.kriterGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kriterGroupControl.Location = new System.Drawing.Point(0, 0);
            this.kriterGroupControl.Name = "kriterGroupControl";
            this.kriterGroupControl.Size = new System.Drawing.Size(1011, 59);
            this.kriterGroupControl.TabIndex = 1;
            this.kriterGroupControl.Text = "Ürünleri Flitrele";
            // 
            // popupFilterModeComboBox
            // 
            this.popupFilterModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.popupFilterModeComboBox.EditValue = "STARTS WITH";
            this.popupFilterModeComboBox.Location = new System.Drawing.Point(635, 29);
            this.popupFilterModeComboBox.Name = "popupFilterModeComboBox";
            this.popupFilterModeComboBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.popupFilterModeComboBox.Properties.Appearance.Options.UseFont = true;
            this.popupFilterModeComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupFilterModeComboBox.Properties.Items.AddRange(new object[] {
            "CONTAINS",
            "STARTS WITH"});
            this.popupFilterModeComboBox.Size = new System.Drawing.Size(114, 23);
            this.popupFilterModeComboBox.TabIndex = 4;
            this.popupFilterModeComboBox.TabStop = false;
            this.popupFilterModeComboBox.ToolTip = "Arama yapılırken girilen kelimeler ile \"BAŞLAYAN\" yada \"İÇEREN\" olarak belirtebil" +
                "irsiniz. \"BAŞLAYAN\" kelimeler sol baştan itibaren girdiğiniz kayıtlar ile eşleme" +
                "si gerekmektedir.";
            this.popupFilterModeComboBox.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.popupFilterModeComboBox.ToolTipTitle = "Arama Kutusu";
            // 
            // katalogTipiRadioGroup
            // 
            this.katalogTipiRadioGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.katalogTipiRadioGroup.EditValue = "Ucuz";
            this.katalogTipiRadioGroup.Location = new System.Drawing.Point(754, 29);
            this.katalogTipiRadioGroup.Name = "katalogTipiRadioGroup";
            this.katalogTipiRadioGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.katalogTipiRadioGroup.Properties.Appearance.Options.UseFont = true;
            this.katalogTipiRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Hepsi", "Tüm Ürünler"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Ucuz", "En Ucuz Ürünler")});
            this.katalogTipiRadioGroup.Size = new System.Drawing.Size(252, 23);
            toolTipTitleItem1.Text = "Listedeki Ürünler";
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = resources.GetString("toolTipItem1.Text");
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.katalogTipiRadioGroup.SuperTip = superToolTip1;
            this.katalogTipiRadioGroup.TabIndex = 1;
            this.katalogTipiRadioGroup.EditValueChanged += new System.EventHandler(this.katalogTipiRadioGroup_EditValueChanged);
            // 
            // urunTextEdit
            // 
            this.urunTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.urunTextEdit.Location = new System.Drawing.Point(12, 29);
            this.urunTextEdit.Name = "urunTextEdit";
            this.urunTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.urunTextEdit.Properties.Appearance.Options.UseFont = true;
            this.urunTextEdit.Size = new System.Drawing.Size(621, 23);
            superToolTip2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem2.Text = "Ürün Arama Kutusu";
            toolTipItem2.Appearance.Options.UseImage = true;
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = resources.GetString("toolTipItem2.Text");
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.urunTextEdit.SuperTip = superToolTip2;
            this.urunTextEdit.TabIndex = 0;
            this.urunTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.urunTextEdit_EditValueChanging);
            // 
            // xFrmUrunKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 664);
            this.Controls.Add(this.urunKatalogGridControl);
            this.Controls.Add(this.kriterGroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xFrmUrunKatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Katalog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xFrmUrunKatalog_FormClosing);
            this.Load += new System.EventHandler(this.xFrmUrunKatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunKatalogGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunKatalogGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kriterGroupControl)).EndInit();
            this.kriterGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupFilterModeComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogTipiRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl urunKatalogGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView urunKatalogGridView;
        private DevExpress.XtraEditors.GroupControl kriterGroupControl;
        private DevExpress.XtraEditors.TextEdit urunTextEdit;
        private DevExpress.XtraEditors.RadioGroup katalogTipiRadioGroup;
        private System.Windows.Forms.BindingSource urunKatalogBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colKategoriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colKarOran;
        private DevExpress.XtraGrid.Columns.GridColumn colSiraNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated;
        private DevExpress.XtraEditors.ComboBoxEdit popupFilterModeComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
    }
}