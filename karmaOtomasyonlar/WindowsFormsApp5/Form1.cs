using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt16(textBox1.Text);
            if(yas>=18 && checkBox1.Checked)
            {
                label2.Text = "Askere Gidebilir";
            }
            else
            {
                label2.Text = "Askere Gidemez";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox2.Text);
            int s2 = Convert.ToInt32(textBox3.Text);
            if (s1 > s2)
            {
                label5.Text = "1. Sayı Büyük";
            }
            else if(s1<s2)

            {
                label5.Text = "2. Sayı Büyük";
            }
            else
            {
                label5.Text = "Sayılar Eşit";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox5.Text);
         
            if (s1 % 2 == 0)
            {
                label6.Text = "Girilen Sayı Çift Sayıdır.";
            }
           
            else
            {
                label6.Text = "Girilen Sayı Tek Sayıdır.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (checkBox3.Checked && checkBox4.Checked)
            {
                listBox1.Items.Add("Klima Açık");
                listBox1.Items.Add("Lambalar Açık");
            }
            else if(checkBox3.Checked)
                {
                listBox1.Items.Add("Klima Açık");
            }
            else
            {
                listBox1.Items.Add("Lamba Açık");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int para = Convert.ToInt16(textBox7.Text)
        }
    }
}
