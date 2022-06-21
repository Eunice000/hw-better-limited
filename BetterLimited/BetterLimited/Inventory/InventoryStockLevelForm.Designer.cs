
namespace BetterLimited
{
    partial class InventoryStockLevelForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvInventoryStockLevel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateLowLevel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ReOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.cbxItemSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryStockLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(93, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "Inventory Stock Level";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1179, 108);
            this.label1.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(871, 184);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(261, 25);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dgvInventoryStockLevel
            // 
            this.dgvInventoryStockLevel.AllowUserToAddRows = false;
            this.dgvInventoryStockLevel.AllowUserToDeleteRows = false;
            this.dgvInventoryStockLevel.AllowUserToResizeRows = false;
            this.dgvInventoryStockLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventoryStockLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryStockLevel.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventoryStockLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryStockLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.UpdateLowLevel,
            this.ReOrder});
            this.dgvInventoryStockLevel.GridColor = System.Drawing.Color.White;
            this.dgvInventoryStockLevel.Location = new System.Drawing.Point(44, 239);
            this.dgvInventoryStockLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventoryStockLevel.Name = "dgvInventoryStockLevel";
            this.dgvInventoryStockLevel.ReadOnly = true;
            this.dgvInventoryStockLevel.RowHeadersVisible = false;
            this.dgvInventoryStockLevel.RowHeadersWidth = 51;
            this.dgvInventoryStockLevel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventoryStockLevel.RowTemplate.Height = 27;
            this.dgvInventoryStockLevel.ShowEditingIcon = false;
            this.dgvInventoryStockLevel.Size = new System.Drawing.Size(1089, 502);
            this.dgvInventoryStockLevel.TabIndex = 18;
            this.dgvInventoryStockLevel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryStockLevel_CellClick);
            this.dgvInventoryStockLevel.SelectionChanged += new System.EventHandler(this.dgvInventoryStockLevel_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "itemID";
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Item ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "itemName";
            this.Column2.FillWeight = 180F;
            this.Column2.HeaderText = "Item Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Quantity";
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LowLevelQty";
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Low Level Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UpdateLowLevel
            // 
            this.UpdateLowLevel.HeaderText = "";
            this.UpdateLowLevel.MinimumWidth = 6;
            this.UpdateLowLevel.Name = "UpdateLowLevel";
            this.UpdateLowLevel.ReadOnly = true;
            this.UpdateLowLevel.Text = "Update Low Level";
            this.UpdateLowLevel.UseColumnTextForButtonValue = true;
            // 
            // ReOrder
            // 
            this.ReOrder.FillWeight = 70F;
            this.ReOrder.HeaderText = "";
            this.ReOrder.Name = "ReOrder";
            this.ReOrder.ReadOnly = true;
            this.ReOrder.Text = "Re-order";
            this.ReOrder.UseColumnTextForButtonValue = true;
            // 
            // picSearch
            // 
            this.picSearch.Image = global::BetterLimited.Properties.Resources.search;
            this.picSearch.Location = new System.Drawing.Point(833, 184);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(29, 28);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 17;
            this.picSearch.TabStop = false;
            // 
            // cbxItemSearch
            // 
            this.cbxItemSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemSearch.Items.AddRange(new object[] {
            "Item ID",
            "Item Name"});
            this.cbxItemSearch.Location = new System.Drawing.Point(664, 184);
            this.cbxItemSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxItemSearch.Name = "cbxItemSearch";
            this.cbxItemSearch.Size = new System.Drawing.Size(160, 23);
            this.cbxItemSearch.TabIndex = 24;
            this.cbxItemSearch.SelectedIndexChanged += new System.EventHandler(this.cbxItemSearch_SelectedIndexChanged);
            // 
            // InventoryStockLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 826);
            this.Controls.Add(this.cbxItemSearch);
            this.Controls.Add(this.dgvInventoryStockLevel);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InventoryStockLevelForm";
            this.Text = "InventoryStockLevelForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.InventoryStockLevelForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryStockLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.DataGridView dgvInventoryStockLevel;
        private System.Windows.Forms.ComboBox cbxItemSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateLowLevel;
        private System.Windows.Forms.DataGridViewButtonColumn ReOrder;
    }
}