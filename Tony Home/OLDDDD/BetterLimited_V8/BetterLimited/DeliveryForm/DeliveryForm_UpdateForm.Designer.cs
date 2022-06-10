
namespace BetterLimited
{
    partial class DeliveryForm_UpdateForm
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
            this.button_cacel = new System.Windows.Forms.Button();
            this.label_DeliveryTime = new System.Windows.Forms.Label();
            this.label_DeliveryDate = new System.Windows.Forms.Label();
            this.label_deliveryStatus = new System.Windows.Forms.Label();
            this.label_CustomerID = new System.Windows.Forms.Label();
            this.label_SalesOrderID = new System.Windows.Forms.Label();
            this.label_DeliveryID = new System.Windows.Forms.Label();
            this.textBox_DeliveryID = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.textbox_CustomerID = new System.Windows.Forms.TextBox();
            this.textBox_SalesOrderID = new System.Windows.Forms.TextBox();
            this.comboBox_deliveryStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker__DeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker__DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 20F);
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update Delivery Record";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 62);
            this.label1.TabIndex = 2;
            // 
            // button_cacel
            // 
            this.button_cacel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cacel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cacel.Location = new System.Drawing.Point(105, 474);
            this.button_cacel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cacel.Name = "button_cacel";
            this.button_cacel.Size = new System.Drawing.Size(139, 30);
            this.button_cacel.TabIndex = 42;
            this.button_cacel.Text = "cancel";
            this.button_cacel.UseVisualStyleBackColor = false;
            this.button_cacel.Click += new System.EventHandler(this.button_cacel_Click);
            // 
            // label_DeliveryTime
            // 
            this.label_DeliveryTime.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeliveryTime.Location = new System.Drawing.Point(123, 342);
            this.label_DeliveryTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DeliveryTime.Name = "label_DeliveryTime";
            this.label_DeliveryTime.Size = new System.Drawing.Size(121, 20);
            this.label_DeliveryTime.TabIndex = 37;
            this.label_DeliveryTime.Text = "DeliveryTime :";
            // 
            // label_DeliveryDate
            // 
            this.label_DeliveryDate.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeliveryDate.Location = new System.Drawing.Point(123, 290);
            this.label_DeliveryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DeliveryDate.Name = "label_DeliveryDate";
            this.label_DeliveryDate.Size = new System.Drawing.Size(121, 20);
            this.label_DeliveryDate.TabIndex = 36;
            this.label_DeliveryDate.Text = "DeliveryDate :";
            // 
            // label_deliveryStatus
            // 
            this.label_deliveryStatus.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deliveryStatus.Location = new System.Drawing.Point(123, 397);
            this.label_deliveryStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_deliveryStatus.Name = "label_deliveryStatus";
            this.label_deliveryStatus.Size = new System.Drawing.Size(121, 20);
            this.label_deliveryStatus.TabIndex = 35;
            this.label_deliveryStatus.Text = "DeliveryStatus :";
            // 
            // label_CustomerID
            // 
            this.label_CustomerID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerID.Location = new System.Drawing.Point(123, 236);
            this.label_CustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CustomerID.Name = "label_CustomerID";
            this.label_CustomerID.Size = new System.Drawing.Size(121, 20);
            this.label_CustomerID.TabIndex = 34;
            this.label_CustomerID.Text = "CustomerID :";
            // 
            // label_SalesOrderID
            // 
            this.label_SalesOrderID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SalesOrderID.Location = new System.Drawing.Point(123, 182);
            this.label_SalesOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SalesOrderID.Name = "label_SalesOrderID";
            this.label_SalesOrderID.Size = new System.Drawing.Size(121, 20);
            this.label_SalesOrderID.TabIndex = 33;
            this.label_SalesOrderID.Text = "SalesOrderID :";
            // 
            // label_DeliveryID
            // 
            this.label_DeliveryID.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeliveryID.Location = new System.Drawing.Point(123, 127);
            this.label_DeliveryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DeliveryID.Name = "label_DeliveryID";
            this.label_DeliveryID.Size = new System.Drawing.Size(121, 20);
            this.label_DeliveryID.TabIndex = 32;
            this.label_DeliveryID.Text = "DeliveryID :";
            // 
            // textBox_DeliveryID
            // 
            this.textBox_DeliveryID.Enabled = false;
            this.textBox_DeliveryID.Location = new System.Drawing.Point(261, 127);
            this.textBox_DeliveryID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DeliveryID.Name = "textBox_DeliveryID";
            this.textBox_DeliveryID.Size = new System.Drawing.Size(140, 22);
            this.textBox_DeliveryID.TabIndex = 31;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Update.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(261, 474);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(139, 30);
            this.button_Update.TabIndex = 30;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textbox_CustomerID
            // 
            this.textbox_CustomerID.Enabled = false;
            this.textbox_CustomerID.Location = new System.Drawing.Point(261, 236);
            this.textbox_CustomerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbox_CustomerID.Name = "textbox_CustomerID";
            this.textbox_CustomerID.Size = new System.Drawing.Size(140, 22);
            this.textbox_CustomerID.TabIndex = 25;
            // 
            // textBox_SalesOrderID
            // 
            this.textBox_SalesOrderID.Enabled = false;
            this.textBox_SalesOrderID.Location = new System.Drawing.Point(261, 182);
            this.textBox_SalesOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_SalesOrderID.Name = "textBox_SalesOrderID";
            this.textBox_SalesOrderID.Size = new System.Drawing.Size(140, 22);
            this.textBox_SalesOrderID.TabIndex = 24;
            // 
            // comboBox_deliveryStatus
            // 
            this.comboBox_deliveryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_deliveryStatus.FormattingEnabled = true;
            this.comboBox_deliveryStatus.Items.AddRange(new object[] {
            "pending",
            "In-transit",
            "delivered"});
            this.comboBox_deliveryStatus.Location = new System.Drawing.Point(261, 399);
            this.comboBox_deliveryStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_deliveryStatus.Name = "comboBox_deliveryStatus";
            this.comboBox_deliveryStatus.Size = new System.Drawing.Size(140, 20);
            this.comboBox_deliveryStatus.TabIndex = 23;
            // 
            // dateTimePicker__DeliveryTime
            // 
            this.dateTimePicker__DeliveryTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker__DeliveryTime.Location = new System.Drawing.Point(261, 342);
            this.dateTimePicker__DeliveryTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker__DeliveryTime.Name = "dateTimePicker__DeliveryTime";
            this.dateTimePicker__DeliveryTime.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker__DeliveryTime.TabIndex = 62;
            // 
            // dateTimePicker__DeliveryDate
            // 
            this.dateTimePicker__DeliveryDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker__DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker__DeliveryDate.Location = new System.Drawing.Point(261, 290);
            this.dateTimePicker__DeliveryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker__DeliveryDate.Name = "dateTimePicker__DeliveryDate";
            this.dateTimePicker__DeliveryDate.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker__DeliveryDate.TabIndex = 61;
            this.dateTimePicker__DeliveryDate.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            // 
            // DeliveryForm_UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 617);
            this.Controls.Add(this.dateTimePicker__DeliveryTime);
            this.Controls.Add(this.dateTimePicker__DeliveryDate);
            this.Controls.Add(this.button_cacel);
            this.Controls.Add(this.label_DeliveryTime);
            this.Controls.Add(this.label_DeliveryDate);
            this.Controls.Add(this.label_deliveryStatus);
            this.Controls.Add(this.label_CustomerID);
            this.Controls.Add(this.label_SalesOrderID);
            this.Controls.Add(this.label_DeliveryID);
            this.Controls.Add(this.textBox_DeliveryID);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textbox_CustomerID);
            this.Controls.Add(this.textBox_SalesOrderID);
            this.Controls.Add(this.comboBox_deliveryStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeliveryForm_UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryForm_Update";
            this.Load += new System.EventHandler(this.DeliveryForm_UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cacel;
        private System.Windows.Forms.Label label_DeliveryTime;
        private System.Windows.Forms.Label label_DeliveryDate;
        private System.Windows.Forms.Label label_deliveryStatus;
        private System.Windows.Forms.Label label_CustomerID;
        private System.Windows.Forms.Label label_SalesOrderID;
        private System.Windows.Forms.Label label_DeliveryID;
        private System.Windows.Forms.TextBox textBox_DeliveryID;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textbox_CustomerID;
        private System.Windows.Forms.TextBox textBox_SalesOrderID;
        private System.Windows.Forms.ComboBox comboBox_deliveryStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker__DeliveryTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker__DeliveryDate;
    }
}