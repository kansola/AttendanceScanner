namespace AttendanceScanner
{
    partial class AdminLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminUsername = new System.Windows.Forms.TextBox();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // adminUsername
            // 
            this.adminUsername.Location = new System.Drawing.Point(178, 106);
            this.adminUsername.Name = "adminUsername";
            this.adminUsername.Size = new System.Drawing.Size(294, 26);
            this.adminUsername.TabIndex = 2;
            // 
            // adminPassword
            // 
            this.adminPassword.Location = new System.Drawing.Point(178, 170);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.Size = new System.Drawing.Size(294, 26);
            this.adminPassword.TabIndex = 3;
            this.adminPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.Location = new System.Drawing.Point(270, 265);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(147, 41);
            this.adminLoginBtn.TabIndex = 4;
            this.adminLoginBtn.Text = "Login";
            this.adminLoginBtn.UseVisualStyleBackColor = true;
            this.adminLoginBtn.Click += new System.EventHandler(this.adminLoginBtn_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminLoginBtn);
            this.Controls.Add(this.adminPassword);
            this.Controls.Add(this.adminUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminLogin";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminUsername;
        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.Button adminLoginBtn;
    }
}