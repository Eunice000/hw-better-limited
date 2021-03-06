using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetterLimited
{
    public partial class SalesOrder_UpdateForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string salesOrderID;
        

        public SalesOrder_UpdateForm()
        {
            InitializeComponent();
        }

        //get set StaffID
        public string setSalesOrderID
        {
            set
            {
                salesOrderID = value;
            }
        }
        //get set StaffID
        public string getSalesOrderID
        {
            get
            {
                return salesOrderID;
            }
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void SalesOrder_UpdateForm_Load(object sender, EventArgs e)
        {

            openConnection();

            string sql = "SELECT * FROM salesorder WHERE SalesOrderID = @salesOrderID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("salesOrderID", getSalesOrderID);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_salesorderID.Text = reader["SalesOrderID"].ToString();
                textBox_StoreID.Text = reader["StoreID"].ToString();
                textbox_StaffID.Text = reader["StaffID"].ToString();
                comboBox_PaymentStatus.Text = reader["PaymentStatus"].ToString();
                textBox_PaidAmt.Text = reader["PaidAmt"].ToString();
                textBox_Date.Text = Convert.ToDateTime(reader["Date"]).ToString("yyyy/MM/dd");
                textBox_Time.Text = reader["Time"].ToString();
                textBox__ExpDate.Text = Convert.ToDateTime(reader["ExpDate"]).ToString("yyyy/MM/dd");
                textBox_CustomerID.Text = reader["CustomerID"].ToString();

                if (comboBox_PaymentStatus.Text == "") 
                {
                    comboBox_PaymentStatus.Text = "Null";
                }

            }
            else
            {
                MessageBox.Show("Dedug: code in SalesOrder_UpdateForm.cs, Error :  Not Data Found");
            }
            closeConnection();



        }

        private void button_cacel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {

            openConnection();

            if (comboBox_PaymentStatus.Text == "Null") { comboBox_PaymentStatus.Text = "";}

            string sql = "UPDATE salesorder SET " +
                "StoreID=@StoreID," +
                "StaffID=@StaffID," +
                "PaymentStatus=@PaymentStatus," +
                "PaidAmt=@PaidAmt," +
                "Date=@Date, " +
                "Time=@Time, " +
                "ExpDate=@ExpDate, " +
                "CustomerID=@CustomerID" +
                " WHERE SalesOrderID = @SalesOrderID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("SalesOrderID", textBox_salesorderID.Text);
            command.Parameters.AddWithValue("StoreID", textBox_StoreID.Text);
            command.Parameters.AddWithValue("StaffID", textbox_StaffID.Text);
            command.Parameters.AddWithValue("PaymentStatus", comboBox_PaymentStatus.Text);
            command.Parameters.AddWithValue("PaidAmt", textBox_PaidAmt.Text);
            command.Parameters.AddWithValue("Date", textBox_Date.Text);
            command.Parameters.AddWithValue("Time", textBox_Time.Text);
            command.Parameters.AddWithValue("ExpDate", textBox__ExpDate.Text);
            command.Parameters.AddWithValue("CustomerID", textBox_CustomerID.Text);


            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Update Successfuly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Update unuccessfuly. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            closeConnection();
            this.Hide();
        }
    }
}
