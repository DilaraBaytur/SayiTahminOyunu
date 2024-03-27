using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int sayi, skor;
        int tahmin;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tahmin = int.Parse(textBox1.Text);
                if (tahmin<sayi)
                {
                    MessageBox.Show("Daha Büyük Bir Sayı Tahmin Ediniz");
                    skor -= 10;
                }
                else if (tahmin > sayi)
                {
                    MessageBox.Show("Daha KüçüK Bir Sayı Tahmin Ediniz");
                    skor -= 10;

                }
                else
                {
                    MessageBox.Show("Tebrikler Doğru Bildiniz");
                    button1.Enabled = true;
                    button2.Enabled = false;
                }

                if (skor==0)
                {
                    MessageBox.Show("Hakkınız Bitti");
                    button1.Enabled = true;
                    button2.Enabled = false;
                }

                label1.Text = "Skor : " + skor;
                textBox1.Clear();
            }
            catch 
            {

                MessageBox.Show("Doğru Bir Değer Giriniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skor = 100;
            label1.Text = "Skor : " + skor;
            Random rastgele = new Random();
            sayi= rastgele.Next(0,101);
            MessageBox.Show("Rastgele Sayı Üretildi");
            button1.Enabled = false;
            button2.Enabled = true ;
        }
    }
}
