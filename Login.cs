using fruitCommissionAgent;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); 
        }
        SqlConnection con = new SqlConnection(); //creates a sql connection obj. 


        private void btnLoginForm_Click(object sender, EventArgs e) 
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Select * from tb_User where userName='" + txtBoxUserName.Text + "' and userPassword = '" + txtBoxPassword.Text + "'");
                cmd.Connection = con; //creates the connection 

                SqlDataAdapter sda = new SqlDataAdapter(cmd); //Sends the commands to Sql Db
                DataSet ds = new DataSet(); //Initalizes obj. to hold the data
                sda.Fill(ds); // fills the data into the DataAdapter

                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide(); // if no data, hide this box
                    Home db = new Home(); 
                    db.Show();
                }
                else
                { 
                    MessageBox.Show("username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // show error message
            }
        }

        private void NewMember_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp(); //Creates a new obj of SignUp
            signup.Show(); //shows the popup
            this.Hide(); 
        }
    }


}
