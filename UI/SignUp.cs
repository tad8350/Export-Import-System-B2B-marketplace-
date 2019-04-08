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

namespace UI
{
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void ButDonemetroButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            try
            {
                EventHandler.userSignUp(TxtUsernamemetroTextBox.Text, TxtPasswordmetroTextBox.Text, TxtEmailMetroTextBox.Text, ComUserTypemetroComboBox.Text.ToString());
            }
            catch (Exception exp)
            {
                MetroMessageBox.Show(this, exp.Message);
            }
                MetroMessageBox.Show(this, "Registration Successful");
            //}
            //catch (Exception exp)
            //{
            //    MetroMessageBox.Show(this, exp.Message);
            //}
        }

        private void ButLoginmetroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ob = new Login();
            ob.Show();
        }
    }
}
