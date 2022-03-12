
namespace Eksamens
{
    partial class Form1
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnSeniorStudent = new System.Windows.Forms.Button();
            this.lblPasniedzejam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(193, 104);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(418, 25);
            this.lblStudent.TabIndex = 17;
            this.lblStudent.Text = "Pasniedzēja atzīmju uzskaites sistēma";
            // 
            // btnSeniorStudent
            // 
            this.btnSeniorStudent.Location = new System.Drawing.Point(228, 214);
            this.btnSeniorStudent.Name = "btnSeniorStudent";
            this.btnSeniorStudent.Size = new System.Drawing.Size(167, 23);
            this.btnSeniorStudent.TabIndex = 18;
            this.btnSeniorStudent.Text = "Vecākajam studentam";
            this.btnSeniorStudent.UseVisualStyleBackColor = true;
            this.btnSeniorStudent.Click += new System.EventHandler(this.btnSeniorStudent_Click);
            // 
            // lblPasniedzejam
            // 
            this.lblPasniedzejam.Location = new System.Drawing.Point(423, 214);
            this.lblPasniedzejam.Name = "lblPasniedzejam";
            this.lblPasniedzejam.Size = new System.Drawing.Size(109, 23);
            this.lblPasniedzejam.TabIndex = 19;
            this.lblPasniedzejam.Text = "Pasniedzējam";
            this.lblPasniedzejam.UseVisualStyleBackColor = true;
            this.lblPasniedzejam.Click += new System.EventHandler(this.lblPasniedzejam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPasniedzejam);
            this.Controls.Add(this.btnSeniorStudent);
            this.Controls.Add(this.lblStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnSeniorStudent;
        private System.Windows.Forms.Button lblPasniedzejam;
    }
}

