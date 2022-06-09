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
        string department, position;
        string staffID = "10001";
        //get set StaffID
        public string getStaffID
        {
            get
            {
                return staffID;
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

        public void HiddenAllButton()
        {
            button_AccountingDepart.Visible = false;
            button_PurchaseDepart.Visible = false;
            button_SalesDepart.Visible = false;
            button_TechnicalDepart.Visible = false;
            button_InventoryDepart.Visible = false;
            btnAdmin.Visible = false;
        }

        public void HiddenAllModule()
        {
            flPanel_AccountDepart.Visible = false;
            flPanel_PurchaseDepart.Visible = false;
            flPanel_SalesDepart.Visible = false;
            flPanel_TechnicalDepart.Visible = false;
            flPanel_InventoryDepart.Visible = false;
            flowLayoutPanel_Admin.Visible = false;
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

            flowLayoutPanel_Admin.Visible = false;
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

        private void Menu_Load(object sender, EventArgs e)
        {
            checkPermission(staffID);
            HiddenAllButton();
            HiddenAllModule();
            HiddenAllFunction();
            switch (department) {
                case "Accounting":
                    button_AccountingDepart.Visible = true;
                    break;
                case "Purchase":
                    button_PurchaseDepart.Visible = true;
                    break;    
                case "Sales":
                    button_SalesDepart.Visible = true;
                    break;
                case "Technical Support":
                    button_TechnicalDepart.Visible = true;
                    break;
                case "Inventory":
                    button_InventoryDepart.Visible = true;
                    break;
                default:
                    button_AccountingDepart.Visible = true;
                    button_PurchaseDepart.Visible = true;
                    button_SalesDepart.Visible = true;
                    button_TechnicalDepart.Visible = true;
                    button_InventoryDepart.Visible = true;
                    btnAdmin.Visible = true;
                    break;
            }            
        }

        public void checkPermission(string staffID)
        {
            openConnection();
            command = new MySqlCommand("SELECT StaffID, StaffName,Position,Depart FROM staff WHERE StaffID=@staffID;", conn);
            command.Parameters.AddWithValue("staffID", staffID);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                department = reader["Depart"].ToString();
                position = reader["Position"].ToString();
                Label_UserDepartment.Text += department;
                Label_UserPosition.Text += position;
                Label_UserName.Text += reader["StaffName"].ToString();
                Label_UserID.Text += reader["StaffID"].ToString();
            }
            else
            {
                MessageBox.Show("Dedug: code in MenuForm.cs, Error : Staff Not Data Found");
            }
            closeConnection();
        }

        public void addReOrderItem(string itemID, string itemName) 
        {
            ReOrderRequestForm rorform = new ReOrderRequestForm();
            rorform.setStaffID = getStaffID;
            rorform.setDepartment = getDepartment;
            rorform.setPosition = getPosition;
            rorform.addReOrderItem(itemID, itemName);
            loadform(rorform);
        }
        public void addReStockItem(string itemID, string itemName, string supplierID, string storeID)
        {
            CreateRestockRequestForm crrform = new CreateRestockRequestForm();
            crrform.addReStockItem(itemID, itemName, supplierID, storeID);
            crrform.setStaffID = getStaffID;
            crrform.setDepartment = getDepartment;
            crrform.setPosition = getPosition;
            loadform(crrform);
        }
        private void button_LogOut_Click(object sender, EventArgs e)
        {
            LoginForm menuform = new LoginForm();
            this.Hide();
            menuform.Show();
        }

        private void button_Sales_PMM_SalesItemList_Click(object sender, EventArgs e)
        {
            ItemList itemlist = new ItemList();
            loadform(itemlist);
        }

        private void button_Inventory_DIM_DeliveryArrangement_Click(object sender, EventArgs e)
        {
            loadform(new DeliveryForm());
            DeliveryForm deliveryform = new DeliveryForm();
            deliveryform.setStaffID = getStaffID;
            deliveryform.setDepartment = getDepartment;
            deliveryform.setPosition = getPosition;
            loadform(deliveryform);
        }

        private void button_Technical_DIM_InstallationArrangement_Click(object sender, EventArgs e)
        {
            InstallationForm installationform = new InstallationForm();
            installationform.setStaffID = getStaffID;
            installationform.setDepartment = getDepartment;
            installationform.setPosition = getPosition;
            loadform(installationform);
        }

        private void button_Purchase_ISMM_ReorderRequest_Click(object sender, EventArgs e)
        {
            ReOrderRequestForm rorform = new ReOrderRequestForm();
            rorform.setStaffID = getStaffID;
            rorform.setDepartment = getDepartment;
            rorform.setPosition = getPosition;
            loadform(rorform);
        }

        private void button_Inventory_RSMM_RetailStockLevel_Click(object sender, EventArgs e)
        {
            RetailStockLevelForm rslform = new RetailStockLevelForm();
            rslform.setStaffID = getStaffID;
            rslform.setDepartment = getDepartment;
            rslform.setPosition = getPosition;
            loadform(rslform);
        }

        private void button_Sales_RSMM_ReRestockRequest_Click(object sender, EventArgs e)
        {
            RestockRequestRecord rsrrform = new RestockRequestRecord();
            rsrrform.setStaffID = getStaffID;
            rsrrform.setDepartment = getDepartment;
            rsrrform.setPosition = getPosition;
            loadform(rsrrform);
        }

        private void button_Inventory_ISMM_InventoryStorckLevel_Click(object sender, EventArgs e)
        {
            InventoryStockLevelForm islfrm = new InventoryStockLevelForm();
            islfrm.setStaffID = getStaffID;
            islfrm.setDepartment = getDepartment;
            islfrm.setPosition = getPosition;
            loadform(islfrm);
        }

        private void button_Sales_RSMM_SalesItemList_Click(object sender, EventArgs e)
        {
            ItemList itemlist = new ItemList();
            loadform(itemlist);
        }

        private void button_Sales_RSMM_InventoryStockLevel_Click(object sender, EventArgs e)
        {
            InventoryStockLevelForm islfrm = new InventoryStockLevelForm();
            islfrm.setStaffID = getStaffID;
            islfrm.setDepartment = getDepartment;
            islfrm.setPosition = getPosition;
            loadform(islfrm);
        }

        private void button_Function_Account__PMM_ItemList_Click(object sender, EventArgs e)
        {
            ItemList itemlist = new ItemList();
            loadform(itemlist);
        }

        private void button_Purchase_PMM_PurchaseItemList_Click(object sender, EventArgs e)
        {
            ItemList itemlist = new ItemList();
            loadform(itemlist);
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            SalesOrder soform = new SalesOrder();
            soform.setStaffID = getStaffID;
            soform.setDepartment = getDepartment;
            soform.setPosition = getPosition;
            loadform(soform);
        }

        private void btnDailyDelivery_Click(object sender, EventArgs e)
        {
            dailyDelivery dailydeliveryform = new dailyDelivery();
            dailydeliveryform.setStaffID = getStaffID;
            dailydeliveryform.setDepartment = getDepartment;
            dailydeliveryform.setPosition = getPosition;
            loadform(dailydeliveryform);
        }


        private void button_Sales_RSMM_SalesStorckLevel_Click(object sender, EventArgs e)
        {
            RetailStockLevelForm rslform = new RetailStockLevelForm();
            rslform.setStaffID = getStaffID;
            rslform.setDepartment = getDepartment;
            rslform.setPosition = getPosition;
            loadform(rslform);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel_Admin.Visible == false)
            {
                HiddenAllModule();
                flowLayoutPanel_Admin.Visible = true;
            }
            else
            {
                flowLayoutPanel_Admin.Visible = false;
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            AccountManagementForm amform = new AccountManagementForm();
            amform.setStaffID = getStaffID;
            amform.setDepartment = getDepartment;
            amform.setPosition = getPosition;
            loadform(amform);
        }

        private void button_Sales_posMod_POS_Click(object sender, EventArgs e)
        {
            frmPOS pos = new frmPOS();
            loadform(pos);
        }

        private void button__Sales_PMM_SupplierList_Click(object sender, EventArgs e)
        {
            SupplierList slform = new SupplierList();
            loadform(slform);
        }

        private void button_Inventory_ISMM_SupplierList_Click(object sender, EventArgs e)
        {
            SupplierList slform = new SupplierList();
            loadform(slform);
        }

        private void button_Purchase_PMM_SupplierList_Click(object sender, EventArgs e)
        {
            SupplierList slform = new SupplierList();
            loadform(slform);
        }

        private void button_Account__AAM_SupplierList_Click(object sender, EventArgs e)
        {
            SupplierList slform = new SupplierList();
            loadform(slform);
        }

        private void button_Inventory_DIM_WorkmenInfoRecord_Click(object sender, EventArgs e)
        {
            ViewDeliveryWorkmanForm vdwform = new ViewDeliveryWorkmanForm();
            loadform(vdwform);
        }

        private void button_Inventory_DIM_DeliveryWorkmanManagement_Click(object sender, EventArgs e)
        {
            DeliveryWorkerForm dwform = new DeliveryWorkerForm();
            loadform(dwform);
        }

        private void button_Technical_DIM_WorkmenInfoRecord_Click(object sender, EventArgs e)
        {
            ViewInstallationWorkmanForm viwform = new ViewInstallationWorkmanForm();
            loadform(viwform);
        }

        private void button_Technical_DIM_InstallationWorkmanManagement_Click(object sender, EventArgs e)
        {
            InstallationWorkerForm iwform = new InstallationWorkerForm();
            loadform(iwform);
        }

        public void button_Inventory_ISMM_ReorderRequest_Click(object sender, EventArgs e)
        {
            ReOrderRequestForm rorform = new ReOrderRequestForm();
            rorform.setStaffID = getStaffID;
            rorform.setDepartment = getDepartment;
            rorform.setPosition = getPosition;
            loadform(rorform);
        }
    }
}
