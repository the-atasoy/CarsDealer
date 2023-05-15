namespace Cars
{
    partial class AddCarPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarPanel));
            this.logo = new System.Windows.Forms.PictureBox();
            this.cars_label = new System.Windows.Forms.Label();
            this.makeTextbox = new System.Windows.Forms.TextBox();
            this.modelTextbox = new System.Windows.Forms.TextBox();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.hpTextbox = new System.Windows.Forms.TextBox();
            this.versionTextbox = new System.Windows.Forms.TextBox();
            this.colorTextbox = new System.Windows.Forms.TextBox();
            this.kmTextbox = new System.Windows.Forms.TextBox();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.ccTextbox = new System.Windows.Forms.TextBox();
            this.addCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(13, 13);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(75, 44);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Font = new System.Drawing.Font("Magneto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_label.Location = new System.Drawing.Point(96, 24);
            this.cars_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(99, 22);
            this.cars_label.TabIndex = 8;
            this.cars_label.Text = "car$.com";
            // 
            // makeTextbox
            // 
            this.makeTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.makeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTextbox.Location = new System.Drawing.Point(12, 106);
            this.makeTextbox.Name = "makeTextbox";
            this.makeTextbox.Size = new System.Drawing.Size(167, 28);
            this.makeTextbox.TabIndex = 10;
            this.makeTextbox.TextChanged += new System.EventHandler(this.makeTextbox_TextChanged);
            // 
            // modelTextbox
            // 
            this.modelTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.modelTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextbox.Location = new System.Drawing.Point(12, 161);
            this.modelTextbox.Name = "modelTextbox";
            this.modelTextbox.Size = new System.Drawing.Size(167, 28);
            this.modelTextbox.TabIndex = 10;
            this.modelTextbox.TextChanged += new System.EventHandler(this.modelTextbox_TextChanged);
            // 
            // yearTextbox
            // 
            this.yearTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.yearTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextbox.Location = new System.Drawing.Point(12, 214);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(167, 28);
            this.yearTextbox.TabIndex = 10;
            this.yearTextbox.TextChanged += new System.EventHandler(this.yearTextbox_TextChanged);
            // 
            // hpTextbox
            // 
            this.hpTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hpTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpTextbox.Location = new System.Drawing.Point(413, 161);
            this.hpTextbox.Name = "hpTextbox";
            this.hpTextbox.Size = new System.Drawing.Size(167, 28);
            this.hpTextbox.TabIndex = 10;
            this.hpTextbox.TextChanged += new System.EventHandler(this.hpTextbox_TextChanged);
            // 
            // versionTextbox
            // 
            this.versionTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.versionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionTextbox.Location = new System.Drawing.Point(213, 106);
            this.versionTextbox.Name = "versionTextbox";
            this.versionTextbox.Size = new System.Drawing.Size(167, 28);
            this.versionTextbox.TabIndex = 10;
            this.versionTextbox.TextChanged += new System.EventHandler(this.versionTextbox_TextChanged);
            // 
            // colorTextbox
            // 
            this.colorTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.colorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextbox.Location = new System.Drawing.Point(213, 161);
            this.colorTextbox.Name = "colorTextbox";
            this.colorTextbox.Size = new System.Drawing.Size(167, 28);
            this.colorTextbox.TabIndex = 10;
            this.colorTextbox.TextChanged += new System.EventHandler(this.colorTextbox_TextChanged);
            // 
            // kmTextbox
            // 
            this.kmTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kmTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmTextbox.Location = new System.Drawing.Point(213, 214);
            this.kmTextbox.Name = "kmTextbox";
            this.kmTextbox.Size = new System.Drawing.Size(167, 28);
            this.kmTextbox.TabIndex = 10;
            this.kmTextbox.TextChanged += new System.EventHandler(this.kmTextbox_TextChanged);
            // 
            // priceTextbox
            // 
            this.priceTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.priceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextbox.Location = new System.Drawing.Point(413, 214);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(167, 28);
            this.priceTextbox.TabIndex = 10;
            this.priceTextbox.TextChanged += new System.EventHandler(this.priceTextbox_TextChanged);
            // 
            // ccTextbox
            // 
            this.ccTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ccTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccTextbox.Location = new System.Drawing.Point(413, 106);
            this.ccTextbox.Name = "ccTextbox";
            this.ccTextbox.Size = new System.Drawing.Size(167, 28);
            this.ccTextbox.TabIndex = 10;
            this.ccTextbox.TextChanged += new System.EventHandler(this.ccTextbox_TextChanged);
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.Location = new System.Drawing.Point(261, 260);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(72, 66);
            this.addCarButton.TabIndex = 11;
            this.addCarButton.Text = "Add Car";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // AddCarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(593, 338);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.hpTextbox);
            this.Controls.Add(this.kmTextbox);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.colorTextbox);
            this.Controls.Add(this.ccTextbox);
            this.Controls.Add(this.versionTextbox);
            this.Controls.Add(this.modelTextbox);
            this.Controls.Add(this.makeTextbox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.cars_label);
            this.MaximizeBox = false;
            this.Name = "AddCarPanel";
            this.Text = "AddCarPanel";
            this.Load += new System.EventHandler(this.AddCarPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label cars_label;
        private System.Windows.Forms.TextBox makeTextbox;
        private System.Windows.Forms.TextBox modelTextbox;
        private System.Windows.Forms.TextBox yearTextbox;
        private System.Windows.Forms.TextBox hpTextbox;
        private System.Windows.Forms.TextBox versionTextbox;
        private System.Windows.Forms.TextBox colorTextbox;
        private System.Windows.Forms.TextBox kmTextbox;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.TextBox ccTextbox;
        private System.Windows.Forms.Button addCarButton;
    }
}