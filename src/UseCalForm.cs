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
        int count;
        int counter = 1;
        double[] inputs;
        ClassCalculator ClassCal;
        public UseCalForm(ClassCalculator x)
        {
            count = x.GetCount();
            inputs = new double[count];
            ClassCal = x;
            InitializeComponent();
            label1.Text = "Enter " + ClassCal.GetCatagory(0) + " Grade (" + ClassCal.GetPercent(0) + "%): ";
            //Requires to be given a ClassCalculator object to be initilzed
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
                Double.Parse(textBox.Text);
                textBox.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                textBox.ForeColor = Color.Red;
            }
            //Validates the input and change the textBox ForeColor based off of the results
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox.ForeColor != Color.Red) && (textBox.Text != ""))
            {
                if (counter == (count + 1))
                {
                    this.Hide();
                    //Close the form if all final Grade has already been shown
                }
                else if (counter == count)
                {
                    inputs[counter - 1] = Double.Parse(textBox.Text);
                    textBox.Visible = false;
                    label1.Text = "Your Final Grade is: " + CalculateGrade().ToString("F") + "%";
                    counter++;
                    //Shows the final Calculated Grade
                }
                else
                {
                    inputs[counter - 1] = Double.Parse(textBox.Text);
                    label1.Text = "Enter " + ClassCal.GetCatagory(counter) + " Grade (" + ClassCal.GetPercent(counter) + "%): ";
                    textBox.Text = "";
                    counter++;
                    //Adds the input from the textBox and asks for the next input if there is any
                }
            }
        }
    }
}
