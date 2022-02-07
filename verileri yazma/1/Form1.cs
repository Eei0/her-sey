using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string a = textBox1.Text;
            int b = Convert.ToInt32(textBox2.Text);
            string c = comboBox1.Text;
            label1.Text = a;
            label2.Text=b.ToString();
            label3.Text = c;
            FileStream fw;
            StreamWriter sw;
            fw = new FileStream(@"C:\Users\eeisc\Desktop\c#\1\1\Bilgiler.txt", FileMode.Append,FileAccess.Write);
            sw = new StreamWriter(fw);
            sw.WriteLine(a);
            sw.WriteLine(Convert.ToString(b));
            sw.WriteLine(c);
            sw.WriteLine("----------------");
            sw.Close();
            fw.Close();
            MessageBox.Show("kayıt başarılı");
            Close();





        }
    }
}
