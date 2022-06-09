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
    public partial class supplierUpdateForm : Form
    {
        //Database 
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        string SupplierID;
        private SupplierList _supplierListfrm;
        public supplierUpdateForm(SupplierList supplierListfrm)
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

        private void supplierUpdateForm_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT * FROM supplier WHERE SupplierID= " + getSupplierID + ";", con);
            openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                txtSupplierID.Text = reader["SupplierID"].ToString();
                txtName.Text = reader["SupplierName"].ToString();
                txtAddress.Text = reader["Address"].ToString();
                txtTel.Text = reader["Tel"].ToString();

            }
            closeConnection();
        }

        private void button_update_Click(object sender, EventArgs e)
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

                if (txtTel.Text.Trim().Length < 8)
                {
                    label_tel.Text = "Please Enter Correct Telephone Number";
                }
            }
            else
            {
                string sql = "UPDATE supplier SET " +
                    "SupplierID = @SupplierID, " +
                    "SupplierName = @SupplierName, " +
                    "Address = @Address, " +
                     "Tel = @Tel " +
                    "WHERE SupplierID = @SupplierID; ";
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
                    MessageBox.Show("Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Item not updated. \n " + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                closeConnection();
                Close();
            }
            
            _supplierListfrm.DisplayTable();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT * FROM supplier WHERE SupplierID= " + getSupplierID + ";", con);
            label_tel.Text = label_address.Text = label_name.Text = "";

            openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                txtSupplierID.Text = reader["SupplierID"].ToString();
                txtName.Text = reader["SupplierName"].ToString();
                txtAddress.Text = reader["Address"].ToString();
                txtTel.Text = reader["Tel"].ToString();

            }
            closeConnection();
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
