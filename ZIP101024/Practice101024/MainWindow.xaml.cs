using System;
using System.Collections.Generic;
using System.Data;
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

namespace Practice101024
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool flag = true;
        public MainWindow()
        {
            InitializeComponent();
            textBox_main.Text = "";
        }



        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text = string.Empty;
        }


        private void button_backspace_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_main.Text.Length>0) textBox_main.Text = textBox_main.Text.Substring(0, textBox_main.Text.Length-1);
        }

        private void button_one_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "1";
        }

        private void button_two_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "2";
        }

        private void button_three_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "3";
        }

        private void button_four_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "4";
        }

        private void button_five_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "5";
        }

        private void button_six_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "6";
        }

        private void button_seven_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "7";
        }

        private void button_eight_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "8";
        }

        private void button_nine_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "9";
        }

        private void button_zero_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "0";
        }

        private void button_plusOrMinus_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_main.Text.Length > 0 && textBox_main.Text[0] == '-')
            {
                textBox_main.Text = textBox_main.Text.Substring(1, textBox_main.Text.Length-1);
            }
            else
            {
                textBox_main.Text = '-' + textBox_main.Text;
            }
        }

        private void button_double_Click(object sender, RoutedEventArgs e)
        {
            if (flag && textBox_main.Text[textBox_main.Text.Length-1]!='+' && textBox_main.Text[textBox_main.Text.Length - 1] != '-' && textBox_main.Text[textBox_main.Text.Length - 1] != '*' && textBox_main.Text[textBox_main.Text.Length - 1] != '/')
            textBox_main.Text += ',';
            flag = false;
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += '+';
            flag = true;
        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += '-';
            flag = true;
        }

        private void button_multiplication_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += '*';
            flag = true;
        }
        private void button_divide_Click(object sender, RoutedEventArgs e)
        {
            textBox_main.Text += "/";
            flag = true;
        }

        private void button_result_Click(object sender, RoutedEventArgs e)
        {
            string task = textBox_main.Text.Replace(',','.');
            MessageBox.Show(new DataTable().Compute(task, null).ToString());
        }
    }

}
