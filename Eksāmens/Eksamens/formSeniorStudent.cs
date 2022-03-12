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
    public partial class formSeniorStudent : Form
    {
        public formSeniorStudent()
        {
            InitializeComponent();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentList studentList = new studentList();
            studentList.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formMain = new Form1();
            formMain.Show();
        }
    }
}
