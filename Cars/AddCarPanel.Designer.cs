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
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.kmLabel = new System.Windows.Forms.Label();
            this.ccLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(13, 13);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(107, 69);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Font = new System.Drawing.Font("Magneto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_label.Location = new System.Drawing.Point(128, 34);
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
            this.makeTextbox.Location = new System.Drawing.Point(12, 117);
            this.makeTextbox.Name = "makeTextbox";
            this.makeTextbox.Size = new System.Drawing.Size(167, 28);
            this.makeTextbox.TabIndex = 10;
            this.makeTextbox.TextChanged += new System.EventHandler(this.makeTextbox_TextChanged);
            // 
            // modelTextbox
            // 
            this.modelTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.modelTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextbox.Location = new System.Drawing.Point(12, 208);
            this.modelTextbox.Name = "modelTextbox";
            this.modelTextbox.Size = new System.Drawing.Size(167, 28);
            this.modelTextbox.TabIndex = 10;
            this.modelTextbox.TextChanged += new System.EventHandler(this.modelTextbox_TextChanged);
            // 
            // yearTextbox
            // 
            this.yearTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.yearTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextbox.Location = new System.Drawing.Point(12, 304);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(167, 28);
            this.yearTextbox.TabIndex = 10;
            this.yearTextbox.TextChanged += new System.EventHandler(this.yearTextbox_TextChanged);
            // 
            // hpTextbox
            // 
            this.hpTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hpTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpTextbox.Location = new System.Drawing.Point(413, 208);
            this.hpTextbox.Name = "hpTextbox";
            this.hpTextbox.Size = new System.Drawing.Size(167, 28);
            this.hpTextbox.TabIndex = 10;
            this.hpTextbox.TextChanged += new System.EventHandler(this.hpTextbox_TextChanged);
            // 
            // versionTextbox
            // 
            this.versionTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.versionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionTextbox.Location = new System.Drawing.Point(213, 117);
            this.versionTextbox.Name = "versionTextbox";
            this.versionTextbox.Size = new System.Drawing.Size(167, 28);
            this.versionTextbox.TabIndex = 10;
            this.versionTextbox.TextChanged += new System.EventHandler(this.versionTextbox_TextChanged);
            // 
            // colorTextbox
            // 
            this.colorTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.colorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextbox.Location = new System.Drawing.Point(213, 208);
            this.colorTextbox.Name = "colorTextbox";
            this.colorTextbox.Size = new System.Drawing.Size(167, 28);
            this.colorTextbox.TabIndex = 10;
            this.colorTextbox.TextChanged += new System.EventHandler(this.colorTextbox_TextChanged);
            // 
            // kmTextbox
            // 
            this.kmTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kmTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmTextbox.Location = new System.Drawing.Point(213, 304);
            this.kmTextbox.Name = "kmTextbox";
            this.kmTextbox.Size = new System.Drawing.Size(167, 28);
            this.kmTextbox.TabIndex = 10;
            this.kmTextbox.TextChanged += new System.EventHandler(this.kmTextbox_TextChanged);
            // 
            // priceTextbox
            // 
            this.priceTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.priceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextbox.Location = new System.Drawing.Point(413, 304);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(167, 28);
            this.priceTextbox.TabIndex = 10;
            this.priceTextbox.TextChanged += new System.EventHandler(this.priceTextbox_TextChanged);
            // 
            // ccTextbox
            // 
            this.ccTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ccTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccTextbox.Location = new System.Drawing.Point(413, 117);
            this.ccTextbox.Name = "ccTextbox";
            this.ccTextbox.Size = new System.Drawing.Size(167, 28);
            this.ccTextbox.TabIndex = 10;
            this.ccTextbox.TextChanged += new System.EventHandler(this.ccTextbox_TextChanged);
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.Location = new System.Drawing.Point(262, 354);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(72, 66);
            this.addCarButton.TabIndex = 11;
            this.addCarButton.Text = "Add Car";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.Location = new System.Drawing.Point(10, 86);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(58, 22);
            this.makeLabel.TabIndex = 12;
            this.makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(10, 175);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(63, 22);
            this.modelLabel.TabIndex = 12;
            this.modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(10, 273);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(53, 22);
            this.yearLabel.TabIndex = 12;
            this.yearLabel.Text = "Year:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(211, 86);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(76, 22);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "Version:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(211, 175);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(58, 22);
            this.colorLabel.TabIndex = 12;
            this.colorLabel.Text = "Color:";
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmLabel.Location = new System.Drawing.Point(211, 273);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(90, 22);
            this.kmLabel.TabIndex = 12;
            this.kmLabel.Text = "Kilometer:";
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccLabel.Location = new System.Drawing.Point(412, 86);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(156, 22);
            this.ccLabel.TabIndex = 12;
            this.ccLabel.Text = "Cylinder Capacity:";
            this.ccLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(412, 175);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(119, 22);
            this.hpLabel.TabIndex = 12;
            this.hpLabel.Text = "Horse Power:";
            this.hpLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(412, 273);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 22);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Price:";
            this.priceLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddCarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(593, 431);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.kmLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.ccLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeLabel);
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
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.Label ccLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}