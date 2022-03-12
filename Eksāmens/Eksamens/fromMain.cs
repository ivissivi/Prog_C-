using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPasniedzejam_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPasniedzejs formPasniedzejs = new formPasniedzejs();
            formPasniedzejs.Show();
        }

        private void btnSeniorStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSeniorStudent formSeniorStudent = new formSeniorStudent();
            formSeniorStudent.Show();
        }
    }
}
