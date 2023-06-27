using PP_2023MAG.baza;
using PP_2023MAG.str;
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

namespace PP_2023MAG
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.model0db = new PPMAG_20023Entities1();
            AppFrame.frameMain = myFRM;

            myFRM.Navigate(new входСтр());
        }

        

        

        static public void Update(string FFIO, int zzvanie)
        {
            

        }
    }
}
