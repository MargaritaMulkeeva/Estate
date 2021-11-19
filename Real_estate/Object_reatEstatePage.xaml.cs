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
            DGridDistrict.ItemsSource = Real_estate_RitaEntities1.GetContext().Object_of_realEstate.ToList();
        }
    }
}
