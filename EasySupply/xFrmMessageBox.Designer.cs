namespace EasySupply
{
    partial class xFrmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFrmMessageBox));
            this.NoButton = new DevExpress.XtraEditors.SimpleButton();
            this.YesButton = new DevExpress.XtraEditors.SimpleButton();
            this.YesPictureBox = new System.Windows.Forms.PictureBox();
            this.NoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.YesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NoButton
            // 
            this.NoButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.NoButton.Appearance.Options.UseFont = true;
            this.NoButton.Appearance.Options.UseTextOptions = true;
            this.NoButton.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NoButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NoButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NoButton.Location = new System.Drawing.Point(201, 126);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(180, 42);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "...";
            this.NoButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.YesButton.Appearance.Options.UseFont = true;
            this.YesButton.Appearance.Options.UseTextOptions = true;
            this.YesButton.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.YesButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.YesButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.YesButton.Location = new System.Drawing.Point(9, 126);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(182, 42);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "...";
            this.YesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // YesPictureBox
            // 
            this.YesPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YesPictureBox.Location = new System.Drawing.Point(9, 11);
            this.YesPictureBox.Name = "YesPictureBox";
            this.YesPictureBox.Size = new System.Drawing.Size(182, 111);
            this.YesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.YesPictureBox.TabIndex = 0;
            this.YesPictureBox.TabStop = false;
            // 
            // NoPictureBox
            // 
            this.NoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoPictureBox.Location = new System.Drawing.Point(201, 11);
            this.NoPictureBox.Name = "NoPictureBox";
            this.NoPictureBox.Size = new System.Drawing.Size(182, 111);
            this.NoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NoPictureBox.TabIndex = 0;
            this.NoPictureBox.TabStop = false;
            // 
            // xFrmMessageBox
            // 
            this.AcceptButton = this.YesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 181);
            this.ControlBox = false;
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesPictureBox);
            this.Controls.Add(this.NoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 215);
            this.Name = "xFrmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.Load += new System.EventHandler(this.xFrmMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NoPictureBox;
        private System.Windows.Forms.PictureBox YesPictureBox;
        private DevExpress.XtraEditors.SimpleButton NoButton;
        private DevExpress.XtraEditors.SimpleButton YesButton;
    }
}