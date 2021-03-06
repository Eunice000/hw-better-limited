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
    public partial class InstallationForm : Form
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string InstallationID;


        public string setInstallationID
        {
            set
            {
                InstallationID = value;
            }
        }
        //get set StaffID
        public string getInstallationID
        {
            get
            {
                return InstallationID;
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

        public InstallationForm()
        {
            InitializeComponent();
        }

        private void DisplayTable()
        {
            string sql = "SELECT * FROM installationorder";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_InstallationOrder_Table.DataSource = tb1;
            closeConnection();
        }

        private void DelectDelivery(string id)
        {
            string sql = "DELETE FROM installationorder WHERE InstallationID =" + id + ";";
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
                sql = "SELECT * FROM installationorder;";
            }
            else
            {
                sql = "SELECT * FROM installationorder Where InstallationID = " + textBox_Search.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_InstallationOrder_Table.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT * FROM installationorder;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_InstallationOrder_Table.DataSource = tb1;
            closeConnection();
        }

        private void dataGridView_InstallationOrder_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
                if (e.ColumnIndex == 0)
                {
                    string SalesOrderID = dataGridView_InstallationOrder_Table.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string sql = "SELECT * From salesorder_item Where SalesOrderID = " + SalesOrderID + ";";

                    openConnection();
                    command = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(command);
                    DataTable tb2 = new DataTable();
                    adp.Fill(tb2);
                    dataGridView_InstallationOrder_item_Table.DataSource = tb2;
                    closeConnection();
                }
                if (e.ColumnIndex == 1)
                {
                    InstallationID =  dataGridView_InstallationOrder_Table.Rows[e.RowIndex].Cells[3].Value.ToString();
                    InstallationForm_UpdateForm updateForm = new InstallationForm_UpdateForm();
                    updateForm.setInstallationID = getInstallationID;
                    updateForm.Show();
                }
                //Delete
                if (e.ColumnIndex == 2)
                {
                    if (MessageBox.Show("You want to delect this sales order record ?? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        DelectDelivery(dataGridView_InstallationOrder_Table.Rows[e.RowIndex].Cells[3].Value.ToString());
                        DisplayTable();
                    }
                    return;
                }

            
        }

        private void InstallationForm_Load(object sender, EventArgs e)
        {
            dataGridView_InstallationOrder_Table.Columns[3].DefaultCellStyle.Format = "yyyy/MM/dd";
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
