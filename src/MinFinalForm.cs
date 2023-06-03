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
    public partial class MinFinalForm : Form
    {
        public MinFinalForm()
        {
            InitializeComponent();
        }

        private void ValidateInput(Object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                Double.Parse(textBox.Text);
                textBox.ForeColor = Color.Black;
                //If textBox text can succefully be Parse to a double then input is valid
            }
            catch (Exception ex)
            {
                textBox.ForeColor = Color.Red;
                //Otherwise input is invalid so make textbox ForeColor Red
            }
        }

        private double CalcuateMinFinal()
        {
            double MinFinal = 0;
            double currentGrade = Double.Parse(CurrentGradeTextBox.Text);
            double DesiredGrade = Double.Parse(DesiredGradeTextBox.Text);
            double FinalPercentage = (Double.Parse(FinalPercentTextBox.Text) / 100);

            currentGrade *= (1 - FinalPercentage);
            double Points = DesiredGrade - currentGrade;
            MinFinal = Points / (FinalPercentage * 100);

            return (MinFinal * 100);
            //Takes in teh information from the textBoxs and uses a formula to calculate and return the Minumal Final Grade
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if ((CurrentGradeTextBox.ForeColor == Color.Black) && (DesiredGradeTextBox.ForeColor == Color.Black)
                && (FinalPercentTextBox.ForeColor == Color.Black))
            {
                if ((CurrentGradeTextBox.Text != "") && (DesiredGradeTextBox.Text != "") && (FinalPercentTextBox.Text != ""))
                {
                    MinimumFinalLabel.Text = "Minimum Final: " + CalcuateMinFinal();
                    //Displays the Minumal Final Grade if all considtions are meet 
                }
            }
        }
    }
}
