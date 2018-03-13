namespace Communalnie
{
    partial class ServiceManagement
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tariffSelectButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.tariffRadioButton = new System.Windows.Forms.RadioButton();
            this.meterRadioButton = new System.Windows.Forms.RadioButton();
            this.serviceTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.servicesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Стоимость за ед.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ед. измерения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Тарификация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Услуга";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Список услуг";
            // 
            // tariffSelectButton
            // 
            this.tariffSelectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tariffSelectButton.FlatAppearance.BorderSize = 0;
            this.tariffSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tariffSelectButton.Location = new System.Drawing.Point(384, 117);
            this.tariffSelectButton.Name = "tariffSelectButton";
            this.tariffSelectButton.Size = new System.Drawing.Size(126, 20);
            this.tariffSelectButton.TabIndex = 48;
            this.tariffSelectButton.Text = "выбор тарифа";
            this.tariffSelectButton.UseVisualStyleBackColor = false;
            this.tariffSelectButton.Click += new System.EventHandler(this.tariffSelectButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(296, 117);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(81, 20);
            this.priceTextBox.TabIndex = 47;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(280, 181);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 31);
            this.saveButton.TabIndex = 46;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(398, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 31);
            this.cancelButton.TabIndex = 45;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // unitComboBox
            // 
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "кВт*ч",
            "м2",
            "м3"});
            this.unitComboBox.Location = new System.Drawing.Point(297, 90);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(213, 21);
            this.unitComboBox.TabIndex = 44;
            this.unitComboBox.SelectionChangeCommitted += new System.EventHandler(this.unitComboBox_SelectionChangeCommitted);
            // 
            // tariffRadioButton
            // 
            this.tariffRadioButton.AutoSize = true;
            this.tariffRadioButton.Location = new System.Drawing.Point(384, 66);
            this.tariffRadioButton.Name = "tariffRadioButton";
            this.tariffRadioButton.Size = new System.Drawing.Size(56, 17);
            this.tariffRadioButton.TabIndex = 43;
            this.tariffRadioButton.TabStop = true;
            this.tariffRadioButton.Text = "тариф";
            this.tariffRadioButton.UseVisualStyleBackColor = true;
            this.tariffRadioButton.Click += new System.EventHandler(this.tariffRadioButton_Click);
            // 
            // meterRadioButton
            // 
            this.meterRadioButton.AutoSize = true;
            this.meterRadioButton.Location = new System.Drawing.Point(296, 66);
            this.meterRadioButton.Name = "meterRadioButton";
            this.meterRadioButton.Size = new System.Drawing.Size(64, 17);
            this.meterRadioButton.TabIndex = 42;
            this.meterRadioButton.Text = "счётчик";
            this.meterRadioButton.UseVisualStyleBackColor = true;
            this.meterRadioButton.Click += new System.EventHandler(this.meterRadioButton_Click);
            // 
            // serviceTextBox
            // 
            this.serviceTextBox.Location = new System.Drawing.Point(296, 40);
            this.serviceTextBox.Name = "serviceTextBox";
            this.serviceTextBox.Size = new System.Drawing.Size(214, 20);
            this.serviceTextBox.TabIndex = 41;
            this.serviceTextBox.TextChanged += new System.EventHandler(this.serviceTextBox_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(106, 181);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 31);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(12, 181);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 31);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // servicesListBox
            // 
            this.servicesListBox.FormattingEnabled = true;
            this.servicesListBox.Location = new System.Drawing.Point(12, 40);
            this.servicesListBox.Name = "servicesListBox";
            this.servicesListBox.Size = new System.Drawing.Size(182, 134);
            this.servicesListBox.TabIndex = 38;
            this.servicesListBox.SelectedIndexChanged += new System.EventHandler(this.servicesListBox_SelectedIndexChanged);
            // 
            // ServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 228);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tariffSelectButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.tariffRadioButton);
            this.Controls.Add(this.meterRadioButton);
            this.Controls.Add(this.serviceTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.servicesListBox);
            this.Name = "ServiceManagement";
            this.Text = "ServiceManagement";
            this.Load += new System.EventHandler(this.ServiceManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tariffSelectButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.RadioButton tariffRadioButton;
        private System.Windows.Forms.RadioButton meterRadioButton;
        private System.Windows.Forms.TextBox serviceTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox servicesListBox;
    }
}