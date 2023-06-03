namespace Final_Grade_Calculator
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MinFinalButton_Click(object sender, EventArgs e)
        {
            MinFinalForm minFinal = new MinFinalForm();
            minFinal.ShowDialog();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            GenerateNewCalculatorForm generateNewCalculatorForm = new GenerateNewCalculatorForm();
            generateNewCalculatorForm.ShowDialog();
        }

        private void ViewCalsButton_Click(object sender, EventArgs e)
        {
            ViewCalsForm viewCalsForm = new ViewCalsForm();
            viewCalsForm.ShowDialog();
        }

        private void CatGradeButton_Click(object sender, EventArgs e)
        {
            CatGradeCalForm catGradeCalForm = new CatGradeCalForm();
            catGradeCalForm.ShowDialog();
        }
    }
}