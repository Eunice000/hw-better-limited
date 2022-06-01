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
    public partial class RestockRequestRecord : Form
    {
        //Database 
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;

        DataTable dt = new DataTable();
        public RestockRequestRecord()
        {
            InitializeComponent();

            //DATAGRIDVIEW PROPERTIES
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void RestockRequestRecord_Load(object sender, EventArgs e)
        {
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
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtRestock.Load(reader);
                }
            }
            return dtRestock;

        }

        //Show Restock Request detail
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Details")
            {
                RestockRequestDetail f = new RestockRequestDetail();
                f.Show();
            }
        }
    }
}
