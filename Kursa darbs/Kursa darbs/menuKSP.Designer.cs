
namespace Kursa_darbs
{
    partial class menuKSP
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
            this.lblKSP = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lvwKSPList = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNoliktava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.lblKSP);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 76);
            this.panel1.TabIndex = 7;
            // 
            // lblKSP
            // 
            this.lblKSP.AutoSize = true;
            this.lblKSP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblKSP.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.lblKSP.Location = new System.Drawing.Point(380, 9);
            this.lblKSP.Name = "lblKSP";
            this.lblKSP.Size = new System.Drawing.Size(92, 57);
            this.lblKSP.TabIndex = 15;
            this.lblKSP.Text = "KSP";
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
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Iziet";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lvwKSPList
            // 
            this.lvwKSPList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwKSPList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chNoliktava,
            this.chCount});
            this.lvwKSPList.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwKSPList.FullRowSelect = true;
            this.lvwKSPList.HideSelection = false;
            this.lvwKSPList.HoverSelection = true;
            this.lvwKSPList.Location = new System.Drawing.Point(341, 128);
            this.lvwKSPList.Name = "lvwKSPList";
            this.lvwKSPList.Size = new System.Drawing.Size(209, 303);
            this.lvwKSPList.TabIndex = 8;
            this.lvwKSPList.UseCompatibleStateImageBehavior = false;
            this.lvwKSPList.View = System.Windows.Forms.View.Details;
            this.lvwKSPList.SelectedIndexChanged += new System.EventHandler(this.lvwStudentList_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 38;
            // 
            // chNoliktava
            // 
            this.chNoliktava.Text = "Noliktava";
            this.chNoliktava.Width = 106;
            // 
            // chCount
            // 
            this.chCount.Text = "Skaits";
            this.chCount.Width = 65;
            // 
            // menuKSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1000, 499);
            this.Controls.Add(this.lvwKSPList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuKSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuBalki";
            this.Load += new System.EventHandler(this.menuBalki_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListView lvwKSPList;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chNoliktava;
        private System.Windows.Forms.Label lblKSP;
        private System.Windows.Forms.ColumnHeader chCount;
    }
}