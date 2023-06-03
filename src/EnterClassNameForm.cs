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
    public partial class EnterClassNameForm : Form
    {
        string[] catagory;
        double[] percent;
        Form form;
        public EnterClassNameForm(string[] x, double[] y, Form z)
        {
            InitializeComponent();
            catagory = x;
            percent = y;
            form = z;
            //Requires a string array and double array and a Form object to be inilized
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Closes just this window
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                ClassCalculator x = new ClassCalculator(textBox.Text, catagory, percent);
                Program.AddToList(x);
                //Adds a new ClassCalculator to the list in program class with given information and name
                this.Hide();
                form.Hide();
                //Then closes both this Form and the given Form
            }
            else
            {
                textBox.BackColor = Color.Red;
                //If textbox text equal an empty string then set BackColor to Red
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.BackColor = Color.White;
                //If textbox text does not equal an empty string then set BackColor to white
            }
        }
    }
}
