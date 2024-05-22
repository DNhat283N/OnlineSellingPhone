using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace WindowsFormsApp1
{
    public partial class Product_add_admin : UserControl
    {
        public Product_add_admin()
        {
            InitializeComponent();

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
            if (lblNoName.Visible == false && lblNoManufacturer.Visible == false && lblNoColor.Visible == false && lblNoPrice.Visible == false && lblNoQuantity.Visible == false && lblNoLinkImage1.Visible == false && lblNoLinkImage2.Visible == false && lblNoRAM.Visible == false && lblNoROM.Visible == false)
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                DAO.AddPhone(txtName.Text, ManufacturerID, colorCode, Convert.ToDouble(txtPrice.Text), Convert.ToInt32(nudQuantity.Value), txtLinkImage1.Text, Convert.ToInt32(txtRAM.Text), Convert.ToInt32(txtROM.Text), txtLinkImage2.Text, true);
                //Mall newMall = new Mall();
                //newMall.refreshMall();
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

        int ManufacturerID;
        private void cbbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbManufacturer.SelectedItem)
            {
                case "Apple":
                    ManufacturerID = 1;
                    break;
                case "Oppo":
                    ManufacturerID = 2;
                    break;
                case "Realme":
                    ManufacturerID = 3;
                    break;
                case "Samsung":
                    ManufacturerID = 4;
                    break;
                case "Xiaomi":
                    ManufacturerID = 5;
                    break;
            }    
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


        private void btnAddLinkImage_Click(object sender, EventArgs e)
        {
            txtLinkImage2.Visible = true;
            btnClearLinkImage2.Visible = true;
            lblNoLinkImage2.Visible = true;

        }
        private void btnClearLinkImage2_Click(object sender, EventArgs e)
        {
            //txtLinkImage2.Text = "Link URL hình ảnh 2";
            //txtLinkImage2.ForeColor = Color.DarkGray;
            txtLinkImage2.Visible = false;
            lblNoLinkImage2.Visible = false;
            btnClearLinkImage2.Visible = false;
        }

        string colorCode;

        private void cbbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbColor.SelectedItem == "Đen")
            {
                colorCode = "#000000";
            }
            switch (cbbColor.SelectedItem)
            {
                case "Đen":
                    colorCode = "#000000";
                    break;
                case "Đỏ":
                    colorCode = "#FF0000";
                    break;
                case "Hồng":
                    colorCode = "#FFCCFF";
                    break;
                case "Trắng":
                    colorCode = "#FFFFFF";
                    break;
                case "Xám ":
                    colorCode = "#808080";
                    break;
                case "Xanh đen":
                    colorCode = "#000080";
                    break;
                case "Xanh dương":
                    colorCode = "#0000FF";
                    break;
                case "Xanh lá":
                    colorCode = "#008000";
                    break;
            }
        }

        private void txtLinkImage1_Click(object sender, EventArgs e)
        {
            txtLinkImage1.Text = "";
            txtLinkImage1.ForeColor = Color.Black;
        }

        private void txtLinkImage2_Click(object sender, EventArgs e)
        {
            txtLinkImage2.Text = "";
            txtLinkImage2.ForeColor = Color.Black;
        }

        private void txtLinkImage1_Leave(object sender, EventArgs e)
        {
            if (txtLinkImage1.Text == "")
            {
                txtLinkImage1.Text = "Link URL hình ảnh 1";
                txtLinkImage1.ForeColor = Color.DarkGray;
            }
        }

        private void txtLinkImage2_Leave(object sender, EventArgs e)
        {
            //if (txtLinkImage2.Text == "")
            //{
            //    txtLinkImage2.Text = "Link URL hình ảnh 2";
            //    txtLinkImage2.ForeColor = Color.DarkGray;
            //}
        }

        private void txtLinkImage1_TextChanged(object sender, EventArgs e)
        {
            if (txtLinkImage1.Text == "" || txtLinkImage1.Text == "Link URL hình ảnh 1")
                lblNoLinkImage1.Visible = true;
            else
                lblNoLinkImage1.Visible = false;
        }

        private void txtLinkImage2_TextChanged(object sender, EventArgs e)
        {
            if (txtLinkImage2.Text == "" /*|| txtLinkImage2.Text == "Link URL hình ảnh 2"*/)
                lblNoLinkImage2.Visible = true;
            else
                lblNoLinkImage2.Visible = false;
        }
    }
}
