using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LD5_gynimas
{
    public partial class Form1 : Form
    {

        string vardas = "";
        string numeris = "";
        int metai;
        int menesis;
        int diena;

        int metaid = 2017;
        int menesisd = 5;
        int dienad = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            vardas = textBox4.Text;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            numeris = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            metai = Convert.ToInt32(textBox6.Text);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            menesis = Convert.ToInt32(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            diena = Convert.ToInt32(textBox8.Text);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = vardas;
            label3.Text = numeris;
            label4.Text = metai + "-" + menesis + "-" + diena;

            metaid = metaid - metai;
            menesisd = metaid * 12;
            dienad = metaid * 365;

            string metaiP = metaid.ToString();
            string menesisP = menesisd.ToString();
            string dienaP = dienad.ToString();

            label11.Text = metaiP;
            label12.Text = menesisP;
            label13.Text = dienaP;
        }

    }
}
