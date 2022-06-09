using BetterLimited.ItemForm;
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
        string ItemID;

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

        //get set itemID
        public string setItemID
        { 
            set
            {
                ItemID = value;
            }
        }
        public string getItemID
        {
            get
            {
                return ItemID;
            }
        }


        public ItemList()
        {
            InitializeComponent();
        }

        //Display item list
        private void ItemList_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //DataGridView Row Height
            dataGridView1.RowTemplate.Height = 70;

            //Change Image Size to Fit DataDridView Cell
            for(int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if(dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
            DisplayTable();
        }

        public void DisplayTable()
        {

            string sql = "SELECT * FROM item";
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView1.DataSource = tb1;

            closeConnection();
        }

        // Delete Method
        private void DeleteItem(string id)
        {
            string sql = "DELETE FROM item WHERE itemID =" + id + ";";
            openConnection();
            cmd = new MySqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleted not Successfully \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeConnection();
        }

        // Edit and Delete Function
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == 0)
            {
                ItemID = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                item_UpdateForm updateForm = new item_UpdateForm(this);
                updateForm.setItemID = getItemID;
                updateForm.Show();
            }
            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure to delete this item ?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteItem(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayTable();
                }
                return;
            }
        }

        //Search button
        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;
            if (textBox_Search.Text == "")
            {
                sql = "SELECT * FROM item;";
            }
            else
            {
                sql = "SELECT * FROM item Where itemID = " + textBox_Search.Text + ";";
            }
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView1.DataSource = tb1;
            closeConnection();
        }



        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT * FROM item;";
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView1.DataSource = tb1;
            closeConnection();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            item_New_Form NewForm = new item_New_Form(this);
            NewForm.Show();
        }

        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
