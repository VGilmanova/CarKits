using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarKits
{
    class Characteristics2
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private string carcase;

        public string Carcase
        {
            get { return carcase; }
            set { carcase = value; }
        }
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        private int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        private int maxspeed;

        public int Maxspeed
        {
            get { return maxspeed; }
            set { maxspeed = value; }
        }

        private string gearbox;

        public string Gearbox
        {
            get { return gearbox; }
            set { gearbox = value; }
        }
        private string engine;

        public string Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Characteristics2(string brand, string carcase, int capacity, int power, int maxspeed, string gearbox, string engine, double weight)
        {
            Brand = brand;
            Carcase = carcase;
            Capacity = capacity;
            Power = power;
            Maxspeed = maxspeed;
            Gearbox = gearbox;
            Engine = engine;
            Weight = weight;
        }
        public string CarInfo2()
        {
            return string.Format("Марка: {0}  |  Кузов: {1}  |  Объем: {2} см^3  |  Мощность: {3}л.с.  | Макс.скорость: {4}км/ч  | Коробка передач: {5}  | Топливо: {6}  | Масса: {7} |");
        }

    }
}
