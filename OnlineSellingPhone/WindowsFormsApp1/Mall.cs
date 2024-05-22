using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Enities;
using System.Globalization;

namespace WindowsFormsApp1
{

    public partial class Mall : UserControl
    {
        public Mall()
        {
            InitializeComponent();
            //refreshMall = new refresh(LoadUI);
        }
        //public delegate void refresh();
        //public refresh refreshMall;


        private static int ITEM_WIDTH = 357;
        private static int ITEM_HEIGHT = 357;
        private static int MAX_COLUMNS_IN_PHONES_GRID = 3;
        private static int HORIZONTAL_SPACING = 20;
        private static int VERTICAL_SPACING = 20;

        private static DAO.PRICE_FILTER SORT_BY = DAO.PRICE_FILTER.NONE;
        private static string KEYWORD = "";
        private static string MANUFACTURER_NAME = "";
        private static List<Phone> suggestionPhoneList = new List<Phone>();
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

        private void UpdateListBoxHeight(bool isDisplay)
        {
            if (isDisplay)
            {
                const int itemHeight = 16; // Độ cao mặc định của mỗi item trong ListBox
                const int maxHeight = 300; // Độ cao tối đa của listbox

                int numItems = lsbSuggestions.Items.Count;
                int desiredHeight = Math.Min(numItems * itemHeight, maxHeight);

                lsbSuggestions.Height = desiredHeight;
            }
        }

        private void SetPhoneGrid(List<Phone> phones, int itemWidth, int itemHeight, int horizontalSpacing, int verticalSpacing, int maxColumns, int offsetRowForFirstItem = 20, int offsetColumnForFirstItem = 20)
        {
            if(phones.Count() != 0)
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
                            pnlProduct.Controls.Add(product);

                       
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
        }

        private void LoadUI()
        {
            ClearPanel();
            productsByManufacturerName = DAO.QueryPhoneTableBySearchKeywordOrByManuFacturerNameAndFilterByPrice(KEYWORD, MANUFACTURER_NAME, SORT_BY);
            SetPhoneGrid(productsByManufacturerName, ITEM_WIDTH, ITEM_HEIGHT, HORIZONTAL_SPACING, VERTICAL_SPACING, MAX_COLUMNS_IN_PHONES_GRID);
        }

        private void ShowSuggestions(string searchText)
        {
            suggestionPhoneList.Clear();

            if (!string.IsNullOrEmpty(searchText))
            {
                suggestionPhoneList = DAO.QueryPhoneTableBySearchKeywordOrByManuFacturerNameAndFilterByPrice(txtSearch.Text);
                if (suggestionPhoneList.Count() == 0)
                    UpdateListBoxHeight(false);
            }

            // Xóa các đề xuất cũ
            lsbSuggestions.Items.Clear();

            // Hiển thị các đề xuất mới
            foreach (Phone suggestion in suggestionPhoneList)
            {
                lsbSuggestions.Items.Add(suggestion.Phone_Name);
            }
            UpdateListBoxHeight(true);
            lsbSuggestions.Location = new Point(txtSearch.Left, txtSearch.Bottom + 5);
            // Hiển thị danh sách đề xuất
            lsbSuggestions.Visible = suggestionPhoneList.Any();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text != "" && KEYWORD == "")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
                lblClearSearch.Visible = false;
            }    
            else if(KEYWORD != "" && txtSearch.Text != "Tìm theo tên điện thoại")
            {
                txtSearch.Text = KEYWORD;
            }
        }

        private void ClearPanel()
        {
            pnlProduct.Controls.Clear();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (KEYWORD == "")
            {
                txtSearch.Text = "Tìm theo tên điện thoại";
                txtSearch.ForeColor = Color.DarkGray;
                lblClearSearch.Visible = false;
            }
            else if(KEYWORD != "")
            {
                txtSearch.Text = KEYWORD;
            }
        }

        private void btnPricefilter_Click(object sender, EventArgs e)
        {
            string Pricefilter = btnPricefilter.Text;
            switch (Pricefilter)
            {
                case "Giá ↑↓":
                    btnPricefilter.Text = "Giá ↑";
                    SORT_BY = DAO.PRICE_FILTER.ASCENDING;
                    btnPricefilter.ForeColor = Color.Red;
                    LoadUI();
                    break;
                case "Giá ↑":
                    btnPricefilter.Text = "Giá ↓";
                    SORT_BY = DAO.PRICE_FILTER.DESCENDING;
                    btnPricefilter.ForeColor = Color.Red;
                    LoadUI();
                    break;
                case "Giá ↓":
                    btnPricefilter.Text = "Giá ↑↓";
                    SORT_BY = DAO.PRICE_FILTER.NONE;
                    btnPricefilter.ForeColor = Color.Black;
                    LoadUI(); 
                    break;
            }
        }

        bool isButtonClicked = false;

        private void Mall_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void btnClickEvent(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (!isButtonClicked)
            {
                isButtonClicked = true;
                foreach (Control control in Controls)
                {
                    if (control is Button button && button != clickedButton && button.Name.StartsWith("btn") && button.Name != "btnSearch" && button.Name != "btnPricefilter")
                    {
                        button.Enabled = false;
                    }
                }
                MANUFACTURER_NAME = clickedButton.Text;
                clickedButton.BackColor = Color.DarkGray;
                LoadUI();
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
                MANUFACTURER_NAME = "";
                clickedButton.BackColor = Color.White;
                LoadUI();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsbSuggestions.Visible = false;
            if (txtSearch.Text != "" && txtSearch.Text != "Tìm theo tên điện thoại")
            {
                KEYWORD = txtSearch.Text;
                LoadUI();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(txtSearch.Text);
            if(txtSearch.Text != "" && txtSearch.Text != "Tìm theo tên điện thoại")
            {
                KEYWORD = txtSearch.Text;
                lblClearSearch.Location = new Point(txtSearch.Left - lblClearSearch.Width - 5, txtSearch.Top);
                lblClearSearch.Visible = true;
            }
        }

        private void lblClearSearch_Click(object sender, EventArgs e)
        {
            KEYWORD = "";
            txtSearch.Text = KEYWORD;
            lblClearSearch.Visible = false;
            LoadUI();
        }

        private void lsbSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbSuggestions.SelectedItem != null)
            {
                string selectedSuggestion = lsbSuggestions.SelectedItem.ToString();
                lsbSuggestions.Text = selectedSuggestion;
                txtSearch.Text = selectedSuggestion;
                lsbSuggestions.Visible = false; // Ẩn danh sách đề xuất khi người dùng chọn một đề xuất
            }
        }
    }
}
