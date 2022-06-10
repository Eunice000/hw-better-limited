using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace POSModule
{
    public partial class frmTestReceipt : Form
    {
        public frmTestReceipt()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrinterSettings ps = new PrinterSettings();
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings = ps;

                pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 315, 300);
                pd.PrintPage += pd_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (dbEntities db = new dbEntities())
            { 
                
            }

            Font fontTitle = new Font("Arial", 32, FontStyle.Bold);
            Font fontSubtitle = new Font("Arial", 24, FontStyle.Regular);
            Font fontNormal = new Font("Arial", 12, FontStyle.Regular);
            Font fontBold = new Font("Arial", 12, FontStyle.Bold);
            

            float topMargin = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;

            string receipt_no = "10002";
            string receipt_date = DateTime.Now.Date.ToString();
            string net_total = 0.ToString("C2");

            String lineStyle1 = new String('-', 174);
            String lineSytle2 = new string('=', 174);
            float height = 30;


            // Company Title
            e.Graphics.DrawString("Better Limited", fontTitle, Brushes.Black, 200, height, new StringFormat());
            height += 40;

            // Subtitle
            e.Graphics.DrawString("Order Receipt", fontSubtitle, Brushes.Black, 200, height, new StringFormat());
            height += 20;

            //Print Company Address
            e.Graphics.DrawString("", fontNormal, Brushes.Black, 100, height, new StringFormat());
            height += 40;

            //Print Receipt No
            e.Graphics.DrawString("Receipt No. : " + receipt_no, fontBold, Brushes.Black, 10, height, new StringFormat());
            //Print Receipt Date
            e.Graphics.DrawString($"Date / Time : {receipt_date}", fontBold, Brushes.Black, 260, height, new StringFormat());
            height += 40;

            //Print Line
            e.Graphics.DrawString(lineStyle1, fontNormal, Brushes.Black, 10, height, new StringFormat());
            height += 20;

            //Printe Table Headings
            e.Graphics.DrawString("ID", fontNormal, Brushes.Black, 10, height, new StringFormat());
            e.Graphics.DrawString("Name", fontNormal, Brushes.Black, 80, height, new StringFormat());
            e.Graphics.DrawString("Qty", fontNormal, Brushes.Black, 200, height, new StringFormat());
            e.Graphics.DrawString("Price", fontNormal, Brushes.Black, 300, height, new StringFormat());
            height += 20;

            //Print Line
            e.Graphics.DrawString(lineStyle1, fontNormal, Brushes.Black, 10, height, new StringFormat());
            height += 20;

            //Printe Table Rows
            /*for (int i = 0; i < dt.Rows.Count; i++)
            {
                SizeF qtyWidth = e.Graphics.MeasureString(dt.Rows[i][1].ToString(), normalFont);
                SizeF priceWidth = e.Graphics.MeasureString(dt.Rows[i][2].ToString(), normalFont);
                SizeF totalWidth = e.Graphics.MeasureString(dt.Rows[i][3].ToString(), normalFont);

                e.Graphics.DrawString(dt.Rows[i][0].ToString(), normalFont, Brushes.Black, 10, height, new StringFormat());
                e.Graphics.DrawString(dt.Rows[i][1].ToString(), normalFont, Brushes.Black, 140 + (50 - qtyWidth.Width), height, new StringFormat());
                e.Graphics.DrawString(dt.Rows[i][2].ToString(), normalFont, Brushes.Black, 220 + (50 - priceWidth.Width), height, new StringFormat());
                e.Graphics.DrawString(dt.Rows[i][3].ToString(), normalFont, Brushes.Black, 320 + (50 - totalWidth.Width), height, new StringFormat());
                height += 30;
            }*/

            //Print Line
            e.Graphics.DrawString(lineStyle1, fontNormal, Brushes.Black, 10, height, new StringFormat());
            height += 20;

            //Print Net Total
            e.Graphics.DrawString("Total", fontNormal, Brushes.Black, 220, height, new StringFormat());

            SizeF netWidth = e.Graphics.MeasureString(net_total, fontNormal);
            e.Graphics.DrawString(net_total, fontNormal, Brushes.Black, 320 + (50 - netWidth.Width), height, new StringFormat());
            height += 20;

            //Print Line
            e.Graphics.DrawString(lineStyle1, fontNormal, Brushes.Black, 10, height, new StringFormat());
            height += 40;

            e.Graphics.DrawString("!!! THANK YOU !!!", fontTitle, Brushes.Black, 130, height, new StringFormat());

            e.HasMorePages = false;
        }
    }
}
