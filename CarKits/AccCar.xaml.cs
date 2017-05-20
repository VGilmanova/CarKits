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
using System.IO;

namespace CarKits
{
    /// <summary>
    /// Логика взаимодействия для AccCar.xaml
    /// </summary>
    public partial class AccCar : Window
    {
        Main1 wnd4;
        public List<Accesories> acc = new List<Accesories>();
        public AccCar(Main1 w4)
        {
            wnd4 = w4;
            InitializeComponent();
            try
            {
                using (FileStream fs = new FileStream(@"../../acc.txt", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    string[] data;
                    Accesories accs;
                    StreamReader sr = new StreamReader(fs, Encoding.Default);
                    while (!sr.EndOfStream)
                    {
                        data = sr.ReadLine().Split(' ');
                        accs = new Accesories(data[0]);
                        acc.Add(accs);
                    }
                    sr.Close();
                    fs.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Accesories accs in acc)
                accList.Items.Add(accs);
        }
        
       
    }
}
