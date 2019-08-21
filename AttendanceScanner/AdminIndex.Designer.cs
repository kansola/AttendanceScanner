namespace AttendanceScanner
{
    partial class AdminIndex
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
            this.AddTeachersBtn = new System.Windows.Forms.Button();
            this.AddStudentsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTeachersBtn
            // 
            this.AddTeachersBtn.Location = new System.Drawing.Point(78, 124);
            this.AddTeachersBtn.Name = "AddTeachersBtn";
            this.AddTeachersBtn.Size = new System.Drawing.Size(174, 115);
            this.AddTeachersBtn.TabIndex = 0;
            this.AddTeachersBtn.Text = "Add Teachers";
            this.AddTeachersBtn.UseVisualStyleBackColor = true;
            this.AddTeachersBtn.Click += new System.EventHandler(this.AddTeachersBtn_Click);
            // 
            // AddStudentsBtn
            // 
            this.AddStudentsBtn.Location = new System.Drawing.Point(453, 124);
            this.AddStudentsBtn.Name = "AddStudentsBtn";
            this.AddStudentsBtn.Size = new System.Drawing.Size(174, 115);
            this.AddStudentsBtn.TabIndex = 1;
            this.AddStudentsBtn.Text = "Add Students";
            this.AddStudentsBtn.UseVisualStyleBackColor = true;
            this.AddStudentsBtn.Click += new System.EventHandler(this.AddStudentsBtn_Click);
            // 
            // AdminIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddStudentsBtn);
            this.Controls.Add(this.AddTeachersBtn);
            this.Name = "AdminIndex";
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddTeachersBtn;
        private System.Windows.Forms.Button AddStudentsBtn;
    }
}