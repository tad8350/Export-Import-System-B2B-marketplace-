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
    public partial class SellerProfile : MetroFramework.Forms.MetroForm
    {
        public SellerProfile()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm ob = new SellerForm();
            ob.Show();
        }

        private void ButPhotometroButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            string imglocation = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                PictureBox.ImageLocation = imglocation;
                TexPathmetroTextBox.Text = imglocation;
            }
        }

        private void ButDonemetroButton_Click(object sender, EventArgs e)
        {

        }

        private void ButHomemetroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm ob = new SellerForm();
            ob.Show();
        }
    }
}
