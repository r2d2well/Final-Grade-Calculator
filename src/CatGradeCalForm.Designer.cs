namespace Final_Grade_Calculator
{
    partial class CatGradeCalForm
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
            listView = new ListView();
            label1 = new Label();
            textBox1 = new TextBox();
            AddButton = new Button();
            RemoveButton = new Button();
            AverageGradeLabel = new Label();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.Location = new Point(12, 12);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(279, 411);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.List;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(454, 63);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 1;
            label1.Text = "Enter Grade:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(454, 184);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(169, 50);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Visible = false;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(310, 373);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(169, 50);
            RemoveButton.TabIndex = 4;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Visible = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AverageGradeLabel
            // 
            AverageGradeLabel.AutoSize = true;
            AverageGradeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AverageGradeLabel.Location = new Point(390, 295);
            AverageGradeLabel.Name = "AverageGradeLabel";
            AverageGradeLabel.Size = new Size(220, 41);
            AverageGradeLabel.TabIndex = 5;
            AverageGradeLabel.Text = "Average Grade:";
            // 
            // CatGradeCalForm
            // 
            AcceptButton = AddButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 450);
            Controls.Add(AverageGradeLabel);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listView);
            Name = "CatGradeCalForm";
            Text = "CatGradeCalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private Label label1;
        private TextBox textBox1;
        private Button AddButton;
        private Button RemoveButton;
        private Label AverageGradeLabel;
    }
}