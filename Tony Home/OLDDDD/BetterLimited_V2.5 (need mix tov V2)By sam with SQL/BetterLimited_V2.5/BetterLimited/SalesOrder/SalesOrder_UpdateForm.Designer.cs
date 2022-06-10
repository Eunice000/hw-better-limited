
namespace BetterLimited
{
    partial class SalesOrder_UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_PaymentStatus = new System.Windows.Forms.ComboBox();
            this.textBox_StoreID = new System.Windows.Forms.TextBox();
            this.textbox_StaffID = new System.Windows.Forms.TextBox();
            this.textBox_PaidAmt = new System.Windows.Forms.TextBox();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.textBox_CustomerID = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_salesorderID = new System.Windows.Forms.TextBox();
            this.label_salesorderID = new System.Windows.Forms.Label();
            this.label_StoreID = new System.Windows.Forms.Label();
            this.label_StaffID = new System.Windows.Forms.Label();
            this.label_PaidAmt = new System.Windows.Forms.Label();
            this.label_PaymentStatus = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_CustomerID = new System.Windows.Forms.Label();
            this.label_ExpDate = new System.Windows.Forms.Label();
            this.textBox__ExpDate = new System.Windows.Forms.TextBox();
            this.button_cacel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 77);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 20F);
            this.label2.Location = new System.Drawing.Point(31, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Update SalesOrder Record";
            // 
            // comboBox_PaymentStatus
            // 
            this.comboBox_PaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PaymentStatus.FormattingEnabled = true;
            this.comboBox_PaymentStatus.Items.AddRange(new object[] {
            "Null",
            "order",
            "settled"});
            this.comboBox_PaymentStatus.Location = new System.Drawing.Point(276, 273);
            this.comboBox_PaymentStatus.Name = "comboBox_PaymentStatus";
            this.comboBox_PaymentStatus.Size = new System.Drawing.Size(185, 23);
            this.comboBox_PaymentStatus.TabIndex = 2;
            // 
            // textBox_StoreID
            // 
            this.textBox_StoreID.Location = new System.Drawing.Point(276, 183);
            this.textBox_StoreID.Name = "textBox_StoreID";
            this.textBox_StoreID.Size = new System.Drawing.Size(185, 25);
            this.textBox_StoreID.TabIndex = 4;
            // 
            // textbox_StaffID
            // 
            this.textbox_StaffID.Location = new System.Drawing.Point(276, 228);
            this.textbox_StaffID.Name = "textbox_StaffID";
            this.textbox_StaffID.Size = new System.Drawing.Size(185, 25);
            this.textbox_StaffID.TabIndex = 5;
            // 
            // textBox_PaidAmt
            // 
            this.textBox_PaidAmt.Location = new System.Drawing.Point(276, 316);
            this.textBox_PaidAmt.Name = "textBox_PaidAmt";
            this.textBox_PaidAmt.Size = new System.Drawing.Size(185, 25);
            this.textBox_PaidAmt.TabIndex = 6;
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(276, 361);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(185, 25);
            this.textBox_Date.TabIndex = 7;
            // 
            // textBox_Time
            // 
            this.textBox_Time.Location = new System.Drawing.Point(276, 406);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(185, 25);
            this.textBox_Time.TabIndex = 8;
            // 
            // textBox_CustomerID
            // 
            this.textBox_CustomerID.Location = new System.Drawing.Point(276, 498);
            this.textBox_CustomerID.Name = "textBox_CustomerID";
            this.textBox_CustomerID.Size = new System.Drawing.Size(185, 25);
            this.textBox_CustomerID.TabIndex = 9;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Update.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(276, 567);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(185, 38);
            this.button_Update.TabIndex = 10;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_salesorderID
            // 
            this.textBox_salesorderID.Enabled = false;
            this.textBox_salesorderID.Location = new System.Drawing.Point(276, 138);
            this.textBox_salesorderID.Name = "textBox_salesorderID";
            this.textBox_salesorderID.Size = new System.Drawing.Size(185, 25);
            this.textBox_salesorderID.TabIndex = 11;
            // 
            // label_salesorderID
            // 
            this.label_salesorderID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salesorderID.Location = new System.Drawing.Point(92, 138);
            this.label_salesorderID.Name = "label_salesorderID";
            this.label_salesorderID.Size = new System.Drawing.Size(161, 25);
            this.label_salesorderID.TabIndex = 12;
            this.label_salesorderID.Text = "SalesOrderID :";
            // 
            // label_StoreID
            // 
            this.label_StoreID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoreID.Location = new System.Drawing.Point(92, 183);
            this.label_StoreID.Name = "label_StoreID";
            this.label_StoreID.Size = new System.Drawing.Size(161, 25);
            this.label_StoreID.TabIndex = 13;
            this.label_StoreID.Text = "StoreID :";
            // 
            // label_StaffID
            // 
            this.label_StaffID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StaffID.Location = new System.Drawing.Point(92, 228);
            this.label_StaffID.Name = "label_StaffID";
            this.label_StaffID.Size = new System.Drawing.Size(161, 25);
            this.label_StaffID.TabIndex = 14;
            this.label_StaffID.Text = "StaffID :";
            // 
            // label_PaidAmt
            // 
            this.label_PaidAmt.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PaidAmt.Location = new System.Drawing.Point(92, 318);
            this.label_PaidAmt.Name = "label_PaidAmt";
            this.label_PaidAmt.Size = new System.Drawing.Size(161, 25);
            this.label_PaidAmt.TabIndex = 16;
            this.label_PaidAmt.Text = "PaidAmount :";
            // 
            // label_PaymentStatus
            // 
            this.label_PaymentStatus.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PaymentStatus.Location = new System.Drawing.Point(92, 273);
            this.label_PaymentStatus.Name = "label_PaymentStatus";
            this.label_PaymentStatus.Size = new System.Drawing.Size(161, 25);
            this.label_PaymentStatus.TabIndex = 15;
            this.label_PaymentStatus.Text = "PaymentStatus :";
            // 
            // label_Time
            // 
            this.label_Time.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(92, 408);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(161, 25);
            this.label_Time.TabIndex = 18;
            this.label_Time.Text = "Time :";
            // 
            // label_Date
            // 
            this.label_Date.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(92, 363);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(161, 25);
            this.label_Date.TabIndex = 17;
            this.label_Date.Text = "Date :";
            // 
            // label_CustomerID
            // 
            this.label_CustomerID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerID.Location = new System.Drawing.Point(92, 498);
            this.label_CustomerID.Name = "label_CustomerID";
            this.label_CustomerID.Size = new System.Drawing.Size(161, 23);
            this.label_CustomerID.TabIndex = 19;
            this.label_CustomerID.Text = "CustomerID :";
            // 
            // label_ExpDate
            // 
            this.label_ExpDate.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ExpDate.Location = new System.Drawing.Point(92, 453);
            this.label_ExpDate.Name = "label_ExpDate";
            this.label_ExpDate.Size = new System.Drawing.Size(161, 25);
            this.label_ExpDate.TabIndex = 21;
            this.label_ExpDate.Text = "ExpDate :";
            // 
            // textBox__ExpDate
            // 
            this.textBox__ExpDate.Location = new System.Drawing.Point(276, 451);
            this.textBox__ExpDate.Name = "textBox__ExpDate";
            this.textBox__ExpDate.Size = new System.Drawing.Size(185, 25);
            this.textBox__ExpDate.TabIndex = 20;
            // 
            // button_cacel
            // 
            this.button_cacel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cacel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cacel.Location = new System.Drawing.Point(68, 567);
            this.button_cacel.Name = "button_cacel";
            this.button_cacel.Size = new System.Drawing.Size(185, 38);
            this.button_cacel.TabIndex = 22;
            this.button_cacel.Text = "cancel";
            this.button_cacel.UseVisualStyleBackColor = false;
            this.button_cacel.Click += new System.EventHandler(this.button_cacel_Click);
            // 
            // SalesOrder_UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 690);
            this.Controls.Add(this.button_cacel);
            this.Controls.Add(this.label_ExpDate);
            this.Controls.Add(this.textBox__ExpDate);
            this.Controls.Add(this.label_CustomerID);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_PaidAmt);
            this.Controls.Add(this.label_PaymentStatus);
            this.Controls.Add(this.label_StaffID);
            this.Controls.Add(this.label_StoreID);
            this.Controls.Add(this.label_salesorderID);
            this.Controls.Add(this.textBox_salesorderID);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_CustomerID);
            this.Controls.Add(this.textBox_Time);
            this.Controls.Add(this.textBox_Date);
            this.Controls.Add(this.textBox_PaidAmt);
            this.Controls.Add(this.textbox_StaffID);
            this.Controls.Add(this.textBox_StoreID);
            this.Controls.Add(this.comboBox_PaymentStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalesOrder_UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesOrder_UpdateForm";
            this.Load += new System.EventHandler(this.SalesOrder_UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_PaymentStatus;
        private System.Windows.Forms.TextBox textBox_StoreID;
        private System.Windows.Forms.TextBox textbox_StaffID;
        private System.Windows.Forms.TextBox textBox_PaidAmt;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.TextBox textBox_CustomerID;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_salesorderID;
        private System.Windows.Forms.Label label_salesorderID;
        private System.Windows.Forms.Label label_StoreID;
        private System.Windows.Forms.Label label_StaffID;
        private System.Windows.Forms.Label label_PaidAmt;
        private System.Windows.Forms.Label label_PaymentStatus;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_CustomerID;
        private System.Windows.Forms.Label label_ExpDate;
        private System.Windows.Forms.TextBox textBox__ExpDate;
        private System.Windows.Forms.Button button_cacel;
    }
}