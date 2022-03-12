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
    public partial class courseList : Form
    {
        public courseList()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPasniedzejs formPasniedzejs = new formPasniedzejs();
            formPasniedzejs.Show();
        }

        private void lvwCourseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void courseList_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ivis3\source\repos\Eksamens\data_base\ivars_sloka.accdb";

            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Kursi";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem courseRow = new ListViewItem(reader[0].ToString());
                    courseRow.SubItems.Add(reader[1].ToString());
                    courseRow.SubItems.Add(reader[2].ToString());
                    lvwCourseList.Items.Add(courseRow);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
