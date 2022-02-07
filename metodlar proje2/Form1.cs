using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodlar_proje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void bütüntextboxlarıtemizle()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        void sayilar(string klms)
        {
            string sayilar = " ";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text.Substring(i, 1) == "1") sayilar = sayilar + "1";
                if (textBox1.Text.Substring(i, 1) == "2") sayilar = sayilar + "2";
                if (textBox1.Text.Substring(i, 1) == "3") sayilar = sayilar + "3";
                if (textBox1.Text.Substring(i, 1) == "4") sayilar = sayilar + "4";
                if (textBox1.Text.Substring(i, 1) == "5") sayilar = sayilar + "5";
                if (textBox1.Text.Substring(i, 1) == "6") sayilar = sayilar + "6";
                if (textBox1.Text.Substring(i, 1) == "7") sayilar = sayilar + "7";
                if (textBox1.Text.Substring(i, 1) == "8") sayilar = sayilar + "8";
                if (textBox1.Text.Substring(i, 1) == "9") sayilar = sayilar + "9";
                if (textBox1.Text.Substring(i, 1) == "0") sayilar = sayilar + "0";


            }
            MessageBox.Show(sayilar);

        }
        void temizle()
        {
            textBox1.Clear();

        }
        string kelimesy(string klm)
        {
            string[] kelimeler = klm.Split(' ');
            int klmsy = kelimeler.Length;
            return klmsy.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = kelimesy(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayilar(textBox1.Text);
        }
    }
}
