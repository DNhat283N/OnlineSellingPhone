
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
            this.fpnlProductCart = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCustomerDetail = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbCity = new System.Windows.Forms.ComboBox();
            this.cbbWards = new System.Windows.Forms.ComboBox();
            this.cbbDistrict = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPayCash = new WindowsFormsApp1.DSButton();
            this.btnPaypal = new WindowsFormsApp1.DSButton();
            this.btnOrder = new WindowsFormsApp1.DSButton();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlCustomerDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlProductCart
            // 
            this.fpnlProductCart.AutoSize = true;
            this.fpnlProductCart.BackColor = System.Drawing.Color.White;
            this.fpnlProductCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlProductCart.Location = new System.Drawing.Point(109, 148);
            this.fpnlProductCart.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlProductCart.Name = "fpnlProductCart";
            this.fpnlProductCart.Size = new System.Drawing.Size(957, 169);
            this.fpnlProductCart.TabIndex = 6;
            this.fpnlProductCart.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 80);
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
            this.label1.Location = new System.Drawing.Point(474, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn hàng";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(957, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "_________________________________________________________________________________" +
    "_________________________";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 326);
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
            this.pnlCustomerDetail.Controls.Add(this.btnOrder);
            this.pnlCustomerDetail.Controls.Add(this.btnPaypal);
            this.pnlCustomerDetail.Controls.Add(this.btnPayCash);
            this.pnlCustomerDetail.Controls.Add(this.label10);
            this.pnlCustomerDetail.Controls.Add(this.label9);
            this.pnlCustomerDetail.Controls.Add(this.txtNote);
            this.pnlCustomerDetail.Controls.Add(this.txtAddress);
            this.pnlCustomerDetail.Controls.Add(this.cbbDistrict);
            this.pnlCustomerDetail.Controls.Add(this.cbbWards);
            this.pnlCustomerDetail.Controls.Add(this.cbbCity);
            this.pnlCustomerDetail.Controls.Add(this.label8);
            this.pnlCustomerDetail.Controls.Add(this.txtPhone);
            this.pnlCustomerDetail.Controls.Add(this.label7);
            this.pnlCustomerDetail.Controls.Add(this.label6);
            this.pnlCustomerDetail.Controls.Add(this.txtName);
            this.pnlCustomerDetail.Controls.Add(this.label5);
            this.pnlCustomerDetail.Location = new System.Drawing.Point(109, 362);
            this.pnlCustomerDetail.Name = "pnlCustomerDetail";
            this.pnlCustomerDetail.Size = new System.Drawing.Size(957, 523);
            this.pnlCustomerDetail.TabIndex = 9;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 32);
            this.txtName.TabIndex = 13;
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
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(252, 121);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(291, 32);
            this.txtPhone.TabIndex = 16;
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
            // cbbCity
            // 
            this.cbbCity.FormattingEnabled = true;
            this.cbbCity.Location = new System.Drawing.Point(252, 182);
            this.cbbCity.Name = "cbbCity";
            this.cbbCity.Size = new System.Drawing.Size(291, 31);
            this.cbbCity.TabIndex = 18;
            // 
            // cbbWards
            // 
            this.cbbWards.FormattingEnabled = true;
            this.cbbWards.Location = new System.Drawing.Point(252, 237);
            this.cbbWards.Name = "cbbWards";
            this.cbbWards.Size = new System.Drawing.Size(291, 31);
            this.cbbWards.TabIndex = 20;
            // 
            // cbbDistrict
            // 
            this.cbbDistrict.FormattingEnabled = true;
            this.cbbDistrict.Location = new System.Drawing.Point(611, 182);
            this.cbbDistrict.Name = "cbbDistrict";
            this.cbbDistrict.Size = new System.Drawing.Size(291, 31);
            this.cbbDistrict.TabIndex = 21;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(611, 236);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(291, 32);
            this.txtAddress.TabIndex = 22;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(252, 375);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(650, 32);
            this.txtNote.TabIndex = 23;
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
            this.btnPaypal.Text = "Paypal";
            this.btnPaypal.TextColor = System.Drawing.Color.Black;
            this.btnPaypal.UseVisualStyleBackColor = false;
            this.btnPaypal.Click += new System.EventHandler(this.btnPaypal_Click);
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
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(109, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(957, 867);
            this.label11.TabIndex = 40;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCustomerDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fpnlProductCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(1171, 596);
            this.SizeChanged += new System.EventHandler(this.Cart_SizeChanged);
            this.pnlCustomerDetail.ResumeLayout(false);
            this.pnlCustomerDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlProductCart;
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
        private System.Windows.Forms.ComboBox cbbWards;
        private System.Windows.Forms.ComboBox cbbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private DSButton btnPayCash;
        private DSButton btnOrder;
        private DSButton btnPaypal;
        private System.Windows.Forms.Label label11;
    }
}
