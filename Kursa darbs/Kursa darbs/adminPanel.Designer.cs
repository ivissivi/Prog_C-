
namespace Kursa_darbs
{
    partial class adminPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.pbxUsers = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbxEmployees = new System.Windows.Forms.PictureBox();
            this.pbxWarehouse = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 76);
            this.panel1.TabIndex = 10;
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
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblWarehouse.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblWarehouse.Location = new System.Drawing.Point(122, 318);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(176, 57);
            this.lblWarehouse.TabIndex = 9;
            this.lblWarehouse.Text = "Noliktava";
            this.lblWarehouse.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblEmployees.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblEmployees.Location = new System.Drawing.Point(398, 318);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(188, 57);
            this.lblEmployees.TabIndex = 12;
            this.lblEmployees.Text = "Darbinieki";
            // 
            // pbxUsers
            // 
            this.pbxUsers.AutoSize = true;
            this.pbxUsers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbxUsers.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbxUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pbxUsers.Location = new System.Drawing.Point(699, 318);
            this.pbxUsers.Name = "pbxUsers";
            this.pbxUsers.Size = new System.Drawing.Size(157, 57);
            this.pbxUsers.TabIndex = 14;
            this.pbxUsers.Text = "Lietotāji";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Kursa_darbs.Properties.Resources.multiple_users_silhouette;
            this.pictureBox2.Location = new System.Drawing.Point(709, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbxEmployees
            // 
            this.pbxEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEmployees.Image = global::Kursa_darbs.Properties.Resources.employees;
            this.pbxEmployees.Location = new System.Drawing.Point(418, 180);
            this.pbxEmployees.Name = "pbxEmployees";
            this.pbxEmployees.Size = new System.Drawing.Size(148, 135);
            this.pbxEmployees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEmployees.TabIndex = 13;
            this.pbxEmployees.TabStop = false;
            this.pbxEmployees.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pbxWarehouse
            // 
            this.pbxWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxWarehouse.Image = global::Kursa_darbs.Properties.Resources.warehouse;
            this.pbxWarehouse.Location = new System.Drawing.Point(132, 180);
            this.pbxWarehouse.Name = "pbxWarehouse";
            this.pbxWarehouse.Size = new System.Drawing.Size(148, 135);
            this.pbxWarehouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWarehouse.TabIndex = 11;
            this.pbxWarehouse.TabStop = false;
            this.pbxWarehouse.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1000, 499);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbxUsers);
            this.Controls.Add(this.pbxEmployees);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.pbxWarehouse);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminPanel";
            this.Click += new System.EventHandler(this.adminPanel_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.PictureBox pbxWarehouse;
        private System.Windows.Forms.PictureBox pbxEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label pbxUsers;
    }
}