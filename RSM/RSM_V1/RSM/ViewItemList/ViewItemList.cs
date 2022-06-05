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
    public partial class ItemList : Form
    {
        //Database 
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;

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
        public ItemList()
        {
            InitializeComponent();
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            dataGridView_itemList.DataSource = GetItemList();
        }

        private DataTable GetItemList()
        {
            DataTable dtItem = new DataTable();

            using (con)
            {
                using (cmd = new MySqlCommand("SELECT ItemID ,ItemCat ,ItemName, ItemDesc ,SalePrice ,SupplierID ,SupplierPrice ,WarrantyMonth FROM Item;", con))
                {
                    openConnection();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtItem.Load(reader);
                    closeConnection();
                }
            }
            return dtItem;

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox_Search.Text == "")
            {
                sql = "SELECT ItemID ,ItemCat ,ItemName, ItemDesc ,SalePrice ,SupplierID ,SupplierPrice ,WarrantyMonth FROM Item;";
            }
            else
            {
                sql = "SELECT ItemID ,ItemCat ,ItemName, ItemDesc ,SalePrice ,SupplierID ,SupplierPrice ,WarrantyMonth FROM Item Where ItemID = " + textBox_Search.Text + ";";
            }
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_itemList.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT ItemID ,ItemCat ,ItemName, ItemDesc ,SalePrice ,SupplierID ,SupplierPrice ,WarrantyMonth FROM Item";
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_itemList.DataSource = tb1;
            closeConnection();
        }
    }
}
