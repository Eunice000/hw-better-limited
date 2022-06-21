namespace BetterLimited
{
    partial class SalesOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_SalesOrderTable = new System.Windows.Forms.DataGridView();
            this.SalesOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DelectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesOrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SalesOrderTable
            // 
            this.dataGridView_SalesOrderTable.AllowUserToAddRows = false;
            this.dataGridView_SalesOrderTable.AllowUserToDeleteRows = false;
            this.dataGridView_SalesOrderTable.AllowUserToResizeRows = false;
            this.dataGridView_SalesOrderTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SalesOrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SalesOrderTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SalesOrderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_SalesOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SalesOrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesOrderID,
            this.StoreID,
            this.StaffID,
            this.PaymentStatus,
            this.PaidAmt,
            this.Date,
            this.Time,
            this.ExpDate,
            this.CustomerID,
            this.EditButton,
            this.DelectButton});
            this.dataGridView_SalesOrderTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_SalesOrderTable.Location = new System.Drawing.Point(73, 196);
            this.dataGridView_SalesOrderTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_SalesOrderTable.Name = "dataGridView_SalesOrderTable";
            this.dataGridView_SalesOrderTable.ReadOnly = true;
            this.dataGridView_SalesOrderTable.RowHeadersVisible = false;
            this.dataGridView_SalesOrderTable.RowHeadersWidth = 51;
            this.dataGridView_SalesOrderTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_SalesOrderTable.RowTemplate.Height = 27;
            this.dataGridView_SalesOrderTable.ShowEditingIcon = false;
            this.dataGridView_SalesOrderTable.Size = new System.Drawing.Size(694, 376);
            this.dataGridView_SalesOrderTable.TabIndex = 0;
            this.dataGridView_SalesOrderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SalesOrderTable_CellClick);
            this.dataGridView_SalesOrderTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SalesOrderTable_CellContentClick);
            // 
            // SalesOrderID
            // 
            this.SalesOrderID.DataPropertyName = "SalesOrderID";
            this.SalesOrderID.HeaderText = "SalesOrderID";
            this.SalesOrderID.MinimumWidth = 6;
            this.SalesOrderID.Name = "SalesOrderID";
            this.SalesOrderID.ReadOnly = true;
            // 
            // StoreID
            // 
            this.StoreID.DataPropertyName = "StoreID";
            this.StoreID.HeaderText = "StoreID";
            this.StoreID.MinimumWidth = 6;
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            this.PaymentStatus.HeaderText = "PaymentStatus";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            // 
            // PaidAmt
            // 
            this.PaidAmt.DataPropertyName = "PaidAmt";
            this.PaidAmt.HeaderText = "PaidAmt";
            this.PaidAmt.MinimumWidth = 6;
            this.PaidAmt.Name = "PaidAmt";
            this.PaidAmt.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ExpDate
            // 
            this.ExpDate.DataPropertyName = "ExpDate";
            this.ExpDate.HeaderText = "ExpDate";
            this.ExpDate.MinimumWidth = 6;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // EditButton
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.MinimumWidth = 6;
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Edit";
            this.EditButton.UseColumnTextForButtonValue = true;
            // 
            // DelectButton
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DelectButton.DefaultCellStyle = dataGridViewCellStyle4;
            this.DelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelectButton.HeaderText = "";
            this.DelectButton.MinimumWidth = 6;
            this.DelectButton.Name = "DelectButton";
            this.DelectButton.ReadOnly = true;
            this.DelectButton.Text = "Delect";
            this.DelectButton.UseColumnTextForButtonValue = true;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Location = new System.Drawing.Point(536, 171);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(148, 22);
            this.textBox_Search.TabIndex = 1;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.Location = new System.Drawing.Point(687, 171);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(80, 20);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 86);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sales Order ";
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.Location = new System.Drawing.Point(380, 171);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(80, 20);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "SalesOrderID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SalesOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_SalesOrderTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalesOrder";
            this.Text = "SalesOrder";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesOrderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SalesOrderTable;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DelectButton;
        private System.Windows.Forms.Label label3;
    }
}