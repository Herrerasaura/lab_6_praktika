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

namespace lab_6_Sav
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BlueFont(object sender, RoutedEventArgs e)
        {
            text1.Style = (Style)Resources["BlueText"];
            text2.Style = (Style)Resources["BlueText"];
        }

        private void RedFont(object sender, RoutedEventArgs e)
        {
            text1.Style = (Style)Resources["RedText"];
            text2.Style = (Style)Resources["RedText"];
        }

        private void NormalFont(object sender, RoutedEventArgs e)
        {
            text1.Style = (Style)Resources["NormalText"];
            text2.Style = (Style)Resources["NormalText"];
        }

        private void Open(object sender, RoutedEventArgs e)
        {
            text1.Visibility = Visibility.Visible;
            text2.Visibility = Visibility.Visible;
        }

        private void Clean(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            if (text1.Text == "" & text2.Text == "")
            {
                text1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("You have some text in your textboxes");
            }
        }
    }
}
