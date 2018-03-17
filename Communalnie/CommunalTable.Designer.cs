namespace Communalnie
{
    partial class CommunalTable
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
            this.communalnieDataGridView = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accruals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.entityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.removeDateButton = new System.Windows.Forms.Button();
            this.addDateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.communalnieDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.Cost,
            this.Accruals});
            this.communalnieDataGridView.Location = new System.Drawing.Point(12, 52);
            this.communalnieDataGridView.Name = "communalnieDataGridView";
            this.communalnieDataGridView.ReadOnly = true;
            this.communalnieDataGridView.RowHeadersVisible = false;
            this.communalnieDataGridView.Size = new System.Drawing.Size(432, 229);
            this.communalnieDataGridView.TabIndex = 22;
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
            this.Indications.Width = 96;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 96;
            // 
            // Accruals
            // 
            this.Accruals.HeaderText = "Начисления";
            this.Accruals.Name = "Accruals";
            this.Accruals.ReadOnly = true;
            this.Accruals.Width = 96;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(214, 296);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 31);
            this.saveButton.TabIndex = 66;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(332, 296);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 31);
            this.cancelButton.TabIndex = 65;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(105, 296);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 31);
            this.deleteButton.TabIndex = 64;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(12, 296);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 31);
            this.addButton.TabIndex = 63;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // entityLabel
            // 
            this.entityLabel.AutoSize = true;
            this.entityLabel.Location = new System.Drawing.Point(12, 9);
            this.entityLabel.Name = "entityLabel";
            this.entityLabel.Size = new System.Drawing.Size(45, 13);
            this.entityLabel.TabIndex = 67;
            this.entityLabel.Text = "Объект";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 28);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 70;
            this.dateLabel.Text = "Дата";
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.Enabled = false;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(148, 25);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(141, 21);
            this.monthComboBox.TabIndex = 74;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.Enabled = false;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(51, 25);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(91, 21);
            this.yearComboBox.TabIndex = 73;
            // 
            // removeDateButton
            // 
            this.removeDateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removeDateButton.FlatAppearance.BorderSize = 0;
            this.removeDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDateButton.Location = new System.Drawing.Point(322, 25);
            this.removeDateButton.Name = "removeDateButton";
            this.removeDateButton.Size = new System.Drawing.Size(21, 21);
            this.removeDateButton.TabIndex = 76;
            this.removeDateButton.Text = "-";
            this.removeDateButton.UseVisualStyleBackColor = false;
            // 
            // addDateButton
            // 
            this.addDateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addDateButton.FlatAppearance.BorderSize = 0;
            this.addDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDateButton.Location = new System.Drawing.Point(295, 25);
            this.addDateButton.Name = "addDateButton";
            this.addDateButton.Size = new System.Drawing.Size(21, 21);
            this.addDateButton.TabIndex = 75;
            this.addDateButton.Text = "+";
            this.addDateButton.UseVisualStyleBackColor = false;
            this.addDateButton.Click += new System.EventHandler(this.addDateButton_Click);
            // 
            // CommunalTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 339);
            this.Controls.Add(this.removeDateButton);
            this.Controls.Add(this.addDateButton);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.entityLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.communalnieDataGridView);
            this.Name = "CommunalTable";
            this.Text = "Редактор услуг";
            this.Load += new System.EventHandler(this.CommunalTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.communalnieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView communalnieDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label entityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accruals;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Button removeDateButton;
        private System.Windows.Forms.Button addDateButton;
    }
}