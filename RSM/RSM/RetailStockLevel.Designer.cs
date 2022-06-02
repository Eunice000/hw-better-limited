
namespace RSM
{
    partial class RetailStockLevel
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
            this.RRFLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_KB = new System.Windows.Forms.Button();
            this.button_TW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RRFLbl
            // 
            this.RRFLbl.BackColor = System.Drawing.SystemColors.Info;
            this.RRFLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRFLbl.Location = new System.Drawing.Point(0, -3);
            this.RRFLbl.Name = "RRFLbl";
            this.RRFLbl.Size = new System.Drawing.Size(803, 46);
            this.RRFLbl.TabIndex = 2;
            this.RRFLbl.Text = "Retail Stock Level";
            this.RRFLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 287);
            this.dataGridView1.TabIndex = 3;
            // 
            // button_KB
            // 
            this.button_KB.Location = new System.Drawing.Point(4, 46);
            this.button_KB.Name = "button_KB";
            this.button_KB.Size = new System.Drawing.Size(128, 23);
            this.button_KB.TabIndex = 4;
            this.button_KB.Text = "Kowloon Bay";
            this.button_KB.UseVisualStyleBackColor = true;
            // 
            // button_TW
            // 
            this.button_TW.Location = new System.Drawing.Point(138, 46);
            this.button_TW.Name = "button_TW";
            this.button_TW.Size = new System.Drawing.Size(128, 23);
            this.button_TW.TabIndex = 5;
            this.button_TW.Text = "Tsuen Wan";
            this.button_TW.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search ID:";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(695, 48);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(104, 21);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(585, 48);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(104, 21);
            this.button_Search.TabIndex = 9;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(500, 49);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(77, 20);
            this.textBox_Search.TabIndex = 8;
            // 
            // RetailStockLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_TW);
            this.Controls.Add(this.button_KB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RRFLbl);
            this.Name = "RetailStockLevel";
            this.Text = "RetailRestockLevel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RRFLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_KB;
        private System.Windows.Forms.Button button_TW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
    }
}