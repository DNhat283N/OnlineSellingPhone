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
    public partial class Account_SignUp : UserControl
    {
        public Account_SignUp()
        {
            InitializeComponent();
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "")
            {
                lblNoFirstname.Visible = true;
            }  
            else { lblNoFirstname.Visible = false; }
            if (txtName.Text == "")
            {
                lblNoName.Visible = true;
            }    
            if (txtPhonenumber.Text == "")
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
        }
    }
}
