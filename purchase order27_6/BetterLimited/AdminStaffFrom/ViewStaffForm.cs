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
    public partial class ViewStaffForm : Form
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;

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

        public ViewStaffForm()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox_Search.Text == "")
            {
                sql = "SELECT * FROM staff;";
            }
            else
            {
                sql = "SELECT * FROM staff Where staffID = " + textBox_Search.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_StaffTable.DataSource = tb1;
            closeConnection();
        }

        private void DisplayTable()
        {
            string sql = "SELECT * FROM staff";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_StaffTable.DataSource = tb1;
            closeConnection();
        }

        private void DelectSalesOrder(string id)
        {
            string sql = "DELETE FROM staff WHERE staffID =" + id + ";";
            openConnection();
            command = new MySqlCommand(sql, conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Delected Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delected not Successfully \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeConnection();
        }


        private void ViewStaffForm_Load(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT * FROM staff;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_StaffTable.DataSource = tb1;
            closeConnection();
        }

        private void dataGridView_StaffTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == 0)
            {
                string staffID = dataGridView_StaffTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                EditStaffForm updateForm = new EditStaffForm();
                updateForm.setStaffID = staffID;
                updateForm.Show();
            }
            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("You want to delect this staff record ?? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DelectSalesOrder(dataGridView_StaffTable.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayTable();
                }
                return; 
            }
        }
    }
}
