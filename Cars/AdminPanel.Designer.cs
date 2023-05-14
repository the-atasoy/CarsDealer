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
            this.cars_label = new System.Windows.Forms.Label();
            this.selectModelLabel = new System.Windows.Forms.Label();
            this.selectBrandLabel = new System.Windows.Forms.Label();
            this.carsTable = new System.Windows.Forms.DataGridView();
            this.showCarsButton = new System.Windows.Forms.Button();
            this.modelCombobox = new System.Windows.Forms.ComboBox();
            this.makeCombobox = new System.Windows.Forms.ComboBox();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Font = new System.Drawing.Font("Magneto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_label.Location = new System.Drawing.Point(233, 56);
            this.cars_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(189, 41);
            this.cars_label.TabIndex = 6;
            this.cars_label.Text = "car$.com";
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
            this.carsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsTable_CellContentClick);
            // 
            // showCarsButton
            // 
            this.showCarsButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.showCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCarsButton.Location = new System.Drawing.Point(404, 339);
            this.showCarsButton.Margin = new System.Windows.Forms.Padding(4);
            this.showCarsButton.Name = "showCarsButton";
            this.showCarsButton.Size = new System.Drawing.Size(127, 57);
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
            this.modelCombobox.SelectedIndexChanged += new System.EventHandler(this.modelCombobox_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Users";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1131, 602);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.selectModelLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectBrandLabel);
            this.Controls.Add(this.carsTable);
            this.Controls.Add(this.showCarsButton);
            this.Controls.Add(this.modelCombobox);
            this.Controls.Add(this.makeCombobox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.cars_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label cars_label;
        private System.Windows.Forms.Label selectModelLabel;
        private System.Windows.Forms.Label selectBrandLabel;
        private System.Windows.Forms.DataGridView carsTable;
        private System.Windows.Forms.Button showCarsButton;
        private System.Windows.Forms.ComboBox modelCombobox;
        private System.Windows.Forms.ComboBox makeCombobox;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.Label label1;
    }
}