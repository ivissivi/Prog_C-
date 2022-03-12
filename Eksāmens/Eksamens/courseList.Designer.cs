
namespace Eksamens
{
    partial class courseList
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
            this.lvwCourseList = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLecturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCourseList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwCourseList
            // 
            this.lvwCourseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chLecturer});
            this.lvwCourseList.FullRowSelect = true;
            this.lvwCourseList.HideSelection = false;
            this.lvwCourseList.HoverSelection = true;
            this.lvwCourseList.Location = new System.Drawing.Point(187, 83);
            this.lvwCourseList.Name = "lvwCourseList";
            this.lvwCourseList.Size = new System.Drawing.Size(241, 259);
            this.lvwCourseList.TabIndex = 9;
            this.lvwCourseList.UseCompatibleStateImageBehavior = false;
            this.lvwCourseList.View = System.Windows.Forms.View.Details;
            this.lvwCourseList.SelectedIndexChanged += new System.EventHandler(this.lvwCourseList_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 30;
            // 
            // chName
            // 
            this.chName.Text = "Nosaukums";
            this.chName.Width = 100;
            // 
            // chLecturer
            // 
            this.chLecturer.Text = "Pasniedzējs";
            this.chLecturer.Width = 100;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Atpakaļ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCourseList
            // 
            this.lblCourseList.AutoSize = true;
            this.lblCourseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseList.Location = new System.Drawing.Point(220, 25);
            this.lblCourseList.Name = "lblCourseList";
            this.lblCourseList.Size = new System.Drawing.Size(169, 25);
            this.lblCourseList.TabIndex = 7;
            this.lblCourseList.Text = "Kursu saraksts";
            // 
            // courseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwCourseList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCourseList);
            this.Name = "courseList";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.courseList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwCourseList;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLecturer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCourseList;
    }
}