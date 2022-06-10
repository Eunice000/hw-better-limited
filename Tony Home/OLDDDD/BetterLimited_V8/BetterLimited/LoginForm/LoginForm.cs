using MySql.Data.MySqlClient;
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
        Boolean show;
        Bitmap picShow = Properties.Resources.show;
        Bitmap picHide = Properties.Resources.hide;

        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string sqlStr;
        string staffid;

        public string getStaffID
        {
            get
            {
                sqlStr = "SELECT staffID FROM useraccount WHERE UserName = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
                return staffid = selectQueryValue(sqlStr, "StaffID");
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

        //Insert, Update, and Delete data query
        public bool iudQuery(string sql) {
            try
            {
                openConnection();
                command = new MySqlCommand(sql, conn);
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally {
                closeConnection();
            }
        }

        //Select data query
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
            else {
                closeConnection();
                return false;
            }
        }

        public string selectQueryValue(string sql, string column)
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
                return reader.GetString(column);
            }
            else
            {
                closeConnection();
                return null;
            }
        }

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
            if (txtPassword.Text == "Password" && !show)
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }
            else if (txtPassword.Text == "Password" && show)
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Black;
            }
            else if (txtPassword.Text == null && show)
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Black;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Gray;
            } 
        }
        
        private void lblSignup_Click(object sender, EventArgs e)
        {
            SignupForm singupform = new SignupForm();
            this.Hide();
            singupform.Show();
            
        }
        private void picShowPassword_Click(object sender, EventArgs e)
        {
            
            if (picShowPassword.Image == picHide)
            {
                show = false;
                picShowPassword.Image = picShow;
            }
            else
            {
                show = true;
                picShowPassword.Image = picHide;
            }

            if (txtPassword.Text != "Password" || txtPassword.Text == "")
            {
                txtPassword.PasswordChar = show ? '\0' : '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlStr = "SELECT * FROM useraccount WHERE UserName = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
            if (selectQuery(sqlStr))
            {
                sqlStr = "UPDATE useraccount SET LastLoginDateTime = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE UserName = '" + txtUsername.Text + "'; ";
                iudQuery(sqlStr);

                MenuForm menuform = new MenuForm();

                menuform.setStaffID = getStaffID;

                this.Hide();
                menuform.Show();
            }
            else
            {
                MessageBox.Show("Incorrect user name or password. "
                    + "Please try again.");
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotpasswordform = new ForgotPasswordForm();
            this.Hide();
            forgotpasswordform.Show();
        }
    }
}