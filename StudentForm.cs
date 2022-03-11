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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nitin\Desktop\WindowsFormsApp2\StudentDetails.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd;

            if (textStudentId.Text != null && textCourseName.Text != null )
            {
                try
                {
                    
                    con.Open();
                    cmd = new SqlCommand("insert into StudentForm(Id,Course_Name) values (@id,@coursename)", con);


                    cmd.Parameters.AddWithValue("@id", textStudentId.Text);
                    cmd.Parameters.AddWithValue("@coursename", textCourseName.Text);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Student Form Inserted Successfully");



                    ClearData();


                    

                }
                
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
            textStudentId.Text = "";
            textCourseName.Text = "";
          
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}

