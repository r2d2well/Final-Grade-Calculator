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
    public partial class UseCalForm : Form
    {
        int y = 50;
        int x = 100;
        double[] inputs;
        ClassCalculator ClassCal;
        List<Label> categorLabels;
        List<TextBox> categorTextBoxs;
        bool[] valideInput;
        public UseCalForm(ClassCalculator x)
        {
            inputs = new double[x.GetCount()];
            valideInput = new bool[x.GetCount()];
            ClassCal = x;
            categorLabels = new List<Label>();
            categorTextBoxs = new List<TextBox>();
            InitializeComponent();
            //Requires to be given a ClassCalculator object to be initilzed
            for (int i = 0; i < x.GetCount(); i++)
            {
                addCategory(i);
            }
            FinalGradeLabel.Location = new Point(250, y);
            this.Size = new Size(750, y + 100);
            setGrades();
        }

        private void setGrades()
        {
            StreamReader reader = new StreamReader("ClassGrades.txt");
            using (reader)
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] stringArray = line.Split(' ');
                    if (stringArray[0].Replace('_', ' ') == ClassCal.GetName())
                    {
                        for(int i = 0; i < ClassCal.GetCount(); i++)
                        {
                            categorTextBoxs[i].Text = stringArray[i + 1];
                        }
                    }
                }
            }
        }

        private void addCategory(int count)
        {
            Label label = new Label();
            string text = "Enter " + ClassCal.GetCatagory(count) + " Grade: ";
            label.Text = text;
            label.Location = new Point(x, y);
            label.Size = new Size(250, 25);
            categorLabels.Add(label);
            Controls.Add(label);
            TextBox textBox = new TextBox();
            textBox.Location = new Point(x + 350, y);
            textBox.Size = new Size(150, 25);
            textBox.TextChanged += ValidateInput;
            categorTextBoxs.Add(textBox);
            Controls.Add(textBox);
            y += 100;
        }

        private double CalculateGrade()
        {
            double sumPoints = 0;
            double sumPercent = 0;

            for (int x = 0; x < inputs.Count(); x++)
            {
                sumPoints += (inputs[x] * ClassCal.GetPercent(x));
                sumPercent += ClassCal.GetPercent(x);
            }

            return (sumPoints / sumPercent);
            //Returns all the points a person earned divided by the total amount of points a person got
        }

        private void ValidateInput(Object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                double value = Double.Parse(textBox.Text);
                if ((value < 0) || (value > 100))
                {
                    throw new Exception();
                }
                textBox.ForeColor = Color.Black;
                int index = categorTextBoxs.IndexOf(textBox);
                valideInput[index] = true;
                inputs[index] = value;
                for (int temp = 0; temp < valideInput.Count(); temp++)
                {
                    if (!valideInput[temp])
                    {
                        return;
                    }
                }
                string text = "Final Grade: " + CalculateGrade();
                FinalGradeLabel.Text = text;
            }
            catch (Exception ex)
            {
                textBox.ForeColor = Color.Red;
                int index = categorTextBoxs.IndexOf(textBox);
                valideInput[index] = false;
            }
            //Validates the input and change the textBox ForeColor based off of the results
        }

        private void UseCalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string tempFile = Path.GetTempFileName();
            bool found = false;

            using (StreamReader reader = new StreamReader("ClassGrades.txt"))
            using (StreamWriter writer = new StreamWriter(tempFile))
            //Creates a reader for the ClassData and a Writer for the temp file
            {
                string line;
                string temp;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] stringArray = line.Split(' ');
                    if (stringArray[0].Replace('_', ' ') == ClassCal.GetName())
                    {
                        temp = stringArray[0];
                        for (int i = 0; i < ClassCal.GetCount(); i++)
                        {
                            temp += (" " + categorTextBoxs[i].Text);
                        }
                        writer.WriteLine(temp);
                        found = true;
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
                if (!found)
                {
                    temp = ClassCal.GetName().Replace(' ', '_');
                    for (int i = 0; i < ClassCal.GetCount(); i++)
                    {
                        if (valideInput[i])
                        {
                            temp += (" " + categorTextBoxs[i].Text);
                        }
                        else
                        {
                            temp += (" 0");
                        }
                    }
                    writer.WriteLine(temp);
                }
            }
            File.Delete("ClassGrades.txt");
            File.Move(tempFile, "ClassGrades.txt");
        }
    }
}
