using System.Windows.Forms;

namespace UI
{
    partial class SellerForm
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
        private void AddCatagory(int i, int end)
        {


            // 
            // TilCatagorymetroTile
            // 
            this.TilCatagorymetroTile = new MetroFramework.Controls.MetroTile();
            this.TilCatagorymetroTile.Click += new System.EventHandler(this.TilCatagorymetroTile_Click);

            this.TilCatagorymetroTile.ActiveControl = null;
            this.TilCatagorymetroTile.Location = new System.Drawing.Point(3, end);
            this.TilCatagorymetroTile.Name = "TilCatagorymetroTile" + i.ToString();
            this.TilCatagorymetroTile.Size = new System.Drawing.Size(164, 54);
            this.TilCatagorymetroTile.TabIndex = i;
            this.TilCatagorymetroTile.Text = "Catagory" + i.ToString();
            this.TilCatagorymetroTile.TileImage = global::UI.Properties.Resources._1491607548_gnome_mime_application_x_bzip_compressed_tar;
            this.TilCatagorymetroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TilCatagorymetroTile.UseSelectable = true;
            this.TilCatagorymetroTile.UseTileImage = true;


            this.FloCatagoryflowLayoutPanel.Controls.Add(this.TilCatagorymetroTile);
        }
        private void AddProductlist(int i, int end)
        {
            this.BoxProductListgroupBox = new System.Windows.Forms.GroupBox();
            this.ButProductDetailsmetroButton = new MetroFramework.Controls.MetroButton();
            this.PicProductListpictureBox = new System.Windows.Forms.PictureBox();

            this.ButProductDetailsmetroButton.Click += new System.EventHandler(this.ButProductDetailsmetroButton_Click_1);
            this.LabProductcatagory = new MetroFramework.Controls.MetroLabel();
            this.LabProductCatagorymetroLabel = new MetroFramework.Controls.MetroLabel();
            this.LabProductPricemetroLabel = new MetroFramework.Controls.MetroLabel();

            this.BoxProductListgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProductListpictureBox)).BeginInit();
            this.SuspendLayout();

            this.BoxProductListgroupBox.ResumeLayout(false);
            this.BoxProductListgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProductListpictureBox)).EndInit();
            this.ResumeLayout(false);
            // 
            // BoxProductListgroupBox
            // 


            this.BoxProductListgroupBox.ForeColor = System.Drawing.Color.White;
            this.BoxProductListgroupBox.Location = new System.Drawing.Point(3, end);
            this.BoxProductListgroupBox.Name = "BoxProductListgroupBox" + i.ToString();
            this.BoxProductListgroupBox.Size = new System.Drawing.Size(338, 117);
            this.BoxProductListgroupBox.TabIndex = i;
            this.BoxProductListgroupBox.TabStop = false;
            this.BoxProductListgroupBox.Text = "Product Name" + i.ToString();
            //this.BoxProductListgroupBox.Enter += new System.EventHandler(this.BoxProgroupBox_Enter);
            // 
            // ButProductDetailsmetroButton
            // 
            this.ButProductDetailsmetroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButProductDetailsmetroButton.Location = new System.Drawing.Point(230, 80);
            this.ButProductDetailsmetroButton.Name = "ButProductDetailsmetroButton";
            this.ButProductDetailsmetroButton.Size = new System.Drawing.Size(85, 23);
            this.ButProductDetailsmetroButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.ButProductDetailsmetroButton.TabIndex = 10;
            this.ButProductDetailsmetroButton.Text = "Details";
            this.ButProductDetailsmetroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButProductDetailsmetroButton.UseSelectable = true;
            this.ButProductDetailsmetroButton.UseStyleColors = true;
            // 
            // PicProductListpictureBox
            // 
            this.PicProductListpictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.PicProductListpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicProductListpictureBox.Image = global::UI.Properties.Resources._1491607548_gnome_mime_application_x_bzip_compressed_tar;
            this.PicProductListpictureBox.Location = new System.Drawing.Point(16, 20);
            this.PicProductListpictureBox.Name = "PicProductListpictureBox";
            this.PicProductListpictureBox.Size = new System.Drawing.Size(93, 67);
            this.PicProductListpictureBox.TabIndex = 9;
            this.PicProductListpictureBox.TabStop = false;

            // 
            // LabProductcatagory
            // 
            this.LabProductcatagory.AutoSize = true;
            this.LabProductcatagory.Location = new System.Drawing.Point(135, 61);
            this.LabProductcatagory.Name = "LabProductcatagory";
            this.LabProductcatagory.Size = new System.Drawing.Size(58, 19);
            this.LabProductcatagory.TabIndex = 4;
            this.LabProductcatagory.Text = "Quantity";
            this.LabProductcatagory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabProductcatagory.UseCustomBackColor = true;
            this.LabProductcatagory.UseCustomForeColor = true;
            // 
            // LabProductCatagorymetroLabel
            // 
            this.LabProductCatagorymetroLabel.AutoSize = true;
            this.LabProductCatagorymetroLabel.Location = new System.Drawing.Point(135, 39);
            this.LabProductCatagorymetroLabel.Name = "LabProductCatagorymetroLabel";
            this.LabProductCatagorymetroLabel.Size = new System.Drawing.Size(64, 19);
            this.LabProductCatagorymetroLabel.TabIndex = 3;
            this.LabProductCatagorymetroLabel.Text = "Catagory";
            this.LabProductCatagorymetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabProductCatagorymetroLabel.UseCustomBackColor = true;
            this.LabProductCatagorymetroLabel.UseCustomForeColor = true;
            // 
            // LabProductPricemetroLabel
            // 
            this.LabProductPricemetroLabel.AutoSize = true;
            this.LabProductPricemetroLabel.Location = new System.Drawing.Point(135, 20);
            this.LabProductPricemetroLabel.Name = "LabProductPricemetroLabel";
            this.LabProductPricemetroLabel.Size = new System.Drawing.Size(88, 19);
            this.LabProductPricemetroLabel.TabIndex = 2;
            this.LabProductPricemetroLabel.Text = "Product Price";
            this.LabProductPricemetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabProductPricemetroLabel.UseCustomBackColor = true;
            this.LabProductPricemetroLabel.UseCustomForeColor = true;
            //
            //Add All to groupbox
            //
            this.FloBuyerProductflowLayoutPanel.Controls.Add(this.BoxProductListgroupBox);
            this.BoxProductListgroupBox.Controls.Add(this.ButProductDetailsmetroButton);
            this.BoxProductListgroupBox.Controls.Add(this.PicProductListpictureBox);
            this.BoxProductListgroupBox.Controls.Add(this.LabProductcatagory);
            this.BoxProductListgroupBox.Controls.Add(this.LabProductCatagorymetroLabel);
            this.BoxProductListgroupBox.Controls.Add(this.LabProductPricemetroLabel);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabSellermetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabProductInfometroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.ButProductPhotometroButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TexProdutDetailsmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexProductNamemetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexProductQuantitymetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexProductRatingmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexProductPricemetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TabAddProductmetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.ButAddProductChoosePhotometroButton = new MetroFramework.Controls.MetroButton();
            this.ButAddProductDonemetroButton = new MetroFramework.Controls.MetroButton();
            this.TexAddPhotoPathmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PicAddProductPictureBox = new System.Windows.Forms.PictureBox();
            this.TexAddProductDetailsmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexAddProductNamemetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexAddProductQuantitymetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexAddProductRatingmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexAddProductcatagorymetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexAddProductPricemetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FloBuyerProductflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FloCatagoryflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ComUserTypemetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.GroProductListgroupBox.SuspendLayout();
            this.GroProfilegroupBox.SuspendLayout();
            this.GroNotificationgroupBox.SuspendLayout();
            this.GroCatagorygroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProfilepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TabSellermetroTabControl.SuspendLayout();
            this.TabProductInfometroTabPage.SuspendLayout();
            this.TabAddProductmetroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAddProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroProductListgroupBox
            // 
            this.GroProductListgroupBox.Controls.Add(this.FloBuyerProductflowLayoutPanel);
            // 
            // GroCatagorygroupBox
            // 
            this.GroCatagorygroupBox.Controls.Add(this.FloCatagoryflowLayoutPanel);
            // 
            // TexSearchmetroTextBox
            // 
            // 
            // 
            // 
            this.TexSearchmetroTextBox.CustomButton.Image = null;
            this.TexSearchmetroTextBox.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.TexSearchmetroTextBox.CustomButton.Name = "";
            this.TexSearchmetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexSearchmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexSearchmetroTextBox.CustomButton.TabIndex = 1;
            this.TexSearchmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexSearchmetroTextBox.CustomButton.UseSelectable = true;
            this.TexSearchmetroTextBox.Lines = new string[] {
        "Search"};
            // 
            // TabSellermetroTabControl
            // 
            this.TabSellermetroTabControl.Controls.Add(this.TabProductInfometroTabPage);
            this.TabSellermetroTabControl.Controls.Add(this.TabAddProductmetroTabPage);
            this.TabSellermetroTabControl.Location = new System.Drawing.Point(630, 148);
            this.TabSellermetroTabControl.Name = "TabSellermetroTabControl";
            this.TabSellermetroTabControl.SelectedIndex = 0;
            this.TabSellermetroTabControl.Size = new System.Drawing.Size(291, 347);
            this.TabSellermetroTabControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.TabSellermetroTabControl.TabIndex = 7;
            this.TabSellermetroTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabSellermetroTabControl.UseSelectable = true;
            this.TabSellermetroTabControl.UseStyleColors = true;
            // 
            // TabProductInfometroTabPage
            // 
            this.TabProductInfometroTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabProductInfometroTabPage.Controls.Add(this.ComUserTypemetroComboBox);
            this.TabProductInfometroTabPage.Controls.Add(this.ButProductPhotometroButton);
            this.TabProductInfometroTabPage.Controls.Add(this.metroLabel5);
            this.TabProductInfometroTabPage.Controls.Add(this.metroLabel6);
            this.TabProductInfometroTabPage.Controls.Add(this.metroLabel3);
            this.TabProductInfometroTabPage.Controls.Add(this.metroLabel2);
            this.TabProductInfometroTabPage.Controls.Add(this.metroLabel1);
            this.TabProductInfometroTabPage.Controls.Add(this.TexProdutDetailsmetroTextBox);
            this.TabProductInfometroTabPage.Controls.Add(this.TexProductNamemetroTextBox);
            this.TabProductInfometroTabPage.Controls.Add(this.TexProductQuantitymetroTextBox);
            this.TabProductInfometroTabPage.Controls.Add(this.TexProductRatingmetroTextBox);
            this.TabProductInfometroTabPage.Controls.Add(this.TexProductPricemetroTextBox);
            this.TabProductInfometroTabPage.HorizontalScrollbarBarColor = true;
            this.TabProductInfometroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.TabProductInfometroTabPage.HorizontalScrollbarSize = 10;
            this.TabProductInfometroTabPage.Location = new System.Drawing.Point(4, 38);
            this.TabProductInfometroTabPage.Name = "TabProductInfometroTabPage";
            this.TabProductInfometroTabPage.Size = new System.Drawing.Size(283, 305);
            this.TabProductInfometroTabPage.TabIndex = 3;
            this.TabProductInfometroTabPage.Text = "Product Info";
            this.TabProductInfometroTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabProductInfometroTabPage.VerticalScrollbarBarColor = true;
            this.TabProductInfometroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.TabProductInfometroTabPage.VerticalScrollbarSize = 10;
            // 
            // ButProductPhotometroButton
            // 
            this.ButProductPhotometroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButProductPhotometroButton.Location = new System.Drawing.Point(18, 161);
            this.ButProductPhotometroButton.Name = "ButProductPhotometroButton";
            this.ButProductPhotometroButton.Size = new System.Drawing.Size(248, 23);
            this.ButProductPhotometroButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.ButProductPhotometroButton.TabIndex = 9;
            this.ButProductPhotometroButton.Text = "Photo";
            this.ButProductPhotometroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButProductPhotometroButton.UseSelectable = true;
            this.ButProductPhotometroButton.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel5.Location = new System.Drawing.Point(18, 133);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Product Name";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel6.Location = new System.Drawing.Point(18, 105);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Product Quantity";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel3.Location = new System.Drawing.Point(18, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Product Rating";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel2.Location = new System.Drawing.Point(10, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Product Catagory";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel1.Location = new System.Drawing.Point(18, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Product Price";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // TexProdutDetailsmetroTextBox
            // 
            // 
            // 
            // 
            this.TexProdutDetailsmetroTextBox.CustomButton.Image = null;
            this.TexProdutDetailsmetroTextBox.CustomButton.Location = new System.Drawing.Point(150, 2);
            this.TexProdutDetailsmetroTextBox.CustomButton.Name = "";
            this.TexProdutDetailsmetroTextBox.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.TexProdutDetailsmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProdutDetailsmetroTextBox.CustomButton.TabIndex = 1;
            this.TexProdutDetailsmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProdutDetailsmetroTextBox.CustomButton.UseSelectable = true;
            this.TexProdutDetailsmetroTextBox.CustomButton.Visible = false;
            this.TexProdutDetailsmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProdutDetailsmetroTextBox.Lines = new string[] {
        "Product Details"};
            this.TexProdutDetailsmetroTextBox.Location = new System.Drawing.Point(18, 193);
            this.TexProdutDetailsmetroTextBox.MaxLength = 32767;
            this.TexProdutDetailsmetroTextBox.Multiline = true;
            this.TexProdutDetailsmetroTextBox.Name = "TexProdutDetailsmetroTextBox";
            this.TexProdutDetailsmetroTextBox.PasswordChar = '\0';
            this.TexProdutDetailsmetroTextBox.ReadOnly = true;
            this.TexProdutDetailsmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TexProdutDetailsmetroTextBox.SelectedText = "";
            this.TexProdutDetailsmetroTextBox.SelectionLength = 0;
            this.TexProdutDetailsmetroTextBox.SelectionStart = 0;
            this.TexProdutDetailsmetroTextBox.ShortcutsEnabled = true;
            this.TexProdutDetailsmetroTextBox.Size = new System.Drawing.Size(248, 100);
            this.TexProdutDetailsmetroTextBox.TabIndex = 7;
            this.TexProdutDetailsmetroTextBox.Text = "Product Details";
            this.TexProdutDetailsmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexProdutDetailsmetroTextBox.UseSelectable = true;
            this.TexProdutDetailsmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexProdutDetailsmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexProductNamemetroTextBox
            // 
            // 
            // 
            // 
            this.TexProductNamemetroTextBox.CustomButton.Image = null;
            this.TexProductNamemetroTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.TexProductNamemetroTextBox.CustomButton.Name = "";
            this.TexProductNamemetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexProductNamemetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProductNamemetroTextBox.CustomButton.TabIndex = 1;
            this.TexProductNamemetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProductNamemetroTextBox.CustomButton.UseSelectable = true;
            this.TexProductNamemetroTextBox.CustomButton.Visible = false;
            this.TexProductNamemetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProductNamemetroTextBox.Lines = new string[0];
            this.TexProductNamemetroTextBox.Location = new System.Drawing.Point(130, 132);
            this.TexProductNamemetroTextBox.MaxLength = 32767;
            this.TexProductNamemetroTextBox.Name = "TexProductNamemetroTextBox";
            this.TexProductNamemetroTextBox.PasswordChar = '\0';
            this.TexProductNamemetroTextBox.ReadOnly = true;
            this.TexProductNamemetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexProductNamemetroTextBox.SelectedText = "";
            this.TexProductNamemetroTextBox.SelectionLength = 0;
            this.TexProductNamemetroTextBox.SelectionStart = 0;
            this.TexProductNamemetroTextBox.ShortcutsEnabled = true;
            this.TexProductNamemetroTextBox.Size = new System.Drawing.Size(136, 23);
            this.TexProductNamemetroTextBox.TabIndex = 6;
            this.TexProductNamemetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexProductNamemetroTextBox.UseSelectable = true;
            this.TexProductNamemetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexProductNamemetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexProductQuantitymetroTextBox
            // 
            // 
            // 
            // 
            this.TexProductQuantitymetroTextBox.CustomButton.Image = null;
            this.TexProductQuantitymetroTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.TexProductQuantitymetroTextBox.CustomButton.Name = "";
            this.TexProductQuantitymetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexProductQuantitymetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProductQuantitymetroTextBox.CustomButton.TabIndex = 1;
            this.TexProductQuantitymetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProductQuantitymetroTextBox.CustomButton.UseSelectable = true;
            this.TexProductQuantitymetroTextBox.CustomButton.Visible = false;
            this.TexProductQuantitymetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProductQuantitymetroTextBox.Lines = new string[0];
            this.TexProductQuantitymetroTextBox.Location = new System.Drawing.Point(130, 103);
            this.TexProductQuantitymetroTextBox.MaxLength = 32767;
            this.TexProductQuantitymetroTextBox.Name = "TexProductQuantitymetroTextBox";
            this.TexProductQuantitymetroTextBox.PasswordChar = '\0';
            this.TexProductQuantitymetroTextBox.ReadOnly = true;
            this.TexProductQuantitymetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexProductQuantitymetroTextBox.SelectedText = "";
            this.TexProductQuantitymetroTextBox.SelectionLength = 0;
            this.TexProductQuantitymetroTextBox.SelectionStart = 0;
            this.TexProductQuantitymetroTextBox.ShortcutsEnabled = true;
            this.TexProductQuantitymetroTextBox.Size = new System.Drawing.Size(136, 23);
            this.TexProductQuantitymetroTextBox.TabIndex = 5;
            this.TexProductQuantitymetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexProductQuantitymetroTextBox.UseSelectable = true;
            this.TexProductQuantitymetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexProductQuantitymetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexProductRatingmetroTextBox
            // 
            // 
            // 
            // 
            this.TexProductRatingmetroTextBox.CustomButton.Image = null;
            this.TexProductRatingmetroTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.TexProductRatingmetroTextBox.CustomButton.Name = "";
            this.TexProductRatingmetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexProductRatingmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProductRatingmetroTextBox.CustomButton.TabIndex = 1;
            this.TexProductRatingmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProductRatingmetroTextBox.CustomButton.UseSelectable = true;
            this.TexProductRatingmetroTextBox.CustomButton.Visible = false;
            this.TexProductRatingmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProductRatingmetroTextBox.Lines = new string[0];
            this.TexProductRatingmetroTextBox.Location = new System.Drawing.Point(130, 74);
            this.TexProductRatingmetroTextBox.MaxLength = 32767;
            this.TexProductRatingmetroTextBox.Name = "TexProductRatingmetroTextBox";
            this.TexProductRatingmetroTextBox.PasswordChar = '\0';
            this.TexProductRatingmetroTextBox.ReadOnly = true;
            this.TexProductRatingmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexProductRatingmetroTextBox.SelectedText = "";
            this.TexProductRatingmetroTextBox.SelectionLength = 0;
            this.TexProductRatingmetroTextBox.SelectionStart = 0;
            this.TexProductRatingmetroTextBox.ShortcutsEnabled = true;
            this.TexProductRatingmetroTextBox.Size = new System.Drawing.Size(136, 23);
            this.TexProductRatingmetroTextBox.TabIndex = 4;
            this.TexProductRatingmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexProductRatingmetroTextBox.UseSelectable = true;
            this.TexProductRatingmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexProductRatingmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexProductPricemetroTextBox
            // 
            // 
            // 
            // 
            this.TexProductPricemetroTextBox.CustomButton.Image = null;
            this.TexProductPricemetroTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.TexProductPricemetroTextBox.CustomButton.Name = "";
            this.TexProductPricemetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexProductPricemetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProductPricemetroTextBox.CustomButton.TabIndex = 1;
            this.TexProductPricemetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProductPricemetroTextBox.CustomButton.UseSelectable = true;
            this.TexProductPricemetroTextBox.CustomButton.Visible = false;
            this.TexProductPricemetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProductPricemetroTextBox.Lines = new string[0];
            this.TexProductPricemetroTextBox.Location = new System.Drawing.Point(130, 10);
            this.TexProductPricemetroTextBox.MaxLength = 32767;
            this.TexProductPricemetroTextBox.Name = "TexProductPricemetroTextBox";
            this.TexProductPricemetroTextBox.PasswordChar = '\0';
            this.TexProductPricemetroTextBox.ReadOnly = true;
            this.TexProductPricemetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexProductPricemetroTextBox.SelectedText = "";
            this.TexProductPricemetroTextBox.SelectionLength = 0;
            this.TexProductPricemetroTextBox.SelectionStart = 0;
            this.TexProductPricemetroTextBox.ShortcutsEnabled = true;
            this.TexProductPricemetroTextBox.Size = new System.Drawing.Size(136, 23);
            this.TexProductPricemetroTextBox.TabIndex = 2;
            this.TexProductPricemetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexProductPricemetroTextBox.UseSelectable = true;
            this.TexProductPricemetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexProductPricemetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TabAddProductmetroTabPage
            // 
            this.TabAddProductmetroTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabAddProductmetroTabPage.Controls.Add(this.ButAddProductChoosePhotometroButton);
            this.TabAddProductmetroTabPage.Controls.Add(this.ButAddProductDonemetroButton);
            this.TabAddProductmetroTabPage.Controls.Add(this.TexAddPhotoPathmetroTextBox);
            this.TabAddProductmetroTabPage.Controls.Add(this.PicAddProductPictureBox);
            this.TabAddProductmetroTabPage.Controls.Add(this.TexAddProductDetailsmetroTextBox);
            this.TabAddProductmetroTabPage.Controls.Add(this.TexAddProductNamemetroTextBox);
            this.TabAddProductmetroTabPage.Controls.Add(this.TexAddProductQuantitymetroTextBox);
            this.TabAddProductmetroTabPage.Controls.Add(this.TexAddProductRatingmetroTextBox);
            this.TabAddProductmetroTabPage.Controls.Add(this.TexAddProductcatagorymetroTextBox);
            this.TabAddProductmetroTabPage.Controls.Add(this.TexAddProductPricemetroTextBox);
            this.TabAddProductmetroTabPage.HorizontalScrollbarBarColor = false;
            this.TabAddProductmetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.TabAddProductmetroTabPage.HorizontalScrollbarSize = 10;
            this.TabAddProductmetroTabPage.Location = new System.Drawing.Point(4, 38);
            this.TabAddProductmetroTabPage.Name = "TabAddProductmetroTabPage";
            this.TabAddProductmetroTabPage.Size = new System.Drawing.Size(283, 305);
            this.TabAddProductmetroTabPage.TabIndex = 0;
            this.TabAddProductmetroTabPage.Text = "Add Product";
            this.TabAddProductmetroTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabAddProductmetroTabPage.VerticalScrollbarBarColor = true;
            this.TabAddProductmetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.TabAddProductmetroTabPage.VerticalScrollbarSize = 10;
            // 
            // ButAddProductChoosePhotometroButton
            // 
            this.ButAddProductChoosePhotometroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButAddProductChoosePhotometroButton.Location = new System.Drawing.Point(149, 134);
            this.ButAddProductChoosePhotometroButton.Name = "ButAddProductChoosePhotometroButton";
            this.ButAddProductChoosePhotometroButton.Size = new System.Drawing.Size(114, 23);
            this.ButAddProductChoosePhotometroButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.ButAddProductChoosePhotometroButton.TabIndex = 18;
            this.ButAddProductChoosePhotometroButton.Text = "Choose Photo";
            this.ButAddProductChoosePhotometroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButAddProductChoosePhotometroButton.UseSelectable = true;
            this.ButAddProductChoosePhotometroButton.UseStyleColors = true;
            this.ButAddProductChoosePhotometroButton.Click += new System.EventHandler(this.ButAddProductChoosePhotometroButton_Click);
            // 
            // ButAddProductDonemetroButton
            // 
            this.ButAddProductDonemetroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButAddProductDonemetroButton.Location = new System.Drawing.Point(15, 265);
            this.ButAddProductDonemetroButton.Name = "ButAddProductDonemetroButton";
            this.ButAddProductDonemetroButton.Size = new System.Drawing.Size(248, 23);
            this.ButAddProductDonemetroButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.ButAddProductDonemetroButton.TabIndex = 17;
            this.ButAddProductDonemetroButton.Text = "Done";
            this.ButAddProductDonemetroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButAddProductDonemetroButton.UseSelectable = true;
            this.ButAddProductDonemetroButton.UseStyleColors = true;
            this.ButAddProductDonemetroButton.Click += new System.EventHandler(this.ButAddProductDonemetroButton_Click);
            // 
            // TexAddPhotoPathmetroTextBox
            // 
            // 
            // 
            // 
            this.TexAddPhotoPathmetroTextBox.CustomButton.Image = null;
            this.TexAddPhotoPathmetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexAddPhotoPathmetroTextBox.CustomButton.Name = "";
            this.TexAddPhotoPathmetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexAddPhotoPathmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexAddPhotoPathmetroTextBox.CustomButton.TabIndex = 1;
            this.TexAddPhotoPathmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexAddPhotoPathmetroTextBox.CustomButton.UseSelectable = true;
            this.TexAddPhotoPathmetroTextBox.CustomButton.Visible = false;
            this.TexAddPhotoPathmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexAddPhotoPathmetroTextBox.Lines = new string[0];
            this.TexAddPhotoPathmetroTextBox.Location = new System.Drawing.Point(149, 105);
            this.TexAddPhotoPathmetroTextBox.MaxLength = 32767;
            this.TexAddPhotoPathmetroTextBox.Name = "TexAddPhotoPathmetroTextBox";
            this.TexAddPhotoPathmetroTextBox.PasswordChar = '\0';
            this.TexAddPhotoPathmetroTextBox.PromptText = "Photo Path";
            this.TexAddPhotoPathmetroTextBox.ReadOnly = true;
            this.TexAddPhotoPathmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexAddPhotoPathmetroTextBox.SelectedText = "";
            this.TexAddPhotoPathmetroTextBox.SelectionLength = 0;
            this.TexAddPhotoPathmetroTextBox.SelectionStart = 0;
            this.TexAddPhotoPathmetroTextBox.ShortcutsEnabled = true;
            this.TexAddPhotoPathmetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexAddPhotoPathmetroTextBox.TabIndex = 16;
            this.TexAddPhotoPathmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexAddPhotoPathmetroTextBox.UseSelectable = true;
            this.TexAddPhotoPathmetroTextBox.WaterMark = "Photo Path";
            this.TexAddPhotoPathmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexAddPhotoPathmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PicAddProductPictureBox
            // 
            this.PicAddProductPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.PicAddProductPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicAddProductPictureBox.Image = global::UI.Properties.Resources._1491607548_gnome_mime_application_x_bzip_compressed_tar;
            this.PicAddProductPictureBox.Location = new System.Drawing.Point(149, 16);
            this.PicAddProductPictureBox.Name = "PicAddProductPictureBox";
            this.PicAddProductPictureBox.Size = new System.Drawing.Size(114, 83);
            this.PicAddProductPictureBox.TabIndex = 15;
            this.PicAddProductPictureBox.TabStop = false;
            // 
            // TexAddProductDetailsmetroTextBox
            // 
            // 
            // 
            // 
            this.TexAddProductDetailsmetroTextBox.CustomButton.Image = null;
            this.TexAddProductDetailsmetroTextBox.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.TexAddProductDetailsmetroTextBox.CustomButton.Name = "";
            this.TexAddProductDetailsmetroTextBox.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.TexAddProductDetailsmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexAddProductDetailsmetroTextBox.CustomButton.TabIndex = 1;
            this.TexAddProductDetailsmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexAddProductDetailsmetroTextBox.CustomButton.UseSelectable = true;
            this.TexAddProductDetailsmetroTextBox.CustomButton.Visible = false;
            this.TexAddProductDetailsmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexAddProductDetailsmetroTextBox.Lines = new string[0];
            this.TexAddProductDetailsmetroTextBox.Location = new System.Drawing.Point(15, 161);
            this.TexAddProductDetailsmetroTextBox.MaxLength = 32767;
            this.TexAddProductDetailsmetroTextBox.Multiline = true;
            this.TexAddProductDetailsmetroTextBox.Name = "TexAddProductDetailsmetroTextBox";
            this.TexAddProductDetailsmetroTextBox.PasswordChar = '\0';
            this.TexAddProductDetailsmetroTextBox.PromptText = "Product Details";
            this.TexAddProductDetailsmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TexAddProductDetailsmetroTextBox.SelectedText = "";
            this.TexAddProductDetailsmetroTextBox.SelectionLength = 0;
            this.TexAddProductDetailsmetroTextBox.SelectionStart = 0;
            this.TexAddProductDetailsmetroTextBox.ShortcutsEnabled = true;
            this.TexAddProductDetailsmetroTextBox.Size = new System.Drawing.Size(248, 98);
            this.TexAddProductDetailsmetroTextBox.TabIndex = 14;
            this.TexAddProductDetailsmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexAddProductDetailsmetroTextBox.UseSelectable = true;
            this.TexAddProductDetailsmetroTextBox.WaterMark = "Product Details";
            this.TexAddProductDetailsmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexAddProductDetailsmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexAddProductDetailsmetroTextBox.Click += new System.EventHandler(this.TexAddProductDetailsmetroTextBox_Click);
            // 
            // TexAddProductNamemetroTextBox
            // 
            // 
            // 
            // 
            this.TexAddProductNamemetroTextBox.CustomButton.Image = null;
            this.TexAddProductNamemetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexAddProductNamemetroTextBox.CustomButton.Name = "";
            this.TexAddProductNamemetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexAddProductNamemetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexAddProductNamemetroTextBox.CustomButton.TabIndex = 1;
            this.TexAddProductNamemetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexAddProductNamemetroTextBox.CustomButton.UseSelectable = true;
            this.TexAddProductNamemetroTextBox.CustomButton.Visible = false;
            this.TexAddProductNamemetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexAddProductNamemetroTextBox.Lines = new string[0];
            this.TexAddProductNamemetroTextBox.Location = new System.Drawing.Point(15, 132);
            this.TexAddProductNamemetroTextBox.MaxLength = 32767;
            this.TexAddProductNamemetroTextBox.Name = "TexAddProductNamemetroTextBox";
            this.TexAddProductNamemetroTextBox.PasswordChar = '\0';
            this.TexAddProductNamemetroTextBox.PromptText = "Product Name";
            this.TexAddProductNamemetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexAddProductNamemetroTextBox.SelectedText = "";
            this.TexAddProductNamemetroTextBox.SelectionLength = 0;
            this.TexAddProductNamemetroTextBox.SelectionStart = 0;
            this.TexAddProductNamemetroTextBox.ShortcutsEnabled = true;
            this.TexAddProductNamemetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexAddProductNamemetroTextBox.TabIndex = 13;
            this.TexAddProductNamemetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexAddProductNamemetroTextBox.UseSelectable = true;
            this.TexAddProductNamemetroTextBox.WaterMark = "Product Name";
            this.TexAddProductNamemetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexAddProductNamemetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexAddProductNamemetroTextBox.Click += new System.EventHandler(this.TexAddProductNamemetroTextBox_Click);
            // 
            // TexAddProductQuantitymetroTextBox
            // 
            // 
            // 
            // 
            this.TexAddProductQuantitymetroTextBox.CustomButton.Image = null;
            this.TexAddProductQuantitymetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexAddProductQuantitymetroTextBox.CustomButton.Name = "";
            this.TexAddProductQuantitymetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexAddProductQuantitymetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexAddProductQuantitymetroTextBox.CustomButton.TabIndex = 1;
            this.TexAddProductQuantitymetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexAddProductQuantitymetroTextBox.CustomButton.UseSelectable = true;
            this.TexAddProductQuantitymetroTextBox.CustomButton.Visible = false;
            this.TexAddProductQuantitymetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexAddProductQuantitymetroTextBox.Lines = new string[0];
            this.TexAddProductQuantitymetroTextBox.Location = new System.Drawing.Point(15, 103);
            this.TexAddProductQuantitymetroTextBox.MaxLength = 32767;
            this.TexAddProductQuantitymetroTextBox.Name = "TexAddProductQuantitymetroTextBox";
            this.TexAddProductQuantitymetroTextBox.PasswordChar = '\0';
            this.TexAddProductQuantitymetroTextBox.PromptText = "Product Quantity";
            this.TexAddProductQuantitymetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexAddProductQuantitymetroTextBox.SelectedText = "";
            this.TexAddProductQuantitymetroTextBox.SelectionLength = 0;
            this.TexAddProductQuantitymetroTextBox.SelectionStart = 0;
            this.TexAddProductQuantitymetroTextBox.ShortcutsEnabled = true;
            this.TexAddProductQuantitymetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexAddProductQuantitymetroTextBox.TabIndex = 12;
            this.TexAddProductQuantitymetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexAddProductQuantitymetroTextBox.UseSelectable = true;
            this.TexAddProductQuantitymetroTextBox.WaterMark = "Product Quantity";
            this.TexAddProductQuantitymetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexAddProductQuantitymetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexAddProductQuantitymetroTextBox.Click += new System.EventHandler(this.TexAddProductQuantitymetroTextBox_Click);
            // 
            // TexAddProductRatingmetroTextBox
            // 
            // 
            // 
            // 
            this.TexAddProductRatingmetroTextBox.CustomButton.Image = null;
            this.TexAddProductRatingmetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexAddProductRatingmetroTextBox.CustomButton.Name = "";
            this.TexAddProductRatingmetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexAddProductRatingmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexAddProductRatingmetroTextBox.CustomButton.TabIndex = 1;
            this.TexAddProductRatingmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexAddProductRatingmetroTextBox.CustomButton.UseSelectable = true;
            this.TexAddProductRatingmetroTextBox.CustomButton.Visible = false;
            this.TexAddProductRatingmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexAddProductRatingmetroTextBox.Lines = new string[0];
            this.TexAddProductRatingmetroTextBox.Location = new System.Drawing.Point(15, 74);
            this.TexAddProductRatingmetroTextBox.MaxLength = 32767;
            this.TexAddProductRatingmetroTextBox.Name = "TexAddProductRatingmetroTextBox";
            this.TexAddProductRatingmetroTextBox.PasswordChar = '\0';
            this.TexAddProductRatingmetroTextBox.PromptText = "Product Rating";
            this.TexAddProductRatingmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexAddProductRatingmetroTextBox.SelectedText = "";
            this.TexAddProductRatingmetroTextBox.SelectionLength = 0;
            this.TexAddProductRatingmetroTextBox.SelectionStart = 0;
            this.TexAddProductRatingmetroTextBox.ShortcutsEnabled = true;
            this.TexAddProductRatingmetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexAddProductRatingmetroTextBox.TabIndex = 11;
            this.TexAddProductRatingmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexAddProductRatingmetroTextBox.UseSelectable = true;
            this.TexAddProductRatingmetroTextBox.WaterMark = "Product Rating";
            this.TexAddProductRatingmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexAddProductRatingmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexAddProductRatingmetroTextBox.Click += new System.EventHandler(this.TexAddProductRatingmetroTextBox_Click);
            // 
            // TexAddProductcatagorymetroTextBox
            // 
            // 
            // 
            // 
            this.TexAddProductcatagorymetroTextBox.CustomButton.Image = null;
            this.TexAddProductcatagorymetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexAddProductcatagorymetroTextBox.CustomButton.Name = "";
            this.TexAddProductcatagorymetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexAddProductcatagorymetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexAddProductcatagorymetroTextBox.CustomButton.TabIndex = 1;
            this.TexAddProductcatagorymetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexAddProductcatagorymetroTextBox.CustomButton.UseSelectable = true;
            this.TexAddProductcatagorymetroTextBox.CustomButton.Visible = false;
            this.TexAddProductcatagorymetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexAddProductcatagorymetroTextBox.Lines = new string[0];
            this.TexAddProductcatagorymetroTextBox.Location = new System.Drawing.Point(15, 45);
            this.TexAddProductcatagorymetroTextBox.MaxLength = 32767;
            this.TexAddProductcatagorymetroTextBox.Name = "TexAddProductcatagorymetroTextBox";
            this.TexAddProductcatagorymetroTextBox.PasswordChar = '\0';
            this.TexAddProductcatagorymetroTextBox.PromptText = "Product Catagory";
            this.TexAddProductcatagorymetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexAddProductcatagorymetroTextBox.SelectedText = "";
            this.TexAddProductcatagorymetroTextBox.SelectionLength = 0;
            this.TexAddProductcatagorymetroTextBox.SelectionStart = 0;
            this.TexAddProductcatagorymetroTextBox.ShortcutsEnabled = true;
            this.TexAddProductcatagorymetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexAddProductcatagorymetroTextBox.TabIndex = 10;
            this.TexAddProductcatagorymetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexAddProductcatagorymetroTextBox.UseSelectable = true;
            this.TexAddProductcatagorymetroTextBox.WaterMark = "Product Catagory";
            this.TexAddProductcatagorymetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexAddProductcatagorymetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexAddProductcatagorymetroTextBox.Click += new System.EventHandler(this.TexAddProductcatagorymetroTextBox_Click);
            // 
            // TexAddProductPricemetroTextBox
            // 
            // 
            // 
            // 
            this.TexAddProductPricemetroTextBox.CustomButton.Image = null;
            this.TexAddProductPricemetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexAddProductPricemetroTextBox.CustomButton.Name = "";
            this.TexAddProductPricemetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexAddProductPricemetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexAddProductPricemetroTextBox.CustomButton.TabIndex = 1;
            this.TexAddProductPricemetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexAddProductPricemetroTextBox.CustomButton.UseSelectable = true;
            this.TexAddProductPricemetroTextBox.CustomButton.Visible = false;
            this.TexAddProductPricemetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexAddProductPricemetroTextBox.Lines = new string[0];
            this.TexAddProductPricemetroTextBox.Location = new System.Drawing.Point(15, 16);
            this.TexAddProductPricemetroTextBox.MaxLength = 32767;
            this.TexAddProductPricemetroTextBox.Name = "TexAddProductPricemetroTextBox";
            this.TexAddProductPricemetroTextBox.PasswordChar = '\0';
            this.TexAddProductPricemetroTextBox.PromptText = "Product Price";
            this.TexAddProductPricemetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexAddProductPricemetroTextBox.SelectedText = "";
            this.TexAddProductPricemetroTextBox.SelectionLength = 0;
            this.TexAddProductPricemetroTextBox.SelectionStart = 0;
            this.TexAddProductPricemetroTextBox.ShortcutsEnabled = true;
            this.TexAddProductPricemetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexAddProductPricemetroTextBox.TabIndex = 9;
            this.TexAddProductPricemetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexAddProductPricemetroTextBox.UseSelectable = true;
            this.TexAddProductPricemetroTextBox.WaterMark = "Product Price";
            this.TexAddProductPricemetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexAddProductPricemetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexAddProductPricemetroTextBox.Click += new System.EventHandler(this.TexAddProductPricemetroTextBox_Click);
            // 
            // FloBuyerProductflowLayoutPanel
            // 
            this.FloBuyerProductflowLayoutPanel.AutoScroll = true;
            this.FloBuyerProductflowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FloBuyerProductflowLayoutPanel.Location = new System.Drawing.Point(6, 21);
            this.FloBuyerProductflowLayoutPanel.Name = "FloBuyerProductflowLayoutPanel";
            this.FloBuyerProductflowLayoutPanel.Size = new System.Drawing.Size(368, 492);
            this.FloBuyerProductflowLayoutPanel.TabIndex = 1;
            // 
            // FloCatagoryflowLayoutPanel
            // 
            this.FloCatagoryflowLayoutPanel.AutoScroll = true;
            this.FloCatagoryflowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FloCatagoryflowLayoutPanel.Location = new System.Drawing.Point(6, 14);
            this.FloCatagoryflowLayoutPanel.Name = "FloCatagoryflowLayoutPanel";
            this.FloCatagoryflowLayoutPanel.Size = new System.Drawing.Size(196, 177);
            this.FloCatagoryflowLayoutPanel.TabIndex = 1;
            // 
            // ComUserTypemetroComboBox
            // 
            this.ComUserTypemetroComboBox.FormattingEnabled = true;
            this.ComUserTypemetroComboBox.ItemHeight = 23;
            this.ComUserTypemetroComboBox.Items.AddRange(new object[] {
            "Buyer",
            "Seller"});
            this.ComUserTypemetroComboBox.Location = new System.Drawing.Point(130, 39);
            this.ComUserTypemetroComboBox.Name = "ComUserTypemetroComboBox";
            this.ComUserTypemetroComboBox.PromptText = "Select User type";
            this.ComUserTypemetroComboBox.Size = new System.Drawing.Size(136, 29);
            this.ComUserTypemetroComboBox.TabIndex = 13;
            this.ComUserTypemetroComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ComUserTypemetroComboBox.UseSelectable = true;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 607);
            this.Controls.Add(this.TabSellermetroTabControl);
            this.Name = "SellerForm";
            this.Text = "Seller Form";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.Controls.SetChildIndex(this.TabSellermetroTabControl, 0);
            this.Controls.SetChildIndex(this.TexSearchmetroTextBox, 0);
            this.Controls.SetChildIndex(this.ButMenumetroButton, 0);
            this.Controls.SetChildIndex(this.GroProductListgroupBox, 0);
            this.Controls.SetChildIndex(this.GroProfilegroupBox, 0);
            this.Controls.SetChildIndex(this.GroCatagorygroupBox, 0);
            this.Controls.SetChildIndex(this.GroNotificationgroupBox, 0);
            this.Controls.SetChildIndex(this.ButSearchmetroButton, 0);
            this.GroProductListgroupBox.ResumeLayout(false);
            this.GroProfilegroupBox.ResumeLayout(false);
            this.GroProfilegroupBox.PerformLayout();
            this.GroNotificationgroupBox.ResumeLayout(false);
            this.GroCatagorygroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicProfilepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TabSellermetroTabControl.ResumeLayout(false);
            this.TabProductInfometroTabPage.ResumeLayout(false);
            this.TabProductInfometroTabPage.PerformLayout();
            this.TabAddProductmetroTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicAddProductPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabSellermetroTabControl;
        private MetroFramework.Controls.MetroTabPage TabAddProductmetroTabPage;
        private MetroFramework.Controls.MetroButton ButAddProductChoosePhotometroButton;
        private MetroFramework.Controls.MetroButton ButAddProductDonemetroButton;
        private MetroFramework.Controls.MetroTextBox TexAddPhotoPathmetroTextBox;
        private System.Windows.Forms.PictureBox PicAddProductPictureBox;
        private MetroFramework.Controls.MetroTextBox TexAddProductDetailsmetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexAddProductNamemetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexAddProductQuantitymetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexAddProductRatingmetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexAddProductcatagorymetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexAddProductPricemetroTextBox;
        private MetroFramework.Controls.MetroTabPage TabProductInfometroTabPage;
        private MetroFramework.Controls.MetroButton ButProductPhotometroButton;
        protected MetroFramework.Controls.MetroLabel metroLabel5;
        protected MetroFramework.Controls.MetroLabel metroLabel6;
        protected MetroFramework.Controls.MetroLabel metroLabel3;
        protected MetroFramework.Controls.MetroLabel metroLabel2;
        protected MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TexProdutDetailsmetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexProductNamemetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexProductQuantitymetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexProductRatingmetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexProductPricemetroTextBox;
        private System.Windows.Forms.FlowLayoutPanel FloBuyerProductflowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel FloCatagoryflowLayoutPanel;


        protected MetroFramework.Controls.MetroLabel LabProductcatagory;
        protected MetroFramework.Controls.MetroLabel LabProductCatagorymetroLabel;
        protected MetroFramework.Controls.MetroLabel LabProductPricemetroLabel;
        private MetroFramework.Controls.MetroTile TilCatagorymetroTile;

        private System.Windows.Forms.GroupBox BoxProductListgroupBox;
        private MetroFramework.Controls.MetroButton ButProductDetailsmetroButton;
        private System.Windows.Forms.PictureBox PicProductListpictureBox;
        private MetroFramework.Controls.MetroComboBox ComUserTypemetroComboBox;
    }
}