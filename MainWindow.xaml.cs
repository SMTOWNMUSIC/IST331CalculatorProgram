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

namespace IST331CalculatorProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String memory;
        bool AfterOperation = false;
        public double number1 = 0, number2, result = 0;
        char operation = '+';
        double memorySaveValue = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Calculator Memory Clear 
        private void buttonMemoryClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxDisplay.Text = "";
        }

        // Calculator Memory Read  
        private void buttonMemoryRead_Click(object sender, RoutedEventArgs e)
        {
            textBoxDisplay.Text = memory;
        }

        // Calculator Memory Save
        private void buttonMemorySave_Click(object sender, RoutedEventArgs e)
        {
            memory = textBoxDisplay.Text;
        }

        // Calculator Memory Plus 
        private void buttonMemoryPlus_Click(object sender, RoutedEventArgs e)
        {
            String getString = textBoxDisplay.Text;
            if(getString.Length !=0)
            {
                memorySaveValue = memorySaveValue + Double.Parse(getString);
            }
        }

        // Calculator Memory Minus
        private void buttonMemoryMinus_Click(object sender, RoutedEventArgs e)
        {
            String getString = textBoxDisplay.Text;
            if(getString.Length !=0)
            {
                memorySaveValue = memorySaveValue + Double.Parse(getString);
            }
        }

        // Calculator Clear All
        private void buttonClearAll_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBoxDisplay.Clear();
            }
            catch
            {

            }
        }

        // Calculator Back 
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Substring(0, textBoxDisplay.Text.Length - 1);
            }
            catch
            {

            }
        }

        // Calculator Clear
        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Substring(0, textBoxDisplay.Text.Length - 1);
            }
            catch
            {

            }
        }
  
        // Calculator Numbers
        private void buttonSeven_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 7;
            }
            catch { }
        }

        private void buttonEight_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 8;
            }
            catch { }
        }

        private void buttonNine_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 9;
            }
            catch { }
        }

        private void buttonFour_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 4;
            }
            catch { }
        }
  
        private void buttonFive_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 5;
            }
            catch { }
        }

        private void buttonSix_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 6;
            }
            catch { }
        }

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 1;
            }
            catch { }
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 2;
            }
            catch { }
        }
        private void buttonThree_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 3;
            }
            catch { }
        }

        private void buttonZero_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Verify();
                textBoxDisplay.Text += 0;
            }
            catch { }
        }

        // Calculator Functions
        private void buttonDivision_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(textBoxDisplay.Text);
            operation = '/';
            textBoxDisplay.Clear();
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(textBoxDisplay.Text);
            operation = '*';
            textBoxDisplay.Clear();
        }

        private void buttonReciprocal_Click(object sender, RoutedEventArgs e)
        {
            textBoxDisplay.Text = "1/(" + textBoxDisplay.Text + ")";
            textBoxDisplay.Text = (1 / Double.Parse(textBoxDisplay.Text)).ToString();
        }
    
        private void buttonDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxDisplay.Text.Contains("."))
                return;
            else
                textBoxDisplay.Text += ".";
        }

        private void buttonAddition_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(textBoxDisplay.Text);
            operation = '+';
            textBoxDisplay.Clear();
        }

        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(textBoxDisplay.Text);
            operation = '%';
            textBoxDisplay.Clear();
        }

        private void buttonSubtraction_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(textBoxDisplay.Text);
            operation = '-';
            textBoxDisplay.Clear();
        }

        private void buttonCubicRoot_Click(object sender, RoutedEventArgs e)
        {
            if((textBoxDisplay.Text).Length !=0)
            {
                number1 = Convert.ToDouble(textBoxDisplay.Text);
                if (number1 >= 0)
                {
                    textBoxDisplay.Text = Convert.ToString(Math.Sqrt(number1));
                }
                else
                {
                    textBoxDisplay.Text = "Error";
                }
            }
        }

        private void buttonSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            if((textBoxDisplay.Text).Length !=0)
            {
                number1 = Convert.ToDouble(textBoxDisplay.Text);
                if(number1 >= 0)
                {
                    textBoxDisplay.Text = Convert.ToString(Math.Sqrt(number1));
                }
                else
                {
                    textBoxDisplay.Text = "Error";
                }
            }
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AfterOperation = true;
                number2 = Convert.ToDouble(textBoxDisplay.Text);

                switch (operation)
                {
                    case '+':
                        result = number1 + number2;
                        break;
                    case '-':
                        result = number1 - number2;
                        break;
                    case '*':
                        result = number1 * number2;
                        break;
                    case '/':
                        result = number1 / number2;
                        break;
                    case '%':
                        result = number1 % number2;
                        break;
                }
                textBoxDisplay.Text = result.ToString();
            }
            catch { }

        }

        // Verify 
        public void Verify()
        {
            if (AfterOperation == true)
            {
                textBoxDisplay.Clear();
                AfterOperation = false;
            }
        }

    }
}
