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
using System.Runtime.Serialization.Formatters.Binary;

namespace CarKits
{
    /// <summary>
    /// Логика взаимодействия для AddCarNow.xaml
    /// </summary>
    public partial class AddCarNow : Window
    {
        Main1 wnd;
        public AddCarNow(Main1 w)
        {
            wnd = w;
            InitializeComponent();
        }

        private void addFinalCar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CustomCars crs = new CustomCars(newbrand.Text, newcarcase.Text, int.Parse(newcapacity.Text), newgearbox.Text, int.Parse(newmaxspeed.Text));
                wnd.cars.Add(crs);
                wnd.carList.Items.Add(crs);
                wnd.RefreshCarsTXT();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
            this.Close();
        }
    }
}
