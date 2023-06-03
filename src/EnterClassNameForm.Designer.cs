namespace Final_Grade_Calculator
{
    partial class EnterClassNameForm
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
            label = new Label();
            textBox = new TextBox();
            CancelButton = new Button();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(161, 54);
            label.Name = "label";
            label.Size = new Size(255, 41);
            label.TabIndex = 0;
            label.Text = "Enter Class Name:";
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(161, 140);
            textBox.Name = "textBox";
            textBox.Size = new Size(255, 47);
            textBox.TabIndex = 1;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 253);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(472, 253);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // EnterClassNameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(578, 294);
            Controls.Add(SubmitButton);
            Controls.Add(CancelButton);
            Controls.Add(textBox);
            Controls.Add(label);
            Name = "EnterClassNameForm";
            Text = "EnterClassNameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox textBox;
        private Button CancelButton;
        private Button SubmitButton;
    }
}