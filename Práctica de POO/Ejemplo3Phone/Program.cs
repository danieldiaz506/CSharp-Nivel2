using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3Phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone p1 = new Phone("005", "Samsung");
            Console.WriteLine(p1.Modelo + "                               " + p1.Marca);
            Console.WriteLine("Buen dia, bienvenido a telefono samsung :)");
            Console.WriteLine("Ingrese un numero de telefono: ");
            p1.NumeroTelefono = Console.ReadLine();
            Console.WriteLine("Ingrese un numero de operador: ");
            p1.CodigoOperador = int.Parse(Console.ReadLine());
            while (p1.CodigoOperador == 0)
            {
                Console.WriteLine("Ingrese un operador valido ( 1 al 3): ");
                p1.CodigoOperador = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese el nombre de contacto:");
            string contacto = Console.ReadLine();
            Console.WriteLine(p1.Llamar(contacto));
            Console.ReadKey();

        }
    }
}
