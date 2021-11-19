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

namespace Real_estate
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new ClientPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new RealtorsPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new DemandsPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new SuppliesPage());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new DealPage());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new Object_reatEstatePage());
        }
    }
}
