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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        List<Characteristics> chrc = new List<Characteristics>();
        public Page1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("../../bmw.txt", Encoding.Default))
                    while (!sr.EndOfStream)
                    {
                        string brand = sr.ReadLine();
                        string carcase = sr.ReadLine();
                        int capacity = int.Parse(sr.ReadLine());
                        int power = int.Parse(sr.ReadLine());
                        int maxspeed = int.Parse(sr.ReadLine());
                        string gearbox = sr.ReadLine();
                        string engine = sr.ReadLine();
                        int weight = int.Parse(sr.ReadLine());
                        chrc.Add(new Characteristics(brand, carcase, capacity, power, maxspeed, gearbox, engine, weight));
                    }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Characteristics crist in chrc)
                chrcList.Items.Add(crist.CarInfo());
        }
    }
}
