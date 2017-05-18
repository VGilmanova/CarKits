using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarKits
{
    [Serializable]
   public class CustomCars
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
        private string gearbox;

        public string Gearbox
        {
            get { return gearbox; }
            set { gearbox = value; }
        }
        private int maxspeed;

        public int Maxspeed
        {
            get { return maxspeed; }
            set { maxspeed = value; }
        }
        public CustomCars(string brand, string carcase, int capacity, string gearbox,int maxspeed)
        {
            Brand = brand;
            Carcase = carcase;
            Capacity = capacity;
            Gearbox = gearbox;
            Maxspeed = maxspeed;
           
            
        }

    }
}
