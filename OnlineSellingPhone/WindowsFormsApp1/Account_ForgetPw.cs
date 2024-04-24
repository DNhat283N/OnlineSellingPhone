using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using BusinessLayer;


namespace WindowsFormsApp1
{
    public partial class Account_ForgetPw : UserControl
    {
        public Account_ForgetPw()
        {
            InitializeComponent();
        }


        //static Account_ForgetPw _obj;

        //public static Account_ForgetPw Instance
        //{
        //    get
        //    {
        //        if (_obj == null)
        //        {
        //            _obj = new Account_ForgetPw();
        //        }
        //        return _obj;
        //    }
        //}

        //public TextBox textBoxUsernameVerify
        //{
        //    get { return txtUsernameVerify; }
        //    set { txtUsernameVerify = value; }
        //}
        string randomCode;
        public static string to, usernameVerify;



        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerifyCode.Text).ToString())
            {
                to = DAO.EmailOfAccount(txtUsernameVerify.Text);
                usernameVerify = txtUsernameVerify.Text;
                if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Account_ResetPw"))
                {
                    Account_ResetPw AResetpw = new Account_ResetPw();
                    AResetpw.Dock = DockStyle.Fill;
                    Form1.Instance.PnlContainer.Controls.Add(AResetpw);
                }
                Form1.Instance.PnlContainer.Controls["Account_ResetPw"].BringToFront();
                Form1.Instance.BackButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Mã sai");
            }
           

        }


       

        private void btnSendEmailVerify_Click(object sender, EventArgs e)
        {
            string fromEmail,  passEmail ,messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = DAO.EmailOfAccount(txtUsernameVerify.Text);
            fromEmail = "2151053059tri@ou.edu.vn";
            passEmail = "0913207611";
            messageBody = "Mã đặt lại mật khẩu là: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(fromEmail);
            message.Body = messageBody;
            message.Subject = "Mã đặt lại mật khẩu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromEmail, passEmail);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Đã gửi mã thành công");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
