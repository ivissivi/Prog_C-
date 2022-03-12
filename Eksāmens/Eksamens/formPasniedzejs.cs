using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Eksamens
{
    public partial class formPasniedzejs : Form
    {
        public formPasniedzejs()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtLastName.Text != "")
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ivis3\source\repos\Eksamens\data_base\ivars_sloka.accdb";

                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Studenti (Vards, Uzvards, Studenta_kods) VALUES (@name, @lastName, @studentCode)";
                    cmd.Parameters.AddWithValue("@name", OleDbType.Char).Value = txtName.Text;
                    cmd.Parameters.AddWithValue("@lastName", OleDbType.Char).Value = txtLastName.Text;
                    cmd.Parameters.AddWithValue("@studentCode", OleDbType.Char).Value = txtStudentCode.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student with a code: " + txtStudentCode.Text + " has been added");

                    txtName.Text = "";
                    txtLastName.Text = "";
                    txtStudentCode.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                MessageBox.Show("Fields are empty!");
            }
        }

        private void lblStudentCode_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStudent_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentList studentList = new studentList();
            studentList.Show();
        }

        private void btnCourseList_Click(object sender, EventArgs e)
        {
            this.Hide();
            courseList courseList = new courseList();
            courseList.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formMain = new Form1();
            formMain.Show();
        }
    }
}
