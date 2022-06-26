
namespace BetterLimited
{
    partial class supplierNewForm
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
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RRRLbl
            // 
            this.RRRLbl.BackColor = System.Drawing.SystemColors.Info;
            this.RRRLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRRLbl.Location = new System.Drawing.Point(-30, -7);
            this.RRRLbl.Name = "RRRLbl";
            this.RRRLbl.Size = new System.Drawing.Size(618, 61);
            this.RRRLbl.TabIndex = 32;
            this.RRRLbl.Text = "New Item ";
            this.RRRLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.SystemColors.Info;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(204, 266);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(137, 35);
            this.button_Clear.TabIndex = 55;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(360, 266);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(137, 35);
            this.button_cancel.TabIndex = 54;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(48, 266);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(137, 35);
            this.button_save.TabIndex = 53;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(155, 184);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(175, 20);
            this.txtTel.TabIndex = 63;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 62;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(155, 132);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(364, 20);
            this.txtAddress.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 60;
            this.label4.Text = "Supplier Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 59;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tel No. :";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(39, 57);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 57;
            this.txtSupplierID.Visible = false;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.Red;
            this.label_name.Location = new System.Drawing.Point(153, 110);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(238, 18);
            this.label_name.TabIndex = 64;
            // 
            // label_address
            // 
            this.label_address.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.Color.Red;
            this.label_address.Location = new System.Drawing.Point(153, 163);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(238, 18);
            this.label_address.TabIndex = 65;
            // 
            // label_tel
            // 
            this.label_tel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tel.ForeColor = System.Drawing.Color.Red;
            this.label_tel.Location = new System.Drawing.Point(153, 207);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(238, 18);
            this.label_tel.TabIndex = 66;
            // 
            // supplierNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 385);
            this.Controls.Add(this.label_tel);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.RRRLbl);
            this.Name = "supplierNewForm";
            this.Text = "supplierNewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RRRLbl;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_tel;
    }
}