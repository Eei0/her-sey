using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_islemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            İSLEMLER isl = new İSLEMLER();
            MessageBox.Show(isl.topla(Convert.ToInt16(textBox1.Text),Convert.ToInt16(textBox2.Text)).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İSLEMLER isl = new İSLEMLER();
            MessageBox.Show(isl.cikar(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İSLEMLER isl = new İSLEMLER();
            MessageBox.Show(isl.carp(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            İSLEMLER isl = new İSLEMLER();
            MessageBox.Show(isl.bol(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)).ToString());
        }
    }
}
