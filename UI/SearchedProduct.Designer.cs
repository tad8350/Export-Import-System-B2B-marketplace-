namespace UI
{
    partial class SearchedProduct
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

        public void AddCatagory(int i, int end, string name)
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
            this.TilCatagorymetroTile.Text = name;
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
            this.ButProductAddTobagmetroButton = new MetroFramework.Controls.MetroButton();
            this.ButProductAddTobagmetroButton.Click += new System.EventHandler(this.ButProductAddTobagmetroButton_Click_1);
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
            this.ButProductDetailsmetroButton.Location = new System.Drawing.Point(135, 88);
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
            // ButProductAddTobagmetroButton
            // 
            this.ButProductAddTobagmetroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButProductAddTobagmetroButton.Location = new System.Drawing.Point(226, 88);
            this.ButProductAddTobagmetroButton.Name = "ButProductAddTobagmetroButton";
            this.ButProductAddTobagmetroButton.Size = new System.Drawing.Size(106, 23);
            this.ButProductAddTobagmetroButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.ButProductAddTobagmetroButton.TabIndex = 9;
            this.ButProductAddTobagmetroButton.Text = "Add to Bag ";
            this.ButProductAddTobagmetroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButProductAddTobagmetroButton.UseSelectable = true;
            this.ButProductAddTobagmetroButton.UseStyleColors = true;
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
            this.BoxProductListgroupBox.Controls.Add(this.ButProductAddTobagmetroButton);
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
            this.TexProductCatagorymetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexProductPricemetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TexsellerAddressmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexsellerCountrymetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexsellerMailmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexsellerPhonemetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexsellerIdmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TexsellerNamemetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FloCatagoryflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FloBuyerProductflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButHomemetroButton = new MetroFramework.Controls.MetroButton();
            this.GroProductListgroupBox.SuspendLayout();
            this.GroProfilegroupBox.SuspendLayout();
            this.GroNotificationgroupBox.SuspendLayout();
            this.GroCatagorygroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProfilepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TabSellermetroTabControl.SuspendLayout();
            this.TabProductInfometroTabPage.SuspendLayout();
            this.metroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.TabSellermetroTabControl.Controls.Add(this.metroTabPage);
            this.TabSellermetroTabControl.Location = new System.Drawing.Point(630, 155);
            this.TabSellermetroTabControl.Name = "TabSellermetroTabControl";
            this.TabSellermetroTabControl.SelectedIndex = 0;
            this.TabSellermetroTabControl.Size = new System.Drawing.Size(291, 326);
            this.TabSellermetroTabControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.TabSellermetroTabControl.TabIndex = 9;
            this.TabSellermetroTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabSellermetroTabControl.UseSelectable = true;
            this.TabSellermetroTabControl.UseStyleColors = true;
            // 
            // TabProductInfometroTabPage
            // 
            this.TabProductInfometroTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.TabProductInfometroTabPage.Controls.Add(this.TexProductCatagorymetroTextBox);
            this.TabProductInfometroTabPage.Controls.Add(this.TexProductPricemetroTextBox);
            this.TabProductInfometroTabPage.HorizontalScrollbarBarColor = true;
            this.TabProductInfometroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.TabProductInfometroTabPage.HorizontalScrollbarSize = 10;
            this.TabProductInfometroTabPage.Location = new System.Drawing.Point(4, 38);
            this.TabProductInfometroTabPage.Name = "TabProductInfometroTabPage";
            this.TabProductInfometroTabPage.Size = new System.Drawing.Size(283, 284);
            this.TabProductInfometroTabPage.TabIndex = 4;
            this.TabProductInfometroTabPage.Text = "Product Info";
            this.TabProductInfometroTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabProductInfometroTabPage.VerticalScrollbarBarColor = true;
            this.TabProductInfometroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.TabProductInfometroTabPage.VerticalScrollbarSize = 10;
            // 
            // ButProductPhotometroButton
            // 
            this.ButProductPhotometroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButProductPhotometroButton.Location = new System.Drawing.Point(250, 9);
            this.ButProductPhotometroButton.Name = "ButProductPhotometroButton";
            this.ButProductPhotometroButton.Size = new System.Drawing.Size(21, 136);
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
            this.metroLabel5.Location = new System.Drawing.Point(18, 126);
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
            this.metroLabel6.Location = new System.Drawing.Point(18, 98);
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
            this.metroLabel3.Location = new System.Drawing.Point(18, 70);
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
            this.metroLabel2.Location = new System.Drawing.Point(10, 42);
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
            this.TexProdutDetailsmetroTextBox.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.TexProdutDetailsmetroTextBox.CustomButton.Name = "";
            this.TexProdutDetailsmetroTextBox.CustomButton.Size = new System.Drawing.Size(111, 111);
            this.TexProdutDetailsmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProdutDetailsmetroTextBox.CustomButton.TabIndex = 1;
            this.TexProdutDetailsmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProdutDetailsmetroTextBox.CustomButton.UseSelectable = true;
            this.TexProdutDetailsmetroTextBox.CustomButton.Visible = false;
            this.TexProdutDetailsmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProdutDetailsmetroTextBox.Lines = new string[] {
        "Product Details"};
            this.TexProdutDetailsmetroTextBox.Location = new System.Drawing.Point(18, 164);
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
            this.TexProdutDetailsmetroTextBox.Size = new System.Drawing.Size(248, 113);
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
            this.TexProductNamemetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexProductNamemetroTextBox.CustomButton.Name = "";
            this.TexProductNamemetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexProductNamemetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProductNamemetroTextBox.CustomButton.TabIndex = 1;
            this.TexProductNamemetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProductNamemetroTextBox.CustomButton.UseSelectable = true;
            this.TexProductNamemetroTextBox.CustomButton.Visible = false;
            this.TexProductNamemetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProductNamemetroTextBox.Lines = new string[0];
            this.TexProductNamemetroTextBox.Location = new System.Drawing.Point(130, 125);
            this.TexProductNamemetroTextBox.MaxLength = 32767;
            this.TexProductNamemetroTextBox.Name = "TexProductNamemetroTextBox";
            this.TexProductNamemetroTextBox.PasswordChar = '\0';
            this.TexProductNamemetroTextBox.ReadOnly = true;
            this.TexProductNamemetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexProductNamemetroTextBox.SelectedText = "";
            this.TexProductNamemetroTextBox.SelectionLength = 0;
            this.TexProductNamemetroTextBox.SelectionStart = 0;
            this.TexProductNamemetroTextBox.ShortcutsEnabled = true;
            this.TexProductNamemetroTextBox.Size = new System.Drawing.Size(114, 23);
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
            this.TexProductQuantitymetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexProductQuantitymetroTextBox.CustomButton.Name = "";
            this.TexProductQuantitymetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexProductQuantitymetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProductQuantitymetroTextBox.CustomButton.TabIndex = 1;
            this.TexProductQuantitymetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProductQuantitymetroTextBox.CustomButton.UseSelectable = true;
            this.TexProductQuantitymetroTextBox.CustomButton.Visible = false;
            this.TexProductQuantitymetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProductQuantitymetroTextBox.Lines = new string[0];
            this.TexProductQuantitymetroTextBox.Location = new System.Drawing.Point(130, 96);
            this.TexProductQuantitymetroTextBox.MaxLength = 32767;
            this.TexProductQuantitymetroTextBox.Name = "TexProductQuantitymetroTextBox";
            this.TexProductQuantitymetroTextBox.PasswordChar = '\0';
            this.TexProductQuantitymetroTextBox.ReadOnly = true;
            this.TexProductQuantitymetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexProductQuantitymetroTextBox.SelectedText = "";
            this.TexProductQuantitymetroTextBox.SelectionLength = 0;
            this.TexProductQuantitymetroTextBox.SelectionStart = 0;
            this.TexProductQuantitymetroTextBox.ShortcutsEnabled = true;
            this.TexProductQuantitymetroTextBox.Size = new System.Drawing.Size(114, 23);
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
            this.TexProductRatingmetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexProductRatingmetroTextBox.CustomButton.Name = "";
            this.TexProductRatingmetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexProductRatingmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProductRatingmetroTextBox.CustomButton.TabIndex = 1;
            this.TexProductRatingmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProductRatingmetroTextBox.CustomButton.UseSelectable = true;
            this.TexProductRatingmetroTextBox.CustomButton.Visible = false;
            this.TexProductRatingmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProductRatingmetroTextBox.Lines = new string[0];
            this.TexProductRatingmetroTextBox.Location = new System.Drawing.Point(130, 67);
            this.TexProductRatingmetroTextBox.MaxLength = 32767;
            this.TexProductRatingmetroTextBox.Name = "TexProductRatingmetroTextBox";
            this.TexProductRatingmetroTextBox.PasswordChar = '\0';
            this.TexProductRatingmetroTextBox.ReadOnly = true;
            this.TexProductRatingmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexProductRatingmetroTextBox.SelectedText = "";
            this.TexProductRatingmetroTextBox.SelectionLength = 0;
            this.TexProductRatingmetroTextBox.SelectionStart = 0;
            this.TexProductRatingmetroTextBox.ShortcutsEnabled = true;
            this.TexProductRatingmetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexProductRatingmetroTextBox.TabIndex = 4;
            this.TexProductRatingmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexProductRatingmetroTextBox.UseSelectable = true;
            this.TexProductRatingmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexProductRatingmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexProductCatagorymetroTextBox
            // 
            // 
            // 
            // 
            this.TexProductCatagorymetroTextBox.CustomButton.Image = null;
            this.TexProductCatagorymetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexProductCatagorymetroTextBox.CustomButton.Name = "";
            this.TexProductCatagorymetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexProductCatagorymetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexProductCatagorymetroTextBox.CustomButton.TabIndex = 1;
            this.TexProductCatagorymetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexProductCatagorymetroTextBox.CustomButton.UseSelectable = true;
            this.TexProductCatagorymetroTextBox.CustomButton.Visible = false;
            this.TexProductCatagorymetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexProductCatagorymetroTextBox.Lines = new string[0];
            this.TexProductCatagorymetroTextBox.Location = new System.Drawing.Point(130, 38);
            this.TexProductCatagorymetroTextBox.MaxLength = 32767;
            this.TexProductCatagorymetroTextBox.Name = "TexProductCatagorymetroTextBox";
            this.TexProductCatagorymetroTextBox.PasswordChar = '\0';
            this.TexProductCatagorymetroTextBox.ReadOnly = true;
            this.TexProductCatagorymetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexProductCatagorymetroTextBox.SelectedText = "";
            this.TexProductCatagorymetroTextBox.SelectionLength = 0;
            this.TexProductCatagorymetroTextBox.SelectionStart = 0;
            this.TexProductCatagorymetroTextBox.ShortcutsEnabled = true;
            this.TexProductCatagorymetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexProductCatagorymetroTextBox.TabIndex = 3;
            this.TexProductCatagorymetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexProductCatagorymetroTextBox.UseSelectable = true;
            this.TexProductCatagorymetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexProductCatagorymetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexProductPricemetroTextBox
            // 
            // 
            // 
            // 
            this.TexProductPricemetroTextBox.CustomButton.Image = null;
            this.TexProductPricemetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
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
            this.TexProductPricemetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexProductPricemetroTextBox.TabIndex = 2;
            this.TexProductPricemetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexProductPricemetroTextBox.UseSelectable = true;
            this.TexProductPricemetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexProductPricemetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage
            // 
            this.metroTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroTabPage.Controls.Add(this.pictureBox3);
            this.metroTabPage.Controls.Add(this.TexsellerAddressmetroTextBox);
            this.metroTabPage.Controls.Add(this.TexsellerCountrymetroTextBox);
            this.metroTabPage.Controls.Add(this.TexsellerMailmetroTextBox);
            this.metroTabPage.Controls.Add(this.TexsellerPhonemetroTextBox);
            this.metroTabPage.Controls.Add(this.TexsellerIdmetroTextBox);
            this.metroTabPage.Controls.Add(this.TexsellerNamemetroTextBox);
            this.metroTabPage.HorizontalScrollbarBarColor = true;
            this.metroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage.HorizontalScrollbarSize = 10;
            this.metroTabPage.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage.Name = "metroTabPage";
            this.metroTabPage.Size = new System.Drawing.Size(283, 284);
            this.metroTabPage.TabIndex = 3;
            this.metroTabPage.Text = "Seller Info";
            this.metroTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage.VerticalScrollbarBarColor = true;
            this.metroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage.VerticalScrollbarSize = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::UI.Properties.Resources._1491607548_gnome_mime_application_x_bzip_compressed_tar;
            this.pictureBox3.Location = new System.Drawing.Point(157, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 98);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // TexsellerAddressmetroTextBox
            // 
            // 
            // 
            // 
            this.TexsellerAddressmetroTextBox.CustomButton.Image = null;
            this.TexsellerAddressmetroTextBox.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.TexsellerAddressmetroTextBox.CustomButton.Name = "";
            this.TexsellerAddressmetroTextBox.CustomButton.Size = new System.Drawing.Size(111, 111);
            this.TexsellerAddressmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexsellerAddressmetroTextBox.CustomButton.TabIndex = 1;
            this.TexsellerAddressmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexsellerAddressmetroTextBox.CustomButton.UseSelectable = true;
            this.TexsellerAddressmetroTextBox.CustomButton.Visible = false;
            this.TexsellerAddressmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexsellerAddressmetroTextBox.Lines = new string[] {
        "Seller Address"};
            this.TexsellerAddressmetroTextBox.Location = new System.Drawing.Point(15, 161);
            this.TexsellerAddressmetroTextBox.MaxLength = 32767;
            this.TexsellerAddressmetroTextBox.Multiline = true;
            this.TexsellerAddressmetroTextBox.Name = "TexsellerAddressmetroTextBox";
            this.TexsellerAddressmetroTextBox.PasswordChar = '\0';
            this.TexsellerAddressmetroTextBox.ReadOnly = true;
            this.TexsellerAddressmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TexsellerAddressmetroTextBox.SelectedText = "";
            this.TexsellerAddressmetroTextBox.SelectionLength = 0;
            this.TexsellerAddressmetroTextBox.SelectionStart = 0;
            this.TexsellerAddressmetroTextBox.ShortcutsEnabled = true;
            this.TexsellerAddressmetroTextBox.Size = new System.Drawing.Size(248, 113);
            this.TexsellerAddressmetroTextBox.TabIndex = 14;
            this.TexsellerAddressmetroTextBox.Text = "Seller Address";
            this.TexsellerAddressmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexsellerAddressmetroTextBox.UseSelectable = true;
            this.TexsellerAddressmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexsellerAddressmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexsellerCountrymetroTextBox
            // 
            // 
            // 
            // 
            this.TexsellerCountrymetroTextBox.CustomButton.Image = null;
            this.TexsellerCountrymetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexsellerCountrymetroTextBox.CustomButton.Name = "";
            this.TexsellerCountrymetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexsellerCountrymetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexsellerCountrymetroTextBox.CustomButton.TabIndex = 1;
            this.TexsellerCountrymetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexsellerCountrymetroTextBox.CustomButton.UseSelectable = true;
            this.TexsellerCountrymetroTextBox.CustomButton.Visible = false;
            this.TexsellerCountrymetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexsellerCountrymetroTextBox.Lines = new string[] {
        "Country"};
            this.TexsellerCountrymetroTextBox.Location = new System.Drawing.Point(15, 132);
            this.TexsellerCountrymetroTextBox.MaxLength = 32767;
            this.TexsellerCountrymetroTextBox.Name = "TexsellerCountrymetroTextBox";
            this.TexsellerCountrymetroTextBox.PasswordChar = '\0';
            this.TexsellerCountrymetroTextBox.ReadOnly = true;
            this.TexsellerCountrymetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexsellerCountrymetroTextBox.SelectedText = "";
            this.TexsellerCountrymetroTextBox.SelectionLength = 0;
            this.TexsellerCountrymetroTextBox.SelectionStart = 0;
            this.TexsellerCountrymetroTextBox.ShortcutsEnabled = true;
            this.TexsellerCountrymetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexsellerCountrymetroTextBox.TabIndex = 13;
            this.TexsellerCountrymetroTextBox.Text = "Country";
            this.TexsellerCountrymetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexsellerCountrymetroTextBox.UseSelectable = true;
            this.TexsellerCountrymetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexsellerCountrymetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexsellerMailmetroTextBox
            // 
            // 
            // 
            // 
            this.TexsellerMailmetroTextBox.CustomButton.Image = null;
            this.TexsellerMailmetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexsellerMailmetroTextBox.CustomButton.Name = "";
            this.TexsellerMailmetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexsellerMailmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexsellerMailmetroTextBox.CustomButton.TabIndex = 1;
            this.TexsellerMailmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexsellerMailmetroTextBox.CustomButton.UseSelectable = true;
            this.TexsellerMailmetroTextBox.CustomButton.Visible = false;
            this.TexsellerMailmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexsellerMailmetroTextBox.Lines = new string[] {
        "Mail"};
            this.TexsellerMailmetroTextBox.Location = new System.Drawing.Point(15, 103);
            this.TexsellerMailmetroTextBox.MaxLength = 32767;
            this.TexsellerMailmetroTextBox.Name = "TexsellerMailmetroTextBox";
            this.TexsellerMailmetroTextBox.PasswordChar = '\0';
            this.TexsellerMailmetroTextBox.ReadOnly = true;
            this.TexsellerMailmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexsellerMailmetroTextBox.SelectedText = "";
            this.TexsellerMailmetroTextBox.SelectionLength = 0;
            this.TexsellerMailmetroTextBox.SelectionStart = 0;
            this.TexsellerMailmetroTextBox.ShortcutsEnabled = true;
            this.TexsellerMailmetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexsellerMailmetroTextBox.TabIndex = 12;
            this.TexsellerMailmetroTextBox.Text = "Mail";
            this.TexsellerMailmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexsellerMailmetroTextBox.UseSelectable = true;
            this.TexsellerMailmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexsellerMailmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexsellerPhonemetroTextBox
            // 
            // 
            // 
            // 
            this.TexsellerPhonemetroTextBox.CustomButton.Image = null;
            this.TexsellerPhonemetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexsellerPhonemetroTextBox.CustomButton.Name = "";
            this.TexsellerPhonemetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexsellerPhonemetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexsellerPhonemetroTextBox.CustomButton.TabIndex = 1;
            this.TexsellerPhonemetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexsellerPhonemetroTextBox.CustomButton.UseSelectable = true;
            this.TexsellerPhonemetroTextBox.CustomButton.Visible = false;
            this.TexsellerPhonemetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexsellerPhonemetroTextBox.Lines = new string[] {
        "Phone No"};
            this.TexsellerPhonemetroTextBox.Location = new System.Drawing.Point(15, 74);
            this.TexsellerPhonemetroTextBox.MaxLength = 32767;
            this.TexsellerPhonemetroTextBox.Name = "TexsellerPhonemetroTextBox";
            this.TexsellerPhonemetroTextBox.PasswordChar = '\0';
            this.TexsellerPhonemetroTextBox.ReadOnly = true;
            this.TexsellerPhonemetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexsellerPhonemetroTextBox.SelectedText = "";
            this.TexsellerPhonemetroTextBox.SelectionLength = 0;
            this.TexsellerPhonemetroTextBox.SelectionStart = 0;
            this.TexsellerPhonemetroTextBox.ShortcutsEnabled = true;
            this.TexsellerPhonemetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexsellerPhonemetroTextBox.TabIndex = 11;
            this.TexsellerPhonemetroTextBox.Text = "Phone No";
            this.TexsellerPhonemetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexsellerPhonemetroTextBox.UseSelectable = true;
            this.TexsellerPhonemetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexsellerPhonemetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexsellerIdmetroTextBox
            // 
            // 
            // 
            // 
            this.TexsellerIdmetroTextBox.CustomButton.Image = null;
            this.TexsellerIdmetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexsellerIdmetroTextBox.CustomButton.Name = "";
            this.TexsellerIdmetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexsellerIdmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexsellerIdmetroTextBox.CustomButton.TabIndex = 1;
            this.TexsellerIdmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexsellerIdmetroTextBox.CustomButton.UseSelectable = true;
            this.TexsellerIdmetroTextBox.CustomButton.Visible = false;
            this.TexsellerIdmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexsellerIdmetroTextBox.Lines = new string[] {
        "Seller Id"};
            this.TexsellerIdmetroTextBox.Location = new System.Drawing.Point(15, 45);
            this.TexsellerIdmetroTextBox.MaxLength = 32767;
            this.TexsellerIdmetroTextBox.Name = "TexsellerIdmetroTextBox";
            this.TexsellerIdmetroTextBox.PasswordChar = '\0';
            this.TexsellerIdmetroTextBox.ReadOnly = true;
            this.TexsellerIdmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexsellerIdmetroTextBox.SelectedText = "";
            this.TexsellerIdmetroTextBox.SelectionLength = 0;
            this.TexsellerIdmetroTextBox.SelectionStart = 0;
            this.TexsellerIdmetroTextBox.ShortcutsEnabled = true;
            this.TexsellerIdmetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexsellerIdmetroTextBox.TabIndex = 10;
            this.TexsellerIdmetroTextBox.Text = "Seller Id";
            this.TexsellerIdmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexsellerIdmetroTextBox.UseSelectable = true;
            this.TexsellerIdmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexsellerIdmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TexsellerNamemetroTextBox
            // 
            // 
            // 
            // 
            this.TexsellerNamemetroTextBox.CustomButton.Image = null;
            this.TexsellerNamemetroTextBox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.TexsellerNamemetroTextBox.CustomButton.Name = "";
            this.TexsellerNamemetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexsellerNamemetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexsellerNamemetroTextBox.CustomButton.TabIndex = 1;
            this.TexsellerNamemetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexsellerNamemetroTextBox.CustomButton.UseSelectable = true;
            this.TexsellerNamemetroTextBox.CustomButton.Visible = false;
            this.TexsellerNamemetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TexsellerNamemetroTextBox.Lines = new string[] {
        "Seller name"};
            this.TexsellerNamemetroTextBox.Location = new System.Drawing.Point(15, 16);
            this.TexsellerNamemetroTextBox.MaxLength = 32767;
            this.TexsellerNamemetroTextBox.Name = "TexsellerNamemetroTextBox";
            this.TexsellerNamemetroTextBox.PasswordChar = '\0';
            this.TexsellerNamemetroTextBox.ReadOnly = true;
            this.TexsellerNamemetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexsellerNamemetroTextBox.SelectedText = "";
            this.TexsellerNamemetroTextBox.SelectionLength = 0;
            this.TexsellerNamemetroTextBox.SelectionStart = 0;
            this.TexsellerNamemetroTextBox.ShortcutsEnabled = true;
            this.TexsellerNamemetroTextBox.Size = new System.Drawing.Size(114, 23);
            this.TexsellerNamemetroTextBox.TabIndex = 9;
            this.TexsellerNamemetroTextBox.Text = "Seller name";
            this.TexsellerNamemetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TexsellerNamemetroTextBox.UseSelectable = true;
            this.TexsellerNamemetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexsellerNamemetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FloCatagoryflowLayoutPanel
            // 
            this.FloCatagoryflowLayoutPanel.AutoScroll = true;
            this.FloCatagoryflowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FloCatagoryflowLayoutPanel.Location = new System.Drawing.Point(6, 14);
            this.FloCatagoryflowLayoutPanel.Name = "FloCatagoryflowLayoutPanel";
            this.FloCatagoryflowLayoutPanel.Size = new System.Drawing.Size(196, 184);
            this.FloCatagoryflowLayoutPanel.TabIndex = 1;
            // 
            // FloBuyerProductflowLayoutPanel
            // 
            this.FloBuyerProductflowLayoutPanel.AutoScroll = true;
            this.FloBuyerProductflowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FloBuyerProductflowLayoutPanel.Location = new System.Drawing.Point(6, 29);
            this.FloBuyerProductflowLayoutPanel.Name = "FloBuyerProductflowLayoutPanel";
            this.FloBuyerProductflowLayoutPanel.Size = new System.Drawing.Size(368, 484);
            this.FloBuyerProductflowLayoutPanel.TabIndex = 1;
            // 
            // ButHomemetroButton
            // 
            this.ButHomemetroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButHomemetroButton.Location = new System.Drawing.Point(30, 319);
            this.ButHomemetroButton.Name = "ButHomemetroButton";
            this.ButHomemetroButton.Size = new System.Drawing.Size(208, 23);
            this.ButHomemetroButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.ButHomemetroButton.TabIndex = 11;
            this.ButHomemetroButton.Text = "Go To Home";
            this.ButHomemetroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButHomemetroButton.UseSelectable = true;
            this.ButHomemetroButton.UseStyleColors = true;
            this.ButHomemetroButton.Click += new System.EventHandler(this.ButHomemetroButton_Click);
            // 
            // SearchedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 607);
            this.Controls.Add(this.ButHomemetroButton);
            this.Controls.Add(this.TabSellermetroTabControl);
            this.Name = "SearchedProduct";
            this.Text = "SearchedProduct";
            this.Load += new System.EventHandler(this.SearchedProduct_Load);
            this.Controls.SetChildIndex(this.TexSearchmetroTextBox, 0);
            this.Controls.SetChildIndex(this.ButMenumetroButton, 0);
            this.Controls.SetChildIndex(this.GroProductListgroupBox, 0);
            this.Controls.SetChildIndex(this.GroProfilegroupBox, 0);
            this.Controls.SetChildIndex(this.GroCatagorygroupBox, 0);
            this.Controls.SetChildIndex(this.GroNotificationgroupBox, 0);
            this.Controls.SetChildIndex(this.ButSearchmetroButton, 0);
            this.Controls.SetChildIndex(this.TabSellermetroTabControl, 0);
            this.Controls.SetChildIndex(this.ButHomemetroButton, 0);
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
            this.metroTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabSellermetroTabControl;
        //private System.Windows.Forms.FlowLayoutPanel FloCatagoryflowLayoutPanel;
        //private System.Windows.Forms.FlowLayoutPanel FloBuyerProductflowLayoutPanel;
        private System.Windows.Forms.GroupBox BoxProductListgroupBox;
        private MetroFramework.Controls.MetroButton ButProductDetailsmetroButton;
        private System.Windows.Forms.PictureBox PicProductListpictureBox;
        private MetroFramework.Controls.MetroButton ButProductAddTobagmetroButton;
        protected MetroFramework.Controls.MetroLabel LabProductcatagory;
        protected MetroFramework.Controls.MetroLabel LabProductCatagorymetroLabel;
        protected MetroFramework.Controls.MetroLabel LabProductPricemetroLabel;
        private MetroFramework.Controls.MetroTile TilCatagorymetroTile;
        private System.Windows.Forms.FlowLayoutPanel FloCatagoryflowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel FloBuyerProductflowLayoutPanel;
        private MetroFramework.Controls.MetroButton ButHomemetroButton;
        private MetroFramework.Controls.MetroTabPage metroTabPage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroTextBox TexsellerAddressmetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexsellerCountrymetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexsellerMailmetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexsellerPhonemetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexsellerIdmetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexsellerNamemetroTextBox;
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
        private MetroFramework.Controls.MetroTextBox TexProductCatagorymetroTextBox;
        private MetroFramework.Controls.MetroTextBox TexProductPricemetroTextBox;
    }
}