using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string output = "";
        string op = "";
        double temp = 0;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            DivideButton.Content = "\u00F7";
            SqrtButton.Content = "\u221A";

        }

        private void NumButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "ZeroButton":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;
                case "OneButton":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;
                case "TwoButton":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;
                case "ThreeButton":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;
                case "FourButton":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;
                case "FiveButton":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;
                case "SixButton":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;
                case "SevenButton":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;
                case "EightButton":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;
                case "NineButton":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;
                case "DecimalButton":
                    output += ".";
                    OutputTextBlock.Text = output;
                    break;
            }
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            temp = double.Parse(output);
            

            switch (name)
            {
                case "DivideButton":
                    op = "divide";
                    output += "\u00F7";
                    break;
                case "MultiplyButton":
                    op = "multiply";
                    output += "x";
                    break;
                case "MinusButton":
                    op = "minus";
                    output += "-";
                    break;
                case "AddButton":
                    op = "add";
                    output += "+";
                    break;
                case "PowButton":
                    op = "pow";
                    output += "^";
                    break;
            }

            PreviewTextBlock.Text = output;
            OutputTextBlock.Text = "";
            output = "";

        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            double calc = 0;
            double num = double.Parse(output);
            PreviewTextBlock.Text += output + "=";

            switch (op)
            {
                case "divide":
                    calc = temp / num;
                    break;
                case "multiply":
                    calc = temp * num;
                    break;
                case "minus":
                    calc = temp - num;
                    break;
                case "add":
                    calc = temp + num;
                    break;
                case "pow":
                    calc = Math.Pow(temp, num);
                    break;
                case "sqrt":
                    calc = num;
                    break;
            }
            output = calc.ToString();
            OutputTextBlock.Text = output;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            OutputTextBlock.Text = "";
            PreviewTextBlock.Text = "";
            op = "";

        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(output);
            num *= -1;
            output = num.ToString();
            OutputTextBlock.Text = output;
        }

        private void SqrtButton_Click(object sender, RoutedEventArgs e)
        {
            temp = double.Parse(output);
            op = "sqrt";

            output = "\u221A" + output;
            PreviewTextBlock.Text = output;

            OutputTextBlock.Text = "";
            output = "";

            PreviewTextBlock.Text += output + "=";

            double calc = Math.Sqrt(temp);
            output = calc.ToString();

            OutputTextBlock.Text = output;
        }
    }
}
