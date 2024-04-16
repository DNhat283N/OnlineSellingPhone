using System;
using System.Windows.Forms;
using BusinessLayer;

namespace WindowsFormsApp1
{
    public partial class Account_SignUp : UserControl
    {
        public Account_SignUp()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "")
            {
                lblNoFirstname.Visible = true;
            }
            else { lblNoFirstname.Visible = false; }
            if (txtFirstName.Text == "")
            {
                lblNoName.Visible = true;
            }
            if (txtPhoneNumber.Text == "")
            {
                lblNoPhonenumber.Visible = true;
            }
            if (txtUsername.Text == "")
            {
                lblNoUsername.Visible = true;
            }
            if (txtPassword.Text == "")
            {
                lblNoPassword.Visible = true;
            }

            DAO.AddSignUpCustomerInformation("ADS", true, DateTime.Now, "Test", "21324132", "1234567891");
            Console.WriteLine(DAO.IsExistAccount("Test"));
        }
    }
}
