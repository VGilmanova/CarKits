﻿using System;
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
using System.Runtime.Serialization.Formatters.Binary;

namespace CarKits
{
    /// <summary>
    /// Логика взаимодействия для Main1.xaml
    /// </summary>
    public partial class Main1 : Window
    {
        Main2 wnd1;
        
        
       public  List<CustomCars> cars = new List<CustomCars>();
        public Main1(Main2 w1)
        {
            wnd1 = w1;
            InitializeComponent();
            try
            {
                using (FileStream fs = new FileStream(@"../../input.txt", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    string[] data;
                    CustomCars crs;
                    StreamReader sr = new StreamReader(fs, Encoding.Default);
                    while (!sr.EndOfStream)
                    {
                        data = sr.ReadLine().Split(' ');
                        crs = new CustomCars(data[0], data[1], int.Parse(data[2]), data[3], int.Parse(data[4]));
                        cars.Add(crs);
                    }
                    sr.Close();
                    fs.Close();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefreshCarsTXT();
            foreach (CustomCars crs in cars)
                carList.Items.Add(crs);
        }
        public void RefreshCarsTXT()
        {
            try
            {
                using (FileStream fs = new FileStream(@"../../Cars.txt", FileMode.Create, FileAccess.Write))
                {
                    StreamWriter sr = new StreamWriter(fs, Encoding.Default);
                    foreach (CustomCars crs in cars)
                    {
                        sr.Write(crs.Brand + " " + crs.Carcase + " " + crs.Capacity + " " + crs.Gearbox + " " + crs.Maxspeed);
                        sr.WriteLine();
                    }
                    sr.Close();
                    fs.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addCar_Click(object sender, RoutedEventArgs e)
        {
            AddCarNow wnd = new AddCarNow(this);
            wnd.Show();
        }

        private void deleteCar_Click(object sender, RoutedEventArgs e)
        {
            Object crs = carList.SelectedItem;
            carList.Items.Remove(crs);
            cars.Remove((CustomCars)crs);
            RefreshCarsTXT();

        }

        private void searchCar_Click(object sender, RoutedEventArgs e)
        {
            foreach(CustomCars crs in cars)
            {
                if (crs.Brand == searcher.Text)
                {
                    crsInfo.Text = crs.Brand + " " + crs.Carcase + " " + crs.Capacity + " " + crs.Gearbox + " " + crs.Maxspeed;
                    break;
                }
                else
                    MessageBox.Show("Данная машина не найдена!");
            }
        }

        private void saveCartxt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(@"../../" + saving.Text + ".dat", FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter sr = new BinaryFormatter();
                    sr.Serialize(fs, cars);


                }
                MessageBox.Show("Список успешно сохранен и сериалезирован в файл" + " " + saving.Text + ".dat");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void accClick_Click(object sender, RoutedEventArgs e)
        {
            AccCar wnd4 = new AccCar(this);
            wnd4.Show();
        }
    }
}
