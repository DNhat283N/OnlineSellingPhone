
namespace WindowsFormsApp1
{
    partial class Cart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCustomerDetail = new System.Windows.Forms.Panel();
            this.lblNoPayment = new System.Windows.Forms.Label();
            this.lblNoDistrict = new System.Windows.Forms.Label();
            this.lblNoCity = new System.Windows.Forms.Label();
            this.lblNoAddress = new System.Windows.Forms.Label();
            this.lblNoPhonenumber = new System.Windows.Forms.Label();
            this.lblNoName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbbDistrict = new System.Windows.Forms.ComboBox();
            this.cbbCity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.btnOrder = new WindowsFormsApp1.DSButton();
            this.btnPaypal = new WindowsFormsApp1.DSButton();
            this.btnPayCash = new WindowsFormsApp1.DSButton();
            this.pnlCustomerDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sản phẩm trong giỏ hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn hàng";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(957, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "_________________________________________________________________________________" +
    "_________________________";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(106, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(957, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "_________________________________________________________________________________" +
    "_________________________";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnlCustomerDetail
            // 
            this.pnlCustomerDetail.AutoSize = true;
            this.pnlCustomerDetail.BackColor = System.Drawing.Color.White;
            this.pnlCustomerDetail.Controls.Add(this.lblNoPayment);
            this.pnlCustomerDetail.Controls.Add(this.lblNoDistrict);
            this.pnlCustomerDetail.Controls.Add(this.lblNoCity);
            this.pnlCustomerDetail.Controls.Add(this.lblNoAddress);
            this.pnlCustomerDetail.Controls.Add(this.lblNoPhonenumber);
            this.pnlCustomerDetail.Controls.Add(this.lblNoName);
            this.pnlCustomerDetail.Controls.Add(this.btnOrder);
            this.pnlCustomerDetail.Controls.Add(this.btnPaypal);
            this.pnlCustomerDetail.Controls.Add(this.btnPayCash);
            this.pnlCustomerDetail.Controls.Add(this.label10);
            this.pnlCustomerDetail.Controls.Add(this.label9);
            this.pnlCustomerDetail.Controls.Add(this.txtNote);
            this.pnlCustomerDetail.Controls.Add(this.txtAddress);
            this.pnlCustomerDetail.Controls.Add(this.cbbDistrict);
            this.pnlCustomerDetail.Controls.Add(this.cbbCity);
            this.pnlCustomerDetail.Controls.Add(this.label8);
            this.pnlCustomerDetail.Controls.Add(this.txtPhonenumber);
            this.pnlCustomerDetail.Controls.Add(this.label7);
            this.pnlCustomerDetail.Controls.Add(this.label6);
            this.pnlCustomerDetail.Controls.Add(this.txtName);
            this.pnlCustomerDetail.Controls.Add(this.label5);
            this.pnlCustomerDetail.Location = new System.Drawing.Point(106, 462);
            this.pnlCustomerDetail.Name = "pnlCustomerDetail";
            this.pnlCustomerDetail.Size = new System.Drawing.Size(957, 523);
            this.pnlCustomerDetail.TabIndex = 9;
            // 
            // lblNoPayment
            // 
            this.lblNoPayment.AutoSize = true;
            this.lblNoPayment.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPayment.ForeColor = System.Drawing.Color.Red;
            this.lblNoPayment.Location = new System.Drawing.Point(325, 355);
            this.lblNoPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPayment.Name = "lblNoPayment";
            this.lblNoPayment.Size = new System.Drawing.Size(287, 17);
            this.lblNoPayment.TabIndex = 45;
            this.lblNoPayment.Text = "* Vui lòng chọn phương thức thanh toán";
            // 
            // lblNoDistrict
            // 
            this.lblNoDistrict.AutoSize = true;
            this.lblNoDistrict.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDistrict.ForeColor = System.Drawing.Color.Red;
            this.lblNoDistrict.Location = new System.Drawing.Point(623, 216);
            this.lblNoDistrict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoDistrict.Name = "lblNoDistrict";
            this.lblNoDistrict.Size = new System.Drawing.Size(195, 17);
            this.lblNoDistrict.TabIndex = 44;
            this.lblNoDistrict.Text = "* Vui lòng chọn quận huyện";
            // 
            // lblNoCity
            // 
            this.lblNoCity.AutoSize = true;
            this.lblNoCity.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCity.ForeColor = System.Drawing.Color.Red;
            this.lblNoCity.Location = new System.Drawing.Point(261, 216);
            this.lblNoCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoCity.Name = "lblNoCity";
            this.lblNoCity.Size = new System.Drawing.Size(189, 17);
            this.lblNoCity.TabIndex = 43;
            this.lblNoCity.Text = "* Vui lòng chọn thành phố";
            // 
            // lblNoAddress
            // 
            this.lblNoAddress.AutoSize = true;
            this.lblNoAddress.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAddress.ForeColor = System.Drawing.Color.Red;
            this.lblNoAddress.Location = new System.Drawing.Point(261, 276);
            this.lblNoAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoAddress.Name = "lblNoAddress";
            this.lblNoAddress.Size = new System.Drawing.Size(165, 17);
            this.lblNoAddress.TabIndex = 42;
            this.lblNoAddress.Text = "* Vui lòng nhập địa chỉ";
            // 
            // lblNoPhonenumber
            // 
            this.lblNoPhonenumber.AutoSize = true;
            this.lblNoPhonenumber.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPhonenumber.ForeColor = System.Drawing.Color.Red;
            this.lblNoPhonenumber.Location = new System.Drawing.Point(261, 156);
            this.lblNoPhonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPhonenumber.Name = "lblNoPhonenumber";
            this.lblNoPhonenumber.Size = new System.Drawing.Size(202, 17);
            this.lblNoPhonenumber.TabIndex = 41;
            this.lblNoPhonenumber.Text = "* Vui lòng nhập số điện thoại";
            // 
            // lblNoName
            // 
            this.lblNoName.AutoSize = true;
            this.lblNoName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoName.ForeColor = System.Drawing.Color.Red;
            this.lblNoName.Location = new System.Drawing.Point(261, 95);
            this.lblNoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoName.Name = "lblNoName";
            this.lblNoName.Size = new System.Drawing.Size(140, 17);
            this.lblNoName.TabIndex = 40;
            this.lblNoName.Text = "* Vui lòng nhập tên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(48, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Phương thức thanh toán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(48, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Lưu ý cho đơn hàng";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(252, 375);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(650, 32);
            this.txtNote.TabIndex = 23;
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAddress.Location = new System.Drawing.Point(252, 236);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(650, 32);
            this.txtAddress.TabIndex = 22;
            this.txtAddress.Text = "Số nhà tên đường, phường/xã";
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // cbbDistrict
            // 
            this.cbbDistrict.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbDistrict.FormattingEnabled = true;
            this.cbbDistrict.Location = new System.Drawing.Point(611, 182);
            this.cbbDistrict.Name = "cbbDistrict";
            this.cbbDistrict.Size = new System.Drawing.Size(291, 31);
            this.cbbDistrict.TabIndex = 21;
            this.cbbDistrict.Text = "Quận/Huyện";
            this.cbbDistrict.SelectedIndexChanged += new System.EventHandler(this.cbbDistrict_SelectedIndexChanged);
            // 
            // cbbCity
            // 
            this.cbbCity.DropDownHeight = 100;
            this.cbbCity.DropDownWidth = 50;
            this.cbbCity.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbCity.FormattingEnabled = true;
            this.cbbCity.IntegralHeight = false;
            this.cbbCity.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bạc Liêu",
            "Bắc Kạn",
            "Bắc Giang",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Đồng Nai",
            "Đồng Tháp",
            "Điện Biên",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hòa Bình",
            "Hậu Giang",
            "Hưng Yên",
            "Thành phố Hồ Chí Minh",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lào Cai",
            "Lạng Sơn",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên - Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cbbCity.Location = new System.Drawing.Point(252, 182);
            this.cbbCity.Name = "cbbCity";
            this.cbbCity.Size = new System.Drawing.Size(291, 31);
            this.cbbCity.TabIndex = 18;
            this.cbbCity.Text = "Tỉnh/Thành phố";
            this.cbbCity.SelectedIndexChanged += new System.EventHandler(this.cbbCity_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(48, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Địa chỉ";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(252, 121);
            this.txtPhonenumber.MaxLength = 10;
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(291, 32);
            this.txtPhonenumber.TabIndex = 16;
            this.txtPhonenumber.TextChanged += new System.EventHandler(this.txtPhonenumber_TextChanged);
            this.txtPhonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhonenumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 32);
            this.txtName.TabIndex = 13;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thông tin khách hàng";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(106, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(957, 867);
            this.label11.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(154, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 23);
            this.label13.TabIndex = 47;
            this.label13.Text = "Tổng sản phẩm";
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.BackColor = System.Drawing.Color.White;
            this.lblTotalProduct.Location = new System.Drawing.Point(340, 362);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(147, 23);
            this.lblTotalProduct.TabIndex = 48;
            this.lblTotalProduct.Text = "Tổng sản phẩm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(154, 403);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 23);
            this.label15.TabIndex = 49;
            this.label15.Text = "Tổng tiền";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(340, 403);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(89, 23);
            this.lblTotalPrice.TabIndex = 50;
            this.lblTotalPrice.Text = "Tổng tiền";
            // 
            // pnlProduct
            // 
            this.pnlProduct.AutoScroll = true;
            this.pnlProduct.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlProduct.Location = new System.Drawing.Point(198, 169);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(764, 169);
            this.pnlProduct.TabIndex = 51;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Coral;
            this.btnOrder.BackgroundColor = System.Drawing.Color.Coral;
            this.btnOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOrder.BorderRadius = 20;
            this.btnOrder.BorderSize = 0;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(403, 426);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(171, 58);
            this.btnOrder.TabIndex = 39;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.TextColor = System.Drawing.Color.White;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPaypal
            // 
            this.btnPaypal.BackColor = System.Drawing.Color.White;
            this.btnPaypal.BackgroundColor = System.Drawing.Color.White;
            this.btnPaypal.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaypal.BorderRadius = 20;
            this.btnPaypal.BorderSize = 1;
            this.btnPaypal.FlatAppearance.BorderSize = 0;
            this.btnPaypal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaypal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaypal.ForeColor = System.Drawing.Color.Black;
            this.btnPaypal.Location = new System.Drawing.Point(505, 296);
            this.btnPaypal.Name = "btnPaypal";
            this.btnPaypal.Size = new System.Drawing.Size(159, 50);
            this.btnPaypal.TabIndex = 38;
            this.btnPaypal.Tag = "";
            this.btnPaypal.Text = "Momo";
            this.btnPaypal.TextColor = System.Drawing.Color.Black;
            this.btnPaypal.UseVisualStyleBackColor = false;
            this.btnPaypal.Click += new System.EventHandler(this.btnPaypal_Click);
            // 
            // btnPayCash
            // 
            this.btnPayCash.BackColor = System.Drawing.Color.White;
            this.btnPayCash.BackgroundColor = System.Drawing.Color.White;
            this.btnPayCash.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayCash.BorderRadius = 20;
            this.btnPayCash.BorderSize = 1;
            this.btnPayCash.FlatAppearance.BorderSize = 0;
            this.btnPayCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayCash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayCash.ForeColor = System.Drawing.Color.Black;
            this.btnPayCash.Location = new System.Drawing.Point(319, 296);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(159, 50);
            this.btnPayCash.TabIndex = 37;
            this.btnPayCash.Tag = "";
            this.btnPayCash.Text = "Khi nhận hàng";
            this.btnPayCash.TextColor = System.Drawing.Color.Black;
            this.btnPayCash.UseVisualStyleBackColor = false;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTotalProduct);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pnlCustomerDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(1171, 596);
            this.Load += new System.EventHandler(this.Cart_Load);
            this.SizeChanged += new System.EventHandler(this.Cart_SizeChanged);
            this.pnlCustomerDetail.ResumeLayout(false);
            this.pnlCustomerDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCustomerDetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbbDistrict;
        private System.Windows.Forms.ComboBox cbbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private DSButton btnPayCash;
        private DSButton btnOrder;
        private DSButton btnPaypal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNoName;
        private System.Windows.Forms.Label lblNoPhonenumber;
        private System.Windows.Forms.Label lblNoDistrict;
        private System.Windows.Forms.Label lblNoCity;
        private System.Windows.Forms.Label lblNoAddress;
        private System.Windows.Forms.Label lblNoPayment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Panel pnlProduct;
    }
}
