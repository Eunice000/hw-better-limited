
namespace BetterLimited
{
    partial class ReOrderRequestForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReOrderRequest = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbxItemSearch = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSelectItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReOrderRecor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Re-order Request";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 86);
            this.label1.TabIndex = 14;
            // 
            // dgvReOrderRequest
            // 
            this.dgvReOrderRequest.AllowUserToAddRows = false;
            this.dgvReOrderRequest.AllowUserToDeleteRows = false;
            this.dgvReOrderRequest.AllowUserToResizeRows = false;
            this.dgvReOrderRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReOrderRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReOrderRequest.BackgroundColor = System.Drawing.Color.White;
            this.dgvReOrderRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReOrderRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReOrderRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column2,
            this.minus,
            this.Column3,
            this.add});
            this.dgvReOrderRequest.GridColor = System.Drawing.Color.White;
            this.dgvReOrderRequest.Location = new System.Drawing.Point(33, 398);
            this.dgvReOrderRequest.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReOrderRequest.Name = "dgvReOrderRequest";
            this.dgvReOrderRequest.ReadOnly = true;
            this.dgvReOrderRequest.RowHeadersVisible = false;
            this.dgvReOrderRequest.RowHeadersWidth = 51;
            this.dgvReOrderRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReOrderRequest.RowTemplate.Height = 27;
            this.dgvReOrderRequest.ShowEditingIcon = false;
            this.dgvReOrderRequest.Size = new System.Drawing.Size(817, 194);
            this.dgvReOrderRequest.TabIndex = 18;
            this.dgvReOrderRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReOrderRequest_CellClick);
            this.dgvReOrderRequest.SelectionChanged += new System.EventHandler(this.dgvInventoryStockLevel_SelectionChanged);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "itemID";
            this.Column5.HeaderText = "Item ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ItemName";
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // minus
            // 
            this.minus.FillWeight = 80F;
            this.minus.HeaderText = "";
            this.minus.Name = "minus";
            this.minus.ReadOnly = true;
            this.minus.Text = "-";
            this.minus.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Qty";
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // add
            // 
            this.add.FillWeight = 80F;
            this.add.HeaderText = "";
            this.add.MinimumWidth = 6;
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Text = "+";
            this.add.UseColumnTextForButtonValue = true;
            // 
            // cbxItemSearch
            // 
            this.cbxItemSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemSearch.Items.AddRange(new object[] {
            "Item ID",
            "Item Name"});
            this.cbxItemSearch.Location = new System.Drawing.Point(498, 113);
            this.cbxItemSearch.Name = "cbxItemSearch";
            this.cbxItemSearch.Size = new System.Drawing.Size(121, 21);
            this.cbxItemSearch.TabIndex = 23;
            this.cbxItemSearch.SelectedIndexChanged += new System.EventHandler(this.cbxItemSearch_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BetterLimited.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(625, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemSearch.Location = new System.Drawing.Point(653, 113);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(197, 20);
            this.txtItemSearch.TabIndex = 20;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            this.txtItemSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemSearch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Select item to re-order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Create Re-order Request";
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendRequest.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendRequest.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSendRequest.ForeColor = System.Drawing.Color.Black;
            this.btnSendRequest.Location = new System.Drawing.Point(729, 612);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(121, 37);
            this.btnSendRequest.TabIndex = 26;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = false;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(641, 612);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 37);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSelectItem
            // 
            this.dgvSelectItem.AllowUserToAddRows = false;
            this.dgvSelectItem.AllowUserToDeleteRows = false;
            this.dgvSelectItem.AllowUserToResizeRows = false;
            this.dgvSelectItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelectItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelectItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ReOrder});
            this.dgvSelectItem.GridColor = System.Drawing.Color.White;
            this.dgvSelectItem.Location = new System.Drawing.Point(36, 152);
            this.dgvSelectItem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSelectItem.MultiSelect = false;
            this.dgvSelectItem.Name = "dgvSelectItem";
            this.dgvSelectItem.ReadOnly = true;
            this.dgvSelectItem.RowHeadersVisible = false;
            this.dgvSelectItem.RowHeadersWidth = 51;
            this.dgvSelectItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSelectItem.RowTemplate.Height = 27;
            this.dgvSelectItem.ShowEditingIcon = false;
            this.dgvSelectItem.Size = new System.Drawing.Size(817, 193);
            this.dgvSelectItem.TabIndex = 28;
            this.dgvSelectItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectItem_CellClick);
            this.dgvSelectItem.SelectionChanged += new System.EventHandler(this.dgvSelectItem_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "itemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 174;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "itemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 164;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 164;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LowLevelQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Low Level Quantity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 164;
            // 
            // ReOrder
            // 
            this.ReOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReOrder.HeaderText = "";
            this.ReOrder.Name = "ReOrder";
            this.ReOrder.ReadOnly = true;
            this.ReOrder.Text = "Re-order";
            this.ReOrder.UseColumnTextForButtonValue = true;
            this.ReOrder.Width = 148;
            // 
            // btnReOrderRecor
            // 
            this.btnReOrderRecor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReOrderRecor.BackColor = System.Drawing.SystemColors.Control;
            this.btnReOrderRecor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnReOrderRecor.ForeColor = System.Drawing.Color.Black;
            this.btnReOrderRecor.Location = new System.Drawing.Point(33, 612);
            this.btnReOrderRecor.Name = "btnReOrderRecor";
            this.btnReOrderRecor.Size = new System.Drawing.Size(165, 37);
            this.btnReOrderRecor.TabIndex = 29;
            this.btnReOrderRecor.Text = "View Request Record";
            this.btnReOrderRecor.UseVisualStyleBackColor = false;
            this.btnReOrderRecor.Click += new System.EventHandler(this.btnReOrderRecord_Click);
            // 
            // ReOrderRequestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnReOrderRecor);
            this.Controls.Add(this.dgvSelectItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxItemSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtItemSearch);
            this.Controls.Add(this.dgvReOrderRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReOrderRequestForm";
            this.Text = "InventoryStockLevelForm";
            this.Load += new System.EventHandler(this.ReOrderRequestForm_Load);
            this.Shown += new System.EventHandler(this.InventoryStockLevelForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReOrderRequest;
        private System.Windows.Forms.ComboBox cbxItemSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSelectItem;
        private System.Windows.Forms.Button btnReOrderRecor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn ReOrder;
    }
}