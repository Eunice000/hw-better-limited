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
            dataGridView1.DataSource = GetItemList();
        }

        private DataTable GetItemList()
        {
            DataTable dtItem = new DataTable();

            using (con)
            {
                using (cmd = new MySqlCommand("SELECT * FROM item ", con))
                {
                    openConnection();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtItem.Load(reader);
                    closeConnection();
                }
            }
            return dtItem;

        }

    }
}
