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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

      
       
        public static string username = "";
        public static string password = "";


        private void button2_Click(object sender, EventArgs e)
        {
            SignUp up = new SignUp();
            up.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textUserName.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nitin\Desktop\WindowsFormsApp2\StudentDetails.mdf;Integrated Security=True";
                //Create SqlConnection
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand("Select * from StudentRegistration where User_Name=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", textUserName.Text);
                cmd.Parameters.AddWithValue("@password", textPassword.Text);
                
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                username=textUserName.Text;
                password=textPassword.Text;
                con.Close();
                

                            int count = ds.Tables[0].Rows.Count;
            //If count is equal to 1, than show frmMain form
            if (count == 1)
            {

                    
                    MessageBox.Show("Login Successful!");
                    
                this.Hide();
                    
                       Home nav = new Home();
                    nav.Show();
                       
                    }




                
                else
            {
                MessageBox.Show("Login Failed!");
            }
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void SignIn_Load(object sender, EventArgs e)
        {
           
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
