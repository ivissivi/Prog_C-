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
    public partial class manageUsers : Form
    {
        public manageUsers()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kursa_darbs.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd;

        private void btnHome_Click(object sender, EventArgs e)
        {
            new adminPanel().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void pbxRefresh_Click(object sender, EventArgs e)
        {
            new manageUsers().Show();
            this.Hide();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string connStr = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kursa_darbs.mdb";
                string selectQuery = "SELECT * FROM Users";
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvUsers.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Lūdzu ievadiet lietotājvārdu, lai varētu dzēst!", "Lietotāja dzēšana ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
            }
            else
            {

                con.Open();

                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Users WHERE Username='" + txtUsername.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";

                MessageBox.Show("Lietotājs tika veiksmīgi dzēsts!", "Lietotāja dzēšana ir veiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
