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

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if(tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = "9";
            }
            else
            {
                tbxResult.Text = tbxResult.Text + "9";
            }
        }

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
        }
    }
}
