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


namespace Kreo10
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

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton1 = (RadioButton)sender;
            SayHello.Visibility = Visibility.Visible;
            WeAre.Visibility = Visibility.Hidden;
            TakeALook.Visibility = Visibility.Hidden;
        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton2 = (RadioButton)sender;
            SayHello.Visibility = Visibility.Hidden;
            WeAre.Visibility = Visibility.Visible;
            TakeALook.Visibility = Visibility.Hidden;
        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton3 = (RadioButton)sender;
            SayHello.Visibility = Visibility.Hidden;
            WeAre.Visibility = Visibility.Hidden;
            TakeALook.Visibility = Visibility.Visible;
        }    
    }

   
}
