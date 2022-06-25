using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetterLimited.PurchaseOrder;

namespace BetterLimited.PurchaseForm
{
    public partial class PurchaseOrderForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlConnection thisConn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending';";
        string itemID, staffID, department, position, supplierID, reorderRequestID;
        int itemSearch;

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
        public string setStaffID
        {
            set
            {
                staffID = value;
            }
        }

        public string getDepartment
        {
            get
            {
                return department;
            }
        }

        public string setDepartment
        {
            set
            {
                department = value;
            }
        }

        public string getPosition
        {
            get
            {
                return position;
            }
        }
        public string setPosition
        {
            set
            {
                position = value;
            }
        }
        public void showData(string sql)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvSelectItem.DataSource = dt;
                // switch (department)
                //{
                //  case "Purchase":
                //case "Admin":
                //case "CEO":
                //  this.dgvSelectItem.Columns["Add"].Visible = true;
                // break;
                //default:
                //  this.dgvSelectItem.Columns["Add"].Visible = false;
                //break;
                //  }
                //dgvSelectItem.DefaultCellStyle.ForeColor = Color.Blue;
                // dgvSelectItem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // dgvSelectItem.DefaultCellStyle.Font = new Font("Microsoft YaHei", 9);
                //      checkStock();
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }
        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void btnReOrderRecor_Click(object sender, EventArgs e)
        {
            PurchaseOrderRecord POR = new PurchaseOrderRecord();
            POR.Show();
        }

        private void cbxItemSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSearch = cbxItemSearch.SelectedIndex;
            txtItemSearch.Text = "";
        }

        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            switch (itemSearch)
            {
                case 0:
                    sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending'AND ReorderRequestID LIKE '%" + this.txtItemSearch.Text + "%'";
                    showData(sql);
                    break;
                case 1:
                    sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending'AND StaffID LIKE '%" + this.txtItemSearch.Text + "%'";
                    showData(sql);
                    break;
            }

        }

        private void PurchaseOrderForm_Load(object sender, EventArgs e)
        {
            showData(sql);
        }

        private void dgvSelectItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Add
            if (e.ColumnIndex == 0)
            {
                reorderRequestID = dgvSelectItem.Rows[e.RowIndex].Cells[1].Value.ToString();
                sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending' AND ReorderRequestID !=" + reorderRequestID;
                openConnection();
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvSelectItem.DataSource = dt;
                if (dgvPurchaseOrder.RowCount == 0)
                {
                    sql = "SELECT ReorderRequestID, item.SupplierID, reorderrequest_item.ItemID, item.ItemName, Qty FROM reorderrequest_item,item " +
                        "WHERE item.ItemID = reorderrequest_item.ItemID AND ReorderRequestID =" + reorderRequestID;

                    cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        RRID.Text = reader.GetValue(0).ToString();
                        var supplierID = reader.GetValue(1);
                        var itemID = reader.GetValue(2);
                        var itemName = reader.GetValue(3);
                        var qty = reader.GetValue(4);
                        dgvPurchaseOrder.Rows.Add(supplierID.ToString(), itemID.ToString(), itemName.ToString(), qty.ToString());
                    }


                    closeConnection();
                }
                else
                {
                    openConnection();
                    dgvPurchaseOrder.Rows.Clear();
                    sql = "SELECT ReorderRequestID, item.SupplierID, reorderrequest_item.ItemID, item.ItemName, Qty FROM reorderrequest_item,item " +
                        "WHERE item.ItemID = reorderrequest_item.ItemID AND ReorderRequestID =" + reorderRequestID;

                    cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        RRID.Text = reader.GetValue(0).ToString();
                        var supplierID = reader.GetValue(1);
                        var itemID = reader.GetValue(2);
                        var itemName = reader.GetValue(3);
                        var qty = reader.GetValue(4);
                        dgvPurchaseOrder.Rows.Add(supplierID.ToString(), itemID.ToString(), itemName.ToString(), qty.ToString());
                    }
                    closeConnection();

                }

            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvPurchaseOrder.Rows.Clear();
            sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending';";
            showData(sql);
        }

        public string selectQueryValue(string sql, string column)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            try
            {
                openConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetString(column);
            }
            else
            {
                closeConnection();
                return null;
            }
        }

        public string getPurchaseOrderID()
        {
            string sql = "SELECT PurchaseOrderID FROM purchaseorder ORDER BY PurchaseOrderID DESC LIMIT 1;";
            return selectQueryValue(sql, "PurchaseOrderID");
        }


        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<PurchaseItem>> supplierMap = new Dictionary<string, List<PurchaseItem>>();

            for (int i = 0; i < dgvPurchaseOrder.RowCount; i++)
            {
                supplierID = dgvPurchaseOrder.Rows[i].Cells[0].Value.ToString();
                if (!supplierMap.ContainsKey(supplierID))
                {
                    List<PurchaseItem> items = new List<PurchaseItem>();
                    PurchaseItem item = new PurchaseItem(
                        dgvPurchaseOrder.Rows[i].Cells[0].Value.ToString(),
                        dgvPurchaseOrder.Rows[i].Cells[1].Value.ToString(),
                        dgvPurchaseOrder.Rows[i].Cells[2].Value.ToString(),
                        dgvPurchaseOrder.Rows[i].Cells[3].Value.ToString());
                    items.Add(item);
                    supplierMap.Add(supplierID, items);
                }
                else
                {
                    List<PurchaseItem> items = supplierMap[supplierID];
                    PurchaseItem item = new PurchaseItem(
                        dgvPurchaseOrder.Rows[i].Cells[0].Value.ToString(),
                        dgvPurchaseOrder.Rows[i].Cells[1].Value.ToString(),
                        dgvPurchaseOrder.Rows[i].Cells[2].Value.ToString(),
                        dgvPurchaseOrder.Rows[i].Cells[3].Value.ToString());
                    items.Add(item);
                    supplierMap[supplierID] = items;
                }
            }
            foreach (KeyValuePair<string, List<PurchaseItem>> entry in supplierMap)
            {
                string supplierID = entry.Key;
                List<PurchaseItem> data = entry.Value;
                try
                {
                    openConnection();
                    sql = "INSERT INTO purchaseorder (PurchaseOrderID, StaffID, SupplierID, OrderDate, OrderTime) VALUES (@PurchaseOrderID, @StaffID, @SupplierID, @OrderDate, @OderTime);";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@PurchaseOrderID", null);
                    cmd.Parameters.AddWithValue("@StaffID", "10008");
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@OderTime", DateTime.Now.ToString("HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    string purchaseOrderID = getPurchaseOrderID();
                    closeConnection();
                    for (int j = 0; j < data.Count; j++)
                    {
                        try
                        {
                            openConnection();
                            sql = "INSERT INTO purchaseorder_item (PurchaseOrderID, ItemID,  Qty) VALUES (@PurchaseOrderID, @ItemID, @Qty);";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderID);
                            cmd.Parameters.AddWithValue("@ItemID", data[j].itemID);
                            cmd.Parameters.AddWithValue("@Qty", data[j].qty);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                            closeConnection();
                        }
                        catch (Exception ex)
                        {
                            
                            closeConnection();

                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Purchase unsuccessfully. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    closeConnection();

                }
                dgvPurchaseOrder.Rows.Clear();
            }
            MessageBox.Show("Purchase Order successfully.", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}



