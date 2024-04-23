using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;

namespace WindowsFormsApp1
{
    public partial class Account_ResetPw : UserControl
    {
        
        public Account_ResetPw()
        {
            InitializeComponent();
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            DAO.ResetAccountPassword(Account_ForgetPw.usernameVerify, txtNewPw.Text);
            if (DAO.ResetAccountPassword(Account_ForgetPw.usernameVerify, txtNewPw.Text) == true)
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
                 if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Account_Login"))
                 {
                    Account_Login ALogin = new Account_Login();
                    ALogin.Dock = DockStyle.Fill;
                    Form1.Instance.PnlContainer.Controls.Add(ALogin);
                 }
                Form1.Instance.PnlContainer.Controls["Account_Login"].BringToFront();
            }    
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void txtNewPwRewrite_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPw.Text == txtNewPwRewrite.Text)
            {
                lblNoResetPwRewrite.Visible = false;
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
