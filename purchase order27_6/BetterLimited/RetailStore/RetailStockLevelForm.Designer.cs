
namespace BetterLimited
{
    partial class RetailStockLevelForm
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
            this.dgvRetailStockLevel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateLowLevel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Restock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxItemSearch = new System.Windows.Forms.ComboBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.btnTW = new System.Windows.Forms.Button();
            this.btnKB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetailStockLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRetailStockLevel
            // 
            this.dgvRetailStockLevel.AllowUserToAddRows = false;
            this.dgvRetailStockLevel.AllowUserToDeleteRows = false;
            this.dgvRetailStockLevel.AllowUserToResizeRows = false;
            this.dgvRetailStockLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRetailStockLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRetailStockLevel.BackgroundColor = System.Drawing.Color.White;
            this.dgvRetailStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRetailStockLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetailStockLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.UpdateLowLevel,
            this.Restock});
            this.dgvRetailStockLevel.GridColor = System.Drawing.Color.White;
            this.dgvRetailStockLevel.Location = new System.Drawing.Point(33, 225);
            this.dgvRetailStockLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRetailStockLevel.Name = "dgvRetailStockLevel";
            this.dgvRetailStockLevel.ReadOnly = true;
            this.dgvRetailStockLevel.RowHeadersVisible = false;
            this.dgvRetailStockLevel.RowHeadersWidth = 51;
            this.dgvRetailStockLevel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRetailStockLevel.RowTemplate.Height = 27;
            this.dgvRetailStockLevel.ShowEditingIcon = false;
            this.dgvRetailStockLevel.Size = new System.Drawing.Size(817, 402);
            this.dgvRetailStockLevel.TabIndex = 29;
            this.dgvRetailStockLevel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRetailStockLevel_CellClick);
            this.dgvRetailStockLevel.SelectionChanged += new System.EventHandler(this.dgvRetailStockLevel_SelectionChanged);
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
            this.Column3.FillWeight = 70F;
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
            // Restock
            // 
            this.Restock.FillWeight = 80F;
            this.Restock.HeaderText = "";
            this.Restock.Name = "Restock";
            this.Restock.ReadOnly = true;
            this.Restock.Text = "Re-stock";
            this.Restock.UseColumnTextForButtonValue = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(653, 181);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 22);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 35);
            this.label2.TabIndex = 26;
            this.label2.Text = "Retail Stock Level";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 86);
            this.label1.TabIndex = 25;
            // 
            // cbxItemSearch
            // 
            this.cbxItemSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemSearch.Items.AddRange(new object[] {
            "Item ID",
            "Item Name"});
            this.cbxItemSearch.Location = new System.Drawing.Point(498, 181);
            this.cbxItemSearch.Name = "cbxItemSearch";
            this.cbxItemSearch.Size = new System.Drawing.Size(121, 20);
            this.cbxItemSearch.TabIndex = 30;
            this.cbxItemSearch.SelectedIndexChanged += new System.EventHandler(this.cbxItemSearch_SelectedIndexChanged);
            // 
            // picSearch
            // 
            this.picSearch.Image = global::BetterLimited.Properties.Resources.search;
            this.picSearch.Location = new System.Drawing.Point(625, 181);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(22, 22);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 28;
            this.picSearch.TabStop = false;
            // 
            // btnTW
            // 
            this.btnTW.Location = new System.Drawing.Point(33, 119);
            this.btnTW.Name = "btnTW";
            this.btnTW.Size = new System.Drawing.Size(107, 23);
            this.btnTW.TabIndex = 31;
            this.btnTW.Text = "Tsuen Wan";
            this.btnTW.UseVisualStyleBackColor = true;
            this.btnTW.Click += new System.EventHandler(this.btnTW_Click);
            // 
            // btnKB
            // 
            this.btnKB.Location = new System.Drawing.Point(158, 119);
            this.btnKB.Name = "btnKB";
            this.btnKB.Size = new System.Drawing.Size(107, 23);
            this.btnKB.TabIndex = 32;
            this.btnKB.Text = "Kowloon Bay";
            this.btnKB.UseVisualStyleBackColor = true;
            this.btnKB.Click += new System.EventHandler(this.btnKB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tsuen Wan Store Stock Level";
            // 
            // RetailStockLevelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKB);
            this.Controls.Add(this.btnTW);
            this.Controls.Add(this.dgvRetailStockLevel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxItemSearch);
            this.Controls.Add(this.picSearch);
            this.Name = "RetailStockLevelForm";
            this.Text = "RetailStockLevelForm";
            this.Load += new System.EventHandler(this.RetailStockLevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetailStockLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRetailStockLevel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxItemSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Button btnTW;
        private System.Windows.Forms.Button btnKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateLowLevel;
        private System.Windows.Forms.DataGridViewButtonColumn Restock;
    }
}