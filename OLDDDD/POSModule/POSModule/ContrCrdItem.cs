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
                picItem.BackgroundImage = ByteArrayToImage(itm.itemImg.ToArray());
                lblDisItemID.Text = "#" + itm.itemId.ToString();
                lblDisItemName.Text = itm.itemName;
                lblDisItemPrice.Text = "$" + itm.itemPrice.ToString();
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
            using (DBEntities db = new DBEntities())
            {
                if (db.stocklevels.Where(i => i.itemId == _item.itemId && i.qty == 0).Any())
                {
                    btnAddToLst.Text = "Out of Stock\n[Add to Pre-order]";
                    btnAddToLst.BackColor = Color.Brown;
                    btnAddToLst.Click -= btnAddToLst_Click;
                }
            }
        }

        private void btnAddToLst_Click(object sender, EventArgs e)
        {
            // Raise the event
            // if (BtnAddToLstClicked != null) BtnAddToLstClicked(sender, itm);
            BtnAddToLstClicked?.Invoke(sender, itm);
        }
    }
}
