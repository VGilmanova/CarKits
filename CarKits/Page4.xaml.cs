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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        List<Characteristics3> chrc3 = new List<Characteristics3>();
        public Page4()
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
                    chrc3.Add(new Characteristics3(brand, carcase, capacity, power, maxspeed, gearbox, engine, weight));
                }
            foreach (Characteristics3 crist in chrc3)
                chrc3List.Items.Add(crist.CarInfo3());

        }
    }
}
