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
    public partial class ViewCalsForm : Form
    {
        List<ClassCalculator> list;
        public ViewCalsForm()
        {
            InitializeComponent();
            list = Program.GetList();
            foreach (ClassCalculator c in list)
            {
                listView.Items.Add(c.GetName());
                //Add all the ClassCalculators in the list into the ListView
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count > 0)
            {
                UseButton.Visible = true;
                RemoveButton.Visible = true;
                EditButton.Visible = true;
                //If a ListView Item is selected make UseButton and RemoveButton Visable
            }
            else
            {
                UseButton.Visible = false;
                RemoveButton.Visible = false;
                EditButton.Visible = false;
                //If no ListView Item is selected make UseButton and RemoveButton Invisable
            }
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            int x = listView.SelectedIndices[0];
            UseCalForm useCalForm = new UseCalForm(list[x]);
            useCalForm.ShowDialog();
            //Creates a new UseCalForm with the currently selected ListViewItem
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ClassCalculator x = list[listView.SelectedIndices[0]];
            listView.Items.RemoveAt(listView.SelectedIndices[0]);
            Program.RemoveFromList(x);
            //Removes the Calculator from the Listview and the calls the RemoveFromList method from the Program class
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int x = listView.SelectedIndices[0];
            GenerateNewCalculatorForm generateNewCalculatorForm = new GenerateNewCalculatorForm(list[x]);
            generateNewCalculatorForm.ShowDialog();
            //Creates a new UseCalForm with the currently selected ListViewItem
        }
    }
}
