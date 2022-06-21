namespace BetterLimited
{
    partial class ReturnNoteForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_StaffID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_ReuturnNoteTable = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Create = new System.Windows.Forms.Button();
            this.dataGridView_ReturnItemTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReuturnNoteTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnItemTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 85);
            this.panel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "View Return Good Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Staff ID:";
            // 
            // textbox_StaffID
            // 
            this.textbox_StaffID.Enabled = false;
            this.textbox_StaffID.Location = new System.Drawing.Point(88, 97);
            this.textbox_StaffID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbox_StaffID.Name = "textbox_StaffID";
            this.textbox_StaffID.Size = new System.Drawing.Size(152, 22);
            this.textbox_StaffID.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 45;
            this.label7.Text = "ReturnNoteID :";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(419, 154);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(80, 20);
            this.button_clear.TabIndex = 44;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(746, 154);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(80, 20);
            this.button_Search.TabIndex = 43;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(594, 154);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(148, 22);
            this.textBox_Search.TabIndex = 42;
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // dataGridView_ReuturnNoteTable
            // 
            this.dataGridView_ReuturnNoteTable.AllowUserToAddRows = false;
            this.dataGridView_ReuturnNoteTable.AllowUserToDeleteRows = false;
            this.dataGridView_ReuturnNoteTable.AllowUserToResizeRows = false;
            this.dataGridView_ReuturnNoteTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ReuturnNoteTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ReuturnNoteTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ReuturnNoteTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReuturnNoteTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column1});
            this.dataGridView_ReuturnNoteTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_ReuturnNoteTable.Location = new System.Drawing.Point(25, 178);
            this.dataGridView_ReuturnNoteTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_ReuturnNoteTable.Name = "dataGridView_ReuturnNoteTable";
            this.dataGridView_ReuturnNoteTable.ReadOnly = true;
            this.dataGridView_ReuturnNoteTable.RowHeadersVisible = false;
            this.dataGridView_ReuturnNoteTable.RowHeadersWidth = 51;
            this.dataGridView_ReuturnNoteTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_ReuturnNoteTable.RowTemplate.Height = 27;
            this.dataGridView_ReuturnNoteTable.ShowEditingIcon = false;
            this.dataGridView_ReuturnNoteTable.Size = new System.Drawing.Size(801, 177);
            this.dataGridView_ReuturnNoteTable.TabIndex = 46;
            this.dataGridView_ReuturnNoteTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ReuturnNoteTable_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ReturnNoteID";
            this.Column2.HeaderText = "ReturnNoteID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SalesOrderID";
            this.Column3.HeaderText = "SalesOrderID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "StoreID";
            this.Column5.HeaderText = "StoreID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "StaffID";
            this.Column6.HeaderText = "StaffID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Date";
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Time";
            this.Column8.HeaderText = "Time";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Select";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // button_Create
            // 
            this.button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Create.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create.Location = new System.Drawing.Point(628, 589);
            this.button_Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(198, 30);
            this.button_Create.TabIndex = 47;
            this.button_Create.Text = "Create Return Note";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // dataGridView_ReturnItemTable
            // 
            this.dataGridView_ReturnItemTable.AllowUserToAddRows = false;
            this.dataGridView_ReturnItemTable.AllowUserToDeleteRows = false;
            this.dataGridView_ReturnItemTable.AllowUserToResizeRows = false;
            this.dataGridView_ReturnItemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ReturnItemTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ReturnItemTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ReturnItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReturnItemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView_ReturnItemTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_ReturnItemTable.Location = new System.Drawing.Point(25, 391);
            this.dataGridView_ReturnItemTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_ReturnItemTable.Name = "dataGridView_ReturnItemTable";
            this.dataGridView_ReturnItemTable.ReadOnly = true;
            this.dataGridView_ReturnItemTable.RowHeadersVisible = false;
            this.dataGridView_ReturnItemTable.RowHeadersWidth = 51;
            this.dataGridView_ReturnItemTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_ReturnItemTable.RowTemplate.Height = 27;
            this.dataGridView_ReturnItemTable.ShowEditingIcon = false;
            this.dataGridView_ReturnItemTable.Size = new System.Drawing.Size(801, 177);
            this.dataGridView_ReturnItemTable.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ReturnNoteID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ReturnNoteID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn7.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // ReturnNoteForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.dataGridView_ReturnItemTable);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.dataGridView_ReuturnNoteTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_StaffID);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReturnNoteForm";
            this.Text = "returnGoodForm";
            this.Load += new System.EventHandler(this.ReturnNoteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReuturnNoteTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnItemTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_StaffID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView_ReuturnNoteTable;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.DataGridView dataGridView_ReturnItemTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}