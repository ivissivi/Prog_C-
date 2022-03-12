using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parts_Dealership
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CreateParts buyCarParts;

        private int bWinterTires;
        private int bSummerTires;
        private int bAllSeasonTires;
        private int bBrakeFluid;
        private int bWiperFluid;
        private int bEngineOil;
        private int bSparkPlug;
        private int bCarBattery;
        private int bBrakePads;

        private void frmMain_Load(object sender, EventArgs e)
        {
            buyCarParts = new CreateParts();
            buyCarParts.CarPartBought += new CreateParts.CarPartBoughtDelegate(CarPartBoughtHandler);
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
            if (Char.IsDigit(e.KeyChar) == false)
            {
                erpError.SetError(txtQuantity, "Please enter a numeric value!");
            }
            else
            {
                erpError.SetError(txtQuantity, "");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                erpError.SetError(txtQuantity, "Please set quantity");
                e.Cancel = true;

            }
            else if (erpError.GetError(txtQuantity) != "")
            {
                e.Cancel = true;

            }
            else
            {
                erpError.SetError(txtQuantity, "");
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

        private void lblAllSeason_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuWinterTires_Click(object sender, EventArgs e)
        {
            mnuWinterTires.Checked = true;
            mnuSummerTires.Checked = false;
            mnuAllSeasonTires.Checked = false;

            buyCarParts.BuyCarParts(CreateParts.PartType.WinterTires);
        }

        private void mnuSummerTires_Click(object sender, EventArgs e)
        {
            mnuWinterTires.Checked = false;
            mnuSummerTires.Checked = true;
            mnuAllSeasonTires.Checked = false;

            buyCarParts.BuyCarParts(CreateParts.PartType.SummerTires);
        }

        private void mnuAllSeasonTires_Click(object sender, EventArgs e)
        {
            mnuWinterTires.Checked = false;
            mnuSummerTires.Checked = false;
            mnuAllSeasonTires.Checked = true;

            buyCarParts.BuyCarParts(CreateParts.PartType.AllSeasonTires);
        }

        private void CarPartBoughtHandler()
        {
            switch (buyCarParts.Part)
            {
                case CreateParts.PartType.WinterTires:
                    bWinterTires++;
                    txtWinterTires.Text = bWinterTires.ToString();
                    break;

                case CreateParts.PartType.SummerTires:
                    bSummerTires++;
                    txtSummerTires.Text = bSummerTires.ToString();
                    break;

                case CreateParts.PartType.AllSeasonTires:
                    bAllSeasonTires++;
                    txtAllSeasonTires.Text = bAllSeasonTires.ToString();
                    break;

                case CreateParts.PartType.BrakeFluid:
                    bBrakeFluid++;
                    txtBrakeFluid.Text = bBrakeFluid.ToString();
                    break;

                case CreateParts.PartType.WiperFluid:
                    bWiperFluid++;
                    txtWiperFluid.Text = bWiperFluid.ToString();
                    break;

                case CreateParts.PartType.EngineOil:
                    bEngineOil++;
                    txtEngineOil.Text = bEngineOil.ToString();
                    break;

                case CreateParts.PartType.SparkPlug:
                    bSparkPlug++;
                    txtSparkPlug.Text = bSparkPlug.ToString();
                    break;

                case CreateParts.PartType.CarBattery:
                    bCarBattery++;
                    txtCarBattery.Text = bCarBattery.ToString();
                    break;

                case CreateParts.PartType.BrakePads:
                    bBrakePads++;
                    txtBrakePads.Text = bBrakePads.ToString();
                    break;
            }
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            buyCarParts.Enabled = false;
        }

        private void mnuBrakeFluid_Click(object sender, EventArgs e)
        {
            mnuBrakeFluid.Checked = true;
            mnuWiperFluid.Checked = false;
            mnuEngineOil.Checked = false;

            buyCarParts.BuyCarParts(CreateParts.PartType.BrakeFluid);
        }

        private void mnuWiperFluid_Click(object sender, EventArgs e)
        {
            mnuBrakeFluid.Checked = false;
            mnuWiperFluid.Checked = true;
            mnuEngineOil.Checked = false;

            buyCarParts.BuyCarParts(CreateParts.PartType.WiperFluid);
        }

        private void mnuEngineOil_Click(object sender, EventArgs e)
        {
            mnuBrakeFluid.Checked = false;
            mnuWiperFluid.Checked = false;
            mnuEngineOil.Checked = true;

            buyCarParts.BuyCarParts(CreateParts.PartType.EngineOil);
        }

        private void mnuSparkPlug_Click(object sender, EventArgs e)
        {
            mnuSparkPlug.Checked = true;
            mnuCarBattery.Checked = false;
            mnuBrakePads.Checked = false;

            buyCarParts.BuyCarParts(CreateParts.PartType.SparkPlug);
        }

        private void mnuCarBattery_Click(object sender, EventArgs e)
        {
            mnuSparkPlug.Checked = false;
            mnuCarBattery.Checked = true;
            mnuBrakePads.Checked = false;

            buyCarParts.BuyCarParts(CreateParts.PartType.CarBattery);
        }

        private void mnuBrakePads_Click(object sender, EventArgs e)
        {
            mnuSparkPlug.Checked = false;
            mnuCarBattery.Checked = false;
            mnuBrakePads.Checked = true;
            buyCarParts.BuyCarParts(CreateParts.PartType.BrakePads);
        }
    }
}
