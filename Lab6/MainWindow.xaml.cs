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

namespace Lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /// 
    /// 
    /// Student Name: Harpreet Singh
    /// Class MSD Section3 
    /// Subject C# 
    /// Lab 6

    public partial class MainWindow : Window
    {

        int number1 = 0;
        int number2 = 0;
        String operation = "";
        int result = 0;




        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }

        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtDisplay.Text = number2.ToString();
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtDisplay.Text = number2.ToString();
            }

        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtDisplay.Text = number2.ToString();
            }

        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtDisplay.Text = number2.ToString();
            }

        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtDisplay.Text = number2.ToString();
            }

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }

        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtDisplay.Text = number2.ToString();
            }

        }
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txtDisplay.Text = number2.ToString();
            }

        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) ;
                txtDisplay.Text = number2.ToString();
            }

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplayUpper.Text = txtDisplay.Text + " + ";
            txtDisplay.Text = "0";


        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplayUpper.Text = txtDisplay.Text + " - ";
            txtDisplay.Text = "0";

        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "x";
            txtDisplayUpper.Text = txtDisplay.Text + " x ";
            txtDisplay.Text = "0";

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplayUpper.Text = txtDisplay.Text + " / ";
            txtDisplay.Text = "0";

        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplayUpper.Text = number1.ToString() + " + " + number2.ToString();
                    result = number1 + number2;
                    txtDisplay.Text = result.ToString();
                    number1 = result;
                    number2 = 0;
                    break;
                case "-":
                    txtDisplayUpper.Text = number1.ToString() + " - " + number2.ToString();
                    result = number1 - number2;
                    txtDisplay.Text = result.ToString();
                    number1 = result;
                    number2 = 0;
                    break;
                case "x":
                    txtDisplayUpper.Text = number1.ToString() + " x " + number2.ToString();
                    result = number1 * number2;
                    txtDisplay.Text = result.ToString();
                    number1 = result;
                    number2 = 0;
                    break;
                case "/":
                    txtDisplayUpper.Text = number1.ToString() + " / " + number2.ToString();
                    result = number1 / number2;
                    txtDisplay.Text = result.ToString();
                    number1 = result;
                    number2 = 0;
                    break;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";
            txtDisplayUpper.Text = "";
        }

       
    }
}
