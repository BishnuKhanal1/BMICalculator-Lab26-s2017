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
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialLabel = new System.Windows.Forms.Label();
            this.MatricsRadioButton = new System.Windows.Forms.RadioButton();
            this.MatricsLabel = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.MyHeight = new System.Windows.Forms.Label();
            this.IncheLabel = new System.Windows.Forms.Label();
            this.BMITextBoxControl = new System.Windows.Forms.TextBox();
            this.MeterLabel = new System.Windows.Forms.Label();
            this.MyWeight = new System.Windows.Forms.Label();
            this.PoundLabel = new System.Windows.Forms.Label();
            this.KilogramLabel = new System.Windows.Forms.Label();
            this.HeightInInches = new System.Windows.Forms.NumericUpDown();
            this.HeightInMeters = new System.Windows.Forms.NumericUpDown();
            this.WeightInPounds = new System.Windows.Forms.NumericUpDown();
            this.WeightInKg = new System.Windows.Forms.NumericUpDown();
            this.TableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInInches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInMeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightInPounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightInKg)).BeginInit();
            this.TableHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CalculateBMI.BackColor = System.Drawing.Color.Maroon;
            this.CalculateBMI.ForeColor = System.Drawing.Color.White;
            this.CalculateBMI.Location = new System.Drawing.Point(50, 3);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(200, 35);
            this.CalculateBMI.TabIndex = 0;
            this.CalculateBMI.Text = "Calculate BMR";
            this.CalculateBMI.UseVisualStyleBackColor = false;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(39, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ImperialRadioButton.TabIndex = 3;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialLabel
            // 
            this.ImperialLabel.AutoSize = true;
            this.ImperialLabel.Location = new System.Drawing.Point(59, 0);
            this.ImperialLabel.Name = "ImperialLabel";
            this.ImperialLabel.Size = new System.Drawing.Size(65, 20);
            this.ImperialLabel.TabIndex = 2;
            this.ImperialLabel.Text = "Imperial";
            // 
            // MatricsRadioButton
            // 
            this.MatricsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MatricsRadioButton.AutoSize = true;
            this.MatricsRadioButton.Location = new System.Drawing.Point(172, 3);
            this.MatricsRadioButton.Name = "MatricsRadioButton";
            this.MatricsRadioButton.Size = new System.Drawing.Size(14, 13);
            this.MatricsRadioButton.TabIndex = 4;
            this.MatricsRadioButton.TabStop = true;
            this.MatricsRadioButton.UseVisualStyleBackColor = true;
            // 
            // MatricsLabel
            // 
            this.MatricsLabel.AutoSize = true;
            this.MatricsLabel.Location = new System.Drawing.Point(192, 0);
            this.MatricsLabel.Name = "MatricsLabel";
            this.MatricsLabel.Size = new System.Drawing.Size(52, 20);
            this.MatricsLabel.TabIndex = 5;
            this.MatricsLabel.Text = "Matric";
            // 
            // LabelName
            // 
            this.LabelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Maroon;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(17, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelName.Size = new System.Drawing.Size(276, 20);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "BODY MASS INDEX CALCULATOR";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyHeight
            // 
            this.MyHeight.AutoSize = true;
            this.MyHeight.Location = new System.Drawing.Point(3, 0);
            this.MyHeight.Name = "MyHeight";
            this.MyHeight.Size = new System.Drawing.Size(80, 20);
            this.MyHeight.TabIndex = 7;
            this.MyHeight.Text = "My Height";
            // 
            // IncheLabel
            // 
            this.IncheLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IncheLabel.AutoSize = true;
            this.IncheLabel.Location = new System.Drawing.Point(104, 27);
            this.IncheLabel.Name = "IncheLabel";
            this.IncheLabel.Size = new System.Drawing.Size(55, 42);
            this.IncheLabel.TabIndex = 9;
            this.IncheLabel.Text = "inches";
            // 
            // BMITextBoxControl
            // 
            this.BMITextBoxControl.BackColor = System.Drawing.Color.LightCyan;
            this.BMITextBoxControl.Enabled = false;
            this.BMITextBoxControl.ForeColor = System.Drawing.Color.Maroon;
            this.BMITextBoxControl.Location = new System.Drawing.Point(3, 260);
            this.BMITextBoxControl.Multiline = true;
            this.BMITextBoxControl.Name = "BMITextBoxControl";
            this.BMITextBoxControl.Size = new System.Drawing.Size(301, 122);
            this.BMITextBoxControl.TabIndex = 10;
            // 
            // MeterLabel
            // 
            this.MeterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MeterLabel.AutoSize = true;
            this.MeterLabel.Location = new System.Drawing.Point(240, 27);
            this.MeterLabel.Name = "MeterLabel";
            this.MeterLabel.Size = new System.Drawing.Size(58, 42);
            this.MeterLabel.TabIndex = 11;
            this.MeterLabel.Text = "meters";
            // 
            // MyWeight
            // 
            this.MyWeight.AutoSize = true;
            this.MyWeight.Location = new System.Drawing.Point(3, 69);
            this.MyWeight.Name = "MyWeight";
            this.MyWeight.Size = new System.Drawing.Size(83, 20);
            this.MyWeight.TabIndex = 12;
            this.MyWeight.Text = "My Weight";
            // 
            // PoundLabel
            // 
            this.PoundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PoundLabel.AutoSize = true;
            this.PoundLabel.Location = new System.Drawing.Point(104, 102);
            this.PoundLabel.Name = "PoundLabel";
            this.PoundLabel.Size = new System.Drawing.Size(62, 71);
            this.PoundLabel.TabIndex = 14;
            this.PoundLabel.Text = "pounds";
            // 
            // KilogramLabel
            // 
            this.KilogramLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.KilogramLabel.AutoSize = true;
            this.KilogramLabel.Location = new System.Drawing.Point(240, 102);
            this.KilogramLabel.Name = "KilogramLabel";
            this.KilogramLabel.Size = new System.Drawing.Size(34, 71);
            this.KilogramLabel.TabIndex = 15;
            this.KilogramLabel.Text = "kgs";
            // 
            // HeightInInches
            // 
            this.HeightInInches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightInInches.Location = new System.Drawing.Point(38, 30);
            this.HeightInInches.Name = "HeightInInches";
            this.HeightInInches.Size = new System.Drawing.Size(60, 26);
            this.HeightInInches.TabIndex = 17;
            this.HeightInInches.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HeightInMeters
            // 
            this.HeightInMeters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeightInMeters.Location = new System.Drawing.Point(173, 30);
            this.HeightInMeters.Name = "HeightInMeters";
            this.HeightInMeters.Size = new System.Drawing.Size(61, 26);
            this.HeightInMeters.TabIndex = 18;
            this.HeightInMeters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeightInPounds
            // 
            this.WeightInPounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightInPounds.Location = new System.Drawing.Point(38, 105);
            this.WeightInPounds.Name = "WeightInPounds";
            this.WeightInPounds.Size = new System.Drawing.Size(60, 26);
            this.WeightInPounds.TabIndex = 19;
            this.WeightInPounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeightInKg
            // 
            this.WeightInKg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightInKg.Location = new System.Drawing.Point(174, 105);
            this.WeightInKg.Name = "WeightInKg";
            this.WeightInKg.Size = new System.Drawing.Size(60, 26);
            this.WeightInKg.TabIndex = 20;
            this.WeightInKg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TableHeader
            // 
            this.TableHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TableHeader.ColumnCount = 1;
            this.TableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableHeader.Controls.Add(this.LabelName, 0, 0);
            this.TableHeader.Location = new System.Drawing.Point(3, 1);
            this.TableHeader.Name = "TableHeader";
            this.TableHeader.RowCount = 1;
            this.TableHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableHeader.Size = new System.Drawing.Size(301, 28);
            this.TableHeader.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.22013F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.77988F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImperialLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MatricsRadioButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MatricsLabel, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 30);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.41177F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.58823F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.Controls.Add(this.MyHeight, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.HeightInInches, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.IncheLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.KilogramLabel, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.WeightInKg, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.HeightInMeters, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.WeightInPounds, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.PoundLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.MeterLabel, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.MyWeight, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.98305F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.01695F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 173);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.CalculateBMI, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(301, 41);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TableHeader);
            this.Controls.Add(this.BMITextBoxControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator Form";
            ((System.ComponentModel.ISupportInitialize)(this.HeightInInches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInMeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightInPounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightInKg)).EndInit();
            this.TableHeader.ResumeLayout(false);
            this.TableHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        internal System.Windows.Forms.Label ImperialLabel;
        private System.Windows.Forms.RadioButton MatricsRadioButton;
        private System.Windows.Forms.Label MatricsLabel;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label MyHeight;
        private System.Windows.Forms.Label IncheLabel;
        private System.Windows.Forms.TextBox BMITextBoxControl;
        private System.Windows.Forms.Label MeterLabel;
        private System.Windows.Forms.Label MyWeight;
        private System.Windows.Forms.Label PoundLabel;
        private System.Windows.Forms.Label KilogramLabel;
        private System.Windows.Forms.NumericUpDown HeightInInches;
        private System.Windows.Forms.NumericUpDown HeightInMeters;
        private System.Windows.Forms.NumericUpDown WeightInPounds;
        private System.Windows.Forms.NumericUpDown WeightInKg;
        private System.Windows.Forms.TableLayoutPanel TableHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

