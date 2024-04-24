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

        private void button1_Click(object sender, EventArgs e)
        {
            Mall_Product product = new Mall_Product();
            fpnlProductCart.Controls.Add(product);
        }
       

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
            }
            else
            {
                btnPayCash.BackgroundColor = Color.White;
                btnPaypal.Enabled = true;
                buttonClicked = false;
            }
        }

        private void btnPaypal_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                btnPaypal.BackgroundColor = Color.DarkGray;
                btnPayCash.Enabled = false;
                buttonClicked = true;
            }
            else
            {
                btnPaypal.BackgroundColor = Color.White;
                btnPayCash.Enabled = true;
                buttonClicked = false;
            }
        }
    }
}
