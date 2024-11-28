using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio de lógica para ingresar frases (letra por letra en consola) y todas las vocales "a"
            //ser reemplazadas por la vocal "e"
     
            char[] letras = new char[51];
            Console.WriteLine("Ingrese una frase(Para terminar ingrese un punto: ");
            char letras2;
            letras2 = char.Parse(Console.ReadLine());
            int i = 0;
            while (i < 50 && letras2 != '.')
            {
                letras[i] = letras2;
                letras2 = char.Parse(Console.ReadLine());
                i++;
            }
            letras[i] = '\0';
            for (int x = 0; x < i; x++)
            {
                if (letras[x] == 'a')
                {
                    letras[x] = 'e';
                }
                Console.WriteLine(letras[x]);
            }
            Console.WriteLine("El programa terminó");
            Console.ReadKey();
        }
    }
}
