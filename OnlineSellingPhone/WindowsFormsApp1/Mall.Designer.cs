
namespace WindowsFormsApp1
{
    partial class Mall
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lblClearSearch = new System.Windows.Forms.Label();
            this.lsbSuggestions = new System.Windows.Forms.ListBox();
            this.btnPricefilter = new WindowsFormsApp1.DSButton();
            this.btnSearch = new WindowsFormsApp1.DSButton();
            this.btnRealme = new WindowsFormsApp1.DSButton();
            this.btnXiaomi = new WindowsFormsApp1.DSButton();
            this.btnOppo = new WindowsFormsApp1.DSButton();
            this.btnApple = new WindowsFormsApp1.DSButton();
            this.btnSamsung = new WindowsFormsApp1.DSButton();
            this.mall_Product6 = new WindowsFormsApp1.Mall_Product();
            this.mall_Product7 = new WindowsFormsApp1.Mall_Product();
            this.mall_Product4 = new WindowsFormsApp1.Mall_Product();
            this.mall_Product8 = new WindowsFormsApp1.Mall_Product();
            this.mall_Product5 = new WindowsFormsApp1.Mall_Product();
            this.mall_Product9 = new WindowsFormsApp1.Mall_Product();
            this.mall_Product3 = new WindowsFormsApp1.Mall_Product();
            this.mall_Product2 = new WindowsFormsApp1.Mall_Product();
            this.mall_Product1 = new WindowsFormsApp1.Mall_Product();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(392, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(351, 36);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Text = "Tìm theo tên điện thoại ";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pnlProduct
            // 
            this.pnlProduct.AutoScroll = true;
            this.pnlProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProduct.Location = new System.Drawing.Point(0, 152);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1171, 444);
            this.pnlProduct.TabIndex = 42;
            // 
            // lblClearSearch
            // 
            this.lblClearSearch.BackColor = System.Drawing.Color.Tomato;
            this.lblClearSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearSearch.Location = new System.Drawing.Point(363, 27);
            this.lblClearSearch.Name = "lblClearSearch";
            this.lblClearSearch.Size = new System.Drawing.Size(23, 29);
            this.lblClearSearch.TabIndex = 43;
            this.lblClearSearch.Text = "X";
            this.lblClearSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClearSearch.Visible = false;
            this.lblClearSearch.Click += new System.EventHandler(this.lblClearSearch_Click);
            // 
            // lsbSuggestions
            // 
            this.lsbSuggestions.FormattingEnabled = true;
            this.lsbSuggestions.ItemHeight = 23;
            this.lsbSuggestions.Location = new System.Drawing.Point(392, 66);
            this.lsbSuggestions.Name = "lsbSuggestions";
            this.lsbSuggestions.Size = new System.Drawing.Size(351, 4);
            this.lsbSuggestions.TabIndex = 44;
            this.lsbSuggestions.Visible = false;
            this.lsbSuggestions.SelectedIndexChanged += new System.EventHandler(this.lsbSuggestions_SelectedIndexChanged);
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
            this.btnPricefilter.TabIndex = 41;
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
            this.btnSearch.TabIndex = 40;
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
            this.btnRealme.TabIndex = 39;
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
            this.btnXiaomi.TabIndex = 38;
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
            this.btnOppo.TabIndex = 37;
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
            this.btnApple.TabIndex = 36;
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
            this.btnSamsung.TabIndex = 35;
            this.btnSamsung.Tag = "Product";
            this.btnSamsung.Text = "SAMSUNG";
            this.btnSamsung.TextColor = System.Drawing.Color.Black;
            this.btnSamsung.UseVisualStyleBackColor = false;
            this.btnSamsung.Click += new System.EventHandler(this.btnClickEvent);
            // 
            // mall_Product6
            // 
            this.mall_Product6.AutoSize = true;
            this.mall_Product6.BackColor = System.Drawing.Color.White;
            this.mall_Product6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mall_Product6.Location = new System.Drawing.Point(0, 0);
            this.mall_Product6.Margin = new System.Windows.Forms.Padding(4);
            this.mall_Product6.Name = "mall_Product6";
            this.mall_Product6.Size = new System.Drawing.Size(357, 357);
            this.mall_Product6.TabIndex = 0;
            // 
            // mall_Product7
            // 
            this.mall_Product7.AutoSize = true;
            this.mall_Product7.BackColor = System.Drawing.Color.White;
            this.mall_Product7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mall_Product7.Location = new System.Drawing.Point(0, 0);
            this.mall_Product7.Margin = new System.Windows.Forms.Padding(4);
            this.mall_Product7.Name = "mall_Product7";
            this.mall_Product7.Size = new System.Drawing.Size(357, 357);
            this.mall_Product7.TabIndex = 1;
            // 
            // mall_Product4
            // 
            this.mall_Product4.AutoSize = true;
            this.mall_Product4.BackColor = System.Drawing.Color.White;
            this.mall_Product4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mall_Product4.Location = new System.Drawing.Point(0, 0);
            this.mall_Product4.Margin = new System.Windows.Forms.Padding(4);
            this.mall_Product4.Name = "mall_Product4";
            this.mall_Product4.Size = new System.Drawing.Size(357, 357);
            this.mall_Product4.TabIndex = 2;
            // 
            // mall_Product8
            // 
            this.mall_Product8.AutoSize = true;
            this.mall_Product8.BackColor = System.Drawing.Color.White;
            this.mall_Product8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mall_Product8.Location = new System.Drawing.Point(0, 0);
            this.mall_Product8.Margin = new System.Windows.Forms.Padding(4);
            this.mall_Product8.Name = "mall_Product8";
            this.mall_Product8.Size = new System.Drawing.Size(357, 357);
            this.mall_Product8.TabIndex = 3;
            // 
            // mall_Product5
            // 
            this.mall_Product5.AutoSize = true;
            this.mall_Product5.BackColor = System.Drawing.Color.White;
            this.mall_Product5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mall_Product5.Location = new System.Drawing.Point(0, 0);
            this.mall_Product5.Margin = new System.Windows.Forms.Padding(4);
            this.mall_Product5.Name = "mall_Product5";
            this.mall_Product5.Size = new System.Drawing.Size(357, 357);
            this.mall_Product5.TabIndex = 4;
            // 
            // mall_Product9
            // 
            this.mall_Product9.AutoSize = true;
            this.mall_Product9.BackColor = System.Drawing.Color.White;
            this.mall_Product9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mall_Product9.Location = new System.Drawing.Point(0, 0);
            this.mall_Product9.Margin = new System.Windows.Forms.Padding(4);
            this.mall_Product9.Name = "mall_Product9";
            this.mall_Product9.Size = new System.Drawing.Size(357, 357);
            this.mall_Product9.TabIndex = 5;
            // 
            // mall_Product3
            // 
            this.mall_Product3.AutoSize = true;
            this.mall_Product3.BackColor = System.Drawing.Color.White;
            this.mall_Product3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mall_Product3.Location = new System.Drawing.Point(0, 0);
            this.mall_Product3.Margin = new System.Windows.Forms.Padding(4);
            this.mall_Product3.Name = "mall_Product3";
            this.mall_Product3.Size = new System.Drawing.Size(357, 357);
            this.mall_Product3.TabIndex = 6;
            // 
            // mall_Product2
            // 
            this.mall_Product2.AutoSize = true;
            this.mall_Product2.BackColor = System.Drawing.Color.White;
            this.mall_Product2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mall_Product2.Location = new System.Drawing.Point(0, 0);
            this.mall_Product2.Margin = new System.Windows.Forms.Padding(4);
            this.mall_Product2.Name = "mall_Product2";
            this.mall_Product2.Size = new System.Drawing.Size(357, 357);
            this.mall_Product2.TabIndex = 7;
            // 
            // mall_Product1
            // 
            this.mall_Product1.AutoSize = true;
            this.mall_Product1.BackColor = System.Drawing.Color.White;
            this.mall_Product1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mall_Product1.Location = new System.Drawing.Point(0, 0);
            this.mall_Product1.Margin = new System.Windows.Forms.Padding(4);
            this.mall_Product1.Name = "mall_Product1";
            this.mall_Product1.Size = new System.Drawing.Size(357, 357);
            this.mall_Product1.TabIndex = 8;
            // 
            // Mall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Mall";
            this.Size = new System.Drawing.Size(1171, 596);
            this.Load += new System.EventHandler(this.Mall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mall_Product mall_Product6;
        private Mall_Product mall_Product7;
        private Mall_Product mall_Product4;
        private Mall_Product mall_Product8;
        private Mall_Product mall_Product5;
        private Mall_Product mall_Product9;
        private Mall_Product mall_Product3;
        private Mall_Product mall_Product2;
        private Mall_Product mall_Product1;
        private System.Windows.Forms.TextBox txtSearch;
        private DSButton btnSearch;
        private DSButton btnPricefilter;
        private DSButton btnSamsung;
        private DSButton btnApple;
        private DSButton btnOppo;
        private DSButton btnXiaomi;
        private DSButton btnRealme;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Label lblClearSearch;
        private System.Windows.Forms.ListBox lsbSuggestions;
    }
}
