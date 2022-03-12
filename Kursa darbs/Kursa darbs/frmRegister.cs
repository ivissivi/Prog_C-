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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kursa_darbs.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string strConn = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Kursa_darbs.mdb";
            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                conn.Open();
                string select = "SELECT * FROM Users WHERE Username='" + txtUsername.Text + "'";
                using (OleDbCommand selectCommand = new OleDbCommand(select, conn))
                {
                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Lietotājs ar lietotājvārdu '"+ txtUsername.Text + "' jau pastāv!", "Reģistrācija ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Text = "";
                    }
                    else
                    {

                        if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text == "")
                        {
                            MessageBox.Show("Lietotājvārda un paroles lauki ir tukši", "Reģistrācija ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (ValidatePassword(txtPassword.Text) == false)
                        {
                            MessageBox.Show("Lai izveidotu kontu, parolei nepieciešams saturēt: \n Vismaz vienu mazo burtu, \n Vismaz vienu lielo burtu, \n Vismaz vienu īpašo simbolu, \n Vismaz vienu ciparu, \n Vismaz 8 rakstzīmes", "Reģistrācija ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (txtPassword.Text == txtConfirmPassword.Text)
                        {
                            con.Open();

                            OleDbCommand cmd = con.CreateCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "INSERT INTO Users ([Username], [Password]) VALUES (@Username, @Password)";
                            cmd.Parameters.AddWithValue("@Username", OleDbType.Char).Value = txtUsername.Text;
                            cmd.Parameters.AddWithValue("@Password", OleDbType.Char).Value = txtPassword.Text;
                            cmd.ExecuteNonQuery();

                            con.Close();

                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtConfirmPassword.Text = "";

                            MessageBox.Show("Jūsu konts tika veiksmīgi izveidots!", "Reģistrācija ir veiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Paroles nesakrīt savā starpā, lūdzu ievadiet vēlreiz", "Reģistrācija ir neveiksmīga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Text = "";
                            txtConfirmPassword.Text = "";
                            txtPassword.Focus();
                        }

                    }
                }
            }

            bool ValidatePassword(string passWord)
            {
                int validCount = 0;
                foreach (char c in passWord)
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        validCount++;
                        break;
                    }
                }
                foreach (char c in passWord)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        validCount++;
                        break;
                    }
                }
                if (validCount == 0) return false;
                foreach (char c in passWord)
                {
                    if (c >= '0' && c <= '9')
                    {
                        validCount++;
                        break;
                    }
                }
                if (validCount == 1) return false;
                if (validCount == 2)
                {
                    char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' };
                    if (passWord.IndexOfAny(special) == -1) return false;
                }
                return true;
            }
        }
    

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '●';
                txtConfirmPassword.PasswordChar = '●';
            }
        }

        private void lblAlreadyHaveAnAccount_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
