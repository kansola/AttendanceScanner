namespace AttendanceScanner
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
            this.label3 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Button();
            this.Teacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(95, 162);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(126, 120);
            this.Admin.TabIndex = 3;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Teacher
            // 
            this.Teacher.Location = new System.Drawing.Point(490, 162);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(126, 120);
            this.Teacher.TabIndex = 4;
            this.Teacher.Text = "Teacher";
            this.Teacher.UseVisualStyleBackColor = true;
            this.Teacher.Click += new System.EventHandler(this.Teacher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Teacher;
    }
}

