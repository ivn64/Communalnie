namespace Communalnie
{
    partial class ProfitForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accrualsTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.indicationsTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.servicesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Начисления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Показания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Услуга";
            // 
            // accrualsTextBox
            // 
            this.accrualsTextBox.Location = new System.Drawing.Point(180, 86);
            this.accrualsTextBox.Name = "accrualsTextBox";
            this.accrualsTextBox.ReadOnly = true;
            this.accrualsTextBox.Size = new System.Drawing.Size(214, 20);
            this.accrualsTextBox.TabIndex = 98;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(180, 58);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(214, 20);
            this.costTextBox.TabIndex = 99;
            // 
            // indicationsTextBox
            // 
            this.indicationsTextBox.Location = new System.Drawing.Point(180, 32);
            this.indicationsTextBox.Name = "indicationsTextBox";
            this.indicationsTextBox.Size = new System.Drawing.Size(214, 20);
            this.indicationsTextBox.TabIndex = 100;
            this.indicationsTextBox.TextChanged += new System.EventHandler(this.indicationsTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(305, 112);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(89, 31);
            this.okButton.TabIndex = 102;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // servicesComboBox
            // 
            this.servicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicesComboBox.FormattingEnabled = true;
            this.servicesComboBox.Location = new System.Drawing.Point(180, 6);
            this.servicesComboBox.Name = "servicesComboBox";
            this.servicesComboBox.Size = new System.Drawing.Size(214, 21);
            this.servicesComboBox.TabIndex = 103;
            this.servicesComboBox.SelectedIndexChanged += new System.EventHandler(this.servicesComboBox_SelectedIndexChanged);
            // 
            // ProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 153);
            this.Controls.Add(this.servicesComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.indicationsTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.accrualsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProfitForm";
            this.Text = "Добавление начисления";
            this.Load += new System.EventHandler(this.ProfitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accrualsTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox indicationsTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox servicesComboBox;
    }
}