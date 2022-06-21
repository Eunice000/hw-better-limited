
namespace BetterLimited
{
    partial class ItemList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RRRLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SalesOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmt = new System.Windows.Forms.DataGridViewImageColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RRRLbl
            // 
            this.RRRLbl.BackColor = System.Drawing.SystemColors.Info;
            this.RRRLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRRLbl.Location = new System.Drawing.Point(-2, -3);
            this.RRRLbl.Name = "RRRLbl";
            this.RRRLbl.Size = new System.Drawing.Size(889, 42);
            this.RRRLbl.TabIndex = 1;
            this.RRRLbl.Text = "Item List";
            this.RRRLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search Item ID:";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(465, 64);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(158, 20);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click_1);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(301, 63);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(158, 20);
            this.button_Search.TabIndex = 9;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(164, 63);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(131, 22);
            this.textBox_Search.TabIndex = 8;
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesOrderID,
            this.StoreID,
            this.StaffID,
            this.PaymentStatus,
            this.PaidAmt,
            this.Date,
            this.Time,
            this.ExpDate,
            this.CustomerID,
            this.Column1,
            this.EditButton,
            this.DeleteButton});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(11, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(868, 548);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // SalesOrderID
            // 
            this.SalesOrderID.DataPropertyName = "ItemID";
            this.SalesOrderID.FillWeight = 70F;
            this.SalesOrderID.HeaderText = "ItemID";
            this.SalesOrderID.MinimumWidth = 6;
            this.SalesOrderID.Name = "SalesOrderID";
            this.SalesOrderID.ReadOnly = true;
            // 
            // StoreID
            // 
            this.StoreID.DataPropertyName = "ItemCat";
            this.StoreID.FillWeight = 62.55183F;
            this.StoreID.HeaderText = "ItemCat";
            this.StoreID.MinimumWidth = 6;
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "ItemName";
            this.StaffID.FillWeight = 78.1898F;
            this.StaffID.HeaderText = "ItemName";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "ItemDesc";
            this.PaymentStatus.FillWeight = 78.1898F;
            this.PaymentStatus.HeaderText = "ItemDesc";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            // 
            // PaidAmt
            // 
            this.PaidAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidAmt.DataPropertyName = "ItemImg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PaidAmt.DefaultCellStyle = dataGridViewCellStyle4;
            this.PaidAmt.FillWeight = 100.3796F;
            this.PaidAmt.HeaderText = "ItemImg";
            this.PaidAmt.MinimumWidth = 6;
            this.PaidAmt.Name = "PaidAmt";
            this.PaidAmt.ReadOnly = true;
            this.PaidAmt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PaidAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "SalePrice";
            this.Date.FillWeight = 70F;
            this.Date.HeaderText = "SalePrice";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "SupplierID";
            this.Time.FillWeight = 66F;
            this.Time.HeaderText = "SupplierID";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ExpDate
            // 
            this.ExpDate.DataPropertyName = "SupplierPrice";
            this.ExpDate.FillWeight = 78.1898F;
            this.ExpDate.HeaderText = "SupplierPrice";
            this.ExpDate.MinimumWidth = 6;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "WarrantyMonth";
            this.CustomerID.FillWeight = 78.1898F;
            this.CustomerID.HeaderText = "WarrantyMonth";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "AllowDelivery";
            this.Column1.FillWeight = 78.1898F;
            this.Column1.HeaderText = "AllowDelivery";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // EditButton
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle5;
            this.EditButton.FillWeight = 78.1898F;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.MinimumWidth = 6;
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Edit";
            this.EditButton.UseColumnTextForButtonValue = true;
            // 
            // DeleteButton
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle6;
            this.DeleteButton.FillWeight = 78.1898F;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.MinimumWidth = 6;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(710, 62);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(158, 20);
            this.button_New.TabIndex = 13;
            this.button_New.Text = "New";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // ItemList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.RRRLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemList";
            this.Text = "ItemList";
            this.Load += new System.EventHandler(this.ItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RRRLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewImageColumn PaidAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}