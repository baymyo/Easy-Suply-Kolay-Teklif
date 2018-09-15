namespace EasySupply
{
    partial class xFrmKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmKategori));
            this.kategoriGridControl = new DevExpress.XtraGrid.GridControl();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblKod = new DevExpress.XtraEditors.LabelControl();
            this.txtKod = new DevExpress.XtraEditors.TextEdit();
            this.txtKategoriAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblKategoriAdi = new DevExpress.XtraEditors.LabelControl();
            this.kategoriGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.yeniButton = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGroupControl)).BeginInit();
            this.kategoriGroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // kategoriGridControl
            // 
            this.kategoriGridControl.DataSource = this.kategoriBindingSource;
            this.kategoriGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kategoriGridControl.Location = new System.Drawing.Point(285, 0);
            this.kategoriGridControl.MainView = this.kategoriGridView;
            this.kategoriGridControl.Name = "kategoriGridControl";
            this.kategoriGridControl.Size = new System.Drawing.Size(545, 409);
            this.kategoriGridControl.TabIndex = 1;
            this.kategoriGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.kategoriGridView});
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataSource = typeof(EasySupply.Kategori);
            // 
            // kategoriGridView
            // 
            this.kategoriGridView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.kategoriGridView.Appearance.GroupPanel.Options.UseFont = true;
            this.kategoriGridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kategoriGridView.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kategoriGridView.Appearance.TopNewRow.BorderColor = System.Drawing.Color.Yellow;
            this.kategoriGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kategoriGridView.Appearance.TopNewRow.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.kategoriGridView.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kategoriGridView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.kategoriGridView.Appearance.TopNewRow.Options.UseBorderColor = true;
            this.kategoriGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.kategoriGridView.Appearance.TopNewRow.Options.UseForeColor = true;
            this.kategoriGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKod,
            this.colAdi});
            this.kategoriGridView.GridControl = this.kategoriGridControl;
            this.kategoriGridView.GroupPanelText = "Kategori Kayıt İşlemleri";
            this.kategoriGridView.Name = "kategoriGridView";
            this.kategoriGridView.NewItemRowText = "NEW ITEM ROW";
            this.kategoriGridView.OptionsBehavior.Editable = false;
            this.kategoriGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.kategoriGridView.OptionsView.ShowGroupPanel = false;
            this.kategoriGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kategoriGridView_KeyDown);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colKod
            // 
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowSize = false;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            // 
            // colAdi
            // 
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 1;
            this.colAdi.Width = 457;
            // 
            // lblKod
            // 
            this.lblKod.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKod.Location = new System.Drawing.Point(5, 25);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(9, 13);
            this.lblKod.TabIndex = 1;
            this.lblKod.Text = "...";
            // 
            // txtKod
            // 
            this.txtKod.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kategoriBindingSource, "Kod", true));
            this.txtKod.Location = new System.Drawing.Point(5, 44);
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.MaxLength = 5;
            this.txtKod.Size = new System.Drawing.Size(75, 20);
            this.txtKod.TabIndex = 0;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kategoriBindingSource, "Adi", true));
            this.txtKategoriAdi.Location = new System.Drawing.Point(5, 89);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Properties.MaxLength = 75;
            this.txtKategoriAdi.Size = new System.Drawing.Size(269, 20);
            this.txtKategoriAdi.TabIndex = 1;
            // 
            // lblKategoriAdi
            // 
            this.lblKategoriAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKategoriAdi.Location = new System.Drawing.Point(5, 70);
            this.lblKategoriAdi.Name = "lblKategoriAdi";
            this.lblKategoriAdi.Size = new System.Drawing.Size(9, 13);
            this.lblKategoriAdi.TabIndex = 4;
            this.lblKategoriAdi.Text = "...";
            // 
            // kategoriGroupControl
            // 
            this.kategoriGroupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kategoriGroupControl.AppearanceCaption.Options.UseFont = true;
            this.kategoriGroupControl.Controls.Add(this.yeniButton);
            this.kategoriGroupControl.Controls.Add(this.kaydetButton);
            this.kategoriGroupControl.Controls.Add(this.lblKod);
            this.kategoriGroupControl.Controls.Add(this.lblKategoriAdi);
            this.kategoriGroupControl.Controls.Add(this.txtKod);
            this.kategoriGroupControl.Controls.Add(this.txtKategoriAdi);
            this.kategoriGroupControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.kategoriGroupControl.Location = new System.Drawing.Point(0, 0);
            this.kategoriGroupControl.Name = "kategoriGroupControl";
            this.kategoriGroupControl.Size = new System.Drawing.Size(280, 409);
            this.kategoriGroupControl.TabIndex = 0;
            this.kategoriGroupControl.Text = "...";
            // 
            // yeniButton
            // 
            this.yeniButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.yeniButton.Appearance.Options.UseFont = true;
            this.yeniButton.Location = new System.Drawing.Point(118, 115);
            this.yeniButton.Name = "yeniButton";
            this.yeniButton.Size = new System.Drawing.Size(75, 23);
            this.yeniButton.TabIndex = 3;
            this.yeniButton.Text = "Yeni Kayıt";
            this.yeniButton.Click += new System.EventHandler(this.yeniButton_Click);
            // 
            // kaydetButton
            // 
            this.kaydetButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kaydetButton.Appearance.Options.UseFont = true;
            this.kaydetButton.Location = new System.Drawing.Point(199, 115);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(75, 23);
            this.kaydetButton.TabIndex = 2;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(280, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 409);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            this.splitterControl1.DoubleClick += new System.EventHandler(this.splitterControl1_DoubleClick);
            // 
            // xFrmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 409);
            this.Controls.Add(this.kategoriGridControl);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.kategoriGroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xFrmKategori";
            this.Text = "Kategori Tanımla";
            this.Load += new System.EventHandler(this.xFrmKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGroupControl)).EndInit();
            this.kategoriGroupControl.ResumeLayout(false);
            this.kategoriGroupControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl kategoriGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView kategoriGridView;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKod;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraEditors.LabelControl lblKod;
        private DevExpress.XtraEditors.TextEdit txtKod;
        private DevExpress.XtraEditors.TextEdit txtKategoriAdi;
        private DevExpress.XtraEditors.LabelControl lblKategoriAdi;
        private DevExpress.XtraEditors.GroupControl kategoriGroupControl;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.SimpleButton yeniButton;
        private DevExpress.XtraEditors.SimpleButton kaydetButton;
    }
}