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

namespace Real_estate.EditPage
{
    /// <summary>
    /// Логика взаимодействия для EditClientsPage.xaml
    /// </summary>
    public partial class EditClientsPage : Page
    {
        public Clients clients = new Clients();
        public EditClientsPage(Clients _clients)
        {
            InitializeComponent();
            if (_clients != null)
                clients = _clients;
            DataContext = clients;
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new ClientPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (clients.Id == 0)
                {
                    Real_estate_RitaEntities1.GetContext().Clients.Add(clients);
                }

                Real_estate_RitaEntities1.GetContext().SaveChanges();
                MessageBox.Show("Всё успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
