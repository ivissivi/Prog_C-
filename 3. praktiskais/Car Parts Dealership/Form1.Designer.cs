
namespace Car_Parts_Dealership
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
            this.mnuTires = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWinterTires = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSummerTires = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllSeasonTires = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFluids = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrakeFluid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWiperFluid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEngineOil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReplacementParts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSparkPlug = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCarBattery = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrakePads = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveDamaged = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlueprint = new System.Windows.Forms.ToolStripMenuItem();
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
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHeading
            // 
            this.txtHeading.AutoSize = true;
            this.txtHeading.BackColor = System.Drawing.Color.Transparent;
            this.txtHeading.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.txtHeading.ForeColor = System.Drawing.Color.Tomato;
            this.txtHeading.Location = new System.Drawing.Point(261, 31);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(182, 51);
            this.txtHeading.TabIndex = 0;
            this.txtHeading.Text = "Your cart";
            this.txtHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTires
            // 
            this.lblTires.AutoSize = true;
            this.lblTires.Location = new System.Drawing.Point(98, 101);
            this.lblTires.Name = "lblTires";
            this.lblTires.Size = new System.Drawing.Size(30, 13);
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
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMenu.Size = new System.Drawing.Size(722, 24);
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
            this.mnuRemoveDamaged,
            this.mnuStop});
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(48, 20);
            this.mnuStock.Text = "Stock";
            // 
            // mnuUpdateStock
            // 
            this.mnuUpdateStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTires,
            this.mnuFluids,
            this.mnuReplacementParts});
            this.mnuUpdateStock.Name = "mnuUpdateStock";
            this.mnuUpdateStock.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateStock.Text = "Update stock";
            // 
            // mnuTires
            // 
            this.mnuTires.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWinterTires,
            this.mnuSummerTires,
            this.mnuAllSeasonTires});
            this.mnuTires.Name = "mnuTires";
            this.mnuTires.Size = new System.Drawing.Size(180, 22);
            this.mnuTires.Text = "Tires";
            // 
            // mnuWinterTires
            // 
            this.mnuWinterTires.Name = "mnuWinterTires";
            this.mnuWinterTires.Size = new System.Drawing.Size(180, 22);
            this.mnuWinterTires.Text = "Winter";
            this.mnuWinterTires.Click += new System.EventHandler(this.mnuWinterTires_Click);
            // 
            // mnuSummerTires
            // 
            this.mnuSummerTires.Name = "mnuSummerTires";
            this.mnuSummerTires.Size = new System.Drawing.Size(180, 22);
            this.mnuSummerTires.Text = "Summer";
            this.mnuSummerTires.Click += new System.EventHandler(this.mnuSummerTires_Click);
            // 
            // mnuAllSeasonTires
            // 
            this.mnuAllSeasonTires.Name = "mnuAllSeasonTires";
            this.mnuAllSeasonTires.Size = new System.Drawing.Size(180, 22);
            this.mnuAllSeasonTires.Text = "All-Season";
            this.mnuAllSeasonTires.Click += new System.EventHandler(this.mnuAllSeasonTires_Click);
            // 
            // mnuFluids
            // 
            this.mnuFluids.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBrakeFluid,
            this.mnuWiperFluid,
            this.mnuEngineOil});
            this.mnuFluids.Name = "mnuFluids";
            this.mnuFluids.Size = new System.Drawing.Size(180, 22);
            this.mnuFluids.Text = "Fluids";
            // 
            // mnuBrakeFluid
            // 
            this.mnuBrakeFluid.Name = "mnuBrakeFluid";
            this.mnuBrakeFluid.Size = new System.Drawing.Size(180, 22);
            this.mnuBrakeFluid.Text = "Brake fluid";
            this.mnuBrakeFluid.Click += new System.EventHandler(this.mnuBrakeFluid_Click);
            // 
            // mnuWiperFluid
            // 
            this.mnuWiperFluid.Name = "mnuWiperFluid";
            this.mnuWiperFluid.Size = new System.Drawing.Size(180, 22);
            this.mnuWiperFluid.Text = "Wiper fluid";
            this.mnuWiperFluid.Click += new System.EventHandler(this.mnuWiperFluid_Click);
            // 
            // mnuEngineOil
            // 
            this.mnuEngineOil.Name = "mnuEngineOil";
            this.mnuEngineOil.Size = new System.Drawing.Size(180, 22);
            this.mnuEngineOil.Text = "Engine oil";
            this.mnuEngineOil.Click += new System.EventHandler(this.mnuEngineOil_Click);
            // 
            // mnuReplacementParts
            // 
            this.mnuReplacementParts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSparkPlug,
            this.mnuCarBattery,
            this.mnuBrakePads});
            this.mnuReplacementParts.Name = "mnuReplacementParts";
            this.mnuReplacementParts.Size = new System.Drawing.Size(180, 22);
            this.mnuReplacementParts.Text = "Replacement parts";
            // 
            // mnuSparkPlug
            // 
            this.mnuSparkPlug.Name = "mnuSparkPlug";
            this.mnuSparkPlug.Size = new System.Drawing.Size(180, 22);
            this.mnuSparkPlug.Text = "Spark plug";
            this.mnuSparkPlug.Click += new System.EventHandler(this.mnuSparkPlug_Click);
            // 
            // mnuCarBattery
            // 
            this.mnuCarBattery.Name = "mnuCarBattery";
            this.mnuCarBattery.Size = new System.Drawing.Size(180, 22);
            this.mnuCarBattery.Text = "Car battery";
            this.mnuCarBattery.Click += new System.EventHandler(this.mnuCarBattery_Click);
            // 
            // mnuBrakePads
            // 
            this.mnuBrakePads.Name = "mnuBrakePads";
            this.mnuBrakePads.Size = new System.Drawing.Size(180, 22);
            this.mnuBrakePads.Text = "Brake pads";
            this.mnuBrakePads.Click += new System.EventHandler(this.mnuBrakePads_Click);
            // 
            // mnuRemoveDamaged
            // 
            this.mnuRemoveDamaged.Name = "mnuRemoveDamaged";
            this.mnuRemoveDamaged.Size = new System.Drawing.Size(180, 22);
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
            this.mnuAbout.Size = new System.Drawing.Size(122, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuContents
            // 
            this.mnuContents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBlueprint});
            this.mnuContents.Name = "mnuContents";
            this.mnuContents.Size = new System.Drawing.Size(122, 22);
            this.mnuContents.Text = "Contents";
            // 
            // mnuBlueprint
            // 
            this.mnuBlueprint.Name = "mnuBlueprint";
            this.mnuBlueprint.Size = new System.Drawing.Size(122, 22);
            this.mnuBlueprint.Text = "Blueprint";
            this.mnuBlueprint.Click += new System.EventHandler(this.mnuBlueprint_Click);
            // 
            // lblWinterTires
            // 
            this.lblWinterTires.AutoSize = true;
            this.lblWinterTires.Location = new System.Drawing.Point(33, 121);
            this.lblWinterTires.Name = "lblWinterTires";
            this.lblWinterTires.Size = new System.Drawing.Size(38, 13);
            this.lblWinterTires.TabIndex = 3;
            this.lblWinterTires.Text = "Winter";
            // 
            // lblSummerTires
            // 
            this.lblSummerTires.AutoSize = true;
            this.lblSummerTires.Location = new System.Drawing.Point(25, 149);
            this.lblSummerTires.Name = "lblSummerTires";
            this.lblSummerTires.Size = new System.Drawing.Size(45, 13);
            this.lblSummerTires.TabIndex = 4;
            this.lblSummerTires.Text = "Summer";
            // 
            // lblAllSeasonTires
            // 
            this.lblAllSeasonTires.AutoSize = true;
            this.lblAllSeasonTires.Location = new System.Drawing.Point(15, 177);
            this.lblAllSeasonTires.Name = "lblAllSeasonTires";
            this.lblAllSeasonTires.Size = new System.Drawing.Size(57, 13);
            this.lblAllSeasonTires.TabIndex = 5;
            this.lblAllSeasonTires.Text = "All-Season";
            // 
            // txtWinterTires
            // 
            this.txtWinterTires.Location = new System.Drawing.Point(75, 119);
            this.txtWinterTires.Name = "txtWinterTires";
            this.txtWinterTires.ReadOnly = true;
            this.txtWinterTires.Size = new System.Drawing.Size(86, 20);
            this.txtWinterTires.TabIndex = 6;
            // 
            // txtSummerTires
            // 
            this.txtSummerTires.Location = new System.Drawing.Point(75, 146);
            this.txtSummerTires.Name = "txtSummerTires";
            this.txtSummerTires.ReadOnly = true;
            this.txtSummerTires.Size = new System.Drawing.Size(86, 20);
            this.txtSummerTires.TabIndex = 7;
            // 
            // txtAllSeasonTires
            // 
            this.txtAllSeasonTires.Location = new System.Drawing.Point(75, 174);
            this.txtAllSeasonTires.Name = "txtAllSeasonTires";
            this.txtAllSeasonTires.ReadOnly = true;
            this.txtAllSeasonTires.Size = new System.Drawing.Size(86, 20);
            this.txtAllSeasonTires.TabIndex = 8;
            // 
            // txtEngineOil
            // 
            this.txtEngineOil.Location = new System.Drawing.Point(237, 174);
            this.txtEngineOil.Name = "txtEngineOil";
            this.txtEngineOil.ReadOnly = true;
            this.txtEngineOil.Size = new System.Drawing.Size(86, 20);
            this.txtEngineOil.TabIndex = 15;
            // 
            // txtWiperFluid
            // 
            this.txtWiperFluid.Location = new System.Drawing.Point(237, 146);
            this.txtWiperFluid.Name = "txtWiperFluid";
            this.txtWiperFluid.ReadOnly = true;
            this.txtWiperFluid.Size = new System.Drawing.Size(86, 20);
            this.txtWiperFluid.TabIndex = 14;
            // 
            // txtBrakeFluid
            // 
            this.txtBrakeFluid.Location = new System.Drawing.Point(237, 119);
            this.txtBrakeFluid.Name = "txtBrakeFluid";
            this.txtBrakeFluid.ReadOnly = true;
            this.txtBrakeFluid.Size = new System.Drawing.Size(86, 20);
            this.txtBrakeFluid.TabIndex = 13;
            // 
            // lblEngineOil
            // 
            this.lblEngineOil.AutoSize = true;
            this.lblEngineOil.Location = new System.Drawing.Point(182, 177);
            this.lblEngineOil.Name = "lblEngineOil";
            this.lblEngineOil.Size = new System.Drawing.Size(53, 13);
            this.lblEngineOil.TabIndex = 12;
            this.lblEngineOil.Text = "Engine oil";
            // 
            // lblWiperFluid
            // 
            this.lblWiperFluid.AutoSize = true;
            this.lblWiperFluid.Location = new System.Drawing.Point(177, 149);
            this.lblWiperFluid.Name = "lblWiperFluid";
            this.lblWiperFluid.Size = new System.Drawing.Size(57, 13);
            this.lblWiperFluid.TabIndex = 11;
            this.lblWiperFluid.Text = "Wiper fluid";
            // 
            // lblBrakeFluid
            // 
            this.lblBrakeFluid.AutoSize = true;
            this.lblBrakeFluid.Location = new System.Drawing.Point(178, 121);
            this.lblBrakeFluid.Name = "lblBrakeFluid";
            this.lblBrakeFluid.Size = new System.Drawing.Size(57, 13);
            this.lblBrakeFluid.TabIndex = 10;
            this.lblBrakeFluid.Text = "Brake fluid";
            this.lblBrakeFluid.Click += new System.EventHandler(this.lblBrakeFluid_Click);
            // 
            // lblFluids
            // 
            this.lblFluids.AutoSize = true;
            this.lblFluids.Location = new System.Drawing.Point(261, 101);
            this.lblFluids.Name = "lblFluids";
            this.lblFluids.Size = new System.Drawing.Size(34, 13);
            this.lblFluids.TabIndex = 9;
            this.lblFluids.Text = "Fluids";
            // 
            // txtBrakePads
            // 
            this.txtBrakePads.Location = new System.Drawing.Point(399, 174);
            this.txtBrakePads.Name = "txtBrakePads";
            this.txtBrakePads.ReadOnly = true;
            this.txtBrakePads.Size = new System.Drawing.Size(86, 20);
            this.txtBrakePads.TabIndex = 22;
            // 
            // txtCarBattery
            // 
            this.txtCarBattery.Location = new System.Drawing.Point(399, 146);
            this.txtCarBattery.Name = "txtCarBattery";
            this.txtCarBattery.ReadOnly = true;
            this.txtCarBattery.Size = new System.Drawing.Size(86, 20);
            this.txtCarBattery.TabIndex = 21;
            // 
            // txtSparkPlug
            // 
            this.txtSparkPlug.Location = new System.Drawing.Point(399, 119);
            this.txtSparkPlug.Name = "txtSparkPlug";
            this.txtSparkPlug.ReadOnly = true;
            this.txtSparkPlug.Size = new System.Drawing.Size(86, 20);
            this.txtSparkPlug.TabIndex = 20;
            // 
            // lblBrakePads
            // 
            this.lblBrakePads.AutoSize = true;
            this.lblBrakePads.Location = new System.Drawing.Point(338, 177);
            this.lblBrakePads.Name = "lblBrakePads";
            this.lblBrakePads.Size = new System.Drawing.Size(61, 13);
            this.lblBrakePads.TabIndex = 19;
            this.lblBrakePads.Text = "Brake pads";
            // 
            // lblCarBattery
            // 
            this.lblCarBattery.AutoSize = true;
            this.lblCarBattery.Location = new System.Drawing.Point(338, 149);
            this.lblCarBattery.Name = "lblCarBattery";
            this.lblCarBattery.Size = new System.Drawing.Size(58, 13);
            this.lblCarBattery.TabIndex = 18;
            this.lblCarBattery.Text = "Car battery";
            // 
            // lblSparkPlug
            // 
            this.lblSparkPlug.AutoSize = true;
            this.lblSparkPlug.Location = new System.Drawing.Point(339, 121);
            this.lblSparkPlug.Name = "lblSparkPlug";
            this.lblSparkPlug.Size = new System.Drawing.Size(58, 13);
            this.lblSparkPlug.TabIndex = 17;
            this.lblSparkPlug.Text = "Spark plug";
            // 
            // lblReplacementParts
            // 
            this.lblReplacementParts.AutoSize = true;
            this.lblReplacementParts.Location = new System.Drawing.Point(394, 101);
            this.lblReplacementParts.Name = "lblReplacementParts";
            this.lblReplacementParts.Size = new System.Drawing.Size(96, 13);
            this.lblReplacementParts.TabIndex = 16;
            this.lblReplacementParts.Text = "Replacement parts";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(399, 237);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(86, 20);
            this.txtQuantity.TabIndex = 23;
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.textBox10_Validating);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(348, 240);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(366, 269);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(399, 266);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(86, 21);
            this.cmbType.TabIndex = 26;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(364, 294);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(399, 291);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(86, 20);
            this.txtPrice.TabIndex = 29;
            // 
            // lstSale
            // 
            this.lstSale.FormattingEnabled = true;
            this.lstSale.Location = new System.Drawing.Point(502, 101);
            this.lstSale.Name = "lstSale";
            this.lstSale.Size = new System.Drawing.Size(174, 160);
            this.lstSale.TabIndex = 30;
            this.lstSale.SelectedIndexChanged += new System.EventHandler(this.lstSale_SelectedIndexChanged);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(502, 314);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(82, 29);
            this.btnAddToCart.TabIndex = 31;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(502, 348);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(82, 29);
            this.btnRemoveItem.TabIndex = 32;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(590, 314);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(86, 64);
            this.btnCheckOut.TabIndex = 33;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(590, 269);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(86, 20);
            this.txtTotal.TabIndex = 35;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(557, 271);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(55, 315);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(50, 13);
            this.lblFuelType.TabIndex = 39;
            this.lblFuelType.Text = "Fuel type";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(67, 266);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 38;
            this.lblModel.Text = "Model";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(34, 240);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 37;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(168, 213);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(23, 13);
            this.lblCar.TabIndex = 36;
            this.lblCar.Text = "Car";
            this.lblCar.Click += new System.EventHandler(this.lblCar_Click);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(107, 262);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(150, 21);
            this.cmbModel.TabIndex = 43;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(107, 237);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(150, 21);
            this.cmbManufacturer.TabIndex = 44;
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(107, 313);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(150, 21);
            this.cmbFuelType.TabIndex = 45;
            this.cmbFuelType.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cmbEngineSize
            // 
            this.cmbEngineSize.FormattingEnabled = true;
            this.cmbEngineSize.Location = new System.Drawing.Point(107, 338);
            this.cmbEngineSize.Name = "cmbEngineSize";
            this.cmbEngineSize.Size = new System.Drawing.Size(150, 21);
            this.cmbEngineSize.TabIndex = 46;
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(46, 340);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(61, 13);
            this.lblEngineSize.TabIndex = 47;
            this.lblEngineSize.Text = "Engine size";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(107, 287);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(150, 21);
            this.cmbYear.TabIndex = 49;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(67, 289);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 48;
            this.lblYear.Text = "Year";
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(180, 22);
            this.mnuStop.Text = "Stop";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 422);
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
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
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
        private System.Windows.Forms.ErrorProvider erpError;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mnuTires;
        private System.Windows.Forms.ToolStripMenuItem mnuWinterTires;
        private System.Windows.Forms.ToolStripMenuItem mnuSummerTires;
        private System.Windows.Forms.ToolStripMenuItem mnuAllSeasonTires;
        private System.Windows.Forms.ToolStripMenuItem mnuFluids;
        private System.Windows.Forms.ToolStripMenuItem mnuBrakeFluid;
        private System.Windows.Forms.ToolStripMenuItem mnuWiperFluid;
        private System.Windows.Forms.ToolStripMenuItem mnuEngineOil;
        private System.Windows.Forms.ToolStripMenuItem mnuReplacementParts;
        private System.Windows.Forms.ToolStripMenuItem mnuSparkPlug;
        private System.Windows.Forms.ToolStripMenuItem mnuCarBattery;
        private System.Windows.Forms.ToolStripMenuItem mnuBrakePads;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
    }
}

