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
using BusinessLayer;
using DataLayer.Enities;
using System.Threading;
using System.Globalization;

namespace WindowsFormsApp1
{

    public partial class Mall : UserControl
    {
        public Mall()
        {
            InitializeComponent();
        }

        private static int ITEM_WIDTH = 357;
        private static int ITEM_HEIGHT = 357;
        private static int MAX_COLUMNS_IN_PHONES_GRID = 3;
        private static int HORIZONTAL_SPACING = 10;
        private static int VERTICAL_SPACING = 10;

        private string PriceFormat(double amount)
        {
            // Định dạng số tiền theo văn hóa khu vực hiện tại
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            string formattedAmount = amount.ToString("C", currentCulture);

            // Định dạng số tiền theo tiếng Việt
            CultureInfo vietnameseCulture = CultureInfo.GetCultureInfo("vi-VN");
            formattedAmount = amount.ToString("C", vietnameseCulture);

            return formattedAmount;
        }


        private void SetPhoneGrid(List<Phone> phones, int itemWidth, int itemHeight, int horizontalSpacing, int verticalSpacing, int maxColumns, int offsetRowForFirstItem = 40, int offsetColumnForFirstItem = 40)
        {
            try
            {
                int row = 0;
                int column = 0;

                phones.ForEach(p => {
                    Mall_Product product = new Mall_Product();
                    Label lblName = (Label)product.Controls.Find("lblName", true).FirstOrDefault();
                    Label lblPrice = (Label)product.Controls.Find("lblPrice", true).FirstOrDefault();
                    PictureBox pctProduct = (PictureBox)product.Controls.Find("pcbProduct", true).FirstOrDefault();
                    lblName.Text = p.Phone_Name;
                    lblPrice.Text = PriceFormat(p.Phone_Price);

                    // Tính toán vị trí của sản phẩm
                    int x = 0, y = 0;
                    if (column == 0)
                    {
                        x = offsetRowForFirstItem;
                    }
                    else
                    {
                        x = column * (itemWidth + horizontalSpacing) + offsetRowForFirstItem;
                    }
                    if (row == 0)
                    {
                        y = offsetColumnForFirstItem;
                    }
                    else
                    {
                        y = row * (itemHeight + verticalSpacing) + offsetColumnForFirstItem;
                    }

                    // Đặt vị trí của sản phẩm trong panel1
                    product.Location = new Point(x, y);

                    // Thêm sản phẩm vào panel1
                    panel1.Controls.Add(product);

                    // Di chuyển sang hàng và cột tiếp theo
                    column++;
                    if (column >= maxColumns)
                    {
                        column = 0;
                        row++;
                    }
                });
            }
            catch
            {

            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }    

        }

        public void ClearPanel()
        {
            panel1.Controls.Clear();
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

        bool isButtonClicked = false;

        private void Mall_Load(object sender, EventArgs e)
        {
            List<Phone> productsByManufacturerName = DAO.QueryPhoneInformationByManufacturerName();
            SetPhoneGrid(productsByManufacturerName, ITEM_WIDTH, ITEM_HEIGHT, HORIZONTAL_SPACING, VERTICAL_SPACING, MAX_COLUMNS_IN_PHONES_GRID);
        }

        private void btnClickEvent(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (!isButtonClicked)
            {
                isButtonClicked = true;
                foreach (Control control in Controls)
                {
                    if (control is Button button && button != clickedButton)
                    {
                        button.Enabled = false;
                    }
                }
                ClearPanel();
                List<Phone> productsByManufacturerName = DAO.QueryPhoneInformationByManufacturerName(clickedButton.Text);
                SetPhoneGrid(productsByManufacturerName, ITEM_WIDTH, ITEM_HEIGHT, HORIZONTAL_SPACING, VERTICAL_SPACING, MAX_COLUMNS_IN_PHONES_GRID);
            }
            else
            {
                isButtonClicked = false;
                foreach (Control control in Controls)
                {
                    if (control is Button button)
                    {
                        button.Enabled = true;
                    }
                }
                ClearPanel();
                List<Phone> productsByManufacturerName = DAO.QueryPhoneInformationByManufacturerName();
                SetPhoneGrid(productsByManufacturerName, ITEM_WIDTH, ITEM_HEIGHT, HORIZONTAL_SPACING, VERTICAL_SPACING, MAX_COLUMNS_IN_PHONES_GRID);
            }
        }

    }
}
