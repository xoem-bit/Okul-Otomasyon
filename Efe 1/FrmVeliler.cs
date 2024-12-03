using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efe_1
{
    public partial class FrmVeliler : Form
    {
        public FrmVeliler()
        {
            InitializeComponent();
        }

        OkulOtomasyonEntities db = new OkulOtomasyonEntities();

        void listele()
        {
            var liste = from item in db.TBL_VELILER select new { item.VELIID, item.VELIANNE, item.VELIBABA, item.VELITEL1, item.VELITEL2, item.VELIMAIL };

            gridControl1.DataSource = liste.ToList();           
        }
        void temizle()
        {
            txtID.Text = "";
            txtAnneAd.Text = "";
            txtBabaAd.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            txtMail.Text = "";
        }

        private void FrmVeliler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //TBL_VELILER veli = new TBL_VELILER();
            //veli.VELIANNE = txtAnneAd.Text;
            //veli.VELIBABA = txtBabaAd.Text;
            //veli.VELITEL1 = mskTel1.Text;
            //veli.VELITEL2 = mskTel2.Text;
            //veli.VELIMAIL = txtMail.Text;
            //db.TBL_VELILER.Add(veli);
            //db.SaveChanges();
            //MessageBox.Show("Veli Bilgileri Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //listele();
            using (OkulOtomasyonEntities db = new OkulOtomasyonEntities())
            {
                TBL_VELILER veli = new TBL_VELILER();
                veli.VELIANNE = txtAnneAd.Text;
                veli.VELIBABA = txtBabaAd.Text;
                veli.VELITEL1 = mskTel1.Text;
                veli.VELITEL2 = mskTel2.Text;
                veli.VELIMAIL = txtMail.Text;
                db.TBL_VELILER.Add(veli);
                db.SaveChanges();
                listele();
            }
            MessageBox.Show("Veli Bilgileri Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            txtID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString();
            txtAnneAd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIANNE").ToString();
            txtBabaAd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIBABA").ToString();
            mskTel1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL1").ToString();
            mskTel2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL2").ToString();
            txtMail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIMAIL").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            //var item = db.TBL_VELILER.Find(id);
            //item.VELIANNE = txtAnneAd.Text;
            //item.VELIBABA = txtBabaAd.Text;
            //item.VELITEL1 = mskTel1.Text;
            //item.VELITEL2 = mskTel2.Text;
            //item.VELIMAIL = txtMail.Text;
            //db.SaveChanges();            
            //listele();
            using (OkulOtomasyonEntities db = new OkulOtomasyonEntities())
            {
                var item = db.TBL_VELILER.FirstOrDefault(x => x.VELIID == id);
                item.VELIANNE = txtAnneAd.Text;
                item.VELIBABA = txtBabaAd.Text;
                item.VELITEL1 = mskTel1.Text;
                item.VELITEL2 = mskTel2.Text;
                item.VELIMAIL = txtMail.Text;
                db.SaveChanges();
                listele();
                temizle();
            }
            MessageBox.Show("Veli Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            //var item = db.TBL_VELILER.Find(id);
            //db.TBL_VELILER.Remove(item);
            //db.SaveChanges();
            //listele();
            using (OkulOtomasyonEntities db = new OkulOtomasyonEntities())
            {
                var item = db.TBL_VELILER.FirstOrDefault(x => x.VELIID == id);
                db.TBL_VELILER.Remove(item);
                db.SaveChanges();
                listele();
                temizle();
            }
            MessageBox.Show("Veli Bilgisi Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
