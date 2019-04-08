using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace UI
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            TxtUsernamemetroTextBox.Text = "";
        }

        private void PasswordmetroTextBox_Click(object sender, EventArgs e)
        {
            TxtPasswordmetroTextBox.Text = "";
        }

        private void LoginmetroButton_Click(object sender, EventArgs e)
        {
            UserInfo.UserID = int.Parse(TxtUsernamemetroTextBox.Text);
            UserInfo.Password = TxtPasswordmetroTextBox.Text;
            try
            {
                if (ComUserTypemetroComboBox.Text == "Buyer")
                {
                    if(EventHandler.LoginCheck(UserInfo.UserID, UserInfo.Password, "Buyer"))
                    {
                        this.Hide();
                        BuyerForm ob = new BuyerForm();
                        ob.Show();
                        MetroMessageBox.Show(this, "Log in Success As a" + ComUserTypemetroComboBox.Text + "!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else if (ComUserTypemetroComboBox.Text == "Seller")
                {
                   if(EventHandler.LoginCheck(UserInfo.UserID, UserInfo.Password, "Seller"))
                   {
                       this.Hide();
                       SellerForm ob = new SellerForm();
                       ob.Show();
                       MetroMessageBox.Show(this, "Log in Success As a" + ComUserTypemetroComboBox.Text + "!!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   }
                }
                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Login Fail!!!!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void SignupmetroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp ob = new SignUp();
            ob.Show();

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
