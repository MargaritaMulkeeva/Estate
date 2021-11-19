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

namespace Real_estate.AddPages
{
    /// <summary>
    /// Логика взаимодействия для AddDealsPage.xaml
    /// </summary>
    public partial class AddDealsPage : Page
    {
        public AddDealsPage()
        {
            InitializeComponent();
            CBDemand.ItemsSource = Real_estate_RitaEntities1.GetContext().Deals.ToList();
            CBSupply.ItemsSource = Real_estate_RitaEntities1.GetContext().Deals.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new DealPage());
        }
    }
}
