using PP_2023MAG.baza;
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

namespace PP_2023MAG.str
{
    /// <summary>
    /// Логика взаимодействия для ЗаписьДостижений.xaml
    /// </summary>
    public partial class ЗаписьДостижений : Page
    {
        private Достижения _currentHotel = new Достижения();
        public ЗаписьДостижений(Достижения selectedHotel)
        {
            InitializeComponent();
            if (selectedHotel != null)
                _currentHotel = selectedHotel;

            DataContext = _currentHotel;
            if (профиль.пользователь.Звание != -1)
            {
                прогресс.IsEnabled = false;
                прогресс.Visibility = Visibility.Hidden;
                прогрессНадпись.Visibility = Visibility.Hidden;
                _currentHotel.Статус = "Создано";
                _currentHotel.КолличествоОчковПрогресса = 0;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_currentHotel.Номер == 0)
                PPMAG_20023Entities1.GetContext().Достижения.Add(_currentHotel);

            try
            {
                _currentHotel.Дата = DateTime.Now;
                
                if (профиль.пользователь.Звание == -1)
                {
                    _currentHotel.Статус = "Проверено";
                    var userObj = AppConnect.model0db.Пользователи.FirstOrDefault(x => x.ФИО == _currentHotel.Участник);

                    Пользователи пользователь = userObj;
                    пользователь.Звание += int.Parse(прогресс.Text);
                    AppConnect.model0db.SaveChanges();
                    PPMAG_20023Entities1.GetContext().SaveChanges();
                }
                else
                {
                    _currentHotel.Участник = профиль.пользователь.ФИО;
                }

                PPMAG_20023Entities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                AppFrame.frameMain.Navigate(new УчастникСТР());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
