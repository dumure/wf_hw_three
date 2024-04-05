using System.CodeDom;

namespace wf_hw_three
{
    public partial class Form1 : Form
    {
        private Operations Operation;
        private float? firstNumber;
        private float? secondNumber;
        private bool isFractional;

        public Form1()
        {
            InitializeComponent();
            firstNumber = 0;
            secondNumber = null;
            isFractional = false;
            Operation = Operations.NONE;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text != "0" && baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    baseLabel.Text += "0";
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "0";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "0";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "0";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    if (baseLabel.Text == "0")
                    {
                        baseLabel.Text = "1";
                    }
                    else
                    {
                        baseLabel.Text += "1";
                    }
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "1";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "1";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "1";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    if (baseLabel.Text == "0")
                    {
                        baseLabel.Text = "2";
                    }
                    else
                    {
                        baseLabel.Text += "2";
                    }
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "2";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "2";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "2";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    if (baseLabel.Text == "0")
                    {
                        baseLabel.Text = "3";
                    }
                    else
                    {
                        baseLabel.Text += "3";
                    }
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "3";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "3";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "3";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    if (baseLabel.Text == "0")
                    {
                        baseLabel.Text = "4";
                    }
                    else
                    {
                        baseLabel.Text += "4";
                    }
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "4";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "4";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "4";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    if (baseLabel.Text == "0")
                    {
                        baseLabel.Text = "5";
                    }
                    else
                    {
                        baseLabel.Text += "5";
                    }
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "5";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "5";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "5";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    if (baseLabel.Text == "0")
                    {
                        baseLabel.Text = "6";
                    }
                    else
                    {
                        baseLabel.Text += "6";
                    }
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "6";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "6";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "6";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    if (baseLabel.Text == "0")
                    {
                        baseLabel.Text = "7";
                    }
                    else
                    {
                        baseLabel.Text += "7";
                    }
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "7";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "7";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "7";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    if (baseLabel.Text == "0")
                    {
                        baseLabel.Text = "8";
                    }
                    else
                    {
                        baseLabel.Text += "8";
                    }
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "8";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "8";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "8";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                {
                    if (baseLabel.Text == "0")
                    {
                        baseLabel.Text = "9";
                    }
                    else
                    {
                        baseLabel.Text += "9";
                    }
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "9";
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "9";
                }
                else
                {
                    if (baseLabel.Text.Length <= (isFractional ? 10 : 9))
                    {
                        baseLabel.Text += "9";
                    }
                }
                secondNumber = float.Parse(baseLabel.Text);
            }
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (!isFractional && baseLabel.Text.Length <= 10)
                {
                    baseLabel.Text += ".";
                }
                if (baseLabel.Text.Any(c => c == '.'))
                {
                    isFractional = true;
                }
                firstNumber = float.Parse(baseLabel.Text);
            }
            else if (Operation == Operations.EQUALS)
            {
                helpLabel.Text = "";
                baseLabel.Text = "0.";
                isFractional = true;
                firstNumber = float.Parse(baseLabel.Text);
                Operation = Operations.NONE;
            }
            else
            {
                if (secondNumber == null || secondNumber == 0)
                {
                    baseLabel.Text = "0.";
                    if (baseLabel.Text.Any(c => c == '.'))
                    {
                        isFractional = true;
                    }
                    secondNumber = float.Parse(baseLabel.Text);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            baseLabel.Text = "0";
            firstNumber = 0;
            helpLabel.Text = "";
            secondNumber = null;
            Operation = Operations.NONE;
            isFractional = false;
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                clearButton_Click(sender, e);
            }
            else
            {
                baseLabel.Text = "0";
                secondNumber = 0;
                isFractional = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                Operation = Operations.ADD;
                helpLabel.Text = $"{firstNumber} + ";
                isFractional = false;
            }
            else
            {
                switch (Operation)
                {
                    case Operations.ADD:
                        if ((firstNumber + (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber + (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.SUBTRACT:
                        if ((firstNumber - (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber - (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.DIVIDE:
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot division by zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearButton_Click(sender, e);
                            return;
                        }
                        if ((firstNumber / (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber / (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.MULTIPLY:
                        if ((firstNumber * (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber * (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.PERCENT:
                        if ((firstNumber % (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber % (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.EQUALS:
                    case Operations.NONE:
                        break;
                }
                Operation = Operations.ADD;
                baseLabel.Text = firstNumber.ToString();
                helpLabel.Text = $"{firstNumber} + ";
                isFractional = false;
            }
            secondNumber = null;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                Operation = Operations.SUBTRACT;
                helpLabel.Text = $"{firstNumber} - ";
                isFractional = false;
            }
            else
            {
                switch (Operation)
                {
                    case Operations.ADD:
                        if ((firstNumber + (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber + (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.SUBTRACT:
                        if ((firstNumber - (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber - (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.DIVIDE:
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot division by zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearButton_Click(sender, e);
                            return;
                        }
                        if ((firstNumber / (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber / (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.MULTIPLY:
                        if ((firstNumber * (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber * (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.PERCENT:
                        if ((firstNumber % (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber % (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.EQUALS:
                    case Operations.NONE:
                        break;
                }
                Operation = Operations.SUBTRACT;
                baseLabel.Text = firstNumber.ToString();
                helpLabel.Text = $"{firstNumber} - ";
                isFractional = false;
            }
            secondNumber = null;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                Operation = Operations.MULTIPLY;
                helpLabel.Text = $"{firstNumber} * ";
                isFractional = false;
            }
            else
            {
                switch (Operation)
                {
                    case Operations.ADD:
                        if ((firstNumber + (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber + (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.SUBTRACT:
                        if ((firstNumber - (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber - (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.DIVIDE:
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot division by zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearButton_Click(sender, e);
                            return;
                        }
                        if ((firstNumber / (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber / (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.MULTIPLY:
                        if ((firstNumber * (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber * (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.PERCENT:
                        if ((firstNumber % (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber % (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.EQUALS:
                    case Operations.NONE:
                        break;
                }
                Operation = Operations.MULTIPLY;
                baseLabel.Text = firstNumber.ToString();
                helpLabel.Text = $"{firstNumber} * ";
                isFractional = false;
            }
            secondNumber = null;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                Operation = Operations.DIVIDE;
                helpLabel.Text = $"{firstNumber} / ";
                isFractional = false;
            }
            else
            {
                switch (Operation)
                {
                    case Operations.ADD:
                        if ((firstNumber + (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber + (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.SUBTRACT:
                        if ((firstNumber - (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber - (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.DIVIDE:
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot division by zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearButton_Click(sender, e);
                            return;
                        }
                        if ((firstNumber / (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber / (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.MULTIPLY:
                        if ((firstNumber * (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber * (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.PERCENT:
                        if ((firstNumber % (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber % (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.EQUALS:
                    case Operations.NONE:
                        break;
                }
                Operation = Operations.DIVIDE;
                baseLabel.Text = firstNumber.ToString();
                helpLabel.Text = $"{firstNumber} / ";
                isFractional = false;
            }
            secondNumber = null;
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                Operation = Operations.PERCENT;
                helpLabel.Text = $"{firstNumber} % ";
                isFractional = false;
            }
            else
            {
                switch (Operation)
                {
                    case Operations.ADD:
                        if ((firstNumber + (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber + (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.SUBTRACT:
                        if ((firstNumber - (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber - (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.DIVIDE:
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot division by zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearButton_Click(sender, e);
                            return;
                        }
                        if ((firstNumber / (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber / (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.MULTIPLY:
                        if ((firstNumber * (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber * (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.PERCENT:
                        if ((firstNumber % (secondNumber ??= firstNumber)).ToString().Length <= 10)
                        {
                            firstNumber = firstNumber % (secondNumber ??= firstNumber);
                        }
                        break;
                    case Operations.EQUALS:
                    case Operations.NONE:
                        break;
                }
                Operation = Operations.PERCENT;
                baseLabel.Text = firstNumber.ToString();
                helpLabel.Text = $"{firstNumber} % ";
                isFractional = false;
            }
            secondNumber = null;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case Operations.ADD:
                    helpLabel.Text = $"{firstNumber} + {(secondNumber < 0 ? $"({secondNumber})" : secondNumber)} = ";
                    if ((firstNumber + secondNumber).ToString().Length <= 10)
                    {
                        firstNumber = firstNumber + secondNumber;
                    }
                    baseLabel.Text = firstNumber.ToString();
                    secondNumber = null;
                    break;
                case Operations.SUBTRACT:
                    helpLabel.Text = $"{firstNumber} - {(secondNumber < 0 ? $"({secondNumber})" : secondNumber)} = ";
                    if ((firstNumber - secondNumber).ToString().Length <= 10)
                    {
                        firstNumber = firstNumber - secondNumber;
                    }
                    baseLabel.Text = firstNumber.ToString();
                    secondNumber = null;
                    break;
                case Operations.DIVIDE:
                    helpLabel.Text = $"{firstNumber} / {(secondNumber < 0 ? $"({secondNumber})" : secondNumber)} = ";
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot division by zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearButton_Click(sender, e);
                        return;
                    }
                    if ((firstNumber / (secondNumber ??= firstNumber)).ToString().Length <= 10)
                    {
                        firstNumber = firstNumber / (secondNumber ??= firstNumber);
                    }
                    baseLabel.Text = firstNumber.ToString();
                    secondNumber = null;
                    break;
                case Operations.MULTIPLY:
                    helpLabel.Text = $"{firstNumber} * {(secondNumber < 0 ? $"({secondNumber})" : secondNumber)} = ";
                    if ((firstNumber * secondNumber).ToString().Length <= 10)
                    {
                        firstNumber = firstNumber * secondNumber;
                    }
                    baseLabel.Text = firstNumber.ToString();
                    secondNumber = null;
                    break;
                case Operations.EQUALS:
                    helpLabel.Text = "";
                    firstNumber = float.Parse(baseLabel.Text);
                    secondNumber = null;
                    if (baseLabel.Text.Any(c => c == '.'))
                    {
                        isFractional = true;
                    }
                    Operation = Operations.NONE;
                    break;
                case Operations.NONE:
                    helpLabel.Text = $"{firstNumber} = ";
                    baseLabel.Text = firstNumber.ToString();
                    break;
            }
            Operation = Operations.EQUALS;
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                if (!isFractional && baseLabel.Text.Length <= 10)
                {
                    firstNumber = -firstNumber;
                    baseLabel.Text = firstNumber.ToString();
                }
            }
            else
            {
                if (!isFractional && baseLabel.Text.Length <= 10)
                {
                    if (secondNumber == null || secondNumber == 0)
                    {
                        secondNumber = -firstNumber;
                    }
                    else
                    {
                        secondNumber = -secondNumber;
                    }
                    baseLabel.Text = secondNumber.ToString();
                }
            }
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                if (!isFractional && baseLabel.Text.Length <= 10)
                {
                    if (firstNumber == 0)
                    {
                        MessageBox.Show("Cannot division by zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearButton_Click(sender, e);
                        return;
                    }
                    if ((1 / firstNumber).ToString().Length <= 10)
                        firstNumber = 1 / firstNumber;
                    baseLabel.Text = firstNumber.ToString();
                }
            }
            else
            {
                if (!isFractional && baseLabel.Text.Length <= 10)
                {
                    if (secondNumber == null || secondNumber == 0)
                    {
                        if (firstNumber == 0)
                        {
                            MessageBox.Show("Cannot division by zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearButton_Click(sender, e);
                            return;
                        }
                        if ((1 / firstNumber).ToString().Length <= 10)
                        {
                            secondNumber = 1 / firstNumber;
                        }
                    }
                    else
                    {
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot division by zero!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearButton_Click(sender, e);
                            return;
                        }
                        if ((1 / secondNumber).ToString().Length <= 10)
                        {
                            secondNumber = 1 / secondNumber;
                        }
                    }
                    baseLabel.Text = secondNumber.ToString();
                }
            }
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE)
            {
                if (firstNumber != 0)
                {
                    baseLabel.Text = baseLabel.Text.Remove(baseLabel.Text.Length - 1);
                    if (baseLabel.Text == "" || baseLabel.Text == "-")
                    {
                        baseLabel.Text = "0";
                    }
                    if (baseLabel.Text.All(c => c != '.'))
                    {
                        isFractional = false;
                    }
                    firstNumber = float.Parse(baseLabel.Text);
                }
            }
            else if (Operation == Operations.EQUALS)
            {
                clearButton_Click(sender, e);
            }
            else
            {
                if (secondNumber != null && secondNumber != 0)
                {
                    baseLabel.Text = baseLabel.Text.Remove(baseLabel.Text.Length - 1);
                    if (baseLabel.Text == "" || baseLabel.Text == "-")
                    {
                        baseLabel.Text = "0";
                    }
                    if (baseLabel.Text.All(c => c != '.'))
                    {
                        isFractional = false;
                    }
                    secondNumber = float.Parse(baseLabel.Text);
                }
            }
        }

        private void sqrButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                if (!isFractional && baseLabel.Text.Length <= 10)
                {
                    if ((firstNumber * firstNumber).ToString().Length <= 10)
                    {
                        firstNumber = firstNumber * firstNumber;
                    }
                    baseLabel.Text = firstNumber.ToString();
                }
            }
            else
            {
                if (!isFractional && baseLabel.Text.Length <= 10)
                {
                    if (secondNumber == null || secondNumber == 0)
                    {
                        if ((firstNumber * firstNumber).ToString().Length <= 10)
                        {
                            secondNumber = firstNumber * firstNumber;
                        }
                    }
                    else
                    {
                        if ((secondNumber * secondNumber).ToString().Length <= 10)
                        {
                            secondNumber = secondNumber * secondNumber;
                        }
                    }
                    baseLabel.Text = secondNumber.ToString();
                }
            }
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            if (Operation == Operations.NONE || Operation == Operations.EQUALS)
            {
                if (!isFractional && baseLabel.Text.Length <= 10)
                {
                    if (float.Parse((Math.Sqrt(double.Parse(firstNumber.ToString()))).ToString()).ToString().Length <= 10)
                    {
                        firstNumber = float.Parse((Math.Sqrt(double.Parse(firstNumber.ToString()))).ToString());
                    }
                    baseLabel.Text = firstNumber.ToString();
                }
            }
            else
            {
                if (!isFractional && baseLabel.Text.Length <= 10)
                {
                    if (secondNumber == null || secondNumber == 0)
                    {
                        if (float.Parse((Math.Sqrt(double.Parse(firstNumber.ToString()))).ToString()).ToString().Length <= 10)
                        {
                            secondNumber = float.Parse((Math.Sqrt(double.Parse(firstNumber.ToString()))).ToString());
                        }
                    }
                    else
                    {
                        if (float.Parse((Math.Sqrt(double.Parse(secondNumber.ToString()))).ToString()).ToString().Length <= 10)
                        {
                            secondNumber = float.Parse((Math.Sqrt(double.Parse(secondNumber.ToString()))).ToString());
                        }
                    }
                    baseLabel.Text = secondNumber.ToString();
                }
            }
        }
    }
}