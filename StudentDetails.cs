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

namespace WindowsFormsApp2
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
            string UserName = null;
            string Password = null;
            usernamelabel.Text = SignIn.username;
            labelPassword.Text = SignIn.password;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nitin\Desktop\WindowsFormsApp2\StudentDetails.mdf;Integrated Security=True";

             UserName = usernamelabel.Text;
            Password=labelPassword.Text;

            SqlConnection sqlConn = new SqlConnection(connection);
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select First_Name, Last_Name, Email from StudentRegistration where User_Name=@username and Password=@password ", sqlConn);

           sqlDA.SelectCommand.Parameters.AddWithValue("@username",  UserName);
            sqlDA.SelectCommand.Parameters.AddWithValue("@password", Password);

            DataTable students = new DataTable();




                sqlDA.Fill(students);
                dgStudent.DataSource = students;

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home he= new Home();
            he.Show();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection sqlConn = new SqlConnection(connection);
        //    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from StudentRegistration ", sqlConn);
        //    DataTable students = new DataTable();
        //    sqlDA.Fill(students);
        //    dgStudent.DataSource = students;

        //}
    }
}
