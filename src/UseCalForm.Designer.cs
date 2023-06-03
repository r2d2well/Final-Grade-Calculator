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
            label1 = new Label();
            textBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 54);
            label1.Name = "label1";
            label1.Size = new Size(215, 38);
            label1.TabIndex = 0;
            label1.Text = "Enter <> Grade:";
            // 
            // textBox
            // 
            textBox.Location = new Point(170, 113);
            textBox.Name = "textBox";
            textBox.Size = new Size(151, 27);
            textBox.TabIndex = 1;
            textBox.TextChanged += ValidateInput;
            // 
            // button1
            // 
            button1.Location = new Point(395, 144);
            button1.Name = "button1";
            button1.Size = new Size(127, 44);
            button1.TabIndex = 2;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UseCalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(534, 200);
            Controls.Add(button1);
            Controls.Add(textBox);
            Controls.Add(label1);
            Name = "UseCalForm";
            Text = "Use Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox;
        private Button button1;
    }
}