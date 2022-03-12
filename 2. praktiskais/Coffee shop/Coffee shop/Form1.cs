using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)==false)
            {
                errorProvider.SetError(txtQuantity, "Please enter a numeric value!");
            } else
            {
                errorProvider.SetError(txtQuantity, "");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                errorProvider.SetError(txtQuantity, "Please set quantity");
                e.Cancel = true;

            } else if (errorProvider.GetError(txtQuantity) != "")
            {
                e.Cancel = true;

            } else
            {
                errorProvider.SetError(txtQuantity, "");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lietotnes produktu klāstā pieejamas auto rezerves daļas, kas pēc kvalitātes rādītājiem ir pielīdzināmas oriģinālajām rezerves daļām, vai arī pārspēj tās, gan arī lētāki budžeta versijas produkti. Detaļas iespējams pielāgot pēc attiecīgā mašīnas markas modeļa, kas tiek atlasīts. Lietotnes mērķis ir ļaut lietotājam ērti, ātri un pārskatāmi pasūtīt pielāgotas detaļas savam automobīlim.");
        }

        private void lstSale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnuMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblBrakeFluid_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCar_Click(object sender, EventArgs e)
        {

        }

        private void mnuBlueprint_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "/Untitled.png";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
