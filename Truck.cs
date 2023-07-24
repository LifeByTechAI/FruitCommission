using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FruitSoftware_SelfProject
{
    public partial class Truck : Form
    {
        public Truck()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        int ID;
        int rowID;

        private void Truck_Load(object sender, EventArgs e)
        { // Load data to the inital track gridview
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Select * FROM tb_Truck", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            truckDataGrid.DataSource = ds.Tables[0];
        }
        private void truckDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        { // loads data into gridview

            if (truckDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ID = int.Parse(truckDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Parses data into the gridview ?????? ?????? ?????? ?????? ??????  
            }
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from tb_Truck", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            //Fills in the corresponding data grid
            rowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtTradeNumber.Text = ds.Tables[0].Rows[0][1].ToString();
            txtArrivalTime.Text = ds.Tables[0].Rows[0][3].ToString();
            txtRent.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void txtSearchTradeNo_TextChanged(object sender, EventArgs e)
        {
            try {
                if (txtSearchTradeNo.Text != "")
                {
                    SqlConnection con = new SqlConnection(); // new sql connection 
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                    SqlCommand cmd = new SqlCommand("Select * From tb_TradeNumber WHERE id = '" + txtSearchTradeNo.Text + '"', con);
                    cmd.Connection = con; // opens connection to send cmd

                    SqlDataAdapter sda = new SqlDataAdapter(); // new data adaptor
                    DataSet ds = new DataSet(); // actual data 
                    sda.Fill(ds); // fits data to the frame or data adaptor

                    truckDataGrid.DataSource = ds.Tables[0];
                }
                else { // if can not load specific trade number, loads * 
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                    SqlCommand cmd = new SqlCommand("Select * from tb_Truck", con);
                    cmd.Connection = con; 

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    truckDataGrid.DataSource = ds.Tables[0]; //shows table 0
                }
            } catch (Exception ex) { // if any error is thrown - show error
                MessageBox.Show(ex.Message);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        { // calls the method below that will clear all of the fields
           ClearAll();
        }

        private void ClearAll()
        {// clears date inside the fields boxs of trade number,arrival time, rent and truck number
            txtTradeNumber.Clear();
            txtArrivalTime.Clear();
            txtRent.Clear();
            txtTruckNumber.Clear();
            txtSearchTradeNo.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Pulls connection settings to connect with the database
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            // Holds cmd to send to the sql db
            SqlCommand cmd = new SqlCommand("Insert into tb_Truck Values(@TradeNumber,@ArrivalTime, @TruckNumber,@Rent)", con);

            con.Open(); // open the connection and send with parameters 
            cmd.Parameters.AddWithValue("@ArrivalTime", txtArrivalTime.Text);
            cmd.Parameters.AddWithValue("@Rent", txtRent.Text);
            cmd.Parameters.AddWithValue("@TruckNumber", txtTruckNumber.Text);
            cmd.Parameters.AddWithValue("@TradeNumber", txtTradeNumber.Text);
        
            cmd.ExecuteNonQuery(); // executes the cmd 
            con.Close(); // closes the connection
            MessageBox.Show("Congradulations, you have saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Truck_Load(null, null); // what does this do? 
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Pulls connection settings to connect with the database
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            // Holds cmd to send to the sql db
            SqlCommand cmd = new SqlCommand("UPDATE tb_Truck set TruckNumber=@TruckNumber,Rent=@Rent,TradeNumber=@TradeNumber where id= '" + ID + "'", con);

            con.Open(); // open the connection and send with parameters 
            cmd.Parameters.AddWithValue("@TradeNumber ", txtTradeNumber.Text);
            cmd.Parameters.AddWithValue("@Rent", txtRent.Text); 
            cmd.Parameters.AddWithValue("@TruckNumber", txtTruckNumber.Text);
            cmd.Parameters.AddWithValue("@ArrivalTime", txtArrivalTime.Text);
        
            
            cmd.ExecuteNonQuery (); // runs the query to the database
            con.Close(); // closes the connection right after

            MessageBox.Show("Successfully updated Truck Record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Truck_Load(this,null); // avoids needing to reopen the grid
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try { // Confirm user would like to take the deleting option
            if(MessageBox.Show("Are you sure you want to delete the selected record?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes);
                // opens con obj with connection string and sends the sql command
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Delete From tb_Truck Where id='" + ID + "'");
                cmd.Connection = con; //create a connection icon 


                con.Open(); // open 
                cmd.ExecuteNonQuery(); // execute non query 
                con.Close (); // close 

                //Show message box after deleting the record and send the cmd to sql + load new data
                MessageBox.Show("Truck Data Record Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlDataAdapter sda = new SqlDataAdapter(cmd); // Frame to store data
                DataSet ds = new DataSet(); // stores the dataset from sql query
                sda.Fill(ds); // fills frame with data from ds 
                Truck_Load(this, null); // avoids needing to reopen the grid

            } catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
