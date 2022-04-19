using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansör_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 3.Kat butonuna basıldığında tüm katların
        // arkaplan rengi transparan oluyor ve kat numarasına 3 yazılıyor
        // sonra yanında kırmızı rengi çıkıyor
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "3";
            label4.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
        }

        // 1.Kat butonuna basıldığında tüm katların
        // arkaplan rengi transparan oluyor ve kat numarasına 1 yazılıyor
        // sonra yanında kırmızı rengi çıkıyor
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "1";
            label6.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
        }

        // Zemin butonuna basıldığında tüm katların
        // arkaplan rengi transparan oluyor ve kat numarasına 0 yazılıyor
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "0";
            label4.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label8.Text == "0")
            {
                // asansörü bulunduğu konumdan 0 katına indirmek için
                // bulunduğu konumda y ekseninde 5 piksel olarak 645 piksele
                // kadar yükseltiyoruz
                pictureBox1.Top += 5;
                if (pictureBox1.Location.Y >= 645)
                {
                    timer1.Stop();
                }
            }

            else if (label8.Text == "1")
            {
                // asansörü bulunduğu konumdan 1 katına çıkarmak için
                // bulunduğu konumda y ekseninde 5 piksel olarak 460 piksele
                // kadar düşürüyoruz
                pictureBox1.Top -= 5;
                if (pictureBox1.Location.Y <= 460)
                {
                    timer1.Stop();
                    label4.BackColor = Color.Red;
                }
            }
            else if (label8.Text == "2")
            {
                // asansörü bulunduğu konumdan 2 katına çıkarmak için
                // bulunduğu konumda y ekseninde 5 piksel olarak 285 piksele
                // kadar düşürüyoruz
                pictureBox1.Top -= 5;
                if (pictureBox1.Location.Y <= 285)
                {
                    timer1.Stop();
                    label11.BackColor = Color.Red;
                }
            }

            else if (label8.Text == "3")
            {
                // asansörü bulunduğu konumdan 3 katına çıkarmak için
                // bulunduğu konumda y ekseninde 5 piksel olarak 110 piksele
                // kadar düşürüyoruz
                pictureBox1.Top -= 5;
                if (pictureBox1.Location.Y <= 110)
                {
                    timer1.Stop();
                    label6.BackColor = Color.Red;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 2.Kat butonuna basıldığında tüm katların
        // arkaplan rengi transparan oluyor ve kat numarasına 2 yazılıyor
        // sonra yanında kırmızı rengi çıkıyor
        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "2";
            label4.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
        }
    }
}
