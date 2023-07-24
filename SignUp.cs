using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitSoftware_SelfProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();  // create new sql connection obj

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            { // check if all of the items are filled in 
                if (txtFullName.Text != "" && txtUserName.Text != "" && textpw.Text != "" && textrepw.Text != "") 
                { // check if pw and retyped pw matches
                    if (textpw.Text != textrepw.Text)
                    { // if they don't match throw the error
                        MessageBox.Show("Password's don't match. Please check your passwords and try again. ");
                    }
                    else
                    { // if everything is filled && pw match create a connection and insert into the table
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                        SqlCommand cmd = new SqlCommand("INSERT into tb_User (fullName, userName, userPassword) Values ('" + txtFullName.Text + "','" + txtUserName.Text + "','" + textpw.Text + "','" + textrepw.Text + "')", con);
                        cmd.Connection = con; 

                        con.Open(); // open the sql connection 
                        cmd.ExecuteNonQuery(); // run the insert query 
                        con.Close(); // close the sql connection 
                    }
                }           
            }
            catch(Exception ex){ // if an error is caught print the error 
                MessageBox.Show(ex.Message); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show(); 
            this.Hide();
        }
    }
}
