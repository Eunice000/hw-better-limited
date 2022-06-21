namespace BetterLimited
{
    partial class CreateRestockRequestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_StaffID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nowdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NowTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_itemTable = new System.Windows.Forms.DataGridView();
            this.SalesOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dataGridView_RestockList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeQty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQTY = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_itemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RestockList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1179, 81);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(67, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "RestockRequestForm";
            // 
            // textbox_StaffID
            // 
            this.textbox_StaffID.Enabled = false;
            this.textbox_StaffID.Location = new System.Drawing.Point(117, 108);
            this.textbox_StaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_StaffID.Name = "textbox_StaffID";
            this.textbox_StaffID.Size = new System.Drawing.Size(201, 25);
            this.textbox_StaffID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Staff ID:";
            // 
            // textBox_Nowdate
            // 
            this.textBox_Nowdate.Enabled = false;
            this.textBox_Nowdate.Location = new System.Drawing.Point(429, 108);
            this.textBox_Nowdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Nowdate.Name = "textBox_Nowdate";
            this.textBox_Nowdate.ReadOnly = true;
            this.textBox_Nowdate.Size = new System.Drawing.Size(132, 25);
            this.textBox_Nowdate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date:";
            // 
            // textBox_NowTime
            // 
            this.textBox_NowTime.Enabled = false;
            this.textBox_NowTime.Location = new System.Drawing.Point(680, 108);
            this.textBox_NowTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_NowTime.Name = "textBox_NowTime";
            this.textBox_NowTime.ReadOnly = true;
            this.textBox_NowTime.Size = new System.Drawing.Size(132, 25);
            this.textBox_NowTime.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 13;
            // 
            // dataGridView_itemTable
            // 
            this.dataGridView_itemTable.AllowUserToAddRows = false;
            this.dataGridView_itemTable.AllowUserToDeleteRows = false;
            this.dataGridView_itemTable.AllowUserToResizeRows = false;
            this.dataGridView_itemTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_itemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_itemTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_itemTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_itemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_itemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesOrderID,
            this.StoreID,
            this.Column1,
            this.PaymentStatus,
            this.PaidAmt,
            this.Column3,
            this.Time,
            this.ExpDate,
            this.Column5,
            this.EditButton});
            this.dataGridView_itemTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_itemTable.Location = new System.Drawing.Point(12, 195);
            this.dataGridView_itemTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_itemTable.Name = "dataGridView_itemTable";
            this.dataGridView_itemTable.ReadOnly = true;
            this.dataGridView_itemTable.RowHeadersVisible = false;
            this.dataGridView_itemTable.RowHeadersWidth = 51;
            this.dataGridView_itemTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_itemTable.RowTemplate.Height = 27;
            this.dataGridView_itemTable.ShowEditingIcon = false;
            this.dataGridView_itemTable.Size = new System.Drawing.Size(1068, 208);
            this.dataGridView_itemTable.TabIndex = 14;
            this.dataGridView_itemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_itemTable_CellClick);
            // 
            // SalesOrderID
            // 
            this.SalesOrderID.DataPropertyName = "ItemID";
            this.SalesOrderID.HeaderText = "ItemID";
            this.SalesOrderID.MinimumWidth = 6;
            this.SalesOrderID.Name = "SalesOrderID";
            this.SalesOrderID.ReadOnly = true;
            // 
            // StoreID
            // 
            this.StoreID.DataPropertyName = "ItemCat";
            this.StoreID.HeaderText = "ItemCat";
            this.StoreID.MinimumWidth = 6;
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "itemName";
            this.Column1.HeaderText = "itemName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "ItemDesc";
            this.PaymentStatus.HeaderText = "ItemDesc";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            // 
            // PaidAmt
            // 
            this.PaidAmt.DataPropertyName = "SalePrice";
            this.PaidAmt.HeaderText = "SalePrice";
            this.PaidAmt.MinimumWidth = 6;
            this.PaidAmt.Name = "PaidAmt";
            this.PaidAmt.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SupplierID";
            this.Column3.HeaderText = "SupplierID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "SupplierPrice";
            this.Time.HeaderText = "SupplierPirce";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ExpDate
            // 
            this.ExpDate.DataPropertyName = "WarrantyMonth";
            this.ExpDate.HeaderText = "WarrantyMonth";
            this.ExpDate.MinimumWidth = 6;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AllowDelivery";
            this.Column5.HeaderText = "AllowDelivery";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // EditButton
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.MinimumWidth = 6;
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Select";
            this.EditButton.UseColumnTextForButtonValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "ItemID :";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(588, 165);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(107, 25);
            this.button_clear.TabIndex = 17;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(975, 165);
            this.button_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(107, 25);
            this.button_Search.TabIndex = 16;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(772, 165);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(196, 25);
            this.textBox_Search.TabIndex = 15;
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(841, 728);
            this.button_submit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(239, 35);
            this.button_submit.TabIndex = 22;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridView_RestockList
            // 
            this.dataGridView_RestockList.AllowUserToAddRows = false;
            this.dataGridView_RestockList.AllowUserToDeleteRows = false;
            this.dataGridView_RestockList.AllowUserToResizeColumns = false;
            this.dataGridView_RestockList.AllowUserToResizeRows = false;
            this.dataGridView_RestockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_RestockList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_RestockList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_RestockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RestockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.removeQty,
            this.Column2,
            this.AddQTY,
            this.dataGridViewButtonColumn1});
            this.dataGridView_RestockList.GridColor = System.Drawing.Color.White;
            this.dataGridView_RestockList.Location = new System.Drawing.Point(12, 498);
            this.dataGridView_RestockList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_RestockList.MultiSelect = false;
            this.dataGridView_RestockList.Name = "dataGridView_RestockList";
            this.dataGridView_RestockList.RowHeadersVisible = false;
            this.dataGridView_RestockList.RowHeadersWidth = 51;
            this.dataGridView_RestockList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_RestockList.RowTemplate.Height = 27;
            this.dataGridView_RestockList.ShowEditingIcon = false;
            this.dataGridView_RestockList.Size = new System.Drawing.Size(1069, 204);
            this.dataGridView_RestockList.TabIndex = 25;
            this.dataGridView_RestockList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RestockList_CellClick);
            this.dataGridView_RestockList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_RestockList_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "itemName";
            this.dataGridViewTextBoxColumn3.HeaderText = "itemName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn6.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // removeQty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.removeQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.removeQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeQty.HeaderText = "";
            this.removeQty.MinimumWidth = 2;
            this.removeQty.Name = "removeQty";
            this.removeQty.Text = "-";
            this.removeQty.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qty";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddQTY
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.AddQTY.DefaultCellStyle = dataGridViewCellStyle3;
            this.AddQTY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddQTY.HeaderText = "";
            this.AddQTY.MinimumWidth = 2;
            this.AddQTY.Name = "AddQTY";
            this.AddQTY.Text = "+";
            this.AddQTY.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Delect";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(5, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Restock Request List";
            // 
            // cbxStore
            // 
            this.cbxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Items.AddRange(new object[] {
            "Tsuen Wan",
            "Kowloon Bay"});
            this.cbxStore.Location = new System.Drawing.Point(648, 738);
            this.cbxStore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(160, 23);
            this.cbxStore.TabIndex = 26;
            this.cbxStore.SelectedIndexChanged += new System.EventHandler(this.cbxStore_SelectedIndexChanged);
            // 
            // CreateRestockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 826);
            this.Controls.Add(this.cbxStore);
            this.Controls.Add(this.dataGridView_RestockList);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_itemTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_NowTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Nowdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_StaffID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateRestockRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestockRequestForm";
            this.Load += new System.EventHandler(this.RestockRequestForm_v2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_itemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RestockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_StaffID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nowdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NowTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_itemTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_submit;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView_RestockList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn removeQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn AddQTY;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.ComboBox cbxStore;
    }
}