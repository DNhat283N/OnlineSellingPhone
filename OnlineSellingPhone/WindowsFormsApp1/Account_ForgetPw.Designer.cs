
namespace WindowsFormsApp1
{
    partial class Account_ForgetPw
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameVerify = new System.Windows.Forms.TextBox();
            this.btnSendEmailVerify = new System.Windows.Forms.Button();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.btnVerifyCode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm mật khẩu";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(315, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 381);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(336, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập tên đăng nhập tài khoản người dùng của bạn và chúng tôi sẽ gửi cho bạn mã xá" +
    "c thực đặt lại mật khẩu qua email của tài khoản";
            // 
            // txtUsernameVerify
            // 
            this.txtUsernameVerify.Location = new System.Drawing.Point(541, 227);
            this.txtUsernameVerify.Name = "txtUsernameVerify";
            this.txtUsernameVerify.Size = new System.Drawing.Size(235, 32);
            this.txtUsernameVerify.TabIndex = 3;
            // 
            // btnSendEmailVerify
            // 
            this.btnSendEmailVerify.Location = new System.Drawing.Point(496, 277);
            this.btnSendEmailVerify.Name = "btnSendEmailVerify";
            this.btnSendEmailVerify.Size = new System.Drawing.Size(113, 46);
            this.btnSendEmailVerify.TabIndex = 4;
            this.btnSendEmailVerify.Text = "Xác nhận";
            this.btnSendEmailVerify.UseVisualStyleBackColor = true;
            this.btnSendEmailVerify.Click += new System.EventHandler(this.btnSendEmailVerify_Click);
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Location = new System.Drawing.Point(541, 350);
            this.txtVerifyCode.MaxLength = 6;
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(235, 32);
            this.txtVerifyCode.TabIndex = 5;
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.Location = new System.Drawing.Point(496, 412);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(113, 51);
            this.btnVerifyCode.TabIndex = 6;
            this.btnVerifyCode.Text = "Xác thực";
            this.btnVerifyCode.UseVisualStyleBackColor = true;
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(366, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã xác thực";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(366, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên đăng nhập";
            // 
            // Account_ForgetPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerifyCode);
            this.Controls.Add(this.txtVerifyCode);
            this.Controls.Add(this.btnSendEmailVerify);
            this.Controls.Add(this.txtUsernameVerify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Account_ForgetPw";
            this.Size = new System.Drawing.Size(1158, 590);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernameVerify;
        private System.Windows.Forms.Button btnSendEmailVerify;
        private System.Windows.Forms.TextBox txtVerifyCode;
        private System.Windows.Forms.Button btnVerifyCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
