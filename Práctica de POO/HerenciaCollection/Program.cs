using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motocicleta m1 = new Motocicleta();
            Auto a1 = new Auto();
            m1.Color = "Azul escarchado";
            a1.Color = "Rojo Perla";
            m1.nombre = "MT09";
            a1.nombre = "Mazda 3";
            List<Vehiculo> listaMotos = new List<Vehiculo>();
            listaMotos.Add(m1);
            listaMotos.Add(a1); 
            Console.WriteLine("La cantidad de bebes es: " +  listaMotos.Count);
            //Polimorfismo
            foreach (Vehiculo item in listaMotos)
            {
                Console.WriteLine("El torque maximo del vehiculo " + item.nombre + " es " + item.Torque());
                
            }
            List<TwoWheels> twoWheels = new List<TwoWheels>();
            twoWheels.Add(m1);

            Console.WriteLine("El vehiculo " + m1.nombre + " está " + m1.dosRuedas());
            Console.ReadKey();
        }
    }
}
