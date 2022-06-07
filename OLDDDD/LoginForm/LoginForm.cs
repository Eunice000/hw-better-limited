using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnLogin;

            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;

        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }


        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                if (chbShowPassword.Checked == true)
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Black;
                }
                else {
                    txtPassword.Text = "";
                    txtPassword.PasswordChar = '*';
                }
            }
            else if (txtPassword.Text == "") {
                if (chbShowPassword.Checked == false)
                {
                    txtPassword.Text = "Password";
                }
            }
           
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password") {
                txtPassword.PasswordChar = chbShowPassword.Checked ? '\0' : '*';
            } 
        }
    }

}
