namespace SimpleCalculatorCSharp
{
    public partial class Form1 : Form
    {
        private double value;
        private string op;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            var currentText = txtNum.Text;
            var btnText = ((Button)sender).Text;
            var newValue = Double.Parse(currentText);
            if (newValue == 0)
                txtNum.Text = btnText;
            else
                txtNum.Text = $"{currentText}{btnText}";
        }

        private void btnOperatorClick(object sender, EventArgs e)
        {
            var currentText = txtNum.Text;
            var btnText = ((Button)sender).Text;
            var newValue = Double.Parse(currentText);
            switch (btnText)
            {
                case "/":
                case "*":
                case "+":
                case "-":
                    value = newValue;
                    op = btnText;
                    txtNum.Text = "0";
                    break;
                case "=":
                    switch (op)
                    {
                        case "+":
                            value += newValue; break;
                        case "-":
                            value -= newValue; break;
                        case "*":
                            value *= newValue; break;
                        case "/":
                            value /= newValue; break;
                    }
                    txtNum.Text = value.ToString();
                    break;
                case "AC":
                    value = 0;
                    op = "";
                    txtNum.Text = "0";
                    break;
                case ".":
                    if (!currentText.Contains("."))
                        txtNum.Text = $"{currentText}.";
                    break;
                case "+/-": txtNum.Text = (-newValue).ToString(); break;
                case "%": txtNum.Text = (newValue / 100).ToString(); break;
            }
        }
    }
}