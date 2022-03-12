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
    public partial class manageInventory : Form
    {
        public manageInventory()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kursa_darbs.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd;

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new adminPanel().Show();
            this.Hide();
        }

        private void manageInventory_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string connStr = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kursa_darbs.mdb";
                string selectQuery = "SELECT * FROM Stock";
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvStock.DataSource = ds.Tables[0];
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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (cbxTimberType.Text == "" || cbxWarehouseLocation.Text == "" || cbxStockCount.Text == "")
            {
                MessageBox.Show("Visi lauki par kokmateriālu datiem nav aizpildīti!", "Kokmateriālu pievienošana ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string strConn = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kursa_darbs.mdb";
                using (OleDbConnection conn = new OleDbConnection(strConn))
                {
                    conn.Open();
                    string select = "SELECT * FROM Stock WHERE Timber_type='" + cbxTimberType.Text + "' AND Warehouse_location='" + cbxWarehouseLocation.Text + "'";
                    using (OleDbCommand selectCommand = new OleDbCommand(select, conn))
                    {
                        int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "UPDATE Stock SET Stock_count = Stock_Count + '"+cbxStockCount.Text+ "' WHERE Timber_type='" + cbxTimberType.Text + "' AND Warehouse_location='" + cbxWarehouseLocation.Text + "'";
                            cmd.ExecuteNonQuery();

                            con.Close();

                            cbxTimberType.Text = "";
                            cbxWarehouseLocation.Text = "";
                            cbxStockCount.Text = "";

                            MessageBox.Show("Kokmateriālu skaits tika veiksmīgi papildināts!", "Kokmateriālu pievienošana ir veiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            con.Open();

                            OleDbCommand cmd = con.CreateCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "INSERT INTO Stock ([Timber_type], [Warehouse_location], [Stock_count]) VALUES (@Timber_type, @Warehouse_location, @Stock_count)";
                            cmd.Parameters.AddWithValue("@Timber_type", OleDbType.Char).Value = cbxTimberType.Text;
                            cmd.Parameters.AddWithValue("@Warehouse_location", OleDbType.Char).Value = cbxWarehouseLocation.Text;
                            cmd.Parameters.AddWithValue("@Stock_count", OleDbType.Char).Value = cbxStockCount.Text;
                            cmd.ExecuteNonQuery();

                            con.Close();

                            cbxTimberType.Text = "";
                            cbxWarehouseLocation.Text = "";
                            cbxStockCount.Text = "";

                            MessageBox.Show("Kokmateriāli tika veiksmīgi pievienoti sarakstam!", "Kokmateriālu pievienošana ir veiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void pbxRefresh_Click(object sender, EventArgs e)
        {
            new manageInventory().Show();
            this.Hide();
        }

        private void cbxStockCount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            if (cbxTimberType.Text == "" || cbxWarehouseLocation.Text == "" || cbxStockCount.Text == "")
            {
                MessageBox.Show("Visi lauki par kokmateriālu datiem nav aizpildīti!", "Kokmateriālu pievienošana ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { 
                string strConn = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kursa_darbs.mdb";
                using (OleDbConnection conn = new OleDbConnection(strConn))
                {
                    conn.Open();
                    string select = "SELECT * FROM Stock WHERE Timber_type='" + cbxTimberType.Text + "' AND Warehouse_location='" + cbxWarehouseLocation.Text + "'";
                    using (OleDbCommand selectCommand = new OleDbCommand(select, conn))
                    {
                        int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "UPDATE Stock SET Stock_count = Stock_Count - '" + cbxStockCount.Text + "' WHERE Timber_type='" + cbxTimberType.Text + "' AND Warehouse_location='" + cbxWarehouseLocation.Text + "'";
                            int removeStock = Int32.Parse(cbxStockCount.Text);
                            if (removeStock < 0)
                            {
                                MessageBox.Show("'"+ cbxTimberType.Text +"', kas atrodas '"+cbxWarehouseLocation.Text+"'ir tukšs!", "Kokmateriālu pievienošana ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else
                            {
                                cmd.ExecuteNonQuery();
                                con.Close();

                                cbxTimberType.Text = "";
                                cbxWarehouseLocation.Text = "";
                                cbxStockCount.Text = "";

                                MessageBox.Show("Kokmateriālu skaits tika veiksmīgi atjaunināts!", "Kokmateriālu pievienošana ir veiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (cbxTimberType.Text == "" || cbxWarehouseLocation.Text == "")
            {
                MessageBox.Show("Visi lauki par kokmateriālu datiem nav aizpildīti!", "Kokmateriālu pievienošana ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               
                con.Open();
                  
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Stock WHERE Timber_type='" + cbxTimberType.Text + "' AND Warehouse_location='" + cbxWarehouseLocation.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                cbxTimberType.Text = "";
                cbxWarehouseLocation.Text = "";
                cbxStockCount.Text = "";

                MessageBox.Show("Ieraksts tika veiksmīgi izdzēsts!", "Ieraksta dzēšana ir veiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
