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
using System.IO;

namespace CarKits
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        List<Characteristics2> chrc2 = new List<Characteristics2>();
        public Page3()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = new StreamReader("../../audi.txt", Encoding.Default))
                while (!sr.EndOfStream)
                {
                    string brand = sr.ReadLine();
                    string carcase = sr.ReadLine();
                    int capacity = int.Parse(sr.ReadLine());
                    int power = int.Parse(sr.ReadLine());
                    int maxspeed = int.Parse(sr.ReadLine());
                    string gearbox = sr.ReadLine();
                    string engine = sr.ReadLine();
                    double weight = double.Parse(sr.ReadLine());
                    chrc2.Add(new Characteristics2(brand, carcase, capacity, power, maxspeed, gearbox, engine, weight));
                }
            foreach (Characteristics2 crist in chrc2)
                chrc2List.Items.Add(crist.CarInfo2());

        }
    }
}
