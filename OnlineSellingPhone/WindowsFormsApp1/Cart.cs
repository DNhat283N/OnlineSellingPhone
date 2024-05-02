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
    public partial class Cart : UserControl
    {
        public Cart()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Mall_Product product = new Mall_Product();
        //    fpnlProductCart.Controls.Add(product);
        //}
       

        private void Cart_SizeChanged(object sender, EventArgs e)
        {
        }
        //int width = 1150;
        //int height = 164;
        
        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            
            //int newWidth = flowLayoutPanel1.Width;
            //int newHeight = flowLayoutPanel1.Height;
            //mall_Product1.Location = new Point(mall_Product1.Location.X + newWidth - width, mall_Product1.Location.Y + newHeight - height);
            //Console.WriteLine();
            //mall_Product1.Location = new Point(289,mall_Product1.Location.Y + 357);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        bool buttonClicked = false;
        private void btnPayCash_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                btnPayCash.BackgroundColor = Color.DarkGray;
                btnPaypal.Enabled = false;
                buttonClicked = true;
                lblNoPayment.Visible = false;
            }
            else
            {
                btnPayCash.BackgroundColor = Color.White;
                btnPaypal.Enabled = true;
                buttonClicked = false;
                lblNoPayment.Visible = true;
            }
        }
        
        private void btnPaypal_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                btnPaypal.BackgroundColor = Color.DarkGray;
                btnPayCash.Enabled = false;
                buttonClicked = true;
                lblNoPayment.Visible = false;
            }
            else
            {
                btnPaypal.BackgroundColor = Color.White;
                btnPayCash.Enabled = true;
                buttonClicked = false;
                lblNoPayment.Visible = true;
            }
        }




        private void cbbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = cbbCity.SelectedItem.ToString();
            lblNoCity.Visible = false;
            cbbCity.ForeColor = Color.Black;
            string[] districts; 
            cbbDistrict.Items.Clear();
            switch (city)
            {
                case "An Giang":
                    districts = new string[] {"Huyện An Phú",
                                              "Huyện Châu Phú",
                                              "Huyện Châu Thành",
                                              "Huyện Chợ Mới",
                                              "Huyện Phú Tân",
                                              "Huyện Thoại Sơn",
                                              "Huyện Tri Tôn",
                                              "Thị Xã Tịnh Biên",
                                              "TP.Châu Đốc",
                                              "TP.Long Xuyên",
                                              "TX.Tân Châu"};
                    break;
                case "Bà Rịa - Vũng Tàu":
                    districts = new string[] {"Huyện Bà Rịa",
                                              "Huyện Châu Đức",
                                              "Huyện Côn Đảo",
                                              "Huyện Đất Đỏ",
                                              "Huyện Long Điền",
                                              "Huyện Tân Thành",
                                              "Thành phố Vũng Tàu"};
                    break;
                case "Bạc Liêu":
                    districts = new string[] {"Huyện Đông Hải",
                                                "Huyện Hòa Bình",
                                                "Huyện Hồng Dân",
                                                "Huyện Phước Long",
                                                "Huyện Vĩnh Lợi",
                                                "TP. Bạc Liêu",
                                                "TX. Giá Rai"};
                    break;
                case "Bắc Kạn":
                    districts = new string[] {"Huyện Ba Bể",
                                              "Huyện Bạch Thông",
                                              "Huyện Chợ Đồn",
                                              "Huyện Chợ Mới",
                                              "Huyện Na Rì",
                                              "Huyện Ngân Sơn",
                                              "Huyện Pác Nặm",
                                              "TP. Bắc Kạn"};
                    break;
                case "Bắc Giang":
                    districts = new string[] {"Huyện Hiệp Hòa",
                                              "Huyện Lạng Giang",
                                              "Huyện Lục Nam",
                                              "Huyện Lục Ngạn",
                                              "Huyện Sơn Động",
                                              "Huyện Tân Yên",
                                              "Huyện Việt Yên",
                                              "Huyện Yên Dũng",
                                              "Huyện Yên Thế",
                                              "TP. Bắc Giang"};
                    break;
                case "Bắc Ninh":
                    districts = new string[] {"Huyện Gia Bình",
                                              "Huyện Lương Tài",
                                              "Huyện Quế Võ",
                                              "Huyện Thuận Thành",
                                              "Huyện Tiên Du",
                                              "Huyện Yên Phong",
                                              "TP. Bắc Ninh",
                                              "TP. Từ Sơn"};
                    break;
                case "Bến Tre":
                    districts = new string[] {"Huyện Ba Tri",
                                              "Huyện Bình Đại",
                                              "Huyện Châu Thành",
                                              "Huyện Chợ Lách",
                                              "Huyện Giồng Trôm",
                                              "Huyện Mỏ Cày Bắc",
                                              "Huyện Mỏ Cày Nam",
                                              "Huyện Thạnh Phú",
                                              "TP. Bến Tre"};
                    break;
                case "Bình Dương":
                    districts = new string[] {"Huyện Bắc Tân Uyên",
                                              "Huyện Bàu Bàng",
                                              "Huyện Dầu Tiếng",
                                              "Huyện Phú Giáo",
                                              "TP. Dĩ An",
                                              "TP. Tân Uyên",
                                              "TP. Thủ Dầu Một",
                                              "TP. Thuận An",
                                              "TX. Bến Cát"};
                    break;
                case "Bình Định":
                    districts = new string[] {"Huyện An Lão",
                                              "Huyện Hoài Ân",
                                              "Huyện Phù Cát",
                                              "Huyện Phù Mỹ",
                                              "Huyện Tây Sơn",
                                              "Huyện Tuy Phước",
                                              "Huyện Vân Canh",
                                              "Huyện Vĩnh Thạnh",
                                              "TP. Quy Nhơn",
                                              "TX. An Nhơn",
                                              "TX. Hoài Nhơn"};
                    break;
                case "Bình Phước":
                    districts = new string[] {"Huyện Bù Đăng",
                                              "Huyện Bù Đốp",
                                              "Huyện Bù Gia Mập",
                                              "Huyện Đồng Phú",
                                              "Huyện Hớn Quản",
                                              "Huyện Lộc Ninh",
                                              "Huyện Phú Riềng",
                                              "Thị Xã Chơn Thành",
                                              "TP. Đồng Xoài",
                                              "TX. Bình Long",
                                              "TX. Phước Long"};
                    break;
                case "Bình Thuận":
                    districts = new string[] {"Huyện Bắc Bình",
                                              "Huyện Đức Linh",
                                              "Huyện Hàm Tân",
                                              "Huyện Hàm Thuận Bắc",
                                              "Huyện Hàm Thuận Nam",
                                              "Huyện Phú Quí",
                                              "Huyện Tánh Linh",
                                              "Huyện Tuy Phong",
                                              "TP. Phan Thiết",
                                              "TX. La Gi" };
                    break;
                case "Cà Mau":
                    districts = new string[] {"Huyện Cái Nước",
                                              "Huyện Đầm Dơi",
                                              "Huyện Năm Căn",
                                              "Huyện Ngọc Hiển",
                                              "Huyện Phú Tân",
                                              "Huyện Thới Bình",
                                              "Huyện Trần Văn Thời",
                                              "Huyện U Minh",
                                              "TP. Cà Mau"};
                    break;
                case "Cao Bằng":
                    districts = new string[] {"Huyện Bảo Lạc",
                                              "Huyện Bảo Lâm",
                                              "Huyện Hạ Lang",
                                              "Huyện Hà Quảng",
                                              "Huyện Hòa An",
                                              "Huyện Nguyên Bình",
                                              "Huyện Phục Hòa",
                                              "Huyện Quảng Hòa",
                                              "Huyện Quảng Uyên",
                                              "Huyện Thạch An",
                                              "Huyện Thông Nông",
                                              "Huyện Trùng Khánh",
                                              "TP. Cao Bằng" };
                    break;
                case "Cần Thơ":
                    districts = new string[] {"Quận Bình Thủy",
                                              "Quận Cái Răng",
                                              "Quận Ninh Kiều",
                                              "Quận Ô Môn",
                                              "Quận Thốt Nốt",
                                              "Huyện Cờ Đỏ",
                                              "Huyện Phong Điền",
                                              "Huyện Thới Lai",
                                              "Huyện Vĩnh Thạnh"};
                    break;
                case "Đà Nẵng":
                    districts = new string[] {"Quận Cẩm Lệ",
                                              "Quận Hải Châu",
                                              "Quận Liên Chiểu",
                                              "Quận Ngũ Hành Sơn",
                                              "Quận Sơn Trà",
                                              "Quận Thanh Khê",
                                              "Huyện Hòa Vang"};
                    break;
                case "Đắk Lắk":
                    districts = new string[] {"Huyện Buôn Đôn",
                                              "Huyện Cư Kuin",
                                              "Huyện Cư M'gar",
                                              "Huyện Ea H'leo",
                                              "Huyện Ea Kar",
                                              "Huyện Ea Súp",
                                              "Huyện Krông Ana",
                                              "Huyện Krông Bông",
                                              "Huyện Krông Búk",
                                              "Huyện Krông Năng",
                                              "Huyện Krông Pắc",
                                              "Huyện Lắk",
                                              "Huyện M'Đrăk",
                                              "TP. Buôn Ma Thuột",
                                              "TX. Buôn Hồ"};
                    break;
                case "Đắk Nông":
                    districts = new string[] {"Huyện Cư Jút",
                                              "Huyện Đăk Glong",
                                              "Huyện Đắk Mil",
                                              "Huyện Đắk R'Lấp",
                                              "Huyện Đắk Song",
                                              "Huyện Krông Nô",
                                              "Huyện Tuy Đức",
                                              "TP. Gia Nghĩa"};
                    break;
                case "Đồng Nai":
                    districts = new string[] {"Huyện Cẩm Mỹ",
                                              "Huyện Định Quán",
                                              "Huyện Long Thành",
                                              "Huyện Nhơn Trạch",
                                              "Huyện Tân Phú",
                                              "Huyện Thống Nhất",
                                              "Huyện Trảng Bom",
                                              "Huyện Vĩnh Cửu",
                                              "Huyện Xuân Lộc",
                                              "TP. Biên Hòa",
                                              "TP. Long Khánh"};
                    break;
                case "Đồng Tháp":
                    districts = new string[] {"Huyện Cao Lãnh",
                                              "Huyện Châu Thành",
                                              "Huyện Hồng Ngự",
                                              "Huyện Lai Vung",
                                              "Huyện Lấp Vò",
                                              "Huyện Tam Nông",
                                              "Huyện Tân Hồng",
                                              "Huyện Thanh Bình",
                                              "Huyện Tháp Mười",
                                              "TP. Cao Lãnh",
                                              "TP. Hồng Ngự",
                                              "TP. Sa Đéc"};
                    break;
                case "Điện Biên":
                    districts = new string[] {"Huyện Điện Biên",
                                              "Huyện Điện Biên Đông",
                                              "Huyện Mường Ảng",
                                              "Huyện Mường Chà",
                                              "Huyện Mường Nhé",
                                              "Huyện Nậm Pồ",
                                              "Huyện Tủa Chùa",
                                              "Huyện Tuần Giáo",
                                              "TP. Điện Biên Phủ",
                                              "TX. Mường Lay"};
                    break;
                case "Gia Lai":
                    districts = new string[] {"Huyện Chư Păh",
                                              "Huyện Chư Prông",
                                              "Huyện Chư Pưh",
                                              "Huyện Chư Sê",
                                              "Huyện Đăk Đoa",
                                              "Huyện Đắk Pơ",
                                              "Huyện Đức Cơ",
                                              "Huyện Ia Grai",
                                              "Huyện Ia Pa",
                                              "Huyện KBang",
                                              "Huyện Kông Chroc",
                                              "Huyện Krông Pa",
                                              "Huyện Mang Yang",
                                              "Huyện Phú Thiện",
                                              "TP. Pleiku",
                                              "TX. An Khê",
                                              "TX. Ayun Pa"};
                    break;
                case "Hà Giang":
                    districts = new string[] {"Huyện Bắc Mê",
                                              "Huyện Bắc Quang",
                                              "Huyện Đồng Văn",
                                              "Huyện Hoàng Su Phì",
                                              "Huyện Mèo Vạc",
                                              "Huyện Quản Bạ",
                                              "Huyện Quang Bình",
                                              "Huyện Vị Xuyên",
                                              "Huyện Xín Mần",
                                              "Huyện Yên Minh",
                                              "TP. Hà Giang"};
                    break;
                case "Hà Nam":
                    districts = new string[] {"Huyện Bình Lục",
                                              "Huyện Kim Bảng",
                                              "Huyện Lý Nhân",
                                              "Huyện Thanh Liêm",
                                              "TP. Phủ Lý",
                                              "TX. Duy Tiên"};
                    break;
                case "Hà Nội":
                    districts = new string[] {"Quận Ba Đình",
                                              "Quận Bắc Từ Liêm",
                                              "Quận Cầu Giấy",
                                              "Quận Đống Đa",
                                              "Quận Hà Đông",
                                              "Quận Hai Bà Trưng",
                                              "Quận Hoàn Kiếm",
                                              "Quận Hoàng Mai",
                                              "Quận Long Biên",
                                              "Quận Nam Từ Liêm",
                                              "Quận Tây Hồ",
                                              "Quận Thanh Xuân",
                                              "Huyện Ba Vì",
                                              "Huyện Chương Mỹ",
                                              "Huyện Đan Phượng",
                                              "Huyện Đông Anh",
                                              "Huyện Gia Lâm",
                                              "Huyện Hoài Đức",
                                              "Huyện Mê Linh",
                                              "Huyện Mỹ Đức",
                                              "Huyện Phú Xuyên",
                                              "Huyện Phúc Thọ",
                                              "Huyện Quốc Oai",
                                              "Huyện Sóc Sơn",
                                              "Huyện Thạch Thất",
                                              "Huyện Thanh Oai",
                                              "Huyện Thanh Trì",
                                              "Huyện Thường Tín",
                                              "Huyện Ứng Hòa",
                                              "TX. Sơn Tây"};
                    break;
                case "Hà Tĩnh":
                    districts = new string[] {"Huyện Cẩm Xuyên",
                                              "Huyện Can Lộc",
                                              "Huyện Đức Thọ",
                                              "Huyện Hương Khê",
                                              "Huyện Hương Sơn",
                                              "Huyện Kỳ Anh",
                                              "Huyện Lộc Hà",
                                              "Huyện Nghi Xuân",
                                              "Huyện Thạch Hà",
                                              "Huyện Vũ Quang",
                                              "TP. Hà Tĩnh",
                                              "TX. Hồng Lĩnh",
                                              "TX. Kỳ Anh"};
                    break;
                case "Hải Dương":
                    districts = new string[] {"Huyện Bình Giang",
                                              "Huyện Cẩm Giàng",
                                              "Huyện Gia Lộc",
                                              "Huyện Kim Thành",
                                              "Huyện Nam Sách",
                                              "Huyện Ninh Giang",
                                              "Huyện Thanh Hà",
                                              "Huyện Thanh Miện",
                                              "Huyện Tứ Kỳ",
                                              "TP. Chí Linh",
                                              "TP. Hải Dương",
                                              "TX. Kinh Môn"};
                    break;
                case "Hải Phòng":
                    districts = new string[] {"Quận Đồ Sơn",
                                              "Quận Dương Kinh",
                                              "Quận Hải An",
                                              "Quận Hồng Bàng",
                                              "Quận Kiến An",
                                              "Quận Lê Chân",
                                              "Quận Ngô Quyền",
                                              "Huyện An Dương",
                                              "Huyện An Lão",
                                              "Huyện Bạch Long Vĩ",
                                              "Huyện Cát Hải",
                                              "Huyện Kiến Thụy",
                                              "Huyện Thuỷ Nguyên",
                                              "Huyện Tiên Lãng",
                                              "Huyện Vĩnh Bảo"};
                    break;
                case "Hòa Bình":
                    districts = new string[] {"Huyện Cao Phong",
                                              "Huyện Đà Bắc",
                                              "Huyện Kim Bôi",
                                              "Huyện Lạc Sơn",
                                              "Huyện Lạc Thủy",
                                              "Huyện Lương Sơn",
                                              "Huyện Mai Châu",
                                              "Huyện Tân Lạc",
                                              "Huyện Yên Thủy",
                                              "TP. Hòa Bình"};
                    break;
                case "Hậu Giang":
                    districts = new string[] {"Huyện Châu Thành",
                                              "Huyện Châu Thành A",
                                              "Huyện Long Mỹ",
                                              "Huyện Phụng Hiệp",
                                              "Huyện Vị Thủy",
                                              "TP. Ngã Bảy",
                                              "TP. Vị Thanh",
                                              "TX. Long Mỹ"};
                    break;
                case "Hưng Yên":
                    districts = new string[] {"Huyện Ân Thi",
                                              "Huyện Khoái Châu",
                                              "Huyện Kim Động",
                                              "Huyện Phù Cừ",
                                              "Huyện Tiên Lữ",
                                              "Huyện Văn Giang",
                                              "Huyện Văn Lâm",
                                              "Huyện Yên Mỹ",
                                              "Thị Xã Mỹ Hào",
                                              "TP. Hưng Yên"};
                    break;
                case "Thành phố Hồ Chí Minh":
                    districts = new string[] {"TP.Thủ Đức (Gồm Q2, Q9, Q.TĐ)",
                                              "Quận 1",
                                              "Quận 3",
                                              "Quận 4",
                                              "Quận 5",
                                              "Quận 6",
                                              "Quận 7",
                                              "Quận 8",
                                              "Quận 10",
                                              "Quận 11",
                                              "Quận 12",
                                              "Quận Bình Tân",
                                              "Quận Bình Thạnh",
                                              "Quận Gò Vấp",
                                              "Quận Phú Nhuận",
                                              "Quận Tân Bình",
                                              "Quận Tân Phú",
                                              "Huyện Bình Chánh",
                                              "Huyện Cần Giờ",
                                              "Huyện Củ Chi",
                                              "Huyện Hóc Môn",
                                              "Huyện Nhà Bè"};
                    break;
                case "Khánh Hòa":
                    districts = new string[] {"Huyện Cam Lâm",
                                              "Huyện Diên Khánh",
                                              "Huyện Khánh Sơn",
                                              "Huyện Khánh Vĩnh",
                                              "Huyện Trường Sa",
                                              "Huyện Vạn Ninh",
                                              "TP. Cam Ranh",
                                              "TP. Nha Trang",
                                              "TX. Ninh Hòa"};
                    break;
                case "Kiên Giang":
                    districts = new string[] {"Huyện An Biên",
                                              "Huyện An Minh",
                                              "Huyện Châu Thành",
                                              "Huyện Giang Thành",
                                              "Huyện Giồng Riềng",
                                              "Huyện Gò Quao",
                                              "Huyện Hòn Đất",
                                              "Huyện Kiên Hải",
                                              "Huyện Kiên Lương",
                                              "Huyện Tân Hiệp",
                                              "Huyện U Minh Thượng",
                                              "Huyện Vĩnh Thuận",
                                              "TP. Hà Tiên",
                                              "TP. Phú Quốc",
                                              "TP. Rạch Giá"};
                    break;
                case "Kon Tum":
                    districts = new string[] {"Huyện Đăk Glei",
                                              "Huyện Đăk Hà",
                                              "Huyện Đăk Tô",
                                              "Huyện Ia H'Drai",
                                              "Huyện Kon Plông",
                                              "Huyện Kon Rẫy",
                                              "Huyện Ngọc Hồi",
                                              "Huyện Sa Thầy",
                                              "Huyện Tu Mơ Rông",
                                              "TP. Kon Tum"};
                    break;
                case "Lai Châu":
                    districts = new string[] {"Huyện Mường Tè",
                                              "Huyện Nậm Nhùn",
                                              "Huyện Phong Thổ",
                                              "Huyện Sìn Hồ",
                                              "Huyện Tam Đường",
                                              "Huyện Tân Uyên",
                                              "Huyện Than Uyên",
                                              "TP. Lai Châu"};
                    break;
                case "Lào Cai":
                    districts = new string[] {"Huyện Bắc Hà",
                                              "Huyện Bảo Thắng",
                                              "Huyện Bảo Yên",
                                              "Huyện Bát Xát",
                                              "Huyện Mường Khương",
                                              "Huyện Si Ma Cai",
                                              "Huyện Văn Bàn",
                                              "TP. Lào Cai",
                                              "TX. Sa Pa"};
                    break;
                case "Lạng Sơn":
                    districts = new string[] {"Huyện Bắc Sơn",
                                              "Huyện Bình Gia",
                                              "Huyện Cao Lộc",
                                              "Huyện Chi Lăng",
                                              "Huyện Đình Lập",
                                              "Huyện Hữu Lũng",
                                              "Huyện Lộc Bình",
                                              "Huyện Tràng Định",
                                              "Huyện Văn Lãng",
                                              "Huyện Văn Quan",
                                              "TP. Lạng Sơn"};
                    break;
                case "Lâm Đồng":
                    districts = new string[] {"Huyện Bảo Lâm",
                                              "Huyện Cát Tiên",
                                              "Huyện Đạ Huoai",
                                              "Huyện Đạ Tẻh",
                                              "Huyện Đam Rông",
                                              "Huyện Di Linh",
                                              "Huyện Đơn Dương",
                                              "Huyện Đức Trọng",
                                              "Huyện Lạc Dương",
                                              "Huyện Lâm Hà",
                                              "TP. Bảo Lộc",
                                              "TP. Đà Lạt"};
                    break;
                case "Long An":
                    districts = new string[] {"Huyện Bến Lức",
                                              "Huyện Cần Đước",
                                              "Huyện Cần Giuộc",
                                              "Huyện Châu Thành",
                                              "Huyện Đức Hòa",
                                              "Huyện Đức Huệ",
                                              "Huyện Mộc Hóa",
                                              "Huyện Tân Hưng",
                                              "Huyện Tân Thạnh",
                                              "Huyện Tân Trụ",
                                              "Huyện Thạnh Hóa",
                                              "Huyện Thủ Thừa",
                                              "Huyện Vĩnh Hưng",
                                              "TP. Tân An",
                                              "TX. Kiến Tường"};
                    break;
                case "Nam Định":
                    districts = new string[] {"Huyện Giao Thủy",
                                              "Huyện Hải Hậu",
                                              "Huyện Mỹ Lộc",
                                              "Huyện Nam Trực",
                                              "Huyện Nghĩa Hưng",
                                              "Huyện Trực Ninh",
                                              "Huyện Vụ Bản",
                                              "Huyện Xuân Trường",
                                              "Huyện Ý Yên",
                                              "TP. Nam Định"};
                    break;
                case "Nghệ An":
                    districts = new string[] {"Huyện Anh Sơn",
                                              "Huyện Con Cuông",
                                              "Huyện Diễn Châu",
                                              "Huyện Đô Lương",
                                              "Huyện Hưng Nguyên",
                                              "Huyện Kỳ Sơn",
                                              "Huyện Nam Đàn",
                                              "Huyện Nghi Lộc",
                                              "Huyện Nghĩa Đàn",
                                              "Huyện Quế Phong",
                                              "Huyện Quỳ Châu",
                                              "Huyện Quỳ Hợp",
                                              "Huyện Quỳnh Lưu",
                                              "Huyện Tân Kỳ",
                                              "Huyện Thanh Chương",
                                              "Huyện Tương Dương",
                                              "Huyện Yên Thành",
                                              "TP. Vinh",
                                              "TX. Cửa Lò",
                                              "TX. Hoàng Mai",
                                              "TX. Thái Hòa"};
                    break;
                case "Ninh Bình":
                    districts = new string[] {"Huyện Gia Viễn",
                                              "Huyện Hoa Lư",
                                              "Huyện Kim Sơn",
                                              "Huyện Nho Quan",
                                              "Huyện Yên Khánh",
                                              "Huyện Yên Mô",
                                              "TP. Ninh Bình",
                                              "TP. Tam Điệp"};
                    break;
                case "Ninh Thuận":
                    districts = new string[] {"Huyện Bác Ái",
                                              "Huyện Ninh Hải",
                                              "Huyện Ninh Phước",
                                              "Huyện Ninh Sơn",
                                              "Huyện Thuận Bắc",
                                              "Huyện Thuận Nam",
                                              "TP. Phan Rang - Tháp Chàm"};
                    break;
                case "Phú Thọ":
                    districts = new string[] {"Huyện Cẩm Khê",
                                              "Huyện Đoan Hùng",
                                              "Huyện Hạ Hòa",
                                              "Huyện Lâm Thao",
                                              "Huyện Phù Ninh",
                                              "Huyện Tam Nông",
                                              "Huyện Tân Sơn",
                                              "Huyện Thanh Ba",
                                              "Huyện Thanh Sơn",
                                              "Huyện Thanh Thủy",
                                              "Huyện Yên Lập",
                                              "TP. Việt Trì",
                                              "TX. Phú Thọ"};
                    break;
                case "Phú Yên":
                    districts = new string[] {"Huyện Đồng Xuân",
                                              "Huyện Phú Hòa",
                                              "Huyện Sơn Hòa",
                                              "Huyện Sông Hinh",
                                              "Huyện Tây Hòa",
                                              "Huyện Tuy An",
                                              "Thị Xã Đông Hòa",
                                              "TP. Tuy Hòa",
                                              "TX. Sông Cầu"};
                    break;
                case "Quảng Bình":
                    districts = new string[] {"Huyện Bố Trạch",
                                              "Huyện Lệ Thủy",
                                              "Huyện Minh Hóa",
                                              "Huyện Quảng Ninh",
                                              "Huyện Quảng Trạch",
                                              "Huyện Tuyên Hóa",
                                              "TP. Đồng Hới",
                                              "TX. Ba Đồn"};
                    break;
                case "Quảng Nam":
                    districts = new string[] {"Huyện Bắc Trà My",
                                              "Huyện Đại Lộc",
                                              "Huyện Đông Giang",
                                              "Huyện Duy Xuyên",
                                              "Huyện Hiệp Đức",
                                              "Huyện Nam Giang",
                                              "Huyện Nam Trà My",
                                              "Huyện Nông Sơn",
                                              "Huyện Núi Thành",
                                              "Huyện Phú Ninh",
                                              "Huyện Phước Sơn",
                                              "Huyện Quế Sơn",
                                              "Huyện Tây Giang",
                                              "Huyện Thăng Bình",
                                              "Huyện Tiên Phước",
                                              "Thị Xã Điện Bàn",
                                              "TP. Hội An",
                                              "TP. Tam Kỳ"};
                    break;
                case "Quảng Ngãi":
                    districts = new string[] {"Huyện Ba Tơ",
                                              "Huyện Bình Sơn",
                                              "Huyện Lý Sơn",
                                              "Huyện Minh Long",
                                              "Huyện Mộ Đức",
                                              "Huyện Nghĩa Hành",
                                              "Huyện Sơn Hà",
                                              "Huyện Sơn Tây",
                                              "Huyện Sơn Tịnh",
                                              "Huyện Trà Bồng",
                                              "Huyện Tư Nghĩa",
                                              "TP. Quảng Ngãi",
                                              "TX. Đức Phổ"};
                    break;
                case "Quảng Ninh":
                    districts = new string[] {"Huyện Ba Chẽ",
                                              "Huyện Bình Liêu",
                                              "Huyện Cô Tô",
                                              "Huyện Đầm Hà",
                                              "Huyện Hải Hà",
                                              "Huyện Tiên Yên",
                                              "Huyện Vân Đồn",
                                              "TP. Cẩm Phả",
                                              "TP. Hạ Long",
                                              "TP. Móng Cái",
                                              "TP. Uông Bí",
                                              "TX. Đông Triều",
                                              "TX. Quảng Yên"};
                    break;
                case "Quảng Trị":
                    districts = new string[] {"Huyện Cam Lộ",
                                              "Huyện Cồn Cỏ",
                                              "Huyện Đa Krông",
                                              "Huyện Gio Linh",
                                              "Huyện Hải Lăng",
                                              "Huyện Hướng Hóa",
                                              "Huyện Triệu Phong",
                                              "Huyện Vĩnh Linh",
                                              "TP. Đông Hà",
                                              "TX. Quảng Trị"};
                    break;
                case "Sóc Trăng":
                    districts = new string[] {"Huyện Châu Thành",
                                              "Huyện Cù Lao Dung",
                                              "Huyện Kế Sách",
                                              "Huyện Long Phú",
                                              "Huyện Mỹ Tú",
                                              "Huyện Mỹ Xuyên",
                                              "Huyện Thạnh Trị",
                                              "Huyện Trần Đề",
                                              "TP. Sóc Trăng",
                                              "TX. Ngã Năm",
                                              "TX. Vĩnh Châu"};
                    break;
                case "Sơn La":
                    districts = new string[] {"Huyện Bắc Yên",
                                              "Huyện Mai Sơn",
                                              "Huyện Mộc Châu",
                                              "Huyện Mường La",
                                              "Huyện Phù Yên",
                                              "Huyện Quỳnh Nhai",
                                              "Huyện Sông Mã",
                                              "Huyện Sốp Cộp",
                                              "Huyện Thuận Châu",
                                              "Huyện Vân Hồ",
                                              "Huyện Yên Châu",
                                              "TP. Sơn La"};
                    break;
                case "Tây Ninh":
                    districts = new string[] {"Huyện Bến Cầu",
                                              "Huyện Châu Thành",
                                              "Huyện Dương Minh Châu",
                                              "Huyện Gò Dầu",
                                              "Huyện Tân Biên",
                                              "Huyện Tân Châu",
                                              "TP. Tây Ninh",
                                              "TX. Hòa Thành",
                                              "TX. Trảng Bàng"};
                    break;
                case "Thái Bình":
                    districts = new string[] {"Huyện Đông Hưng",
                                              "Huyện Hưng Hà",
                                              "Huyện Kiến Xương",
                                              "Huyện Quỳnh Phụ",
                                              "Huyện Thái Thụy",
                                              "Huyện Tiền Hải",
                                              "Huyện Vũ Thư",
                                              "TP. Thái Bình"};
                    break;
                case "Thái Nguyên":
                    districts = new string[] {"Huyện Đại Từ",
                                              "Huyện Định Hóa",
                                              "Huyện Đồng Hỷ",
                                              "Huyện Phú Bình",
                                              "Huyện Phú Lương",
                                              "Huyện Võ Nhai",
                                              "TP. Phổ Yên",
                                              "TP. Sông Công",
                                              "TP. Thái Nguyên"};
                    break;
                case "Thanh Hóa":
                    districts = new string[] {"Huyện Bá Thước",
                                              "Huyện Cẩm Thủy",
                                              "Huyện Đông Sơn",
                                              "Huyện Hà Trung",
                                              "Huyện Hậu Lộc",
                                              "Huyện Hoằng Hóa",
                                              "Huyện Lang Chánh",
                                              "Huyện Mường Lát",
                                              "Huyện Nga Sơn",
                                              "Huyện Ngọc Lặc",
                                              "Huyện Như Thanh",
                                              "Huyện Như Xuân",
                                              "Huyện Nông Cống",
                                              "Huyện Quan Hóa",
                                              "Huyện Quan Sơn",
                                              "Huyện Quảng Xương",
                                              "Huyện Thạch Thành",
                                              "Huyện Thiệu Hóa",
                                              "Huyện Thọ Xuân",
                                              "Huyện Thường Xuân",
                                              "Huyện Triệu Sơn",
                                              "Huyện Vĩnh Lộc",
                                              "Huyện Yên Định",
                                              "TP. Sầm Sơn",
                                              "TP. Thanh Hóa",
                                              "TX. Bỉm Sơn",
                                              "TX. Nghi Sơn"};
                    break;
                case "Thừa Thiên - Huế":
                    districts = new string[] {"Huyện A Lưới",
                                              "Huyện Nam Đông",
                                              "Huyện Phong Điền",
                                              "Huyện Phú Lộc",
                                              "Huyện Phú Vang",
                                              "Huyện Quảng Điền",
                                              "TP. Huế",
                                              "TX. Hương Thủy",
                                              "TX. Hương Trà"};
                    break;
                case "Tiền Giang":
                    districts = new string[] {"Huyện Cái Bè",
                                              "Huyện Cai Lậy",
                                              "Huyện Châu Thành",
                                              "Huyện Chợ Gạo",
                                              "Huyện Gò Công Đông",
                                              "Huyện Gò Công Tây",
                                              "Huyện Tân Phú Đông",
                                              "Huyện Tân Phước",
                                              "Thị xã Cai Lậy",
                                              "Thị xã Gò Công",
                                              "TP. Mỹ Tho"};
                    break;
                case "Trà Vinh":
                    districts = new string[] {"Huyện Càng Long",
                                              "Huyện Cầu Kè",
                                              "Huyện Cầu Ngang",
                                              "Huyện Châu Thành",
                                              "Huyện Duyên Hải",
                                              "Huyện Tiểu Cần",
                                              "Huyện Trà Cú",
                                              "TP. Trà Vinh",
                                              "TX. Duyên Hải"};
                    break;
                case "Tuyên Quang":
                    districts = new string[] {"Huyện Chiêm Hóa",
                                              "Huyện Hàm Yên",
                                              "Huyện Lâm Bình",
                                              "Huyện Na Hang",
                                              "Huyện Sơn Dương",
                                              "Huyện Yên Sơn",
                                              "TP. Tuyên Quang"};
                    break;
                case "Vĩnh Long":
                    districts = new string[] {"Huyện Bình Tân",
                                              "Huyện Long Hồ",
                                              "Huyện Mang Thít",
                                              "Huyện Tam Bình",
                                              "Huyện Trà Ôn",
                                              "Huyện Vũng Liêm",
                                              "TP. Vĩnh Long",
                                              "TX. Bình Minh"};
                    break;
                case "Vĩnh Phúc":
                    districts = new string[] {"Huyện Bình Xuyên",
                                              "Huyện Lập Thạch",
                                              "Huyện Sông Lô",
                                              "Huyện Tam Đảo",
                                              "Huyện Tam Dương",
                                              "Huyện Vĩnh Tường",
                                              "Huyện Yên Lạc",
                                              "TP. Phúc Yên",
                                              "TP. Vĩnh Yên"};
                    break;
                case "Yên Bái":
                    districts = new string[] {"Huyện Lục Yên",
                                              "Huyện Mù Cang Chải",
                                              "Huyện Trạm Tấu",
                                              "Huyện Trấn Yên",
                                              "Huyện Văn Chấn",
                                              "Huyện Văn Yên",
                                              "Huyện Yên Bình",
                                              "TP. Yên Bái",
                                              "TX. Nghĩa Lộ"};
                    break;
                default:
                    return; // Nếu không có thành phố nào khớp, không làm gì cả
            }

            // Thêm các quận/huyện vào ComboBox
            foreach (string district in districts)
            {
                cbbDistrict.Items.Add(district);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                lblNoName.Visible = false;
            }
            else
            {
                lblNoName.Visible = true;
            }
        }

        private void txtPhonenumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhonenumber.Text.Length < 10)
            {
                lblNoPhonenumber.Text = "*Vui lòng nhập số điện thoại đủ 10 số";
                lblNoPhonenumber.Visible = true;
            }
            if (txtPhonenumber.Text == "")
            {
                lblNoPhonenumber.Text = "*Vui lòng nhập số điện thoại";

            }
        }

        private void txtPhonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Nếu không phải là số, không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
                lblNoPhonenumber.Text = "*Vui lòng nhập số";
                lblNoPhonenumber.Visible = true;
            }
            else
                lblNoPhonenumber.Visible = false;
        }



        private void cbbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDistrict.ForeColor = Color.Black;
            lblNoDistrict.Visible = false;
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Số nhà tên đường, phường/xã")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.Black;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Số nhà tên đường, phường/xã";
                txtAddress.ForeColor = Color.DarkGray;
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtAddress.Text == "Số nhà tên đường, phường/xã")
            {
                lblNoAddress.Visible = true;
            }    
            else
            {
                lblNoAddress.Visible = false;
            }    
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lblNoName.Visible == false && lblNoPhonenumber.Visible == false && lblNoCity.Visible == false && lblNoDistrict.Visible == false && lblNoAddress.Visible == false && lblNoPayment.Visible == false)
            {
                MessageBox.Show("Bạn đã đặt hàng thành công");
            }    
            else
            {
                MessageBox.Show("Đặt hàng thất bại! Vui lòng kiểm tra lại thông tin bạn đã nhập");
            }    
        }
    }
}
