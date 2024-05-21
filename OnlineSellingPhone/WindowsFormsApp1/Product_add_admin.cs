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
    public partial class Product_add_admin : UserControl
    {
        public Product_add_admin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Product_admin"))
            //{
                Product_admin Product_admin = new Product_admin();
                Product_admin.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Clear();
                Form1.Instance.PnlContainer.Controls.Add(Product_admin);
            //}
            Form1.Instance.PnlContainer.Controls["Product_admin"].BringToFront();
        }

        //private void txtColor_TextChanged(object sender, EventArgs e)
        //{
        //    if (!txtColor.Text.StartsWith("#"))
        //    {
        //        txtColor.Text = "#";
        //        txtColor.SelectionStart = txtColor.Text.Length;
        //    }    
        //    if (txtColor.Text == "#")
        //    {
        //        lblNoColor.Visible = true;
        //    }    
        //    else
        //    {
        //        lblNoColor.Visible = false;
        //    }    
        //}

     

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblNoName.Visible == false && lblNoManufacturer.Visible == false && lblNoColor.Visible == false && lblNoPrice.Visible == false && lblNoQuantity.Visible == false && lblNoLinkImage1.Visible == false && lblNoLinkImage2.Visible == false && lblNoRAM.Visible == false && lblNoROM.Visible == false && lblNoStorage.Visible == false && lblNoBattery.Visible == false)
            {
                MessageBox.Show("Thêm sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại! Vui lòng kiểm tra lại thông tin đã nhập");
            }    
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                lblNoName.Visible = true;
            }    
            else
            {
                lblNoName.Visible = false;
            }    
        }

     


        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                lblNoPrice.Visible = true;
            }    
            else
            {
                lblNoPrice.Visible = false;
            }    
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (nudQuantity.Value == 0)
            {
                lblNoQuantity.Visible = true;
            }    
            else
            {
                lblNoQuantity.Visible = false;
            }    
        }

        private void cbbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbManufacturer_TextChanged(object sender, EventArgs e)
        {
            if (cbbManufacturer.Text == "")
            {
                lblNoManufacturer.Visible = true;
            }
            else
            {
                lblNoManufacturer.Visible = false;
            }
        }

        private void cbbColor_TextChanged(object sender, EventArgs e)
        {
            if (cbbColor.Text == "")
            {
                lblNoColor.Visible = true;
            }
            else
            {
                lblNoColor.Visible = false;
            }
        }



        private void txtRAM_TextChanged(object sender, EventArgs e)
        {
            if (txtRAM.Text == "")
            {
                lblNoRAM.Visible = true;
            }
            else
            {
                lblNoRAM.Visible = false;
            }
        }

        private void txtROM_TextChanged(object sender, EventArgs e)
        {
            if (txtROM.Text == "")
            {
                lblNoROM.Visible = true;
            }
            else
            {
                lblNoROM.Visible = false;
            }
        }

        private void txtStorage_TextChanged(object sender, EventArgs e)
        {
            if (txtStorage.Text == "")
            {
                lblNoStorage.Visible = true;
            }
            else
            {
                lblNoStorage.Visible = false;
            }
        }

        private void txtBattery_TextChanged(object sender, EventArgs e)
        {
            if (txtBattery.Text == "")
            {
                lblNoBattery.Visible = true;
            }
            else
            {
                lblNoBattery.Visible = false;
            }
        }

        private void btnAddLinkImage_Click(object sender, EventArgs e)
        {
            txtLinkImage2.Visible = true;
            btnClearLinkImage2.Visible = true;
            lblNoLinkImage2.Visible = true;
            if (txtLinkImage2.Text != "")
                lblNoLinkImage2.Visible = false;
        }
        private void btnClearLinkImage2_Click(object sender, EventArgs e)
        {
            txtLinkImage2.Text = "";
            txtLinkImage2.Visible = false;
            lblNoLinkImage2.Visible = false;
            btnClearLinkImage2.Visible = false;
        }


    }

}
