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

namespace Car_Parts_Dealership
{
    public partial class frmClientList : Form
    {
        public frmClientList()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmClientList_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ivis3\Documents\Klasesdarbs.accdb";

            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Clients";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem clientRow = new ListViewItem(reader[0].ToString());
                    clientRow.SubItems.Add(reader[1].ToString());
                    clientRow.SubItems.Add(reader[2].ToString());
                    lvwClientsList.Items.Add(clientRow);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblClientList_Click(object sender, EventArgs e)
        {

        }
    }
}
