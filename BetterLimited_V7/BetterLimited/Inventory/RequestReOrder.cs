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

namespace BetterLimited
{
    public partial class RequestReOrder : Form
    { 
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string itemID;
        private InventoryStockLevelForm _islfrm;

        public string setItemID
        {
            set
            {
                txtItemID.Text = value;
                itemID = txtItemID.Text;
            }
        }

        public string getItemID
        {
            get {
                return itemID;
            }
        }

        public string selectQueryValue(string sql, string column)
        {
            command = conn.CreateCommand();
            command.CommandText = sql;
            try
            {
                openConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetString(column);
            }
            else
            {
                closeConnection();
                return null;
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

        public RequestReOrder(InventoryStockLevelForm islfrm)
        {
            InitializeComponent();
            _islfrm = islfrm;
            this.ActiveControl = txtReOrderQty;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                openConnection();
                sql = "INSERT INTO reorderrequest (ReorderRequestID, StaffID, RequestDate, RequestTime) VALUES (@ReorderRequestID, @StaffID, @RequestDate, @RequestTime);";
                command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@ReorderRequestID", null);
                command.Parameters.AddWithValue("@StaffID", 10003);
                command.Parameters.AddWithValue("@RequestDate", DateTime.Now.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@RequestTime", DateTime.Now.ToString("HH:mm:ss"));
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                string reOrderRequestID = getReorderRequestID();
                closeConnection();

                openConnection();
                sql = "INSERT INTO reorderrequest_item (ItemID, ReorderRequestID, Qty) VALUES (@ItemID, @ReorderRequestID, @Qty);";
                command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@ItemID", itemID);
                command.Parameters.AddWithValue("@ReorderRequestID", reOrderRequestID);
                command.Parameters.AddWithValue("@Qty", txtReOrderQty.Text);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                MessageBox.Show("Re-order successfully.\nReorderRequestID: " + reOrderRequestID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string message = "Do you want to re-order other items?";
                string title = "Re-order";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                    MenuForm menuform = Application.OpenForms["MenuForm"] as MenuForm;
                    if (menuform != null) 
                    {
                        menuform.Loadf();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Re-order unsuccessfully. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeConnection();
            this.Close();
            sql = "SELECT * FROM inventorystocklevel";
            _islfrm.showData(sql);
        }

        private void RequestReOrder_Load(object sender, EventArgs e)
        {
            try
            {
                openConnection();
                string sql = "SELECT * FROM inventorystocklevel WHERE itemID = '" + txtItemID.Text + "';";
                command = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtItemName.Text = reader["ItemName"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();
                    closeConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }

        private void txtReOrderQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == Convert.ToChar(8)) //represents a backspace
            {
                e.Handled = false; //Accept the input.
                lblWarning.Text = "";
            }
            else {
                e.Handled = true; //Reject the input.
                lblWarning.Text = "Re-order quantity should be numeric";
                
            }
        }

        public string getReorderRequestID()
        {
            string sql = "SELECT ReorderRequestID FROM reorderrequest ORDER BY ReorderRequestID DESC LIMIT 1;";
            return selectQueryValue(sql, "ReorderRequestID");


        }
    }
}
