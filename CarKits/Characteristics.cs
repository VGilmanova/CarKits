using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarKits
{
    class Characteristics
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


    }
}
