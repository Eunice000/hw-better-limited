using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSM
{
    public partial class RestockRequestForm : Form
    {
        //Database 
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        string staffID;
        string itemID;


        //get set restockRequestRecordID
        public string setStaffID
        {
            set
            {
                staffID = value;
            }
        }

        public string getStaffID
        {
            get
            {
                return staffID;
            }
        }



        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public RestockRequestForm()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RestockRequestForm_Load(object sender, EventArgs e)
        {
            textBox_date.Text = DateTime.Today.ToString("yyyy/MM/dd");
            try
            {
                openConnection();
                string sql = "SELECT itemCat, itemID, itemName, i.supplierID, supplierName FROM item i, supplier s WHERE i.supplierID = s.supplierID";
                cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string itemCat = reader.GetString("itemCat");
                    string itemID = reader.GetString("itemID");
                    string itemName = reader.GetString("itemName");
                    string supplierID = reader.GetString("supplierID");
                    string supplierName = reader.GetString("supplierName");
                    comboBox_item.ValueMember = itemID;

                    comboBox_item.Items.Add("Item ID: " + itemID + " Category: " + itemCat + " Item Name: "+ itemName + " Supplier ID: " +supplierID + " Supplier Name: " + supplierName);
                }


                closeConnection();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetRestock();
        }

        private DataTable GetRestock()
        {
            DataTable dtRestock = new DataTable();

            using (con)
            {
                string selectItem = comboBox_item.SelectedItem.ToString();
                selectItem.Substring(9, 14);
                using (cmd = new MySqlCommand("SELECT itemCat, itemID, itemName, i.supplierID, supplierName FROM item i, supplier s WHERE i.supplierID = s.supplierID " , con))
                {
                    openConnection();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtRestock.Load(reader);
                    closeConnection();
                }
            }
            return dtRestock;
        }

        
    }
}
