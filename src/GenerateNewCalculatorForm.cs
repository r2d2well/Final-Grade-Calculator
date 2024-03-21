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
    public partial class GenerateNewCalculatorForm : Form
    {
        System.Windows.Forms.Timer timer;
        bool edit;
        string calName;
        List<string> gradeList;
        public GenerateNewCalculatorForm()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += TimerDone;
            InitializeComponent();
            //Creates a timer that has a 1000 milisecond interval
            edit = false;
            gradeList = null;
        }

        public GenerateNewCalculatorForm(ClassCalculator calculator)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += TimerDone;
            InitializeComponent();
            //Creates a timer that has a 1000 milisecond interval
            calName = calculator.GetName();
            for (int i = 0; i < calculator.GetCount(); i++)
            {
                ListViewItem listViewItem = new ListViewItem(calculator.GetCatagory(i));
                listViewItem.SubItems.Add(calculator.GetPercent(i).ToString());
                listView1.Items.Add(listViewItem);
            }
            TotalLabel.Text = "Total Percent: " + GetTotalPercent();
            this.Text = "Edit " + calName + " Calculator";
            edit = true;
            gradeList = Program.GetGrades(calName).ToList();
            CreateButton.Text = "Submit Changes";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                string[] name = new string[listView1.Items.Count];
                double[] percent = new double[listView1.Items.Count];

                for (int x = 0; x < listView1.Items.Count; x++)
                {
                    name[x] = listView1.Items[x].Text;
                    percent[x] = double.Parse(listView1.Items[x].SubItems[1].Text);
                    //Creates 2 arrays based off current listview Items
                }
                if (!edit)
                {
                    EnterClassNameForm enterClassNameForm = new EnterClassNameForm(name, percent, this);
                    enterClassNameForm.ShowDialog();
                }
                else
                {
                    ClassCalculator x = new ClassCalculator(calName, name, percent);
                    Program.AddToList(x);
                    Program.WriteGradeData(x, gradeList.ToArray());
                    this.Close();
                }
                //Creates a new EnterClassNameForm with array and this current Form
            }
            else
            {
                this.Close();
                //If the listview is empty just closes the Form
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (gradeList != null)
            {
                gradeList.RemoveAt(listView1.SelectedIndices[0]);
            }
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            TotalLabel.Text = "Total Percent: " + GetTotalPercent();
            //Removes currently selected Item and updates the Total Percent Label
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                RemoveButton.Visible = true;
                //If an item is selected make RemoveButton visable
            }
            else
            {
                RemoveButton.Visible = false;
                //If no item is selected make RemoveButton invisable
            }
        }

        private void PercentTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                int x = int.Parse(textBox.Text);
                //Trys to cast the text in PercetnTextBox to a double
                if ((x > 100) || (x < 0))
                {
                    throw new Exception();
                    //If entered percent is more then 100 or less then 0 then throw new exception
                }
                textBox.ForeColor = Color.Black;
                //If no exceptions are throw make ForeColor Black
            }
            catch (Exception ex)
            {
                textBox.ForeColor = Color.Red;
                //If exceptions are throw make ForeColor Red
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((CatagoryNameTextBox.Text != "") && (PercentTextBox.Text != "") && (PercentTextBox.ForeColor != Color.Red))
            {
                ListViewItem listViewItem = new ListViewItem(CatagoryNameTextBox.Text);
                listViewItem.SubItems.Add(PercentTextBox.Text);
                listView1.Items.Add(listViewItem);
                //If all textboxs inputs are valid then adds a new ListView Item to the ListView with the info in the textboxs
                CatagoryNameTextBox.Text = string.Empty;
                PercentTextBox.Text = string.Empty;
                TotalLabel.Text = "Total Percent: " + GetTotalPercent();
                //Makes the 2 textBox empty and update the Total Percent
                if (gradeList != null)
                {
                    gradeList.Add("/");
                }
            }
            else
            {
                timer.Start();
                AddButton.BackColor = Color.Red;
                //If either TextBoxs are empty or PercetnTextBox ForeColor is Red then make the AddButton turn red for a 1000 miliseconds
            }
        }

        private int GetTotalPercent()
        {
            int total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += int.Parse(item.SubItems[1].Text);
            }
            return total;
            //Adds all the percents in the listview together and return them
        }

        private void TimerDone(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;
            timer.Stop();
            AddButton.BackColor = Color.White;
            //When timer is done then stop timer and set AddButton Backcolor back to White
        }
    }
}
