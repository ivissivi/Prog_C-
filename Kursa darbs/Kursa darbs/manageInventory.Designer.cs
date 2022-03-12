
namespace Kursa_darbs
{
    partial class manageInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblTimber = new System.Windows.Forms.Label();
            this.pbxRefresh = new System.Windows.Forms.PictureBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblStockCount = new System.Windows.Forms.Label();
            this.cbxWarehouseLocation = new System.Windows.Forms.ComboBox();
            this.lblWarehouseLocation = new System.Windows.Forms.Label();
            this.lblTimberType = new System.Windows.Forms.Label();
            this.cbxTimberType = new System.Windows.Forms.ComboBox();
            this.cbxStockCount = new System.Windows.Forms.ComboBox();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.lblWarehouse);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 76);
            this.panel1.TabIndex = 11;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblWarehouse.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.lblWarehouse.Location = new System.Drawing.Point(369, 9);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(176, 57);
            this.lblWarehouse.TabIndex = 14;
            this.lblWarehouse.Text = "Noliktava";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.btnLogOut.Location = new System.Drawing.Point(838, 20);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(134, 37);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Iziet";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnHome.BackgroundImage = global::Kursa_darbs.Properties.Resources._335_3354019_white_home_button_icon_png_for_kids_white;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(27, 16);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 46);
            this.btnHome.TabIndex = 7;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblEmployeeID.Location = new System.Drawing.Point(451, 98);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(30, 28);
            this.lblEmployeeID.TabIndex = 49;
            this.lblEmployeeID.Text = "ID";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblCount.Location = new System.Drawing.Point(833, 98);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(59, 28);
            this.lblCount.TabIndex = 48;
            this.lblCount.Text = "Skaits";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblPosition.Location = new System.Drawing.Point(716, 98);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(87, 28);
            this.lblPosition.TabIndex = 47;
            this.lblPosition.Text = "Noliktava";
            // 
            // lblTimber
            // 
            this.lblTimber.AutoSize = true;
            this.lblTimber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblTimber.Location = new System.Drawing.Point(549, 98);
            this.lblTimber.Name = "lblTimber";
            this.lblTimber.Size = new System.Drawing.Size(114, 28);
            this.lblTimber.TabIndex = 45;
            this.lblTimber.Text = "Kokmateriāli";
            // 
            // pbxRefresh
            // 
            this.pbxRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pbxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRefresh.Image = global::Kursa_darbs.Properties.Resources.refresh_icon_white_1;
            this.pbxRefresh.Location = new System.Drawing.Point(941, 447);
            this.pbxRefresh.Name = "pbxRefresh";
            this.pbxRefresh.Size = new System.Drawing.Size(31, 31);
            this.pbxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRefresh.TabIndex = 44;
            this.pbxRefresh.TabStop = false;
            this.pbxRefresh.Click += new System.EventHandler(this.pbxRefresh_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.Location = new System.Drawing.Point(447, 129);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.ShowCellToolTips = false;
            this.dgvStock.ShowEditingIcon = false;
            this.dgvStock.Size = new System.Drawing.Size(525, 312);
            this.dgvStock.TabIndex = 43;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnDeleteEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(294, 404);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(104, 37);
            this.btnDeleteEmployee.TabIndex = 42;
            this.btnDeleteEmployee.Text = "Dzēst";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.btnAddEmployee.Location = new System.Drawing.Point(74, 404);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(104, 37);
            this.btnAddEmployee.TabIndex = 33;
            this.btnAddEmployee.Text = "Pievienot";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblStockCount
            // 
            this.lblStockCount.AutoSize = true;
            this.lblStockCount.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblStockCount.Location = new System.Drawing.Point(69, 299);
            this.lblStockCount.Name = "lblStockCount";
            this.lblStockCount.Size = new System.Drawing.Size(59, 28);
            this.lblStockCount.TabIndex = 38;
            this.lblStockCount.Text = "Skaits";
            // 
            // cbxWarehouseLocation
            // 
            this.cbxWarehouseLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxWarehouseLocation.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWarehouseLocation.FormattingEnabled = true;
            this.cbxWarehouseLocation.Items.AddRange(new object[] {
            "Valmiera",
            "Jelgava",
            "Daugavpils",
            "Tukums",
            "Ventspils",
            "Liepāja",
            "Smiltene"});
            this.cbxWarehouseLocation.Location = new System.Drawing.Point(74, 236);
            this.cbxWarehouseLocation.Name = "cbxWarehouseLocation";
            this.cbxWarehouseLocation.Size = new System.Drawing.Size(324, 36);
            this.cbxWarehouseLocation.TabIndex = 37;
            // 
            // lblWarehouseLocation
            // 
            this.lblWarehouseLocation.AutoSize = true;
            this.lblWarehouseLocation.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblWarehouseLocation.Location = new System.Drawing.Point(69, 205);
            this.lblWarehouseLocation.Name = "lblWarehouseLocation";
            this.lblWarehouseLocation.Size = new System.Drawing.Size(87, 28);
            this.lblWarehouseLocation.TabIndex = 36;
            this.lblWarehouseLocation.Text = "Noliktava";
            // 
            // lblTimberType
            // 
            this.lblTimberType.AutoSize = true;
            this.lblTimberType.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimberType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblTimberType.Location = new System.Drawing.Point(69, 129);
            this.lblTimberType.Name = "lblTimberType";
            this.lblTimberType.Size = new System.Drawing.Size(114, 28);
            this.lblTimberType.TabIndex = 34;
            this.lblTimberType.Text = "Kokmateriāli";
            // 
            // cbxTimberType
            // 
            this.cbxTimberType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTimberType.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimberType.FormattingEnabled = true;
            this.cbxTimberType.Items.AddRange(new object[] {
            "Baļķi",
            "Brusas",
            "Dēļi",
            "Finieris",
            "KSP",
            "Spundēti dēļi",
            "CLT-paneļi"});
            this.cbxTimberType.Location = new System.Drawing.Point(74, 160);
            this.cbxTimberType.Name = "cbxTimberType";
            this.cbxTimberType.Size = new System.Drawing.Size(324, 36);
            this.cbxTimberType.TabIndex = 50;
            // 
            // cbxStockCount
            // 
            this.cbxStockCount.DropDownHeight = 100;
            this.cbxStockCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxStockCount.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStockCount.FormattingEnabled = true;
            this.cbxStockCount.IntegralHeight = false;
            this.cbxStockCount.ItemHeight = 28;
            this.cbxStockCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cbxStockCount.Location = new System.Drawing.Point(74, 330);
            this.cbxStockCount.Name = "cbxStockCount";
            this.cbxStockCount.Size = new System.Drawing.Size(54, 36);
            this.cbxStockCount.TabIndex = 51;
            this.cbxStockCount.SelectedIndexChanged += new System.EventHandler(this.cbxStockCount_SelectedIndexChanged);
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnRemoveStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStock.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.btnRemoveStock.Location = new System.Drawing.Point(184, 404);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(104, 37);
            this.btnRemoveStock.TabIndex = 52;
            this.btnRemoveStock.Text = "Noņemt";
            this.btnRemoveStock.UseVisualStyleBackColor = false;
            this.btnRemoveStock.Click += new System.EventHandler(this.btnRemoveStock_Click);
            // 
            // manageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1000, 499);
            this.Controls.Add(this.btnRemoveStock);
            this.Controls.Add(this.cbxStockCount);
            this.Controls.Add(this.cbxTimberType);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblTimber);
            this.Controls.Add(this.pbxRefresh);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lblStockCount);
            this.Controls.Add(this.cbxWarehouseLocation);
            this.Controls.Add(this.lblWarehouseLocation);
            this.Controls.Add(this.lblTimberType);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manageInventory";
            this.Load += new System.EventHandler(this.manageInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblTimber;
        private System.Windows.Forms.PictureBox pbxRefresh;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblStockCount;
        private System.Windows.Forms.ComboBox cbxWarehouseLocation;
        private System.Windows.Forms.Label lblWarehouseLocation;
        private System.Windows.Forms.Label lblTimberType;
        private System.Windows.Forms.ComboBox cbxTimberType;
        private System.Windows.Forms.ComboBox cbxStockCount;
        private System.Windows.Forms.Button btnRemoveStock;
    }
}