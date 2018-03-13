namespace Communalnie
{
    partial class HousesManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.privateHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.apartmentHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.numberOfPeoplesTextBox = new System.Windows.Forms.TextBox();
            this.totalAreaTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.housesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Список объектов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Количество зарегестрированных граждан";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Общая площадь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Описание";
            // 
            // privateHouseRadioButton
            // 
            this.privateHouseRadioButton.AutoSize = true;
            this.privateHouseRadioButton.Location = new System.Drawing.Point(349, 142);
            this.privateHouseRadioButton.Name = "privateHouseRadioButton";
            this.privateHouseRadioButton.Size = new System.Drawing.Size(90, 17);
            this.privateHouseRadioButton.TabIndex = 67;
            this.privateHouseRadioButton.TabStop = true;
            this.privateHouseRadioButton.Text = "частный дом";
            this.privateHouseRadioButton.UseVisualStyleBackColor = true;
            this.privateHouseRadioButton.Click += new System.EventHandler(this.privateHouseRadioButton_Click);
            // 
            // apartmentHouseRadioButton
            // 
            this.apartmentHouseRadioButton.AutoSize = true;
            this.apartmentHouseRadioButton.Location = new System.Drawing.Point(203, 143);
            this.apartmentHouseRadioButton.Name = "apartmentHouseRadioButton";
            this.apartmentHouseRadioButton.Size = new System.Drawing.Size(140, 17);
            this.apartmentHouseRadioButton.TabIndex = 66;
            this.apartmentHouseRadioButton.TabStop = true;
            this.apartmentHouseRadioButton.Text = "многоквартирный дом";
            this.apartmentHouseRadioButton.UseVisualStyleBackColor = true;
            this.apartmentHouseRadioButton.Click += new System.EventHandler(this.apartmentHouseRadioButton_Click);
            // 
            // numberOfPeoplesTextBox
            // 
            this.numberOfPeoplesTextBox.Location = new System.Drawing.Point(430, 116);
            this.numberOfPeoplesTextBox.Name = "numberOfPeoplesTextBox";
            this.numberOfPeoplesTextBox.Size = new System.Drawing.Size(103, 20);
            this.numberOfPeoplesTextBox.TabIndex = 65;
            this.numberOfPeoplesTextBox.TextChanged += new System.EventHandler(this.numberOfPeoplesTextBox_TextChanged);
            // 
            // totalAreaTextBox
            // 
            this.totalAreaTextBox.Location = new System.Drawing.Point(315, 90);
            this.totalAreaTextBox.Name = "totalAreaTextBox";
            this.totalAreaTextBox.Size = new System.Drawing.Size(218, 20);
            this.totalAreaTextBox.TabIndex = 64;
            this.totalAreaTextBox.TextChanged += new System.EventHandler(this.totalAreaTextBox_TextChanged);
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(315, 64);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(218, 20);
            this.adressTextBox.TabIndex = 63;
            this.adressTextBox.TextChanged += new System.EventHandler(this.adressTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(312, 166);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 31);
            this.saveButton.TabIndex = 62;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(430, 166);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 31);
            this.cancelButton.TabIndex = 61;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(315, 38);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(218, 20);
            this.descriptionTextBox.TabIndex = 60;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(108, 166);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 31);
            this.deleteButton.TabIndex = 59;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(15, 166);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 31);
            this.addButton.TabIndex = 58;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // housesListBox
            // 
            this.housesListBox.FormattingEnabled = true;
            this.housesListBox.Location = new System.Drawing.Point(15, 38);
            this.housesListBox.Name = "housesListBox";
            this.housesListBox.Size = new System.Drawing.Size(182, 121);
            this.housesListBox.TabIndex = 57;
            this.housesListBox.SelectedIndexChanged += new System.EventHandler(this.housesListBox_SelectedIndexChanged);
            // 
            // HousesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.privateHouseRadioButton);
            this.Controls.Add(this.apartmentHouseRadioButton);
            this.Controls.Add(this.numberOfPeoplesTextBox);
            this.Controls.Add(this.totalAreaTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.housesListBox);
            this.Name = "HousesManagement";
            this.Text = "HousesManagement";
            this.Load += new System.EventHandler(this.HousesManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton privateHouseRadioButton;
        private System.Windows.Forms.RadioButton apartmentHouseRadioButton;
        private System.Windows.Forms.TextBox numberOfPeoplesTextBox;
        private System.Windows.Forms.TextBox totalAreaTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox housesListBox;
    }
}