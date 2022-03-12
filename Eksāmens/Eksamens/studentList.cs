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
    public partial class studentList : Form
    {
        public studentList()
        {
            InitializeComponent();
        }

        private void lblClientList_Click(object sender, EventArgs e)
        {

        }

        private void studentList_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ivis3\source\repos\Eksamens\data_base\ivars_sloka.accdb";

            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Studenti";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem studentRow = new ListViewItem(reader[0].ToString());
                    studentRow.SubItems.Add(reader[1].ToString());
                    studentRow.SubItems.Add(reader[2].ToString());
                    studentRow.SubItems.Add(reader[3].ToString());
                    lvwStudentList.Items.Add(studentRow);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formMain = new Form1();
            formMain.Show();
        }

        private void lvwStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentList_Click(object sender, EventArgs e)
        {

        }
    }
}
