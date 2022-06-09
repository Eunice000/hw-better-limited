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
    public partial class UpdateRetailLowLevelQty : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string itemID, storeID;
        private RetailStockLevelForm _rslfrm;

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
            get
            {
                return itemID;
            }
        }
        public string setStoreID
        {
            set
            {

                storeID = value; 
                if (storeID == "1")
                {
                    txtStore.Text = "Tsuen Wan";
                }
                else {
                    txtStore.Text = "Kowloon Bay";
                }                
            }
        }

        public string getStoreName
        {
            get
            {
                return storeID;
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

        public UpdateRetailLowLevelQty(RetailStockLevelForm rslfrm)
        {
            InitializeComponent();
            _rslfrm = rslfrm;
            this.ActiveControl = txtLowLevelQty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                openConnection();
                sql = "UPDATE retailstocklevel SET LowLevelQty = '" + txtLowLevelQty.Text + "' WHERE storeID = '" + storeID + "' AND itemID = '" + txtItemID.Text + "';";
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Update successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update unsuccessfully. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeConnection();
            this.Close();
            sql = "SELECT itemID, itemName, Quantity, LowLevelQty FROM retailstocklevel WHERE storeID = " + storeID;
            _rslfrm.showData(sql);
        }

        private void UpdateRetailLowLevelQty_Load(object sender, EventArgs e)
        {
            try
            {
                openConnection();
                string sql = "SELECT storeName,  itemID, itemName, Quantity, LowLevelQty FROM store, retailstocklevel WHERE itemID = '" + txtItemID.Text + "' AND store.storeID = retailstocklevel.storeID;";
                command = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtStore.Text = reader["storeName"].ToString();
                    txtItemName.Text = reader["ItemName"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();
                    txtLowLevelQty.Text = reader["LowLevelQty"].ToString();
                    closeConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }

        private void txtLowLevelQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == Convert.ToChar(8)) //represents a backspace
            {
                e.Handled = false; //Accept the input.
                lblWarning.Text = "";
            }
            else
            {
                e.Handled = true; //Reject the input.
                lblWarning.Text = "Low level quantity should be numeric";

            }
        }
    }
}
