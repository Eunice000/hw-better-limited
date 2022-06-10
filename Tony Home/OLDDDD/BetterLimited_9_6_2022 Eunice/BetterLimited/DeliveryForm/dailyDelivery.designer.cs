
namespace BetterLimited
{
    partial class dailyDelivery
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_dealiyDelivery = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.textBox_Nowdate = new System.Windows.Forms.TextBox();
            this.dateTimePicker__DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label_DeliveryDate = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dealiyDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F);
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daily Delivery";
            // 
            // dataGridView_dealiyDelivery
            // 
            this.dataGridView_dealiyDelivery.AllowUserToAddRows = false;
            this.dataGridView_dealiyDelivery.AllowUserToDeleteRows = false;
            this.dataGridView_dealiyDelivery.AllowUserToResizeRows = false;
            this.dataGridView_dealiyDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_dealiyDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dealiyDelivery.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_dealiyDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_dealiyDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dealiyDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_dealiyDelivery.GridColor = System.Drawing.Color.White;
            this.dataGridView_dealiyDelivery.Location = new System.Drawing.Point(20, 234);
            this.dataGridView_dealiyDelivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_dealiyDelivery.Name = "dataGridView_dealiyDelivery";
            this.dataGridView_dealiyDelivery.ReadOnly = true;
            this.dataGridView_dealiyDelivery.RowHeadersVisible = false;
            this.dataGridView_dealiyDelivery.RowHeadersWidth = 51;
            this.dataGridView_dealiyDelivery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_dealiyDelivery.RowTemplate.Height = 27;
            this.dataGridView_dealiyDelivery.ShowEditingIcon = false;
            this.dataGridView_dealiyDelivery.Size = new System.Drawing.Size(836, 365);
            this.dataGridView_dealiyDelivery.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DeliveryID";
            this.Column1.HeaderText = "DeliveryID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SalesOrderID";
            this.Column2.HeaderText = "SalesOrderID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DeliveryDate";
            this.Column3.HeaderText = "DeliveryDate";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DeliveryTime";
            this.Column4.HeaderText = "DeliveryTime";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DeliveryStatus";
            this.Column5.HeaderText = "DeliveryStatus";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "9:00 - 12:00";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 173);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "13:00 - 17:00";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "18:00 - 22:00";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("PMingLiU", 13F);
            this.label_Date.Location = new System.Drawing.Point(566, 102);
            this.label_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(65, 18);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "Today : ";
            // 
            // textBox_Nowdate
            // 
            this.textBox_Nowdate.Enabled = false;
            this.textBox_Nowdate.Location = new System.Drawing.Point(639, 102);
            this.textBox_Nowdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Nowdate.Name = "textBox_Nowdate";
            this.textBox_Nowdate.Size = new System.Drawing.Size(161, 22);
            this.textBox_Nowdate.TabIndex = 19;
            // 
            // dateTimePicker__DeliveryDate
            // 
            this.dateTimePicker__DeliveryDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker__DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker__DeliveryDate.Location = new System.Drawing.Point(120, 102);
            this.dateTimePicker__DeliveryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker__DeliveryDate.Name = "dateTimePicker__DeliveryDate";
            this.dateTimePicker__DeliveryDate.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker__DeliveryDate.TabIndex = 63;
            this.dateTimePicker__DeliveryDate.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            // 
            // label_DeliveryDate
            // 
            this.label_DeliveryDate.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeliveryDate.Location = new System.Drawing.Point(8, 103);
            this.label_DeliveryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DeliveryDate.Name = "label_DeliveryDate";
            this.label_DeliveryDate.Size = new System.Drawing.Size(121, 20);
            this.label_DeliveryDate.TabIndex = 62;
            this.label_DeliveryDate.Text = "DeliveryDate :";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(263, 103);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(88, 19);
            this.button_Search.TabIndex = 64;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 173);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 30);
            this.button4.TabIndex = 65;
            this.button4.Text = "All Time";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(18, 215);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(46, 12);
            this.lblTimeSlot.TabIndex = 66;
            this.lblTimeSlot.Text = "All Time";
            // 
            // dailyDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.lblTimeSlot);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dateTimePicker__DeliveryDate);
            this.Controls.Add(this.label_DeliveryDate);
            this.Controls.Add(this.textBox_Nowdate);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_dealiyDelivery);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dailyDelivery";
            this.Text = "dailyDelivery";
            this.Load += new System.EventHandler(this.dailyDelivery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dealiyDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.DataGridView dataGridView_dealiyDelivery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_Nowdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker__DeliveryDate;
        private System.Windows.Forms.Label label_DeliveryDate;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTimeSlot;
    }
}