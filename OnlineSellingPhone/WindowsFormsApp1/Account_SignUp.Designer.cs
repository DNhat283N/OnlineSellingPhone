
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNoEmail = new System.Windows.Forms.Label();
            this.lblNoDateOfBirth = new System.Windows.Forms.Label();
            this.lblNoGender = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.pnlGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoPassword
            // 
            this.lblNoPassword.AutoSize = true;
            this.lblNoPassword.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPassword.ForeColor = System.Drawing.Color.Red;
            this.lblNoPassword.Location = new System.Drawing.Point(529, 471);
            this.lblNoPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPassword.Name = "lblNoPassword";
            this.lblNoPassword.Size = new System.Drawing.Size(180, 17);
            this.lblNoPassword.TabIndex = 41;
            this.lblNoPassword.Text = "* Vui lòng nhập mật khẩu";
            // 
            // lblNoUsername
            // 
            this.lblNoUsername.AutoSize = true;
            this.lblNoUsername.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoUsername.ForeColor = System.Drawing.Color.Red;
            this.lblNoUsername.Location = new System.Drawing.Point(529, 414);
            this.lblNoUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoUsername.Name = "lblNoUsername";
            this.lblNoUsername.Size = new System.Drawing.Size(222, 17);
            this.lblNoUsername.TabIndex = 40;
            this.lblNoUsername.Text = "* Vui lòng nhập tên đăng nhập";
            // 
            // lblNoPhonenumber
            // 
            this.lblNoPhonenumber.AutoSize = true;
            this.lblNoPhonenumber.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPhonenumber.ForeColor = System.Drawing.Color.Red;
            this.lblNoPhonenumber.Location = new System.Drawing.Point(528, 250);
            this.lblNoPhonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPhonenumber.Name = "lblNoPhonenumber";
            this.lblNoPhonenumber.Size = new System.Drawing.Size(202, 17);
            this.lblNoPhonenumber.TabIndex = 39;
            this.lblNoPhonenumber.Text = "* Vui lòng nhập số điện thoại";
            // 
            // lblNoName
            // 
            this.lblNoName.AutoSize = true;
            this.lblNoName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoName.ForeColor = System.Drawing.Color.Red;
            this.lblNoName.Location = new System.Drawing.Point(528, 140);
            this.lblNoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoName.Name = "lblNoName";
            this.lblNoName.Size = new System.Drawing.Size(140, 17);
            this.lblNoName.TabIndex = 38;
            this.lblNoName.Text = "* Vui lòng nhập tên";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(466, 498);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(214, 51);
            this.btnSignUp.TabIndex = 38;
            this.btnSignUp.Text = "Đăng kí";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(475, 270);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(315, 32);
            this.dtpBirthdate.TabIndex = 34;
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.dtpBirthdate_ValueChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(476, 436);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 32);
            this.txtPassword.TabIndex = 37;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(476, 379);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(315, 32);
            this.txtUsername.TabIndex = 36;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(475, 215);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(315, 32);
            this.txtPhoneNumber.TabIndex = 33;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(475, 105);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(315, 32);
            this.txtFirstName.TabIndex = 31;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 270);
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
            this.label4.Location = new System.Drawing.Point(310, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 439);
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
            this.label2.Location = new System.Drawing.Point(310, 388);
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
            this.label1.Location = new System.Drawing.Point(514, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "Đăng kí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Giới tính";
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(3, 3);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(79, 27);
            this.rdbtnMale.TabIndex = 35;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Nam";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            this.rdbtnMale.CheckedChanged += new System.EventHandler(this.rdbtnMale_CheckedChanged);
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(98, 3);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(55, 27);
            this.rdbtnFemale.TabIndex = 44;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Nữ";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            this.rdbtnFemale.CheckedChanged += new System.EventHandler(this.rdbtnMale_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(475, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 32);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblNoEmail
            // 
            this.lblNoEmail.AutoSize = true;
            this.lblNoEmail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEmail.ForeColor = System.Drawing.Color.Red;
            this.lblNoEmail.Location = new System.Drawing.Point(528, 195);
            this.lblNoEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoEmail.Name = "lblNoEmail";
            this.lblNoEmail.Size = new System.Drawing.Size(156, 17);
            this.lblNoEmail.TabIndex = 47;
            this.lblNoEmail.Text = "* Vui lòng nhập email";
            // 
            // lblNoDateOfBirth
            // 
            this.lblNoDateOfBirth.AutoSize = true;
            this.lblNoDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDateOfBirth.ForeColor = System.Drawing.Color.Red;
            this.lblNoDateOfBirth.Location = new System.Drawing.Point(528, 305);
            this.lblNoDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoDateOfBirth.Name = "lblNoDateOfBirth";
            this.lblNoDateOfBirth.Size = new System.Drawing.Size(184, 17);
            this.lblNoDateOfBirth.TabIndex = 48;
            this.lblNoDateOfBirth.Text = "* Vui lòng chỉnh ngày sinh";
            // 
            // lblNoGender
            // 
            this.lblNoGender.AutoSize = true;
            this.lblNoGender.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoGender.ForeColor = System.Drawing.Color.Red;
            this.lblNoGender.Location = new System.Drawing.Point(529, 357);
            this.lblNoGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoGender.Name = "lblNoGender";
            this.lblNoGender.Size = new System.Drawing.Size(169, 17);
            this.lblNoGender.TabIndex = 49;
            this.lblNoGender.Text = "* Vui lòng chọn giới tính";
            // 
            // pnlGender
            // 
            this.pnlGender.BackColor = System.Drawing.Color.Transparent;
            this.pnlGender.Controls.Add(this.rdbtnFemale);
            this.pnlGender.Controls.Add(this.rdbtnMale);
            this.pnlGender.Location = new System.Drawing.Point(493, 322);
            this.pnlGender.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(205, 35);
            this.pnlGender.TabIndex = 35;
            // 
            // Account_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoGender);
            this.Controls.Add(this.lblNoDateOfBirth);
            this.Controls.Add(this.lblNoEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNoPassword);
            this.Controls.Add(this.lblNoUsername);
            this.Controls.Add(this.lblNoPhonenumber);
            this.Controls.Add(this.lblNoName);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGender);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Account_SignUp";
            this.Size = new System.Drawing.Size(1158, 590);
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoPassword;
        private System.Windows.Forms.Label lblNoUsername;
        private System.Windows.Forms.Label lblNoPhonenumber;
        private System.Windows.Forms.Label lblNoName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNoEmail;
        private System.Windows.Forms.Label lblNoDateOfBirth;
        private System.Windows.Forms.Label lblNoGender;
        private System.Windows.Forms.Panel pnlGender;
    }
}
