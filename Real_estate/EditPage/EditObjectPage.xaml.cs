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
    /// Логика взаимодействия для EditObjectPage.xaml
    /// </summary>
    public partial class EditObjectPage : Page
    {

        public Object_of_realEstate _object = new Object_of_realEstate();
        public EditObjectPage(Object_of_realEstate object_)
        {
            InitializeComponent();
            if (object_ != null)
                _object = object_;
            DataContext = _object;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new Object_reatEstatePage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                if (TbDistrict.Text != "")
                {
                    string[] text = TbDistrict.Text.Split(',');
                    if (text.Length == 2)
                    {
                        double coordinate1 = Convert.ToDouble(text[0]);
                        double coordinate2 = Convert.ToDouble(text[1]);
                        if (coordinate1 <= 90 && coordinate1 >= -90 && coordinate2 <= 180 && coordinate2 >= -180 && CBType.SelectedItem != null)
                        {
                            District _district = new District();
                            _district.Area = TbDistrict.Text;
                            Real_estate_RitaEntities1.GetContext().District.Add(_district);

                        }
                        else
                            MessageBox.Show("Вы ввели некорректные координаты или не выбрали тип", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                        MessageBox.Show("Вы ввели некорректные координаты", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                if (_object.Id == 0)
                {
                    Real_estate_RitaEntities1.GetContext().Object_of_realEstate.Add(_object);
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
