namespace CarsDealer
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
            this.carscomLabel = new System.Windows.Forms.Label();
            this.selectBrandLabel = new System.Windows.Forms.Label();
            this.selectModelLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
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
            this.carsTable.RowHeadersWidth = 51;
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
            // 
            // carscomLabel
            // 
            this.carscomLabel.AutoSize = true;
            this.carscomLabel.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carscomLabel.Location = new System.Drawing.Point(-2, 5);
            this.carscomLabel.Name = "carscomLabel";
            this.carscomLabel.Size = new System.Drawing.Size(186, 32);
            this.carscomLabel.TabIndex = 6;
            this.carscomLabel.Text = "Car$Dealer";
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
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(778, 5);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(56, 50);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(849, 487);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.selectModelLabel);
            this.Controls.Add(this.selectBrandLabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.carscomLabel);
            this.Controls.Add(this.carsTable);
            this.Controls.Add(this.showCarsButton);
            this.Controls.Add(this.modelCombobox);
            this.Controls.Add(this.makeCombobox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car$Dealer";
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
        private System.Windows.Forms.Label carscomLabel;
        private System.Windows.Forms.Label selectBrandLabel;
        private System.Windows.Forms.Label selectModelLabel;
        private System.Windows.Forms.Button logoutButton;
    }
}