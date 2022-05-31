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

        

        private void Mune_Load(object sender, EventArgs e)
        {
            
            openConnection();
            command = new MySqlCommand("SELECT StaffID, StaffName,Position,Depart FROM staff WHERE StaffID=@staffID;",conn);
            command.Parameters.AddWithValue("staffID", getStaffID);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                Label_UserDepartment.Text+= reader["Depart"].ToString();
                Label_UserPosition.Text+= reader["Position"].ToString();
                Label_UserName.Text+= reader["StaffName"].ToString();
                Label_UserID.Text+= reader["StaffID"].ToString();

            }
            else
            {
                MessageBox.Show("Dedug: code in MenuForm.cs, Error : Staff Not Data Found");
            }
            closeConnection();


            //Purchase Module
            flPanel_PurchaseDepart.Visible = false;

            //Accounting Module
            flPanel_AccountDepart.Visible = false;

            //Inventory Module
            flPanel_InventoryDepart.Visible = false;

            //Sales Module
            flPanel_SalesDepart.Visible = false;

            //Technical Module
            flPanel_TechnicalDepart.Visible = false;

            //Deopartment Funtion 
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

        }

        private void button_AccountingAnalysisModule_Accounting_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = true;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Account_PMM.Visible = false;
            flpanel_Account_ISMM.Visible = false;
            flpanel_Account_AAM.Visible = true;
        }

        private void button_AccountingAnalysisModule_Purchase_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = true;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Purchase_PMM.Visible = false;
            flpanel_Purchase_ISMM.Visible = false;
            flpanel_Purchase_AAM.Visible = true;
        }

        private void button_AccountingAnalysisModule_Sales_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = true;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Sales_POS.Visible = false;
            flpanel_Sales_RSMM.Visible = false;
            flpanel_Sales_PMM.Visible = false;
            flpanel_Sales_AAM.Visible = true;
            flpanel_Sales_RIM.Visible = false;
        }

        private void button_ProductManageModule_Accounting_Click(object sender, EventArgs e)
        {

            flpanel_AccountFuntion.Visible = true;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Account_PMM.Visible = true;
            flpanel_Account_ISMM.Visible = false;
            flpanel_Account_AAM.Visible = false;

        }

        private void button_ProductManageModule_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = true;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Sales_POS.Visible = false;
            flpanel_Sales_RSMM.Visible = false;
            flpanel_Sales_PMM.Visible = true;
            flpanel_Sales_AAM.Visible = false;
            flpanel_Sales_RIM.Visible = false;
        }

        

        private void button_DeliveryInstallationModule_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = true;

            flpanel_Inventory_DIM.Visible = true;
            flpanel_Inventory_AAM.Visible = false;
            flpanel_Inventory_ISMM.Visible = false;
            flpanel_Inventory_RSMM.Visible = false;
            flpanel_Inventory_RIM.Visible = false;
        }

        private void button_InventoryStorckMangementModule_Purchase_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = true;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Purchase_PMM.Visible = false;
            flpanel_Purchase_ISMM.Visible = true;
            flpanel_Purchase_AAM.Visible = false;
        }

        private void button_InventoryStorckMangementModule_Accounting_Click(object sender, EventArgs e)
        {

        }

        private void button_InventoryStorckMangementModule_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = true;

            flpanel_Inventory_DIM.Visible = false;
            flpanel_Inventory_AAM.Visible = false;
            flpanel_Inventory_ISMM.Visible = true;
            flpanel_Inventory_RSMM.Visible = false;
            flpanel_Inventory_RIM.Visible = false;
        }

        private void button_RetailStorckManageModule_Inventory_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = true;

            flpanel_Inventory_DIM.Visible = false;
            flpanel_Inventory_AAM.Visible = false;
            flpanel_Inventory_ISMM.Visible = false;
            flpanel_Inventory_RSMM.Visible = true;
            flpanel_Inventory_RIM.Visible = false;
        }

        private void button_RetailStorckManageModule_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = true;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Sales_POS.Visible = false;
            flpanel_Sales_RSMM.Visible = true;
            flpanel_Sales_PMM.Visible = false;
            flpanel_Sales_AAM.Visible = false;
            flpanel_Sales_RIM.Visible = false;
        }
        
        private void button_POSModule_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = true;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Sales_POS.Visible = true;
            flpanel_Sales_RSMM.Visible = false;
            flpanel_Sales_PMM.Visible = false;
            flpanel_Sales_AAM.Visible = false;
            flpanel_Sales_RIM.Visible = false;
        }

        


        //Mune  Depart button :
        private void button_PurchaseDepart_Click(object sender, EventArgs e)
        {
            if (flPanel_PurchaseDepart.Visible == false)
            {
                flPanel_PurchaseDepart.Visible = true;
            }
            else
            {
                flPanel_PurchaseDepart.Visible = false;
            }
        }

        private void button_AccountingDepart_Click(object sender, EventArgs e)
        {
            if (flPanel_AccountDepart.Visible == false)
            {
                flPanel_AccountDepart.Visible = true;
            }
            else
            {
                flPanel_AccountDepart.Visible = false;
            }
        }

        private void button_InventoryDepart_Click(object sender, EventArgs e)
        {
            if (flPanel_InventoryDepart.Visible == false)
            {
                flPanel_InventoryDepart.Visible = true;
            } 
            else
            {
                flPanel_InventoryDepart.Visible = false;
            }
            
        }

        private void button_SalesDepart_Click(object sender, EventArgs e)
        {
            if (flPanel_SalesDepart.Visible == false)
            {
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
                flPanel_TechnicalDepart.Visible = true;
            }
            else
            {
                flPanel_TechnicalDepart.Visible = false;
            }
        }



        private void button_InventoryStorckMangementModule_Accounting_Click_1(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = true;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Account_ISMM.Visible = true;
            flpanel_Account_PMM.Visible = false;
            flpanel_Account_AAM.Visible = false;

        }

        private void button_ProductManageModule_Purchase_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = true;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Purchase_PMM.Visible = true;
            flpanel_Purchase_ISMM.Visible = false;
            flpanel_Purchase_AAM.Visible = false;
        }

        private void button_Function_SalesItemList_Click(object sender, EventArgs e)
        {

        }

        private void button_DeliverAndInstallModule_Technical_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = true;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Technical_AAM.Visible = false;
            flpanel_Technical_DIM.Visible = true;

        }

        private void button_ReturnItemsModule_Sales_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = true;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Sales_POS.Visible = false;
            flpanel_Sales_RSMM.Visible = false;
            flpanel_Sales_PMM.Visible = false;
            flpanel_Sales_AAM.Visible = false;
            flpanel_Sales_RIM.Visible = true;
        }

        private void button_AccountingAnalysisModule_Technical_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = true;
            flpanel_InventoryFuntion.Visible = false;

            flpanel_Technical_AAM.Visible = true;
            flpanel_Technical_DIM.Visible = false;
        }

        private void button_AccountingAnalysisModule_Inventory_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = true;

            flpanel_Inventory_DIM.Visible = false;
            flpanel_Inventory_AAM.Visible = true;
            flpanel_Inventory_ISMM.Visible = false;
            flpanel_Inventory_RSMM.Visible = false;
            flpanel_Inventory_RIM.Visible = false;
        }

        private void button_ReturnItemModule_Inventory_Click(object sender, EventArgs e)
        {
            flpanel_AccountFuntion.Visible = false;
            flpanel_PurchaseFuntion.Visible = false;
            flpanel_SalesFuntion.Visible = false;
            flpanel_TechnicalFuntion.Visible = false;
            flpanel_InventoryFuntion.Visible = true;

            flpanel_Inventory_DIM.Visible = false;
            flpanel_Inventory_AAM.Visible = false;
            flpanel_Inventory_ISMM.Visible = false;
            flpanel_Inventory_RSMM.Visible = false;
            flpanel_Inventory_RIM.Visible = true;
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
