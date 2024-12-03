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
    public partial class FrmNufusCuzdani : Form
    {
        public FrmNufusCuzdani()
        {
            InitializeComponent();
        }

        public string ad, soyad, tc, cinsiyet, dogtarihi, uzanti;

        private void FrmNufusCuzdani_Load(object sender, EventArgs e)
        {
            lblAD.Text = ad;
            lblSoyad.Text = soyad;
            lblTC.Text = tc;
            lblCinsiyet.Text = cinsiyet;    
            lblDogtar.Text = dogtarihi;
            pictureEdit1.Image = Image.FromFile(uzanti);
        }
    }



}
