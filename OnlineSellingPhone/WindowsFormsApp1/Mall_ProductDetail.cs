using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Enities;

namespace WindowsFormsApp1
{
    public partial class Mall_ProductDetail : Form
    {
        public Mall_ProductDetail()
        {
            InitializeComponent();
        }



        private static int ITEM_WIDTH = 914;
        private static int ITEM_HEIGHT = 156;
        private static int MAX_COLUMNS_IN_PHONES_GRID = 1;
        private static int HORIZONTAL_SPACING = 10;
        private static int VERTICAL_SPACING = 10;

        private static DAO.PRICE_FILTER SORT_BY = DAO.PRICE_FILTER.NONE;
        private static string KEYWORD = "";
        private static string MANUFACTURER_NAME = "";
        private List<Phone> productsByManufacturerName = new List<Phone>();


        private string PriceFormat(double amount)
        {
            // Định dạng số tiền theo văn hóa khu vực hiện tại
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            string formattedAmount = amount.ToString("C", currentCulture);

            // Định dạng số tiền theo tiếng Việt
            CultureInfo vietnameseCulture = CultureInfo.GetCultureInfo("vi-VN");
            formattedAmount = amount.ToString("C", vietnameseCulture);

            // Loại bỏ phần thập phân "00"
            formattedAmount = formattedAmount.Replace(",00", "");

            return formattedAmount;
        }

        private void totalPrice(List<Phone> phones)
        {
            if (phones.Count() != 0)
            {
                try
                {
                    double total = 0;
                    phones.ForEach(p =>
                    {
                        Cart_ProductInCart product = new Cart_ProductInCart();
                        Label lblPrice = (Label)product.Controls.Find("lblPrice", true).FirstOrDefault();
                        total += Convert.ToDouble(p.Phone_Price);
                        //lblTotalPrice.Text = Convert.ToString(PriceFormat(total));
                        //lblTotalProduct.Text = Convert.ToString(phones.Count());
                    });
                }
                catch
                {

                }
            }
        }

       

        private void getPhoneToCart(List<Phone> phones, int itemWidth, int itemHeight, int horizontalSpacing, int verticalSpacing, int maxColumns, int offsetRowForFirstItem = 20, int offsetColumnForFirstItem = 20)
        {
            //Phone selectedPhone = phones.FirstOrDefault();
            //if (selectedPhone != null)
            //{
            int row = 0;
            int column = 0;
            Cart_ProductInCart product = new Cart_ProductInCart();
            Label lblName = (Label)product.Controls.Find("lblName", true).FirstOrDefault();
            Label lblPrice = (Label)product.Controls.Find("lblPrice", true).FirstOrDefault();
            PictureBox pctProduct = (PictureBox)product.Controls.Find("pcbProduct", true).FirstOrDefault();



            lblName.Text = lblProductName.Text;
            lblPrice.Text = lblProductPrice.Text;
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
            Cart productInCart = new Cart();

            Panel pnlProduct = (Panel)productInCart.Controls.Find("pnlProduct", true).FirstOrDefault();
            pnlProduct.Controls.Add(product);
            //Di chuyển sang hàng và cột tiếp theo
            column++;
            if (column >= maxColumns)
            {
                column = 0;
                row++;
            }
            pnlProduct.Refresh();

        }
    

        private void ClearPanel()
        {
            //pnlProduct.Controls.Clear();
        }

        private void LoadUI()
        {
            //ClearPanel();
            productsByManufacturerName = DAO.QueryPhoneTableBySearchKeywordOrByManuFacturerNameAndFilterByPrice(KEYWORD, MANUFACTURER_NAME, SORT_BY);
            getPhoneToCart(productsByManufacturerName, ITEM_WIDTH, ITEM_HEIGHT, HORIZONTAL_SPACING, VERTICAL_SPACING, MAX_COLUMNS_IN_PHONES_GRID);
        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng");
            LoadUI();
           

        }
    }
}
