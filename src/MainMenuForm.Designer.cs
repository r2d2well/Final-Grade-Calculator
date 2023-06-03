namespace Final_Grade_Calculator
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MinFinalButton = new Button();
            CreateButton = new Button();
            ViewCalsButton = new Button();
            CatGradeButton = new Button();
            SuspendLayout();
            // 
            // MinFinalButton
            // 
            MinFinalButton.Location = new Point(480, 284);
            MinFinalButton.Name = "MinFinalButton";
            MinFinalButton.Size = new Size(262, 128);
            MinFinalButton.TabIndex = 0;
            MinFinalButton.Text = "Min Final Calculator";
            MinFinalButton.UseVisualStyleBackColor = true;
            MinFinalButton.Click += MinFinalButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(41, 44);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(262, 128);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Create New Calculator";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // ViewCalsButton
            // 
            ViewCalsButton.Location = new Point(480, 44);
            ViewCalsButton.Name = "ViewCalsButton";
            ViewCalsButton.Size = new Size(262, 128);
            ViewCalsButton.TabIndex = 2;
            ViewCalsButton.Text = "View Calculators";
            ViewCalsButton.UseVisualStyleBackColor = true;
            ViewCalsButton.Click += ViewCalsButton_Click;
            // 
            // CatGradeButton
            // 
            CatGradeButton.Location = new Point(41, 284);
            CatGradeButton.Name = "CatGradeButton";
            CatGradeButton.Size = new Size(262, 128);
            CatGradeButton.TabIndex = 3;
            CatGradeButton.Text = "Catogory Grade Calculator";
            CatGradeButton.UseVisualStyleBackColor = true;
            CatGradeButton.Click += CatGradeButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(CatGradeButton);
            Controls.Add(ViewCalsButton);
            Controls.Add(CreateButton);
            Controls.Add(MinFinalButton);
            Name = "MainMenuForm";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button MinFinalButton;
        private Button CreateButton;
        private Button ViewCalsButton;
        private Button CatGradeButton;
    }
}