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
    /// Логика взаимодействия для WebBr.xaml
    /// </summary>
    public partial class WebBr : Window
    {
        Main2 wnd5;
        public WebBr(Main2 w5)
        {
            wnd5 = w5;
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                myWeb.Source = new Uri("http://www.google.com");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myWeb.GoForward();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myWeb.GoBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            myWeb.Source = new Uri("http://" + search.Text);
        }
    }
}
