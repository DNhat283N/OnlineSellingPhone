
namespace WindowsFormsApp1
{
    partial class Account_ResetPw
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPw = new System.Windows.Forms.TextBox();
            this.txtNewPwRewrite = new System.Windows.Forms.TextBox();
            this.btnResetPw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt lại mật khẩu";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(290, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 281);
            this.label2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(349, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(349, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtNewPw
            // 
            this.txtNewPw.Location = new System.Drawing.Point(603, 218);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.Size = new System.Drawing.Size(250, 32);
            this.txtNewPw.TabIndex = 11;
            this.txtNewPw.UseSystemPasswordChar = true;
            // 
            // txtNewPwRewrite
            // 
            this.txtNewPwRewrite.Location = new System.Drawing.Point(603, 275);
            this.txtNewPwRewrite.Name = "txtNewPwRewrite";
            this.txtNewPwRewrite.Size = new System.Drawing.Size(250, 32);
            this.txtNewPwRewrite.TabIndex = 12;
            this.txtNewPwRewrite.UseSystemPasswordChar = true;
            // 
            // btnResetPw
            // 
            this.btnResetPw.Location = new System.Drawing.Point(516, 338);
            this.btnResetPw.Name = "btnResetPw";
            this.btnResetPw.Size = new System.Drawing.Size(170, 58);
            this.btnResetPw.TabIndex = 13;
            this.btnResetPw.Text = "Xác nhận";
            this.btnResetPw.UseVisualStyleBackColor = true;
            // 
            // Account_ResetPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnResetPw);
            this.Controls.Add(this.txtNewPwRewrite);
            this.Controls.Add(this.txtNewPw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Account_ResetPw";
            this.Size = new System.Drawing.Size(1158, 590);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPw;
        private System.Windows.Forms.TextBox txtNewPwRewrite;
        private System.Windows.Forms.Button btnResetPw;
    }
}
