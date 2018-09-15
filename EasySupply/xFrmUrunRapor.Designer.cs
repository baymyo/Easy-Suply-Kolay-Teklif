namespace EasySupply
{
    partial class xFrmUrunRapor
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmUrunRapor));
            this.fieldFiyat1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTutar = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldKarOran = new DevExpress.XtraPivotGrid.PivotGridField();
            this.urunlerPivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.urunRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldFirmaKod1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUrunAdi1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldKategoriAdi1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerPivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunRaporBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldFiyat1
            // 
            this.fieldFiyat1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldFiyat1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldFiyat1.AreaIndex = 0;
            this.fieldFiyat1.Caption = "Alış Fiyatı";
            this.fieldFiyat1.CellFormat.FormatString = "###,###,##0.00";
            this.fieldFiyat1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldFiyat1.FieldName = "Fiyat";
            this.fieldFiyat1.Name = "fieldFiyat1";
            this.fieldFiyat1.Options.AllowEdit = false;
            this.fieldFiyat1.Options.ShowCustomTotals = false;
            this.fieldFiyat1.Options.ShowGrandTotal = false;
            this.fieldFiyat1.Options.ShowTotals = false;
            this.fieldFiyat1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.fieldFiyat1.Width = 65;
            // 
            // fieldTutar
            // 
            this.fieldTutar.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fieldTutar.Appearance.Cell.Options.UseFont = true;
            this.fieldTutar.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTutar.AreaIndex = 1;
            this.fieldTutar.Caption = "Satış Fiyatı";
            this.fieldTutar.CellFormat.FormatString = "###,###,##0.00";
            this.fieldTutar.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldTutar.FieldName = "Tutar";
            this.fieldTutar.Name = "fieldTutar";
            this.fieldTutar.Width = 65;
            // 
            // fieldKarOran
            // 
            this.fieldKarOran.AreaIndex = 0;
            this.fieldKarOran.FieldName = "KarOran";
            this.fieldKarOran.Name = "fieldKarOran";
            this.fieldKarOran.Visible = false;
            // 
            // urunlerPivotGridControl
            // 
            this.urunlerPivotGridControl.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.urunlerPivotGridControl.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.urunlerPivotGridControl.DataSource = this.urunRaporBindingSource;
            this.urunlerPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunlerPivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldFiyat1,
            this.fieldKarOran,
            this.fieldTutar,
            this.fieldFirmaKod1,
            this.fieldUrunAdi1,
            this.fieldKategoriAdi1});
            pivotGridGroup1.Caption = "Fiyatlar";
            pivotGridGroup1.Fields.Add(this.fieldFiyat1);
            pivotGridGroup1.Fields.Add(this.fieldTutar);
            pivotGridGroup1.Hierarchy = null;
            this.urunlerPivotGridControl.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.urunlerPivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.urunlerPivotGridControl.Name = "urunlerPivotGridControl";
            this.urunlerPivotGridControl.OptionsView.ShowColumnGrandTotalHeader = false;
            this.urunlerPivotGridControl.OptionsView.ShowColumnGrandTotals = false;
            this.urunlerPivotGridControl.OptionsView.ShowColumnHeaders = false;
            this.urunlerPivotGridControl.OptionsView.ShowColumnTotals = false;
            this.urunlerPivotGridControl.OptionsView.ShowDataHeaders = false;
            this.urunlerPivotGridControl.OptionsView.ShowFilterHeaders = false;
            this.urunlerPivotGridControl.OptionsView.ShowFilterSeparatorBar = false;
            this.urunlerPivotGridControl.OptionsView.ShowRowGrandTotalHeader = false;
            this.urunlerPivotGridControl.OptionsView.ShowRowGrandTotals = false;
            this.urunlerPivotGridControl.OptionsView.ShowRowHeaders = false;
            this.urunlerPivotGridControl.OptionsView.ShowRowTotals = false;
            this.urunlerPivotGridControl.Size = new System.Drawing.Size(641, 360);
            this.urunlerPivotGridControl.TabIndex = 0;
            // 
            // urunRaporBindingSource
            // 
            this.urunRaporBindingSource.DataSource = typeof(EasySupply.UrunRapor);
            // 
            // fieldFirmaKod1
            // 
            this.fieldFirmaKod1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldFirmaKod1.AreaIndex = 0;
            this.fieldFirmaKod1.Caption = "Firma Kod";
            this.fieldFirmaKod1.FieldName = "FirmaKod";
            this.fieldFirmaKod1.Name = "fieldFirmaKod1";
            // 
            // fieldUrunAdi1
            // 
            this.fieldUrunAdi1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldUrunAdi1.AreaIndex = 1;
            this.fieldUrunAdi1.Caption = "Urun Adi";
            this.fieldUrunAdi1.FieldName = "UrunAdi";
            this.fieldUrunAdi1.Name = "fieldUrunAdi1";
            this.fieldUrunAdi1.Options.AllowEdit = false;
            this.fieldUrunAdi1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.fieldUrunAdi1.Width = 275;
            // 
            // fieldKategoriAdi1
            // 
            this.fieldKategoriAdi1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldKategoriAdi1.AreaIndex = 0;
            this.fieldKategoriAdi1.Caption = "Kategori Adi";
            this.fieldKategoriAdi1.FieldName = "KategoriAdi";
            this.fieldKategoriAdi1.Name = "fieldKategoriAdi1";
            this.fieldKategoriAdi1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.fieldKategoriAdi1.Width = 20;
            // 
            // xFrmUrunRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 360);
            this.Controls.Add(this.urunlerPivotGridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xFrmUrunRapor";
            this.Text = "Ürün Raporu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xFrmUrunRapor_FormClosing);
            this.Load += new System.EventHandler(this.xFrmUrunRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerPivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunRaporBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl urunlerPivotGridControl;
        private System.Windows.Forms.BindingSource urunRaporBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFiyat1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFirmaKod1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUrunAdi1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldKategoriAdi1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldKarOran;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTutar;
    }
}