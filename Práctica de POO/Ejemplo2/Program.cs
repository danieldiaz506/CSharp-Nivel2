using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Codigo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Codigo de marca (1 al 10): ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }



        }
    }
}
