using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Filmacion data = new Filmacion();
            data.codigo = 005647;
            data.duracion = 45;
            data.titulo = "Diego Video";
            data.priceSoles = 50;


            Console.WriteLine("el video " + '"' + data.titulo + '"' + " con código " + data.codigo + " dura "
                + data.duracion + " minutos, el costo es de: $" + 
                data.getPriceDollars() );

       

            Persona prop = new Persona();
            prop.nombre = "Diego";
            prop.apellido = "Rivera Paz";
            prop.edad = 17;
            prop.estatura = 1.80;
            prop.peso = 90;

            Console.WriteLine("el IMC de " + prop.nombre + " " + prop.apellido + " es de: " + prop.imc());

            Console.WriteLine("Diego es " + prop.obtenerEstado());

            


            Coordinador atri = new Coordinador();
            atri.categoria = 0;
            atri.codigo = 054;
            atri.celular = 917287980;
            atri.nombre = "Eduardo Rivera";

            Console.WriteLine("el sueldo de " + atri.nombre + " con código " + atri.codigo + " es de: s/." + atri.getSueldo());

            Console.ReadKey();
        }
    }
}
