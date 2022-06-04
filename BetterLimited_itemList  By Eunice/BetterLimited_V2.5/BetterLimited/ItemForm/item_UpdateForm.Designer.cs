
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
            this.txtImg = new System.Windows.Forms.TextBox();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtSupplierPrice = new System.Windows.Forms.TextBox();
            this.txtWm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_image = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // RRRLbl
            // 
            this.RRRLbl.BackColor = System.Drawing.SystemColors.Info;
            this.RRRLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRRLbl.Location = new System.Drawing.Point(-2, -3);
            this.RRRLbl.Name = "RRRLbl";
            this.RRRLbl.Size = new System.Drawing.Size(782, 51);
            this.RRRLbl.TabIndex = 2;
            this.RRRLbl.Text = "Update Item List";
            this.RRRLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item ID :";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(97, 105);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(100, 20);
            this.txtItemID.TabIndex = 4;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(318, 102);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(100, 20);
            this.txtCat.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(136, 192);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(575, 20);
            this.txtDesc.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(509, 102);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(202, 20);
            this.txtImg.TabIndex = 14;
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Location = new System.Drawing.Point(136, 239);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSalesPrice.TabIndex = 12;
            this.txtSalesPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesPrice_KeyPress);
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(135, 283);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 18;
            this.txtSupplierID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierID_KeyPress);
            // 
            // txtSupplierPrice
            // 
            this.txtSupplierPrice.Location = new System.Drawing.Point(412, 280);
            this.txtSupplierPrice.Name = "txtSupplierPrice";
            this.txtSupplierPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierPrice.TabIndex = 16;
            this.txtSupplierPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierPrice_KeyPress);
            // 
            // txtWm
            // 
            this.txtWm.Location = new System.Drawing.Point(412, 239);
            this.txtWm.Name = "txtWm";
            this.txtWm.Size = new System.Drawing.Size(73, 20);
            this.txtWm.TabIndex = 20;
            this.txtWm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWm_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Description :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Image :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sales Price :  $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Supplier ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Supplier Price:  $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(265, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "Warranty Month :";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(434, 345);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(138, 50);
            this.button_update.TabIndex = 29;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Silver;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(604, 345);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(138, 50);
            this.button_cancel.TabIndex = 30;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_image
            // 
            this.button_image.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_image.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_image.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_image.Location = new System.Drawing.Point(717, 98);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(38, 28);
            this.button_image.TabIndex = 31;
            this.button_image.Text = "...";
            this.button_image.UseVisualStyleBackColor = false;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // item_UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 407);
            this.Controls.Add(this.button_image);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWm);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.txtSupplierPrice);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.txtSalesPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RRRLbl);
            this.Name = "item_UpdateForm";
            this.Text = "item_UpdateForm";
            this.Load += new System.EventHandler(this.item_UpdateForm_Load);
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
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.TextBox txtSalesPrice;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtSupplierPrice;
        private System.Windows.Forms.TextBox txtWm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}