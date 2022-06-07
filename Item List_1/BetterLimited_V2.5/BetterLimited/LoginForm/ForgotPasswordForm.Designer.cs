
namespace BetterLimited
{
    partial class ForgotPasswordForm
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.picShowCPassword = new System.Windows.Forms.PictureBox();
            this.picShowNewPassword = new System.Windows.Forms.PictureBox();
            this.lblNewPasswordWarning = new System.Windows.Forms.Label();
            this.lblCPasswordWarning = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblUsernameWarning = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblForgotUsername = new System.Windows.Forms.Label();
            this.btnGetVerify = new System.Windows.Forms.Button();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.lblVerify = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowCPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 144);
            this.label1.TabIndex = 4;
            this.label1.Text = "Better Limited\r\nForgot Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcon
            // 
            this.picIcon.Image = global::BetterLimited.Properties.Resources.icon;
            this.picIcon.Location = new System.Drawing.Point(357, 2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(90, 90);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 5;
            this.picIcon.TabStop = false;
            // 
            // picShowCPassword
            // 
            this.picShowCPassword.Image = global::BetterLimited.Properties.Resources.show;
            this.picShowCPassword.Location = new System.Drawing.Point(456, 394);
            this.picShowCPassword.Name = "picShowCPassword";
            this.picShowCPassword.Size = new System.Drawing.Size(30, 30);
            this.picShowCPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowCPassword.TabIndex = 33;
            this.picShowCPassword.TabStop = false;
            this.picShowCPassword.Click += new System.EventHandler(this.picShowCPassword_Click);
            // 
            // picShowNewPassword
            // 
            this.picShowNewPassword.Image = global::BetterLimited.Properties.Resources.show;
            this.picShowNewPassword.Location = new System.Drawing.Point(456, 338);
            this.picShowNewPassword.Name = "picShowNewPassword";
            this.picShowNewPassword.Size = new System.Drawing.Size(30, 30);
            this.picShowNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowNewPassword.TabIndex = 32;
            this.picShowNewPassword.TabStop = false;
            this.picShowNewPassword.Click += new System.EventHandler(this.picShowNewPassword_Click);
            // 
            // lblNewPasswordWarning
            // 
            this.lblNewPasswordWarning.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.lblNewPasswordWarning.Location = new System.Drawing.Point(213, 369);
            this.lblNewPasswordWarning.Name = "lblNewPasswordWarning";
            this.lblNewPasswordWarning.Size = new System.Drawing.Size(326, 23);
            this.lblNewPasswordWarning.TabIndex = 31;
            // 
            // lblCPasswordWarning
            // 
            this.lblCPasswordWarning.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.lblCPasswordWarning.Location = new System.Drawing.Point(213, 425);
            this.lblCPasswordWarning.Name = "lblCPasswordWarning";
            this.lblCPasswordWarning.Size = new System.Drawing.Size(326, 23);
            this.lblCPasswordWarning.TabIndex = 30;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(218, 400);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(222, 22);
            this.txtConfirmPassword.TabIndex = 29;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(218, 344);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(222, 22);
            this.txtNewPassword.TabIndex = 28;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblConfirmPassword.Location = new System.Drawing.Point(46, 396);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(160, 28);
            this.lblConfirmPassword.TabIndex = 27;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNewPassword.Location = new System.Drawing.Point(46, 340);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(129, 28);
            this.lblNewPassword.TabIndex = 26;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblUsernameWarning
            // 
            this.lblUsernameWarning.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameWarning.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameWarning.Location = new System.Drawing.Point(213, 259);
            this.lblUsernameWarning.Name = "lblUsernameWarning";
            this.lblUsernameWarning.Size = new System.Drawing.Size(347, 23);
            this.lblUsernameWarning.TabIndex = 36;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(218, 234);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(222, 22);
            this.txtUsername.TabIndex = 35;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUsername.Location = new System.Drawing.Point(46, 230);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 28);
            this.lblUsername.TabIndex = 34;
            this.lblUsername.Text = "Username";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Location = new System.Drawing.Point(609, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 45);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Location = new System.Drawing.Point(609, 447);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 45);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(609, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 45);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblForgotUsername
            // 
            this.lblForgotUsername.AutoSize = true;
            this.lblForgotUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotUsername.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.lblForgotUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblForgotUsername.Location = new System.Drawing.Point(47, 259);
            this.lblForgotUsername.Name = "lblForgotUsername";
            this.lblForgotUsername.Size = new System.Drawing.Size(111, 19);
            this.lblForgotUsername.TabIndex = 40;
            this.lblForgotUsername.Text = "Forgot Username?";
            this.lblForgotUsername.Click += new System.EventHandler(this.lblForgotUsername_Click);
            // 
            // btnGetVerify
            // 
            this.btnGetVerify.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.btnGetVerify.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGetVerify.Location = new System.Drawing.Point(446, 228);
            this.btnGetVerify.Name = "btnGetVerify";
            this.btnGetVerify.Size = new System.Drawing.Size(123, 29);
            this.btnGetVerify.TabIndex = 41;
            this.btnGetVerify.Text = "Get verify code";
            this.btnGetVerify.UseVisualStyleBackColor = true;
            this.btnGetVerify.Click += new System.EventHandler(this.btnGetVerify_Click);
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Location = new System.Drawing.Point(217, 294);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(222, 22);
            this.txtVerifyCode.TabIndex = 43;
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerify.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVerify.Location = new System.Drawing.Point(45, 290);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(104, 28);
            this.lblVerify.TabIndex = 42;
            this.lblVerify.Text = "Verify Code";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.txtVerifyCode);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.btnGetVerify);
            this.Controls.Add(this.lblForgotUsername);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblUsernameWarning);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picShowCPassword);
            this.Controls.Add(this.picShowNewPassword);
            this.Controls.Add(this.lblNewPasswordWarning);
            this.Controls.Add(this.lblCPasswordWarning);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Limited - Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowCPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowNewPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picShowCPassword;
        private System.Windows.Forms.PictureBox picShowNewPassword;
        private System.Windows.Forms.Label lblNewPasswordWarning;
        private System.Windows.Forms.Label lblCPasswordWarning;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblUsernameWarning;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblForgotUsername;
        private System.Windows.Forms.Button btnGetVerify;
        private System.Windows.Forms.TextBox txtVerifyCode;
        private System.Windows.Forms.Label lblVerify;
    }
}