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
    public partial class Account_LoginSuccessfulcs : UserControl
    {
        public Account_LoginSuccessfulcs()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã đăng xuất");
            Account_Login ACLogin = new Account_Login();
            ACLogin.Dock = DockStyle.Fill;
            Form1.Instance.PnlContainer.Controls.Clear();
            Form1.Instance.PnlContainer.Controls.Add(ACLogin);
        }
    }
}
