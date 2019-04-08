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
using MetroFramework.Controls;

namespace UI
{
    public partial class BuyerForm : UserBaisForm
    {
        public BuyerForm():base()
        {
            InitializeComponent();
        }

        override protected void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyerForm ob = new BuyerForm();
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
            BuyerProfile ob = new BuyerProfile();
            ob.Show();
        }

        override protected void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButBagListmetroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyerBagList ob = new BuyerBagList();
            ob.Show();
        }

        override protected void ButSearchmetroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchedProduct ob = new SearchedProduct();
            ob.Show();
        }

        private void BoxProgroupBox_Enter(object sender, EventArgs e)
        {

        }



        private void ButRefreshmetroButton_Click(object sender, EventArgs e)
        {
            this.Close();
            BuyerForm ob = new BuyerForm();
            ob.Show();
        }

        private void ButProductDetailsmetroButton_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //product 

            string s=btn.Parent.Text;
            TexProductNamemetroTextBox.Text = s;
            string id = LabProductCatagorymetroLabel.Text;
            EventHandler.ShowProductDetails(id);
            TexProductCatagorymetroTextBox.Text = P_catagory;
            this.P_price = 1000.00.ToString();
            TexProductPricemetroTextBox.Text = P_price;
            this.P_quantity = LabProductcatagory.Text;
            TexProductQuantitymetroTextBox.Text = P_quantity;
            this.P_rating = 8.3.ToString();
            TexProductRatingmetroTextBox.Text = P_rating;

            //seller
            this.S_name = "ehsan";
            this.S_id = "123456";
            this.S_phone = "01987";
            this.S_mail = "ehsanul@gmail.com";
            this.S_country = "Bangladesh";

            TexsellerNamemetroTextBox.Text = S_name;
            TexsellerIdmetroTextBox.Text = S_id;
            TexsellerPhonemetroTextBox.Text = S_phone;
            TexsellerMailmetroTextBox.Text = S_mail;
            TexsellerCountrymetroTextBox.Text = S_country;

            //MessageBox.Show("product details");
        }

        private void ButProductAddTobagmetroButton_Click_1(object ender,EventArgs e)
        {
            MessageBox.Show("Add To Bag");
        }

        private void ButSearchmetroButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ButProductPhotometroButton_Click(object sender, EventArgs e)
        {

        }
        private void TilCatagorymetroTile_Click(object sender, EventArgs e)
        {
            MetroTile t = (MetroTile)sender;
            string name=t.Text;
            this.Close();
            CatagoryProductForm ob = new CatagoryProductForm(name);
            ob.Show();
        }
        override protected void TilNotificationmetroTile_Click(object sender, EventArgs e)
        {
            PopupNotifier ob = new PopupNotifier();
            ob.TitleText = "Nothing";
            ob.ContentText = "Notification test";
            ob.BodyColor = Color.DarkGray;
            ob.Popup();
        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            //loading user profile
            this.loadProfile();

            //loading categories
            this.loadCategory();

            //Loading Product Items
            this.LoadProductList();
        }

        private void loadProfile()
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
        private void loadCategory()
        {
            EventHandler.showCategory(this);
        }

        private void LoadProductList()
        {
            EventHandler.showItemList(this);
        }
    }
}
