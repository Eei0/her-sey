using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void islem()
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox2.Text);
            int sonuc = a * b;
            MessageBox.Show(sonuc.ToString());
        }

        void islem2(string ast, string bst)
        {
            int a = Convert.ToInt16(ast);
            int b = Convert.ToInt16(bst);
            int sonuc = a + b;
            MessageBox.Show(sonuc.ToString());
        }

        void islem3(string sy1, string sy2, string tr)
        {
            int s1 = Convert.ToInt16(sy1);
            int s2 = Convert.ToInt16(sy2);

            int sonuc = 0;
            if ("-" == tr) sonuc = s1 - s2;
            if ("+" == tr) sonuc = s1 + s2;
            if ("*" == tr) sonuc = s1 * s2;
            if ("/" == tr) sonuc = s1 / s2;
            MessageBox.Show(sonuc.ToString());



        }
        int islem4(string sy1, string sy2, string tr)
        {
            int s1 = Convert.ToInt16(sy1);
            int s2 = Convert.ToInt16(sy2);
            if ("-" == tr) return  s1 - s2;
            if ("+" == tr) return  s1 + s2;
            if ("*" == tr) return s1 * s2;
            if ("/" == tr) return s1 / s2;
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(islem4(textBox1.Text  ,textBox2.Text , textBox3.Text).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            islem3(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            islem2(textBox1.Text, textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
