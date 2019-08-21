using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceScanner
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            byte response = 0;
            string username = adminUsername.Text;
            username = username.Trim();
            string password = adminPassword.Text;
            password = password.Trim();
            string attendanceConnString = "Data Source=TECH-SYS23\\SQLEXPRESS;Initial Catalog=AttendanceSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(attendanceConnString);
            SqlCommand com = new SqlCommand("CheckIfUserExists", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@username",username);
            com.Parameters.AddWithValue("@password", password);
            com.Parameters.Add(new SqlParameter("@result", SqlDbType.TinyInt));

            com.Parameters["@result"].Direction = ParameterDirection.Output;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                response = Convert.ToByte(com.Parameters["@result"].Value);
            }
            catch (SqlException error)
            {

                throw error;
            }
            finally
            {
                con.Close();
            }

            if (response == 1)
            {
                AdminIndex adminIndex = new AdminIndex();
                adminIndex.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect login details!!!");
            }
        }
    }
}
