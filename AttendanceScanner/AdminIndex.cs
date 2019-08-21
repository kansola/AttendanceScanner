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
    public partial class AdminIndex : Form
    {
        public AdminIndex()
        {
            InitializeComponent();
        }

        private void AddTeachersBtn_Click(object sender, EventArgs e)
        {
            AddTeachers addTeachers = new AddTeachers();
            addTeachers.ShowDialog();
        }

        private void AddStudentsBtn_Click(object sender, EventArgs e)
        {
            AddStudents addStudents = new AddStudents();
            addStudents.ShowDialog();
        }
    }
}
