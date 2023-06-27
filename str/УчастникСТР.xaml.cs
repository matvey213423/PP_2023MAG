using PP_2023MAG.baza;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для УчастникСТР.xaml
    /// </summary>
    public partial class УчастникСТР : Page
    {
        public УчастникСТР()
        {
            InitializeComponent();
            DGridKlients.ItemsSource = PPMAG_20023Entities1.GetContext().Пользователи.ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new входСтр());
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate( new ЗаписьДостижений(null));
        }
    }
}
