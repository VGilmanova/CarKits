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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        List<Characteristics1> chrc1 = new List<Characteristics1>();
        public Page2()
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
                    chrc1.Add(new Characteristics1(brand, carcase, capacity, power, maxspeed, gearbox, engine, weight));
                }
            foreach (Characteristics1 crist in chrc1)
                chrc1List.Items.Add(crist.CarInfo1());
        }
    }
}
