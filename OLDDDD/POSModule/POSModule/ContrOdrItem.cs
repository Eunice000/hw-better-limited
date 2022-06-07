using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSModule
{
    public partial class ContrOdrItem : UserControl
    {
        public salesorder_item odrItem;

        public event EventHandler<ContrOdrItem> BtnOdrItemDeleted;
        public event EventHandler<ContrOdrItem> OdrItemIncremented;

        public ContrOdrItem(item _itm)
        {
            InitializeComponent();
            Item = _itm;
            lblDisQty.Text = (odrItem.Qty = 1).ToString();
        }

        private item itm;
        private item Item
        {
            get { return itm; }

            set
            {
                itm = value;
                odrItem = new salesorder_item();

                odrItem.itemId = itm.itemId;
                odrItem.salePrice = itm.itemPrice;
                    
                lblOdrItemId.Text = "#" + itm.itemId.ToString();
                lblOdrItemName.Text = itm.itemName;
                lblOdrItemPrice.Text = "$" + itm.itemPrice.ToString();
            }
        }

        public void UpdataData()
        {
            lblDisQty.Text = odrItem.Qty.ToString();
            lblOdrItemPrice.Text = "$" + (odrItem.salePrice * odrItem.Qty).ToString();
        }

        private void btnDeleteOdrItem_Click(object sender, EventArgs e)
        {
            BtnOdrItemDeleted?.Invoke(sender, this);
        }

        private void btnQtyIncrement_Click(object sender, EventArgs e)
        {
            OdrItemIncremented?.Invoke(1, this);
        }

        private void btnQtyReduction_Click(object sender, EventArgs e)
        {
            OdrItemIncremented?.Invoke(-1, this);
        }
    }
}
