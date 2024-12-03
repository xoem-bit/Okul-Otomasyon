namespace Efe_1
{
    partial class Form2OGRETMENLER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2OGRETMENLER));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.cmbBrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtAD = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnResım = new DevExpress.XtraEditors.SimpleButton();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1140, 735);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1147, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(291, 735);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(289, 691);
            this.xtraTabPage1.Text = "Öğretmen Bilgi-1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.mskTel);
            this.groupControl1.Controls.Add(this.mskTc);
            this.groupControl1.Controls.Add(this.cmbBrans);
            this.groupControl1.Controls.Add(this.cmbilce);
            this.groupControl1.Controls.Add(this.cmbil);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.txtAD);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(283, 685);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(87, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(69, 362);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(210, 27);
            this.mskTel.TabIndex = 20;
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(69, 333);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(210, 27);
            this.mskTc.TabIndex = 19;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // cmbBrans
            // 
            this.cmbBrans.EditValue = "";
            this.cmbBrans.Location = new System.Drawing.Point(69, 459);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBrans.Properties.Appearance.Options.UseFont = true;
            this.cmbBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBrans.Size = new System.Drawing.Size(209, 26);
            this.cmbBrans.TabIndex = 18;
            // 
            // cmbilce
            // 
            this.cmbilce.EditValue = "";
            this.cmbilce.Location = new System.Drawing.Point(69, 427);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbilce.Properties.Appearance.Options.UseFont = true;
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(209, 26);
            this.cmbilce.TabIndex = 17;
            // 
            // cmbil
            // 
            this.cmbil.EditValue = "";
            this.cmbil.Location = new System.Drawing.Point(69, 395);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbil.Properties.Appearance.Options.UseFont = true;
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(209, 26);
            this.cmbil.TabIndex = 16;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(69, 302);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Size = new System.Drawing.Size(209, 26);
            this.txtSoyad.TabIndex = 10;
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(69, 270);
            this.txtAD.Name = "txtAD";
            this.txtAD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAD.Properties.Appearance.Options.UseFont = true;
            this.txtAD.Size = new System.Drawing.Size(209, 26);
            this.txtAD.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(69, 238);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(209, 26);
            this.txtID.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 466);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 19);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Branş:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 402);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(16, 19);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "İl:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 370);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 19);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Telefon:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 434);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 19);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "İlçe:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 309);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Soyad:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 341);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "T.C.:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 277);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ad:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 245);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(289, 691);
            this.xtraTabPage2.Text = "Öğretmen Bilgi-2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnTemizle);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Controls.Add(this.btnKaydet);
            this.groupControl2.Controls.Add(this.btnResım);
            this.groupControl2.Controls.Add(this.rchAdres);
            this.groupControl2.Controls.Add(this.txtMail);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(283, 685);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(144, 452);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(131, 41);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(144, 405);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(131, 41);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(144, 358);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(131, 41);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(144, 311);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 41);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnResım
            // 
            this.btnResım.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResım.ImageOptions.Image")));
            this.btnResım.Location = new System.Drawing.Point(144, 264);
            this.btnResım.Name = "btnResım";
            this.btnResım.Size = new System.Drawing.Size(131, 41);
            this.btnResım.TabIndex = 14;
            this.btnResım.Text = "Resim Seç";
            this.btnResım.Click += new System.EventHandler(this.btnResım_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(66, 127);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(209, 131);
            this.rchAdres.TabIndex = 13;
            this.rchAdres.Text = "";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(66, 86);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(209, 26);
            this.txtMail.TabIndex = 12;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(13, 127);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 19);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Adres:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(26, 93);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(34, 19);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "Mail:";
            // 
            // Form2OGRETMENLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 748);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form2OGRETMENLER";
            this.Text = "Form2OGRETMENLER";
            this.Load += new System.EventHandler(this.Form2OGRETMENLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtAD;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBrans;
        private DevExpress.XtraEditors.ComboBoxEdit cmbilce;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnResım;
        private System.Windows.Forms.RichTextBox rchAdres;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}