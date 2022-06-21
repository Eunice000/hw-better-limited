namespace BetterLimited
{
    partial class CreateReturnNoteForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_NowTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nowdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_OrderItemTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_SelectedOrderID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_ReturnNote = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeQty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQTY = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Create = new System.Windows.Forms.Button();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TotalReturnAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_StaffID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesOrderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderItemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnNote)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_NowTime
            // 
            this.textBox_NowTime.Enabled = false;
            this.textBox_NowTime.Location = new System.Drawing.Point(1034, 122);
            this.textBox_NowTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_NowTime.Name = "textBox_NowTime";
            this.textBox_NowTime.ReadOnly = true;
            this.textBox_NowTime.Size = new System.Drawing.Size(132, 25);
            this.textBox_NowTime.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(880, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Current Time :";
            // 
            // textBox_Nowdate
            // 
            this.textBox_Nowdate.Enabled = false;
            this.textBox_Nowdate.Location = new System.Drawing.Point(728, 122);
            this.textBox_Nowdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Nowdate.Name = "textBox_Nowdate";
            this.textBox_Nowdate.ReadOnly = true;
            this.textBox_Nowdate.Size = new System.Drawing.Size(132, 25);
            this.textBox_Nowdate.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Current Date:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 106);
            this.panel1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Create Return Good Note";
            // 
            // dataGridView_SalesOrderTable
            // 
            this.dataGridView_SalesOrderTable.AllowUserToAddRows = false;
            this.dataGridView_SalesOrderTable.AllowUserToDeleteRows = false;
            this.dataGridView_SalesOrderTable.AllowUserToResizeRows = false;
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
            this.EditButton});
            this.dataGridView_SalesOrderTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_SalesOrderTable.Location = new System.Drawing.Point(25, 218);
            this.dataGridView_SalesOrderTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_SalesOrderTable.Name = "dataGridView_SalesOrderTable";
            this.dataGridView_SalesOrderTable.ReadOnly = true;
            this.dataGridView_SalesOrderTable.RowHeadersVisible = false;
            this.dataGridView_SalesOrderTable.RowHeadersWidth = 51;
            this.dataGridView_SalesOrderTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_SalesOrderTable.RowTemplate.Height = 27;
            this.dataGridView_SalesOrderTable.ShowEditingIcon = false;
            this.dataGridView_SalesOrderTable.Size = new System.Drawing.Size(1141, 137);
            this.dataGridView_SalesOrderTable.TabIndex = 47;
            this.dataGridView_SalesOrderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SalesOrderTable_CellClick);
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
            this.label7.Location = new System.Drawing.Point(135, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "SalesOrderID :";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(22, 189);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(107, 25);
            this.button_clear.TabIndex = 50;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(435, 189);
            this.button_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(107, 25);
            this.button_Search.TabIndex = 49;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(233, 189);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(196, 25);
            this.textBox_Search.TabIndex = 48;
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // dataGridView_OrderItemTable
            // 
            this.dataGridView_OrderItemTable.AllowUserToAddRows = false;
            this.dataGridView_OrderItemTable.AllowUserToDeleteRows = false;
            this.dataGridView_OrderItemTable.AllowUserToResizeRows = false;
            this.dataGridView_OrderItemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_OrderItemTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_OrderItemTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_OrderItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderItemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn2});
            this.dataGridView_OrderItemTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_OrderItemTable.Location = new System.Drawing.Point(27, 393);
            this.dataGridView_OrderItemTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_OrderItemTable.Name = "dataGridView_OrderItemTable";
            this.dataGridView_OrderItemTable.ReadOnly = true;
            this.dataGridView_OrderItemTable.RowHeadersVisible = false;
            this.dataGridView_OrderItemTable.RowHeadersWidth = 51;
            this.dataGridView_OrderItemTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_OrderItemTable.RowTemplate.Height = 27;
            this.dataGridView_OrderItemTable.ShowEditingIcon = false;
            this.dataGridView_OrderItemTable.Size = new System.Drawing.Size(506, 304);
            this.dataGridView_OrderItemTable.TabIndex = 52;
            this.dataGridView_OrderItemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OrderItemTable_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn1.FillWeight = 65.65144F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "SalePrice";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn3.FillWeight = 40F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn2.FillWeight = 65.65144F;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Add to return Note";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // label_SelectedOrderID
            // 
            this.label_SelectedOrderID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_SelectedOrderID.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.label_SelectedOrderID.Location = new System.Drawing.Point(212, 359);
            this.label_SelectedOrderID.Name = "label_SelectedOrderID";
            this.label_SelectedOrderID.Size = new System.Drawing.Size(160, 32);
            this.label_SelectedOrderID.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.label1.Location = new System.Drawing.Point(787, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 54;
            this.label1.Text = "Return Note";
            // 
            // dataGridView_ReturnNote
            // 
            this.dataGridView_ReturnNote.AllowUserToAddRows = false;
            this.dataGridView_ReturnNote.AllowUserToDeleteRows = false;
            this.dataGridView_ReturnNote.AllowUserToResizeColumns = false;
            this.dataGridView_ReturnNote.AllowUserToResizeRows = false;
            this.dataGridView_ReturnNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ReturnNote.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ReturnNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ReturnNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReturnNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.removeQty,
            this.Column2,
            this.AddQTY,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn1});
            this.dataGridView_ReturnNote.GridColor = System.Drawing.Color.White;
            this.dataGridView_ReturnNote.Location = new System.Drawing.Point(568, 393);
            this.dataGridView_ReturnNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_ReturnNote.MultiSelect = false;
            this.dataGridView_ReturnNote.Name = "dataGridView_ReturnNote";
            this.dataGridView_ReturnNote.RowHeadersVisible = false;
            this.dataGridView_ReturnNote.RowHeadersWidth = 51;
            this.dataGridView_ReturnNote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_ReturnNote.RowTemplate.Height = 27;
            this.dataGridView_ReturnNote.ShowEditingIcon = false;
            this.dataGridView_ReturnNote.Size = new System.Drawing.Size(598, 304);
            this.dataGridView_ReturnNote.TabIndex = 55;
            this.dataGridView_ReturnNote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ReturnNote_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn5.FillWeight = 75.21151F;
            this.dataGridViewTextBoxColumn5.HeaderText = "SalePrice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // removeQty
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.removeQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.removeQty.FillWeight = 30F;
            this.removeQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeQty.HeaderText = "";
            this.removeQty.MinimumWidth = 2;
            this.removeQty.Name = "removeQty";
            this.removeQty.Text = "+";
            this.removeQty.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 60F;
            this.Column2.HeaderText = "Qty";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddQTY
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.AddQTY.DefaultCellStyle = dataGridViewCellStyle4;
            this.AddQTY.FillWeight = 30F;
            this.AddQTY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddQTY.HeaderText = "";
            this.AddQTY.MinimumWidth = 2;
            this.AddQTY.Name = "AddQTY";
            this.AddQTY.Text = "-";
            this.AddQTY.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total Price";
            this.dataGridViewTextBoxColumn6.FillWeight = 75.21151F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewButtonColumn1.FillWeight = 60F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Delect";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Back.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(27, 759);
            this.button_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(185, 38);
            this.button_Back.TabIndex = 57;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = false;
            // 
            // button_Create
            // 
            this.button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Create.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create.Location = new System.Drawing.Point(902, 759);
            this.button_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(264, 38);
            this.button_Create.TabIndex = 56;
            this.button_Create.Text = "Create Return Note";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // cbxStore
            // 
            this.cbxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Items.AddRange(new object[] {
            "Tsuen Wan",
            "Kowloon Bay"});
            this.cbxStore.Location = new System.Drawing.Point(424, 123);
            this.cbxStore.Margin = new System.Windows.Forms.Padding(4);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(143, 23);
            this.cbxStore.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(326, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "Store :";
            // 
            // label_TotalReturnAmount
            // 
            this.label_TotalReturnAmount.AutoSize = true;
            this.label_TotalReturnAmount.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.label_TotalReturnAmount.Location = new System.Drawing.Point(562, 709);
            this.label_TotalReturnAmount.Name = "label_TotalReturnAmount";
            this.label_TotalReturnAmount.Size = new System.Drawing.Size(254, 32);
            this.label_TotalReturnAmount.TabIndex = 60;
            this.label_TotalReturnAmount.Text = "Return Amount : $ 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Staff ID:";
            // 
            // textbox_StaffID
            // 
            this.textbox_StaffID.Enabled = false;
            this.textbox_StaffID.Location = new System.Drawing.Point(124, 122);
            this.textbox_StaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_StaffID.Name = "textbox_StaffID";
            this.textbox_StaffID.Size = new System.Drawing.Size(161, 25);
            this.textbox_StaffID.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.label8.Location = new System.Drawing.Point(21, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 32);
            this.label8.TabIndex = 63;
            this.label8.Text = "SalesOrderID :";
            // 
            // CreateReturnNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 826);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_StaffID);
            this.Controls.Add(this.label_TotalReturnAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxStore);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.dataGridView_ReturnNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SelectedOrderID);
            this.Controls.Add(this.dataGridView_OrderItemTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_SalesOrderTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_NowTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Nowdate);
            this.Controls.Add(this.label4);
            this.Name = "CreateReturnNoteForm";
            this.Text = "CreateReturnNoteForm";
            this.Load += new System.EventHandler(this.CreateReturnNoteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesOrderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderItemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NowTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Nowdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_SalesOrderTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
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
        private System.Windows.Forms.DataGridView dataGridView_OrderItemTable;
        private System.Windows.Forms.Label label_SelectedOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_ReturnNote;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TotalReturnAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn removeQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn AddQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Label label8;
    }
}