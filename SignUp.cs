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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        //string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\StudentDetails.mdf;Integrated Security=True;";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        




        private void button1_Click(object sender, EventArgs e)
        {


           

            //string connection = @"Server=(LocalDB)\MSSQLLocalDB; Database=StudentDetails; Integrated Security=True";
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nitin\Desktop\WindowsFormsApp2\StudentDetails.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd;

            if (textFirstName.Text != null && textLastName.Text != null &&
                    textEmailId.Text != null && textUserName.Text != null &&
                    textPassword.Text != null && textConfirmPassword.Text != null)
            {
                try
                {
                    //string query = "Insert into StudentRegistration(First_Name,Last_Name,Email,User_Name,Password,Confirm_Password) " +
                    //    "Values('" + textFirstName.Text + "','" + textLastName.Text + "','" + textEmailId.Text + "','" + textUserName.Text + "','" + textPassword.Text + "'+'" + textConfirmPassword.Text + "')";
                    con.Open();
                    cmd = new SqlCommand("insert into StudentRegistration(First_Name,Last_Name,Email,User_Name,Password,Confirm_Password) values (@fullname,@lastname,@email,@username,@password,@confirmpassword)", con);


                    cmd.Parameters.AddWithValue("@fullname", textFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastname", textLastName.Text);
                    cmd.Parameters.AddWithValue("@email", textEmailId.Text);
                    cmd.Parameters.AddWithValue("@username", textUserName.Text);
                    cmd.Parameters.AddWithValue("@password", textPassword.Text);
                    cmd.Parameters.AddWithValue("@confirmpassword", textConfirmPassword.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Record Inserted Successfully");



                    ClearData();


                   

                }
                //catch
                //{
                //    MessageBox.Show("Error occured...");
                //}
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error reported by SQL Server, " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {

            }
        }
        //Clear data after submit
        private void ClearData()
        {
            textFirstName.Text = "";
            textLastName.Text = "";
            textEmailId.Text = "";
            textUserName.Text = "";
            textPassword.Text = "";
            textConfirmPassword.Text = "";
        }

       

        private void SignIn_Click(object sender, EventArgs e)
        {
            
            SignIn f1 = new SignIn();
            f1.Show();
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
    }

