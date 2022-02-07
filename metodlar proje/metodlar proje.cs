using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string copy(string klm, int sy1, int sy2)
        {
            
            string kopya = klm.Substring(sy1 - 1, sy2);
            return kopya;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(copy(textBox1.Text, Convert.ToInt16(tex), textBox3.Text));
        }
    }
}

