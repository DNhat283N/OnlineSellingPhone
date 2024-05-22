
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
            ((System.ComponentModel.ISupportInitialize)(this.pcb_qrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_qrCode
            // 
            this.pcb_qrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_qrCode.Location = new System.Drawing.Point(61, 38);
            this.pcb_qrCode.Name = "pcb_qrCode";
            this.pcb_qrCode.Size = new System.Drawing.Size(380, 380);
            this.pcb_qrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_qrCode.TabIndex = 1;
            this.pcb_qrCode.TabStop = false;
            // 
            // Cart_Pay_Momo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 458);
            this.Controls.Add(this.pcb_qrCode);
            this.Name = "Cart_Pay_Momo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart_Pay_Momo";
            this.Load += new System.EventHandler(this.Cart_Pay_Momo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_qrCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_qrCode;
    }
}