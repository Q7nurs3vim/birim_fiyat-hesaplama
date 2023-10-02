using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ürün_satısV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            int fiyat, miktar, tutar;
            fiyat= Convert.ToInt32(txt1.Text);
            miktar= Convert.ToInt32(txt2.Text);
            tutar =fiyat* miktar;
            lblTutar.Text= "TUTAR:" + tutar.ToString();

        }
    }
}
