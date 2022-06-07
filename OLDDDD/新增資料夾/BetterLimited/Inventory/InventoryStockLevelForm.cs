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
    public partial class InventoryStockLevelForm : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql = "SELECT * FROM inventorystocklevel";
        string itemID;
        string lowLevelQty;

        public string getItemID
        {
            get
            {
                return itemID;
            }
        }

        public InventoryStockLevelForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            showData(sql);
        }

        public void showData(string sql)
        {
            try
            {
                openConnection();                
                command = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(command);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvInventoryStockLevel.DataSource = dt;
                dgvInventoryStockLevel.DefaultCellStyle.ForeColor = Color.Blue;
                dgvInventoryStockLevel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvInventoryStockLevel.DefaultCellStyle.Font = new Font("Segoe Print", 9);
                checkStock();
                closeConnection();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }

        private void checkStock()
        {
            int quantity;
            int lowLevel;
            for (int i = 0; i < dgvInventoryStockLevel.Rows.Count; i++)
            {
                quantity = Convert.ToInt32(dgvInventoryStockLevel.Rows[i].Cells[4].Value.ToString());
                lowLevel = Convert.ToInt32(dgvInventoryStockLevel.Rows[i].Cells[5].Value.ToString());                
                if (quantity < lowLevel)
                {
                    dgvInventoryStockLevel.Rows[i].Cells[4].Style.BackColor = Color.LightCoral;
                    dgvInventoryStockLevel.Rows[i].Cells[4].Style.Font = new Font("Segoe Print", 12, FontStyle.Bold);
                }
                else if (quantity < (lowLevel + 5))
                {
                    dgvInventoryStockLevel.Rows[i].Cells[4].Style.BackColor = Color.LightPink;
                    dgvInventoryStockLevel.Rows[i].Cells[4].Style.Font = new Font("Segoe Print", 12, FontStyle.Bold);
                }                
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM inventorystocklevel WHERE itemID LIKE'" + this.txtSearch.Text + "%'";
            showData(sql);
        }

        private void InventoryStockLevelForm_Shown(object sender, EventArgs e)
        {
            showData(sql);
        }

        private void dgvInventoryStockLevel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                itemID = dgvInventoryStockLevel.Rows[e.RowIndex].Cells[2].Value.ToString();
                int lowLevelQty;
                UpdateInventoryLowLevelQty uillqfrm = new UpdateInventoryLowLevelQty(this);
                uillqfrm.setItemID = getItemID;
                uillqfrm.Show();
            }

            if (e.ColumnIndex == 1)
            {
                itemID = dgvInventoryStockLevel.Rows[e.RowIndex].Cells[2].Value.ToString();
                RequestReOrder requestreorderfrm = new RequestReOrder(this);
                requestreorderfrm.setItemID = getItemID;
                requestreorderfrm.Show();
            }
        }
    }
}
