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

namespace BetterLimited
{
    public partial class supplierNewForm : Form
    {
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        private SupplierList _supplierListfrm;
        string SupplierID;
        public supplierNewForm(SupplierList supplierListfrm)
        {
            InitializeComponent();
            _supplierListfrm = supplierListfrm;
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

        private void button_save_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Trim().Length < 1 ||
                txtAddress.Text.Trim().Length < 1 ||
                txtTel.Text.Trim().Length < 8)
            {
                label_tel.Text = label_address.Text = label_name.Text = "";
                if (txtName.Text.Trim().Length < 1)
                {
                    label_name.Text = "Please Enter Supplier Name";
                }

                if (txtAddress.Text.Trim().Length < 1)
                {
                    label_address.Text = "Please Enter Address";
                }

                if(txtTel.Text.Trim().Length < 8)
                {
                    label_tel.Text = "Please Enter Correct Telephone Number";
                }
            }
            else
            {

                string sql = "INSERT INTO supplier VALUES (@SupplierID, @SupplierName,@Address, @Tel);";

                //Image pimg = pictureBox.Image;
                //ImageConverter Converter = new ImageConverter();
                //var ImageConvert = Converter.ConvertTo(pimg, typeof(byte[]));
                openConnection();
                cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("SupplierID", txtSupplierID.Text);
                cmd.Parameters.AddWithValue("SupplierName", txtName.Text);
                cmd.Parameters.AddWithValue("Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("Tel", txtTel.Text);
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
                Close();
            }
            
            _supplierListfrm.DisplayTable();

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            txtName.Text = txtAddress.Text = txtTel.Text = "";
            label_tel.Text = label_address.Text = label_name.Text = "";
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                label_tel.Text = "Please Enter Numeric";
                e.Handled = true;
            }
        }
    }
}