using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UserBaisForm : MetroFramework.Forms.MetroForm
    {
        //
        //variable
        //
        protected string P_name;
        protected string P_quantity;
        protected string P_rating;
        protected string P_price;
        protected string P_catagory;
        //seller
        protected string S_name;
        protected string S_id;
        protected string S_phone;
        protected string S_mail;
        protected string S_country;

        //Buyer

        protected string B_name;
        protected string B_id;
        protected string B_phone;
        protected string B_mail;
        protected string B_country;

        public UserBaisForm()
        {
            InitializeComponent();
        }

        virtual protected void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        virtual protected void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        virtual protected void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        virtual protected void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TexSearchmetroTextBox_Click(object sender, EventArgs e)
        {
            TexSearchmetroTextBox.Text = "";
        }

        private void ButMenumetroButton_Click(object sender, EventArgs e)
        {
            ConMenumetroContextMenu.Show(ButMenumetroButton, 0, ButMenumetroButton.Height);
        }

        virtual protected void ButSearchmetroButton_Click(object sender, EventArgs e)
        {

        }

        virtual protected void TexProductOricemetroTextBox_Click(object sender, EventArgs e)
        {
            //TexProductOricemetroTextBox.Text = "";
        }

        virtual protected void TexProductCatagorymetroTextBox_Click(object sender, EventArgs e)
        {
            //TexProductCatagorymetroTextBox.Text = "";
        }

        virtual protected void TexProductratingmetroTextBox_Click(object sender, EventArgs e)
        {
            //TexProductratingmetroTextBox.Text = "";
        }

        virtual protected void TexProductNamemetroTextBox_Click(object sender, EventArgs e)
        {
           // TexProductNamemetroTextBox.Text = "";
        }

        virtual protected void TexProductDetailsmetroTextBox_Click(object sender, EventArgs e)
        {
            //TexProductDetailsmetroTextBox.Text = "";
        }

        virtual protected void TilNotificationmetroTile_Click(object sender, EventArgs e)
        {

        }
    }
}
