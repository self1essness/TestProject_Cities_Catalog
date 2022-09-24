namespace TestProject_Cities_Catalog
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DistrictListBox = new System.Windows.Forms.ListBox();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.RegionListBox = new System.Windows.Forms.ListBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityListBox = new System.Windows.Forms.ListBox();
            this.DictrictTextBox = new System.Windows.Forms.TextBox();
            this.RegionTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.AddDistrict = new System.Windows.Forms.Button();
            this.DeleteDistrict = new System.Windows.Forms.Button();
            this.DeleteRegion = new System.Windows.Forms.Button();
            this.AddRegion = new System.Windows.Forms.Button();
            this.DeleteCity = new System.Windows.Forms.Button();
            this.AddCity = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DistrictListBox
            // 
            this.DistrictListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistrictListBox.FormattingEnabled = true;
            this.DistrictListBox.ItemHeight = 16;
            this.DistrictListBox.Items.AddRange(new object[] {
            "123",
            "321",
            "222"});
            this.DistrictListBox.Location = new System.Drawing.Point(50, 50);
            this.DistrictListBox.Name = "DistrictListBox";
            this.DistrictListBox.Size = new System.Drawing.Size(180, 292);
            this.DistrictListBox.TabIndex = 0;
            this.DistrictListBox.SelectedIndexChanged += new System.EventHandler(this.DistrictListBox_SelectedIndexChanged);
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Location = new System.Drawing.Point(118, 26);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(46, 16);
            this.DistrictLabel.TabIndex = 1;
            this.DistrictLabel.Text = "Округ";
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Location = new System.Drawing.Point(315, 26);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(54, 16);
            this.RegionLabel.TabIndex = 3;
            this.RegionLabel.Text = "Регион";
            // 
            // RegionListBox
            // 
            this.RegionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionListBox.FormattingEnabled = true;
            this.RegionListBox.ItemHeight = 16;
            this.RegionListBox.Items.AddRange(new object[] {
            "123",
            "123",
            "123"});
            this.RegionListBox.Location = new System.Drawing.Point(250, 50);
            this.RegionListBox.Name = "RegionListBox";
            this.RegionListBox.Size = new System.Drawing.Size(180, 292);
            this.RegionListBox.TabIndex = 2;
            this.RegionListBox.SelectedIndexChanged += new System.EventHandler(this.RegionListBox_SelectedIndexChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(516, 26);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(46, 16);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "Город";
            // 
            // CityListBox
            // 
            this.CityListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityListBox.FormattingEnabled = true;
            this.CityListBox.ItemHeight = 16;
            this.CityListBox.Items.AddRange(new object[] {
            "123",
            "123",
            "123"});
            this.CityListBox.Location = new System.Drawing.Point(450, 50);
            this.CityListBox.Name = "CityListBox";
            this.CityListBox.Size = new System.Drawing.Size(180, 292);
            this.CityListBox.TabIndex = 4;
            this.CityListBox.SelectedIndexChanged += new System.EventHandler(this.CityListBox_SelectedIndexChanged);
            // 
            // DictrictTextBox
            // 
            this.DictrictTextBox.Location = new System.Drawing.Point(50, 374);
            this.DictrictTextBox.Name = "DictrictTextBox";
            this.DictrictTextBox.Size = new System.Drawing.Size(180, 22);
            this.DictrictTextBox.TabIndex = 6;
            this.DictrictTextBox.Enter += new System.EventHandler(this.DictrictTextBox_Enter);
            this.DictrictTextBox.Leave += new System.EventHandler(this.DictrictTextBox_Leave);
            // 
            // RegionTextBox
            // 
            this.RegionTextBox.Location = new System.Drawing.Point(250, 374);
            this.RegionTextBox.Name = "RegionTextBox";
            this.RegionTextBox.Size = new System.Drawing.Size(180, 22);
            this.RegionTextBox.TabIndex = 7;
            this.RegionTextBox.Enter += new System.EventHandler(this.RegionTextBox_Enter);
            this.RegionTextBox.Leave += new System.EventHandler(this.RegionTextBox_Leave);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(450, 374);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(180, 22);
            this.CityTextBox.TabIndex = 8;
            this.CityTextBox.Enter += new System.EventHandler(this.CityTextBox_Enter);
            this.CityTextBox.Leave += new System.EventHandler(this.CityTextBox_Leave);
            // 
            // AddDistrict
            // 
            this.AddDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDistrict.Location = new System.Drawing.Point(50, 402);
            this.AddDistrict.Name = "AddDistrict";
            this.AddDistrict.Size = new System.Drawing.Size(90, 30);
            this.AddDistrict.TabIndex = 9;
            this.AddDistrict.Text = "Добавить";
            this.AddDistrict.UseVisualStyleBackColor = true;
            this.AddDistrict.Click += new System.EventHandler(this.AddDistrict_Click);
            // 
            // DeleteDistrict
            // 
            this.DeleteDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteDistrict.Location = new System.Drawing.Point(140, 402);
            this.DeleteDistrict.Name = "DeleteDistrict";
            this.DeleteDistrict.Size = new System.Drawing.Size(90, 30);
            this.DeleteDistrict.TabIndex = 10;
            this.DeleteDistrict.Text = "Удалить";
            this.DeleteDistrict.UseVisualStyleBackColor = true;
            this.DeleteDistrict.Click += new System.EventHandler(this.DeleteDistrict_Click);
            // 
            // DeleteRegion
            // 
            this.DeleteRegion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRegion.Location = new System.Drawing.Point(340, 402);
            this.DeleteRegion.Name = "DeleteRegion";
            this.DeleteRegion.Size = new System.Drawing.Size(90, 30);
            this.DeleteRegion.TabIndex = 12;
            this.DeleteRegion.Text = "Удалить";
            this.DeleteRegion.UseVisualStyleBackColor = true;
            this.DeleteRegion.Click += new System.EventHandler(this.DeleteRegion_Click);
            // 
            // AddRegion
            // 
            this.AddRegion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRegion.Location = new System.Drawing.Point(250, 402);
            this.AddRegion.Name = "AddRegion";
            this.AddRegion.Size = new System.Drawing.Size(90, 30);
            this.AddRegion.TabIndex = 11;
            this.AddRegion.Text = "Добавить";
            this.AddRegion.UseVisualStyleBackColor = true;
            this.AddRegion.Click += new System.EventHandler(this.AddRegion_Click);
            // 
            // DeleteCity
            // 
            this.DeleteCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteCity.Location = new System.Drawing.Point(540, 402);
            this.DeleteCity.Name = "DeleteCity";
            this.DeleteCity.Size = new System.Drawing.Size(90, 30);
            this.DeleteCity.TabIndex = 14;
            this.DeleteCity.Text = "Удалить";
            this.DeleteCity.UseVisualStyleBackColor = true;
            this.DeleteCity.Click += new System.EventHandler(this.DeleteCity_Click);
            // 
            // AddCity
            // 
            this.AddCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCity.Location = new System.Drawing.Point(450, 402);
            this.AddCity.Name = "AddCity";
            this.AddCity.Size = new System.Drawing.Size(90, 30);
            this.AddCity.TabIndex = 13;
            this.AddCity.Text = "Добавить";
            this.AddCity.UseVisualStyleBackColor = true;
            this.AddCity.Click += new System.EventHandler(this.AddCity_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CityLabel);
            this.panel1.Controls.Add(this.CityTextBox);
            this.panel1.Controls.Add(this.AddDistrict);
            this.panel1.Controls.Add(this.RegionTextBox);
            this.panel1.Controls.Add(this.DictrictTextBox);
            this.panel1.Controls.Add(this.DeleteCity);
            this.panel1.Controls.Add(this.DeleteDistrict);
            this.panel1.Controls.Add(this.AddCity);
            this.panel1.Controls.Add(this.AddRegion);
            this.panel1.Controls.Add(this.DeleteRegion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 453);
            this.panel1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.CityListBox);
            this.Controls.Add(this.RegionLabel);
            this.Controls.Add(this.RegionListBox);
            this.Controls.Add(this.DistrictLabel);
            this.Controls.Add(this.DistrictListBox);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Справочник городов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DistrictListBox;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.ListBox RegionListBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.ListBox CityListBox;
        private System.Windows.Forms.TextBox DictrictTextBox;
        private System.Windows.Forms.TextBox RegionTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button AddDistrict;
        private System.Windows.Forms.Button DeleteDistrict;
        private System.Windows.Forms.Button DeleteRegion;
        private System.Windows.Forms.Button AddRegion;
        private System.Windows.Forms.Button DeleteCity;
        private System.Windows.Forms.Button AddCity;
        private System.Windows.Forms.Panel panel1;
    }
}

