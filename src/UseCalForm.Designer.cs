namespace Final_Grade_Calculator
{
    partial class UseCalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseCalForm));
            FinalGradeLabel = new Label();
            SuspendLayout();
            // 
            // FinalGradeLabel
            // 
            FinalGradeLabel.AutoSize = true;
            FinalGradeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FinalGradeLabel.Location = new Point(309, 422);
            FinalGradeLabel.Name = "FinalGradeLabel";
            FinalGradeLabel.Size = new Size(156, 28);
            FinalGradeLabel.TabIndex = 0;
            FinalGradeLabel.Text = "Final Grade: N/A";
            // 
            // UseCalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(736, 590);
            Controls.Add(FinalGradeLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UseCalForm";
            Text = "Use Calculator";
            FormClosing += UseCalForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FinalGradeLabel;
    }
}