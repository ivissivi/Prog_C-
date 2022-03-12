
namespace Coffee_shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtHeading = new System.Windows.Forms.Label();
            this.lblTires = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveDamaged = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContents = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWinterTires = new System.Windows.Forms.Label();
            this.lblSummerTires = new System.Windows.Forms.Label();
            this.lblAllSeasonTires = new System.Windows.Forms.Label();
            this.txtWinterTires = new System.Windows.Forms.TextBox();
            this.txtSummerTires = new System.Windows.Forms.TextBox();
            this.txtAllSeasonTires = new System.Windows.Forms.TextBox();
            this.txtEngineOil = new System.Windows.Forms.TextBox();
            this.txtWiperFluid = new System.Windows.Forms.TextBox();
            this.txtBrakeFluid = new System.Windows.Forms.TextBox();
            this.lblEngineOil = new System.Windows.Forms.Label();
            this.lblWiperFluid = new System.Windows.Forms.Label();
            this.lblBrakeFluid = new System.Windows.Forms.Label();
            this.lblFluids = new System.Windows.Forms.Label();
            this.txtBrakePads = new System.Windows.Forms.TextBox();
            this.txtCarBattery = new System.Windows.Forms.TextBox();
            this.txtSparkPlug = new System.Windows.Forms.TextBox();
            this.lblBrakePads = new System.Windows.Forms.Label();
            this.lblCarBattery = new System.Windows.Forms.Label();
            this.lblSparkPlug = new System.Windows.Forms.Label();
            this.lblReplacementParts = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lstSale = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.cmbEngineSize = new System.Windows.Forms.ComboBox();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.mnuBlueprint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHeading
            // 
            this.txtHeading.AutoSize = true;
            this.txtHeading.BackColor = System.Drawing.Color.Transparent;
            this.txtHeading.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHeading.ForeColor = System.Drawing.Color.Tomato;
            this.txtHeading.Location = new System.Drawing.Point(304, 36);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(182, 51);
            this.txtHeading.TabIndex = 0;
            this.txtHeading.Text = "Your cart";
            this.txtHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTires
            // 
            this.lblTires.AutoSize = true;
            this.lblTires.Location = new System.Drawing.Point(114, 116);
            this.lblTires.Name = "lblTires";
            this.lblTires.Size = new System.Drawing.Size(31, 15);
            this.lblTires.TabIndex = 1;
            this.lblTires.Text = "Tires";
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuStock,
            this.mnuCustomers,
            this.mnuHelp});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMenu.TabIndex = 2;
            this.mnuMenu.Text = "Main Menu";
            this.mnuMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMenu_ItemClicked);
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(93, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuStock
            // 
            this.mnuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateStock,
            this.mnuRemoveDamaged});
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(48, 20);
            this.mnuStock.Text = "Stock";
            // 
            // mnuUpdateStock
            // 
            this.mnuUpdateStock.Name = "mnuUpdateStock";
            this.mnuUpdateStock.Size = new System.Drawing.Size(170, 22);
            this.mnuUpdateStock.Text = "Update stock";
            // 
            // mnuRemoveDamaged
            // 
            this.mnuRemoveDamaged.Name = "mnuRemoveDamaged";
            this.mnuRemoveDamaged.Size = new System.Drawing.Size(170, 22);
            this.mnuRemoveDamaged.Text = "Remove damaged";
            this.mnuRemoveDamaged.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // mnuCustomers
            // 
            this.mnuCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddCustomer,
            this.mnuViewCustomer});
            this.mnuCustomers.Name = "mnuCustomers";
            this.mnuCustomers.Size = new System.Drawing.Size(76, 20);
            this.mnuCustomers.Text = "Customers";
            this.mnuCustomers.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // mnuAddCustomer
            // 
            this.mnuAddCustomer.Name = "mnuAddCustomer";
            this.mnuAddCustomer.Size = new System.Drawing.Size(152, 22);
            this.mnuAddCustomer.Text = "Add customer";
            // 
            // mnuViewCustomer
            // 
            this.mnuViewCustomer.Name = "mnuViewCustomer";
            this.mnuViewCustomer.Size = new System.Drawing.Size(152, 22);
            this.mnuViewCustomer.Text = "View customer";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuContents});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuContents
            // 
            this.mnuContents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBlueprint});
            this.mnuContents.Name = "mnuContents";
            this.mnuContents.Size = new System.Drawing.Size(180, 22);
            this.mnuContents.Text = "Contents";
            // 
            // lblWinterTires
            // 
            this.lblWinterTires.AutoSize = true;
            this.lblWinterTires.Location = new System.Drawing.Point(39, 140);
            this.lblWinterTires.Name = "lblWinterTires";
            this.lblWinterTires.Size = new System.Drawing.Size(42, 15);
            this.lblWinterTires.TabIndex = 3;
            this.lblWinterTires.Text = "Winter";
            // 
            // lblSummerTires
            // 
            this.lblSummerTires.AutoSize = true;
            this.lblSummerTires.Location = new System.Drawing.Point(29, 172);
            this.lblSummerTires.Name = "lblSummerTires";
            this.lblSummerTires.Size = new System.Drawing.Size(52, 15);
            this.lblSummerTires.TabIndex = 4;
            this.lblSummerTires.Text = "Summer";
            // 
            // lblAllSeasonTires
            // 
            this.lblAllSeasonTires.AutoSize = true;
            this.lblAllSeasonTires.Location = new System.Drawing.Point(18, 204);
            this.lblAllSeasonTires.Name = "lblAllSeasonTires";
            this.lblAllSeasonTires.Size = new System.Drawing.Size(63, 15);
            this.lblAllSeasonTires.TabIndex = 5;
            this.lblAllSeasonTires.Text = "All-Season";
            // 
            // txtWinterTires
            // 
            this.txtWinterTires.Location = new System.Drawing.Point(87, 137);
            this.txtWinterTires.Name = "txtWinterTires";
            this.txtWinterTires.ReadOnly = true;
            this.txtWinterTires.Size = new System.Drawing.Size(100, 23);
            this.txtWinterTires.TabIndex = 6;
            // 
            // txtSummerTires
            // 
            this.txtSummerTires.Location = new System.Drawing.Point(87, 169);
            this.txtSummerTires.Name = "txtSummerTires";
            this.txtSummerTires.ReadOnly = true;
            this.txtSummerTires.Size = new System.Drawing.Size(100, 23);
            this.txtSummerTires.TabIndex = 7;
            // 
            // txtAllSeasonTires
            // 
            this.txtAllSeasonTires.Location = new System.Drawing.Point(87, 201);
            this.txtAllSeasonTires.Name = "txtAllSeasonTires";
            this.txtAllSeasonTires.ReadOnly = true;
            this.txtAllSeasonTires.Size = new System.Drawing.Size(100, 23);
            this.txtAllSeasonTires.TabIndex = 8;
            // 
            // txtEngineOil
            // 
            this.txtEngineOil.Location = new System.Drawing.Point(277, 201);
            this.txtEngineOil.Name = "txtEngineOil";
            this.txtEngineOil.ReadOnly = true;
            this.txtEngineOil.Size = new System.Drawing.Size(100, 23);
            this.txtEngineOil.TabIndex = 15;
            // 
            // txtWiperFluid
            // 
            this.txtWiperFluid.Location = new System.Drawing.Point(277, 169);
            this.txtWiperFluid.Name = "txtWiperFluid";
            this.txtWiperFluid.ReadOnly = true;
            this.txtWiperFluid.Size = new System.Drawing.Size(100, 23);
            this.txtWiperFluid.TabIndex = 14;
            // 
            // txtBrakeFluid
            // 
            this.txtBrakeFluid.Location = new System.Drawing.Point(277, 137);
            this.txtBrakeFluid.Name = "txtBrakeFluid";
            this.txtBrakeFluid.ReadOnly = true;
            this.txtBrakeFluid.Size = new System.Drawing.Size(100, 23);
            this.txtBrakeFluid.TabIndex = 13;
            // 
            // lblEngineOil
            // 
            this.lblEngineOil.AutoSize = true;
            this.lblEngineOil.Location = new System.Drawing.Point(212, 204);
            this.lblEngineOil.Name = "lblEngineOil";
            this.lblEngineOil.Size = new System.Drawing.Size(59, 15);
            this.lblEngineOil.TabIndex = 12;
            this.lblEngineOil.Text = "Engine oil";
            // 
            // lblWiperFluid
            // 
            this.lblWiperFluid.AutoSize = true;
            this.lblWiperFluid.Location = new System.Drawing.Point(206, 172);
            this.lblWiperFluid.Name = "lblWiperFluid";
            this.lblWiperFluid.Size = new System.Drawing.Size(65, 15);
            this.lblWiperFluid.TabIndex = 11;
            this.lblWiperFluid.Text = "Wiper fluid";
            // 
            // lblBrakeFluid
            // 
            this.lblBrakeFluid.AutoSize = true;
            this.lblBrakeFluid.Location = new System.Drawing.Point(208, 140);
            this.lblBrakeFluid.Name = "lblBrakeFluid";
            this.lblBrakeFluid.Size = new System.Drawing.Size(63, 15);
            this.lblBrakeFluid.TabIndex = 10;
            this.lblBrakeFluid.Text = "Brake fluid";
            this.lblBrakeFluid.Click += new System.EventHandler(this.lblBrakeFluid_Click);
            // 
            // lblFluids
            // 
            this.lblFluids.AutoSize = true;
            this.lblFluids.Location = new System.Drawing.Point(304, 116);
            this.lblFluids.Name = "lblFluids";
            this.lblFluids.Size = new System.Drawing.Size(38, 15);
            this.lblFluids.TabIndex = 9;
            this.lblFluids.Text = "Fluids";
            // 
            // txtBrakePads
            // 
            this.txtBrakePads.Location = new System.Drawing.Point(465, 201);
            this.txtBrakePads.Name = "txtBrakePads";
            this.txtBrakePads.ReadOnly = true;
            this.txtBrakePads.Size = new System.Drawing.Size(100, 23);
            this.txtBrakePads.TabIndex = 22;
            // 
            // txtCarBattery
            // 
            this.txtCarBattery.Location = new System.Drawing.Point(465, 169);
            this.txtCarBattery.Name = "txtCarBattery";
            this.txtCarBattery.ReadOnly = true;
            this.txtCarBattery.Size = new System.Drawing.Size(100, 23);
            this.txtCarBattery.TabIndex = 21;
            // 
            // txtSparkPlug
            // 
            this.txtSparkPlug.Location = new System.Drawing.Point(465, 137);
            this.txtSparkPlug.Name = "txtSparkPlug";
            this.txtSparkPlug.ReadOnly = true;
            this.txtSparkPlug.Size = new System.Drawing.Size(100, 23);
            this.txtSparkPlug.TabIndex = 20;
            // 
            // lblBrakePads
            // 
            this.lblBrakePads.AutoSize = true;
            this.lblBrakePads.Location = new System.Drawing.Point(394, 204);
            this.lblBrakePads.Name = "lblBrakePads";
            this.lblBrakePads.Size = new System.Drawing.Size(64, 15);
            this.lblBrakePads.TabIndex = 19;
            this.lblBrakePads.Text = "Brake pads";
            // 
            // lblCarBattery
            // 
            this.lblCarBattery.AutoSize = true;
            this.lblCarBattery.Location = new System.Drawing.Point(394, 172);
            this.lblCarBattery.Name = "lblCarBattery";
            this.lblCarBattery.Size = new System.Drawing.Size(65, 15);
            this.lblCarBattery.TabIndex = 18;
            this.lblCarBattery.Text = "Car battery";
            // 
            // lblSparkPlug
            // 
            this.lblSparkPlug.AutoSize = true;
            this.lblSparkPlug.Location = new System.Drawing.Point(396, 140);
            this.lblSparkPlug.Name = "lblSparkPlug";
            this.lblSparkPlug.Size = new System.Drawing.Size(63, 15);
            this.lblSparkPlug.TabIndex = 17;
            this.lblSparkPlug.Text = "Spark plug";
            // 
            // lblReplacementParts
            // 
            this.lblReplacementParts.AutoSize = true;
            this.lblReplacementParts.Location = new System.Drawing.Point(460, 116);
            this.lblReplacementParts.Name = "lblReplacementParts";
            this.lblReplacementParts.Size = new System.Drawing.Size(105, 15);
            this.lblReplacementParts.TabIndex = 16;
            this.lblReplacementParts.Text = "Replacement parts";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(465, 274);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtQuantity.TabIndex = 23;
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.textBox10_Validating);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(406, 277);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(427, 310);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 15);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(465, 307);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(100, 23);
            this.cmbType.TabIndex = 26;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(425, 339);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(465, 336);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 29;
            // 
            // lstSale
            // 
            this.lstSale.FormattingEnabled = true;
            this.lstSale.ItemHeight = 15;
            this.lstSale.Location = new System.Drawing.Point(586, 116);
            this.lstSale.Name = "lstSale";
            this.lstSale.Size = new System.Drawing.Size(202, 184);
            this.lstSale.TabIndex = 30;
            this.lstSale.SelectedIndexChanged += new System.EventHandler(this.lstSale_SelectedIndexChanged);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(586, 362);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(96, 34);
            this.btnAddToCart.TabIndex = 31;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(586, 402);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(96, 34);
            this.btnRemoveItem.TabIndex = 32;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(688, 362);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(100, 74);
            this.btnCheckOut.TabIndex = 33;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(688, 310);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 35;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(650, 313);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 15);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(64, 364);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(55, 15);
            this.lblFuelType.TabIndex = 39;
            this.lblFuelType.Text = "Fuel type";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(78, 307);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 15);
            this.lblModel.TabIndex = 38;
            this.lblModel.Text = "Model";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(40, 277);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(79, 15);
            this.lblManufacturer.TabIndex = 37;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(196, 246);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(25, 15);
            this.lblCar.TabIndex = 36;
            this.lblCar.Text = "Car";
            this.lblCar.Click += new System.EventHandler(this.lblCar_Click);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(125, 302);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(174, 23);
            this.cmbModel.TabIndex = 43;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(125, 273);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(174, 23);
            this.cmbManufacturer.TabIndex = 44;
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(125, 361);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(174, 23);
            this.cmbFuelType.TabIndex = 45;
            this.cmbFuelType.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cmbEngineSize
            // 
            this.cmbEngineSize.FormattingEnabled = true;
            this.cmbEngineSize.Location = new System.Drawing.Point(125, 390);
            this.cmbEngineSize.Name = "cmbEngineSize";
            this.cmbEngineSize.Size = new System.Drawing.Size(174, 23);
            this.cmbEngineSize.TabIndex = 46;
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(54, 392);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(65, 15);
            this.lblEngineSize.TabIndex = 47;
            this.lblEngineSize.Text = "Engine size";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(125, 331);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(174, 23);
            this.cmbYear.TabIndex = 49;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(78, 334);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 15);
            this.lblYear.TabIndex = 48;
            this.lblYear.Text = "Year";
            // 
            // mnuBlueprint
            // 
            this.mnuBlueprint.Name = "mnuBlueprint";
            this.mnuBlueprint.Size = new System.Drawing.Size(180, 22);
            this.mnuBlueprint.Text = "Blueprint";
            this.mnuBlueprint.Click += new System.EventHandler(this.mnuBlueprint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblEngineSize);
            this.Controls.Add(this.cmbEngineSize);
            this.Controls.Add(this.cmbFuelType);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lstSale);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtBrakePads);
            this.Controls.Add(this.txtCarBattery);
            this.Controls.Add(this.txtSparkPlug);
            this.Controls.Add(this.lblBrakePads);
            this.Controls.Add(this.lblCarBattery);
            this.Controls.Add(this.lblSparkPlug);
            this.Controls.Add(this.lblReplacementParts);
            this.Controls.Add(this.txtEngineOil);
            this.Controls.Add(this.txtWiperFluid);
            this.Controls.Add(this.txtBrakeFluid);
            this.Controls.Add(this.lblEngineOil);
            this.Controls.Add(this.lblWiperFluid);
            this.Controls.Add(this.lblBrakeFluid);
            this.Controls.Add(this.lblFluids);
            this.Controls.Add(this.txtAllSeasonTires);
            this.Controls.Add(this.txtSummerTires);
            this.Controls.Add(this.txtWinterTires);
            this.Controls.Add(this.lblAllSeasonTires);
            this.Controls.Add(this.lblSummerTires);
            this.Controls.Add(this.lblWinterTires);
            this.Controls.Add(this.lblTires);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTires;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomers;
        private System.Windows.Forms.Label lblWinterTires;
        private System.Windows.Forms.Label lblSummerTires;
        private System.Windows.Forms.Label lblAllSeasonTires;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateStock;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveDamaged;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuContents;
        private System.Windows.Forms.TextBox txtWinterTires;
        private System.Windows.Forms.TextBox txtSummerTires;
        private System.Windows.Forms.TextBox txtAllSeasonTires;
        private System.Windows.Forms.TextBox txtEngineOil;
        private System.Windows.Forms.TextBox txtWiperFluid;
        private System.Windows.Forms.TextBox txtBrakeFluid;
        private System.Windows.Forms.Label lblEngineOil;
        private System.Windows.Forms.Label lblWiperFluid;
        private System.Windows.Forms.Label lblBrakeFluid;
        private System.Windows.Forms.Label lblFluids;
        private System.Windows.Forms.TextBox txtBrakePads;
        private System.Windows.Forms.TextBox txtCarBattery;
        private System.Windows.Forms.TextBox txtSparkPlug;
        private System.Windows.Forms.Label lblBrakePads;
        private System.Windows.Forms.Label lblCarBattery;
        private System.Windows.Forms.Label lblSparkPlug;
        private System.Windows.Forms.Label lblReplacementParts;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox lstSale;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddToCart;
        public System.Windows.Forms.Label txtHeading;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.ComboBox cmbEngineSize;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ToolStripMenuItem mnuBlueprint;
    }
}

