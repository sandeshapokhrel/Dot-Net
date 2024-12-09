using System;
using System.Windows.Forms;

namespace GUICalculator
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Set form properties
            this.Text = "Simple Calculator";
            this.Width = 400;
            this.Height = 300;

            // Create controls
            TextBox txtInput1 = new TextBox { Top = 20, Left = 50, Width = 100 };
            TextBox txtInput2 = new TextBox { Top = 20, Left = 200, Width = 100 };

            Label lblResult = new Label { Text = "Result:", Top = 150, Left = 50, Width = 300 };

            Button btnAdd = new Button { Text = "+", Top = 70, Left = 50, Width = 50 };
            Button btnSubtract = new Button { Text = "-", Top = 70, Left = 120, Width = 50 };
            Button btnMultiply = new Button { Text = "*", Top = 70, Left = 190, Width = 50 };
            Button btnDivide = new Button { Text = "/", Top = 70, Left = 260, Width = 50 };

            // Add controls to the form
            this.Controls.Add(txtInput1);
            this.Controls.Add(txtInput2);
            this.Controls.Add(lblResult);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnSubtract);
            this.Controls.Add(btnMultiply);
            this.Controls.Add(btnDivide);

            // Event handlers for button clicks
            btnAdd.Click += (sender, args) =>
            {
                double num1 = GetInput(txtInput1);
                double num2 = GetInput(txtInput2);
                lblResult.Text = "Result: " + (num1 + num2);
            };

            btnSubtract.Click += (sender, args) =>
            {
                double num1 = GetInput(txtInput1);
                double num2 = GetInput(txtInput2);
                lblResult.Text = "Result: " + (num1 - num2);
            };

            btnMultiply.Click += (sender, args) =>
            {
                double num1 = GetInput(txtInput1);
                double num2 = GetInput(txtInput2);
                lblResult.Text = "Result: " + (num1 * num2);
            };

            btnDivide.Click += (sender, args) =>
            {
                double num1 = GetInput(txtInput1);
                double num2 = GetInput(txtInput2);
                lblResult.Text = num2 != 0 ? "Result: " + (num1 / num2) : "Error: Division by zero";
            };
        }

        // Helper method to get input
        private double GetInput(TextBox textBox)
        {
            double.TryParse(textBox.Text, out double result);
            return result;
        }
    }
}
