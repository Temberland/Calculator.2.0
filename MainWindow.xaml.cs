using System;
using System.Collections.Generic;
using System.Data;
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

namespace Calculator._2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Suda.Text = "0";
        }
        //Кнопка 1
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = Suda.Text;
            Button A = (Button)sender;
            if (Suda.Text[0] == '-')
            {
                Suda.Text = Suda.Text.Substring(1, Suda.Text.Length-1);
            }
            else
            {
                Suda.Text = '-' + Suda.Text;
            }
        }
        //Ниже идут кнопки
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text == "0")
            {
                Suda.Text = "";
            }
            Suda.Text += A.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text == "0")
            {
                Suda.Text = "";
            }
            Suda.Text += A.Content;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text == "0")
            {
                Suda.Text = "";
            }
            Suda.Text += A.Content;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text == "0")
            {
                Suda.Text = "";
            }
            Suda.Text += A.Content;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text == "0")
            {
                Suda.Text = "";
            }
            Suda.Text += A.Content;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text == "0")
            {
                Suda.Text = "";
            }
            Suda.Text += A.Content;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text == "0")
            {
                Suda.Text = "";
            }
            Suda.Text += A.Content;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text == "0")
            {
                Suda.Text = "";
            }
            Suda.Text += A.Content;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text == "0")
            {
                Suda.Text = "";
            }
            Suda.Text += A.Content;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            if (Suda.Text != "0")
            {
                Suda.Text += A.Content;
            }
        }
        //Кнопка CE
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            Suda.Text = "0"; 
        }
        //Кнопка C
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            Verh.Text = "";
            Suda.Text = "0";
        }
        //Кнопка стереть
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            //Verh.Text = "";
            Suda.Text = Suda.Text.Substring(0, Suda.Text.Length-1);
            if (Suda.Text == "") {
                Suda.Text = "0";
            }
        }
        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Button A = (Button)sender;
            //Verh.Text = "";
            bool zap = true;
            for(int i = 0; i < Suda.Text.Length; i++)
            {
                if (Suda.Text[i] == ',')
                {
                    zap = false;
                }
            }
            if (zap == true) { Suda.Text += ","; }

        }
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (Verh.Text == "")
            {
                Verh.Text = Suda.Text + "+";
                Suda.Text = "0";
            }
            if ((Verh.Text[Verh.Text.Length - 1] == '×') || (Verh.Text[Verh.Text.Length - 1] == '-') || (Verh.Text[Verh.Text.Length - 1] == '÷'))
            {
                Verh.Text = Verh.Text.Substring(0, Verh.Text.Length - 1) + "+";
            }

        }
        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            if (Verh.Text == "")
            {
                Verh.Text = Suda.Text + "-";
                Suda.Text = "0";
            }
            if ((Verh.Text[Verh.Text.Length - 1] == '+') || (Verh.Text[Verh.Text.Length - 1] == '+') || (Verh.Text[Verh.Text.Length - 1] == '÷'))
            {
                Verh.Text = Verh.Text.Substring(0, Verh.Text.Length - 1) + "-";
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            if (Verh.Text == "")
            {
                Verh.Text = Suda.Text + "×";
                Suda.Text = "0";
            }
            if ((Verh.Text[Verh.Text.Length - 1] == '+') || (Verh.Text[Verh.Text.Length - 1] == '-') || (Verh.Text[Verh.Text.Length - 1] == '÷'))
            {
                Verh.Text = Verh.Text.Substring(0, Verh.Text.Length - 1) + "×";
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            if (Verh.Text == "")
            {
                Verh.Text = Suda.Text + "÷";
                Suda.Text = "0";
            }
            if ((Verh.Text[Verh.Text.Length - 1] == '×') || (Verh.Text[Verh.Text.Length - 1] == '-') || (Verh.Text[Verh.Text.Length - 1] == '÷'))
            {
                Verh.Text = Verh.Text.Substring(0, Verh.Text.Length - 1) + "÷";
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            Suda.Text = Verh.Text + Suda.Text;
            Suda.Text = Suda.Text.Replace(",", ".");
            Suda.Text = Suda.Text.Replace("÷", "/");
            Suda.Text = Suda.Text.Replace("×", "*");
            Verh.Text = "";
            string value = new DataTable().Compute(Suda.Text, null).ToString();
            Suda.Text = value;
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            Suda.Text = Suda.Text + "*" + Suda.Text;
            Suda.Text = Suda.Text.Replace(",", ".");
            string value = new DataTable().Compute(Suda.Text, null).ToString();
            Suda.Text = value;

        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            if (Suda.Text[Suda.Text.Length-1] != '-')
            {
                //Suda.Text = "Math.Sqrt(" + Suda.Text + ")";
                //Suda.Text = Suda.Text.Replace(",", ".");
                //string value = new DataTable().Compute(Suda.Text, null).ToString();
                //Suda.Text = value;

                double number = double.Parse(Suda.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                double result = Math.Sqrt(number);
                Suda.Text = result.ToString();
            }
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            Suda.Text = "1/" + Suda.Text;
            Suda.Text = Suda.Text.Replace(",", ".");
            string value = new DataTable().Compute(Suda.Text, null).ToString();
            Suda.Text = value;
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {

        }
    }
}
