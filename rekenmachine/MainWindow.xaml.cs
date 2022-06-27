using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Calculator
{
    public partial class MainWindow : Window
    {

        private double Num1 = 0;
        private double Num2 = 0;
        private double Count = 0;
        bool PntBtnActive = false;
        bool DevBtnActive = false;
        bool TimesBtnActive = false;
        bool MinusBtnActive = false;
        bool AddBtnActive = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text.Length > 0)
            {
                if (Count <= 14)
                {
                    input.Text += "0";
                    Count++;
                }
            }
            
        }


        private void Btn1_Click(object sender, RoutedEventArgs e)
        {

            if(Count <= 14)
            {
                input.Text += "1";
                Count++;
            }
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if(Count <= 14)
            {
                input.Text += "2";
                Count++;
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if(Count <= 14)
            {
                input.Text += "3";
                Count++;
            }
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if(Count <= 14)
            {
                input.Text += "4";
                Count++;
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {   
            if(Count <= 14)
            {
                input.Text += "5";
                Count++;
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if(Count <= 14)
            {
                input.Text += "6";
                Count++;
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if(Count <= 14) if(Count <= 15)
            {
                input.Text += "7";
                Count++;
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if(Count <= 14)
            {
                input.Text += "8";
                Count++;
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if(Count <= 14)
            {
                input.Text += "9";
                Count++;
            }
        }

        private void BtnPnt_Click(object sender, RoutedEventArgs e)
        {
            if (PntBtnActive == false)
            {
                input.Text +=".";
                PntBtnActive = true;
                Count = 0;
            }
        }


        private void MultInvBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text, CultureInfo.InvariantCulture);
                calculation.Text = "1/(" + input.Text + ")";
                Num2 = 1 / Num1;
                input.Text = Num2.ToString();
                Count = 0;

                DevBtnActive = false;
                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = false;
            }
        }


        private void PwrBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text, CultureInfo.InvariantCulture);
                calculation.Text = input.Text + "^2";
                Num2 = Num1 * Num1;
                input.Text = Num2.ToString();
                Count = 0;

                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = false;
            }
        }

        private void SqrtBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != null)
            {
                Num1 = double.Parse(input.Text, CultureInfo.InvariantCulture);
                calculation.Text = "\u221A(" + input.Text + ")";
                Num2 = Math.Sqrt(Num1);
                input.Text = Num2.ToString();
                Count = 0;

                DevBtnActive = false;
                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = false;
            }
        }

        private void DevBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != null)
            {
                Num1 = Double.Parse(input.Text, CultureInfo.InvariantCulture);
                calculation.Text = input.Text + "/";
                input.Text = "";
                Count = 0;

                DevBtnActive = true;
                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = false;
            }
        }

        private void TimesBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text, CultureInfo.InvariantCulture);
                calculation.Text = input.Text + "x";
                input.Text = "";
                Count = 0;

                DevBtnActive = false;
                TimesBtnActive = true;
                MinusBtnActive = false;
                AddBtnActive = false;
            }
        }

        private void MinusBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text, CultureInfo.InvariantCulture);
                calculation.Text = input.Text + "-";
                input.Text = "";
                Count = 0;

                DevBtnActive = false;
                TimesBtnActive = false;
                MinusBtnActive = true;
                AddBtnActive = false;
            }
        }


        private void AddBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                Num1 = double.Parse(input.Text, CultureInfo.InvariantCulture);
                calculation.Text = input.Text + "+";
                input.Text = "";
                Count = 0;

                DevBtnActive = false;
                TimesBtnActive = false;
                MinusBtnActive = false;
                AddBtnActive = true;
            }
        }


        private void ResultBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                if ( DevBtnActive == true)
                {
                    Num2 = Num1 / double.Parse(input.Text, CultureInfo.InvariantCulture);
                    calculation.Text = Num1 + "/" + input.Text;
                    input.Text = Num2.ToString();
                }
                else if ( TimesBtnActive == true)
                {
                    Num2 = Num1 * double.Parse(input.Text, CultureInfo.InvariantCulture);
                    calculation.Text = Num1 + "x" + input.Text;
                    input.Text = Num2.ToString();
                }
                else if ( MinusBtnActive == true)
                {
                    Num2 = Num1 - double.Parse(input.Text, CultureInfo.InvariantCulture);
                    calculation.Text = Num1 + "-" + input.Text;
                    input.Text = Num2.ToString();
                }
                else if ( AddBtnActive == true)
                {
                    Num2 = Num1 + double.Parse(input.Text, CultureInfo.InvariantCulture);
                    calculation.Text = Num1 + "+" + input.Text;
                    input.Text = Num2.ToString();
                }
            }

            else if (input.Text == "")
            {
                input.Text = "Can't calculate with zero or nothing";
            }
        }
        private void CansEntrBtn(object sender, RoutedEventArgs e)
        {
            input.Text = "";
            Count = 0;

            PntBtnActive = false;
        }
        
        private void ClearBtn(object sender, RoutedEventArgs e)
        {
            input.Text = "";
            calculation.Text = "";
            Count = 0;

            PntBtnActive = false;
            DevBtnActive = false;
            TimesBtnActive = false;
            MinusBtnActive = false;
            AddBtnActive = false;
        }

        private void BackBtn(object sender, RoutedEventArgs e)
        {
            if (input.Text != "")
            {
                input.Text = input.Text.Remove(input.Text.Length - 1);
                Count--;
            }
        }
        private void ReverseBtn(object sender, RoutedEventArgs e)
        {
            Num1 = 2 * double.Parse(input.Text, CultureInfo.InvariantCulture);
            Num2 = double.Parse(input.Text, CultureInfo.InvariantCulture) - Num1;
            input.Text = Num2.ToString();
        }
    }
}
