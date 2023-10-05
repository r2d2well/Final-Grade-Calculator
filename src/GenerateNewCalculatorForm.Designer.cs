namespace Final_Grade_Calculator
{
    partial class GenerateNewCalculatorForm
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
            listView1 = new ListView();
            CatagoryName = new ColumnHeader();
            Percent = new ColumnHeader();
            CreateButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            CatagoryNameTextBox = new TextBox();
            CatagoryLabel = new Label();
            PercentLabel = new Label();
            PercentTextBox = new TextBox();
            TotalLabel = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CatagoryName, Percent });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 12);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(254, 365);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // CatagoryName
            // 
            CatagoryName.Text = "Catagory Name";
            CatagoryName.Width = 180;
            // 
            // Percent
            // 
            Percent.Text = "Percent";
            Percent.Width = 70;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(651, 392);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(137, 46);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(291, 392);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(137, 46);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Visible = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(474, 331);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(137, 46);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add Catagory";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CatagoryNameTextBox
            // 
            CatagoryNameTextBox.Location = new Point(474, 107);
            CatagoryNameTextBox.Name = "CatagoryNameTextBox";
            CatagoryNameTextBox.Size = new Size(151, 27);
            CatagoryNameTextBox.TabIndex = 4;
            // 
            // CatagoryLabel
            // 
            CatagoryLabel.AutoSize = true;
            CatagoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatagoryLabel.Location = new Point(474, 62);
            CatagoryLabel.Name = "CatagoryLabel";
            CatagoryLabel.Size = new Size(151, 28);
            CatagoryLabel.TabIndex = 5;
            CatagoryLabel.Text = "Catogory Name";
            // 
            // PercentLabel
            // 
            PercentLabel.AutoSize = true;
            PercentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PercentLabel.Location = new Point(511, 191);
            PercentLabel.Name = "PercentLabel";
            PercentLabel.Size = new Size(76, 28);
            PercentLabel.TabIndex = 7;
            PercentLabel.Text = "Percent";
            // 
            // PercentTextBox
            // 
            PercentTextBox.Location = new Point(474, 232);
            PercentTextBox.Name = "PercentTextBox";
            PercentTextBox.Size = new Size(151, 27);
            PercentTextBox.TabIndex = 6;
            PercentTextBox.TextChanged += PercentTextBox_TextChanged;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.BackColor = Color.Transparent;
            TotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLabel.Location = new Point(40, 380);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(127, 28);
            TotalLabel.TabIndex = 8;
            TotalLabel.Text = "Total Percent:";
            // 
            // GenerateNewCalculatorForm
            // 
            AcceptButton = AddButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(TotalLabel);
            Controls.Add(PercentLabel);
            Controls.Add(PercentTextBox);
            Controls.Add(CatagoryLabel);
            Controls.Add(CatagoryNameTextBox);
            Controls.Add(AddButton);
            Controls.Add(RemoveButton);
            Controls.Add(CreateButton);
            Controls.Add(listView1);
            Name = "GenerateNewCalculatorForm";
            Text = "GenerateNewCalculatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader CatagoryName;
        private ColumnHeader Percent;
        private Button CreateButton;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox CatagoryNameTextBox;
        private Label CatagoryLabel;
        private Label PercentLabel;
        private TextBox PercentTextBox;
        private Label TotalLabel;
    }
}