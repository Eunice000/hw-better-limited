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


namespace BetterLimited.ItemForm
{
    public partial class item_New_Form : Form
    {
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;

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
        public item_New_Form()
        {
            InitializeComponent();
        }

        private void AddItem(Item item)
        {
            string sql = "INSERT INTO item VALUES (@ItemID,  @ItemCat, @ItemName, " +
            "@ItemDesc, @ItemImg, @ItemSalePrice, @ItemSID, @ItemSupplierPrice, @ItemWarrantyMonth )";
            openConnection();
            cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ItemID", MySqlDbType.VarChar).Value = item.ID;
            cmd.Parameters.Add("@ItemCat", MySqlDbType.VarChar).Value = item.Cat;
            cmd.Parameters.Add("@ItemName", MySqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar).Value = item.Desc;
            cmd.Parameters.Add("@ItemImg", MySqlDbType.VarChar).Value = item.Img;
            cmd.Parameters.Add("@ItemSalePrice", MySqlDbType.VarChar).Value = item.SalePrice;
            cmd.Parameters.Add("@ItemSID", MySqlDbType.VarChar).Value = item.SID;
            cmd.Parameters.Add("@ItemSupplierPrice", MySqlDbType.VarChar).Value = item.SPrice;
            cmd.Parameters.Add("@ItemWarrantyMonth", MySqlDbType.VarChar).Value = item.WarrantyMonth;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Item not insert. \n" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            closeConnection();

        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (txtCat.Text.Trim().Length < 1 ||
               txtName.Text.Trim().Length < 1 ||
               txtDesc.Text.Trim().Length < 1 ||
               txtSalesPrice.Text.Trim().Length < 1 ||
               txtSupplierID.Text.Trim().Length < 1 ||
               txtSupplierPrice.Text.Trim().Length < 1 ||
               txtWm.Text.Trim().Length < 1
               )
            {
                MessageBox.Show("All information should be filled \n (besides item image)");
                return;
            }
            else
            {

                Item item = new Item(txtItemID.Text.Trim(), txtCat.Text.Trim(), txtName.Text.Trim(), txtDesc.Text.Trim(), txtImg.Text.Trim(), txtSalesPrice.Text.Trim(), txtSupplierID.Text.Trim(), txtSupplierPrice.Text.Trim(), txtWm.Text.Trim());
                AddItem(item);
            }
        }

        //Cancel button
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Clear button
        private void button_Clear_Click(object sender, EventArgs e)
        {
            txtCat.Text = txtName.Text = txtDesc.Text = txtSalesPrice.Text = txtSupplierID.Text = txtSupplierPrice.Text = txtWm.Text = string.Empty;

        }

        private void txtSalesPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtWm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtSupplierID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtSupplierPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif)";
            if (openFileDialog1.ShowDialog() == DialogResult.OK && opf.ShowDialog() == DialogResult.OK)          
            {
                txtImg.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
