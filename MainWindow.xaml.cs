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
    }
}
