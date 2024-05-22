
namespace WindowsFormsApp1
{
    partial class Product_admin
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
            this.lsbSuggestions = new System.Windows.Forms.ListBox();
            this.lblClearSearch = new System.Windows.Forms.Label();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.btnPricefilter = new WindowsFormsApp1.DSButton();
            this.btnSearch = new WindowsFormsApp1.DSButton();
            this.btnRealme = new WindowsFormsApp1.DSButton();
            this.btnXiaomi = new WindowsFormsApp1.DSButton();
            this.btnOppo = new WindowsFormsApp1.DSButton();
            this.btnApple = new WindowsFormsApp1.DSButton();
            this.btnSamsung = new WindowsFormsApp1.DSButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new WindowsFormsApp1.DSButton();
            this.SuspendLayout();
            // 
            // lsbSuggestions
            // 
            this.lsbSuggestions.FormattingEnabled = true;
            this.lsbSuggestions.ItemHeight = 23;
            this.lsbSuggestions.Location = new System.Drawing.Point(392, 66);
            this.lsbSuggestions.Name = "lsbSuggestions";
            this.lsbSuggestions.Size = new System.Drawing.Size(351, 4);
            this.lsbSuggestions.TabIndex = 64;
            this.lsbSuggestions.Visible = false;
            this.lsbSuggestions.SelectedIndexChanged += new System.EventHandler(this.lsbSuggestions_SelectedIndexChanged);
            // 
            // lblClearSearch
            // 
            this.lblClearSearch.BackColor = System.Drawing.Color.Tomato;
            this.lblClearSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearSearch.Location = new System.Drawing.Point(363, 27);
            this.lblClearSearch.Name = "lblClearSearch";
            this.lblClearSearch.Size = new System.Drawing.Size(23, 29);
            this.lblClearSearch.TabIndex = 63;
            this.lblClearSearch.Text = "X";
            this.lblClearSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClearSearch.Visible = false;
            this.lblClearSearch.Click += new System.EventHandler(this.lblClearSearch_Click);
            // 
            // pnlProduct
            // 
            this.pnlProduct.AutoScroll = true;
            this.pnlProduct.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProduct.Location = new System.Drawing.Point(0, 152);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1171, 444);
            this.pnlProduct.TabIndex = 62;
            // 
            // btnPricefilter
            // 
            this.btnPricefilter.BackColor = System.Drawing.Color.White;
            this.btnPricefilter.BackgroundColor = System.Drawing.Color.White;
            this.btnPricefilter.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPricefilter.BorderRadius = 20;
            this.btnPricefilter.BorderSize = 1;
            this.btnPricefilter.FlatAppearance.BorderSize = 0;
            this.btnPricefilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPricefilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricefilter.ForeColor = System.Drawing.Color.Black;
            this.btnPricefilter.Location = new System.Drawing.Point(1052, 100);
            this.btnPricefilter.Name = "btnPricefilter";
            this.btnPricefilter.Size = new System.Drawing.Size(81, 46);
            this.btnPricefilter.TabIndex = 61;
            this.btnPricefilter.Text = "Giá ↑↓";
            this.btnPricefilter.TextColor = System.Drawing.Color.Black;
            this.btnPricefilter.UseVisualStyleBackColor = false;
            this.btnPricefilter.Click += new System.EventHandler(this.btnPricefilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.BorderSize = 1;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(749, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 50);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRealme
            // 
            this.btnRealme.BackColor = System.Drawing.Color.White;
            this.btnRealme.BackgroundColor = System.Drawing.Color.White;
            this.btnRealme.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRealme.BorderRadius = 20;
            this.btnRealme.BorderSize = 1;
            this.btnRealme.FlatAppearance.BorderSize = 0;
            this.btnRealme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealme.ForeColor = System.Drawing.Color.Black;
            this.btnRealme.Location = new System.Drawing.Point(847, 76);
            this.btnRealme.Name = "btnRealme";
            this.btnRealme.Size = new System.Drawing.Size(159, 50);
            this.btnRealme.TabIndex = 59;
            this.btnRealme.Text = "realme";
            this.btnRealme.TextColor = System.Drawing.Color.Black;
            this.btnRealme.UseVisualStyleBackColor = false;
            this.btnRealme.Click += new System.EventHandler(this.btnClickEvent);
            // 
            // btnXiaomi
            // 
            this.btnXiaomi.BackColor = System.Drawing.Color.White;
            this.btnXiaomi.BackgroundColor = System.Drawing.Color.White;
            this.btnXiaomi.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXiaomi.BorderRadius = 20;
            this.btnXiaomi.BorderSize = 1;
            this.btnXiaomi.FlatAppearance.BorderSize = 0;
            this.btnXiaomi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXiaomi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXiaomi.ForeColor = System.Drawing.Color.Black;
            this.btnXiaomi.Location = new System.Drawing.Point(664, 76);
            this.btnXiaomi.Name = "btnXiaomi";
            this.btnXiaomi.Size = new System.Drawing.Size(159, 50);
            this.btnXiaomi.TabIndex = 58;
            this.btnXiaomi.Tag = "Product";
            this.btnXiaomi.Text = "xiaomi";
            this.btnXiaomi.TextColor = System.Drawing.Color.Black;
            this.btnXiaomi.UseVisualStyleBackColor = false;
            this.btnXiaomi.Click += new System.EventHandler(this.btnClickEvent);
            // 
            // btnOppo
            // 
            this.btnOppo.BackColor = System.Drawing.Color.White;
            this.btnOppo.BackgroundColor = System.Drawing.Color.White;
            this.btnOppo.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOppo.BorderRadius = 20;
            this.btnOppo.BorderSize = 1;
            this.btnOppo.FlatAppearance.BorderSize = 0;
            this.btnOppo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOppo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOppo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOppo.Location = new System.Drawing.Point(480, 76);
            this.btnOppo.Name = "btnOppo";
            this.btnOppo.Size = new System.Drawing.Size(159, 50);
            this.btnOppo.TabIndex = 57;
            this.btnOppo.Tag = "Product";
            this.btnOppo.Text = "oppo";
            this.btnOppo.TextColor = System.Drawing.Color.SeaGreen;
            this.btnOppo.UseVisualStyleBackColor = false;
            this.btnOppo.Click += new System.EventHandler(this.btnClickEvent);
            // 
            // btnApple
            // 
            this.btnApple.BackColor = System.Drawing.Color.White;
            this.btnApple.BackgroundColor = System.Drawing.Color.White;
            this.btnApple.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApple.BorderRadius = 20;
            this.btnApple.BorderSize = 1;
            this.btnApple.FlatAppearance.BorderSize = 0;
            this.btnApple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApple.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApple.ForeColor = System.Drawing.Color.Black;
            this.btnApple.Location = new System.Drawing.Point(304, 76);
            this.btnApple.Name = "btnApple";
            this.btnApple.Size = new System.Drawing.Size(159, 50);
            this.btnApple.TabIndex = 56;
            this.btnApple.Tag = "Product";
            this.btnApple.Text = "Apple";
            this.btnApple.TextColor = System.Drawing.Color.Black;
            this.btnApple.UseVisualStyleBackColor = false;
            this.btnApple.Click += new System.EventHandler(this.btnClickEvent);
            // 
            // btnSamsung
            // 
            this.btnSamsung.BackColor = System.Drawing.Color.White;
            this.btnSamsung.BackgroundColor = System.Drawing.Color.White;
            this.btnSamsung.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSamsung.BorderRadius = 20;
            this.btnSamsung.BorderSize = 1;
            this.btnSamsung.FlatAppearance.BorderSize = 0;
            this.btnSamsung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSamsung.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSamsung.ForeColor = System.Drawing.Color.Black;
            this.btnSamsung.Location = new System.Drawing.Point(125, 76);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(159, 50);
            this.btnSamsung.TabIndex = 55;
            this.btnSamsung.Tag = "Product";
            this.btnSamsung.Text = "SAMSUNG";
            this.btnSamsung.TextColor = System.Drawing.Color.Black;
            this.btnSamsung.UseVisualStyleBackColor = false;
            this.btnSamsung.Click += new System.EventHandler(this.btnClickEvent);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(392, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(351, 36);
            this.txtSearch.TabIndex = 54;
            this.txtSearch.Text = "Tìm theo tên điện thoại ";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Salmon;
            this.btnAdd.BackgroundColor = System.Drawing.Color.Salmon;
            this.btnAdd.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(991, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 50);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Thêm SP";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Product_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsbSuggestions);
            this.Controls.Add(this.lblClearSearch);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.btnPricefilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRealme);
            this.Controls.Add(this.btnXiaomi);
            this.Controls.Add(this.btnOppo);
            this.Controls.Add(this.btnApple);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_admin";
            this.Size = new System.Drawing.Size(1171, 596);
            this.Load += new System.EventHandler(this.Mall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbSuggestions;
        private System.Windows.Forms.Label lblClearSearch;
        private System.Windows.Forms.Panel pnlProduct;
        private DSButton btnPricefilter;
        private DSButton btnSearch;
        private DSButton btnRealme;
        private DSButton btnXiaomi;
        private DSButton btnOppo;
        private DSButton btnApple;
        private DSButton btnSamsung;
        private System.Windows.Forms.TextBox txtSearch;
        private DSButton btnAdd;
    }
}
