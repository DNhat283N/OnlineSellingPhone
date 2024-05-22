
namespace WindowsFormsApp1
{
    partial class Account_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNoUsername = new System.Windows.Forms.Label();
            this.lblNoPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbllkSignup = new System.Windows.Forms.LinkLabel();
            this.lbllkForgetPw = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Location = new System.Drawing.Point(445, 175);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(326, 32);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = " Username";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(445, 235);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(326, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = " Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(445, 307);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(214, 51);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblNoUsername
            // 
            this.lblNoUsername.AutoSize = true;
            this.lblNoUsername.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoUsername.ForeColor = System.Drawing.Color.Red;
            this.lblNoUsername.Location = new System.Drawing.Point(481, 210);
            this.lblNoUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoUsername.Name = "lblNoUsername";
            this.lblNoUsername.Size = new System.Drawing.Size(222, 17);
            this.lblNoUsername.TabIndex = 7;
            this.lblNoUsername.Text = "* Vui lòng nhập tên đăng nhập";
            // 
            // lblNoPassword
            // 
            this.lblNoPassword.AutoSize = true;
            this.lblNoPassword.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPassword.ForeColor = System.Drawing.Color.Red;
            this.lblNoPassword.Location = new System.Drawing.Point(481, 270);
            this.lblNoPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPassword.Name = "lblNoPassword";
            this.lblNoPassword.Size = new System.Drawing.Size(180, 17);
            this.lblNoPassword.TabIndex = 8;
            this.lblNoPassword.Text = "* Vui lòng nhập mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bạn chưa có tài khoản ?";
            // 
            // lbllkSignup
            // 
            this.lbllkSignup.AutoSize = true;
            this.lbllkSignup.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbllkSignup.LinkColor = System.Drawing.Color.Red;
            this.lbllkSignup.Location = new System.Drawing.Point(630, 388);
            this.lbllkSignup.Margin = new System.Windows.Forms.Padding(0);
            this.lbllkSignup.Name = "lbllkSignup";
            this.lbllkSignup.Size = new System.Drawing.Size(73, 21);
            this.lbllkSignup.TabIndex = 11;
            this.lbllkSignup.TabStop = true;
            this.lbllkSignup.Text = "Đăng kí";
            this.lbllkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllkSignup_LinkClicked);
            // 
            // lbllkForgetPw
            // 
            this.lbllkForgetPw.AutoSize = true;
            this.lbllkForgetPw.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbllkForgetPw.LinkColor = System.Drawing.Color.Black;
            this.lbllkForgetPw.Location = new System.Drawing.Point(640, 270);
            this.lbllkForgetPw.Margin = new System.Windows.Forms.Padding(0);
            this.lbllkForgetPw.Name = "lbllkForgetPw";
            this.lbllkForgetPw.Size = new System.Drawing.Size(155, 21);
            this.lbllkForgetPw.TabIndex = 12;
            this.lbllkForgetPw.TabStop = true;
            this.lbllkForgetPw.Text = "Quên mật khẩu ? ";
            this.lbllkForgetPw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllkForgetPw_LinkClicked);
            // 
            // Account_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbllkForgetPw);
            this.Controls.Add(this.lbllkSignup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNoPassword);
            this.Controls.Add(this.lblNoUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Account_Login";
            this.Size = new System.Drawing.Size(1158, 590);
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNoUsername;
        private System.Windows.Forms.Label lblNoPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbllkSignup;
        private System.Windows.Forms.LinkLabel lbllkForgetPw;
    }
}
