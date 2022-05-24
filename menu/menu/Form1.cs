using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            module1.Visible = false;
        }

        private void dpmBtn1_Click(object sender, EventArgs e)
        {
            if(module1.Visible == false){
                module1.Visible =true;
            }
            else
            {
                module1.Visible = false;
            }
        }
    }
}
