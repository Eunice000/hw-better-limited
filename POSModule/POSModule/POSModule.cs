using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects.SqlClient;

// 1. Analysis & clean my code (Adding comments etc.)
// 2. Improve the structure (Modulize etc.)
// 3. Adding new features

namespace POSModule
{
    public partial class frmPOS : Form
    {
        public decimal total = 0;
        public decimal paidAmt = 0;

        List<ContrCrdItem> lstCrdItems = new List<ContrCrdItem>();
        List<ContrOdrItem> lstOdrItems = new List<ContrOdrItem>();

        public frmPOS()
        {
            InitializeComponent();
        }

        // Functions
        void LoadData(List<item> _item)
        {          
            for (int i = 0; i < _item.Count(); i++)
            {
                var crdItem = new ContrCrdItem(_item[i]);
                crdItem.BtnAddToLstClicked += OnBtnAddToLstClicked; // Subscribe Event

                lstCrdItems.Add(crdItem);
                flpCrdItems.Controls.Add(lstCrdItems[i]);
            }
        }

        void CountTotal() 
        {
            total = 0;
            foreach (var i in lstOdrItems) 
            {
                total += i.odrItem.salePrice;
            }

            lblDisTotal.Text = total.ToString("C2");
        }

        // Event Handlings
        // From - On Load
        private void Form1_Load(object sender, EventArgs e)
        {
            flpCrdItems.Controls.Clear();

            using (DBEntities db = new DBEntities())
            {
                var item = db.items.ToList();

                LoadData(item);
            }

            // DEBUG
            Console.WriteLine(lstCrdItems.Count());
            Console.WriteLine(txtCash.Text);
        }

        // Button "Search" --- On Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // DEBUG
            Console.WriteLine(lstCrdItems.Count());

            flpCrdItems.Controls.Clear();
            lstCrdItems.Clear();

            using (DBEntities db = new DBEntities())
            {
                var item = db.items
                    .Where(s => s.itemName.Contains(txtSearch.Text))
                    .ToList();

                LoadData(item);

                // DEBUG
                Console.WriteLine(lstCrdItems.Count());
            }
        }

        // Button "Add to Order List" --- On Click
        public void OnBtnAddToLstClicked(object sender, item _item)
        {
            var _odrItem = lstOdrItems.FirstOrDefault(i => i.odrItem.itemId == _item.itemId);

            if (_odrItem == null)
            {
                var ordItem = new ContrOdrItem(_item); // Subscriber
                ordItem.BtnOdrItemDeleted += OnBtnOdrItemDeleted; // Subscribe to the event
                ordItem.OdrItemIncremented += OnOdrItemIncrement;

                lstOdrItems.Add(ordItem);
                flpOdrLst.Controls.Add(ordItem);
                CountTotal();
            }
            else
            {
                OnOdrItemIncrement(1, _odrItem);
            }

            // DEBUG
            Console.WriteLine("#" + _item.itemId + " " + _item.itemName + " $" + _item.itemPrice);
            Console.WriteLine("Number of ordered item(s): " + lstOdrItems.Count());
            Console.WriteLine(lblDisTotal.Text);
        }

        // Button "Delete Item" --- On Click
        public void OnBtnOdrItemDeleted(object sender, ContrOdrItem _item)
        {
            lblDisTotal.Text = (total -= _item.odrItem.salePrice * lstOdrItems.Count(i => i.odrItem.itemId == _item.odrItem.itemId)).ToString("C2");

            if (txtCash != null)
                    txtCash_TextChanged(this, EventArgs.Empty);

            // DEBUG
            Console.WriteLine("Number of deleted item(s) : " + lstOdrItems.Count(i => i.odrItem.itemId == _item.odrItem.itemId));
            Console.WriteLine();

            lstOdrItems.RemoveAll(i => i.odrItem.itemId == _item.odrItem.itemId);
            flpOdrLst.Controls.Remove(_item);
            _item.Dispose();

            // DEBUG
            Console.WriteLine("Number of ordered item(s): " + lstOdrItems.Count());
        }

        // Button "+" & "-" --- On Click
        public void OnOdrItemIncrement(object sender, ContrOdrItem _item)
        {
            if ((int)sender < 1)
                lstOdrItems.Remove(_item);
            else
                lstOdrItems.Add(_item);

            _item.odrItem.Qty += Convert.ToInt32(sender);
            if (_item.odrItem.Qty < 1)
            {
                lstOdrItems.Remove(_item);
                _item.Dispose();
            }
            else
            {
                _item.UpdataData();
            }
            CountTotal();

            if (txtCash.Text != null) txtCash_TextChanged(this, EventArgs.Empty);

            Console.WriteLine("#" + _item.odrItem.itemId + " $" + _item.odrItem.salePrice);
            Console.WriteLine("Number of ordered item(s): " + lstOdrItems.Count());
        }

        // Button "Cancel" --- On Click
        private void btnClearOdrLst_Click(object sender, EventArgs e)
        {
            lblDisTotal.Text = lblDisChange.Text = (total = 0).ToString("C2");
            lstOdrItems.Clear();
            flpOdrLst.Controls.Clear();
        }

        // Text Box "Payment Amount" --- On Text Changed
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(txtCash.Text) || !txtCash.Text.Any(char.IsDigit))
                lblDisChange.Text = (paidAmt - total).ToString("2C");
            else if (!Decimal.TryParse(txtCash.Text, out paidAmt))
                lblDisChange.Text = (paidAmt - total).ToString("2C");
            else
                lblDisChange.Text = ((paidAmt = Convert.ToDecimal(txtCash.Text.Trim())) - total).ToString("2C");
        }
        
        // Button "Checkout" --- On Click
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (lstOdrItems.Count() == 0)
                MessageBox.Show("No item(s) added.");
            else
            {
                using (DBEntities db = new DBEntities())
                {
                    salesorder odr = new salesorder();

                    odr.paidAmt = paidAmt;
                    odr.Date = DateTime.UtcNow.Date;
                    odr.Time = DateTime.Now.TimeOfDay;
                    odr.PaymentStatus = "settled";

                    foreach (var i in lstOdrItems)
                    {
                        odr.salesorder_item.Add(i.odrItem);
                    }
                    db.salesorders.Add(odr);
                    db.SaveChanges();
                }
            }
            
            lblDisTotal.Text = txtCash.Text = lblDisChange.Text = (total = 0).ToString("C2");
            paidAmt = 0;

            lstOdrItems.Clear();
            flpOdrLst.Controls.Clear();
        }
    }
}
