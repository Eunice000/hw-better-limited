﻿
namespace RSM
{
    partial class RestockRequestForm
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
            this.textBox_staffID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_item = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RRRLbl
            // 
            this.RRRLbl.BackColor = System.Drawing.SystemColors.Info;
            this.RRRLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRRLbl.Location = new System.Drawing.Point(-1, -5);
            this.RRRLbl.Name = "RRRLbl";
            this.RRRLbl.Size = new System.Drawing.Size(803, 46);
            this.RRRLbl.TabIndex = 1;
            this.RRRLbl.Text = "Restock Request Form";
            this.RRRLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff ID:";
            // 
            // textBox_staffID
            // 
            this.textBox_staffID.Location = new System.Drawing.Point(95, 54);
            this.textBox_staffID.Name = "textBox_staffID";
            this.textBox_staffID.ReadOnly = true;
            this.textBox_staffID.Size = new System.Drawing.Size(100, 20);
            this.textBox_staffID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity:";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(299, 55);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.ReadOnly = true;
            this.textBox_date.Size = new System.Drawing.Size(100, 20);
            this.textBox_date.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(518, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox_qty
            // 
            this.textBox_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_qty.Location = new System.Drawing.Point(97, 61);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(100, 21);
            this.textBox_qty.TabIndex = 10;
            this.textBox_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_qty_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.comboBox_item);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_qty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 249);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // comboBox_item
            // 
            this.comboBox_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_item.FormattingEnabled = true;
            this.comboBox_item.Location = new System.Drawing.Point(97, 25);
            this.comboBox_item.Name = "comboBox_item";
            this.comboBox_item.Size = new System.Drawing.Size(604, 24);
            this.comboBox_item.TabIndex = 12;
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(211, 56);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(76, 27);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(39, 347);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(179, 30);
            this.button_submit.TabIndex = 12;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(264, 347);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(179, 30);
            this.button_clear.TabIndex = 13;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(501, 347);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(179, 30);
            this.button_cancel.TabIndex = 14;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 155);
            this.dataGridView1.TabIndex = 13;
            // 
            // RestockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 410);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_staffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RRRLbl);
            this.Name = "RestockRequestForm";
            this.Text = "RestockRequestForm";
            this.Load += new System.EventHandler(this.RestockRequestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RRRLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_staffID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_item;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}