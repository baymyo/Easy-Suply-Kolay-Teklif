namespace EasySupply
{
    partial class xFrmTeklifDetayDegisiklik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmTeklifDetayDegisiklik));
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsAdetCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.infoLabel = new DevExpress.XtraEditors.LabelControl();
            this.teklifDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teklifDetayGridControl = new DevExpress.XtraGrid.GridControl();
            this.teklifDetayGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeklifID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsBirimFiyatCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKarOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsKarOraniCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colMiktar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsMiktarCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colBirim1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKazanc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vazgecButton = new DevExpress.XtraEditors.SimpleButton();
            this.onaylaButton = new DevExpress.XtraEditors.SimpleButton();
            this.messageLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rpsAdetCalcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDetayGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDetayGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsBirimFiyatCalcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsKarOraniCalcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsMiktarCalcEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // colAdet
            // 
            this.colAdet.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAdet.Caption = "Adet";
            this.colAdet.ColumnEdit = this.rpsAdetCalcEdit;
            this.colAdet.DisplayFormat.FormatString = "###,##0.00";
            this.colAdet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAdet.FieldName = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.OptionsFilter.AllowAutoFilter = false;
            this.colAdet.OptionsFilter.AllowFilter = false;
            this.colAdet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Adet", "{0:##0}")});
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 2;
            this.colAdet.Width = 50;
            // 
            // rpsAdetCalcEdit
            // 
            this.rpsAdetCalcEdit.AutoHeight = false;
            this.rpsAdetCalcEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsAdetCalcEdit.Name = "rpsAdetCalcEdit";
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
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "- - -";
            // 
            // teklifDetayBindingSource
            // 
            this.teklifDetayBindingSource.DataSource = typeof(EasySupply.TeklifDetay);
            // 
            // teklifDetayGridControl
            // 
            this.teklifDetayGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teklifDetayGridControl.DataSource = this.teklifDetayBindingSource;
            this.teklifDetayGridControl.Location = new System.Drawing.Point(0, 29);
            this.teklifDetayGridControl.MainView = this.teklifDetayGridView;
            this.teklifDetayGridControl.Name = "teklifDetayGridControl";
            this.teklifDetayGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpsAdetCalcEdit,
            this.rpsKarOraniCalcEdit,
            this.rpsMiktarCalcEdit,
            this.rpsBirimFiyatCalcEdit});
            this.teklifDetayGridControl.Size = new System.Drawing.Size(999, 486);
            this.teklifDetayGridControl.TabIndex = 3;
            this.teklifDetayGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.teklifDetayGridView});
            this.teklifDetayGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teklifDetayGridControl_KeyDown);
            // 
            // teklifDetayGridView
            // 
            this.teklifDetayGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.teklifDetayGridView.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.teklifDetayGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.teklifDetayGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.teklifDetayGridView.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.teklifDetayGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.teklifDetayGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.teklifDetayGridView.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.teklifDetayGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.teklifDetayGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.teklifDetayGridView.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.teklifDetayGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.teklifDetayGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTeklifID,
            this.colStokID,
            this.colSiraNo,
            this.colUrunAdi,
            this.colFirmaAdi,
            this.colBirimFiyati,
            this.colKarOrani,
            this.colMiktar1,
            this.colBirim1,
            this.colAdet,
            this.colAlisTutar,
            this.colSatisFiyati,
            this.colSatisTutar,
            this.colKazanc,
            this.colKdv});
            this.teklifDetayGridView.CustomizationFormBounds = new System.Drawing.Rectangle(764, 552, 208, 177);
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colAdet;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "0";
            this.teklifDetayGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.teklifDetayGridView.GridControl = this.teklifDetayGridControl;
            this.teklifDetayGridView.Name = "teklifDetayGridView";
            this.teklifDetayGridView.OptionsSelection.MultiSelect = true;
            this.teklifDetayGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.teklifDetayGridView.OptionsView.ShowFooter = true;
            this.teklifDetayGridView.OptionsView.ShowGroupPanel = false;
            this.teklifDetayGridView.OptionsView.ShowVertLines = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colTeklifID
            // 
            this.colTeklifID.FieldName = "TeklifID";
            this.colTeklifID.Name = "colTeklifID";
            // 
            // colStokID
            // 
            this.colStokID.FieldName = "StokID";
            this.colStokID.Name = "colStokID";
            // 
            // colSiraNo
            // 
            this.colSiraNo.AppearanceCell.Options.UseTextOptions = true;
            this.colSiraNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSiraNo.Caption = "No";
            this.colSiraNo.FieldName = "SiraNo";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.OptionsColumn.AllowEdit = false;
            this.colSiraNo.OptionsColumn.AllowFocus = false;
            this.colSiraNo.OptionsColumn.AllowSize = false;
            this.colSiraNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSiraNo.OptionsFilter.AllowAutoFilter = false;
            this.colSiraNo.OptionsFilter.AllowFilter = false;
            this.colSiraNo.Width = 35;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün / Açıklama";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.OptionsFilter.AllowAutoFilter = false;
            this.colUrunAdi.OptionsFilter.AllowFilter = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 0;
            this.colUrunAdi.Width = 304;
            // 
            // colFirmaAdi
            // 
            this.colFirmaAdi.Caption = "Tedarikçi Firma";
            this.colFirmaAdi.FieldName = "FirmaAdi";
            this.colFirmaAdi.Name = "colFirmaAdi";
            this.colFirmaAdi.OptionsColumn.AllowEdit = false;
            this.colFirmaAdi.OptionsColumn.AllowFocus = false;
            this.colFirmaAdi.OptionsFilter.AllowAutoFilter = false;
            this.colFirmaAdi.OptionsFilter.AllowFilter = false;
            this.colFirmaAdi.Visible = true;
            this.colFirmaAdi.VisibleIndex = 1;
            this.colFirmaAdi.Width = 152;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBirimFiyati.AppearanceCell.Options.UseFont = true;
            this.colBirimFiyati.AppearanceHeader.Options.UseTextOptions = true;
            this.colBirimFiyati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBirimFiyati.Caption = "Birim Fiyatı";
            this.colBirimFiyati.ColumnEdit = this.rpsBirimFiyatCalcEdit;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.AllowSize = false;
            this.colBirimFiyati.OptionsFilter.AllowAutoFilter = false;
            this.colBirimFiyati.OptionsFilter.AllowFilter = false;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 4;
            this.colBirimFiyati.Width = 72;
            // 
            // rpsBirimFiyatCalcEdit
            // 
            this.rpsBirimFiyatCalcEdit.AutoHeight = false;
            this.rpsBirimFiyatCalcEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsBirimFiyatCalcEdit.DisplayFormat.FormatString = "###,###,##0.00 TL";
            this.rpsBirimFiyatCalcEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpsBirimFiyatCalcEdit.EditFormat.FormatString = "###,###,##0.00";
            this.rpsBirimFiyatCalcEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpsBirimFiyatCalcEdit.Name = "rpsBirimFiyatCalcEdit";
            // 
            // colKarOrani
            // 
            this.colKarOrani.AppearanceHeader.Options.UseTextOptions = true;
            this.colKarOrani.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colKarOrani.Caption = "Kâr %";
            this.colKarOrani.ColumnEdit = this.rpsKarOraniCalcEdit;
            this.colKarOrani.DisplayFormat.FormatString = "% ##0";
            this.colKarOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colKarOrani.FieldName = "KarOrani";
            this.colKarOrani.Name = "colKarOrani";
            this.colKarOrani.OptionsColumn.AllowSize = false;
            this.colKarOrani.OptionsFilter.AllowFilter = false;
            this.colKarOrani.Visible = true;
            this.colKarOrani.VisibleIndex = 5;
            this.colKarOrani.Width = 60;
            // 
            // rpsKarOraniCalcEdit
            // 
            this.rpsKarOraniCalcEdit.AutoHeight = false;
            this.rpsKarOraniCalcEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsKarOraniCalcEdit.DisplayFormat.FormatString = "% ##0";
            this.rpsKarOraniCalcEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpsKarOraniCalcEdit.EditFormat.FormatString = "##0.00";
            this.rpsKarOraniCalcEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpsKarOraniCalcEdit.Name = "rpsKarOraniCalcEdit";
            // 
            // colMiktar1
            // 
            this.colMiktar1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMiktar1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMiktar1.ColumnEdit = this.rpsMiktarCalcEdit;
            this.colMiktar1.DisplayFormat.FormatString = "###,##0.00";
            this.colMiktar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMiktar1.FieldName = "Miktar";
            this.colMiktar1.Name = "colMiktar1";
            this.colMiktar1.OptionsColumn.AllowSize = false;
            this.colMiktar1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMiktar1.OptionsFilter.AllowFilter = false;
            this.colMiktar1.Width = 46;
            // 
            // rpsMiktarCalcEdit
            // 
            this.rpsMiktarCalcEdit.AutoHeight = false;
            this.rpsMiktarCalcEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsMiktarCalcEdit.Name = "rpsMiktarCalcEdit";
            // 
            // colBirim1
            // 
            this.colBirim1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBirim1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colBirim1.FieldName = "Birim";
            this.colBirim1.Name = "colBirim1";
            this.colBirim1.OptionsColumn.AllowEdit = false;
            this.colBirim1.OptionsColumn.AllowFocus = false;
            this.colBirim1.OptionsColumn.AllowSize = false;
            this.colBirim1.OptionsFilter.AllowAutoFilter = false;
            this.colBirim1.OptionsFilter.AllowFilter = false;
            this.colBirim1.Visible = true;
            this.colBirim1.VisibleIndex = 3;
            this.colBirim1.Width = 40;
            // 
            // colAlisTutar
            // 
            this.colAlisTutar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colAlisTutar.AppearanceCell.Options.UseFont = true;
            this.colAlisTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colAlisTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAlisTutar.Caption = "Alış Tutar";
            this.colAlisTutar.DisplayFormat.FormatString = "###,###,##0.00 TL";
            this.colAlisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAlisTutar.FieldName = "colAlisTutar";
            this.colAlisTutar.Name = "colAlisTutar";
            this.colAlisTutar.OptionsColumn.AllowEdit = false;
            this.colAlisTutar.OptionsColumn.AllowFocus = false;
            this.colAlisTutar.OptionsColumn.AllowSize = false;
            this.colAlisTutar.OptionsFilter.AllowAutoFilter = false;
            this.colAlisTutar.OptionsFilter.AllowFilter = false;
            this.colAlisTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colAlisTutar", "{0:###,###,##0.00 TL}")});
            this.colAlisTutar.UnboundExpression = "[BirimFiyati] * [Adet]";
            this.colAlisTutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colAlisTutar.Visible = true;
            this.colAlisTutar.VisibleIndex = 7;
            this.colAlisTutar.Width = 74;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSatisFiyati.AppearanceCell.Options.UseFont = true;
            this.colSatisFiyati.AppearanceHeader.Options.UseTextOptions = true;
            this.colSatisFiyati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSatisFiyati.Caption = "Satış Fiyatı";
            this.colSatisFiyati.DisplayFormat.FormatString = "###,###,##0.00 TL";
            this.colSatisFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSatisFiyati.FieldName = "SatisFiyati";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.OptionsColumn.AllowEdit = false;
            this.colSatisFiyati.OptionsColumn.AllowFocus = false;
            this.colSatisFiyati.OptionsColumn.AllowSize = false;
            this.colSatisFiyati.OptionsFilter.AllowAutoFilter = false;
            this.colSatisFiyati.OptionsFilter.AllowFilter = false;
            this.colSatisFiyati.Visible = true;
            this.colSatisFiyati.VisibleIndex = 6;
            this.colSatisFiyati.Width = 74;
            // 
            // colSatisTutar
            // 
            this.colSatisTutar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSatisTutar.AppearanceCell.Options.UseFont = true;
            this.colSatisTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colSatisTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSatisTutar.Caption = "Satış Tutar";
            this.colSatisTutar.DisplayFormat.FormatString = "###,###,##0.00 TL";
            this.colSatisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSatisTutar.FieldName = "colSatisTutar";
            this.colSatisTutar.Name = "colSatisTutar";
            this.colSatisTutar.OptionsColumn.AllowEdit = false;
            this.colSatisTutar.OptionsColumn.AllowFocus = false;
            this.colSatisTutar.OptionsColumn.AllowSize = false;
            this.colSatisTutar.OptionsFilter.AllowAutoFilter = false;
            this.colSatisTutar.OptionsFilter.AllowFilter = false;
            this.colSatisTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colSatisTutar", "{0:###,###,##0.00 TL}")});
            this.colSatisTutar.UnboundExpression = "[SatisFiyati] * [Adet]";
            this.colSatisTutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colSatisTutar.Visible = true;
            this.colSatisTutar.VisibleIndex = 8;
            this.colSatisTutar.Width = 74;
            // 
            // colKazanc
            // 
            this.colKazanc.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colKazanc.AppearanceCell.Options.UseFont = true;
            this.colKazanc.AppearanceHeader.Options.UseTextOptions = true;
            this.colKazanc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colKazanc.Caption = "Net Kâr";
            this.colKazanc.DisplayFormat.FormatString = "###,###,##0.00 TL";
            this.colKazanc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colKazanc.FieldName = "colKazanc";
            this.colKazanc.Name = "colKazanc";
            this.colKazanc.OptionsColumn.AllowEdit = false;
            this.colKazanc.OptionsColumn.AllowFocus = false;
            this.colKazanc.OptionsColumn.AllowSize = false;
            this.colKazanc.OptionsFilter.AllowAutoFilter = false;
            this.colKazanc.OptionsFilter.AllowFilter = false;
            this.colKazanc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colKazanc", "{0:###,###,##0.00 TL}")});
            this.colKazanc.UnboundExpression = "([BirimFiyati] * [KarOrani]) * [Adet]";
            this.colKazanc.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colKazanc.Visible = true;
            this.colKazanc.VisibleIndex = 9;
            this.colKazanc.Width = 70;
            // 
            // colKdv
            // 
            this.colKdv.FieldName = "Kdv";
            this.colKdv.Name = "colKdv";
            // 
            // vazgecButton
            // 
            this.vazgecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vazgecButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vazgecButton.Appearance.Options.UseFont = true;
            this.vazgecButton.Location = new System.Drawing.Point(863, 521);
            this.vazgecButton.Name = "vazgecButton";
            this.vazgecButton.Size = new System.Drawing.Size(124, 30);
            this.vazgecButton.TabIndex = 4;
            this.vazgecButton.Text = "VAZGEÇ";
            this.vazgecButton.Click += new System.EventHandler(this.vazgecButton_Click);
            // 
            // onaylaButton
            // 
            this.onaylaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.onaylaButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.onaylaButton.Appearance.Options.UseFont = true;
            this.onaylaButton.Location = new System.Drawing.Point(733, 521);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(124, 30);
            this.onaylaButton.TabIndex = 4;
            this.onaylaButton.Text = "TAMAM";
            this.onaylaButton.Click += new System.EventHandler(this.onaylaButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.messageLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.messageLabel.Location = new System.Drawing.Point(13, 529);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(391, 13);
            this.messageLabel.TabIndex = 5;
            this.messageLabel.Text = "\"Adet\" alanı \"0\" olanlar silinen kayıtlardır kırmızı renkte belirtilmiştir!";
            // 
            // xFrmTeklifDetayDegisiklik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 556);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.onaylaButton);
            this.Controls.Add(this.vazgecButton);
            this.Controls.Add(this.teklifDetayGridControl);
            this.Controls.Add(this.infoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xFrmTeklifDetayDegisiklik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepetinizdeki Değişiklikler!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.xFrmTeklifDetayDegisiklik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rpsAdetCalcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDetayGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDetayGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsBirimFiyatCalcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsKarOraniCalcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsMiktarCalcEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl infoLabel;
        private System.Windows.Forms.BindingSource teklifDetayBindingSource;
        private DevExpress.XtraGrid.GridControl teklifDetayGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView teklifDetayGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTeklifID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID;
        private DevExpress.XtraGrid.Columns.GridColumn colSiraNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colKarOrani;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpsKarOraniCalcEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpsMiktarCalcEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpsAdetCalcEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colKazanc;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraEditors.SimpleButton vazgecButton;
        private DevExpress.XtraEditors.SimpleButton onaylaButton;
        private DevExpress.XtraEditors.LabelControl messageLabel;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpsBirimFiyatCalcEdit;
    }
}