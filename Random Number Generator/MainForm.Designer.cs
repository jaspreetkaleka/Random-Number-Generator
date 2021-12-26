namespace RandomNumberGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.rsNnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.reNnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.colsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.algoComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.value1Label = new System.Windows.Forms.Label();
            this.value2Label = new System.Windows.Forms.Label();
            this.value1NnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.value2NnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.decimalsRadioButton = new System.Windows.Forms.RadioButton();
            this.integersRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.rsNnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value1NnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value2NnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Range";
            // 
            // rsNnumericUpDown
            // 
            this.rsNnumericUpDown.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsNnumericUpDown.Location = new System.Drawing.Point(86, 60);
            this.rsNnumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rsNnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rsNnumericUpDown.Name = "rsNnumericUpDown";
            this.rsNnumericUpDown.Size = new System.Drawing.Size(76, 25);
            this.rsNnumericUpDown.TabIndex = 1;
            this.rsNnumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reNnumericUpDown
            // 
            this.reNnumericUpDown.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reNnumericUpDown.Location = new System.Drawing.Point(191, 60);
            this.reNnumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reNnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.reNnumericUpDown.Name = "reNnumericUpDown";
            this.reNnumericUpDown.Size = new System.Drawing.Size(76, 25);
            this.reNnumericUpDown.TabIndex = 3;
            this.reNnumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // colsNumericUpDown
            // 
            this.colsNumericUpDown.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colsNumericUpDown.Location = new System.Drawing.Point(191, 93);
            this.colsNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colsNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.colsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colsNumericUpDown.Name = "colsNumericUpDown";
            this.colsNumericUpDown.Size = new System.Drawing.Size(76, 25);
            this.colsNumericUpDown.TabIndex = 7;
            this.colsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            // 
            // rowsNumericUpDown
            // 
            this.rowsNumericUpDown.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsNumericUpDown.Location = new System.Drawing.Point(86, 93);
            this.rowsNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rowsNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rowsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowsNumericUpDown.Name = "rowsNumericUpDown";
            this.rowsNumericUpDown.Size = new System.Drawing.Size(76, 25);
            this.rowsNumericUpDown.TabIndex = 5;
            this.rowsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rowsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Span";
            // 
            // generateButton
            // 
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(86, 245);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(180, 32);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // algoComboBox
            // 
            this.algoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algoComboBox.FormattingEnabled = true;
            this.algoComboBox.Items.AddRange(new object[] {
            "Simple",
            "Gaussian",
            "Exponential\t",
            "Gamma\t\t",
            "Inverse Gamma",
            "Weibull\t\t",
            "Cauchy\t\t",
            "Laplace\t\t",
            "Log Normal\t",
            "Beta\t\t",
            "Chi Square\t",
            "Student\'s t"});
            this.algoComboBox.Location = new System.Drawing.Point(86, 125);
            this.algoComboBox.Name = "algoComboBox";
            this.algoComboBox.Size = new System.Drawing.Size(181, 23);
            this.algoComboBox.TabIndex = 9;
            this.algoComboBox.SelectedIndexChanged += new System.EventHandler(this.algoComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type";
            // 
            // value1Label
            // 
            this.value1Label.AutoSize = true;
            this.value1Label.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1Label.Location = new System.Drawing.Point(168, 159);
            this.value1Label.Name = "value1Label";
            this.value1Label.Size = new System.Drawing.Size(27, 17);
            this.value1Label.TabIndex = 11;
            this.value1Label.Text = "NA";
            // 
            // value2Label
            // 
            this.value2Label.AutoSize = true;
            this.value2Label.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2Label.Location = new System.Drawing.Point(168, 192);
            this.value2Label.Name = "value2Label";
            this.value2Label.Size = new System.Drawing.Size(27, 17);
            this.value2Label.TabIndex = 12;
            this.value2Label.Text = "NA";
            // 
            // value1NnumericUpDown
            // 
            this.value1NnumericUpDown.DecimalPlaces = 2;
            this.value1NnumericUpDown.Enabled = false;
            this.value1NnumericUpDown.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1NnumericUpDown.Location = new System.Drawing.Point(86, 155);
            this.value1NnumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.value1NnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.value1NnumericUpDown.Name = "value1NnumericUpDown";
            this.value1NnumericUpDown.Size = new System.Drawing.Size(76, 25);
            this.value1NnumericUpDown.TabIndex = 13;
            this.value1NnumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // value2NnumericUpDown
            // 
            this.value2NnumericUpDown.DecimalPlaces = 2;
            this.value2NnumericUpDown.Enabled = false;
            this.value2NnumericUpDown.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2NnumericUpDown.Location = new System.Drawing.Point(86, 188);
            this.value2NnumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.value2NnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.value2NnumericUpDown.Name = "value2NnumericUpDown";
            this.value2NnumericUpDown.Size = new System.Drawing.Size(76, 25);
            this.value2NnumericUpDown.TabIndex = 14;
            this.value2NnumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 38);
            this.label8.TabIndex = 15;
            this.label8.Text = "Random Number Generator";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decimalsRadioButton
            // 
            this.decimalsRadioButton.AutoSize = true;
            this.decimalsRadioButton.Location = new System.Drawing.Point(161, 220);
            this.decimalsRadioButton.Name = "decimalsRadioButton";
            this.decimalsRadioButton.Size = new System.Drawing.Size(77, 19);
            this.decimalsRadioButton.TabIndex = 16;
            this.decimalsRadioButton.Text = "Decimals";
            this.decimalsRadioButton.UseVisualStyleBackColor = true;
            // 
            // integersRadioButton
            // 
            this.integersRadioButton.AutoSize = true;
            this.integersRadioButton.Checked = true;
            this.integersRadioButton.Location = new System.Drawing.Point(86, 220);
            this.integersRadioButton.Name = "integersRadioButton";
            this.integersRadioButton.Size = new System.Drawing.Size(69, 19);
            this.integersRadioButton.TabIndex = 17;
            this.integersRadioButton.TabStop = true;
            this.integersRadioButton.Text = "Integers";
            this.integersRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 290);
            this.Controls.Add(this.integersRadioButton);
            this.Controls.Add(this.decimalsRadioButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.value2NnumericUpDown);
            this.Controls.Add(this.value1NnumericUpDown);
            this.Controls.Add(this.value2Label);
            this.Controls.Add(this.value1Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.algoComboBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.colsNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rowsNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reNnumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rsNnumericUpDown);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Number Generator";
            ((System.ComponentModel.ISupportInitialize)(this.rsNnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value1NnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value2NnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rsNnumericUpDown;
        private System.Windows.Forms.NumericUpDown reNnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown colsNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rowsNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ComboBox algoComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label value1Label;
        private System.Windows.Forms.Label value2Label;
        private System.Windows.Forms.NumericUpDown value1NnumericUpDown;
        private System.Windows.Forms.NumericUpDown value2NnumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton decimalsRadioButton;
        private System.Windows.Forms.RadioButton integersRadioButton;
    }
}

