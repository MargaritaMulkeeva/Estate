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
using System.Windows.Shapes;

namespace Real_estate
{
    /// <summary>
    /// Логика взаимодействия для Cap.xaml
    /// </summary>
    public partial class Cap : Window
    {
        public Cap()
        {
            InitializeComponent();
            Manager.frame.Navigate(new MenuPage());
        }
    }
}
