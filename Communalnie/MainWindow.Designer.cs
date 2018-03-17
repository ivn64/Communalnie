namespace Communalnie
{
    partial class MainWindow
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
            this.housesComboBox = new System.Windows.Forms.ComboBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.housesButton = new System.Windows.Forms.Button();
            this.graphButton = new System.Windows.Forms.Button();
            this.servicesButton = new System.Windows.Forms.Button();
            this.communalnieDataGridView = new System.Windows.Forms.DataGridView();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.editButton = new System.Windows.Forms.Button();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accruals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.communalnieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // housesComboBox
            // 
            this.housesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.housesComboBox.FormattingEnabled = true;
            this.housesComboBox.Location = new System.Drawing.Point(108, 14);
            this.housesComboBox.Name = "housesComboBox";
            this.housesComboBox.Size = new System.Drawing.Size(141, 21);
            this.housesComboBox.TabIndex = 20;
            this.housesComboBox.SelectedIndexChanged += new System.EventHandler(this.housesComboBox_SelectedIndexChanged);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Location = new System.Drawing.Point(255, 12);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(91, 54);
            this.exportButton.TabIndex = 19;
            this.exportButton.Text = "Экспорт в excel";
            this.exportButton.UseVisualStyleBackColor = false;
            // 
            // housesButton
            // 
            this.housesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.housesButton.FlatAppearance.BorderSize = 0;
            this.housesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.housesButton.Location = new System.Drawing.Point(108, 41);
            this.housesButton.Name = "housesButton";
            this.housesButton.Size = new System.Drawing.Size(141, 25);
            this.housesButton.TabIndex = 18;
            this.housesButton.Text = "Управление объектами";
            this.housesButton.UseVisualStyleBackColor = false;
            this.housesButton.Click += new System.EventHandler(this.housesButton_Click);
            // 
            // graphButton
            // 
            this.graphButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.graphButton.FlatAppearance.BorderSize = 0;
            this.graphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton.Location = new System.Drawing.Point(352, 12);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(91, 54);
            this.graphButton.TabIndex = 17;
            this.graphButton.Text = "График";
            this.graphButton.UseVisualStyleBackColor = false;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.servicesButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.servicesButton.FlatAppearance.BorderSize = 0;
            this.servicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.servicesButton.Location = new System.Drawing.Point(11, 12);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(91, 54);
            this.servicesButton.TabIndex = 16;
            this.servicesButton.Text = "Управление услугами";
            this.servicesButton.UseVisualStyleBackColor = false;
            this.servicesButton.Click += new System.EventHandler(this.servicesButton_Click);
            // 
            // communalnieDataGridView
            // 
            this.communalnieDataGridView.AllowUserToAddRows = false;
            this.communalnieDataGridView.AllowUserToDeleteRows = false;
            this.communalnieDataGridView.AllowUserToResizeColumns = false;
            this.communalnieDataGridView.AllowUserToResizeRows = false;
            this.communalnieDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.communalnieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.communalnieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.communalnieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.Indications,
            this.Units,
            this.Cost,
            this.Accruals});
            this.communalnieDataGridView.Location = new System.Drawing.Point(11, 100);
            this.communalnieDataGridView.Name = "communalnieDataGridView";
            this.communalnieDataGridView.ReadOnly = true;
            this.communalnieDataGridView.RowHeadersVisible = false;
            this.communalnieDataGridView.Size = new System.Drawing.Size(432, 199);
            this.communalnieDataGridView.TabIndex = 21;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.Enabled = false;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(11, 73);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(91, 21);
            this.yearComboBox.TabIndex = 22;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.Enabled = false;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(108, 73);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(141, 21);
            this.monthComboBox.TabIndex = 23;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(338, 305);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(105, 25);
            this.editButton.TabIndex = 24;
            this.editButton.Text = "Редактирование";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // Service
            // 
            this.Service.HeaderText = "Услуга";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            this.Service.Width = 143;
            // 
            // Indications
            // 
            this.Indications.HeaderText = "Показания";
            this.Indications.Name = "Indications";
            this.Indications.ReadOnly = true;
            this.Indications.Width = 72;
            // 
            // Units
            // 
            this.Units.HeaderText = "Ед. изм.";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            this.Units.Width = 72;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 72;
            // 
            // Accruals
            // 
            this.Accruals.HeaderText = "Начисления";
            this.Accruals.Name = "Accruals";
            this.Accruals.ReadOnly = true;
            this.Accruals.Width = 72;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 339);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.communalnieDataGridView);
            this.Controls.Add(this.housesComboBox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.housesButton);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.servicesButton);
            this.Name = "MainWindow";
            this.Text = "Коммуналка";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.communalnieDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox housesComboBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button housesButton;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Button servicesButton;
        private System.Windows.Forms.DataGridView communalnieDataGridView;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accruals;
    }
}

