using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Semana_1
{
    internal class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad {  get; set; }
        public double estatura { get; set; }
        public double peso { get; set; }

        public string obtenerEstado()
        {
            if (edad >= 18)
            {
                return "mayor de edad";
            }
            else
            {
                return "Menor de edad";
            }
                              
        }

        public double imc()
        {
            return peso / (estatura*estatura);
        }

    }
}
