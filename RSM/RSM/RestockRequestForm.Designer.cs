
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
            this.RRFLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RRFLbl
            // 
            this.RRFLbl.BackColor = System.Drawing.SystemColors.Info;
            this.RRFLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRFLbl.Location = new System.Drawing.Point(-2, -4);
            this.RRFLbl.Name = "RRFLbl";
            this.RRFLbl.Size = new System.Drawing.Size(803, 46);
            this.RRFLbl.TabIndex = 1;
            this.RRFLbl.Text = "Restock Request Form";
            this.RRFLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RRFLbl);
            this.Name = "RestockRequestForm";
            this.Text = "RestockRequestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RRFLbl;
    }
}