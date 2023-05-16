namespace Cars
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.logo = new System.Windows.Forms.PictureBox();
            this.carscomLabel = new System.Windows.Forms.Label();
            this.selectModelLabel = new System.Windows.Forms.Label();
            this.selectBrandLabel = new System.Windows.Forms.Label();
            this.carsTable = new System.Windows.Forms.DataGridView();
            this.showCarsButton = new System.Windows.Forms.Button();
            this.modelCombobox = new System.Windows.Forms.ComboBox();
            this.makeCombobox = new System.Windows.Forms.ComboBox();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.usersLabel = new System.Windows.Forms.Label();
            this.addCarButton = new System.Windows.Forms.Button();
            this.addAdminButton = new System.Windows.Forms.Button();
            this.deleteCarButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(13, 14);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(202, 133);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // carscomLabel
            // 
            this.carscomLabel.AutoSize = true;
            this.carscomLabel.Font = new System.Drawing.Font("Magneto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carscomLabel.Location = new System.Drawing.Point(233, 56);
            this.carscomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carscomLabel.Name = "carscomLabel";
            this.carscomLabel.Size = new System.Drawing.Size(185, 41);
            this.carscomLabel.TabIndex = 6;
            this.carscomLabel.Text = "car$.com";
            // 
            // selectModelLabel
            // 
            this.selectModelLabel.AutoSize = true;
            this.selectModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectModelLabel.Location = new System.Drawing.Point(222, 339);
            this.selectModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectModelLabel.Name = "selectModelLabel";
            this.selectModelLabel.Size = new System.Drawing.Size(125, 24);
            this.selectModelLabel.TabIndex = 13;
            this.selectModelLabel.Text = "Select Model:";
            // 
            // selectBrandLabel
            // 
            this.selectBrandLabel.AutoSize = true;
            this.selectBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBrandLabel.Location = new System.Drawing.Point(35, 339);
            this.selectBrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectBrandLabel.Name = "selectBrandLabel";
            this.selectBrandLabel.Size = new System.Drawing.Size(122, 24);
            this.selectBrandLabel.TabIndex = 14;
            this.selectBrandLabel.Text = "Select Brand:";
            // 
            // carsTable
            // 
            this.carsTable.BackgroundColor = System.Drawing.Color.White;
            this.carsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsTable.Location = new System.Drawing.Point(19, 410);
            this.carsTable.Margin = new System.Windows.Forms.Padding(4);
            this.carsTable.Name = "carsTable";
            this.carsTable.RowHeadersWidth = 51;
            this.carsTable.Size = new System.Drawing.Size(1092, 152);
            this.carsTable.TabIndex = 12;
            // 
            // showCarsButton
            // 
            this.showCarsButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.showCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCarsButton.Location = new System.Drawing.Point(404, 339);
            this.showCarsButton.Margin = new System.Windows.Forms.Padding(4);
            this.showCarsButton.Name = "showCarsButton";
            this.showCarsButton.Size = new System.Drawing.Size(152, 57);
            this.showCarsButton.TabIndex = 11;
            this.showCarsButton.Text = "Show Cars";
            this.showCarsButton.UseVisualStyleBackColor = false;
            this.showCarsButton.Click += new System.EventHandler(this.showCarsButton_Click);
            // 
            // modelCombobox
            // 
            this.modelCombobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.modelCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelCombobox.FormattingEnabled = true;
            this.modelCombobox.Location = new System.Drawing.Point(204, 365);
            this.modelCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.modelCombobox.Name = "modelCombobox";
            this.modelCombobox.Size = new System.Drawing.Size(160, 24);
            this.modelCombobox.TabIndex = 9;
            // 
            // makeCombobox
            // 
            this.makeCombobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.makeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makeCombobox.FormattingEnabled = true;
            this.makeCombobox.Location = new System.Drawing.Point(18, 365);
            this.makeCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.makeCombobox.Name = "makeCombobox";
            this.makeCombobox.Size = new System.Drawing.Size(160, 24);
            this.makeCombobox.TabIndex = 10;
            this.makeCombobox.SelectedIndexChanged += new System.EventHandler(this.makeCombobox_SelectedIndexChanged);
            // 
            // userTable
            // 
            this.userTable.BackgroundColor = System.Drawing.Color.White;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Location = new System.Drawing.Point(19, 154);
            this.userTable.Name = "userTable";
            this.userTable.RowHeadersWidth = 51;
            this.userTable.RowTemplate.Height = 24;
            this.userTable.Size = new System.Drawing.Size(1092, 150);
            this.userTable.TabIndex = 15;
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLabel.Location = new System.Drawing.Point(539, 114);
            this.usersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(57, 22);
            this.usersLabel.TabIndex = 14;
            this.usersLabel.Text = "Users";
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.Location = new System.Drawing.Point(566, 339);
            this.addCarButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(152, 57);
            this.addCarButton.TabIndex = 11;
            this.addCarButton.Text = "Add New Car";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // addAdminButton
            // 
            this.addAdminButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminButton.Location = new System.Drawing.Point(786, 79);
            this.addAdminButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAdminButton.Name = "addAdminButton";
            this.addAdminButton.Size = new System.Drawing.Size(161, 57);
            this.addAdminButton.TabIndex = 11;
            this.addAdminButton.Text = "Add New Admin";
            this.addAdminButton.UseVisualStyleBackColor = false;
            this.addAdminButton.Click += new System.EventHandler(this.addAdminButton_Click);
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.deleteCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCarButton.Location = new System.Drawing.Point(730, 339);
            this.deleteCarButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(152, 57);
            this.deleteCarButton.TabIndex = 11;
            this.deleteCarButton.Text = "Delete Car";
            this.deleteCarButton.UseVisualStyleBackColor = false;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.Location = new System.Drawing.Point(959, 79);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(152, 57);
            this.deleteUserButton.TabIndex = 11;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(910, 11);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(101, 33);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1018, 11);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(101, 33);
            this.logoutButton.TabIndex = 19;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1131, 602);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.selectModelLabel);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.selectBrandLabel);
            this.Controls.Add(this.carsTable);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addAdminButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.showCarsButton);
            this.Controls.Add(this.modelCombobox);
            this.Controls.Add(this.makeCombobox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.carscomLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "car$.com";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label carscomLabel;
        private System.Windows.Forms.Label selectModelLabel;
        private System.Windows.Forms.Label selectBrandLabel;
        private System.Windows.Forms.DataGridView carsTable;
        private System.Windows.Forms.Button showCarsButton;
        private System.Windows.Forms.ComboBox modelCombobox;
        private System.Windows.Forms.ComboBox makeCombobox;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button addAdminButton;
        private System.Windows.Forms.Button deleteCarButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button logoutButton;
    }
}