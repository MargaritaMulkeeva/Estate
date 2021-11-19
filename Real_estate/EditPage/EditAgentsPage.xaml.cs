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
    /// Логика взаимодействия для EditAgentsPage.xaml
    /// </summary>
    public partial class EditAgentsPage : Page
    {
        public Agents agents = new Agents();
        public EditAgentsPage(Agents _agents)
        {
            InitializeComponent();
            if (_agents != null)
                agents = _agents;
            DataContext = agents;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new RealtorsPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (agents.Id == 0)
                {
                    Real_estate_RitaEntities1.GetContext().Agents.Add(agents);
                }
                Real_estate_RitaEntities1.GetContext().SaveChanges();
                MessageBox.Show("Всё успешно");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
