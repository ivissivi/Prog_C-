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

namespace Kursa_darbs
{
    public partial class menuDeli : Form
    {
        public menuDeli()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void lvwStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuBalki_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kursa_darbs.mdb";

            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ID, Warehouse_location, Stock_count FROM Stock WHERE Timber_type='Dēļi'";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem itemRow = new ListViewItem(reader[0].ToString());
                    itemRow.SubItems.Add(reader[1].ToString());
                    itemRow.SubItems.Add(reader[2].ToString());
                    lvwDeliList.Items.Add(itemRow);
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
