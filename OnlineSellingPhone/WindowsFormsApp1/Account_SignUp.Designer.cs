
namespace WindowsFormsApp1
{
    partial class Account_SignUp
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
            this.lblNoPassword = new System.Windows.Forms.Label();
            this.lblNoUsername = new System.Windows.Forms.Label();
            this.lblNoPhonenumber = new System.Windows.Forms.Label();
            this.lblNoName = new System.Windows.Forms.Label();
            this.lblNoFirstname = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoPassword
            // 
            this.lblNoPassword.AutoSize = true;
            this.lblNoPassword.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPassword.ForeColor = System.Drawing.Color.Red;
            this.lblNoPassword.Location = new System.Drawing.Point(528, 425);
            this.lblNoPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPassword.Name = "lblNoPassword";
            this.lblNoPassword.Size = new System.Drawing.Size(180, 17);
            this.lblNoPassword.TabIndex = 41;
            this.lblNoPassword.Text = "* Vui lòng nhập mật khẩu";
            this.lblNoPassword.Visible = false;
            // 
            // lblNoUsername
            // 
            this.lblNoUsername.AutoSize = true;
            this.lblNoUsername.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoUsername.ForeColor = System.Drawing.Color.Red;
            this.lblNoUsername.Location = new System.Drawing.Point(528, 368);
            this.lblNoUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoUsername.Name = "lblNoUsername";
            this.lblNoUsername.Size = new System.Drawing.Size(222, 17);
            this.lblNoUsername.TabIndex = 40;
            this.lblNoUsername.Text = "* Vui lòng nhập tên đăng nhập";
            this.lblNoUsername.Visible = false;
            // 
            // lblNoPhonenumber
            // 
            this.lblNoPhonenumber.AutoSize = true;
            this.lblNoPhonenumber.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPhonenumber.ForeColor = System.Drawing.Color.Red;
            this.lblNoPhonenumber.Location = new System.Drawing.Point(528, 270);
            this.lblNoPhonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPhonenumber.Name = "lblNoPhonenumber";
            this.lblNoPhonenumber.Size = new System.Drawing.Size(202, 17);
            this.lblNoPhonenumber.TabIndex = 39;
            this.lblNoPhonenumber.Text = "* Vui lòng nhập số điện thoại";
            this.lblNoPhonenumber.Visible = false;
            // 
            // lblNoName
            // 
            this.lblNoName.AutoSize = true;
            this.lblNoName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoName.ForeColor = System.Drawing.Color.Red;
            this.lblNoName.Location = new System.Drawing.Point(528, 216);
            this.lblNoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoName.Name = "lblNoName";
            this.lblNoName.Size = new System.Drawing.Size(140, 17);
            this.lblNoName.TabIndex = 38;
            this.lblNoName.Text = "* Vui lòng nhập tên";
            this.lblNoName.Visible = false;
            // 
            // lblNoFirstname
            // 
            this.lblNoFirstname.AutoSize = true;
            this.lblNoFirstname.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFirstname.ForeColor = System.Drawing.Color.Red;
            this.lblNoFirstname.Location = new System.Drawing.Point(528, 159);
            this.lblNoFirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoFirstname.Name = "lblNoFirstname";
            this.lblNoFirstname.Size = new System.Drawing.Size(134, 17);
            this.lblNoFirstname.TabIndex = 37;
            this.lblNoFirstname.Text = "* Vui lòng nhập họ";
            this.lblNoFirstname.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(475, 466);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(214, 51);
            this.btnLogin.TabIndex = 36;
            this.btnLogin.Text = "Đăng kí";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(475, 290);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(315, 32);
            this.dtpBirthdate.TabIndex = 35;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(475, 390);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 32);
            this.txtPassword.TabIndex = 34;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(475, 333);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(315, 32);
            this.txtUsername.TabIndex = 33;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhonenumber.Location = new System.Drawing.Point(475, 235);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(315, 32);
            this.txtPhonenumber.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(475, 181);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(315, 32);
            this.txtName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tên";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(475, 124);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(315, 32);
            this.txtFirstname.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Họ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "Đăng kí";
            // 
            // Account_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoPassword);
            this.Controls.Add(this.lblNoUsername);
            this.Controls.Add(this.lblNoPhonenumber);
            this.Controls.Add(this.lblNoName);
            this.Controls.Add(this.lblNoFirstname);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Account_SignUp";
            this.Size = new System.Drawing.Size(1158, 590);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoPassword;
        private System.Windows.Forms.Label lblNoUsername;
        private System.Windows.Forms.Label lblNoPhonenumber;
        private System.Windows.Forms.Label lblNoName;
        private System.Windows.Forms.Label lblNoFirstname;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
