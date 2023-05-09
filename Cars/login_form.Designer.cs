namespace Cars
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.isadmin_checkbox = new System.Windows.Forms.CheckBox();
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.register_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.cars_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(184, 231);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(125, 25);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "User Name:";
            this.username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(197, 283);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(112, 25);
            this.password_label.TabIndex = 0;
            this.password_label.Text = "Password:";
            this.password_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(329, 237);
            this.username_textbox.MaxLength = 15;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(224, 24);
            this.username_textbox.TabIndex = 1;
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(329, 288);
            this.password_textbox.MaxLength = 20;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(224, 24);
            this.password_textbox.TabIndex = 1;
            this.password_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // isadmin_checkbox
            // 
            this.isadmin_checkbox.AutoSize = true;
            this.isadmin_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isadmin_checkbox.Location = new System.Drawing.Point(570, 237);
            this.isadmin_checkbox.Name = "isadmin_checkbox";
            this.isadmin_checkbox.Size = new System.Drawing.Size(68, 22);
            this.isadmin_checkbox.TabIndex = 2;
            this.isadmin_checkbox.Text = "Admin";
            this.isadmin_checkbox.UseVisualStyleBackColor = true;
            this.isadmin_checkbox.CheckedChanged += new System.EventHandler(this.isadmin_checkbox_CheckedChanged);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(329, 332);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(224, 29);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.Location = new System.Drawing.Point(464, 427);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(89, 29);
            this.register_button.TabIndex = 3;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.Location = new System.Drawing.Point(326, 434);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(132, 16);
            this.register_label.TabIndex = 4;
            this.register_label.Text = "Don\'t Have Account?";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(329, 83);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(224, 130);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_label.Location = new System.Drawing.Point(316, 9);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(257, 58);
            this.cars_label.TabIndex = 0;
            this.cars_label.Text = "cars.com";
            this.cars_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 487);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.isadmin_checkbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.cars_label);
            this.Controls.Add(this.username_label);
            this.MaximizeBox = false;
            this.Name = "login_form";
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
        private System.Windows.Forms.CheckBox isadmin_checkbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label cars_label;
    }
}

