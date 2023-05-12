namespace Cars
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.makeCombobox = new System.Windows.Forms.ComboBox();
            this.modelCombobox = new System.Windows.Forms.ComboBox();
            this.showCarsButton = new System.Windows.Forms.Button();
            this.carsTable = new System.Windows.Forms.DataGridView();
            this.logo = new System.Windows.Forms.PictureBox();
            this.cars_label = new System.Windows.Forms.Label();
            this.selectBrandLabel = new System.Windows.Forms.Label();
            this.selectModelLabel = new System.Windows.Forms.Label();
            this.logout_panel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // makeCombobox
            // 
            this.makeCombobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.makeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makeCombobox.FormattingEnabled = true;
            this.makeCombobox.Location = new System.Drawing.Point(257, 72);
            this.makeCombobox.Name = "makeCombobox";
            this.makeCombobox.Size = new System.Drawing.Size(121, 21);
            this.makeCombobox.TabIndex = 0;
            this.makeCombobox.SelectedIndexChanged += new System.EventHandler(this.makeCombobox_SelectedIndexChanged);
            // 
            // modelCombobox
            // 
            this.modelCombobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.modelCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelCombobox.FormattingEnabled = true;
            this.modelCombobox.Location = new System.Drawing.Point(397, 72);
            this.modelCombobox.Name = "modelCombobox";
            this.modelCombobox.Size = new System.Drawing.Size(121, 21);
            this.modelCombobox.TabIndex = 0;
            this.modelCombobox.SelectedIndexChanged += new System.EventHandler(this.modelCombobox_SelectedIndexChanged);
            // 
            // showCarsButton
            // 
            this.showCarsButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.showCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCarsButton.Location = new System.Drawing.Point(547, 51);
            this.showCarsButton.Name = "showCarsButton";
            this.showCarsButton.Size = new System.Drawing.Size(95, 46);
            this.showCarsButton.TabIndex = 1;
            this.showCarsButton.Text = "Show Cars";
            this.showCarsButton.UseVisualStyleBackColor = false;
            this.showCarsButton.Click += new System.EventHandler(this.showCarsButton_Click);
            // 
            // carsTable
            // 
            this.carsTable.BackgroundColor = System.Drawing.Color.White;
            this.carsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsTable.Location = new System.Drawing.Point(15, 132);
            this.carsTable.Name = "carsTable";
            this.carsTable.Size = new System.Drawing.Size(819, 343);
            this.carsTable.TabIndex = 2;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(15, 40);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(148, 86);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_label.Location = new System.Drawing.Point(14, 5);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(149, 32);
            this.cars_label.TabIndex = 6;
            this.cars_label.Text = "car$.com";
            // 
            // selectBrandLabel
            // 
            this.selectBrandLabel.AutoSize = true;
            this.selectBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBrandLabel.Location = new System.Drawing.Point(270, 51);
            this.selectBrandLabel.Name = "selectBrandLabel";
            this.selectBrandLabel.Size = new System.Drawing.Size(96, 18);
            this.selectBrandLabel.TabIndex = 8;
            this.selectBrandLabel.Text = "Select Brand:";
            // 
            // selectModelLabel
            // 
            this.selectModelLabel.AutoSize = true;
            this.selectModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectModelLabel.Location = new System.Drawing.Point(410, 51);
            this.selectModelLabel.Name = "selectModelLabel";
            this.selectModelLabel.Size = new System.Drawing.Size(98, 18);
            this.selectModelLabel.TabIndex = 8;
            this.selectModelLabel.Text = "Select Model:";
            // 
            // logout_panel_button
            // 
            this.logout_panel_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.logout_panel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_panel_button.Location = new System.Drawing.Point(778, 5);
            this.logout_panel_button.Margin = new System.Windows.Forms.Padding(2);
            this.logout_panel_button.Name = "logout_panel_button";
            this.logout_panel_button.Size = new System.Drawing.Size(56, 50);
            this.logout_panel_button.TabIndex = 18;
            this.logout_panel_button.Text = "Log Out";
            this.logout_panel_button.UseVisualStyleBackColor = false;
            this.logout_panel_button.Click += new System.EventHandler(this.logout_panel_button_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(849, 487);
            this.Controls.Add(this.logout_panel_button);
            this.Controls.Add(this.selectModelLabel);
            this.Controls.Add(this.selectBrandLabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.cars_label);
            this.Controls.Add(this.carsTable);
            this.Controls.Add(this.showCarsButton);
            this.Controls.Add(this.modelCombobox);
            this.Controls.Add(this.makeCombobox);
            this.MaximizeBox = false;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "car$.com";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox makeCombobox;
        private System.Windows.Forms.ComboBox modelCombobox;
        private System.Windows.Forms.Button showCarsButton;
        private System.Windows.Forms.DataGridView carsTable;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label cars_label;
        private System.Windows.Forms.Label selectBrandLabel;
        private System.Windows.Forms.Label selectModelLabel;
        private System.Windows.Forms.Button logout_panel_button;
    }
}