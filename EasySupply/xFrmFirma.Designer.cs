namespace EasySupply
{
    partial class xFrmFirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmFirma));
            this.firmaGridControl = new DevExpress.XtraGrid.GridControl();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firmaGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.txtFirmaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKod = new DevExpress.XtraEditors.TextEdit();
            this.clcPeriod = new DevExpress.XtraEditors.CalcEdit();
            this.lblPeriod = new DevExpress.XtraEditors.LabelControl();
            this.lblAdres = new DevExpress.XtraEditors.LabelControl();
            this.lblMail = new DevExpress.XtraEditors.LabelControl();
            this.lblTelefon = new DevExpress.XtraEditors.LabelControl();
            this.lblYetkili = new DevExpress.XtraEditors.LabelControl();
            this.lblFirmaAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblKod = new DevExpress.XtraEditors.LabelControl();
            this.yeniButton = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.firmaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaGroupControl)).BeginInit();
            this.firmaGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clcPeriod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // firmaGridControl
            // 
            this.firmaGridControl.DataSource = this.firmaBindingSource;
            this.firmaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firmaGridControl.Location = new System.Drawing.Point(286, 0);
            this.firmaGridControl.MainView = this.firmaGridView;
            this.firmaGridControl.Name = "firmaGridControl";
            this.firmaGridControl.Size = new System.Drawing.Size(804, 448);
            this.firmaGridControl.TabIndex = 1;
            this.firmaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.firmaGridView});
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataSource = typeof(EasySupply.Firma);
            // 
            // firmaGridView
            // 
            this.firmaGridView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.firmaGridView.Appearance.GroupPanel.Options.UseFont = true;
            this.firmaGridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.firmaGridView.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.firmaGridView.Appearance.TopNewRow.BorderColor = System.Drawing.Color.Yellow;
            this.firmaGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.firmaGridView.Appearance.TopNewRow.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.firmaGridView.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.firmaGridView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.firmaGridView.Appearance.TopNewRow.Options.UseBorderColor = true;
            this.firmaGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.firmaGridView.Appearance.TopNewRow.Options.UseForeColor = true;
            this.firmaGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKod,
            this.colAdi,
            this.colYetkili,
            this.colTelefon,
            this.colMail,
            this.colAdres,
            this.colPeriod});
            this.firmaGridView.GridControl = this.firmaGridControl;
            this.firmaGridView.GroupPanelText = "Firma Bilgileri";
            this.firmaGridView.Name = "firmaGridView";
            this.firmaGridView.NewItemRowText = "NEW RECORD";
            this.firmaGridView.OptionsBehavior.Editable = false;
            this.firmaGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.firmaGridView.OptionsView.ShowGroupPanel = false;
            this.firmaGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firmaGridView_KeyDown);
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
            this.colKod.Width = 48;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Firma Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowSize = false;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 1;
            this.colAdi.Width = 194;
            // 
            // colYetkili
            // 
            this.colYetkili.FieldName = "Yetkili";
            this.colYetkili.Name = "colYetkili";
            this.colYetkili.OptionsColumn.AllowSize = false;
            this.colYetkili.Visible = true;
            this.colYetkili.VisibleIndex = 2;
            this.colYetkili.Width = 140;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowSize = false;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 3;
            this.colTelefon.Width = 145;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 4;
            this.colMail.Width = 144;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 5;
            this.colAdres.Width = 317;
            // 
            // colPeriod
            // 
            this.colPeriod.DisplayFormat.FormatString = "{0:### Day}";
            this.colPeriod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPeriod.FieldName = "Period";
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.Visible = true;
            this.colPeriod.VisibleIndex = 6;
            this.colPeriod.Width = 84;
            // 
            // firmaGroupControl
            // 
            this.firmaGroupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.firmaGroupControl.AppearanceCaption.Options.UseFont = true;
            this.firmaGroupControl.Controls.Add(this.txtAdres);
            this.firmaGroupControl.Controls.Add(this.txtMail);
            this.firmaGroupControl.Controls.Add(this.txtTelefon);
            this.firmaGroupControl.Controls.Add(this.txtYetkili);
            this.firmaGroupControl.Controls.Add(this.txtFirmaAdi);
            this.firmaGroupControl.Controls.Add(this.txtKod);
            this.firmaGroupControl.Controls.Add(this.clcPeriod);
            this.firmaGroupControl.Controls.Add(this.lblPeriod);
            this.firmaGroupControl.Controls.Add(this.lblAdres);
            this.firmaGroupControl.Controls.Add(this.lblMail);
            this.firmaGroupControl.Controls.Add(this.lblTelefon);
            this.firmaGroupControl.Controls.Add(this.lblYetkili);
            this.firmaGroupControl.Controls.Add(this.lblFirmaAdi);
            this.firmaGroupControl.Controls.Add(this.lblKod);
            this.firmaGroupControl.Controls.Add(this.yeniButton);
            this.firmaGroupControl.Controls.Add(this.kaydetButton);
            this.firmaGroupControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.firmaGroupControl.Location = new System.Drawing.Point(0, 0);
            this.firmaGroupControl.Name = "firmaGroupControl";
            this.firmaGroupControl.Size = new System.Drawing.Size(280, 448);
            this.firmaGroupControl.TabIndex = 0;
            this.firmaGroupControl.Text = "Firma";
            // 
            // txtAdres
            // 
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaBindingSource, "Adres", true));
            this.txtAdres.Location = new System.Drawing.Point(5, 269);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Properties.MaxLength = 100;
            this.txtAdres.Size = new System.Drawing.Size(269, 20);
            this.txtAdres.TabIndex = 6;
            this.txtAdres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTab_KeyDown);
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaBindingSource, "Mail", true));
            this.txtMail.Location = new System.Drawing.Point(5, 224);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.MaxLength = 90;
            this.txtMail.Size = new System.Drawing.Size(269, 20);
            this.txtMail.TabIndex = 5;
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTab_KeyDown);
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaBindingSource, "Telefon", true));
            this.txtTelefon.Location = new System.Drawing.Point(5, 179);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.MaxLength = 50;
            this.txtTelefon.Size = new System.Drawing.Size(269, 20);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTab_KeyDown);
            // 
            // txtYetkili
            // 
            this.txtYetkili.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaBindingSource, "Yetkili", true));
            this.txtYetkili.Location = new System.Drawing.Point(5, 134);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Properties.MaxLength = 30;
            this.txtYetkili.Size = new System.Drawing.Size(269, 20);
            this.txtYetkili.TabIndex = 3;
            this.txtYetkili.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTab_KeyDown);
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaBindingSource, "Adi", true));
            this.txtFirmaAdi.Location = new System.Drawing.Point(5, 44);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Properties.MaxLength = 50;
            this.txtFirmaAdi.Size = new System.Drawing.Size(269, 20);
            this.txtFirmaAdi.TabIndex = 0;
            this.txtFirmaAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTab_KeyDown);
            // 
            // txtKod
            // 
            this.txtKod.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaBindingSource, "Kod", true));
            this.txtKod.Location = new System.Drawing.Point(5, 89);
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.MaxLength = 10;
            this.txtKod.Size = new System.Drawing.Size(100, 20);
            this.txtKod.TabIndex = 1;
            this.txtKod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTab_KeyDown);
            // 
            // clcPeriod
            // 
            this.clcPeriod.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaBindingSource, "Period", true));
            this.clcPeriod.Location = new System.Drawing.Point(199, 89);
            this.clcPeriod.Name = "clcPeriod";
            this.clcPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clcPeriod.Properties.DisplayFormat.FormatString = "{0:### Day}";
            this.clcPeriod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clcPeriod.Properties.EditFormat.FormatString = "##0";
            this.clcPeriod.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clcPeriod.Properties.MaxLength = 3;
            this.clcPeriod.Properties.Precision = 0;
            this.clcPeriod.Size = new System.Drawing.Size(75, 20);
            this.clcPeriod.TabIndex = 2;
            this.clcPeriod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterTab_KeyDown);
            // 
            // lblPeriod
            // 
            this.lblPeriod.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPeriod.Location = new System.Drawing.Point(199, 70);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(9, 13);
            this.lblPeriod.TabIndex = 1;
            this.lblPeriod.Text = "...";
            // 
            // lblAdres
            // 
            this.lblAdres.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAdres.Location = new System.Drawing.Point(5, 250);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(9, 13);
            this.lblAdres.TabIndex = 1;
            this.lblAdres.Text = "...";
            // 
            // lblMail
            // 
            this.lblMail.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMail.Location = new System.Drawing.Point(7, 205);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(23, 13);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Mail";
            // 
            // lblTelefon
            // 
            this.lblTelefon.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefon.Location = new System.Drawing.Point(5, 160);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(9, 13);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "...";
            // 
            // lblYetkili
            // 
            this.lblYetkili.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblYetkili.Location = new System.Drawing.Point(5, 115);
            this.lblYetkili.Name = "lblYetkili";
            this.lblYetkili.Size = new System.Drawing.Size(9, 13);
            this.lblYetkili.TabIndex = 1;
            this.lblYetkili.Text = "...";
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFirmaAdi.Location = new System.Drawing.Point(5, 25);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(9, 13);
            this.lblFirmaAdi.TabIndex = 1;
            this.lblFirmaAdi.Text = "...";
            // 
            // lblKod
            // 
            this.lblKod.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKod.Location = new System.Drawing.Point(5, 70);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(9, 13);
            this.lblKod.TabIndex = 1;
            this.lblKod.Text = "...";
            // 
            // yeniButton
            // 
            this.yeniButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.yeniButton.Appearance.Options.UseFont = true;
            this.yeniButton.Location = new System.Drawing.Point(118, 295);
            this.yeniButton.Name = "yeniButton";
            this.yeniButton.Size = new System.Drawing.Size(75, 23);
            this.yeniButton.TabIndex = 8;
            this.yeniButton.Text = "Yeni Kayıt";
            this.yeniButton.Click += new System.EventHandler(this.yeniButton_Click);
            // 
            // kaydetButton
            // 
            this.kaydetButton.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.kaydetButton.Appearance.Options.UseFont = true;
            this.kaydetButton.Location = new System.Drawing.Point(199, 295);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(75, 23);
            this.kaydetButton.TabIndex = 7;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(280, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 448);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            this.splitterControl1.DoubleClick += new System.EventHandler(this.splitterControl1_DoubleClick);
            // 
            // xFrmFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 448);
            this.Controls.Add(this.firmaGridControl);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.firmaGroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xFrmFirma";
            this.Text = "Firma Tanımla";
            this.Load += new System.EventHandler(this.xFrmFirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaGroupControl)).EndInit();
            this.firmaGroupControl.ResumeLayout(false);
            this.firmaGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clcPeriod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl firmaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView firmaGridView;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKod;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkili;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriod;
        private DevExpress.XtraEditors.GroupControl firmaGroupControl;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtYetkili;
        private DevExpress.XtraEditors.TextEdit txtFirmaAdi;
        private DevExpress.XtraEditors.TextEdit txtKod;
        private DevExpress.XtraEditors.LabelControl lblPeriod;
        private DevExpress.XtraEditors.LabelControl lblAdres;
        private DevExpress.XtraEditors.LabelControl lblMail;
        private DevExpress.XtraEditors.LabelControl lblTelefon;
        private DevExpress.XtraEditors.LabelControl lblYetkili;
        private DevExpress.XtraEditors.LabelControl lblFirmaAdi;
        private DevExpress.XtraEditors.LabelControl lblKod;
        private DevExpress.XtraEditors.SimpleButton kaydetButton;
        private DevExpress.XtraEditors.CalcEdit clcPeriod;
        private DevExpress.XtraEditors.SimpleButton yeniButton;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
    }
}