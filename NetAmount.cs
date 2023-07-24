using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FruitSoftware_SelfProject
{
    public partial class NetAmount : Form
    {
        public NetAmount()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        int ID;
        int RowID;


        private void SqlCommandsToRun(object Message) 
        { // created a method to send all of the sql commands with the message as args.

            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("'" + Message + "'");
            cmd.Connection = con;

            //MessageBox.Show("Command ran successfully"); Don't show success when openin
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            // concept return the datagrid view
            NetAmount_Load(null, null);
        }

        private void NetAmount_Load(object sender, EventArgs e)
        { // pulls data once this obj loads.
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Select * From tb_NetAmount", con);
            cmd.Connection = con;

            MessageBox.Show("Command ran successfully"); // shows successful run
            SqlDataAdapter sda = new SqlDataAdapter(cmd); 
            DataSet ds = new DataSet(); // data frame  

            sda.Fill(ds); // fills data frame with variable data from sql query
            dg_Amount.DataSource = ds.Tables[0]; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFarmerCNIC.Clear();
            txtSearchCNIC.Clear();
            txtTotalExpenditures.Clear();
            txtNetAmount.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try { // confirm user action before deleting
                if (MessageBox.Show("Are you sure you want to DELETE this record?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Yes)
                { 
                // try the connection to delete 
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Delete from tb_NetAmount Values(@FarmerCNIC,@TotalExpenditures,@NetAmount)", con);
                // cmd.Connection = con; // ?????? recommended code 

                con.Open();
                cmd.Parameters.AddWithValue("@FarmerCNIC", txtFarmerCNIC.Text);
                cmd.Parameters.AddWithValue("@TotalExpenditures", txtNetAmount.Text);
                cmd.Parameters.AddWithValue("@TotalExpenses", txtTotalExpenditures.Text);

                // execute cmd and close connection
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Net Amount recorded successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NetAmount_Load(null, null); //?????? ???????? ????????? ?????? ??????
            }            
            }
            catch (Exception ex) { // if unsucessful, catch and show error msg.
                MessageBox.Show(ex.Message);
            }

            }

        private void btnUpdate_Click(object sender, EventArgs e)
        { //CRUD (Updating procedure) Sql Update {table} set {variables}
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("UPDATE tb_NetAmount set FarmerCNIC =@FarmerCNIC,TotalExpenditures=@TotalExpenditures,NetAmount=@NetAmount", con);

            con.Open(); // 1: Open connection 2: Inject parameters into sql cmd statement 
            cmd.Parameters.AddWithValue("@FarmerCNIC", txtFarmerCNIC.Text);
            cmd.Parameters.AddWithValue("@TotalExpenditures", txtTotalExpenditures.Text);
            cmd.Parameters.AddWithValue("@NetAmount", txtNetAmount.Text);

            //3: Execute query
            cmd.BeginExecuteNonQuery();
            con.Close();

            // Show results 
            MessageBox.Show("Successfully updated.", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        { // CRUD (Creating into the sql tbl) Insert into {table} values {args**}
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into tb_NetAmount values (@FarmerCNIC,@TotalExpenditure,@NetAmount)", con);
            
            con.Open(); // opens the connection && adds params below
            cmd.Parameters.AddWithValue("@FarmerCNIC",txtFarmerCNIC.Text);
            cmd.Parameters.AddWithValue("@TotalExpenditure", txtTotalExpenditures.Text);
            cmd.Parameters.AddWithValue("@NetAmount",txtNetAmount.Text);

            cmd.ExecuteNonQuery(); // runs command 
            con.Close(); // closes connection


            //message box if successfull 
            MessageBox.Show("Record successfully created", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NetAmount_Load(null, null); // Avoids reopening the form 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
                if (e.RowIndex == 0)
                {
                    ID = int.Parse(dg_Amount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Select * FROM tb_NetAmount where ID = '"+ ID+ "'");
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                //Filling data to table 
                RowID = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtFarmerCNIC.Text = ds.Tables[0].Rows[0][1].ToString();
                txtTotalExpenditures.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNetAmount.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchCNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCNIC.Text != "")
            { 
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                SqlCommand cmd = new SqlCommand("Select * From tb_NetAmount where FarmerCNIC LIKE '"+txtSearchCNIC.Text+"'", con);
                cmd.Connection = con;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                // loads data into the table
                dg_Amount.DataSource = ds.Tables[0];

            }
        }
    }
}
