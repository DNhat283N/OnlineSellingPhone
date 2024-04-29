using System;
using System.Windows.Forms;
using BusinessLayer;
using System.Text.RegularExpressions;
using System.Linq;

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
         
            if (lblNoName.Visible == false && lblNoEmail.Visible == false && lblNoPhonenumber.Visible == false && lblNoDateOfBirth.Visible == false && lblNoGender.Visible == false && lblNoUsername.Visible == false && lblNoPassword.Visible == false)
            {
                
                DAO.AddSignUpCustomerInformation(txtFirstName.Text, gender, dtpBirthdate.Value, txtUsername.Text.ToLower(), txtPassword.Text, txtEmail.Text, txtPhoneNumber.Text);
                MessageBox.Show("Đăng kí tài khoản thành công");
                Form1.Instance.PnlContainer.Controls.Clear();
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
                MessageBox.Show("Đăng kí tài khoản thất bại, vui lòng kiểm tra lại thông tin đã nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
                

            //DAO.AddSignUpCustomerInformation("ADS", true, DateTime.Now, "Test", "21324132", "Mail test", "1234567891");
            //Console.WriteLine(DAO.IsExistAccount("Test"));
        }



        
        //FirstName
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "")
            {
                lblNoName.Visible = false;
            }
            else
            {
                lblNoName.Visible = true;
            }    
        }


        //Email
        private bool IsValidEmail(string checkEmail)
        {
            //kiểm tra định dạng email
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(checkEmail, pattern);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string checkEmail = txtEmail.Text;
            if (!IsValidEmail(checkEmail))
            {
                lblNoEmail.Text = "Email không hợp lệ";
                lblNoEmail.Visible = true;
            }
            else
            {
                lblNoEmail.Visible = false;
            }   
            if (txtEmail.Text == "")
            {
                lblNoEmail.Text = "Vui lòng nhập Email";
            }    

        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            bool checkIsExistEmail = DAO.IsExistEmail(txtEmail.Text);
            if (checkIsExistEmail == true)
            {
                lblNoEmail.Text = "Email đã được sử dụng cho 1 tài khoản khác";
                lblNoEmail.Visible = true;
            }
        }





        //PhoneNumber
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Length < 10)
            {
                lblNoPhonenumber.Text = "*Vui lòng nhập số điện thoại đủ 10 số";
                lblNoPhonenumber.Visible = true;
            }
            if (txtPhoneNumber.Text == "")
            {
                lblNoPhonenumber.Text = "*Vui lòng nhập số điện thoại";
                
            }    
            
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
                lblNoPhonenumber.Text = "*Vui lòng nhập số";
                lblNoPhonenumber.Visible = true;
            }
            else
                lblNoPhonenumber.Visible = false;
        }



        //Birthdate
        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            lblNoDateOfBirth.Visible = false;
        }


        //Gender
        
        bool gender;
        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {   
            lblNoGender.Visible = false;
            RadioButton selectedRadioButton = pnlGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (selectedRadioButton != null)
            {
                if (selectedRadioButton.Text == "Nam")
                {
                    gender = true;
                }
                else
                    gender = false;
            }
            else
            {
                lblNoGender.Visible = true;
            }    
        }



        //Username
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                lblNoUsername.Visible = false;
            }    
            else
            {
                lblNoUsername.Text = "*Vui lòng nhập tên đăng nhập";
                lblNoUsername.Visible = true;
            }
            txtUsername.Text.ToLower();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            bool checkIsExistAccount = DAO.IsExistAccount(txtUsername.Text.ToLower());
            if (checkIsExistAccount == true)
            {
                lblNoUsername.Text = "*Tài khoản đã tồn tại";
                lblNoUsername.Visible = true;
            }
        }



        //Password
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                lblNoPassword.Visible = false;
            }
            else 
            {
                lblNoPassword.Visible = true;
            }
        }

        
    }
}
