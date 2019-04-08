namespace UI
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButLoginmetroButton = new MetroFramework.Controls.MetroButton();
            this.TxtUsernamemetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TxtPasswordmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ComUserTypemetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ButSignupmetroButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ButLoginmetroButton
            // 
            this.ButLoginmetroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButLoginmetroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButLoginmetroButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButLoginmetroButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButLoginmetroButton.Location = new System.Drawing.Point(27, 299);
            this.ButLoginmetroButton.Name = "ButLoginmetroButton";
            this.ButLoginmetroButton.Size = new System.Drawing.Size(268, 23);
            this.ButLoginmetroButton.TabIndex = 0;
            this.ButLoginmetroButton.Text = "Login";
            this.ButLoginmetroButton.UseCustomBackColor = true;
            this.ButLoginmetroButton.UseSelectable = true;
            this.ButLoginmetroButton.Click += new System.EventHandler(this.LoginmetroButton_Click);
            // 
            // TxtUsernamemetroTextBox
            // 
            this.TxtUsernamemetroTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.TxtUsernamemetroTextBox.CustomButton.Image = null;
            this.TxtUsernamemetroTextBox.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.TxtUsernamemetroTextBox.CustomButton.Name = "";
            this.TxtUsernamemetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtUsernamemetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUsernamemetroTextBox.CustomButton.TabIndex = 1;
            this.TxtUsernamemetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUsernamemetroTextBox.CustomButton.UseSelectable = true;
            this.TxtUsernamemetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtUsernamemetroTextBox.Lines = new string[0];
            this.TxtUsernamemetroTextBox.Location = new System.Drawing.Point(27, 97);
            this.TxtUsernamemetroTextBox.MaxLength = 32767;
            this.TxtUsernamemetroTextBox.Name = "TxtUsernamemetroTextBox";
            this.TxtUsernamemetroTextBox.PasswordChar = '\0';
            this.TxtUsernamemetroTextBox.PromptText = "User Name";
            this.TxtUsernamemetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUsernamemetroTextBox.SelectedText = "";
            this.TxtUsernamemetroTextBox.SelectionLength = 0;
            this.TxtUsernamemetroTextBox.SelectionStart = 0;
            this.TxtUsernamemetroTextBox.ShortcutsEnabled = true;
            this.TxtUsernamemetroTextBox.ShowButton = true;
            this.TxtUsernamemetroTextBox.Size = new System.Drawing.Size(268, 29);
            this.TxtUsernamemetroTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUsernamemetroTextBox.TabIndex = 1;
            this.TxtUsernamemetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtUsernamemetroTextBox.UseSelectable = true;
            this.TxtUsernamemetroTextBox.WaterMark = "User Name";
            this.TxtUsernamemetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUsernamemetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsernamemetroTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // TxtPasswordmetroTextBox
            // 
            this.TxtPasswordmetroTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.TxtPasswordmetroTextBox.CustomButton.Image = null;
            this.TxtPasswordmetroTextBox.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.TxtPasswordmetroTextBox.CustomButton.Name = "";
            this.TxtPasswordmetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtPasswordmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPasswordmetroTextBox.CustomButton.TabIndex = 1;
            this.TxtPasswordmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPasswordmetroTextBox.CustomButton.UseSelectable = true;
            this.TxtPasswordmetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPasswordmetroTextBox.Lines = new string[0];
            this.TxtPasswordmetroTextBox.Location = new System.Drawing.Point(27, 139);
            this.TxtPasswordmetroTextBox.MaxLength = 32767;
            this.TxtPasswordmetroTextBox.Name = "TxtPasswordmetroTextBox";
            this.TxtPasswordmetroTextBox.PasswordChar = '\0';
            this.TxtPasswordmetroTextBox.PromptText = "Password";
            this.TxtPasswordmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPasswordmetroTextBox.SelectedText = "";
            this.TxtPasswordmetroTextBox.SelectionLength = 0;
            this.TxtPasswordmetroTextBox.SelectionStart = 0;
            this.TxtPasswordmetroTextBox.ShortcutsEnabled = true;
            this.TxtPasswordmetroTextBox.ShowButton = true;
            this.TxtPasswordmetroTextBox.Size = new System.Drawing.Size(268, 29);
            this.TxtPasswordmetroTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPasswordmetroTextBox.TabIndex = 2;
            this.TxtPasswordmetroTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtPasswordmetroTextBox.UseSelectable = true;
            this.TxtPasswordmetroTextBox.WaterMark = "Password";
            this.TxtPasswordmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPasswordmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPasswordmetroTextBox.Click += new System.EventHandler(this.PasswordmetroTextBox_Click);
            // 
            // ComUserTypemetroComboBox
            // 
            this.ComUserTypemetroComboBox.FormattingEnabled = true;
            this.ComUserTypemetroComboBox.ItemHeight = 23;
            this.ComUserTypemetroComboBox.Items.AddRange(new object[] {
            "Buyer",
            "Seller"});
            this.ComUserTypemetroComboBox.Location = new System.Drawing.Point(27, 181);
            this.ComUserTypemetroComboBox.Name = "ComUserTypemetroComboBox";
            this.ComUserTypemetroComboBox.PromptText = "Select User type";
            this.ComUserTypemetroComboBox.Size = new System.Drawing.Size(268, 29);
            this.ComUserTypemetroComboBox.TabIndex = 3;
            this.ComUserTypemetroComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ComUserTypemetroComboBox.UseSelectable = true;
            this.ComUserTypemetroComboBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // ButSignupmetroButton
            // 
            this.ButSignupmetroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButSignupmetroButton.DisplayFocus = true;
            this.ButSignupmetroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButSignupmetroButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButSignupmetroButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButSignupmetroButton.Location = new System.Drawing.Point(27, 341);
            this.ButSignupmetroButton.Name = "ButSignupmetroButton";
            this.ButSignupmetroButton.Size = new System.Drawing.Size(268, 23);
            this.ButSignupmetroButton.TabIndex = 4;
            this.ButSignupmetroButton.Text = "Sign up";
            this.ButSignupmetroButton.UseCustomBackColor = true;
            this.ButSignupmetroButton.UseSelectable = true;
            this.ButSignupmetroButton.Click += new System.EventHandler(this.SignupmetroButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(318, 431);
            this.Controls.Add(this.ButSignupmetroButton);
            this.Controls.Add(this.ComUserTypemetroComboBox);
            this.Controls.Add(this.TxtPasswordmetroTextBox);
            this.Controls.Add(this.TxtUsernamemetroTextBox);
            this.Controls.Add(this.ButLoginmetroButton);
            this.Name = "Login";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton ButLoginmetroButton;
        private MetroFramework.Controls.MetroTextBox TxtUsernamemetroTextBox;
        private MetroFramework.Controls.MetroTextBox TxtPasswordmetroTextBox;
        private MetroFramework.Controls.MetroComboBox ComUserTypemetroComboBox;
        private MetroFramework.Controls.MetroButton ButSignupmetroButton;
    }
}

