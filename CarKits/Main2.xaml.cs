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

namespace CarKits
{
    /// <summary>
    /// Логика взаимодействия для Main2.xaml
    /// </summary>
    public partial class Main2 : Window
    {
        public Main2()
        {
            InitializeComponent();
        }

        private void BWW_btn(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page1();
        }
        private void AUDI_btn(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }
        private void LADA_btn(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page3();
        }
        private void SUZUKI_btn(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page4();
        }
        private void add1Car_Click(object sender, RoutedEventArgs e)
        {
            Main1 wnd1 = new Main1(this);
            wnd1.Show();
        }
    }
}
