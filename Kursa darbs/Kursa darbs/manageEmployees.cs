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
    public partial class manageEmployees : Form
    {
        public manageEmployees()
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

        public void manageEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string connStr = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kursa_darbs.mdb";
                string selectQuery = "SELECT * FROM Employees";
                using(OleDbConnection conn = new OleDbConnection(connStr))
                {
                    using(OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvEmployees.DataSource = ds.Tables[0];
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
            if (txtEmployeeName.Text == "" || txtEmployeeLastName.Text == "" || txtEmployeePhoneNumber.Text == "" || cbxEmployeePosition.Text == "")
            {
                MessageBox.Show("Visi lauki par darbinieka datiem nav aizpildīti!", "Darbinieka pievienošana ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                con.Open();

                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Employees ([Employee_name], [Employee_surname], [Employee_position], [Employee_phoneNumber]) VALUES (@Employee_name, @Employee_surname, @Employee_position, @Employee_phoneNumber)";
                cmd.Parameters.AddWithValue("@Employee_name", OleDbType.Char).Value = txtEmployeeName.Text;
                cmd.Parameters.AddWithValue("@Employee_surname", OleDbType.Char).Value = txtEmployeeLastName.Text;
                cmd.Parameters.AddWithValue("@Employee_position", OleDbType.Char).Value = cbxEmployeePosition.Text;
                cmd.Parameters.AddWithValue("@Employee_phoneNumber", OleDbType.Char).Value = txtEmployeePhoneNumber.Text;
                cmd.ExecuteNonQuery();

                con.Close();

                txtEmployeeName.Text = "";
                txtEmployeeLastName.Text = "";
                cbxEmployeePosition.Text = "";
                txtEmployeePhoneNumber.Text = "";

                MessageBox.Show("Darbinieks tika veiksmīgi pievienots sarakstam!", "Darbinieka pievienošana ir veiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void delete(int id)
        {
            String sql = "DELETE FROM Employees WHERE ID=" + id + "";
            cmd = new OleDbCommand(sql, con);

            try
            {
                con.Open();
                da = new OleDbDataAdapter(cmd);
                da.DeleteCommand = con.CreateCommand();
                da.DeleteCommand.CommandText = sql;

                if (MessageBox.Show(@"Are you sure to permanently delete this?", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(@"Successfully deleted");
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "" || txtEmployeeName.Text == "")
            {
                MessageBox.Show("Lūdzu ievadiet darbinieka vārdu un uzvārdu, lai varētu dzēst!", "Darbinieka dzēšana ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeePhoneNumber.Text = "";
                cbxEmployeePosition.Text = "";
            }
            else
            {

                con.Open();

                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Employees WHERE Employee_name='" + txtEmployeeName.Text + "' AND Employee_surname='" + txtEmployeeLastName.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                txtEmployeeName.Text = "";
                txtEmployeeLastName.Text = "";
                txtEmployeePhoneNumber.Text = "";
                cbxEmployeePosition.Text = "";

                MessageBox.Show("Darbinieks tika veiksmīgi dzēsts!", "Darbinieka dzēšana ir veiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbxRefresh_Click(object sender, EventArgs e)
        {
            new manageEmployees().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeePhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeePhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void cbxEmployeePosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeePosition_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }
    }
}
