namespace EasySupply
{
    partial class xFrmUrunYeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmUrunYeni));
            this.onaylaButton = new DevExpress.XtraEditors.SimpleButton();
            this.vazgecButton = new DevExpress.XtraEditors.SimpleButton();
            this.infoLabel = new DevExpress.XtraEditors.LabelControl();
            this.urunGridControl = new DevExpress.XtraGrid.GridControl();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsMiktarCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsBirimComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpsKategoriLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rpsUrunResim = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.urunGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsMiktarCalcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsBirimComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsKategoriLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsUrunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // onaylaButton
            // 
            this.onaylaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.onaylaButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.onaylaButton.Appearance.Options.UseFont = true;
            this.onaylaButton.Location = new System.Drawing.Point(733, 514);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(124, 30);
            this.onaylaButton.TabIndex = 12;
            this.onaylaButton.Text = "TAMAM";
            this.onaylaButton.Click += new System.EventHandler(this.onaylaButton_Click);
            // 
            // vazgecButton
            // 
            this.vazgecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vazgecButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vazgecButton.Appearance.Options.UseFont = true;
            this.vazgecButton.Location = new System.Drawing.Point(863, 514);
            this.vazgecButton.Name = "vazgecButton";
            this.vazgecButton.Size = new System.Drawing.Size(124, 30);
            this.vazgecButton.TabIndex = 11;
            this.vazgecButton.Text = "VAZGEÇ";
            this.vazgecButton.Click += new System.EventHandler(this.vazgecButton_Click);
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
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "- - -";
            // 
            // urunGridControl
            // 
            this.urunGridControl.DataSource = this.urunBindingSource;
            this.urunGridControl.Location = new System.Drawing.Point(0, 30);
            this.urunGridControl.MainView = this.urunGridView;
            this.urunGridControl.Name = "urunGridControl";
            this.urunGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpsKategoriLookUpEdit,
            this.rpsMiktarCalcEdit,
            this.rpsBirimComboBox,
            this.rpsUrunResim});
            this.urunGridControl.Size = new System.Drawing.Size(999, 478);
            this.urunGridControl.TabIndex = 13;
            this.urunGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.urunGridView});
            this.urunGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urunGridControl_KeyDown);
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(EasySupply.Urun);
            // 
            // urunGridView
            // 
            this.urunGridView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.urunGridView.Appearance.GroupPanel.Options.UseFont = true;
            this.urunGridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.urunGridView.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.urunGridView.Appearance.TopNewRow.BorderColor = System.Drawing.Color.Yellow;
            this.urunGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.urunGridView.Appearance.TopNewRow.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.urunGridView.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.urunGridView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.urunGridView.Appearance.TopNewRow.Options.UseBorderColor = true;
            this.urunGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.urunGridView.Appearance.TopNewRow.Options.UseForeColor = true;
            this.urunGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKod,
            this.colAdi,
            this.colMiktar,
            this.colBirim,
            this.colKdv});
            this.urunGridView.GridControl = this.urunGridControl;
            this.urunGridView.GroupPanelText = "Ürün Bilgileri";
            this.urunGridView.Name = "urunGridView";
            this.urunGridView.NewItemRowText = "NEW PRODUCT";
            this.urunGridView.OptionsBehavior.Editable = false;
            this.urunGridView.OptionsSelection.MultiSelect = true;
            this.urunGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.urunGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colKod.AppearanceCell.Options.UseFont = true;
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colKod.AppearanceHeader.Options.UseFont = true;
            this.colKod.AppearanceHeader.Options.UseTextOptions = true;
            this.colKod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Impa Code";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowSize = false;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 74;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Ürün Açıklama";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 1;
            this.colAdi.Width = 389;
            // 
            // colMiktar
            // 
            this.colMiktar.ColumnEdit = this.rpsMiktarCalcEdit;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowSize = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 2;
            this.colMiktar.Width = 50;
            // 
            // rpsMiktarCalcEdit
            // 
            this.rpsMiktarCalcEdit.AutoHeight = false;
            this.rpsMiktarCalcEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsMiktarCalcEdit.Name = "rpsMiktarCalcEdit";
            // 
            // colBirim
            // 
            this.colBirim.ColumnEdit = this.rpsBirimComboBox;
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowSize = false;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 3;
            this.colBirim.Width = 47;
            // 
            // rpsBirimComboBox
            // 
            this.rpsBirimComboBox.AutoHeight = false;
            this.rpsBirimComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsBirimComboBox.Items.AddRange(new object[] {
            "ADET",
            "GR",
            "KG",
            "TON",
            "LT",
            "KUTU"});
            this.rpsBirimComboBox.Name = "rpsBirimComboBox";
            // 
            // colKdv
            // 
            this.colKdv.DisplayFormat.FormatString = "% ##0 Tax";
            this.colKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colKdv.FieldName = "Kdv";
            this.colKdv.Name = "colKdv";
            this.colKdv.OptionsColumn.AllowSize = false;
            this.colKdv.Visible = true;
            this.colKdv.VisibleIndex = 4;
            this.colKdv.Width = 73;
            // 
            // rpsKategoriLookUpEdit
            // 
            this.rpsKategoriLookUpEdit.AutoHeight = false;
            this.rpsKategoriLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpsKategoriLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kod", "Kod", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Adi", "Adi", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.rpsKategoriLookUpEdit.DisplayMember = "Adi";
            this.rpsKategoriLookUpEdit.Name = "rpsKategoriLookUpEdit";
            this.rpsKategoriLookUpEdit.NullText = "[...]";
            this.rpsKategoriLookUpEdit.PopupWidth = 200;
            this.rpsKategoriLookUpEdit.ValueMember = "ID";
            // 
            // rpsUrunResim
            // 
            this.rpsUrunResim.Name = "rpsUrunResim";
            // 
            // xFrmUrunYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 556);
            this.Controls.Add(this.urunGridControl);
            this.Controls.Add(this.onaylaButton);
            this.Controls.Add(this.vazgecButton);
            this.Controls.Add(this.infoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1007, 590);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1007, 590);
            this.Name = "xFrmUrunYeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Ürün Listesi";
            this.Load += new System.EventHandler(this.xFrmUrunYeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsMiktarCalcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsBirimComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsKategoriLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsUrunResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton onaylaButton;
        private DevExpress.XtraEditors.SimpleButton vazgecButton;
        private DevExpress.XtraEditors.LabelControl infoLabel;
        private DevExpress.XtraGrid.GridControl urunGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView urunGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKod;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rpsKategoriLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpsMiktarCalcEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpsBirimComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit rpsUrunResim;
        private System.Windows.Forms.BindingSource urunBindingSource;
    }
}