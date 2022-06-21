﻿namespace BetterLimited
{
    partial class ViewDeliveryWorkmanForm
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
            this.dataGridView_DeliveryTable = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_DeliveryTime = new System.Windows.Forms.Label();
            this.label_DeliveryDate = new System.Windows.Forms.Label();
            this.label_deliveryStatus = new System.Windows.Forms.Label();
            this.label_SalesOrderID = new System.Windows.Forms.Label();
            this.label_DeliveryID = new System.Windows.Forms.Label();
            this.textBox_DeliveryID = new System.Windows.Forms.TextBox();
            this.textBox_SalesOrderID = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_WorkmanID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_DeliveryTime = new System.Windows.Forms.TextBox();
            this.textBox_DeliveryDate = new System.Windows.Forms.TextBox();
            this.textBox_DeliveryStatus = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Workman Delivery List";
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
            this.Column11,
            this.dataGridViewButtonColumn2});
            this.dataGridView_DeliveryTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_DeliveryTable.Location = new System.Drawing.Point(9, 164);
            this.dataGridView_DeliveryTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_DeliveryTable.MultiSelect = false;
            this.dataGridView_DeliveryTable.Name = "dataGridView_DeliveryTable";
            this.dataGridView_DeliveryTable.RowHeadersVisible = false;
            this.dataGridView_DeliveryTable.RowHeadersWidth = 51;
            this.dataGridView_DeliveryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_DeliveryTable.RowTemplate.Height = 27;
            this.dataGridView_DeliveryTable.ShowEditingIcon = false;
            this.dataGridView_DeliveryTable.Size = new System.Drawing.Size(561, 449);
            this.dataGridView_DeliveryTable.TabIndex = 57;
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
            // Column11
            // 
            this.Column11.DataPropertyName = "WorkmanID";
            this.Column11.HeaderText = "WorkmanID";
            this.Column11.Name = "Column11";
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Select";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 61;
            this.label7.Text = "DeliveryID :";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(179, 131);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(80, 18);
            this.button_clear.TabIndex = 60;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(490, 131);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(80, 18);
            this.button_Search.TabIndex = 59;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(338, 131);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(148, 22);
            this.textBox_Search.TabIndex = 58;
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // label_DeliveryTime
            // 
            this.label_DeliveryTime.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeliveryTime.Location = new System.Drawing.Point(585, 369);
            this.label_DeliveryTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DeliveryTime.Name = "label_DeliveryTime";
            this.label_DeliveryTime.Size = new System.Drawing.Size(121, 20);
            this.label_DeliveryTime.TabIndex = 70;
            this.label_DeliveryTime.Text = "DeliveryTime :";
            // 
            // label_DeliveryDate
            // 
            this.label_DeliveryDate.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeliveryDate.Location = new System.Drawing.Point(585, 298);
            this.label_DeliveryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DeliveryDate.Name = "label_DeliveryDate";
            this.label_DeliveryDate.Size = new System.Drawing.Size(121, 20);
            this.label_DeliveryDate.TabIndex = 69;
            this.label_DeliveryDate.Text = "DeliveryDate :";
            // 
            // label_deliveryStatus
            // 
            this.label_deliveryStatus.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deliveryStatus.Location = new System.Drawing.Point(585, 440);
            this.label_deliveryStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_deliveryStatus.Name = "label_deliveryStatus";
            this.label_deliveryStatus.Size = new System.Drawing.Size(121, 20);
            this.label_deliveryStatus.TabIndex = 68;
            this.label_deliveryStatus.Text = "DeliveryStatus :";
            // 
            // label_SalesOrderID
            // 
            this.label_SalesOrderID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SalesOrderID.Location = new System.Drawing.Point(583, 227);
            this.label_SalesOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SalesOrderID.Name = "label_SalesOrderID";
            this.label_SalesOrderID.Size = new System.Drawing.Size(121, 20);
            this.label_SalesOrderID.TabIndex = 67;
            this.label_SalesOrderID.Text = "SalesOrderID :";
            // 
            // label_DeliveryID
            // 
            this.label_DeliveryID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeliveryID.Location = new System.Drawing.Point(590, 156);
            this.label_DeliveryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DeliveryID.Name = "label_DeliveryID";
            this.label_DeliveryID.Size = new System.Drawing.Size(121, 20);
            this.label_DeliveryID.TabIndex = 66;
            this.label_DeliveryID.Text = "DeliveryID :";
            // 
            // textBox_DeliveryID
            // 
            this.textBox_DeliveryID.Enabled = false;
            this.textBox_DeliveryID.Location = new System.Drawing.Point(721, 157);
            this.textBox_DeliveryID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DeliveryID.Name = "textBox_DeliveryID";
            this.textBox_DeliveryID.Size = new System.Drawing.Size(140, 22);
            this.textBox_DeliveryID.TabIndex = 65;
            // 
            // textBox_SalesOrderID
            // 
            this.textBox_SalesOrderID.Enabled = false;
            this.textBox_SalesOrderID.Location = new System.Drawing.Point(721, 228);
            this.textBox_SalesOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_SalesOrderID.Name = "textBox_SalesOrderID";
            this.textBox_SalesOrderID.Size = new System.Drawing.Size(140, 22);
            this.textBox_SalesOrderID.TabIndex = 64;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Update.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(739, 582);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(124, 30);
            this.button_Update.TabIndex = 73;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 511);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "WorkmanID :";
            // 
            // textBox_WorkmanID
            // 
            this.textBox_WorkmanID.Location = new System.Drawing.Point(723, 512);
            this.textBox_WorkmanID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_WorkmanID.Name = "textBox_WorkmanID";
            this.textBox_WorkmanID.Size = new System.Drawing.Size(140, 22);
            this.textBox_WorkmanID.TabIndex = 75;
            this.textBox_WorkmanID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_WorkmanID_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(589, 582);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 77;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_DeliveryTime
            // 
            this.textBox_DeliveryTime.Enabled = false;
            this.textBox_DeliveryTime.Location = new System.Drawing.Point(723, 370);
            this.textBox_DeliveryTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DeliveryTime.Name = "textBox_DeliveryTime";
            this.textBox_DeliveryTime.Size = new System.Drawing.Size(140, 22);
            this.textBox_DeliveryTime.TabIndex = 78;
            // 
            // textBox_DeliveryDate
            // 
            this.textBox_DeliveryDate.Enabled = false;
            this.textBox_DeliveryDate.Location = new System.Drawing.Point(723, 299);
            this.textBox_DeliveryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DeliveryDate.Name = "textBox_DeliveryDate";
            this.textBox_DeliveryDate.Size = new System.Drawing.Size(140, 22);
            this.textBox_DeliveryDate.TabIndex = 79;
            // 
            // textBox_DeliveryStatus
            // 
            this.textBox_DeliveryStatus.Enabled = false;
            this.textBox_DeliveryStatus.Location = new System.Drawing.Point(723, 441);
            this.textBox_DeliveryStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DeliveryStatus.Name = "textBox_DeliveryStatus";
            this.textBox_DeliveryStatus.Size = new System.Drawing.Size(140, 22);
            this.textBox_DeliveryStatus.TabIndex = 80;
            // 
            // ViewDeliveryWorkmanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.textBox_DeliveryStatus);
            this.Controls.Add(this.textBox_DeliveryDate);
            this.Controls.Add(this.textBox_DeliveryTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_WorkmanID);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label_DeliveryTime);
            this.Controls.Add(this.label_DeliveryDate);
            this.Controls.Add(this.label_deliveryStatus);
            this.Controls.Add(this.label_SalesOrderID);
            this.Controls.Add(this.label_DeliveryID);
            this.Controls.Add(this.textBox_DeliveryID);
            this.Controls.Add(this.textBox_SalesOrderID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_DeliveryTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewDeliveryWorkmanForm";
            this.Text = "ViewEditDeliveryWorkmanForm";
            this.Load += new System.EventHandler(this.ViewEditDeliveryWorkmanForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeliveryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_DeliveryTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_DeliveryTime;
        private System.Windows.Forms.Label label_DeliveryDate;
        private System.Windows.Forms.Label label_deliveryStatus;
        private System.Windows.Forms.Label label_SalesOrderID;
        private System.Windows.Forms.Label label_DeliveryID;
        private System.Windows.Forms.TextBox textBox_DeliveryID;
        private System.Windows.Forms.TextBox textBox_SalesOrderID;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_WorkmanID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_DeliveryTime;
        private System.Windows.Forms.TextBox textBox_DeliveryDate;
        private System.Windows.Forms.TextBox textBox_DeliveryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}