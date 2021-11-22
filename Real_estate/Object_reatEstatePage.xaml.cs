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
    /// Логика взаимодействия для Object_reatEstate.xaml
    /// </summary>
    public partial class Object_reatEstatePage : Page
    {

        public Object_reatEstatePage()
        {
            InitializeComponent();
            DGridObject.ItemsSource = Real_estate_RitaEntities1.GetContext().Object_of_realEstate.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new MenuPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddPages.AddObjectPage(null));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var removeObject = DGridObject.SelectedItems.Cast<Object_of_realEstate>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {removeObject.Count()} объектов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Real_estate_RitaEntities1.GetContext().Object_of_realEstate.RemoveRange(removeObject);
                    Real_estate_RitaEntities1.GetContext().SaveChanges();
                    DGridObject.ItemsSource = Real_estate_RitaEntities1.GetContext().Object_of_realEstate.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new EditPage.EditObjectPage(DGridObject.SelectedItem as Object_of_realEstate));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                Real_estate_RitaEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridObject.ItemsSource = Real_estate_RitaEntities1.GetContext().Object_of_realEstate.ToList();
            }
        }
    }
}
