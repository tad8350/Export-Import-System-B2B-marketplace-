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
    public partial class BuyerProfile : MetroFramework.Forms.MetroForm
    {
        string imglocation = "";
        public BuyerProfile()
        {
            InitializeComponent();
        }

        private void ButHomemetroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyerForm ob = new BuyerForm();
            ob.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyerForm ob = new BuyerForm();
            ob.Show();
        }

        private void ButDonemetroButton_Click(object sender, EventArgs e)
        {

        }

        private void ButPhotometroButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                PictureBox.ImageLocation = imglocation;
                TexPathmetroTextBox.Text = imglocation;
            }
        }
    }
}
