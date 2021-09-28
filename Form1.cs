using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saat_Dakika_hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //once sayı1 ısmınde deger atıyoruz
            int sayi1;
            //neyi hesaplıyoruz..
            int saat, dakika;
            //ve sayı1 convert edıyoruz
            sayi1 = Convert.ToInt32(textBox1.Text);

           //sayı1 işlem gırıyoruz
            saat = sayi1 / 60;
            //nereye neyi nasıl yazdırıyoruz
            label2.Text = saat.ToString();

            dakika = sayi1 % 60;
            label4.Text = dakika.ToString();
        }
    }
}
