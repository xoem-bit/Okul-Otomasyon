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

namespace Efe_1
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        OkulOtomasyonEntities db = new OkulOtomasyonEntities();

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMEN on TBL_AYARLAR.AYARLARID=TBL_OGRETMEN.OGRTID where OGRTTC=@p1 and OGRTSIFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C. veya Şifre");
                mskTc.Text = "";
                txtSifre.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMEN on TBL_AYARLAR.AYARLARID=TBL_OGRETMEN.OGRTID where OGRTTC=@p1 and OGRTSIFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmen frm2 = new FrmOgretmen();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C. veya Şifre");
                mskTc.Text = "";
                txtSifre.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBL_OGRAYARLAR
                        join d2 in db.TBL_OGRENCILER
                        on d1.AYARLAROGRID equals d2.OGRID
                        where d2.OGRTC == mskTc.Text &&
                              d1.OGRSIFRE == txtSifre.Text
                        select new { };
            if (sorgu.Any())
            {
                FrmOgrencı frm3 = new FrmOgrencı();
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C. veya Şifre");
                mskTc.Text = "";
                txtSifre.Text = "";
            }
        }
    }
}
