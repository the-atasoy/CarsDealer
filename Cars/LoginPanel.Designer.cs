namespace Cars
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.register_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.cars_label = new System.Windows.Forms.Label();
            this.show_checkbox = new System.Windows.Forms.CheckBox();
            this.error_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(245, 284);
            this.username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(159, 31);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "User Name:";
            this.username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(263, 348);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(142, 31);
            this.password_label.TabIndex = 0;
            this.password_label.Text = "Password:";
            this.password_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(439, 292);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.username_textbox.MaxLength = 15;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(297, 29);
            this.username_textbox.TabIndex = 1;
            this.username_textbox.TextChanged += new System.EventHandler(this.username_textbox_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(439, 354);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_textbox.MaxLength = 20;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(225, 29);
            this.password_textbox.TabIndex = 2;
            this.password_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(439, 417);
            this.login_button.Margin = new System.Windows.Forms.Padding(4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(299, 36);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.Location = new System.Drawing.Point(619, 526);
            this.register_button.Margin = new System.Windows.Forms.Padding(4);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(119, 36);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.Location = new System.Drawing.Point(435, 534);
            this.register_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(168, 20);
            this.register_label.TabIndex = 4;
            this.register_label.Text = "Don\'t Have Account?";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(439, 102);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(299, 160);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_label.Location = new System.Drawing.Point(421, 11);
            this.cars_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(321, 73);
            this.cars_label.TabIndex = 0;
            this.cars_label.Text = "cars.com";
            this.cars_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // show_checkbox
            // 
            this.show_checkbox.AutoSize = true;
            this.show_checkbox.Location = new System.Drawing.Point(677, 359);
            this.show_checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.show_checkbox.Name = "show_checkbox";
            this.show_checkbox.Size = new System.Drawing.Size(62, 20);
            this.show_checkbox.TabIndex = 3;
            this.show_checkbox.Text = "Show";
            this.show_checkbox.UseVisualStyleBackColor = true;
            this.show_checkbox.CheckedChanged += new System.EventHandler(this.show_checkbox_CheckedChanged);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(450, 471);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 20);
            this.error_label.TabIndex = 18;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 599);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.show_checkbox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.cars_label);
            this.Controls.Add(this.username_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label cars_label;
        private System.Windows.Forms.CheckBox show_checkbox;
        private System.Windows.Forms.Label error_label;
    }
}

