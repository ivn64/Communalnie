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
            this.accruals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
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
            this.accruals});
            this.communalnieDataGridView.Location = new System.Drawing.Point(12, 12);
            this.communalnieDataGridView.Name = "communalnieDataGridView";
            this.communalnieDataGridView.ReadOnly = true;
            this.communalnieDataGridView.RowHeadersVisible = false;
            this.communalnieDataGridView.Size = new System.Drawing.Size(432, 269);
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
            // accruals
            // 
            this.accruals.HeaderText = "Начисления";
            this.accruals.Name = "accruals";
            this.accruals.ReadOnly = true;
            this.accruals.Width = 96;
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
            // 
            // CommunalTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 339);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView communalnieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn accruals;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
    }
}