using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using MetroFramework;

namespace UI
{
    public partial class SellerForm : UserBaisForm
    {
        public SellerForm()
        {
            InitializeComponent();
            int end = 3;
            int end1 = 3;
            for (int i = 0; i < 6; i++)
            {
                AddCatagory(i, end);
                AddProductlist(i, end1);
                end1 += 123;
                end += 60;
            }
        }

        override protected void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm ob = new SellerForm();
            ob.Show();
        }

        override protected void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ob = new Login();
            ob.Show();
        }

        override protected void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerProfile ob = new SellerProfile();
            ob.Show();
        }

        override protected void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TexAddProductPricemetroTextBox_Click(object sender, EventArgs e)
        {
            TexAddProductPricemetroTextBox.Text = "";
        }

        private void TexAddProductcatagorymetroTextBox_Click(object sender, EventArgs e)
        {
            TexAddProductcatagorymetroTextBox.Text = "";
        }

        private void TexAddProductRatingmetroTextBox_Click(object sender, EventArgs e)
        {
            TexAddProductRatingmetroTextBox.Text = "";
        }

        private void TexAddProductQuantitymetroTextBox_Click(object sender, EventArgs e)
        {
            TexAddProductQuantitymetroTextBox.Text = "";
        }

        private void TexAddProductNamemetroTextBox_Click(object sender, EventArgs e)
        {
            TexAddProductNamemetroTextBox.Text = "";
        }

        private void TexAddProductDetailsmetroTextBox_Click(object sender, EventArgs e)
        {
            TexAddProductDetailsmetroTextBox.Text = "";
        }

        private void ButAddProductDonemetroButton_Click(object sender, EventArgs e)
        {

        }

        private void ButAddProductChoosePhotometroButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            string imglocation = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                PicAddProductPictureBox.ImageLocation = imglocation;
                TexAddPhotoPathmetroTextBox.Text = imglocation;
            }
        }

        override protected void TilNotificationmetroTile_Click(object sender, EventArgs e)
        {
            PopupNotifier ob = new PopupNotifier();
            ob.TitleText = "Nothing";
            ob.ContentText = "Notification test";
            ob.BodyColor = Color.DarkGray;
            ob.Popup();
        }

        private void ButProductDetailsmetroButton_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //product 

            string s = btn.Parent.Text;
            TexProductNamemetroTextBox.Text = s;
            this.P_catagory = LabProductCatagorymetroLabel.Text;
            this.P_price = 1000.00.ToString();
            TexProductPricemetroTextBox.Text = P_price;
            this.P_quantity = LabProductcatagory.Text;
            TexProductQuantitymetroTextBox.Text = P_quantity;
            this.P_rating = 8.3.ToString();
            TexProductRatingmetroTextBox.Text = P_rating;

            

            //MessageBox.Show("product details");
        }

        private void TilCatagorymetroTile_Click(object sender, EventArgs e)
        {
            this.Close();
            SellerForm ob = new SellerForm();
            ob.Show();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            String name = "";
            String email = "";
            String country = "";
            String phn = "";
            try
            {
                EventHandler.profileLoader(UserInfo.UserID, ref name, ref email, ref country, ref phn);
            }
            catch (Exception exp)
            {
                MetroMessageBox.Show(this, exp.Message);
            }
            LabProfileUserNamemetroLabel.Text = name;
            LabProfileMailmetroLabel.Text = email;
            LabProfileCountrymetroLabel.Text = country;
            LabProfilePhonemetroLabel.Text = phn;
        }



        //==============
        //=======Product info property==========
        //==============

    }
}
