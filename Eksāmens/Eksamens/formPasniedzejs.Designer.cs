
namespace Eksamens
{
    partial class formPasniedzejs
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
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.lblStudentCode = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnStudentList = new System.Windows.Forms.Button();
            this.btnCourseList = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(347, 288);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(100, 20);
            this.txtStudentCode.TabIndex = 21;
            this.txtStudentCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblStudentCode
            // 
            this.lblStudentCode.AutoSize = true;
            this.lblStudentCode.Location = new System.Drawing.Point(251, 291);
            this.lblStudentCode.Name = "lblStudentCode";
            this.lblStudentCode.Size = new System.Drawing.Size(76, 13);
            this.lblStudentCode.TabIndex = 20;
            this.lblStudentCode.Text = "Studenta kods";
            this.lblStudentCode.Click += new System.EventHandler(this.lblStudentCode_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(316, 340);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(159, 23);
            this.btnAddStudent.TabIndex = 19;
            this.btnAddStudent.Text = "Pievienot studentu";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(347, 236);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 18;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(347, 190);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 17;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(191, 87);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(418, 25);
            this.lblStudent.TabIndex = 16;
            this.lblStudent.Text = "Pasniedzēja atzīmju uzskaites sistēma";
            this.lblStudent.Click += new System.EventHandler(this.lblStudent_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(237, 239);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 13);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Studenta uzvārds";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(248, 193);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Studenta vārds";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnStudentList
            // 
            this.btnStudentList.Location = new System.Drawing.Point(316, 369);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(159, 23);
            this.btnStudentList.TabIndex = 22;
            this.btnStudentList.Text = "Parādīt studentu sarakstu";
            this.btnStudentList.UseVisualStyleBackColor = true;
            this.btnStudentList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnCourseList
            // 
            this.btnCourseList.Location = new System.Drawing.Point(316, 398);
            this.btnCourseList.Name = "btnCourseList";
            this.btnCourseList.Size = new System.Drawing.Size(159, 23);
            this.btnCourseList.TabIndex = 23;
            this.btnCourseList.Text = "Parādīt kursu sarakstu";
            this.btnCourseList.UseVisualStyleBackColor = true;
            this.btnCourseList.Click += new System.EventHandler(this.btnCourseList_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Atpakaļ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formPasniedzejs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCourseList);
            this.Controls.Add(this.btnStudentList);
            this.Controls.Add(this.txtStudentCode);
            this.Controls.Add(this.lblStudentCode);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Name = "formPasniedzejs";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.Label lblStudentCode;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnStudentList;
        private System.Windows.Forms.Button btnCourseList;
        private System.Windows.Forms.Button btnBack;
    }
}