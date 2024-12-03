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
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("execute OgrenciVeli5", bgl.baglanti());
            da1.Fill(dt1);
            grdctrl5.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("execute OgrenciVeli6", bgl.baglanti());
            da2.Fill(dt2);
            grdctrl6.DataSource = dt2;

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("execute OgrenciVeli7", bgl.baglanti());
            da3.Fill(dt3);
            grdctrl7.DataSource = dt3;

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("execute OgrenciVeli8", bgl.baglanti());
            da4.Fill(dt4);
            grdctrl8.DataSource = dt4;
        }

        void velilistesi()
        { 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select VELIID,(VELIANNE+' | ' +VELIBABA) as 'VELIANNEBABA' from TBL_VELILER", bgl.baglanti());
            da.Fill(dt);
            lookUpVeli.Properties.ValueMember = "VELIID";
            lookUpVeli.Properties.DisplayMember = "VELIANNEBABA";
            lookUpVeli.Properties.DataSource = dt;
        }

        void sehirekle()
        {
            SqlCommand komut = new SqlCommand("select * from tbl_il", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }


        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            listele();
            sehirekle();
            velilistesi();
            temizle();
        }

        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            cmbilce.Text = "";

            SqlCommand komut = new SqlCommand("select * from tbl_ilce where il_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtAD.Text = dr["OGRAD"].ToString();
                txtSoyad.Text = dr["OGRSOYAD"].ToString();
                mskTC.Text = dr["OGRTC"].ToString();
                mskOgrenciNo.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    rdbtnErkek.Checked = true;
                }
                else
                {
                    rdbtnKadın.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dtedDogtarih.Text = dr["OGRDOGTAR"].ToString();
                rchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpVeli.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        public string cinsiyet;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRENCILER (OGRAD,OGRSOYAD,OGRTC,OGRNO,OGRSINIF,OGRDOGTAR,OGRCINSIYET,OGRIL,OGRILCE,OGRADRES,OGRFOTO,OGRVELIID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p5", cmbsinif.Text);
            komut.Parameters.AddWithValue("@p6", dtedDogtarih.Text);

            if (rdbtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "K");
            }

            komut.Parameters.AddWithValue("@p8", cmbil.Text);
            komut.Parameters.AddWithValue("@p9", cmbilce.Text);
            komut.Parameters.AddWithValue("@p10", rchAdres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", lookUpVeli.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtAD.Text = dr["OGRAD"].ToString();
                txtSoyad.Text = dr["OGRSOYAD"].ToString();
                mskTC.Text = dr["OGRTC"].ToString();
                mskOgrenciNo.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    rdbtnErkek.Checked = true;
                }
                else
                {
                    rdbtnKadın.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dtedDogtarih.Text = dr["OGRDOGTAR"].ToString();
                rchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpVeli.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);

            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtAD.Text = dr["OGRAD"].ToString();
                txtSoyad.Text = dr["OGRSOYAD"].ToString();
                mskTC.Text = dr["OGRTC"].ToString();
                mskOgrenciNo.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    rdbtnErkek.Checked = true;
                }
                else
                {
                    rdbtnKadın.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dtedDogtarih.Text = dr["OGRDOGTAR"].ToString();
                rchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpVeli.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);

            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtAD.Text = dr["OGRAD"].ToString();
                txtSoyad.Text = dr["OGRSOYAD"].ToString();
                mskTC.Text = dr["OGRTC"].ToString();
                mskOgrenciNo.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    rdbtnErkek.Checked = true;
                }
                else
                {
                    rdbtnKadın.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dtedDogtarih.Text = dr["OGRDOGTAR"].ToString();
                rchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpVeli.Text = dr["VELIANNEBABA"].ToString();
            }

        }
        
        void temizle()
        {
            txtID.Text = "";
            txtAD.Text = "";
            txtSoyad.Text = "";
            mskTC.Text = "";
            mskOgrenciNo.Text = "";
            cmbsinif.Text = "";
            rdbtnErkek.Checked = false;
            rdbtnKadın.Checked = false;
            cmbil.Text = "";
            cmbilce.Text = "";
            dtedDogtarih.Text = "";
            rchAdres.Text = "";
            pictureEdit1.Text = "";
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
            pictureEdit1.Image = Image.FromFile(yeniyol);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRENCILER set OGRAD=@p1,OGRSOYAD=@p2,OGRTC=@p3,OGRNO=@p4,OGRSINIF=@p5,OGRDOGTAR=@p6,OGRCINSIYET=@p7,OGRIL=@p8,OGRILCE=@p9,OGRADRES=@p10,OGRFOTO=@p11,OGRVELIID=@p13 where OGRID=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p5", cmbsinif.Text);
            komut.Parameters.AddWithValue("@p6", dtedDogtarih.Text);

            if (rdbtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "K");
            }

            komut.Parameters.AddWithValue("@p8", cmbil.Text);
            komut.Parameters.AddWithValue("@p9", cmbilce.Text);
            komut.Parameters.AddWithValue("@p10", rchAdres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", txtID.Text);
            komut.Parameters.AddWithValue("@p13", lookUpVeli.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_OGRENCILER where OGRID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\Excalibur\\Desktop\\Efe 1\\Efe 1\\" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }
    }

}