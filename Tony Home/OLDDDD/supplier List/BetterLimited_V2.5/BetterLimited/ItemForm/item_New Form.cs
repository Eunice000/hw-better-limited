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
        private ItemList _itemListfrm;
        string SupplierID;

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

        //get set Supplier ID
        public string setSupplierID
        {
            set
            {
                SupplierID = value;
            }
        }
        public string getSupplierID
        {
            get
            {
                return SupplierID;
            }
        }
        public item_New_Form(ItemList itemListfrm)
        {
            InitializeComponent();
            _itemListfrm = itemListfrm;
        }


        private void AddItem(Item item)
        {
            string sql = "INSERT INTO item VALUES (@ItemID,  @ItemCat, @ItemName, " +
            "@ItemDesc, @ItemImg, @ItemSalePrice, @ItemSID, @ItemSupplierPrice, @ItemWarrantyMonth, @AllowDelivery )";

            //Image pimg = pictureBox.Image;
            //ImageConverter Converter = new ImageConverter();
            //var ImageConvert = Converter.ConvertTo(pimg, typeof(byte[]));
            openConnection();
            cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ItemID", MySqlDbType.VarChar).Value = item.ID;
            cmd.Parameters.Add("@ItemCat", MySqlDbType.VarChar).Value = item.Cat;
            cmd.Parameters.Add("@ItemName", MySqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar).Value = item.Desc;
            cmd.Parameters.Add("@ItemImg", MySqlDbType.Blob).Value = item.Img;
            cmd.Parameters.Add("@ItemSalePrice", MySqlDbType.VarChar).Value = item.SalePrice;
            cmd.Parameters.Add("@ItemSID", MySqlDbType.VarChar).Value = item.SID;
            cmd.Parameters.Add("@ItemSupplierPrice", MySqlDbType.VarChar).Value = item.SPrice;
            cmd.Parameters.Add("@ItemWarrantyMonth", MySqlDbType.VarChar).Value = item.WarrantyMonth;
            cmd.Parameters.Add("@AllowDelivery", MySqlDbType.VarChar).Value = item.AllowDelivery;
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
        //Cancel button
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Clear button
        private void button_Clear_Click(object sender, EventArgs e)
        {
            txtCat.Text = txtName.Text = txtDesc.Text = txtSalesPrice.Text = comboBox_SupplierID.Text = txtSupplierPrice.Text = txtWm.Text = comboBox_allowDly.Text = string.Empty;
            label_Cat.Text = label_Des.Text = label_dly.Text = label_Name.Text = label_SalesPrice.Text = label_SI.Text = label_SuPrice.Text = label_WM.Text = string.Empty;
            pictureBox.Image = Properties.Resources.DefaultPicture;

        }

        //Set remind to enter numeric
        private void txtSalesPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                label_SalesPrice.Text = "Please Enter Numeric";
            }
        }

        private void txtWm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                label_WM.Text = "Please Enter Numeric";
            }
        }

        private void txtSupplierPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                label_SuPrice.Text = "Please Enter Numeric";
            }
        }

        //Choose image button
        private void button_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif)";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }



        private void item_New_Form_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.DefaultPicture;
            comboBox_allowDly.Items.Add("true");
            comboBox_allowDly.Items.Add("false");

            try
            {
                openConnection();
                string sql = "SELECT SupplierID FROM supplier;";
                cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string supplierID = reader["SupplierID"].ToString();
                    comboBox_SupplierID.ValueMember = supplierID;
                    comboBox_SupplierID.Items.Add(supplierID);
                }


                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (txtCat.Text.Trim().Length < 1 ||
               txtName.Text.Trim().Length < 1 ||
               txtDesc.Text.Trim().Length < 1 ||
               txtSalesPrice.Text.Trim().Length < 1 ||
               txtSupplierPrice.Text.Trim().Length < 1 ||
               txtWm.Text.Trim().Length < 1 ||
               comboBox_SupplierID.SelectedItem == null ||
               comboBox_allowDly.SelectedItem == null
               )
            {
                MessageBox.Show("All information should be filled \n (besides item image)");

                if (comboBox_SupplierID.SelectedItem == null)
                {
                    label_SI.Text = "Please Select Supplier ID";
                }
                else
                {
                    label_SI.Text = "";
                }

                if (comboBox_allowDly.SelectedItem == null)
                {
                    label_dly.Text = "Please Select wheather Delivery is allowed";
                }
                else
                {
                    label_dly.Text = "";
                }

                if (txtName.Text.Trim().Length < 1)
                {
                    label_Name.Text = "Please Enter Item Name";
                }
                else
                {
                    label_Name.Text = "";
                }

                if (txtCat.Text.Trim().Length < 1)
                {
                    label_Cat.Text = "Please Enter Category";
                }
                else
                {
                    label_Cat.Text = "";
                }

                if (txtDesc.Text.Trim().Length < 1)
                {
                    label_Des.Text = "Please Enter Description";
                }
                else
                {
                    label_Des.Text = "";
                }

                if (txtSalesPrice.Text.Trim().Length < 1)
                {
                    label_SalesPrice.Text = "Please Enter Sales Price";
                }
                else
                {
                    label_SalesPrice.Text = "";
                }

                if (txtSupplierPrice.Text.Trim().Length < 1)
                {
                    label_SuPrice.Text = "Please Enter Supplier Price";
                }
                else
                {
                    label_SuPrice.Text = "";
                }


                if (txtWm.Text.Trim().Length < 1)
                 {
                    label_WM.Text = "Please Enter Warranty Month";
                }
                else
                {
                    label_WM.Text = "";
                }

                    return;
                }
                else if (txtWm.Text.Trim().Length >= 4)
                {
                    MessageBox.Show("Invalild Warranty Month ");
                    label_WM.Text = "Please Enter Valid Warranty Month";
                    return;
                }
                else
                {
                    Image pimg = pictureBox.Image;
                    ImageConverter Converter = new ImageConverter();
                    var ItemImg = Converter.ConvertTo(pimg, typeof(byte[]));

                    Item item = new Item(txtItemID.Text.Trim(), txtCat.Text.Trim(), txtName.Text.Trim(), txtDesc.Text.Trim(), ItemImg, txtSalesPrice.Text.Trim(), comboBox_SupplierID.Text.Trim(), txtSupplierPrice.Text.Trim(), txtWm.Text.Trim(), comboBox_allowDly.Text.Trim());
                    AddItem(item);
                }
                Close();

                _itemListfrm.DisplayTable();
            }

    }
}
