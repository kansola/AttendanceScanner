using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            TeacherLogin teacherLogin = new TeacherLogin();
            teacherLogin.ShowDialog();
        }
    }
}
