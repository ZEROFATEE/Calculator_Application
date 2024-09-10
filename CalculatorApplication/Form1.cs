namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        private CalculatorClass cal;
        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtboxinput1.Text);
            double num2 = Convert.ToDouble(txtboxinput2.Text);
            double result = 0;

            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    cal.CalculateEvent += cal.GetSum;
                    result = cal.GetSum(num1, num2);
                    cal.CalculateEvent -= cal.GetSum;
                    break;
                case "-":
                    cal.CalculateEvent += cal.GetDifference;
                    result = cal.GetDifference(num1, num2);
                    cal.CalculateEvent -= cal.GetDifference;
                    break;
                case "*":
                    cal.CalculateEvent += cal.GetProduct;
                    result = cal.GetProduct(num1, num2);
                    cal.CalculateEvent -= cal.GetProduct;
                    break;
                case "/":
                    try
                    {
                        cal.CalculateEvent += cal.GetQuotient;
                        result = cal.GetQuotient(num1, num2);
                        cal.CalculateEvent -= cal.GetQuotient;
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Please select a valid operator.");
                    return;
            }

            lblDisplayTotal.Text = result.ToString();
        }
    }
}
