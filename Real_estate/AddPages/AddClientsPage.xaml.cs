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
    /// Логика взаимодействия для AddClientsPage.xaml
    /// </summary>
    public partial class AddClientsPage : Page
    {

        private Clients _currentClients = new Clients();
        public AddClientsPage(Clients clients)
        {
            InitializeComponent();
            if (clients != null)
                _currentClients = clients;

            DataContext = _currentClients;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new ClientPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((TbEmail.Text == "" && TbPhone.Text != "") || (TbEmail.Text != "" && TbPhone.Text == "") || (TbEmail.Text != "" && TbPhone.Text != ""))
            {
                if (_currentClients.Id == 0)
                    Real_estate_RitaEntities1.GetContext().Clients.Add(_currentClients);
                Real_estate_RitaEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация успешно добавлена", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
