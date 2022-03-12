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
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "" && txtLastName.Text != "")
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Klasesdarbs.accdb";

                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Clients (ClientName, ClientLastName) VALUES (@name, @lastName)";
                    cmd.Parameters.AddWithValue("@name", OleDbType.Char).Value = txtName.Text;
                    cmd.Parameters.AddWithValue("@lastName", OleDbType.Char).Value = txtLastName.Text;
                    cmd.ExecuteNonQuery();

                    txtName.Text = "";
                    txtLastName.Text = "";

                    MessageBox.Show("Client with name: " + txtName.Text + " has been added");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                } else
                {

                    MessageBox.Show("Fields are empty!");
                }
            }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Close();
            main.Show();
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

        }
    }
}
