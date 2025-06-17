using System;
using System.Drawing;
using System.Windows.Forms;

public class CalculatorForm : Form
{

    private TextBox displayTextBox;
    private Label historyLabel;
    private Button[] numberButtons;
    private Button dotButton;
    private Button addButton;
    private Button subtractButton;
    private Button multiplyButton;
    private Button divideButton;
    private Button equalsButton;
    private Button clearButton;
    private Button backspaceButton;

    private double result = 0;
    private string operation = "";
    private bool isOperationPerformed = false;

    public CalculatorForm()
    {

        this.Text = "Простой калькулятор";
        this.Size = new Size(550, 550);
        this.MaximizeBox = false;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;

        InitializeComponents();
    }

    private void InitializeComponents()
    {
        historyLabel = new Label();
        historyLabel.Location = new Point(10, 10);
        historyLabel.Size = new Size(260, 20);
        historyLabel.TextAlign = ContentAlignment.MiddleRight;
        historyLabel.Font = new Font("Microsoft Sans Serif", 10);
        this.Controls.Add(historyLabel);

        displayTextBox = new TextBox();
        displayTextBox.Location = new Point(50, 40);
        displayTextBox.Size = new Size(260, 30);
        displayTextBox.Font = new Font("Microsoft Sans Serif", 14);
        displayTextBox.TextAlign = HorizontalAlignment.Right;
        displayTextBox.ReadOnly = true;
        this.Controls.Add(displayTextBox);

        numberButtons = new Button[10];
        for (int i = 0; i < 10; i++)
        {
            numberButtons[i] = new Button();
            numberButtons[i].Text = i.ToString();
            numberButtons[i].Font = new Font("Microsoft Sans Serif", 12);
            numberButtons[i].Click += NumberButton_Click;
        }

        numberButtons[7].Location = new Point(10, 100);
        numberButtons[8].Location = new Point(100, 100);
        numberButtons[9].Location = new Point(190, 100);

        numberButtons[4].Location = new Point(10, 170);
        numberButtons[5].Location = new Point(100, 170);
        numberButtons[6].Location = new Point(190, 170);

        numberButtons[1].Location = new Point(10, 240);
        numberButtons[2].Location = new Point(100, 240);
        numberButtons[3].Location = new Point(190, 240);

        numberButtons[0].Location = new Point(100, 310);

        foreach (Button button in numberButtons)
        {
            button.Size = new Size(80, 60);
            this.Controls.Add(button);
        }

        dotButton = new Button();
        dotButton.Text = ".";
        dotButton.Font = new Font("Microsoft Sans Serif", 12);
        dotButton.Size = new Size(80, 60);
        dotButton.Location = new Point(10, 310);
        dotButton.Click += DotButton_Click;
        this.Controls.Add(dotButton);

        addButton = CreateOperationButton("+", 270, 100);
        subtractButton = CreateOperationButton("-", 270, 170);
        multiplyButton = CreateOperationButton("×", 270, 240);
        divideButton = CreateOperationButton("÷", 270, 310);

        equalsButton = new Button();
        equalsButton.Text = "=";
        equalsButton.Font = new Font("Microsoft Sans Serif", 12);
        equalsButton.Size = new Size(80, 60);
        equalsButton.Location = new Point(190, 310);
        equalsButton.Click += EqualsButton_Click;
        this.Controls.Add(equalsButton);

        clearButton = new Button();
        clearButton.Text = "C";
        clearButton.Font = new Font("Microsoft Sans Serif", 12);
        clearButton.Size = new Size(80, 50);
        clearButton.Location = new Point(10, 380);
        clearButton.Click += ClearButton_Click;
        this.Controls.Add(clearButton);

        backspaceButton = new Button();
        backspaceButton.Text = "←";
        backspaceButton.Font = new Font("Microsoft Sans Serif", 12);
        backspaceButton.Size = new Size(80, 50);
        backspaceButton.Location = new Point(100, 380);
        backspaceButton.Click += BackspaceButton_Click;
        this.Controls.Add(backspaceButton);
    }

    private Button CreateOperationButton(string text, int x, int y)
    {
        Button button = new Button();
        button.Text = text;
        button.Font = new Font("Microsoft Sans Serif", 12);
        button.Size = new Size(80, 60);
        button.Location = new Point(x, y);
        button.Click += OperationButton_Click;
        this.Controls.Add(button);
        return button;
    }

    private void NumberButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        if (isOperationPerformed || displayTextBox.Text == "0")
        {
            displayTextBox.Text = "";
            isOperationPerformed = false;
        }

        if (button.Text == "0")
        {
            if (displayTextBox.Text != "0")
            {
                displayTextBox.Text += button.Text;
            }
        }
        else
        {
            displayTextBox.Text += button.Text;
        }
    }

    private void DotButton_Click(object sender, EventArgs e)
    {
        if (!displayTextBox.Text.Contains("."))
        {
            if (string.IsNullOrEmpty(displayTextBox.Text))
            {
                displayTextBox.Text = "0";
            }
            displayTextBox.Text += ".";
        }
    }

    private void OperationButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        if (!string.IsNullOrEmpty(displayTextBox.Text))
        {
            if (!isOperationPerformed && !string.IsNullOrEmpty(operation))
            {
                CalculateResult();
            }
            else
            {
                result = double.Parse(displayTextBox.Text);
            }
        }

        operation = button.Text;
        historyLabel.Text = $"{result} {operation}";
        isOperationPerformed = true;
    }

    private void EqualsButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(operation))
        {
            CalculateResult();
            operation = "";
            historyLabel.Text = "";
        }
    }

    private void CalculateResult()
    {
        double inputNumber = double.Parse(displayTextBox.Text);

        switch (operation)
        {
            case "+":
                result += inputNumber;
                break;
            case "-":
                result -= inputNumber;
                break;
            case "×":
                result *= inputNumber;
                break;
            case "÷":
                if (inputNumber != 0)
                {
                    result /= inputNumber;
                }
                else
                {
                    MessageBox.Show("Нельзя делить на ноль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                break;
        }

        displayTextBox.Text = result.ToString();
        isOperationPerformed = true;
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        displayTextBox.Text = "0";
        result = 0;
        operation = "";
        historyLabel.Text = "";
        isOperationPerformed = false;
    }

    private void BackspaceButton_Click(object sender, EventArgs e)
    {
        if (displayTextBox.Text.Length > 0)
        {
            displayTextBox.Text = displayTextBox.Text.Substring(0, displayTextBox.Text.Length - 1);

            if (displayTextBox.Text.Length == 0)
            {
                displayTextBox.Text = "0";
            }
        }
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData >= Keys.D0 && keyData <= Keys.D9)
        {
            int number = (int)keyData - (int)Keys.D0;
            numberButtons[number].PerformClick();
            return true;
        }

        if (keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9)
        {
            int number = (int)keyData - (int)Keys.NumPad0;
            numberButtons[number].PerformClick();
            return true;
        }

        switch (keyData)
        {
            case Keys.Add:
                addButton.PerformClick();
                return true;
            case Keys.Subtract:
                subtractButton.PerformClick();
                return true;
            case Keys.Multiply:
                multiplyButton.PerformClick();
                return true;
            case Keys.Divide:
                divideButton.PerformClick();
                return true;
            case Keys.Enter:
                equalsButton.PerformClick();
                return true;
            case Keys.Decimal:
                dotButton.PerformClick();
                return true;
            case Keys.Back:
                backspaceButton.PerformClick();
                return true;
            case Keys.Escape:
                clearButton.PerformClick();
                return true;
        }

        return base.ProcessCmdKey(ref msg, keyData);
    }
}
