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
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            DGridClients.ItemsSource = Real_estate_RitaEntities1.GetContext().Clients.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new MenuPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddPages.AddClientsPage(null));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var removeClients = DGridClients.SelectedItems.Cast<Clients>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {removeClients.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Real_estate_RitaEntities1.GetContext().Clients.RemoveRange(removeClients);
                    Real_estate_RitaEntities1.GetContext().SaveChanges();
                    DGridClients.ItemsSource = Real_estate_RitaEntities1.GetContext().Clients.ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new EditPage.EditClientsPage(DGridClients.SelectedItem as Clients));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                Real_estate_RitaEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridClients.ItemsSource = Real_estate_RitaEntities1.GetContext().Clients.ToList();
            }
        }
    }
}
