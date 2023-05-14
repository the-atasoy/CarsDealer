﻿namespace Cars
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
            this.makeCombobox.Location = new System.Drawing.Point(343, 89);
            this.makeCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.makeCombobox.Name = "makeCombobox";
            this.makeCombobox.Size = new System.Drawing.Size(160, 24);
            this.makeCombobox.TabIndex = 0;
            this.makeCombobox.SelectedIndexChanged += new System.EventHandler(this.makeCombobox_SelectedIndexChanged);
            // 
            // modelCombobox
            // 
            this.modelCombobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.modelCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelCombobox.FormattingEnabled = true;
            this.modelCombobox.Location = new System.Drawing.Point(529, 89);
            this.modelCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modelCombobox.Name = "modelCombobox";
            this.modelCombobox.Size = new System.Drawing.Size(160, 24);
            this.modelCombobox.TabIndex = 0;
            this.modelCombobox.SelectedIndexChanged += new System.EventHandler(this.modelCombobox_SelectedIndexChanged);
            // 
            // showCarsButton
            // 
            this.showCarsButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.showCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCarsButton.Location = new System.Drawing.Point(729, 63);
            this.showCarsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showCarsButton.Name = "showCarsButton";
            this.showCarsButton.Size = new System.Drawing.Size(127, 57);
            this.showCarsButton.TabIndex = 1;
            this.showCarsButton.Text = "Show Cars";
            this.showCarsButton.UseVisualStyleBackColor = false;
            this.showCarsButton.Click += new System.EventHandler(this.showCarsButton_Click);
            // 
            // carsTable
            // 
            this.carsTable.BackgroundColor = System.Drawing.Color.White;
            this.carsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsTable.Location = new System.Drawing.Point(20, 162);
            this.carsTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carsTable.Name = "carsTable";
            this.carsTable.RowHeadersWidth = 51;
            this.carsTable.Size = new System.Drawing.Size(1092, 422);
            this.carsTable.TabIndex = 2;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(20, 49);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(197, 106);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_label.Location = new System.Drawing.Point(19, 6);
            this.cars_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(189, 41);
            this.cars_label.TabIndex = 6;
            this.cars_label.Text = "car$.com";
            // 
            // selectBrandLabel
            // 
            this.selectBrandLabel.AutoSize = true;
            this.selectBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBrandLabel.Location = new System.Drawing.Point(360, 63);
            this.selectBrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectBrandLabel.Name = "selectBrandLabel";
            this.selectBrandLabel.Size = new System.Drawing.Size(122, 24);
            this.selectBrandLabel.TabIndex = 8;
            this.selectBrandLabel.Text = "Select Brand:";
            // 
            // selectModelLabel
            // 
            this.selectModelLabel.AutoSize = true;
            this.selectModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectModelLabel.Location = new System.Drawing.Point(547, 63);
            this.selectModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectModelLabel.Name = "selectModelLabel";
            this.selectModelLabel.Size = new System.Drawing.Size(125, 24);
            this.selectModelLabel.TabIndex = 8;
            this.selectModelLabel.Text = "Select Model:";
            // 
            // logout_panel_button
            // 
            this.logout_panel_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.logout_panel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_panel_button.Location = new System.Drawing.Point(1037, 6);
            this.logout_panel_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_panel_button.Name = "logout_panel_button";
            this.logout_panel_button.Size = new System.Drawing.Size(75, 62);
            this.logout_panel_button.TabIndex = 18;
            this.logout_panel_button.Text = "Log Out";
            this.logout_panel_button.UseVisualStyleBackColor = false;
            this.logout_panel_button.Click += new System.EventHandler(this.logout_panel_button_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1132, 599);
            this.Controls.Add(this.logout_panel_button);
            this.Controls.Add(this.selectModelLabel);
            this.Controls.Add(this.selectBrandLabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.cars_label);
            this.Controls.Add(this.carsTable);
            this.Controls.Add(this.showCarsButton);
            this.Controls.Add(this.modelCombobox);
            this.Controls.Add(this.makeCombobox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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