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
    public partial class RestockRequestForm_v2 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string staffID = "10002";
        string restockRequestID;

        public string setStaffID
        {
            set
            {
                staffID = value;
            }
        }
        //get set StaffID
        public string getStaffID
        {
            get
            {
                return staffID;
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


        public RestockRequestForm_v2()
        {
            InitializeComponent();
        }

        private void DisplayTable()
        {
            string sql = "SELECT * FROM item";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_itemTable.DataSource = tb1;
            closeConnection();
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
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_itemTable.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT ItemID ,ItemCat ,ItemName, ItemDesc ,SalePrice ,SupplierID ,SupplierPrice ,WarrantyMonth FROM Item";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_itemTable.DataSource = tb1;
            closeConnection();
        }





        private void RestockRequestForm_v2_Load(object sender, EventArgs e)
        {
            textBox_Nowdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            textBox_NowTime.Text = DateTime.Now.ToString("hh:mm:ss");
            textbox_StaffID.Text = staffID;
            DisplayTable();

        }

        private void dataGridView_itemTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                if (dataGridView_RestockList.RowCount == 0)
                {
                    string itemID = dataGridView_itemTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string itemName = dataGridView_itemTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string SupplierID = dataGridView_itemTable.Rows[e.RowIndex].Cells[7].Value.ToString();
                    dataGridView_RestockList.Rows.Add(itemID, itemName, SupplierID, "", "1");
                }
                else
                {
                    for (int i = 0; i < dataGridView_RestockList.RowCount; i++)
                    {
                        //Use A.Equals(B) to check if(string  A == string B)
                        if (dataGridView_itemTable.Rows[e.RowIndex].Cells[1].Value.ToString()
                            .Equals( dataGridView_RestockList.Rows[i].Cells[0].Value.ToString() )
                            )
                        {
                            MessageBox.Show("this item is already selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    } 
                    string itemID = dataGridView_itemTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string itemName = dataGridView_itemTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string SupplierID = dataGridView_itemTable.Rows[e.RowIndex].Cells[6].Value.ToString();
                    dataGridView_RestockList.Rows.Add(itemID, itemName, SupplierID, "", "1");

                }
            }
        }


        //Add Restorck Request Record
        public void AddRestorckRequestForm()
        {
            string sql = "INSERT INTO restockrequest (RestockRequestID, StaffID, RequestDate, RequestTime) " +
                         "VALUES (NULL, @staffID, @requestDate, @requestTime);";
            openConnection();
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("staffID", staffID);
            command.Parameters.AddWithValue("requestDate", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("requestTime", DateTime.Now.ToString("hh:mm:ss"));
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("AddRestorckRequestForm() Successfuly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("AddRestorckRequestForm() unuccessfuly. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                closeConnection();
            }

        }

        //<<get the RestorckRequestRecordID>> then  <<Add item to RestorckRequestRecord_item>>
        private void Insert_data(string itemID, string Quantity)
        {

            //select the newest ID first
            string sql = "SELECT MAX(RestockRequestID) FROM restockrequest;";

            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                restockRequestID = reader["MAX(RestockRequestID)"].ToString();
            }
            else
            {
                MessageBox.Show("Submit unuccessfuly. \n  Debug:line 196 \n  method : Insert_data()\n" + restockRequestID, "Information",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            closeConnection();


            //Insert to ID that We selected
            sql = "INSERT INTO restockrequest_item ( RestockRequestID , itemID , Quantity ) VALUES (@restockRequestID,@itemID,@Qty);";
            openConnection();

            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("restockRequestID", restockRequestID);
            command.Parameters.AddWithValue("itemID", itemID);
            command.Parameters.AddWithValue("Qty", Quantity);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Submit unuccessfuly. \n Debug:line 218 \n  method : Insert_data()\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            closeConnection();

        }


        private void dataGridView_RestockList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int qty;
            string notings = null;
            //add
            if (e.ColumnIndex == 3)
            {
                try
                {
                    qty = Int16.Parse(dataGridView_RestockList.Rows[e.RowIndex].Cells[4].Value.ToString());
                    if (qty == 1 || qty == 0)
                    {

                        MessageBox.Show("this item Qty can't smaller then 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        qty--;
                        dataGridView_RestockList.Rows[e.RowIndex].Cells[4].Value = qty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Qty can't be null \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //remove
            if (e.ColumnIndex == 5)
            {
                try
                {
                    qty = Int16.Parse(dataGridView_RestockList.Rows[e.RowIndex].Cells[4].Value.ToString());
                    qty++;
                    dataGridView_RestockList.Rows[e.RowIndex].Cells[4].Value = qty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Qty can't be null \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //delete
            if (e.ColumnIndex == 6)
            {
                dataGridView_RestockList.Rows.RemoveAt(e.RowIndex);
            }
        }
        

        
        private void dataGridView_RestockList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
            if (dataGridView_RestockList.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }

        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }







        private void button_cancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }


        private void button_submit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to submit now?? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string itemID;
                string qty;
                AddRestorckRequestForm();
                for (int i = 0; i < dataGridView_RestockList.RowCount; i++)
                {
                    //Use A.Equals(B) to check if(string  A == string B)
                    itemID = dataGridView_RestockList.Rows[i].Cells[0].Value.ToString();
                    qty = dataGridView_RestockList.Rows[i].Cells[4].Value.ToString();
                    Insert_data(itemID, qty);
                }
                MessageBox.Show("Submit Successfuly. \n" + "restockRequestID : " + restockRequestID, "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;

           


        }


    }
}
