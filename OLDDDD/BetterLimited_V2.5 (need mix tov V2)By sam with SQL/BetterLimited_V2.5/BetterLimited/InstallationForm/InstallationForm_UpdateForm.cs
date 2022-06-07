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
    public partial class InstallationForm_UpdateForm : Form
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


        public InstallationForm_UpdateForm()
        {
            InitializeComponent();
        }

        private void InstallationForm_UpdateForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_InstallationTime.Format = DateTimePickerFormat.Time;
            dateTimePicker_InstallationTime.ShowUpDown = true;

            openConnection();

            string sql = "SELECT * FROM installationorder WHERE InstallationID = @installationID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("installationID", getInstallationID);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //textBox_Date.Text = reader["Date"].ToString();
                textBox_InstallationID.Text = reader["InstallationID"].ToString();
                textBox_SalesOrderID.Text = reader["SalesOrderID"].ToString();
                textbox_CustomerID.Text = reader["CustomerID"].ToString();
                dateTimePicker__InstallationDate.Text = Convert.ToDateTime(reader["InstallationDate"]).ToString("yyyy/MM/dd");
                dateTimePicker_InstallationTime.Text = reader["InstallationTime"].ToString();
                comboBox_InstallationStatus.Text = reader["installationStatus"].ToString();

            }
            else
            {
                MessageBox.Show("Dedug: code in Installation_UpdateForm.cs, Error :  Not Data Found");
            }
            closeConnection();
        }

        private void button_cacel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            openConnection();

            string sql = "UPDATE installationorder SET " +
                "InstallationDate=@installationDate," +
                "InstallationTime=@installationTime," +
                "InstallationStatus=@installationStatus" +
                " WHERE InstallationID = @installationID;";
            
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("installationDate", dateTimePicker__InstallationDate.Text);
            command.Parameters.AddWithValue("installationTime", dateTimePicker_InstallationTime.Text);
            command.Parameters.AddWithValue("installationStatus", comboBox_InstallationStatus.Text);
            command.Parameters.AddWithValue("installationID", textBox_InstallationID.Text);


            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Update Successfuly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Update unuccessfuly. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            closeConnection();
            this.Hide();
        }




        private void textBox_InstallationID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox_SalesOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textbox_CustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

    }
}
