using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace WindowsFormsApp1
{

    public partial class Mall : UserControl
    {
        public Mall()
        {
            InitializeComponent();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == " Tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }    

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm";
                txtSearch.ForeColor = Color.DarkGray;
            }    
        }

        private void btnPricefilter_Click(object sender, EventArgs e)
        {
            string Pricefilter = btnPricefilter.Text;
            switch (Pricefilter)
            {
                case "Giá ↑↓":
                    btnPricefilter.Text = "Giá ↑";
                    btnPricefilter.ForeColor = Color.Red;
                    break;
                case "Giá ↑":
                    btnPricefilter.Text = "Giá ↓";
                    btnPricefilter.ForeColor = Color.Red;
                    break;
                case "Giá ↓":
                    btnPricefilter.Text = "Giá ↑↓";
                    btnPricefilter.ForeColor = Color.Black;
                    break;
            }
        }


        bool buttonClicked = false;
        private void btnSamsung_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                btnSamsung.BackgroundColor = Color.DarkGray;
                btnIphone.Enabled = false;
                btnOppo.Enabled = false;
                btnXiaomi.Enabled = false;
                btnRealme.Enabled = false;
                buttonClicked = true;
            }    
            else
            {
                btnSamsung.BackgroundColor = Color.White;
                btnIphone.Enabled = true;
                btnOppo.Enabled = true;
                btnXiaomi.Enabled = true;
                btnRealme.Enabled = true;
                buttonClicked = false;
            }    
        }

        private void btnIphone_Click(object sender, EventArgs e)
        {
            btnIphone.BackgroundColor = Color.DarkGray;
            if (buttonClicked == false)
            {
                btnIphone.BackgroundColor = Color.DarkGray;
                btnSamsung.Enabled = false;
                btnOppo.Enabled = false;
                btnXiaomi.Enabled = false;
                btnRealme.Enabled = false;
                buttonClicked = true;
            }
            else
            {
                btnIphone.BackgroundColor = Color.White;
                btnSamsung.Enabled = true;
                btnOppo.Enabled = true;
                btnXiaomi.Enabled = true;
                btnRealme.Enabled = true;
                buttonClicked = false;
            }
        }

        private void btnOppo_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                btnOppo.BackgroundColor = Color.DarkGray;
                btnSamsung.Enabled = false;
                btnIphone.Enabled = false;
                btnXiaomi.Enabled = false;
                btnRealme.Enabled = false;
                buttonClicked = true;
            }
            else
            {
                btnOppo.BackgroundColor = Color.White;
                btnSamsung.Enabled = true;
                btnIphone.Enabled = true;
                btnXiaomi.Enabled = true;
                btnRealme.Enabled = true;
                buttonClicked = false;
            }
        }

        private void btnXiaomi_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                btnXiaomi.BackgroundColor = Color.DarkGray;
                btnSamsung.Enabled = false;
                btnIphone.Enabled = false;
                btnOppo.Enabled = false;
                btnRealme.Enabled = false;
                buttonClicked = true;
            }
            else
            {
                btnXiaomi.BackgroundColor = Color.White;
                btnSamsung.Enabled = true;
                btnIphone.Enabled = true;
                btnOppo.Enabled = true;
                btnRealme.Enabled = true;
                buttonClicked = false;
            }
        }

        private void btnRealme_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                btnRealme.BackgroundColor = Color.DarkGray;
                btnSamsung.Enabled = false;
                btnIphone.Enabled = false;
                btnOppo.Enabled = false;
                btnXiaomi.Enabled = false;
                buttonClicked = true;
            }
            else
            {
                btnRealme.BackgroundColor = Color.White;
                btnSamsung.Enabled = true;
                btnIphone.Enabled = true;
                btnOppo.Enabled = true;
                btnXiaomi.Enabled = true;
                buttonClicked = false;
            }
        }
    }
}
