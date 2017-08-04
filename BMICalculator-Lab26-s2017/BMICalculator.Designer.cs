namespace BMICalculator_Lab26_s2017
{
    partial class BMICalculator
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
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.BMIFormHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WeightInPounds = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.WeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightInInchLabel = new System.Windows.Forms.Label();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CalculateBMI.BackColor = System.Drawing.Color.Maroon;
            this.CalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMI.ForeColor = System.Drawing.Color.White;
            this.CalculateBMI.Location = new System.Drawing.Point(3, 3);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(140, 35);
            this.CalculateBMI.TabIndex = 0;
            this.CalculateBMI.Text = "Calculate BMI";
            this.CalculateBMI.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel3.Controls.Add(this.CalculateBMI, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ResetButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(297, 41);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(149, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(140, 35);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset Form";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.BMIResultTextBox.Location = new System.Drawing.Point(3, 274);
            this.BMIResultTextBox.Multiline = true;
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(297, 108);
            this.BMIResultTextBox.TabIndex = 10;
            // 
            // BMIFormHeader
            // 
            this.BMIFormHeader.AutoSize = true;
            this.BMIFormHeader.Location = new System.Drawing.Point(27, 0);
            this.BMIFormHeader.Name = "BMIFormHeader";
            this.BMIFormHeader.Size = new System.Drawing.Size(253, 31);
            this.BMIFormHeader.TabIndex = 25;
            this.BMIFormHeader.Text = "BMI CALCULATOR";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16611F));
            this.tableLayoutPanel1.Controls.Add(this.WeightInPounds, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MyWeightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeightNumericUpDown, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MyHeightLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightNumericUpDown, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.HeightInInchLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12329F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.19178F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.80822F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.24657F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 135);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // WeightInPounds
            // 
            this.WeightInPounds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WeightInPounds.AutoSize = true;
            this.WeightInPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInPounds.Location = new System.Drawing.Point(153, 87);
            this.WeightInPounds.Name = "WeightInPounds";
            this.WeightInPounds.Size = new System.Drawing.Size(133, 48);
            this.WeightInPounds.TabIndex = 28;
            this.WeightInPounds.Text = "Weight in Pounds";
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MyWeightLabel, 2);
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 64);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(83, 20);
            this.MyWeightLabel.TabIndex = 27;
            this.MyWeightLabel.Text = "My Weight";
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightNumericUpDown.BackColor = System.Drawing.Color.LightCyan;
            this.HeightNumericUpDown.DecimalPlaces = 2;
            this.HeightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightNumericUpDown.Location = new System.Drawing.Point(57, 25);
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(90, 35);
            this.HeightNumericUpDown.TabIndex = 28;
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MyHeightLabel, 2);
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 0);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(80, 20);
            this.MyHeightLabel.TabIndex = 27;
            this.MyHeightLabel.Text = "My Height";
            // 
            // WeightNumericUpDown
            // 
            this.WeightNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightNumericUpDown.BackColor = System.Drawing.Color.LightCyan;
            this.WeightNumericUpDown.DecimalPlaces = 2;
            this.WeightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightNumericUpDown.Location = new System.Drawing.Point(57, 90);
            this.WeightNumericUpDown.Name = "WeightNumericUpDown";
            this.WeightNumericUpDown.Size = new System.Drawing.Size(90, 35);
            this.WeightNumericUpDown.TabIndex = 30;
            // 
            // HeightInInchLabel
            // 
            this.HeightInInchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightInInchLabel.AutoSize = true;
            this.HeightInInchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInInchLabel.Location = new System.Drawing.Point(153, 22);
            this.HeightInInchLabel.Name = "HeightInInchLabel";
            this.HeightInInchLabel.Size = new System.Drawing.Size(124, 42);
            this.HeightInInchLabel.TabIndex = 29;
            this.HeightInInchLabel.Text = "Height in Inches";
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(21, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(124, 38);
            this.ImperialRadioButton.TabIndex = 28;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial Units";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(151, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(111, 38);
            this.MetricRadioButton.TabIndex = 29;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Matric Units";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MetricRadioButton, 1, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 44);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ResultLabel.Location = new System.Drawing.Point(6, 251);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(55, 20);
            this.ResultLabel.TabIndex = 28;
            this.ResultLabel.Text = "Result";
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BMIFormHeader);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.BMIResultTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator Form";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.Label BMIFormHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.Label WeightInPounds;
        private System.Windows.Forms.Label HeightInInchLabel;
        private System.Windows.Forms.NumericUpDown WeightNumericUpDown;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}

