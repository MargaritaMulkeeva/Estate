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
    /// Логика взаимодействия для Realtors.xaml
    /// </summary>
    public partial class RealtorsPage : Page
    {
        public RealtorsPage()
        {
            InitializeComponent();
            DGridRealtors.ItemsSource = Real_estate_RitaEntities1.GetContext().Agents.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new MenuPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddPages.AddAgentsPage(null));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var removeAgents = DGridRealtors.SelectedItems.Cast<Agents>().ToList();
            if(MessageBox.Show($"Вы точно хотите удалить следующие {removeAgents.Count()} элементов?", "Внимание", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Real_estate_RitaEntities1.GetContext().Agents.RemoveRange(removeAgents);
                    Real_estate_RitaEntities1.GetContext().SaveChanges();
                    DGridRealtors.ItemsSource = Real_estate_RitaEntities1.GetContext().Agents.ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Real_estate_RitaEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridRealtors.ItemsSource = Real_estate_RitaEntities1.GetContext().Agents.ToList();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new EditPage.EditAgentsPage(DGridRealtors.SelectedItem as Agents));
        }
    }
}
