namespace BetterLimited
{
    partial class CreateStaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Position = new System.Windows.Forms.ComboBox();
            this.comboBox_Depart = new System.Windows.Forms.ComboBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Create = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_StaffID = new System.Windows.Forms.Label();
            this.label_DateOfBirth = new System.Windows.Forms.Label();
            this.label_UserAccountID = new System.Windows.Forms.Label();
            this.textBox_StaffName = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Store = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Position :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Depart :";
            // 
            // comboBox_Position
            // 
            this.comboBox_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Position.FormattingEnabled = true;
            this.comboBox_Position.Items.AddRange(new object[] {
            "Admin",
            "CEO",
            "Accounting Clerk",
            "Accounting Manager",
            "Delivery Workman",
            "Goods Inwards Clerk",
            "Inventory Clerk",
            "Inventory Manager",
            "Purchase Officer",
            "Sales Manager",
            "Sales Representative",
            "Installation Workman"});
            this.comboBox_Position.Location = new System.Drawing.Point(306, 472);
            this.comboBox_Position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Position.Name = "comboBox_Position";
            this.comboBox_Position.Size = new System.Drawing.Size(287, 23);
            this.comboBox_Position.TabIndex = 48;
            // 
            // comboBox_Depart
            // 
            this.comboBox_Depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Depart.FormattingEnabled = true;
            this.comboBox_Depart.Items.AddRange(new object[] {
            "CEO",
            "Admin",
            "Accounting",
            "Inventory",
            "Purchase",
            "Sales",
            "Technical Support"});
            this.comboBox_Depart.Location = new System.Drawing.Point(306, 429);
            this.comboBox_Depart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Depart.Name = "comboBox_Depart";
            this.comboBox_Depart.Size = new System.Drawing.Size(287, 23);
            this.comboBox_Depart.TabIndex = 47;
            this.comboBox_Depart.SelectedIndexChanged += new System.EventHandler(this.comboBox_Depart_SelectedIndexChanged);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Close.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(126, 575);
            this.button_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(185, 38);
            this.button_Close.TabIndex = 46;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            // 
            // button_Create
            // 
            this.button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Create.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create.Location = new System.Drawing.Point(408, 575);
            this.button_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(185, 38);
            this.button_Create.TabIndex = 45;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // label_Email
            // 
            this.label_Email.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(122, 378);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(161, 25);
            this.label_Email.TabIndex = 44;
            this.label_Email.Text = "Email :";
            // 
            // label_Password
            // 
            this.label_Password.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(122, 326);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(161, 25);
            this.label_Password.TabIndex = 43;
            this.label_Password.Text = "Tel :";
            // 
            // label_StaffID
            // 
            this.label_StaffID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StaffID.Location = new System.Drawing.Point(122, 212);
            this.label_StaffID.Name = "label_StaffID";
            this.label_StaffID.Size = new System.Drawing.Size(161, 25);
            this.label_StaffID.TabIndex = 42;
            this.label_StaffID.Text = "Gender :";
            // 
            // label_DateOfBirth
            // 
            this.label_DateOfBirth.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateOfBirth.Location = new System.Drawing.Point(122, 268);
            this.label_DateOfBirth.Name = "label_DateOfBirth";
            this.label_DateOfBirth.Size = new System.Drawing.Size(161, 25);
            this.label_DateOfBirth.TabIndex = 41;
            this.label_DateOfBirth.Text = "Date of Birth  :";
            // 
            // label_UserAccountID
            // 
            this.label_UserAccountID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserAccountID.Location = new System.Drawing.Point(122, 161);
            this.label_UserAccountID.Name = "label_UserAccountID";
            this.label_UserAccountID.Size = new System.Drawing.Size(161, 25);
            this.label_UserAccountID.TabIndex = 40;
            this.label_UserAccountID.Text = "StaffName :";
            // 
            // textBox_StaffName
            // 
            this.textBox_StaffName.Location = new System.Drawing.Point(306, 161);
            this.textBox_StaffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_StaffName.Name = "textBox_StaffName";
            this.textBox_StaffName.Size = new System.Drawing.Size(287, 25);
            this.textBox_StaffName.TabIndex = 39;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(306, 381);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(287, 25);
            this.textBox_Email.TabIndex = 38;
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Location = new System.Drawing.Point(306, 326);
            this.textBox_Tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(287, 25);
            this.textBox_Tel.TabIndex = 37;
            this.textBox_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Password_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 106);
            this.panel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Create Staff";
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBox_Gender.Location = new System.Drawing.Point(306, 215);
            this.comboBox_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(287, 23);
            this.comboBox_Gender.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Salary :";
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(306, 515);
            this.textBox_Salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(287, 25);
            this.textBox_Salary.TabIndex = 52;
            this.textBox_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Salary_KeyPress);
            // 
            // dateTimePicker_DateOfBirth
            // 
            this.dateTimePicker_DateOfBirth.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DateOfBirth.Location = new System.Drawing.Point(306, 268);
            this.dateTimePicker_DateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Size = new System.Drawing.Size(287, 25);
            this.dateTimePicker_DateOfBirth.TabIndex = 62;
            this.dateTimePicker_DateOfBirth.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            // 
            // comboBox_Store
            // 
            this.comboBox_Store.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Store.FormattingEnabled = true;
            this.comboBox_Store.Items.AddRange(new object[] {
            "Tsuen Wan",
            "Kowloon Bay"});
            this.comboBox_Store.Location = new System.Drawing.Point(613, 429);
            this.comboBox_Store.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Store.Name = "comboBox_Store";
            this.comboBox_Store.Size = new System.Drawing.Size(110, 23);
            this.comboBox_Store.TabIndex = 63;
            // 
            // CreateStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 745);
            this.Controls.Add(this.comboBox_Store);
            this.Controls.Add(this.dateTimePicker_DateOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Position);
            this.Controls.Add(this.comboBox_Depart);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_StaffID);
            this.Controls.Add(this.label_DateOfBirth);
            this.Controls.Add(this.label_UserAccountID);
            this.Controls.Add(this.textBox_StaffName);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.panel1);
            this.Name = "CreateStaffForm";
            this.Text = "CreateStaffForm";
            this.Load += new System.EventHandler(this.CreateStaffForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Position;
        private System.Windows.Forms.ComboBox comboBox_Depart;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_StaffID;
        private System.Windows.Forms.Label label_DateOfBirth;
        private System.Windows.Forms.Label label_UserAccountID;
        private System.Windows.Forms.TextBox textBox_StaffName;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirth;
        private System.Windows.Forms.ComboBox comboBox_Store;
    }
}