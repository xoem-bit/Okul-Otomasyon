using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Efe_1
{
    public partial class FrmAyarlar2 : Form
    {
        public FrmAyarlar2()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        OkulOtomasyonEntities db = new OkulOtomasyonEntities();

        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("execute AyarlarOgretmenler", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;
        }

        void temizle()
        {
            txtOgrtID.Text = "";
            txtBrans.Text = "";
            txtOgrtSifre.Text = "";
            mskOgrtTC.Text = "";
            pictureEdit1.Text = "";
            lookUpEdit1.Properties.NullText = "Öğretmen Seçiniz";
            txtOgrID.Text = "";
            txtSinif.Text = "";
            mskOgrTC.Text = "";
            txtOgrSifre.Text = "";
            lookupOgr.Properties.NullText = "Öğrenci Seçiniz";
            pictureEdit2.Text = "";
        }

        void ogrlistele()
        {
            gridControl2.DataSource = db.AyarlarOgrenciler();
        }

        void ogretmenlistesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select OGRTID, (OGRTAD+' '+OGRTSOYAD) as 'OGRTADSOYAD',OGRTBRANS from TBL_OGRETMEN",bgl.baglanti());
            da2.Fill(dt2);
            lookUpEdit1.Properties.ValueMember = "OGRTID";
            lookUpEdit1.Properties.DisplayMember = "OGRTADSOYAD";
            lookUpEdit1.Properties.NullText = "Öğretmen Seçiniz";
            lookUpEdit1.Properties.DataSource = dt2;
        }

        void ogrencilistesi()
        {
            var deger = from item in db.TBL_OGRENCILER
                        select new
                        {
                            OGRID = item.OGRID,
                            OGRADSOYAD = item.OGRAD + " " + item.OGRSOYAD,
                            OGRSINIF = item.OGRSINIF,
                        };
            lookupOgr.Properties.ValueMember = "OGRID";
            lookupOgr.Properties.DisplayMember = "OGRADSOYAD";
            lookupOgr.Properties.NullText = "Öğrenci Seçiniz";
            lookupOgr.Properties.DataSource = deger.ToList();
        }

        private void FrmAyarlar2_Load(object sender, EventArgs e)
        {
            listele();
            ogretmenlistesi();
            ogrlistele();
            ogrencilistesi();
            temizle();
        }

        public string yeniyol;

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtOgrtID.Text = dr["AYARLARID"].ToString();
                lookUpEdit1.Text = dr["OGRTADSOYAD"].ToString();
                txtBrans.Text = dr["OGRTBRANS"].ToString();
                mskOgrtTC.Text = dr["OGRTTC"].ToString();
                txtOgrtSifre.Text = dr["OGRTSIFRE"].ToString();
                yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);

            }
        }

        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            txtOgrtSifre.Text = "";

            SqlCommand komut = new SqlCommand("Select * from TBL_OGRETMEN where OGRTID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookUpEdit1.ItemIndex + 1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                txtOgrtID.Text = dr3["OGRTID"].ToString();
                txtBrans.Text = dr3["OGRTBRANS"].ToString();
                mskOgrtTC.Text = dr3["OGRTTC"].ToString();
                yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr3["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
            bgl.baglanti().Close();
        }

        private void btnOgrtKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBL_AYARLAR (AYARLARID,OGRTSIFRE) values(@p1,@p2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtOgrtID.Text);
            komut2.Parameters.AddWithValue("@p2", txtOgrtSifre.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Şifre oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnOgrtGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update TBL_AYARLAR set OGRTSIFRE=@p1 where AYARLARID=@p2", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtOgrtSifre.Text);
            komut3.Parameters.AddWithValue("@p2", txtOgrtID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnOgrtSil_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            txtOgrID.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AYARLAROGRID").ToString();
            lookupOgr.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRADSOYAD").ToString();
            txtSinif.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRSINIF").ToString();
            mskOgrTC.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRTC").ToString();
            txtOgrSifre.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRSIFRE").ToString();
            string uzanti = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRFOTO").ToString();
            yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + uzanti;
            pictureEdit2.Image = Image.FromFile(yeniyol);
        }

        private void lookupOgr_Properties_EditValueChanged(object sender, EventArgs e)
        {
            txtOgrSifre.Text = "";
            using(OkulOtomasyonEntities db = new OkulOtomasyonEntities())
            {
                TBL_OGRENCILER sorgu = db.TBL_OGRENCILER.Find(lookupOgr.ItemIndex + 1);
                txtOgrID.Text = sorgu.OGRID.ToString();
                txtSinif.Text = sorgu.OGRSINIF;
                mskOgrTC.Text = sorgu.OGRTC;
                yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + sorgu.OGRFOTO;
                pictureEdit2.Image = Image.FromFile (yeniyol);
            }
        }

        private void btnOgrKaydet_Click(object sender, EventArgs e)
        {
            TBL_OGRAYARLAR komut = new TBL_OGRAYARLAR();
            komut.AYARLAROGRID = Convert.ToInt32(txtOgrID.Text);
            komut.OGRSIFRE = txtOgrSifre.Text;
            db.TBL_OGRAYARLAR.Add(komut);
            db.SaveChanges();
            MessageBox.Show("Şifre Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrlistele();
        }

        private void btnOgrGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AYARLAROGRID"));
            var item = db.TBL_OGRAYARLAR.FirstOrDefault(x => x.AYARLAROGRID == id);
            item.OGRSIFRE = txtOgrSifre.Text;
            db.SaveChanges();
            MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrlistele();
            temizle();
        }

        private void btnOgrSil_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
