namespace Communalnie
{
    partial class Graph
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
            this.readingsRadioButton = new System.Windows.Forms.RadioButton();
            this.priceRadioButton = new System.Windows.Forms.RadioButton();
            this.servicesComboBox = new System.Windows.Forms.ComboBox();
            this.byMonthComboBox = new System.Windows.Forms.ComboBox();
            this.byYearComboBox = new System.Windows.Forms.ComboBox();
            this.fromMonthComboBox = new System.Windows.Forms.ComboBox();
            this.fromYearComboBox = new System.Windows.Forms.ComboBox();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "По";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Услуга";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Период";
            // 
            // readingsRadioButton
            // 
            this.readingsRadioButton.AutoSize = true;
            this.readingsRadioButton.Location = new System.Drawing.Point(320, 65);
            this.readingsRadioButton.Name = "readingsRadioButton";
            this.readingsRadioButton.Size = new System.Drawing.Size(79, 17);
            this.readingsRadioButton.TabIndex = 44;
            this.readingsRadioButton.TabStop = true;
            this.readingsRadioButton.Text = "показания";
            this.readingsRadioButton.UseVisualStyleBackColor = true;
            this.readingsRadioButton.CheckedChanged += new System.EventHandler(this.readingsRadioButton_CheckedChanged);
            // 
            // priceRadioButton
            // 
            this.priceRadioButton.AutoSize = true;
            this.priceRadioButton.Location = new System.Drawing.Point(405, 66);
            this.priceRadioButton.Name = "priceRadioButton";
            this.priceRadioButton.Size = new System.Drawing.Size(79, 17);
            this.priceRadioButton.TabIndex = 43;
            this.priceRadioButton.TabStop = true;
            this.priceRadioButton.Text = "стоимость";
            this.priceRadioButton.UseVisualStyleBackColor = true;
            // 
            // servicesComboBox
            // 
            this.servicesComboBox.Enabled = false;
            this.servicesComboBox.FormattingEnabled = true;
            this.servicesComboBox.Location = new System.Drawing.Point(320, 35);
            this.servicesComboBox.Name = "servicesComboBox";
            this.servicesComboBox.Size = new System.Drawing.Size(178, 21);
            this.servicesComboBox.TabIndex = 42;
            this.servicesComboBox.SelectedIndexChanged += new System.EventHandler(this.servicesComboBox_SelectedIndexChanged);
            // 
            // byMonthComboBox
            // 
            this.byMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byMonthComboBox.Enabled = false;
            this.byMonthComboBox.FormattingEnabled = true;
            this.byMonthComboBox.Location = new System.Drawing.Point(136, 64);
            this.byMonthComboBox.Name = "byMonthComboBox";
            this.byMonthComboBox.Size = new System.Drawing.Size(141, 21);
            this.byMonthComboBox.TabIndex = 76;
            this.byMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.byMonthComboBox_SelectedIndexChanged);
            // 
            // byYearComboBox
            // 
            this.byYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byYearComboBox.Enabled = false;
            this.byYearComboBox.FormattingEnabled = true;
            this.byYearComboBox.Location = new System.Drawing.Point(39, 64);
            this.byYearComboBox.Name = "byYearComboBox";
            this.byYearComboBox.Size = new System.Drawing.Size(91, 21);
            this.byYearComboBox.Sorted = true;
            this.byYearComboBox.TabIndex = 75;
            this.byYearComboBox.SelectedIndexChanged += new System.EventHandler(this.byYearComboBox_SelectedIndexChanged);
            // 
            // fromMonthComboBox
            // 
            this.fromMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromMonthComboBox.Enabled = false;
            this.fromMonthComboBox.FormattingEnabled = true;
            this.fromMonthComboBox.Location = new System.Drawing.Point(136, 35);
            this.fromMonthComboBox.Name = "fromMonthComboBox";
            this.fromMonthComboBox.Size = new System.Drawing.Size(141, 21);
            this.fromMonthComboBox.TabIndex = 78;
            this.fromMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.fromMonthComboBox_SelectedIndexChanged);
            // 
            // fromYearComboBox
            // 
            this.fromYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromYearComboBox.FormattingEnabled = true;
            this.fromYearComboBox.Location = new System.Drawing.Point(39, 35);
            this.fromYearComboBox.Name = "fromYearComboBox";
            this.fromYearComboBox.Size = new System.Drawing.Size(91, 21);
            this.fromYearComboBox.Sorted = true;
            this.fromYearComboBox.TabIndex = 77;
            this.fromYearComboBox.SelectedIndexChanged += new System.EventHandler(this.fromYearComboBox_SelectedIndexChanged);
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Location = new System.Drawing.Point(15, 91);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(520, 420);
            this.graphPictureBox.TabIndex = 49;
            this.graphPictureBox.TabStop = false;
            this.graphPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.graphPictureBox_Paint);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 522);
            this.Controls.Add(this.fromMonthComboBox);
            this.Controls.Add(this.fromYearComboBox);
            this.Controls.Add(this.byMonthComboBox);
            this.Controls.Add(this.byYearComboBox);
            this.Controls.Add(this.graphPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readingsRadioButton);
            this.Controls.Add(this.priceRadioButton);
            this.Controls.Add(this.servicesComboBox);
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton readingsRadioButton;
        private System.Windows.Forms.RadioButton priceRadioButton;
        private System.Windows.Forms.ComboBox servicesComboBox;
        private System.Windows.Forms.ComboBox byMonthComboBox;
        private System.Windows.Forms.ComboBox byYearComboBox;
        private System.Windows.Forms.ComboBox fromMonthComboBox;
        private System.Windows.Forms.ComboBox fromYearComboBox;
        private System.Windows.Forms.PictureBox graphPictureBox;
    }
}