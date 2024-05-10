using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Account_Login : UserControl
    {
        public Account_Login()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

 

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == " Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }    

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = " Username";
                txtUsername.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == " Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }    
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = " Password";
                txtPassword.ForeColor = Color.DarkGray;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lblNoUsername.Visible == false && lblNoPassword.Visible == false)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin đăng nhập");
            } 
            
                
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbllkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Account_SignUp"))
            {
                Account_SignUp ASignUp = new Account_SignUp();
                ASignUp.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ASignUp);
            }
            Form1.Instance.PnlContainer.Controls["Account_SignUp"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }


        private void lbllkForgetPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Account_ForgetPw"))
            {
                Account_ForgetPw AForgetPw = new Account_ForgetPw();
                AForgetPw.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(AForgetPw);
            }
            Form1.Instance.PnlContainer.Controls["Account_ForgetPw"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtUsername.Text == " Username")
            {
                lblNoUsername.Visible = true;
            }
            else
            {
                lblNoUsername.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtPassword.Text == " Password")
            {
                lblNoPassword.Visible = true;
            }
            else
            {
                lblNoPassword.Visible = false;
            }
        }
    }
}
