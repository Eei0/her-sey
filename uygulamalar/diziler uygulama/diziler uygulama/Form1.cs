using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] notlar = new int[40];


        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = ((gecen*100)/notlar.Length).ToString(); 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
            for (int i = 0; i < notlar.Length; i++)
            {
                listBox1.Items.Add(notlar[i]);
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < notlar.Length; i++)
            {
                notlar[i] = random.Next(101);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i]<50)
                {
                    listBox1.Items.Add(notlar[i]);
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i]<85 && notlar[i]>70)
                {
                    listBox1.Items.Add(notlar[i]);
                }  
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int ort = 0;
            for (int i = 0;i < notlar.Length; i++)
            {
                ort += notlar.Length; 
            }
            label1.Text = (ort/notlar.Length).ToString();
        } 

        private void btn5_Click(object sender, EventArgs e)
        {
            int high = notlar[0];
            for(int i = 0;i<notlar.Length ; i++)
            {
                if (high<notlar[i])
                {
                    high = notlar[i];
                }
            }   
            label1.Text= high.ToString();
            

            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int low = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (low > notlar[i])
                {
                    low = notlar[i];
                }
            }
            label1.Text = low.ToString();

        }
        int gecen = 0;
        private void btn7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i]>=50)
                {
                    gecen++;
                }
            }
            label1.Text = gecen.ToString();
        }

        int kalan =0;
        private void btn8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < 50)
                {
                    kalan++;
                }
            }
            label1.Text = kalan.ToString();
        }
    }
}
