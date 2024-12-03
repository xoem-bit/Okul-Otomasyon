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
    public partial class Form2OGRETMENLER : Form
    {
        public Form2OGRETMENLER()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_OGRETMEN", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void ilekle()
        {
            SqlCommand komut = new SqlCommand("select * from tbl_il", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void bransgetir()
        {
            SqlCommand komut = new SqlCommand("select * from TBL_BRANS", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtID.Text = "";
            txtAD.Text = "";
            txtSoyad.Text = "";
            mskTc.Text = "";
            mskTel.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            cmbBrans.Text = "";
            txtMail.Text = "";
            rchAdres.Text = "";
            pictureBox1.ImageLocation = "";
        }


        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            cmbilce.Text = "";

            SqlCommand komut = new SqlCommand("Select * from tbl_ilce where il_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void Form2OGRETMENLER_Load(object sender, EventArgs e)
        {
            listele();
            ilekle();
            temizle();
            bransgetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRETMEN (OGRTAD,OGRTSOYAD,OGRTTC,OGRTTEL,OGRTMAIL,OGRTIL,OGRTILCE,OGRTADRES,OGRTBRANS,OGRTFOTO) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTc.Text);
            komut.Parameters.AddWithValue("@p4", mskTel.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", rchAdres.Text);
            komut.Parameters.AddWithValue("@p9", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRTID"].ToString();
                txtAD.Text = dr["OGRTAD"].ToString();
                txtSoyad.Text = dr["OGRTSOYAD"].ToString();
                mskTc.Text = dr["OGRTTC"].ToString();
                mskTel.Text = dr["OGRTTEL"].ToString();
                cmbil.Text = dr["OGRTIL"].ToString();
                cmbilce.Text = dr["OGRTILCE"].ToString();
                cmbBrans.Text = dr["OGRTBRANS"].ToString();
                txtMail.Text = dr["OGRTMAIL"].ToString();
                rchAdres.Text = dr["OGRTADRES"].ToString();
                yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pictureBox1.ImageLocation = yeniyol;
            }
        }

        public string yeniyol;

        private void btnResım_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim dosyası |*.jpg;*png;*nef | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureBox1.ImageLocation = yeniyol;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRETMEN set OGRTAD=@p1,OGRTSOYAD=@p2,OGRTTC=@p3,OGRTTEL=@p4,OGRTMAIL=@p5,OGRTIL=@p6,OGRTILCE=@p7,OGRTADRES=@p8,OGRTBRANS=@p9,OGRTFOTO=@p10 where OGRTID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTc.Text);
            komut.Parameters.AddWithValue("@p4", mskTel.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", rchAdres.Text);
            komut.Parameters.AddWithValue("@p9", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p11", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_OGRETMEN where OGRTID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p11", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
