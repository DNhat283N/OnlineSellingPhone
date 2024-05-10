
namespace WindowsFormsApp1
{
    partial class Product_add_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_add_admin));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblForm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.pcbProductImage = new System.Windows.Forms.PictureBox();
            this.btnCancel = new WindowsFormsApp1.DSButton();
            this.btnAdd = new WindowsFormsApp1.DSButton();
            this.btnBrowse = new WindowsFormsApp1.DSButton();
            this.lblNoName = new System.Windows.Forms.Label();
            this.lblNoManufacturer = new System.Windows.Forms.Label();
            this.lblNoColor = new System.Windows.Forms.Label();
            this.lblNoPrice = new System.Windows.Forms.Label();
            this.lblNoQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblForm
            // 
            this.lblForm.BackColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(0, 144);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(1171, 357);
            this.lblForm.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 178);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 32);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhà sản xuất";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(203, 242);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(366, 32);
            this.txtManufacturer.TabIndex = 6;
            this.txtManufacturer.TextChanged += new System.EventHandler(this.txtManufacturer_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Màu";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(203, 304);
            this.txtColor.MaxLength = 7;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(366, 32);
            this.txtColor.TabIndex = 8;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giá";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(203, 368);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(366, 32);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số lượng";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(203, 426);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 32);
            this.nudQuantity.TabIndex = 12;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // pcbProductImage
            // 
            this.pcbProductImage.BackColor = System.Drawing.Color.White;
            this.pcbProductImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbProductImage.Image")));
            this.pcbProductImage.Location = new System.Drawing.Point(822, 168);
            this.pcbProductImage.Name = "pcbProductImage";
            this.pcbProductImage.Size = new System.Drawing.Size(232, 226);
            this.pcbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProductImage.TabIndex = 13;
            this.pcbProductImage.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(262, 517);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 51);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Salmon;
            this.btnAdd.BackgroundColor = System.Drawing.Color.Salmon;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(79, 517);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 51);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBrowse.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnBrowse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBrowse.BorderRadius = 20;
            this.btnBrowse.BorderSize = 0;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(868, 426);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(155, 51);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Chọn hình";
            this.btnBrowse.TextColor = System.Drawing.Color.White;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblNoName
            // 
            this.lblNoName.AutoSize = true;
            this.lblNoName.BackColor = System.Drawing.Color.White;
            this.lblNoName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoName.ForeColor = System.Drawing.Color.Red;
            this.lblNoName.Location = new System.Drawing.Point(226, 213);
            this.lblNoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoName.Name = "lblNoName";
            this.lblNoName.Size = new System.Drawing.Size(211, 17);
            this.lblNoName.TabIndex = 41;
            this.lblNoName.Text = "* Vui lòng nhập tên sản phẩm";
            // 
            // lblNoManufacturer
            // 
            this.lblNoManufacturer.AutoSize = true;
            this.lblNoManufacturer.BackColor = System.Drawing.Color.White;
            this.lblNoManufacturer.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoManufacturer.ForeColor = System.Drawing.Color.Red;
            this.lblNoManufacturer.Location = new System.Drawing.Point(226, 277);
            this.lblNoManufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoManufacturer.Name = "lblNoManufacturer";
            this.lblNoManufacturer.Size = new System.Drawing.Size(203, 17);
            this.lblNoManufacturer.TabIndex = 42;
            this.lblNoManufacturer.Text = "* Vui lòng nhập nhà sản xuất";
            // 
            // lblNoColor
            // 
            this.lblNoColor.AutoSize = true;
            this.lblNoColor.BackColor = System.Drawing.Color.White;
            this.lblNoColor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoColor.ForeColor = System.Drawing.Color.Red;
            this.lblNoColor.Location = new System.Drawing.Point(226, 339);
            this.lblNoColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoColor.Name = "lblNoColor";
            this.lblNoColor.Size = new System.Drawing.Size(177, 17);
            this.lblNoColor.TabIndex = 43;
            this.lblNoColor.Text = "* Vui lòng nhập mã màu";
            // 
            // lblNoPrice
            // 
            this.lblNoPrice.AutoSize = true;
            this.lblNoPrice.BackColor = System.Drawing.Color.White;
            this.lblNoPrice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPrice.ForeColor = System.Drawing.Color.Red;
            this.lblNoPrice.Location = new System.Drawing.Point(226, 403);
            this.lblNoPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPrice.Name = "lblNoPrice";
            this.lblNoPrice.Size = new System.Drawing.Size(139, 17);
            this.lblNoPrice.TabIndex = 44;
            this.lblNoPrice.Text = "* Vui lòng nhập giá";
            // 
            // lblNoQuantity
            // 
            this.lblNoQuantity.AutoSize = true;
            this.lblNoQuantity.BackColor = System.Drawing.Color.White;
            this.lblNoQuantity.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblNoQuantity.Location = new System.Drawing.Point(226, 460);
            this.lblNoQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoQuantity.Name = "lblNoQuantity";
            this.lblNoQuantity.Size = new System.Drawing.Size(245, 17);
            this.lblNoQuantity.TabIndex = 45;
            this.lblNoQuantity.Text = "* Vui lòng chỉnh số lượng sản phẩm";
            // 
            // Product_add_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoQuantity);
            this.Controls.Add(this.lblNoPrice);
            this.Controls.Add(this.lblNoColor);
            this.Controls.Add(this.lblNoManufacturer);
            this.Controls.Add(this.lblNoName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pcbProductImage);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblForm);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_add_admin";
            this.Size = new System.Drawing.Size(1171, 596);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.PictureBox pcbProductImage;
        private DSButton btnBrowse;
        private DSButton btnAdd;
        private DSButton btnCancel;
        private System.Windows.Forms.Label lblNoName;
        private System.Windows.Forms.Label lblNoManufacturer;
        private System.Windows.Forms.Label lblNoColor;
        private System.Windows.Forms.Label lblNoPrice;
        private System.Windows.Forms.Label lblNoQuantity;
    }
}
