namespace BetterLimited
{
    partial class AccountManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_AccountTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DelectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccountTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 85);
            this.panel1.TabIndex = 0;
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
            this.label2.Size = new System.Drawing.Size(303, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account Management";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(496, 145);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(80, 20);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(780, 145);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(80, 20);
            this.button_Search.TabIndex = 9;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(629, 145);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(148, 22);
            this.textBox_Search.TabIndex = 8;
            // 
            // dataGridView_AccountTable
            // 
            this.dataGridView_AccountTable.AllowUserToAddRows = false;
            this.dataGridView_AccountTable.AllowUserToDeleteRows = false;
            this.dataGridView_AccountTable.AllowUserToResizeRows = false;
            this.dataGridView_AccountTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AccountTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_AccountTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_AccountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccountTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.EditButton,
            this.DelectButton});
            this.dataGridView_AccountTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_AccountTable.Location = new System.Drawing.Point(40, 186);
            this.dataGridView_AccountTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_AccountTable.Name = "dataGridView_AccountTable";
            this.dataGridView_AccountTable.ReadOnly = true;
            this.dataGridView_AccountTable.RowHeadersVisible = false;
            this.dataGridView_AccountTable.RowHeadersWidth = 51;
            this.dataGridView_AccountTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_AccountTable.RowTemplate.Height = 27;
            this.dataGridView_AccountTable.ShowEditingIcon = false;
            this.dataGridView_AccountTable.Size = new System.Drawing.Size(820, 362);
            this.dataGridView_AccountTable.TabIndex = 7;
            this.dataGridView_AccountTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AccountTable_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserAccountID";
            this.Column1.HeaderText = "UserAccountID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StaffID";
            this.Column2.HeaderText = "StaffID";
            this.Column2.MaxInputLength = 20000;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UserName";
            this.Column3.HeaderText = "UserName";
            this.Column3.MaxInputLength = 25000;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Depart";
            this.Column6.HeaderText = "Depart";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Position";
            this.Column7.HeaderText = "Position";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
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
            this.EditButton.Text = "Edit info";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "StaffID :";
            // 
            // AccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_AccountTable);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountManagementForm";
            this.Text = "AccountManagementForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccountManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccountTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView_AccountTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DelectButton;
    }
}