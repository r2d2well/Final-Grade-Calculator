namespace Final_Grade_Calculator
{
    partial class MinFinalForm
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
            MinimumFinalLabel = new Label();
            CurrentGradeLabel = new Label();
            CurrentGradeTextBox = new TextBox();
            DesiredGradeTextBox = new TextBox();
            DesiredGradeLabel = new Label();
            FinalPercentTextBox = new TextBox();
            FinalPercentLabel = new Label();
            CalculateButton = new Button();
            SuspendLayout();
            // 
            // MinimumFinalLabel
            // 
            MinimumFinalLabel.AutoSize = true;
            MinimumFinalLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumFinalLabel.Location = new Point(250, 400);
            MinimumFinalLabel.Name = "MinimumFinalLabel";
            MinimumFinalLabel.Size = new Size(229, 41);
            MinimumFinalLabel.TabIndex = 0;
            MinimumFinalLabel.Text = "Minimum Final: ";
            // 
            // CurrentGradeLabel
            // 
            CurrentGradeLabel.AutoSize = true;
            CurrentGradeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentGradeLabel.Location = new Point(275, 40);
            CurrentGradeLabel.Name = "CurrentGradeLabel";
            CurrentGradeLabel.Size = new Size(208, 28);
            CurrentGradeLabel.TabIndex = 1;
            CurrentGradeLabel.Text = "Current Grade In Class:";
            // 
            // CurrentGradeTextBox
            // 
            CurrentGradeTextBox.ForeColor = Color.Black;
            CurrentGradeTextBox.Location = new Point(289, 81);
            CurrentGradeTextBox.Name = "CurrentGradeTextBox";
            CurrentGradeTextBox.Size = new Size(174, 27);
            CurrentGradeTextBox.TabIndex = 2;
            CurrentGradeTextBox.TextChanged += ValidateInput;
            // 
            // DesiredGradeTextBox
            // 
            DesiredGradeTextBox.ForeColor = Color.Black;
            DesiredGradeTextBox.Location = new Point(289, 170);
            DesiredGradeTextBox.Name = "DesiredGradeTextBox";
            DesiredGradeTextBox.Size = new Size(174, 27);
            DesiredGradeTextBox.TabIndex = 4;
            DesiredGradeTextBox.TextChanged += ValidateInput;
            // 
            // DesiredGradeLabel
            // 
            DesiredGradeLabel.AutoSize = true;
            DesiredGradeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DesiredGradeLabel.Location = new Point(275, 129);
            DesiredGradeLabel.Name = "DesiredGradeLabel";
            DesiredGradeLabel.Size = new Size(209, 28);
            DesiredGradeLabel.TabIndex = 0;
            DesiredGradeLabel.Text = "Desired Grade In Class:";
            // 
            // FinalPercentTextBox
            // 
            FinalPercentTextBox.ForeColor = Color.Black;
            FinalPercentTextBox.Location = new Point(289, 256);
            FinalPercentTextBox.Name = "FinalPercentTextBox";
            FinalPercentTextBox.Size = new Size(174, 27);
            FinalPercentTextBox.TabIndex = 6;
            FinalPercentTextBox.TextChanged += ValidateInput;
            // 
            // FinalPercentLabel
            // 
            FinalPercentLabel.AutoSize = true;
            FinalPercentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FinalPercentLabel.Location = new Point(259, 216);
            FinalPercentLabel.Name = "FinalPercentLabel";
            FinalPercentLabel.Size = new Size(240, 28);
            FinalPercentLabel.TabIndex = 5;
            FinalPercentLabel.Text = "What Percent Is Your Final:";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(289, 334);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(174, 63);
            CalculateButton.TabIndex = 7;
            CalculateButton.Text = "CalculateButton";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // MinFinalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(CalculateButton);
            Controls.Add(FinalPercentTextBox);
            Controls.Add(FinalPercentLabel);
            Controls.Add(DesiredGradeTextBox);
            Controls.Add(DesiredGradeLabel);
            Controls.Add(CurrentGradeTextBox);
            Controls.Add(CurrentGradeLabel);
            Controls.Add(MinimumFinalLabel);
            Name = "MinFinalForm";
            Text = "MinFinal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MinimumFinalLabel;
        private Label CurrentGradeLabel;
        private TextBox CurrentGradeTextBox;
        private TextBox DesiredGradeTextBox;
        private Label DesiredGradeLabel;
        private TextBox FinalPercentTextBox;
        private Label FinalPercentLabel;
        private Button CalculateButton;
    }
}