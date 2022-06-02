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
    public partial class DeliveryForm_UpdateForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string deliveryID;

        public DeliveryForm_UpdateForm()
        {
            InitializeComponent();
        }
        public string setDeliveryID
        {
            set
            {
                deliveryID = value;
            }
        }
        //get set StaffID
        public string getDeliveryID
        {
            get
            {
                return deliveryID;
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


        private void DeliveryForm_UpdateForm_Load(object sender, EventArgs e)
        {
            dateTimePicker__DeliveryTime.Format = DateTimePickerFormat.Time;
            dateTimePicker__DeliveryTime.ShowUpDown = true;


            openConnection();

            string sql = "SELECT * FROM deliverynote WHERE DeliveryID = @deliveryID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("deliveryID", getDeliveryID);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //textBox_Date.Text = reader["Date"].ToString();
                textBox_DeliveryID.Text = reader["DeliveryID"].ToString();
                textBox_SalesOrderID.Text = reader["SalesOrderID"].ToString();
                textbox_CustomerID.Text = reader["CustomerID"].ToString();
                dateTimePicker__DeliveryDate.Text = Convert.ToDateTime(reader["DeliveryDate"]).ToString("yyyy/MM/dd");
                dateTimePicker__DeliveryTime.Text = reader["DeliveryTime"].ToString();
                comboBox_deliveryStatus.Text = reader["DeliveryStatus"].ToString();



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

            string sql = "UPDATE deliverynote SET " +
                "DeliveryDate=@deliveryDate," +
                "DeliveryTime=@deliveryTime," +
                "DeliveryStatus=@deliveryStatus" +
                " WHERE DeliveryID = @deliveryID;";

            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("deliveryDate", dateTimePicker__DeliveryDate.Text);
            command.Parameters.AddWithValue("deliveryTime", dateTimePicker__DeliveryTime.Text);
            command.Parameters.AddWithValue("deliveryStatus", comboBox_deliveryStatus.Text);
            command.Parameters.AddWithValue("deliveryID", textBox_DeliveryID.Text);


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
