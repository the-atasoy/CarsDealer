namespace CarsDealer
{
    partial class RegisterPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPanel));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.carscomLabel = new System.Windows.Forms.Label();
            this.usernameTextboox = new System.Windows.Forms.TextBox();
            this.emailTextboox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.is_username_label = new System.Windows.Forms.Label();
            this.is_email_label = new System.Windows.Forms.Label();
            this.is_password_label = new System.Windows.Forms.Label();
            this.is_phonenumber_label = new System.Windows.Forms.Label();
            this.register_label = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.showCheckbox = new System.Windows.Forms.CheckBox();
            this.loginPanelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(188, 235);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(125, 25);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "User Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(152, 324);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(161, 25);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(235, 281);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 25);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E Mail:";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(328, 422);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(224, 29);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.register_button_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(328, 83);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(224, 130);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // carscomLabel
            // 
            this.carscomLabel.AutoSize = true;
            this.carscomLabel.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carscomLabel.Location = new System.Drawing.Point(277, 9);
            this.carscomLabel.Name = "carscomLabel";
            this.carscomLabel.Size = new System.Drawing.Size(330, 58);
            this.carscomLabel.TabIndex = 6;
            this.carscomLabel.Text = "Car$Dealer";
            // 
            // usernameTextboox
            // 
            this.usernameTextboox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameTextboox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextboox.Location = new System.Drawing.Point(328, 241);
            this.usernameTextboox.MaxLength = 16;
            this.usernameTextboox.Name = "usernameTextboox";
            this.usernameTextboox.Size = new System.Drawing.Size(224, 24);
            this.usernameTextboox.TabIndex = 0;
            this.usernameTextboox.TextChanged += new System.EventHandler(this.usernameTextboox_TextChanged);
            // 
            // emailTextboox
            // 
            this.emailTextboox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.emailTextboox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextboox.Location = new System.Drawing.Point(328, 286);
            this.emailTextboox.MaxLength = 50;
            this.emailTextboox.Name = "emailTextboox";
            this.emailTextboox.Size = new System.Drawing.Size(224, 24);
            this.emailTextboox.TabIndex = 1;
            this.emailTextboox.TextChanged += new System.EventHandler(this.emailTextboox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(328, 371);
            this.passwordTextbox.MaxLength = 30;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(169, 24);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(201, 366);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(112, 25);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password:";
            // 
            // is_username_label
            // 
            this.is_username_label.AutoSize = true;
            this.is_username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_username_label.ForeColor = System.Drawing.Color.Red;
            this.is_username_label.Location = new System.Drawing.Point(573, 242);
            this.is_username_label.Name = "is_username_label";
            this.is_username_label.Size = new System.Drawing.Size(0, 16);
            this.is_username_label.TabIndex = 14;
            // 
            // is_email_label
            // 
            this.is_email_label.AutoSize = true;
            this.is_email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_email_label.ForeColor = System.Drawing.Color.Red;
            this.is_email_label.Location = new System.Drawing.Point(573, 288);
            this.is_email_label.Name = "is_email_label";
            this.is_email_label.Size = new System.Drawing.Size(0, 16);
            this.is_email_label.TabIndex = 14;
            this.is_email_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // is_password_label
            // 
            this.is_password_label.AutoSize = true;
            this.is_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_password_label.ForeColor = System.Drawing.Color.Red;
            this.is_password_label.Location = new System.Drawing.Point(573, 376);
            this.is_password_label.Name = "is_password_label";
            this.is_password_label.Size = new System.Drawing.Size(0, 16);
            this.is_password_label.TabIndex = 14;
            // 
            // is_phonenumber_label
            // 
            this.is_phonenumber_label.AutoSize = true;
            this.is_phonenumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_phonenumber_label.ForeColor = System.Drawing.Color.Red;
            this.is_phonenumber_label.Location = new System.Drawing.Point(573, 331);
            this.is_phonenumber_label.Name = "is_phonenumber_label";
            this.is_phonenumber_label.Size = new System.Drawing.Size(0, 16);
            this.is_phonenumber_label.TabIndex = 14;
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.ForeColor = System.Drawing.Color.LimeGreen;
            this.register_label.Location = new System.Drawing.Point(382, 459);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(0, 16);
            this.register_label.TabIndex = 15;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.phoneTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextbox.Location = new System.Drawing.Point(328, 328);
            this.phoneTextbox.MaxLength = 10;
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(224, 24);
            this.phoneTextbox.TabIndex = 2;
            this.phoneTextbox.Tag = "";
            this.phoneTextbox.Text = "\r\n\r\n";
            this.phoneTextbox.TextChanged += new System.EventHandler(this.phoneTextbox_TextChanged);
            // 
            // showCheckbox
            // 
            this.showCheckbox.AutoSize = true;
            this.showCheckbox.Location = new System.Drawing.Point(504, 375);
            this.showCheckbox.Name = "showCheckbox";
            this.showCheckbox.Size = new System.Drawing.Size(53, 17);
            this.showCheckbox.TabIndex = 4;
            this.showCheckbox.Text = "Show";
            this.showCheckbox.UseVisualStyleBackColor = true;
            this.showCheckbox.CheckedChanged += new System.EventHandler(this.showCheckbox_CheckedChanged);
            // 
            // loginPanelButton
            // 
            this.loginPanelButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.loginPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPanelButton.Location = new System.Drawing.Point(10, 11);
            this.loginPanelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginPanelButton.Name = "loginPanelButton";
            this.loginPanelButton.Size = new System.Drawing.Size(56, 50);
            this.loginPanelButton.TabIndex = 17;
            this.loginPanelButton.Text = "Login Panel";
            this.loginPanelButton.UseVisualStyleBackColor = false;
            this.loginPanelButton.Click += new System.EventHandler(this.loginPanelButton_Click);
            // 
            // RegisterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(846, 484);
            this.Controls.Add(this.loginPanelButton);
            this.Controls.Add(this.showCheckbox);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.is_phonenumber_label);
            this.Controls.Add(this.is_password_label);
            this.Controls.Add(this.is_email_label);
            this.Controls.Add(this.is_username_label);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextboox);
            this.Controls.Add(this.usernameTextboox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.carscomLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label carscomLabel;
        private System.Windows.Forms.TextBox usernameTextboox;
        private System.Windows.Forms.TextBox emailTextboox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label is_username_label;
        private System.Windows.Forms.Label is_email_label;
        private System.Windows.Forms.Label is_password_label;
        private System.Windows.Forms.Label is_phonenumber_label;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.CheckBox showCheckbox;
        private System.Windows.Forms.Button loginPanelButton;
    }
}