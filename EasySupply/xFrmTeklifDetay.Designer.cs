namespace EasySupply
{
    partial class xFrmTeklifDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmTeklifDetay));
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teklifGridControl = new DevExpress.XtraGrid.GridControl();
            this.teklifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teklifGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGemiAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaglamaLimani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTasimaUcreti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHazirlayan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumNotu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsDurumNotuMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.filterGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.lblIptal = new DevExpress.XtraEditors.LabelControl();
            this.lblOnaylandi = new DevExpress.XtraEditors.LabelControl();
            this.lblBekliyor = new DevExpress.XtraEditors.LabelControl();
            this.suzButton = new DevExpress.XtraEditors.SimpleButton();
            this.gemiAdiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sonTarihDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.lblGemiAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblSonTarih = new DevExpress.XtraEditors.LabelControl();
            this.ilkTarihDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.lblIlkTarih = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teklifGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDurumNotuMemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterGroupControl)).BeginInit();
            this.filterGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gemiAdiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonTarihDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonTarihDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkTarihDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkTarihDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            // 
            // teklifGridControl
            // 
            this.teklifGridControl.DataSource = this.teklifBindingSource;
            this.teklifGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teklifGridControl.Location = new System.Drawing.Point(0, 60);
            this.teklifGridControl.MainView = this.teklifGridView;
            this.teklifGridControl.Name = "teklifGridControl";
            this.teklifGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpsDurumNotuMemoExEdit});
            this.teklifGridControl.Size = new System.Drawing.Size(1110, 411);
            this.teklifGridControl.TabIndex = 0;
            this.teklifGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.teklifGridView});
            // 
            // teklifBindingSource
            // 
            this.teklifBindingSource.DataSource = typeof(EasySupply.Teklif);
            // 
            // teklifGridView
            // 
            this.teklifGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colGemiAdi,
            this.colBaglamaLimani,
            this.colAcenta,
            this.colManager,
            this.colTarih,
            this.colParaBirimi,
            this.colTasimaUcreti,
            this.colHazirlayan,
            this.colDurum,
            this.colDurumNotu});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LavenderBlush;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Pink;
            styleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.Pink;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseBorderColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colDurum;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "4";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Azure;
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.LightBlue;
            styleFormatCondition2.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            styleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseBorderColor = true;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colDurum;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "3";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.LightYellow;
            styleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.PaleGoldenrod;
            styleFormatCondition3.Appearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Chocolate;
            styleFormatCondition3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseBorderColor = true;
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colDurum;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = "2";
            this.teklifGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.teklifGridView.GridControl = this.teklifGridControl;
            this.teklifGridView.Name = "teklifGridView";
            this.teklifGridView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.teklifGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.teklifGridView.OptionsView.ShowGroupPanel = false;
            this.teklifGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTarih, DevExpress.Data.ColumnSortOrder.Descending)});
            this.teklifGridView.DoubleClick += new System.EventHandler(this.teklifGridView_DoubleClick);
            // 
            // colID
            // 
            this.colID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceCell.Options.UseFont = true;
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "Referans No";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.AllowSize = false;
            this.colID.OptionsFilter.AllowAutoFilter = false;
            this.colID.OptionsFilter.AllowFilter = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 77;
            // 
            // colGemiAdi
            // 
            this.colGemiAdi.FieldName = "GemiAdi";
            this.colGemiAdi.Name = "colGemiAdi";
            this.colGemiAdi.OptionsColumn.AllowEdit = false;
            this.colGemiAdi.OptionsColumn.AllowFocus = false;
            this.colGemiAdi.Visible = true;
            this.colGemiAdi.VisibleIndex = 2;
            this.colGemiAdi.Width = 256;
            // 
            // colBaglamaLimani
            // 
            this.colBaglamaLimani.FieldName = "BaglamaLimani";
            this.colBaglamaLimani.Name = "colBaglamaLimani";
            this.colBaglamaLimani.OptionsColumn.AllowEdit = false;
            this.colBaglamaLimani.OptionsColumn.AllowFocus = false;
            this.colBaglamaLimani.OptionsColumn.AllowSize = false;
            this.colBaglamaLimani.Visible = true;
            this.colBaglamaLimani.VisibleIndex = 3;
            this.colBaglamaLimani.Width = 177;
            // 
            // colAcenta
            // 
            this.colAcenta.FieldName = "Acenta";
            this.colAcenta.Name = "colAcenta";
            this.colAcenta.OptionsColumn.AllowEdit = false;
            this.colAcenta.OptionsColumn.AllowFocus = false;
            this.colAcenta.Visible = true;
            this.colAcenta.VisibleIndex = 4;
            this.colAcenta.Width = 145;
            // 
            // colManager
            // 
            this.colManager.FieldName = "Manager";
            this.colManager.Name = "colManager";
            this.colManager.OptionsColumn.AllowEdit = false;
            this.colManager.OptionsColumn.AllowFocus = false;
            this.colManager.Visible = true;
            this.colManager.VisibleIndex = 5;
            this.colManager.Width = 145;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.AllowFocus = false;
            this.colTarih.OptionsColumn.AllowSize = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 7;
            this.colTarih.Width = 84;
            // 
            // colParaBirimi
            // 
            this.colParaBirimi.FieldName = "ParaBirimi";
            this.colParaBirimi.Name = "colParaBirimi";
            // 
            // colTasimaUcreti
            // 
            this.colTasimaUcreti.FieldName = "TasimaUcreti";
            this.colTasimaUcreti.Name = "colTasimaUcreti";
            // 
            // colHazirlayan
            // 
            this.colHazirlayan.FieldName = "Hazirlayan";
            this.colHazirlayan.Name = "colHazirlayan";
            this.colHazirlayan.OptionsColumn.AllowEdit = false;
            this.colHazirlayan.OptionsColumn.AllowFocus = false;
            this.colHazirlayan.OptionsColumn.AllowSize = false;
            this.colHazirlayan.Visible = true;
            this.colHazirlayan.VisibleIndex = 6;
            this.colHazirlayan.Width = 158;
            // 
            // colDurumNotu
            // 
            this.colDurumNotu.AppearanceHeader.Options.UseTextOptions = true;
            this.colDurumNotu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDurumNotu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDurumNotu.Caption = "Not";
            this.colDurumNotu.ColumnEdit = this.rpsDurumNotuMemoExEdit;
            this.colDurumNotu.FieldName = "DurumNotu";
            this.colDurumNotu.Name = "colDurumNotu";
            this.colDurumNotu.OptionsColumn.ReadOnly = true;
            this.colDurumNotu.OptionsFilter.AllowFilter = false;
            this.colDurumNotu.Visible = true;
            this.colDurumNotu.VisibleIndex = 1;
            this.colDurumNotu.Width = 50;
            // 
            // rpsDurumNotuMemoExEdit
            // 
            this.rpsDurumNotuMemoExEdit.AutoHeight = false;
            this.rpsDurumNotuMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsDurumNotuMemoExEdit.Name = "rpsDurumNotuMemoExEdit";
            // 
            // filterGroupControl
            // 
            this.filterGroupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.filterGroupControl.AppearanceCaption.Options.UseFont = true;
            this.filterGroupControl.Controls.Add(this.lblIptal);
            this.filterGroupControl.Controls.Add(this.lblOnaylandi);
            this.filterGroupControl.Controls.Add(this.lblBekliyor);
            this.filterGroupControl.Controls.Add(this.suzButton);
            this.filterGroupControl.Controls.Add(this.gemiAdiTextEdit);
            this.filterGroupControl.Controls.Add(this.sonTarihDateEdit);
            this.filterGroupControl.Controls.Add(this.lblGemiAdi);
            this.filterGroupControl.Controls.Add(this.lblSonTarih);
            this.filterGroupControl.Controls.Add(this.ilkTarihDateEdit);
            this.filterGroupControl.Controls.Add(this.lblIlkTarih);
            this.filterGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterGroupControl.Location = new System.Drawing.Point(0, 0);
            this.filterGroupControl.Name = "filterGroupControl";
            this.filterGroupControl.Size = new System.Drawing.Size(1110, 60);
            this.filterGroupControl.TabIndex = 1;
            this.filterGroupControl.Text = "Arşiv\'deki Bilgileri Süz";
            // 
            // lblIptal
            // 
            this.lblIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIptal.Appearance.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblIptal.Appearance.BackColor2 = System.Drawing.Color.Pink;
            this.lblIptal.Appearance.BorderColor = System.Drawing.Color.Pink;
            this.lblIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblIptal.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIptal.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblIptal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblIptal.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblIptal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblIptal.Location = new System.Drawing.Point(1024, 29);
            this.lblIptal.Name = "lblIptal";
            this.lblIptal.Size = new System.Drawing.Size(80, 22);
            this.lblIptal.TabIndex = 4;
            this.lblIptal.Text = "İPTAL";
            // 
            // lblOnaylandi
            // 
            this.lblOnaylandi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOnaylandi.Appearance.BackColor = System.Drawing.Color.Azure;
            this.lblOnaylandi.Appearance.BackColor2 = System.Drawing.Color.LightBlue;
            this.lblOnaylandi.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.lblOnaylandi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOnaylandi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOnaylandi.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblOnaylandi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblOnaylandi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblOnaylandi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOnaylandi.Location = new System.Drawing.Point(942, 29);
            this.lblOnaylandi.Name = "lblOnaylandi";
            this.lblOnaylandi.Size = new System.Drawing.Size(80, 22);
            this.lblOnaylandi.TabIndex = 4;
            this.lblOnaylandi.Text = "ONAYLANDI";
            // 
            // lblBekliyor
            // 
            this.lblBekliyor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBekliyor.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.lblBekliyor.Appearance.BackColor2 = System.Drawing.Color.PaleGoldenrod;
            this.lblBekliyor.Appearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.lblBekliyor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBekliyor.Appearance.ForeColor = System.Drawing.Color.Chocolate;
            this.lblBekliyor.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblBekliyor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBekliyor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblBekliyor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBekliyor.Location = new System.Drawing.Point(860, 29);
            this.lblBekliyor.Name = "lblBekliyor";
            this.lblBekliyor.Size = new System.Drawing.Size(80, 22);
            this.lblBekliyor.TabIndex = 4;
            this.lblBekliyor.Text = "BEKLİYOR";
            // 
            // suzButton
            // 
            this.suzButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.suzButton.Appearance.Options.UseFont = true;
            this.suzButton.Image = global::EasySupply.Properties.Resources.search;
            this.suzButton.Location = new System.Drawing.Point(615, 29);
            this.suzButton.Name = "suzButton";
            this.suzButton.Size = new System.Drawing.Size(75, 23);
            this.suzButton.TabIndex = 3;
            this.suzButton.Text = "Ara";
            this.suzButton.Click += new System.EventHandler(this.suzButton_Click);
            // 
            // gemiAdiTextEdit
            // 
            this.gemiAdiTextEdit.EditValue = "";
            this.gemiAdiTextEdit.Location = new System.Drawing.Point(409, 31);
            this.gemiAdiTextEdit.Name = "gemiAdiTextEdit";
            this.gemiAdiTextEdit.Properties.MaxLength = 50;
            this.gemiAdiTextEdit.Size = new System.Drawing.Size(200, 20);
            this.gemiAdiTextEdit.TabIndex = 2;
            // 
            // sonTarihDateEdit
            // 
            this.sonTarihDateEdit.EditValue = null;
            this.sonTarihDateEdit.Location = new System.Drawing.Point(239, 31);
            this.sonTarihDateEdit.Name = "sonTarihDateEdit";
            this.sonTarihDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sonTarihDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.sonTarihDateEdit.Size = new System.Drawing.Size(90, 20);
            this.sonTarihDateEdit.TabIndex = 1;
            // 
            // lblGemiAdi
            // 
            this.lblGemiAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGemiAdi.Location = new System.Drawing.Point(335, 34);
            this.lblGemiAdi.Name = "lblGemiAdi";
            this.lblGemiAdi.Size = new System.Drawing.Size(50, 13);
            this.lblGemiAdi.TabIndex = 0;
            this.lblGemiAdi.Text = "Gemi Adı";
            // 
            // lblSonTarih
            // 
            this.lblSonTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSonTarih.Location = new System.Drawing.Point(174, 33);
            this.lblSonTarih.Name = "lblSonTarih";
            this.lblSonTarih.Size = new System.Drawing.Size(53, 13);
            this.lblSonTarih.TabIndex = 0;
            this.lblSonTarih.Text = "Son Tarih";
            // 
            // ilkTarihDateEdit
            // 
            this.ilkTarihDateEdit.EditValue = null;
            this.ilkTarihDateEdit.Location = new System.Drawing.Point(78, 30);
            this.ilkTarihDateEdit.Name = "ilkTarihDateEdit";
            this.ilkTarihDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ilkTarihDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ilkTarihDateEdit.Size = new System.Drawing.Size(90, 20);
            this.ilkTarihDateEdit.TabIndex = 1;
            // 
            // lblIlkTarih
            // 
            this.lblIlkTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblIlkTarih.Location = new System.Drawing.Point(11, 34);
            this.lblIlkTarih.Name = "lblIlkTarih";
            this.lblIlkTarih.Size = new System.Drawing.Size(47, 13);
            this.lblIlkTarih.TabIndex = 0;
            this.lblIlkTarih.Text = "İlk Tarih";
            // 
            // xFrmTeklifDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 471);
            this.Controls.Add(this.teklifGridControl);
            this.Controls.Add(this.filterGroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xFrmTeklifDetay";
            this.Text = "Teklif Arşivi";
            this.Load += new System.EventHandler(this.xFrmTeklifDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teklifGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDurumNotuMemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterGroupControl)).EndInit();
            this.filterGroupControl.ResumeLayout(false);
            this.filterGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gemiAdiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonTarihDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonTarihDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkTarihDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkTarihDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl teklifGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView teklifGridView;
        private System.Windows.Forms.BindingSource teklifBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colGemiAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBaglamaLimani;
        private DevExpress.XtraGrid.Columns.GridColumn colAcenta;
        private DevExpress.XtraGrid.Columns.GridColumn colManager;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colParaBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colTasimaUcreti;
        private DevExpress.XtraGrid.Columns.GridColumn colHazirlayan;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraEditors.GroupControl filterGroupControl;
        private DevExpress.XtraEditors.LabelControl lblIlkTarih;
        private DevExpress.XtraEditors.DateEdit sonTarihDateEdit;
        private DevExpress.XtraEditors.LabelControl lblSonTarih;
        private DevExpress.XtraEditors.DateEdit ilkTarihDateEdit;
        private DevExpress.XtraEditors.SimpleButton suzButton;
        private DevExpress.XtraEditors.TextEdit gemiAdiTextEdit;
        private DevExpress.XtraEditors.LabelControl lblGemiAdi;
        private DevExpress.XtraEditors.LabelControl lblBekliyor;
        private DevExpress.XtraEditors.LabelControl lblIptal;
        private DevExpress.XtraEditors.LabelControl lblOnaylandi;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumNotu;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit rpsDurumNotuMemoExEdit;
    }
}