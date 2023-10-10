using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Grade_Calculator
{
    public partial class CatGradeCalForm : Form
    {
        public CatGradeCalForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "")
            {
                AddButton.Visible = false;
                //If textbox is empty make AddButton invisable
            }
            try
            {
                Double.Parse(textBox.Text);
                //Trys to convert the inputted text into a Double
                textBox.ForeColor = Color.Black;
                AddButton.Visible = true;
                //If successful make textBox.ForeColor black and AddButton visable
            }
            catch (Exception ex)
            {
                textBox.ForeColor = Color.Red;
                AddButton.Visible = false;
                //If unsuccessful make textBox.ForeColor Red and AddButton invisable
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listView.Items.Add(textBox1.Text);
                textBox1.Text = "";
                SetAverageGradeLabel();
                //Adds the text from textBox1 into the listview and set textBox1 text to empty
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                RemoveButton.Visible = true;
                //If listview item is selected make RemoveButton visable
            }
            else
            {
                RemoveButton.Visible = false;
                //If listview item is not selected make RemoveButton invisable
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            listView.Items.RemoveAt(listView.SelectedIndices[0]);
            SetAverageGradeLabel();
            //Removes current selected item from list and calls SetAverageGradeLabel method
        }

        private void SetAverageGradeLabel()
        {
            double x = 0;
            foreach (ListViewItem item in listView.Items)
            {
                x += Double.Parse(item.Text);
                //For each item in listview add the double value of the item to the x varable
            }
            x /= listView.Items.Count;
            AverageGradeLabel.Text = "Average Grade: " + x.ToString("F");
            //Divide x by the number of items in the list and displays the output
        }
    }
}
