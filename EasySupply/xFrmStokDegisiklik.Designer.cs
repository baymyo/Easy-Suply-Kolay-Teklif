namespace EasySupply
{
    partial class xFrmStokDegisiklik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmStokDegisiklik));
            this.infoLabel = new DevExpress.XtraEditors.LabelControl();
            this.onaylaButton = new DevExpress.XtraEditors.SimpleButton();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vazgecButton = new DevExpress.XtraEditors.SimpleButton();
            this.rpsFirmaLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rpsUrunLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rpsKategoriLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.stokGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategoriID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKarOran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGuncellemeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stokGridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsFirmaLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsUrunLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsKategoriLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Appearance.BackColor = System.Drawing.Color.Red;
            this.infoLabel.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.infoLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.infoLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.infoLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.infoLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Padding = new System.Windows.Forms.Padding(10);
            this.infoLabel.Size = new System.Drawing.Size(999, 30);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "- - -";
            // 
            // onaylaButton
            // 
            this.onaylaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.onaylaButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.onaylaButton.Appearance.Options.UseFont = true;
            this.onaylaButton.Location = new System.Drawing.Point(733, 514);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(124, 30);
            this.onaylaButton.TabIndex = 7;
            this.onaylaButton.Text = "TAMAM";
            this.onaylaButton.Click += new System.EventHandler(this.onaylaButton_Click);
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataSource = typeof(EasySupply.Stok);
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataSource = typeof(EasySupply.Kategori);
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(EasySupply.Urun);
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataSource = typeof(EasySupply.Firma);
            // 
            // vazgecButton
            // 
            this.vazgecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vazgecButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vazgecButton.Appearance.Options.UseFont = true;
            this.vazgecButton.Location = new System.Drawing.Point(863, 514);
            this.vazgecButton.Name = "vazgecButton";
            this.vazgecButton.Size = new System.Drawing.Size(124, 30);
            this.vazgecButton.TabIndex = 6;
            this.vazgecButton.Text = "VAZGEÇ";
            this.vazgecButton.Click += new System.EventHandler(this.vazgecButton_Click);
            // 
            // rpsFirmaLookUpEdit
            // 
            this.rpsFirmaLookUpEdit.AutoHeight = false;
            this.rpsFirmaLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsFirmaLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kod", global::EasySupply.L.Kod, 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Adi", global::EasySupply.L.Adi, 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Yetkili", global::EasySupply.L.Yetkili, 125, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Telefon", global::EasySupply.L.Telefon, 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mail", "Mail", 140, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Adres", global::EasySupply.L.Adres, 110, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Period", global::EasySupply.L.Period, 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.rpsFirmaLookUpEdit.DisplayMember = "Adi";
            this.rpsFirmaLookUpEdit.Name = "rpsFirmaLookUpEdit";
            this.rpsFirmaLookUpEdit.NullText = "[...]";
            this.rpsFirmaLookUpEdit.ValueMember = "ID";
            // 
            // rpsUrunLookUpEdit
            // 
            this.rpsUrunLookUpEdit.AutoHeight = false;
            this.rpsUrunLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsUrunLookUpEdit.DataSource = this.urunBindingSource;
            this.rpsUrunLookUpEdit.DisplayMember = "Adi";
            this.rpsUrunLookUpEdit.Name = "rpsUrunLookUpEdit";
            this.rpsUrunLookUpEdit.NullText = "[...]";
            this.rpsUrunLookUpEdit.ValueMember = "ID";
            // 
            // rpsKategoriLookUpEdit
            // 
            this.rpsKategoriLookUpEdit.AutoHeight = false;
            this.rpsKategoriLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsKategoriLookUpEdit.DataSource = this.kategoriBindingSource;
            this.rpsKategoriLookUpEdit.DisplayMember = "Adi";
            this.rpsKategoriLookUpEdit.Name = "rpsKategoriLookUpEdit";
            this.rpsKategoriLookUpEdit.NullText = "[...]";
            this.rpsKategoriLookUpEdit.ValueMember = "ID";
            // 
            // stokGridView
            // 
            this.stokGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.stokGridView.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.stokGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.stokGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.stokGridView.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.stokGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.stokGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.stokGridView.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.stokGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.stokGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKategoriID,
            this.colUrunID,
            this.colFiyat,
            this.colKarOran,
            this.colTutar,
            this.colGuncellemeTarihi,
            this.colChanged});
            this.stokGridView.CustomizationFormBounds = new System.Drawing.Rectangle(837, 559, 208, 170);
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Green;
            styleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseBorderColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colChanged;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.stokGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.stokGridView.GridControl = this.stokGridControl;
            this.stokGridView.GroupCount = 1;
            this.stokGridView.GroupPanelText = "Gruplama yapmak istediğiniz alanı buraya sürükleyip bırakınız";
            this.stokGridView.Name = "stokGridView";
            this.stokGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.stokGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.stokGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.stokGridView.OptionsView.ShowGroupPanel = false;
            this.stokGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKategoriID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceCell.Options.UseFont = true;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.Caption = "S. ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Width = 65;
            // 
            // colKategoriID
            // 
            this.colKategoriID.Caption = "Kategori";
            this.colKategoriID.ColumnEdit = this.rpsKategoriLookUpEdit;
            this.colKategoriID.FieldName = "KategoriID";
            this.colKategoriID.Name = "colKategoriID";
            this.colKategoriID.OptionsColumn.AllowEdit = false;
            this.colKategoriID.OptionsColumn.AllowFocus = false;
            this.colKategoriID.Visible = true;
            this.colKategoriID.VisibleIndex = 5;
            this.colKategoriID.Width = 105;
            // 
            // colUrunID
            // 
            this.colUrunID.Caption = "Ürün Açıklama";
            this.colUrunID.ColumnEdit = this.rpsUrunLookUpEdit;
            this.colUrunID.FieldName = "UrunID";
            this.colUrunID.Name = "colUrunID";
            this.colUrunID.OptionsColumn.AllowEdit = false;
            this.colUrunID.OptionsColumn.AllowFocus = false;
            this.colUrunID.Visible = true;
            this.colUrunID.VisibleIndex = 0;
            this.colUrunID.Width = 529;
            // 
            // colFiyat
            // 
            this.colFiyat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFiyat.AppearanceCell.Options.UseFont = true;
            this.colFiyat.Caption = "Alış Fiyat";
            this.colFiyat.DisplayFormat.FormatString = "###,###,##0.00 TL";
            this.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.OptionsColumn.AllowSize = false;
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 1;
            this.colFiyat.Width = 126;
            // 
            // colKarOran
            // 
            this.colKarOran.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colKarOran.AppearanceCell.Options.UseFont = true;
            this.colKarOran.DisplayFormat.FormatString = "% ##0";
            this.colKarOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colKarOran.FieldName = "KarOran";
            this.colKarOran.Name = "colKarOran";
            this.colKarOran.OptionsColumn.AllowSize = false;
            this.colKarOran.Visible = true;
            this.colKarOran.VisibleIndex = 2;
            this.colKarOran.Width = 126;
            // 
            // colTutar
            // 
            this.colTutar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTutar.AppearanceCell.Options.UseFont = true;
            this.colTutar.Caption = "Satış Fiyat";
            this.colTutar.DisplayFormat.FormatString = "###,###,##0.00 TL";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.OptionsColumn.AllowFocus = false;
            this.colTutar.OptionsColumn.AllowSize = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            this.colTutar.Width = 135;
            // 
            // colGuncellemeTarihi
            // 
            this.colGuncellemeTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colGuncellemeTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGuncellemeTarihi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGuncellemeTarihi.FieldName = "GuncellemeTarihi";
            this.colGuncellemeTarihi.Name = "colGuncellemeTarihi";
            this.colGuncellemeTarihi.OptionsColumn.AllowEdit = false;
            this.colGuncellemeTarihi.OptionsColumn.AllowFocus = false;
            this.colGuncellemeTarihi.OptionsColumn.AllowSize = false;
            this.colGuncellemeTarihi.Width = 91;
            // 
            // colChanged
            // 
            this.colChanged.FieldName = "Changed";
            this.colChanged.Name = "colChanged";
            // 
            // stokGridControl
            // 
            this.stokGridControl.DataSource = this.stokBindingSource;
            this.stokGridControl.Location = new System.Drawing.Point(0, 30);
            this.stokGridControl.MainView = this.stokGridView;
            this.stokGridControl.Name = "stokGridControl";
            this.stokGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpsFirmaLookUpEdit,
            this.rpsUrunLookUpEdit,
            this.rpsKategoriLookUpEdit});
            this.stokGridControl.Size = new System.Drawing.Size(999, 478);
            this.stokGridControl.TabIndex = 9;
            this.stokGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.stokGridView});
            this.stokGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stokGridControl_KeyDown);
            // 
            // xFrmStokDegisiklik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 556);
            this.Controls.Add(this.stokGridControl);
            this.Controls.Add(this.onaylaButton);
            this.Controls.Add(this.vazgecButton);
            this.Controls.Add(this.infoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xFrmStokDegisiklik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Bazında Stokda Değişiklik";
            this.Load += new System.EventHandler(this.xFrmStokDegisiklik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsFirmaLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsUrunLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsKategoriLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl infoLabel;
        private DevExpress.XtraEditors.SimpleButton onaylaButton;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private DevExpress.XtraEditors.SimpleButton vazgecButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rpsFirmaLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rpsUrunLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rpsKategoriLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView stokGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKategoriID;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunID;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colKarOran;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colGuncellemeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colChanged;
        private DevExpress.XtraGrid.GridControl stokGridControl;
    }
}