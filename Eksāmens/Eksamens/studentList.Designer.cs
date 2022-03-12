
namespace Eksamens
{
    partial class studentList
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
            this.lvwStudentList = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.chStudentCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwStudentList
            // 
            this.lvwStudentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chLastName,
            this.chStudentCode,
            this.chCourse,
            this.chGrades});
            this.lvwStudentList.FullRowSelect = true;
            this.lvwStudentList.HideSelection = false;
            this.lvwStudentList.HoverSelection = true;
            this.lvwStudentList.Location = new System.Drawing.Point(121, 95);
            this.lvwStudentList.Name = "lvwStudentList";
            this.lvwStudentList.Size = new System.Drawing.Size(491, 259);
            this.lvwStudentList.TabIndex = 6;
            this.lvwStudentList.UseCompatibleStateImageBehavior = false;
            this.lvwStudentList.View = System.Windows.Forms.View.Details;
            this.lvwStudentList.SelectedIndexChanged += new System.EventHandler(this.lvwStudentList_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 30;
            // 
            // chName
            // 
            this.chName.Text = "Vārds";
            this.chName.Width = 100;
            // 
            // chLastName
            // 
            this.chLastName.Text = "Uzvārds";
            this.chLastName.Width = 100;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Atpakaļ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentList.Location = new System.Drawing.Point(274, 37);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(202, 25);
            this.lblStudentList.TabIndex = 4;
            this.lblStudentList.Text = "Studentu saraksts";
            this.lblStudentList.Click += new System.EventHandler(this.lblStudentList_Click);
            // 
            // chStudentCode
            // 
            this.chStudentCode.Text = "Studenta kods";
            this.chStudentCode.Width = 98;
            // 
            // chGrades
            // 
            this.chGrades.DisplayIndex = 4;
            this.chGrades.Text = "Atzīme";
            // 
            // chCourse
            // 
            this.chCourse.DisplayIndex = 5;
            this.chCourse.Text = "Kurss";
            // 
            // studentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwStudentList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblStudentList);
            this.Name = "studentList";
            this.Text = "studentList";
            this.Load += new System.EventHandler(this.studentList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwStudentList;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chStudentCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.ColumnHeader chCourse;
        private System.Windows.Forms.ColumnHeader chGrades;
    }
}