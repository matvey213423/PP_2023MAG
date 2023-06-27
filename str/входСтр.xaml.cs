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
    /// Логика взаимодействия для входСтр.xaml
    /// </summary>
    public partial class входСтр : Page
    {
        public входСтр()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnect.model0db.Пользователи.FirstOrDefault(x => x.Логин == txbLogin.Text && x.Пароль == psbPassword.Text);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    профиль.пользователь = userObj;
                    MainWindow.Update(профиль.пользователь.ФИО, профиль.пользователь.Звание);
                    if(userObj.Звание == -1)
                    {
                        AppFrame.frameMain.Navigate(new РуководительСТР());
                    }else
                    {
                        AppFrame.frameMain.Navigate(new УчастникСТР());

                    }
                    


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая работа приложения!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new РегистрацияПользователя());
        }
    }
}
