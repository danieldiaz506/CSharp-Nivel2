using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int edad;
            //string nombre;
            //int capacidad;
            Botella b1 = new Botella("Plastico", "Transparente");
            Persona p1 = new Persona("Alejo");
            p1.setEdad(23);
            Console.WriteLine(p1.Saludar("Karime"));
            Console.WriteLine("Mi edad es: " + p1.getEdad() + " años y lo ayudare a cargar la botella.");
            Console.WriteLine("Ingrese la cantidad actual de su botella : ");
            b1.CantidadActual = int.Parse(Console.ReadLine());
            while (b1.CantidadActual < 0 || b1.CantidadActual > 99)
            {
                Console.WriteLine("Ingrese un valor correcto( 0 a 99): ");
                b1.CantidadActual = int.Parse(Console.ReadLine());


            }
            Console.WriteLine("Ingrese el valor que desea recargar: ");
            int valorD = int.Parse(Console.ReadLine());
            Console.WriteLine("El precio por recargar su botella fue: " + b1.Recargar(valorD) + " pesos.");
            Console.WriteLine("La cantidad actual ahora es: " + b1.CantidadActual);

            Console.ReadKey();

        }
    }
}
