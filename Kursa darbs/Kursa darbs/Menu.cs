using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursa_darbs
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pbxBalki_Click(object sender, EventArgs e)
        {
            new menuBalki().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new menuBrusas().Show();
            this.Hide();
        }

        private void pbxDeli_Click(object sender, EventArgs e)
        {
            new menuDeli().Show();
            this.Hide();
        }

        private void pbxFinieris_Click(object sender, EventArgs e)
        {
            new menuFinieris().Show();
            this.Hide();
        }

        private void pbxKSP_Click(object sender, EventArgs e)
        {
            new menuKSP().Show();
            this.Hide();
        }

        private void pbxSpundetiDeli_Click(object sender, EventArgs e)
        {
            new menuSpundetiDeli().Show();
            this.Hide();
        }

        private void pbxCLT_Click(object sender, EventArgs e)
        {
            new menuCLT().Show();
            this.Hide();
        }
    }
}
