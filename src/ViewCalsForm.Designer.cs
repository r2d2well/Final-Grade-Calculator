﻿namespace Final_Grade_Calculator
{
    partial class ViewCalsForm
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
            UseButton = new Button();
            RemoveButton = new Button();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.Location = new Point(181, 12);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(451, 306);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.List;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // UseButton
            // 
            UseButton.Location = new Point(466, 380);
            UseButton.Name = "UseButton";
            UseButton.Size = new Size(166, 58);
            UseButton.TabIndex = 1;
            UseButton.Text = "Use Calculator";
            UseButton.UseVisualStyleBackColor = true;
            UseButton.Visible = false;
            UseButton.Click += UseButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(181, 380);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(166, 58);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove Calculator";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Visible = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ViewCalsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveButton);
            Controls.Add(UseButton);
            Controls.Add(listView);
            Name = "ViewCalsForm";
            Text = "View Calculators";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private Button UseButton;
        private Button RemoveButton;
    }
}