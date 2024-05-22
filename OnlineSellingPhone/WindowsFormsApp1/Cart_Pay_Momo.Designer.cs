
namespace WindowsFormsApp1
{
    partial class Cart_Pay_Momo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcb_qrCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_qrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_qrCode
            // 
            this.pcb_qrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_qrCode.Location = new System.Drawing.Point(56, 53);
            this.pcb_qrCode.Name = "pcb_qrCode";
            this.pcb_qrCode.Size = new System.Drawing.Size(380, 380);
            this.pcb_qrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_qrCode.TabIndex = 1;
            this.pcb_qrCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số tiền phải thanh toán:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(300, 9);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(51, 25);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Tiền";
            // 
            // Cart_Pay_Momo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 458);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_qrCode);
            this.Name = "Cart_Pay_Momo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart_Pay_Momo";
            this.Load += new System.EventHandler(this.Cart_Pay_Momo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_qrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_qrCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}