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
            this.SuspendLayout();
            // 
            // housesComboBox
            // 
            this.housesComboBox.FormattingEnabled = true;
            this.housesComboBox.Location = new System.Drawing.Point(108, 14);
            this.housesComboBox.Name = "housesComboBox";
            this.housesComboBox.Size = new System.Drawing.Size(141, 21);
            this.housesComboBox.TabIndex = 20;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 311);
            this.Controls.Add(this.housesComboBox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.housesButton);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.servicesButton);
            this.Name = "MainWindow";
            this.Text = "Коммуналка";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox housesComboBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button housesButton;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Button servicesButton;
    }
}

