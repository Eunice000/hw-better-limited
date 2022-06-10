
namespace BetterLimited.ItemForm
{
    partial class item_New_Form
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWm = new System.Windows.Forms.TextBox();
            this.txtSupplierPrice = new System.Windows.Forms.TextBox();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RRRLbl = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_image = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_SalesPrice = new System.Windows.Forms.Label();
            this.label_WM = new System.Windows.Forms.Label();
            this.label_SI = new System.Windows.Forms.Label();
            this.label_SuPrice = new System.Windows.Forms.Label();
            this.comboBox_SupplierID = new System.Windows.Forms.ComboBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Cat = new System.Windows.Forms.Label();
            this.label_Des = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_allowDly = new System.Windows.Forms.ComboBox();
            this.label_dly = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(641, 388);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(138, 50);
            this.button_cancel.TabIndex = 51;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(329, 388);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(138, 50);
            this.button_save.TabIndex = 50;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(271, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 29);
            this.label9.TabIndex = 49;
            this.label9.Text = "Warranty Month :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 48;
            this.label8.Text = "Supplier Price:  $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 47;
            this.label7.Text = "Supplier ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "Sales Price :  $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Item Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Category :";
            // 
            // txtWm
            // 
            this.txtWm.Location = new System.Drawing.Point(417, 239);
            this.txtWm.Name = "txtWm";
            this.txtWm.Size = new System.Drawing.Size(100, 20);
            this.txtWm.TabIndex = 41;
            this.txtWm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWm_KeyPress);
            // 
            // txtSupplierPrice
            // 
            this.txtSupplierPrice.Location = new System.Drawing.Point(417, 280);
            this.txtSupplierPrice.Name = "txtSupplierPrice";
            this.txtSupplierPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierPrice.TabIndex = 39;
            this.txtSupplierPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierPrice_KeyPress);
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Location = new System.Drawing.Point(141, 239);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(124, 20);
            this.txtSalesPrice.TabIndex = 37;
            this.txtSalesPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesPrice_KeyPress);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(141, 192);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(376, 20);
            this.txtDesc.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(374, 20);
            this.txtName.TabIndex = 35;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(143, 143);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(164, 20);
            this.txtCat.TabIndex = 34;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(26, 50);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(100, 20);
            this.txtItemID.TabIndex = 33;
            this.txtItemID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 32;
            this.label1.Visible = false;
            // 
            // RRRLbl
            // 
            this.RRRLbl.BackColor = System.Drawing.SystemColors.Info;
            this.RRRLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRRLbl.Location = new System.Drawing.Point(-3, -4);
            this.RRRLbl.Name = "RRRLbl";
            this.RRRLbl.Size = new System.Drawing.Size(870, 51);
            this.RRRLbl.TabIndex = 31;
            this.RRRLbl.Text = "New Item ";
            this.RRRLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.SystemColors.Info;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(485, 388);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(138, 50);
            this.button_Clear.TabIndex = 52;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_image
            // 
            this.button_image.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_image.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_image.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_image.Location = new System.Drawing.Point(661, 275);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(99, 25);
            this.button_image.TabIndex = 53;
            this.button_image.Text = "Choose photo";
            this.button_image.UseVisualStyleBackColor = false;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(615, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(203, 177);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 54;
            this.pictureBox.TabStop = false;
            // 
            // label_SalesPrice
            // 
            this.label_SalesPrice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SalesPrice.ForeColor = System.Drawing.Color.Red;
            this.label_SalesPrice.Location = new System.Drawing.Point(138, 262);
            this.label_SalesPrice.Name = "label_SalesPrice";
            this.label_SalesPrice.Size = new System.Drawing.Size(169, 18);
            this.label_SalesPrice.TabIndex = 55;
            // 
            // label_WM
            // 
            this.label_WM.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WM.ForeColor = System.Drawing.Color.Red;
            this.label_WM.Location = new System.Drawing.Point(414, 262);
            this.label_WM.Name = "label_WM";
            this.label_WM.Size = new System.Drawing.Size(224, 21);
            this.label_WM.TabIndex = 56;
            // 
            // label_SI
            // 
            this.label_SI.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SI.ForeColor = System.Drawing.Color.Red;
            this.label_SI.Location = new System.Drawing.Point(140, 309);
            this.label_SI.Name = "label_SI";
            this.label_SI.Size = new System.Drawing.Size(152, 15);
            this.label_SI.TabIndex = 57;
            // 
            // label_SuPrice
            // 
            this.label_SuPrice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SuPrice.ForeColor = System.Drawing.Color.Red;
            this.label_SuPrice.Location = new System.Drawing.Point(417, 309);
            this.label_SuPrice.Name = "label_SuPrice";
            this.label_SuPrice.Size = new System.Drawing.Size(164, 21);
            this.label_SuPrice.TabIndex = 58;
            // 
            // comboBox_SupplierID
            // 
            this.comboBox_SupplierID.FormattingEnabled = true;
            this.comboBox_SupplierID.Location = new System.Drawing.Point(141, 279);
            this.comboBox_SupplierID.Name = "comboBox_SupplierID";
            this.comboBox_SupplierID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SupplierID.TabIndex = 59;
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.Red;
            this.label_Name.Location = new System.Drawing.Point(140, 122);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(238, 18);
            this.label_Name.TabIndex = 60;
            // 
            // label_Cat
            // 
            this.label_Cat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cat.ForeColor = System.Drawing.Color.Red;
            this.label_Cat.Location = new System.Drawing.Point(140, 166);
            this.label_Cat.Name = "label_Cat";
            this.label_Cat.Size = new System.Drawing.Size(238, 18);
            this.label_Cat.TabIndex = 61;
            // 
            // label_Des
            // 
            this.label_Des.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Des.ForeColor = System.Drawing.Color.Red;
            this.label_Des.Location = new System.Drawing.Point(138, 218);
            this.label_Des.Name = "label_Des";
            this.label_Des.Size = new System.Drawing.Size(314, 18);
            this.label_Des.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 63;
            this.label5.Text = "Delivery:";
            // 
            // comboBox_allowDly
            // 
            this.comboBox_allowDly.FormattingEnabled = true;
            this.comboBox_allowDly.Location = new System.Drawing.Point(417, 143);
            this.comboBox_allowDly.Name = "comboBox_allowDly";
            this.comboBox_allowDly.Size = new System.Drawing.Size(100, 21);
            this.comboBox_allowDly.TabIndex = 64;
            // 
            // label_dly
            // 
            this.label_dly.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dly.ForeColor = System.Drawing.Color.Red;
            this.label_dly.Location = new System.Drawing.Point(335, 166);
            this.label_dly.Name = "label_dly";
            this.label_dly.Size = new System.Drawing.Size(274, 18);
            this.label_dly.TabIndex = 65;
            // 
            // item_New_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 507);
            this.Controls.Add(this.label_dly);
            this.Controls.Add(this.comboBox_allowDly);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Des);
            this.Controls.Add(this.label_Cat);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.comboBox_SupplierID);
            this.Controls.Add(this.label_SuPrice);
            this.Controls.Add(this.label_SI);
            this.Controls.Add(this.label_WM);
            this.Controls.Add(this.label_SalesPrice);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_image);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
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
            this.Name = "item_New_Form";
            this.Text = "item_New_Form";
            this.Load += new System.EventHandler(this.item_New_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWm;
        private System.Windows.Forms.TextBox txtSupplierPrice;
        private System.Windows.Forms.TextBox txtSalesPrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RRRLbl;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label_SalesPrice;
        private System.Windows.Forms.Label label_WM;
        private System.Windows.Forms.Label label_SI;
        private System.Windows.Forms.Label label_SuPrice;
        private System.Windows.Forms.ComboBox comboBox_SupplierID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Cat;
        private System.Windows.Forms.Label label_Des;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_allowDly;
        private System.Windows.Forms.Label label_dly;
    }
}