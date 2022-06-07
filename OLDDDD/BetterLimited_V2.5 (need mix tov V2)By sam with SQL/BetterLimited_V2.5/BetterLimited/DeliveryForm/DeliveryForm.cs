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
    public partial class DeliveryForm : Form
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string deliveryID;

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

        public bool selectQuery(string sql)
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
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }





        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void DisplayTable()
        {
            string sql = "SELECT * FROM deliverynote";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_DeliveryNote_Table.DataSource = tb1;
            closeConnection();
        }

        private void DelectDelivery(string id)
        {
            string sql = "DELETE FROM deliverynote WHERE DeliveryID =" + id + ";";
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


        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox_Search.Text == "")
            {
                sql = "SELECT * FROM deliverynote;";
            }
            else
            {
                sql = "SELECT * FROM deliverynote Where DeliveryID = " + textBox_Search.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_DeliveryNote_Table.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT * FROM deliverynote;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_DeliveryNote_Table.DataSource = tb1;
            closeConnection();
        }

        private void dataGridView_DeliveryNote_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == 0 )
            {
                string SalesOrderID = dataGridView_DeliveryNote_Table.Rows[e.RowIndex].Cells[4].Value.ToString();
                string sql = "SELECT * From salesorder_item Where SalesOrderID = "+SalesOrderID+";";
                
                openConnection();
                command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable tb2 = new DataTable();
                adp.Fill(tb2);
                dataGridView_DeliveryNote_item_Table.DataSource = tb2;
                closeConnection();

            }

            if (e.ColumnIndex == 1)
            {
                deliveryID = dataGridView_DeliveryNote_Table.Rows[e.RowIndex].Cells[3].Value.ToString();
                DeliveryForm_UpdateForm updateForm = new DeliveryForm_UpdateForm();
                
                updateForm.setDeliveryID = getDeliveryID;
                updateForm.Show();
            }
            //Delete
            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("You want to delect this sales order record ?? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    DelectDelivery(dataGridView_DeliveryNote_Table.Rows[e.RowIndex].Cells[3].Value.ToString());
                    DisplayTable();
                }
                return;
            }
        }



        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            dataGridView_DeliveryNote_Table.Columns[3].DefaultCellStyle.Format = "yyyy/MM/dd";
            DisplayTable();


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
