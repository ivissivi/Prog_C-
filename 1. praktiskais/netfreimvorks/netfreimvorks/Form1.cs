using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netfreimvorks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {

            string text1 = textBox1.Text;
            string text2 = textBox3.Text;

            int numbers1 = 0;
            int letters1 = 0;
            int chars1 = 0;

            int numbers2 = 0;
            int letters2 = 0;
            int chars2 = 0;

            label1.Text = text1;
            label2.Text = text2;

            label3.Text = text1.GetHashCode().ToString();
            label4.Text = text2.GetHashCode().ToString();

            foreach (char value in text1)
            {
                if (Char.IsDigit(value))
                {
                    numbers1++;
                    chars1++;
                }
                else if (Char.IsLetter(value))
                {
                    letters1++;
                    chars1++;
                }
                else
                {
                    chars1++;
                }
            }

            label12.Text = numbers1.ToString();
            label15.Text = letters1.ToString();
            label18.Text = chars1.ToString();

            foreach (char value in text2)
            {
                if (Char.IsDigit(value))
                {
                    numbers2++;
                    chars2++;
                }
                else if (Char.IsLetter(value))
                {
                    letters2++;
                    chars2++;
                }
                else
                {
                    chars2++;
                }
            }

            label13.Text = numbers2.ToString();
            label16.Text = letters2.ToString();
            label19.Text = chars2.ToString();

            if (numbers2 > 0 && chars2 > 8)
            {
                label21.Text = "Der";
                label22.Text = "";
            }
            else
            {
                label21.Text = "Neder";
                label22.Text = "Password must contain at least 1 number and 8 characters";
            }
            }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
