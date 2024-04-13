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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        static Form1 _obj;
        
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        


        Home FormHome = new Home();
        private void Form1_Load(object sender, EventArgs e)
        {
            //btnBack.Visible = false;
            //_obj = this;
            //Account_Login ALogin = new Account_Login();
            //ALogin.Dock = DockStyle.Fill;
            //panelContainer.Controls.Add(ALogin);
            _obj = this;
            FormHome.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(FormHome);
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            _obj = this;
            FormHome.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(FormHome);
        }

        private void btnMall_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMall.Height;
            SidePanel.Top = btnMall.Top;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCart.Height;
            SidePanel.Top = btnCart.Top;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAccount.Height;
            SidePanel.Top = btnAccount.Top;
            btnBack.Visible = false;
            _obj = this;
            Account_Login ALogin = new Account_Login();
            ALogin.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(ALogin);
        }

        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["Account_Login"].BringToFront();
            btnBack.Visible = false;
        }

        private void panelContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            btnBack.Visible = false;
        }
    }
}
