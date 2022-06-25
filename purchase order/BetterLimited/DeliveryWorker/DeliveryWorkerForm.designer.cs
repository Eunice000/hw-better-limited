
namespace BetterLimited
{
    partial class DeliveryWorkerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_WorkerTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button_clear_Worker = new System.Windows.Forms.Button();
            this.button_Search_Worker = new System.Windows.Forms.Button();
            this.textBox_Search_Worker = new System.Windows.Forms.TextBox();
            this.dataGridView_arrengeTable = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_WorkID = new System.Windows.Forms.TextBox();
            this.dataGridView_DeliveryTable = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_clearAll_arrangeList = new System.Windows.Forms.Button();
            this.button_ViewEditManagement = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorkerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_arrengeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeliveryTable)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(900, 87);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Delivery Workman Management";
            // 
            // dataGridView_WorkerTable
            // 
            this.dataGridView_WorkerTable.AllowUserToAddRows = false;
            this.dataGridView_WorkerTable.AllowUserToDeleteRows = false;
            this.dataGridView_WorkerTable.AllowUserToResizeRows = false;
            this.dataGridView_WorkerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_WorkerTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_WorkerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_WorkerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_WorkerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.EditButton});
            this.dataGridView_WorkerTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_WorkerTable.Location = new System.Drawing.Point(20, 142);
            this.dataGridView_WorkerTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_WorkerTable.Name = "dataGridView_WorkerTable";
            this.dataGridView_WorkerTable.ReadOnly = true;
            this.dataGridView_WorkerTable.RowHeadersVisible = false;
            this.dataGridView_WorkerTable.RowHeadersWidth = 51;
            this.dataGridView_WorkerTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_WorkerTable.RowTemplate.Height = 27;
            this.dataGridView_WorkerTable.ShowEditingIcon = false;
            this.dataGridView_WorkerTable.Size = new System.Drawing.Size(855, 147);
            this.dataGridView_WorkerTable.TabIndex = 15;
            this.dataGridView_WorkerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_WorkerTable_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StaffID";
            this.Column1.HeaderText = "StaffID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StaffName";
            this.Column2.HeaderText = "StaffName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gender";
            this.Column3.HeaderText = "Gender";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tel";
            this.Column4.HeaderText = "Tel";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // EditButton
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.label7.Location = new System.Drawing.Point(589, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "StaffID :";
            // 
            // button_clear_Worker
            // 
            this.button_clear_Worker.Location = new System.Drawing.Point(505, 104);
            this.button_clear_Worker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_clear_Worker.Name = "button_clear_Worker";
            this.button_clear_Worker.Size = new System.Drawing.Size(80, 20);
            this.button_clear_Worker.TabIndex = 21;
            this.button_clear_Worker.Text = "Clear";
            this.button_clear_Worker.UseVisualStyleBackColor = true;
            this.button_clear_Worker.Click += new System.EventHandler(this.button_clear_Worker_Click);
            // 
            // button_Search_Worker
            // 
            this.button_Search_Worker.Location = new System.Drawing.Point(795, 104);
            this.button_Search_Worker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Search_Worker.Name = "button_Search_Worker";
            this.button_Search_Worker.Size = new System.Drawing.Size(80, 20);
            this.button_Search_Worker.TabIndex = 20;
            this.button_Search_Worker.Text = "Search";
            this.button_Search_Worker.UseVisualStyleBackColor = true;
            this.button_Search_Worker.Click += new System.EventHandler(this.button_Search_Worker_Click);
            // 
            // textBox_Search_Worker
            // 
            this.textBox_Search_Worker.Location = new System.Drawing.Point(643, 104);
            this.textBox_Search_Worker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Search_Worker.Name = "textBox_Search_Worker";
            this.textBox_Search_Worker.Size = new System.Drawing.Size(148, 22);
            this.textBox_Search_Worker.TabIndex = 19;
            this.textBox_Search_Worker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_Worker_KeyPress);
            // 
            // dataGridView_arrengeTable
            // 
            this.dataGridView_arrengeTable.AllowUserToAddRows = false;
            this.dataGridView_arrengeTable.AllowUserToDeleteRows = false;
            this.dataGridView_arrengeTable.AllowUserToResizeRows = false;
            this.dataGridView_arrengeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_arrengeTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_arrengeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_arrengeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_arrengeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.dataGridViewButtonColumn1});
            this.dataGridView_arrengeTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_arrengeTable.Location = new System.Drawing.Point(657, 341);
            this.dataGridView_arrengeTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_arrengeTable.Name = "dataGridView_arrengeTable";
            this.dataGridView_arrengeTable.ReadOnly = true;
            this.dataGridView_arrengeTable.RowHeadersVisible = false;
            this.dataGridView_arrengeTable.RowHeadersWidth = 51;
            this.dataGridView_arrengeTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_arrengeTable.RowTemplate.Height = 27;
            this.dataGridView_arrengeTable.ShowEditingIcon = false;
            this.dataGridView_arrengeTable.Size = new System.Drawing.Size(218, 229);
            this.dataGridView_arrengeTable.TabIndex = 23;
            this.dataGridView_arrengeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_arrengeTable_CellClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DeliveryID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Delect";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "WorkerID :";
            // 
            // textBox_WorkID
            // 
            this.textBox_WorkID.Location = new System.Drawing.Point(714, 315);
            this.textBox_WorkID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_WorkID.Name = "textBox_WorkID";
            this.textBox_WorkID.ReadOnly = true;
            this.textBox_WorkID.Size = new System.Drawing.Size(90, 22);
            this.textBox_WorkID.TabIndex = 25;
            // 
            // dataGridView_DeliveryTable
            // 
            this.dataGridView_DeliveryTable.AllowUserToAddRows = false;
            this.dataGridView_DeliveryTable.AllowUserToDeleteRows = false;
            this.dataGridView_DeliveryTable.AllowUserToResizeColumns = false;
            this.dataGridView_DeliveryTable.AllowUserToResizeRows = false;
            this.dataGridView_DeliveryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DeliveryTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DeliveryTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_DeliveryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DeliveryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column12,
            this.Column8,
            this.Column9,
            this.Column10,
            this.dataGridViewButtonColumn2});
            this.dataGridView_DeliveryTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_DeliveryTable.Location = new System.Drawing.Point(20, 315);
            this.dataGridView_DeliveryTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_DeliveryTable.MultiSelect = false;
            this.dataGridView_DeliveryTable.Name = "dataGridView_DeliveryTable";
            this.dataGridView_DeliveryTable.RowHeadersVisible = false;
            this.dataGridView_DeliveryTable.RowHeadersWidth = 51;
            this.dataGridView_DeliveryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_DeliveryTable.RowTemplate.Height = 27;
            this.dataGridView_DeliveryTable.ShowEditingIcon = false;
            this.dataGridView_DeliveryTable.Size = new System.Drawing.Size(614, 255);
            this.dataGridView_DeliveryTable.TabIndex = 26;
            this.dataGridView_DeliveryTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DeliveryTable_CellClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DeliveryID";
            this.Column7.HeaderText = "DeliveryID";
            this.Column7.Name = "Column7";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SalesOrderID";
            this.Column12.HeaderText = "SalesOrderID";
            this.Column12.Name = "Column12";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DeliveryDate";
            this.Column8.HeaderText = "DeliveryDate";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DeliveryTime";
            this.Column9.HeaderText = "DeliveryTime";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "DeliveryStatus";
            this.Column10.HeaderText = "DeliveryStatus";
            this.Column10.Name = "Column10";
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Select";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Update.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(736, 610);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(139, 30);
            this.button_Update.TabIndex = 43;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_clearAll_arrangeList
            // 
            this.button_clearAll_arrangeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_clearAll_arrangeList.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.button_clearAll_arrangeList.Location = new System.Drawing.Point(808, 315);
            this.button_clearAll_arrangeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_clearAll_arrangeList.Name = "button_clearAll_arrangeList";
            this.button_clearAll_arrangeList.Size = new System.Drawing.Size(67, 21);
            this.button_clearAll_arrangeList.TabIndex = 45;
            this.button_clearAll_arrangeList.Text = "clear all";
            this.button_clearAll_arrangeList.UseVisualStyleBackColor = false;
            this.button_clearAll_arrangeList.Click += new System.EventHandler(this.button_clearAll_arrangeList_Click);
            // 
            // button_ViewEditManagement
            // 
            this.button_ViewEditManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_ViewEditManagement.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewEditManagement.Location = new System.Drawing.Point(20, 610);
            this.button_ViewEditManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ViewEditManagement.Name = "button_ViewEditManagement";
            this.button_ViewEditManagement.Size = new System.Drawing.Size(139, 30);
            this.button_ViewEditManagement.TabIndex = 59;
            this.button_ViewEditManagement.Text = "View and Edit";
            this.button_ViewEditManagement.UseVisualStyleBackColor = false;
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_refresh.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(178, 610);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(124, 30);
            this.button_refresh.TabIndex = 104;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // DeliveryWorkerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_ViewEditManagement);
            this.Controls.Add(this.button_clearAll_arrangeList);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.dataGridView_DeliveryTable);
            this.Controls.Add(this.textBox_WorkID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_arrengeTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_clear_Worker);
            this.Controls.Add(this.button_Search_Worker);
            this.Controls.Add(this.textBox_Search_Worker);
            this.Controls.Add(this.dataGridView_WorkerTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeliveryWorkerForm";
            this.Text = "DeliveryWorkerForm";
            this.Load += new System.EventHandler(this.DeliveryWorkerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorkerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_arrengeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeliveryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_WorkerTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_clear_Worker;
        private System.Windows.Forms.Button button_Search_Worker;
        private System.Windows.Forms.TextBox textBox_Search_Worker;
        private System.Windows.Forms.DataGridView dataGridView_arrengeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_WorkID;
        private System.Windows.Forms.DataGridView dataGridView_DeliveryTable;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_clearAll_arrangeList;
        private System.Windows.Forms.Button button_ViewEditManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Button button_refresh;
    }
}