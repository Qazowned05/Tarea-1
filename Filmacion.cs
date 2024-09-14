using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_1
{
    internal class Filmacion
    {
        public int codigo {  get; set; }    
        public  string titulo { get; set; }
        public int duracion { get; set; }
        public double priceSoles { get; set; }


        public double getPriceDollars()
        {
            return priceSoles / 3.59;
        }
    }
}
