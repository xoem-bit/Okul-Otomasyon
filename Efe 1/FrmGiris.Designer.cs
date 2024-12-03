namespace Efe_1
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(82, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(729, 43);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Gülsüm Sami Kefeli Ortaokulu Giriş Paneli";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(640, 450);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(153, 32);
            this.txtSifre.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 451);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(119, 34);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kullanıcı:";
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(154, 451);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(140, 31);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(564, 448);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 34);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Şifre:";
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYonetici.BackgroundImage")));
            this.btnYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetici.Location = new System.Drawing.Point(138, 486);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(188, 120);
            this.btnYonetici.TabIndex = 5;
            this.btnYonetici.Text = "Yönetici";
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOgretmen.BackgroundImage")));
            this.btnOgretmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmen.Location = new System.Drawing.Point(347, 486);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(188, 120);
            this.btnOgretmen.TabIndex = 6;
            this.btnOgretmen.Text = "Öğretmen";
            this.btnOgretmen.UseVisualStyleBackColor = true;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenci.BackgroundImage")));
            this.btnOgrenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.Location = new System.Drawing.Point(605, 488);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(188, 118);
            this.btnOgrenci.TabIndex = 7;
            this.btnOgrenci.Text = "Öğrenci";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 644);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnOgretmen);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.Button btnOgrenci;
    }
}