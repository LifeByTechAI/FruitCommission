using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitSoftware_SelfProject
{
    public partial class Farmer : Form
    {
        public Farmer()
        {
            InitializeComponent();
        }
            
        SqlConnection con = new SqlConnection();
        int ID;
        int RowID; 
        private void Farmer_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_Farmer", con);
            cmd.Connection = con; 

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            datagridFarmer.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Confirm intent to Delete?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Yes);
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Delete from tb_Farmer where Farmer_Id='" + ID+"'", con);
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                MessageBox.Show("successfully deleted!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Farmer_Load(this, null);
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { // Saves the updated record when editing from the table 
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Update tb_Farmer set TraderName=@TraderName,FCNIC=@FCNIC,FarmerMobileNumber=@FarmerMobileNumber,FarmerAddress=@FarmerAddress,FarmerCity=@FarmerCity, FarmerProvince=@FarmerProvince where Farmer_Id= '" + ID + "'", con);
            con.Open();

            cmd.Parameters.AddWithValue("@TraderName", txtTraderName.Text);
            cmd.Parameters.AddWithValue("@FCNIC", txtFarmerCNIC.Text);
            cmd.Parameters.AddWithValue("@FarmerMobileNumber", txtMobileNumber.Text);
            cmd.Parameters.AddWithValue("@FarmerAddress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@FarmerCity", txtCity.Text);
            cmd.Parameters.AddWithValue("@FarmerProvince", txtProvince.Text);

            // executed query with the cmd obj holding the sql command 
            cmd.ExecuteNonQuery();
            con.Close(); // close connection after execution

            // show success message after execution
            MessageBox.Show("Farmer record updated .", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Farmer_Load(this, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // sql connection configuration && sql command 
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into tb_Farmer values (@TraderName,@FCNIC,@FarmberMobileNumber,@FarmerAddress,@FarmerCity,@FarmerProvince)", con);

            con.Open(); // open connection 
            cmd.Parameters.AddWithValue("@TraderName", txtTraderName.Text);
            cmd.Parameters.AddWithValue("@FCNIC", txtMobileNumber.Text);
            cmd.Parameters.AddWithValue("@FarmberMobileNumber", txtAddress.Text);
            cmd.Parameters.AddWithValue("@FarmerAddress", txtCity.Text);
            cmd.Parameters.AddWithValue("@FarmerCity", txtProvince.Text);
            cmd.Parameters.AddWithValue("@FarmerProvince", txtProvince.Text);

            cmd.ExecuteNonQuery(); // execute query with parameters
            con.Close(); // close connection 

            //print success message
            MessageBox.Show("Farmer record created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Farmer_Load(null, null);
        }

        private void datagridFarmer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datagridFarmer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ID = int.Parse(datagridFarmer.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                //Connection
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Select * from tb_Farmer where Farmer_Id= '" + ID + "'");
                cmd.Connection = con;

                //Data 
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                //Fill corresponding data for each row in table 
                RowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                //Data for each row
                txtTraderName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFarmerCNIC.Text = ds.Tables[0].Rows[0][2].ToString();
                txtMobileNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][5].ToString();
                txtProvince.Text = ds.Tables[0].Rows[0][6].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {

                txtTraderName.Text = string.Empty;
                txtFarmerCNIC.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtProvince.Text = string.Empty;
                txtMobileNumber.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchCNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCNIC.Text != "")
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Select * from tb_Farmer where FCNIC LIKE '" + txtSearchCNIC.Text + "%'", con);
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                datagridFarmer.DataSource = ds.Tables[0];
                //Products_Load(this, null);

            }
        }

    }      
}
