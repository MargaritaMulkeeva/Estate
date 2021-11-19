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
    /// Логика взаимодействия для AddAgentsPage.xaml
    /// </summary>
    public partial class AddAgentsPage : Page
    {
        private Agents _currentAgents = new Agents();
        public AddAgentsPage(Agents agents)
        {
            InitializeComponent();
            if (agents != null)
                _currentAgents = agents;
            DataContext = _currentAgents;

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new RealtorsPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((TbLastName.Text!=""&&TbMiddledName.Text!=""&&TbName.Text!="")
                &&(0<=Convert.ToInt32(TbDeals.Text))&& Convert.ToInt32(TbDeals.Text) < 100)
            {
                if (_currentAgents.Id == 0)
                {
                    Real_estate_RitaEntities1.GetContext().Agents.Add(_currentAgents);
                    Real_estate_RitaEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Информация успешно добавлена", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                    MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Неправильно заполнены поля", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
