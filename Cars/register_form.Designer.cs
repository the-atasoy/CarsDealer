namespace Cars
{
    partial class register_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register_form));
            this.user_name_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.carscom_label = new System.Windows.Forms.Label();
            this.username_textboox = new System.Windows.Forms.TextBox();
            this.email_textboox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.is_username_label = new System.Windows.Forms.Label();
            this.is_email_label = new System.Windows.Forms.Label();
            this.is_password_label = new System.Windows.Forms.Label();
            this.is_phonenumber_label = new System.Windows.Forms.Label();
            this.register_label = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.show_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_label.Location = new System.Drawing.Point(188, 235);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(125, 25);
            this.user_name_label.TabIndex = 0;
            this.user_name_label.Text = "User Name:";
            this.user_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(152, 324);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(161, 25);
            this.phone_label.TabIndex = 0;
            this.phone_label.Text = "Phone Number:";
            this.phone_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(235, 281);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(78, 25);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "E Mail:";
            this.email_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.Location = new System.Drawing.Point(328, 422);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(224, 29);
            this.register_button.TabIndex = 4;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
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
            // carscom_label
            // 
            this.carscom_label.AutoSize = true;
            this.carscom_label.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carscom_label.Location = new System.Drawing.Point(316, 9);
            this.carscom_label.Name = "carscom_label";
            this.carscom_label.Size = new System.Drawing.Size(257, 58);
            this.carscom_label.TabIndex = 6;
            this.carscom_label.Text = "cars.com";
            // 
            // username_textboox
            // 
            this.username_textboox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.username_textboox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textboox.Location = new System.Drawing.Point(328, 241);
            this.username_textboox.MaxLength = 16;
            this.username_textboox.Name = "username_textboox";
            this.username_textboox.Size = new System.Drawing.Size(224, 24);
            this.username_textboox.TabIndex = 0;
            this.username_textboox.TextChanged += new System.EventHandler(this.username_textboox_TextChanged);
            // 
            // email_textboox
            // 
            this.email_textboox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.email_textboox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textboox.Location = new System.Drawing.Point(328, 286);
            this.email_textboox.MaxLength = 50;
            this.email_textboox.Name = "email_textboox";
            this.email_textboox.Size = new System.Drawing.Size(224, 24);
            this.email_textboox.TabIndex = 1;
            this.email_textboox.TextChanged += new System.EventHandler(this.email_textboox_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(328, 371);
            this.password_textbox.MaxLength = 30;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(169, 24);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(201, 366);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(112, 25);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Password:";
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
            // phone_textbox
            // 
            this.phone_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.phone_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_textbox.Location = new System.Drawing.Point(328, 328);
            this.phone_textbox.MaxLength = 10;
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(224, 24);
            this.phone_textbox.TabIndex = 2;
            this.phone_textbox.Tag = "";
            this.phone_textbox.Text = "\r\n\r\n";
            this.phone_textbox.TextChanged += new System.EventHandler(this.phone_textbox_TextChanged);
            // 
            // show_checkbox
            // 
            this.show_checkbox.AutoSize = true;
            this.show_checkbox.Location = new System.Drawing.Point(504, 375);
            this.show_checkbox.Name = "show_checkbox";
            this.show_checkbox.Size = new System.Drawing.Size(53, 17);
            this.show_checkbox.TabIndex = 16;
            this.show_checkbox.Text = "Show";
            this.show_checkbox.UseVisualStyleBackColor = true;
            this.show_checkbox.CheckedChanged += new System.EventHandler(this.show_checkbox_CheckedChanged);
            // 
            // register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 484);
            this.Controls.Add(this.show_checkbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.is_phonenumber_label);
            this.Controls.Add(this.is_password_label);
            this.Controls.Add(this.is_email_label);
            this.Controls.Add(this.is_username_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_textboox);
            this.Controls.Add(this.username_textboox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.carscom_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.user_name_label);
            this.MaximizeBox = false;
            this.Name = "register_form";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.register_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label carscom_label;
        private System.Windows.Forms.TextBox username_textboox;
        private System.Windows.Forms.TextBox email_textboox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label is_username_label;
        private System.Windows.Forms.Label is_email_label;
        private System.Windows.Forms.Label is_password_label;
        private System.Windows.Forms.Label is_phonenumber_label;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.CheckBox show_checkbox;
    }
}