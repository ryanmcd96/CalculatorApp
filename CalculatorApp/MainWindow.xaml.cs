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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //stored number int that keeps track of the total after calculations
        double storedNumber = 0;
        //string that denotes which operation to perform
        string operation = String.Empty;

        //inputs a nine in the textbox
        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "9";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "9";
            }
        }
        //inputs a eight in the textbox
        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "8";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "8";
            }
        }
        //inputs a seven in the textbox
        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "7";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "7";
            }
        }
        //inputs a six in the textbox
        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "6";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "6";
            }
        }
        //inputs a five in the textbox
        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "5";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "5";
            }
        }
        //inputs a four in the textbox
        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "4";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "4";
            }
        }
        //inputs a three in the textbox
        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "3";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "3";
            }
        }
        //inputs a two in the textbox
        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "2";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "2";
            }
        }
        //inputs a one in the textbox
        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "1";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "1";
            }

        }
        //inputs a zero in the textbox
        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "0";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "0";
            }
        }

        //clears the textbox and sets it back to 0
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbxResult.Text = "0";
            storedNumber = 0;
            operation = String.Empty;
        }

        //stores the added numbers in a variable and outputs the current total
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "-")
            {
                storedNumber -= int.Parse(tbxResult.Text);
                operation = "+";
                tbxResult.Text = "0";
            }
            else if(operation == "=")
            {
                operation = "+";
                tbxResult.Text = "0";
            }
            else if (operation == "*")
            {
                storedNumber *= int.Parse(tbxResult.Text);
                operation = "+";
                tbxResult.Text = "0";
            }
            else if (operation == "/")
            {
                storedNumber /= Convert.ToDouble(tbxResult.Text);
                operation = "+";
                tbxResult.Text = "0";
            }
            else
            {
                operation = "+";
                storedNumber = int.Parse(tbxResult.Text) + storedNumber;
                tbxResult.Text = "0";
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "+")
            {
                storedNumber += int.Parse(tbxResult.Text);
                tbxResult.Text = storedNumber.ToString();
                operation = "=";
            }
            else if (operation == "-")
            {
                storedNumber -= int.Parse(tbxResult.Text);
                tbxResult.Text = storedNumber.ToString();
                operation = "=";
            }  
            else if (operation == "*")
            {
                storedNumber *= int.Parse(tbxResult.Text);
                tbxResult.Text = storedNumber.ToString();
                operation = "=";
            }
            else if (operation == "/")
            {
                storedNumber /= Convert.ToDouble(tbxResult.Text);
                tbxResult.Text = storedNumber.ToString();
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "+")
            {
                storedNumber += int.Parse(tbxResult.Text);
                tbxResult.Text = "0";
                operation = "-";
            }
            else if (operation == "=")
            {
                operation = "-";
                tbxResult.Text = "0";
            }
            else if (operation == "*")
            {
                storedNumber *= int.Parse(tbxResult.Text);
                operation = "-";
                tbxResult.Text = "0";
            }
            else if (operation == "/")
            {
                storedNumber /= Convert.ToDouble(tbxResult.Text);
                operation = "-";
                tbxResult.Text = "0";
            }
            else
            {
                operation = "-";
                storedNumber -= storedNumber - int.Parse(tbxResult.Text);
                tbxResult.Text = "0";
            }

        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "+")
            {
                storedNumber += int.Parse(tbxResult.Text);
                tbxResult.Text = "0";
                operation = "*";
            }
            else if (operation == "=")
            {
                operation = "*";
                tbxResult.Text = "0";
            }
            else if (operation == "-")
            {
                storedNumber -= int.Parse(tbxResult.Text);
                operation = "*";
                tbxResult.Text = "0";
            }
            else if (operation == "/")
            {
                storedNumber /= Convert.ToDouble(tbxResult.Text);
                operation = "*";
                tbxResult.Text = "0";
            }
            else
            {
                operation = "*";
                storedNumber = int.Parse(tbxResult.Text);
                tbxResult.Text = "0";           
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "+")
            {
                storedNumber += int.Parse(tbxResult.Text);
                tbxResult.Text = "0";
                operation = "/";
            }
            else if (operation == "=")
            {
                operation = "/";
                tbxResult.Text = "0";
            }
            else if (operation == "-")
            {
                storedNumber -= int.Parse(tbxResult.Text);
                operation = "/";
                tbxResult.Text = "0";
            }
            else
            {
                operation = "/";
                storedNumber = int.Parse(tbxResult.Text);
                tbxResult.Text = "0";
            }
        }
    }
}
