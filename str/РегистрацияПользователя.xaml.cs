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
using System.Xml.Linq;

namespace PP_2023MAG.str
{
    /// <summary>
    /// Логика взаимодействия для РегистрацияПользователя.xaml
    /// </summary>
    public partial class РегистрацияПользователя : Page
    {
        public РегистрацияПользователя()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (AppConnect.model0db.Пользователи.Count(x => x.Логин == txbLogin.Text) > 0)
            {
                MessageBox.Show("Пользователь с таким логином есть!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                Пользователи userObj = new Пользователи()
                {
                    Логин = txbLogin.Text,
                    ФИО = txbName.Text,
                    Пароль = txtPass.Text,
                    Звание = 0,
                    Телефон = long.Parse(тел.Text)
                
                };
                AppConnect.model0db.Пользователи.Add(userObj);
                AppConnect.model0db.SaveChanges();
                MessageBox.Show("Данные успешно добавлены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }
    }
}
