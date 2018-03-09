using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        string secim;
        public Form1()
        {
            InitializeComponent();
        }
        public string islem = String.Empty;
        public double sayi1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "+";
            secim = "+";
            textBox1.ResetText();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "-";
            secim = "-";
            textBox1.ResetText();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "*";
            secim = "*";
            textBox1.ResetText();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "/";
            secim = "/";
            textBox1.ResetText();
        }
        private void Ekle(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text += button13.Text;
            textBox1.ResetText();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            {
                double sayi2 = Convert.ToDouble(textBox1.Text);  //İkinci sayıyı tanımlıyoruz.
                double sonuc = 0;
                switch (secim)           //Burada switch case yöntemiyle toplama, çıkarma, çarpma, bölme işlemlerini   tanımlıyoruz.    
                {
                    case "+":
                            sonuc = sayi1 + sayi2;
                     break;
                    case "-":
                            sonuc = sayi1 - sayi2;
                        break;
                    case "*":
                            sonuc = sayi1 * sayi2;
                        break;
                    case "/":
                            sonuc = sayi1 / sayi2;
                        break;

                    default:
                        MessageBox.Show("İşlem seçmelisiniz!", "Hata");  //Herhangi bir işlem yapılmadan “=” basıldığında çıkacak uyarı.
                        break;
                }
                textBox1.Text = (sayi1+secim+sayi2+"="+sonuc.ToString());                 //Sonuç yazısının gözüktüğü yer.
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                int sayi1 = Convert.ToInt32(this.textBox1.Text);
                double sonuc = sayi1 * sayi1;                                                   //Karesini alma kodu   Karesi
                textBox1.Text = sonuc.ToString();
            }
        }
    }

        
    }
