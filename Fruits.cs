using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetProjectType_FruitCommission
{
    public partial class Fruits : Form
    {
        public Fruits()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection();
        int ID;
        int rowID; 

        private void Fruits_Load(object sender, EventArgs e)
        { // Pulls all of the data on load 
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from tb_Fruit", con); // new sql command
            cmd.Connection = con; 

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            // Display data into the datagrid obj.
            datagridFruit.DataSource = ds.Tables[0];
        }

        private void txtSearchCNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCNIC.Text != "") { 
            // open connection, find similar records to the current text
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Select * from tb_Fruit where FCNIC LIKE '"+ txtSearchCNIC.Text+"'", con);
                cmd.Connection = con; 

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                datagridFruit.DataSource = ds.Tables[0];

            }
        }

        private void btnClear_Click(object sender, EventArgs e) // testing new method.
        { // Clears all of the text inside any of the boxes
            txtSearchCNIC.Text = string.Empty;
            txtStockNumber.Text = string.Empty;
            txtSalePerStock.Text = string.Empty;
            txtFruitName.Text = string.Empty;
            txtTradeNumber.Text = string.Empty;
            txtFarmerCNIC.Text = string.Empty;
            txtDate.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Delete from tb_Fruit where Id='"+ID+"'", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            MessageBox.Show("Fruit record deleted successfully.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Fruits_Load(this, null);

       }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Update tb_Fruit set FNIC=@FNIC, Date=@Date, FruitName=@FN, StockNo=@StockN, SalePerStock =@SPS,TradeNo=@TN", con);
            cmd.Connection = con;

            con.Open();
            cmd.Parameters.AddWithValue("@FNIC", txtFarmerCNIC.Text);
            cmd.Parameters.AddWithValue("@Date", txtDate.Text);
            cmd.Parameters.AddWithValue("@FN", txtFruitName.Text);
            cmd.Parameters.AddWithValue("@StockN", txtStockNumber.Text);
            cmd.Parameters.AddWithValue("@SPS",txtSalePerStock.Text);
            cmd.Parameters.AddWithValue("@TN",txtTradeNumber.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Fruits_Load(this, null);
        }   

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("INSERT into tb_Fruit values(@FNIC,@Date,@FruitName,@StockNo,@SalePerStock,@TradeNumber)",con);

            con.Open();
            cmd.Parameters.AddWithValue("@FNIC",txtFarmerCNIC.Text);
            cmd.Parameters.AddWithValue("@Date",txtDate.Text);
            cmd.Parameters.AddWithValue("@FruitName", txtFruitName.Text);
            cmd.Parameters.AddWithValue("@StockNo", txtStockNumber.Text);
            cmd.Parameters.AddWithValue("@SalePerStock", txtSalePerStock.Text);
            cmd.Parameters.AddWithValue("@TradeNumber", txtTradeNumber.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully added Fruit", "info", MessageBoxButtons.OK,MessageBoxIcon.Information);

            Fruits_Load(null, null);
        }

        private void datagridFruit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (datagridFruit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                { // parse the table and get the rows and values
                    ID = int.Parse(datagridFruit.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                // new connection
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                // new sql command 
                SqlCommand cmd = new SqlCommand("Select * from tb_Fruit where Id = '" + ID + "'");
                // create a new connection with the sql command 
                cmd.Connection = con;

                // create a new data frame 
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                // obj to hold the actual data 
                DataSet ds = new DataSet();
                // fills the data frame with the data in the ds obj.
                sda.Fill(ds);

                // goes through each item and parses the data adding var to corresponding table row
                rowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtFarmerCNIC.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDate.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFruitName.Text = ds.Tables[0].Rows[0][3].ToString();
                txtStockNumber.Text = ds.Tables[0].Rows[0][4].ToString();
                txtSalePerStock.Text = ds.Tables[0].Rows[0][5].ToString();
                txtTradeNumber.Text = ds.Tables[0].Rows[0][6].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void datagridFruit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
