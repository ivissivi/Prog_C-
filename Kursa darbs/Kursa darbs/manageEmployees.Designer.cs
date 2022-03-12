
namespace Kursa_darbs
{
    partial class manageEmployees
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
            this.lblEmployees = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.cbxEmployeePosition = new System.Windows.Forms.ComboBox();
            this.txtEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeePhoneNumber = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.pbxRefresh = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.lblEmployees);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 76);
            this.panel1.TabIndex = 12;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblEmployees.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.lblEmployees.Location = new System.Drawing.Point(369, 9);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(188, 57);
            this.lblEmployees.TabIndex = 13;
            this.lblEmployees.Text = "Darbinieki";
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
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(74, 159);
            this.txtEmployeeName.Multiline = true;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(142, 30);
            this.txtEmployeeName.TabIndex = 16;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(69, 128);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(58, 28);
            this.lblEmployeeName.TabIndex = 15;
            this.lblEmployeeName.Text = "Vārds";
            this.lblEmployeeName.Click += new System.EventHandler(this.lblEmployeeName_Click);
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = true;
            this.lblEmployeePosition.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblEmployeePosition.Location = new System.Drawing.Point(69, 204);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(72, 28);
            this.lblEmployeePosition.TabIndex = 17;
            this.lblEmployeePosition.Text = "Pozīcija";
            this.lblEmployeePosition.Click += new System.EventHandler(this.lblEmployeePosition_Click);
            // 
            // cbxEmployeePosition
            // 
            this.cbxEmployeePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEmployeePosition.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeePosition.FormattingEnabled = true;
            this.cbxEmployeePosition.Items.AddRange(new object[] {
            "Manager",
            "Developer",
            "Accountant",
            "System administrator",
            ""});
            this.cbxEmployeePosition.Location = new System.Drawing.Point(74, 235);
            this.cbxEmployeePosition.Name = "cbxEmployeePosition";
            this.cbxEmployeePosition.Size = new System.Drawing.Size(324, 36);
            this.cbxEmployeePosition.TabIndex = 18;
            this.cbxEmployeePosition.SelectedIndexChanged += new System.EventHandler(this.cbxEmployeePosition_SelectedIndexChanged);
            // 
            // txtEmployeePhoneNumber
            // 
            this.txtEmployeePhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtEmployeePhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePhoneNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePhoneNumber.Location = new System.Drawing.Point(74, 329);
            this.txtEmployeePhoneNumber.Multiline = true;
            this.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            this.txtEmployeePhoneNumber.Size = new System.Drawing.Size(171, 30);
            this.txtEmployeePhoneNumber.TabIndex = 21;
            this.txtEmployeePhoneNumber.TextChanged += new System.EventHandler(this.txtEmployeePhoneNumber_TextChanged);
            // 
            // lblEmployeePhoneNumber
            // 
            this.lblEmployeePhoneNumber.AutoSize = true;
            this.lblEmployeePhoneNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblEmployeePhoneNumber.Location = new System.Drawing.Point(69, 298);
            this.lblEmployeePhoneNumber.Name = "lblEmployeePhoneNumber";
            this.lblEmployeePhoneNumber.Size = new System.Drawing.Size(147, 28);
            this.lblEmployeePhoneNumber.TabIndex = 20;
            this.lblEmployeePhoneNumber.Text = "Telefona numurs";
            this.lblEmployeePhoneNumber.Click += new System.EventHandler(this.lblEmployeePhoneNumber_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnAddStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.btnAddStock.Location = new System.Drawing.Point(74, 403);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(104, 37);
            this.btnAddStock.TabIndex = 9;
            this.btnAddStock.Text = "Pievienot";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeLastName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLastName.Location = new System.Drawing.Point(256, 159);
            this.txtEmployeeLastName.Multiline = true;
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(142, 30);
            this.txtEmployeeLastName.TabIndex = 23;
            this.txtEmployeeLastName.TextChanged += new System.EventHandler(this.txtEmployeeLastName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblLastName.Location = new System.Drawing.Point(251, 128);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 28);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "Uzvārds";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnDeleteStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStock.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.btnDeleteStock.Location = new System.Drawing.Point(184, 403);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(104, 37);
            this.btnDeleteStock.TabIndex = 25;
            this.btnDeleteStock.Text = "Dzēst";
            this.btnDeleteStock.UseVisualStyleBackColor = false;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToResizeColumns = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.Location = new System.Drawing.Point(447, 128);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.ShowCellToolTips = false;
            this.dgvEmployees.ShowEditingIcon = false;
            this.dgvEmployees.Size = new System.Drawing.Size(525, 312);
            this.dgvEmployees.TabIndex = 26;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblName.Location = new System.Drawing.Point(549, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 28);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Vārds";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblSurname.Location = new System.Drawing.Point(657, 97);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(76, 28);
            this.lblSurname.TabIndex = 29;
            this.lblSurname.Text = "Uzvārds";
            this.lblSurname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblPosition.Location = new System.Drawing.Point(768, 97);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 28);
            this.lblPosition.TabIndex = 30;
            this.lblPosition.Text = "Pozīcija";
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(873, 97);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(69, 28);
            this.lblPhoneNumber.TabIndex = 31;
            this.lblPhoneNumber.Text = "Tel. nr.";
            this.lblPhoneNumber.Click += new System.EventHandler(this.lblPhoneNumber_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblEmployeeID.Location = new System.Drawing.Point(451, 97);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(30, 28);
            this.lblEmployeeID.TabIndex = 32;
            this.lblEmployeeID.Text = "ID";
            this.lblEmployeeID.Click += new System.EventHandler(this.lblEmployeeID_Click);
            // 
            // pbxRefresh
            // 
            this.pbxRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pbxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRefresh.Image = global::Kursa_darbs.Properties.Resources.refresh_icon_white_1;
            this.pbxRefresh.Location = new System.Drawing.Point(941, 446);
            this.pbxRefresh.Name = "pbxRefresh";
            this.pbxRefresh.Size = new System.Drawing.Size(31, 31);
            this.pbxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRefresh.TabIndex = 27;
            this.pbxRefresh.TabStop = false;
            this.pbxRefresh.Click += new System.EventHandler(this.pbxRefresh_Click);
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
            // manageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 499);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxRefresh);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnDeleteStock);
            this.Controls.Add(this.txtEmployeeLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.txtEmployeePhoneNumber);
            this.Controls.Add(this.lblEmployeePhoneNumber);
            this.Controls.Add(this.cbxEmployeePosition);
            this.Controls.Add(this.lblEmployeePosition);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manageEmployees";
            this.Load += new System.EventHandler(this.manageEmployees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeePosition;
        private System.Windows.Forms.ComboBox cbxEmployeePosition;
        private System.Windows.Forms.TextBox txtEmployeePhoneNumber;
        private System.Windows.Forms.Label lblEmployeePhoneNumber;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.PictureBox pbxRefresh;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmployeeID;
    }
}