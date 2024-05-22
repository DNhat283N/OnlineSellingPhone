using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Enities;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using Image = System.Drawing.Image;

namespace WindowsFormsApp1
{
    public partial class Cart_Pay_Momo : Form
    {
        public Cart_Pay_Momo()
        {
            InitializeComponent();
        }


        private List<Phone> productsByManufacturerName = new List<Phone>();
        private static DAO.PRICE_FILTER SORT_BY = DAO.PRICE_FILTER.NONE;
        private static string KEYWORD = "";
        private static string MANUFACTURER_NAME = "";

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

        double total = 0;
        private double totalPrice(List<Phone> phones)
        {
            if (phones.Count() != 0)
            {
                try
                {
                    phones.ForEach(p =>
                    {
                        Cart_ProductInCart product = new Cart_ProductInCart();
                        Label lblPrice = (Label)product.Controls.Find("lblPrice", true).FirstOrDefault();
                        total += Convert.ToDouble(p.Phone_Price);
                        lblTotalPrice.Text = Convert.ToString(PriceFormat(total));
                    });
                }
                catch
                {

                }
            }
            return total;
        }
        private void listphone()
        {
            productsByManufacturerName = DAO.QueryPhoneTableBySearchKeywordOrByManuFacturerNameAndFilterByPrice(KEYWORD, MANUFACTURER_NAME, SORT_BY);
        }

        private void Cart_Pay_Momo_Load(object sender, EventArgs e)
        {
            listphone();
            var qrcode_text = $"2|99|0387965097|Truong Minh Tri|truongminhtri1507@gmail.com|0|0|{totalPrice(productsByManufacturerName)}|";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 380, Height = 380, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            Bitmap logo = resizeImage(Properties.Resources.momo, 64, 64) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            pcb_qrCode.Image = bitmap;
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }
    }
}
