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
    public partial class SupplierList : Form
    {
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        string supplierID;


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

        //get set supplierID
        public string setSupplierID
        {
            set
            {
                supplierID = value;
            }
        }
        public string getSupplierID
        {
            get
            {
                return supplierID;
            }
        }
        public SupplierList()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        public void DisplayTable()
        {

            string sql = "SELECT * FROM supplier;";
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView1.DataSource = tb1;

            closeConnection();
        }

        // Delete Method
        private void DeleteSupplier(string id)
        {
            string sql = "DELETE FROM supplier WHERE supplierID =" + id + ";";
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == 0)
            {
                supplierID = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplierUpdateForm updateForm = new supplierUpdateForm(this);
                updateForm.setSupplierID = getSupplierID;
                updateForm.Show();
            }
            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure to delete this item ?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteSupplier(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayTable();
                }
                return;
            }
        }

        private void button_Search_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (textBox_Search.Text == "")
            {
                sql = "SELECT * FROM supplier;";
            }
            else
            {
                sql = "SELECT * FROM supplier Where supplierID = " + textBox_Search.Text + ";";
            }
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView1.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT * FROM supplier;";
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView1.DataSource = tb1;
            closeConnection();
        }

        private void button_New_Click_1(object sender, EventArgs e)
        {
            supplierNewForm NewForm = new supplierNewForm(this);
            NewForm.Show();
        }

        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            DisplayTable();
        }

    }
}
