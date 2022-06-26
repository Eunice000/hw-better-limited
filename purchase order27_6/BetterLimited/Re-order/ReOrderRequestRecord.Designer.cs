
namespace BetterLimited
{
    partial class ReOrderRequestRecord
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
            this.lblReOrderRecord = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtReOrderRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReOrderRecord = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbxIDSearch = new System.Windows.Forms.ComboBox();
            this.dgvReOrderDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReOrderRecord
            // 
            this.lblReOrderRecord.AutoSize = true;
            this.lblReOrderRecord.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReOrderRecord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReOrderRecord.Location = new System.Drawing.Point(6, 10);
            this.lblReOrderRecord.Name = "lblReOrderRecord";
            this.lblReOrderRecord.Size = new System.Drawing.Size(216, 28);
            this.lblReOrderRecord.TabIndex = 28;
            this.lblReOrderRecord.Text = "Re-order Request Record";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BetterLimited.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(403, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txtReOrderRecord
            // 
            this.txtReOrderRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReOrderRecord.Location = new System.Drawing.Point(431, 13);
            this.txtReOrderRecord.Name = "txtReOrderRecord";
            this.txtReOrderRecord.Size = new System.Drawing.Size(141, 20);
            this.txtReOrderRecord.TabIndex = 25;
            this.txtReOrderRecord.TextChanged += new System.EventHandler(this.txtReOrderRecord_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(6, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Re-order Request Details";
            // 
            // dgvReOrderRecord
            // 
            this.dgvReOrderRecord.AllowUserToAddRows = false;
            this.dgvReOrderRecord.AllowUserToDeleteRows = false;
            this.dgvReOrderRecord.AllowUserToResizeRows = false;
            this.dgvReOrderRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReOrderRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReOrderRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvReOrderRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReOrderRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReOrderRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Status,
            this.Accept});
            this.dgvReOrderRecord.GridColor = System.Drawing.Color.White;
            this.dgvReOrderRecord.Location = new System.Drawing.Point(11, 42);
            this.dgvReOrderRecord.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReOrderRecord.Name = "dgvReOrderRecord";
            this.dgvReOrderRecord.ReadOnly = true;
            this.dgvReOrderRecord.RowHeadersVisible = false;
            this.dgvReOrderRecord.RowHeadersWidth = 51;
            this.dgvReOrderRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReOrderRecord.RowTemplate.Height = 27;
            this.dgvReOrderRecord.ShowEditingIcon = false;
            this.dgvReOrderRecord.Size = new System.Drawing.Size(561, 204);
            this.dgvReOrderRecord.TabIndex = 31;
            this.dgvReOrderRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReOrderRecord_CellClick);
            this.dgvReOrderRecord.SelectionChanged += new System.EventHandler(this.dgvReOrderRecord_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReorderRequestID";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Request ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StaffID";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Staff ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RequestDate";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RequestTime";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "RequestStatus";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Accept
            // 
            this.Accept.HeaderText = "";
            this.Accept.Name = "Accept";
            this.Accept.ReadOnly = true;
            this.Accept.Text = "Accept";
            this.Accept.UseColumnTextForButtonValue = true;
            // 
            // cbxIDSearch
            // 
            this.cbxIDSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDSearch.Items.AddRange(new object[] {
            "Request ID",
            "Staff ID"});
            this.cbxIDSearch.Location = new System.Drawing.Point(276, 15);
            this.cbxIDSearch.Name = "cbxIDSearch";
            this.cbxIDSearch.Size = new System.Drawing.Size(121, 21);
            this.cbxIDSearch.TabIndex = 32;
            this.cbxIDSearch.SelectedIndexChanged += new System.EventHandler(this.cbxIDSearch_SelectedIndexChanged);
            // 
            // dgvReOrderDetails
            // 
            this.dgvReOrderDetails.AllowUserToAddRows = false;
            this.dgvReOrderDetails.AllowUserToDeleteRows = false;
            this.dgvReOrderDetails.AllowUserToResizeRows = false;
            this.dgvReOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvReOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgvReOrderDetails.GridColor = System.Drawing.Color.White;
            this.dgvReOrderDetails.Location = new System.Drawing.Point(11, 311);
            this.dgvReOrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReOrderDetails.Name = "dgvReOrderDetails";
            this.dgvReOrderDetails.ReadOnly = true;
            this.dgvReOrderDetails.RowHeadersVisible = false;
            this.dgvReOrderDetails.RowHeadersWidth = 51;
            this.dgvReOrderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReOrderDetails.RowTemplate.Height = 27;
            this.dgvReOrderDetails.ShowEditingIcon = false;
            this.dgvReOrderDetails.Size = new System.Drawing.Size(561, 242);
            this.dgvReOrderDetails.TabIndex = 33;
            this.dgvReOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReOrderDetails_CellClick);
            this.dgvReOrderDetails.SelectionChanged += new System.EventHandler(this.dgvReOrderDetails_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn6.FillWeight = 180F;
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 260;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Qty";
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 70F;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = "Delete";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(300, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ReOrderRequestRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 608);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvReOrderDetails);
            this.Controls.Add(this.cbxIDSearch);
            this.Controls.Add(this.dgvReOrderRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReOrderRecord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtReOrderRecord);
            this.Name = "ReOrderRequestRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Re Order Request Record";
            this.Load += new System.EventHandler(this.ReOrderRequestRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReOrderRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtReOrderRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReOrderRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Accept;
        private System.Windows.Forms.ComboBox cbxIDSearch;
        private System.Windows.Forms.DataGridView dgvReOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Button btnDelete;
    }
}