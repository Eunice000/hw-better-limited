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
    public partial class MenuForm : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string staffID;

        //get set StaffID
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

        public bool selectQuery(string sql)
        {
            command = conn.CreateCommand();
            command.CommandText = sql;
            try
            {
                openConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }

        public MenuForm()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();


        }



        public void HiddenAllModule()
        {
            flPanel_AccountDepart.Visible = false;
            flPanel_PurchaseDepart.Visible = false;
            flPanel_SalesDepart.Visible = false;
            flPanel_TechnicalDepart.Visible = false;
            flPanel_InventoryDepart.Visible = false;
        }

        // Department
        private void button_AccountingDepart_Click(object sender, EventArgs e)
        {
            
            if(flPanel_AccountDepart.Visible == true) { 
                flPanel_AccountDepart.Visible = false;
            }
            else
            {
                HiddenAllModule();
                flPanel_AccountDepart.Visible = true;
            }
        }

        private void button_PurchaseDepart_Click(object sender, EventArgs e)
        {
            
            if (flPanel_PurchaseDepart.Visible == false)
            {
                HiddenAllModule();
                flPanel_PurchaseDepart.Visible = true;
            }
            else
            {
                flPanel_PurchaseDepart.Visible = false;
            }
        }

        private void button_SalesDepart_Click(object sender, EventArgs e)
        {
            
            if (flPanel_SalesDepart.Visible == false)
            {
                HiddenAllModule();
                flPanel_SalesDepart.Visible = true;
            }
            else
            {
                flPanel_SalesDepart.Visible = false;
            }
        }

        private void button_TechnicalDepart_Click(object sender, EventArgs e)
        {
            

            if (flPanel_TechnicalDepart.Visible == false)
            {
                HiddenAllModule();
                flPanel_TechnicalDepart.Visible = true;
            }
            else
            {
                flPanel_TechnicalDepart.Visible = false;
            }
        }

        private void button_InventoryDepart_Click(object sender, EventArgs e)
        {
            
            if (flPanel_InventoryDepart.Visible == false)
            {
                HiddenAllModule();
                flPanel_InventoryDepart.Visible = true;
            }
            else
            {
                flPanel_InventoryDepart.Visible = false;
            }
        }




        public void HiddenAllFunction()
        {
            flowLayoutPanel_Account_RIM.Visible = false;
            flowLayoutPanel_Account_ISMM.Visible = false;
            flowLayoutPanel_Account_PMM.Visible = false;
            flowLayoutPanel_Account_AAM.Visible = false;

            flowLayoutPanel_Sales_POS.Visible = false;
            flowLayoutPanel_Sales_AAM.Visible = false;
            flowLayoutPanel_Sales_RIM.Visible = false;
            flowLayoutPanel_Sales_PMM.Visible = false;
            flowLayoutPanel_Sales_RSMM.Visible = false;

            flowLayoutPanel_Purchase_AAM.Visible = false;
            flowLayoutPanel_Purchase_ISMM.Visible = false;
            flowLayoutPanel_Purchase_PMM.Visible = false;

            flowLayoutPanel_Inventory_RSMM.Visible = false;
            flowLayoutPanel_Inventory_DIM.Visible = false;
            flowLayoutPanel_Inventory_AAM.Visible = false;
            flowLayoutPanel_Inventory_RIM.Visible = false;
            flowLayoutPanel_Inventory_ISMM.Visible = false;

            flowLayoutPanel_Technical_AAM.Visible = false;
            flowLayoutPanel_Technical_DIM.Visible = false;
        }

        //Accounting Module
        private void button_PMM_Accounting_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Account_PMM.Visible = true;
        }

        private void button_AAM_Accounting_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Account_AAM.Visible = true;
        }

        private void button_ISMM_Account_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Account_ISMM.Visible = true;
        }

        private void button_RIM_Account_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Account_RIM.Visible = true;
        }


        //Purchase Module
        private void button_ISMM_Purchase_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Purchase_ISMM.Visible = true;
        }

        private void button_AAM_Purchase_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Purchase_AAM.Visible = true;
        }

        private void button_PMM_Purchase_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Purchase_PMM.Visible = true;
        }


        //Sales Module
        private void button_PMM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_PMM.Visible = true;
        }

        private void button_AAM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_AAM.Visible = true;

        }

        private void button_RSMM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_RSMM.Visible = true;

        }

        private void button_POSM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_POS.Visible = true;

        }

        private void button_RIM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_RIM.Visible = true;

        }

        //Technical Module
        private void button_AAM_Technical_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Technical_AAM.Visible = true;
        }

        private void button_DIM_Technical_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Technical_DIM.Visible = true;

        }

        //Inventory Module
        private void button_DIM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_DIM.Visible = true;
        }

        private void button_AAM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_AAM.Visible = true;

        }

        private void button_ISMM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_ISMM.Visible = true;

        }

        private void button_RSMM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_RSMM.Visible = true;
        }

        private void button_RIM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_RIM.Visible = true;
        }






        private void Mune_Load(object sender, EventArgs e)
        {
            HiddenAllModule();
            HiddenAllFunction();


            openConnection();
            command = new MySqlCommand("SELECT StaffID, StaffName,Position,Depart FROM staff WHERE StaffID=@staffID;", conn);
            command.Parameters.AddWithValue("staffID", getStaffID);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                Label_UserDepartment.Text += reader["Depart"].ToString();
                Label_UserPosition.Text += reader["Position"].ToString();
                Label_UserName.Text += reader["StaffName"].ToString();
                Label_UserID.Text += reader["StaffID"].ToString();

            }
            else
            {
                MessageBox.Show("Dedug: code in MenuForm.cs, Error : Staff Not Data Found");
            }
            closeConnection();
        }



        private void button_LogOut_Click(object sender, EventArgs e)
        {
            LoginForm menuform = new LoginForm();
            this.Hide();
            menuform.Show();
        }









        //Mune  Depart button(End)
    }
}
