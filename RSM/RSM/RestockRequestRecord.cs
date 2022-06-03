﻿using MySql.Data.MySqlClient;
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
    public partial class RestockRequestRecord : Form
    {
        //Database 
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        string restockRequestRecordID;


        //get set restockRequestRecordID
        public string setRestockRequestRecord
        {
            set
            {
                restockRequestRecordID = value;
            }
        }

        public string getRestockRequestRecord
        {
            get
            {
                return restockRequestRecordID;
            }
        }


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

        public RestockRequestRecord()
        {
            InitializeComponent();

            //DATAGRIDVIEW PROPERTIES
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void RestockRequestRecord_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns[2].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView1.DataSource = GetRestockRequest();
            DataGridViewButtonColumn detailsCol = new DataGridViewButtonColumn(); 

            //Detail button
            detailsCol.Name = "Details"; 
            detailsCol.Text = "Details..."; 
            detailsCol.UseColumnTextForButtonValue = true; 
            detailsCol.HeaderText = "Details";
            dataGridView1.Columns.Insert(dataGridView1.Columns.Count, detailsCol);
        }

        // get restock request data
        private DataTable GetRestockRequest()
        {
            DataTable dtRestock = new DataTable();

            using (con)
            {
                using (cmd = new MySqlCommand("SELECT * FROM restockrequest ", con))
                {
                    openConnection();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtRestock.Load(reader);
                    closeConnection();
                }
            }
            return dtRestock;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Details")
            {
                restockRequestRecordID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                RestockRequestDetail detailsForm = new RestockRequestDetail();
                detailsForm.setRestockRequestRecord = getRestockRequestRecord;
                detailsForm.Show();
            }

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;
            if (textBox_Search.Text == "")
            {
                sql = "SELECT * FROM restockrequest;";
            }
            else
            {
                sql = "SELECT * FROM restockrequest Where RestockRequestID = " + textBox_Search.Text + ";";
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
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            RestockRequestForm f = new RestockRequestForm();
            f.Show();
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
