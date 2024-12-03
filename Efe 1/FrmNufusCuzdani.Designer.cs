namespace Efe_1
{
    partial class FrmNufusCuzdani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNufusCuzdani));
            this.lblTC = new DevExpress.XtraEditors.LabelControl();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.lblAD = new DevExpress.XtraEditors.LabelControl();
            this.lblDogtar = new DevExpress.XtraEditors.LabelControl();
            this.lblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Appearance.Options.UseFont = true;
            this.lblTC.Location = new System.Drawing.Point(51, 147);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(110, 19);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "labelControl1";
            // 
            // lblSoyad
            // 
            this.lblSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Appearance.Options.UseFont = true;
            this.lblSoyad.Location = new System.Drawing.Point(261, 147);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(110, 19);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "labelControl2";
            // 
            // lblAD
            // 
            this.lblAD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAD.Appearance.Options.UseFont = true;
            this.lblAD.Location = new System.Drawing.Point(261, 210);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(110, 19);
            this.lblAD.TabIndex = 2;
            this.lblAD.Text = "labelControl3";
            // 
            // lblDogtar
            // 
            this.lblDogtar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogtar.Appearance.Options.UseFont = true;
            this.lblDogtar.Location = new System.Drawing.Point(261, 275);
            this.lblDogtar.Name = "lblDogtar";
            this.lblDogtar.Size = new System.Drawing.Size(110, 19);
            this.lblDogtar.TabIndex = 3;
            this.lblDogtar.Text = "labelControl4";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Appearance.Options.UseFont = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(459, 275);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(110, 19);
            this.lblCinsiyet.TabIndex = 4;
            this.lblCinsiyet.Text = "labelControl5";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.Location = new System.Drawing.Point(35, 172);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(196, 222);
            this.pictureEdit1.TabIndex = 5;
            // 
            // FrmNufusCuzdani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 459);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblDogtar);
            this.Controls.Add(this.lblAD);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblTC);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmNufusCuzdani";
            this.Text = "FrmNufusCuzdani";
            this.Load += new System.EventHandler(this.FrmNufusCuzdani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTC;
        private DevExpress.XtraEditors.LabelControl lblSoyad;
        private DevExpress.XtraEditors.LabelControl lblAD;
        private DevExpress.XtraEditors.LabelControl lblDogtar;
        private DevExpress.XtraEditors.LabelControl lblCinsiyet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}