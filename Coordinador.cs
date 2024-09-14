using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_1
{
    internal class Coordinador
    {

        public int codigo {  get; set; }
        public string nombre { get; set; }
        public int categoria { get; set; }
        public int celular { get; set; }


        public double getSueldo()
        {
            if (categoria == 0)
            {
                return 8500;
            }
            else if (categoria == 1)
            {
                return 6850;

            }else if (categoria == 2) 
            {
                return 5500;
            }
            else
            {
                return 0;
            }

        }
    }
}
