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
    /// Логика взаимодействия для РуководительСТР.xaml
    /// </summary>
    public partial class РуководительСТР : Page
    {
        public РуководительСТР()
        {
            InitializeComponent();
            DGridKlients.ItemsSource = PPMAG_20023Entities1.GetContext().Достижения.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate( new УчастникСТР());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Достижения hotelsForRemoving = (Достижения)DGridKlients.SelectedItems[0];
            AppFrame.frameMain.Navigate(new ЗаписьДостижений(hotelsForRemoving));
        }
    }
}
