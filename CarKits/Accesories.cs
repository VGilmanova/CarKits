using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarKits
{
  public  class Accesories
    {
       
        private string interior;

        public string Interior
        {
            get { return interior; }
            set { interior = value; }
        }
        public Accesories( string interior)
        {
            
            Interior = interior;
        }

        
       


    }
}
