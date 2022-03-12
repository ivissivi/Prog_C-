
namespace Car_Parts_Dealership
{
    partial class frmClientList
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
            this.lblClientList = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lvwClientsList = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblClientList
            // 
            this.lblClientList.AutoSize = true;
            this.lblClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientList.Location = new System.Drawing.Point(366, 41);
            this.lblClientList.Name = "lblClientList";
            this.lblClientList.Size = new System.Drawing.Size(111, 25);
            this.lblClientList.TabIndex = 0;
            this.lblClientList.Text = "Client list";
            this.lblClientList.Click += new System.EventHandler(this.lblClientList_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(697, 395);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lvwClientsList
            // 
            this.lvwClientsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chLastName});
            this.lvwClientsList.FullRowSelect = true;
            this.lvwClientsList.HideSelection = false;
            this.lvwClientsList.HoverSelection = true;
            this.lvwClientsList.Location = new System.Drawing.Point(213, 99);
            this.lvwClientsList.Name = "lvwClientsList";
            this.lvwClientsList.Size = new System.Drawing.Size(402, 259);
            this.lvwClientsList.TabIndex = 3;
            this.lvwClientsList.UseCompatibleStateImageBehavior = false;
            this.lvwClientsList.View = System.Windows.Forms.View.Details;
            this.lvwClientsList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 30;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 100;
            // 
            // chLastName
            // 
            this.chLastName.Text = "Last name";
            this.chLastName.Width = 100;
            // 
            // frmClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwClientsList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblClientList);
            this.Name = "frmClientList";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmClientList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvwClientsList;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLastName;
    }
}