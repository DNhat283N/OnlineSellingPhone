
namespace WindowsFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pcbImageBanner1 = new System.Windows.Forms.PictureBox();
            this.btnBanner2Next = new System.Windows.Forms.Button();
            this.pcbImageBanner2 = new System.Windows.Forms.PictureBox();
            this.btnBanner2Previous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageBanner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageBanner2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImageBanner1
            // 
            this.pcbImageBanner1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbImageBanner1.BackgroundImage")));
            this.pcbImageBanner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbImageBanner1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImageBanner1.Location = new System.Drawing.Point(0, 22);
            this.pcbImageBanner1.Name = "pcbImageBanner1";
            this.pcbImageBanner1.Size = new System.Drawing.Size(1171, 281);
            this.pcbImageBanner1.TabIndex = 20;
            this.pcbImageBanner1.TabStop = false;
            // 
            // btnBanner2Next
            // 
            this.btnBanner2Next.BackColor = System.Drawing.Color.Transparent;
            this.btnBanner2Next.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnBanner2Next.FlatAppearance.BorderSize = 0;
            this.btnBanner2Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBanner2Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBanner2Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanner2Next.Image = ((System.Drawing.Image)(resources.GetObject("btnBanner2Next.Image")));
            this.btnBanner2Next.Location = new System.Drawing.Point(1005, 428);
            this.btnBanner2Next.Name = "btnBanner2Next";
            this.btnBanner2Next.Size = new System.Drawing.Size(44, 45);
            this.btnBanner2Next.TabIndex = 23;
            this.btnBanner2Next.UseVisualStyleBackColor = false;
            this.btnBanner2Next.Click += new System.EventHandler(this.btnBanner2Next_Click);
            // 
            // pcbImageBanner2
            // 
            this.pcbImageBanner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImageBanner2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImageBanner2.Image = ((System.Drawing.Image)(resources.GetObject("pcbImageBanner2.Image")));
            this.pcbImageBanner2.Location = new System.Drawing.Point(196, 332);
            this.pcbImageBanner2.Name = "pcbImageBanner2";
            this.pcbImageBanner2.Size = new System.Drawing.Size(791, 236);
            this.pcbImageBanner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImageBanner2.TabIndex = 21;
            this.pcbImageBanner2.TabStop = false;
            // 
            // btnBanner2Previous
            // 
            this.btnBanner2Previous.BackColor = System.Drawing.Color.Transparent;
            this.btnBanner2Previous.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnBanner2Previous.FlatAppearance.BorderSize = 0;
            this.btnBanner2Previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBanner2Previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBanner2Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanner2Previous.Image = ((System.Drawing.Image)(resources.GetObject("btnBanner2Previous.Image")));
            this.btnBanner2Previous.Location = new System.Drawing.Point(132, 418);
            this.btnBanner2Previous.Name = "btnBanner2Previous";
            this.btnBanner2Previous.Size = new System.Drawing.Size(49, 64);
            this.btnBanner2Previous.TabIndex = 22;
            this.btnBanner2Previous.UseVisualStyleBackColor = false;
            this.btnBanner2Previous.Click += new System.EventHandler(this.btnBanner2Previous_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pcbImageBanner1);
            this.Controls.Add(this.btnBanner2Next);
            this.Controls.Add(this.pcbImageBanner2);
            this.Controls.Add(this.btnBanner2Previous);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1171, 596);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageBanner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageBanner2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbImageBanner1;
        private System.Windows.Forms.Button btnBanner2Next;
        private System.Windows.Forms.PictureBox pcbImageBanner2;
        private System.Windows.Forms.Button btnBanner2Previous;
    }
}
