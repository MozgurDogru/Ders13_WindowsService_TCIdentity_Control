using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders13_WindowsService_TCkimlik_Kontrol
{
    public partial class TcKimlikSorgulama : Form
    {
        public TcKimlikSorgulama()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            tcno.KPSPublicSoapClient t = new tcno.KPSPublicSoapClient();
            bool answer = t.TCKimlikNoDogrula(Convert.ToInt64(txt_tckimlik.Text), txt_isim.Text.ToUpper(), txt_Soyisim.Text.ToUpper(), Convert.ToInt32(txt_doğum.Text));

            if (answer == true)
            {
                //Formdaki verileri veri tabanına kaydet
                MessageBox.Show("bilgiler doğru");
            }
            else
            {
                MessageBox.Show("isim,soyisim,doğum yılı,tc no alanlarını tekrar kontrol ediniz");
            }
        }

        private void txt_doğum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
