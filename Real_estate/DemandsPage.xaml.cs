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
    /// Логика взаимодействия для DemandsPage.xaml
    /// </summary>
    public partial class DemandsPage : Page
    {
        public DemandsPage()
        {
            InitializeComponent();
            DGridDemands.ItemsSource = Real_estate_RitaEntities1.GetContext().Demands.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new MenuPage());
        }
    }
}
