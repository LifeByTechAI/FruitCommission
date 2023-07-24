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
using System.Net.Sockets;
using System.Configuration;
using System.Security.Cryptography;

namespace FruitSoftware_SelfProject
{
    public partial class Expenditures : Form
    {
        public Expenditures()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        int ID;
        int wID;
        int rowID;

        private void Expenditures_Load(object sender, EventArgs e)
        { // loading initial data 
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from tb_Expanditure", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            DataGridExpenditures.DataSource = ds.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        { // delete
            try
            {
                if (MessageBox.Show("Do you want to delete the selected record?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                    SqlCommand cmd = new SqlCommand("Delete from tb_Expanditure where Id='" + ID + "'");
                    cmd.Connection = con;

                    MessageBox.Show("Expanditure Data Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);


                    // load null data so that you don't have to close/reopen tab
                    Expenditures_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { // update
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Update tb_Expanditure set CompanyID=@CompanyID,DriverCNIC=@DriverCNIC,FarmerCNIC=@FarmerCNIC,Quantity=@Quantity,TotalSale=@TotalSale, TruckRent=@TruckRent,TotalCommission=@TotalCommission,TotalExpanditure=@TotalExpanditure where Id= '" + ID + "'", con);

            con.Open();
            cmd.Parameters.AddWithValue("@CompanyID", txtCompanyId.Text);
            cmd.Parameters.AddWithValue("@DriverCNIC", txtDriverCnic.Text);
            cmd.Parameters.AddWithValue("@FarmerCNIC", txtFarmerCnic.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtQuant.Text);
            cmd.Parameters.AddWithValue("@TotalSale", txtTotalSale.Text);
            cmd.Parameters.AddWithValue("@TruckRent", TxtTruckRent.Text);
            cmd.Parameters.AddWithValue("@TotalCommission", txtTotalCommission.Text);
            cmd.Parameters.AddWithValue("@TotalExpanditure", txtTotalExpenditure.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Expanditure record updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // load null data so that you don't have to close/reopen tab
            Expenditures_Load(null, null);

        }

        private void button2_Click(object sender, EventArgs e)
        { // clear all btn
            txtCompanyId.Clear();
            txtDriverCnic.Clear();
            txtFarmerCnic.Clear();
            txtQuant.Clear();
            txtTotalSale.Clear();
            TxtTruckRent.Clear();
            txtTotalCommission.Clear();
            txtTotalExpenditure.Clear();

            // load null data so that you don't have to close/reopen tab
            Expenditures_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        { // save
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into tb_Expanditure values(@CompanyID,@DriverCNIC,@FarmerCNIC,@Quantity,@TotalSale, @TruckRent, @TotalCommission, @TotalExpanditure)", con);
            cmd.Connection = con;

            con.Open();
            cmd.Parameters.AddWithValue("@CompanyID", txtCompanyId.Text);
            cmd.Parameters.AddWithValue("@DriverCNIC", txtDriverCnic.Text);
            cmd.Parameters.AddWithValue("@FarmerCNIC", txtFarmerCnic.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtQuant.Text);
            cmd.Parameters.AddWithValue("@TotalSale", txtTotalSale.Text);
            cmd.Parameters.AddWithValue("@TruckRent", TxtTruckRent.Text);
            cmd.Parameters.AddWithValue("@TotalCommission", txtTotalCommission.Text);
            cmd.Parameters.AddWithValue("@TotalExpanditure", txtTotalExpenditure.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            // load null data so that you don't have to close/reopen tab
            Expenditures_Load(null, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Select * from tb_Expanditure where CompanyID LIKE '" + txtSearch.Text + "%'", con);
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                DataGridExpenditures.DataSource = ds.Tables[0];

                // load null data so that you don't have to close/reopen tab
                Expenditures_Load(null, null);
            }
        }

        private void DataGridExpenditures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridExpenditures.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ID = int.Parse(DataGridExpenditures.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Select * from tb_Expanditure where Id='" + ID + "'");
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                rowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtCompanyId.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDriverCnic.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFarmerCnic.Text = ds.Tables[0].Rows[0][3].ToString();
                txtQuant.Text = ds.Tables[0].Rows[0][4].ToString();
                txtTotalSale.Text = ds.Tables[0].Rows[0][5].ToString();
                TxtTruckRent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtTotalCommission.Text = ds.Tables[0].Rows[0][7].ToString();
                txtTotalExpenditure.Text = ds.Tables[0].Rows[0][8].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        { // search box 
            if (txtSearch.Text != "")
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Select * from tb_Expanditure where CompanyID LIKE '" + txtSearch.Text + "%'", con);
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                DataGridExpenditures.DataSource = ds.Tables[0];
            }
        }
    }
}
