using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalkOtobüsüBiletUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       Bus bus;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bus = new Bus(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label3.Text = "Otobüs Hazır";
                groupBox1.Enabled = true;
            }
            catch 
            {

                MessageBox.Show("Otobüs tanımlanırken hata oluştu !!");
                label3.Text = "Hata! Otobüs Hazır Değil";

            }
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Bakiye=" + bus.viewBalance().ToString() + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bus != null)
            {
                bus.passengersAdd(true);
                label3.Text = "Tam Bilet Kesildi";
            }
            else
            {
                MessageBox.Show("Null Hatası");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (bus != null)
            {
                bus.passengersAdd(false);
                label3.Text = "Öğrenci Bilet Kesildi";
            }
            else
            {
                MessageBox.Show("Null Hatası");

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (bus != null)
            {
                bus.takeOutPassengerfrombus();
                label3.Text = "Bir Yolcu İndirildi";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Boş Koltuk Sayısı=" + bus.viewEmptySeat().ToString();
        }
    }
}
