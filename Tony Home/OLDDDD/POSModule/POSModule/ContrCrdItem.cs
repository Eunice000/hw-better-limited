using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POSModule
{
    public partial class ContrCrdItem : UserControl
    {
        private item itm;
        private int qty;
        public event EventHandler<item> BtnAddToLstClicked;

        public ContrCrdItem(item _item)
        {
            InitializeComponent();
            CrdItem = _item;
            CheckStockQty(_item);
        }

        private item CrdItem
        {
            get { return itm; }

            set
            {
                itm = value;
                picItem.BackgroundImage = ByteArrayToImage(itm.ItemImg.ToArray());
                lblDisItemID.Text = $"#{itm.ItemID}";
                lblDisItemName.Text = itm.ItemName;
                lblDisItemPrice.Text = itm.SalePrice.ToString("C0");
            }
        }

        // Translate byte data into an image
        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        public void CheckStockQty(item _item)
        {
            using (dbEntities db = new dbEntities())
            {
                if (db.retailstocklevels.Where(i => i.itemID == _item.ItemID && i.Quantity == 0).Any())
                {
                    btnAddToLst.Text = "Out of Stock\n[Add to Pre-order]";
                    btnAddToLst.BackColor = Color.Brown;
                }
            }
        }
        public void UpdateCrd() 
        {
            btnAddToLst.Text = "Out of Stock\n[Add to Pre-order]";
            btnAddToLst.BackColor = Color.Brown;
        }

        private void btnAddToLst_Click(object sender, EventArgs e)
        {
            // Raise the event
            // if (BtnAddToLstClicked != null) BtnAddToLstClicked(sender, itm);
            BtnAddToLstClicked?.Invoke(sender, itm);
        }
    }
}
