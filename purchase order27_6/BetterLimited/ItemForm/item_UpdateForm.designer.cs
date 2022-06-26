
namespace BetterLimited.ItemForm
{
    partial class item_UpdateForm
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
            this.RRRLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.txtSupplierPrice = new System.Windows.Forms.TextBox();
            this.txtWm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.comboBox_SupplierID = new System.Windows.Forms.ComboBox();
            this.label_Cat = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Des = new System.Windows.Forms.Label();
            this.label_SalesPrice = new System.Windows.Forms.Label();
            this.label_WM = new System.Windows.Forms.Label();
            this.label_SuPrice = new System.Windows.Forms.Label();
            this.comboBox_allowDly = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RRRLbl
            // 
            this.RRRLbl.BackColor = System.Drawing.SystemColors.Info;
            this.RRRLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRRLbl.Location = new System.Drawing.Point(-3, -4);
            this.RRRLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RRRLbl.Name = "RRRLbl";
            this.RRRLbl.Size = new System.Drawing.Size(1043, 59);
            this.RRRLbl.TabIndex = 2;
            this.RRRLbl.Text = "Update Item List";
            this.RRRLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item ID :";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(177, 105);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(132, 25);
            this.txtItemID.TabIndex = 4;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(177, 166);
            this.txtCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(132, 25);
            this.txtCat.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(181, 221);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(464, 25);
            this.txtDesc.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(480, 105);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 25);
            this.txtName.TabIndex = 8;
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Location = new System.Drawing.Point(181, 276);
            this.txtSalesPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(132, 25);
            this.txtSalesPrice.TabIndex = 12;
            this.txtSalesPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesPrice_KeyPress);
            // 
            // txtSupplierPrice
            // 
            this.txtSupplierPrice.Location = new System.Drawing.Point(549, 322);
            this.txtSupplierPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplierPrice.Name = "txtSupplierPrice";
            this.txtSupplierPrice.Size = new System.Drawing.Size(96, 25);
            this.txtSupplierPrice.TabIndex = 16;
            this.txtSupplierPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierPrice_KeyPress);
            // 
            // txtWm
            // 
            this.txtWm.Location = new System.Drawing.Point(549, 276);
            this.txtWm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWm.Name = "txtWm";
            this.txtWm.Size = new System.Drawing.Size(96, 25);
            this.txtWm.TabIndex = 20;
            this.txtWm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWm_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 36);
            this.label3.TabIndex = 22;
            this.label3.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "Description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sales Price :  $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 36);
            this.label7.TabIndex = 26;
            this.label7.Text = "Supplier ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 36);
            this.label8.TabIndex = 27;
            this.label8.Text = "Supplier Price:  $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(353, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 36);
            this.label9.TabIndex = 28;
            this.label9.Text = "Warranty Month :";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(399, 398);
            this.button_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(184, 58);
            this.button_update.TabIndex = 29;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Silver;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(805, 398);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(184, 58);
            this.button_cancel.TabIndex = 30;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::BetterLimited.Properties.Resources.DefaultPicture;
            this.pictureBox.Location = new System.Drawing.Point(768, 82);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(221, 161);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 56;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(805, 270);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 55;
            this.button1.Text = "Choose photo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.Info;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(604, 398);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(184, 58);
            this.button_clear.TabIndex = 57;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // comboBox_SupplierID
            // 
            this.comboBox_SupplierID.FormattingEnabled = true;
            this.comboBox_SupplierID.Location = new System.Drawing.Point(168, 326);
            this.comboBox_SupplierID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_SupplierID.Name = "comboBox_SupplierID";
            this.comboBox_SupplierID.Size = new System.Drawing.Size(160, 23);
            this.comboBox_SupplierID.TabIndex = 60;
            // 
            // label_Cat
            // 
            this.label_Cat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cat.ForeColor = System.Drawing.Color.Red;
            this.label_Cat.Location = new System.Drawing.Point(177, 192);
            this.label_Cat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Cat.Name = "label_Cat";
            this.label_Cat.Size = new System.Drawing.Size(259, 20);
            this.label_Cat.TabIndex = 61;
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.Red;
            this.label_Name.Location = new System.Drawing.Point(477, 131);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(259, 20);
            this.label_Name.TabIndex = 62;
            // 
            // label_Des
            // 
            this.label_Des.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Des.ForeColor = System.Drawing.Color.Red;
            this.label_Des.Location = new System.Drawing.Point(177, 252);
            this.label_Des.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Des.Name = "label_Des";
            this.label_Des.Size = new System.Drawing.Size(259, 20);
            this.label_Des.TabIndex = 63;
            // 
            // label_SalesPrice
            // 
            this.label_SalesPrice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SalesPrice.ForeColor = System.Drawing.Color.Red;
            this.label_SalesPrice.Location = new System.Drawing.Point(176, 304);
            this.label_SalesPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SalesPrice.Name = "label_SalesPrice";
            this.label_SalesPrice.Size = new System.Drawing.Size(259, 20);
            this.label_SalesPrice.TabIndex = 64;
            // 
            // label_WM
            // 
            this.label_WM.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WM.ForeColor = System.Drawing.Color.Red;
            this.label_WM.Location = new System.Drawing.Point(551, 302);
            this.label_WM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_WM.Name = "label_WM";
            this.label_WM.Size = new System.Drawing.Size(259, 20);
            this.label_WM.TabIndex = 65;
            // 
            // label_SuPrice
            // 
            this.label_SuPrice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SuPrice.ForeColor = System.Drawing.Color.Red;
            this.label_SuPrice.Location = new System.Drawing.Point(545, 356);
            this.label_SuPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SuPrice.Name = "label_SuPrice";
            this.label_SuPrice.Size = new System.Drawing.Size(259, 20);
            this.label_SuPrice.TabIndex = 67;
            // 
            // comboBox_allowDly
            // 
            this.comboBox_allowDly.FormattingEnabled = true;
            this.comboBox_allowDly.Location = new System.Drawing.Point(480, 165);
            this.comboBox_allowDly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_allowDly.Name = "comboBox_allowDly";
            this.comboBox_allowDly.Size = new System.Drawing.Size(132, 23);
            this.comboBox_allowDly.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 36);
            this.label5.TabIndex = 68;
            this.label5.Text = "Delivery:";
            // 
            // item_UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 594);
            this.Controls.Add(this.comboBox_allowDly);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_SuPrice);
            this.Controls.Add(this.label_WM);
            this.Controls.Add(this.label_SalesPrice);
            this.Controls.Add(this.label_Des);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Cat);
            this.Controls.Add(this.comboBox_SupplierID);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWm);
            this.Controls.Add(this.txtSupplierPrice);
            this.Controls.Add(this.txtSalesPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RRRLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "item_UpdateForm";
            this.Text = "item_UpdateForm";
            this.Load += new System.EventHandler(this.item_UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RRRLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalesPrice;
        private System.Windows.Forms.TextBox txtSupplierPrice;
        private System.Windows.Forms.TextBox txtWm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ComboBox comboBox_SupplierID;
        private System.Windows.Forms.Label label_Cat;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Des;
        private System.Windows.Forms.Label label_SalesPrice;
        private System.Windows.Forms.Label label_WM;
        private System.Windows.Forms.Label label_SuPrice;
        private System.Windows.Forms.ComboBox comboBox_allowDly;
        private System.Windows.Forms.Label label5;
    }
}