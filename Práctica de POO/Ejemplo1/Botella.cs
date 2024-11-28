using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        public Botella (string material, string color)
        {
            this.material = material;
            this.color = color;
            capacidad = 100;
        }
        public Botella () { }
        
        private int capacidad;
        private string material;
        private string color;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
            set { cantidadActual = value; }
        }

        //Métodos
        public float Recargar()
        {
            int dif = capacidad - cantidadActual;
            float monto = (dif * 50) / 100;
            cantidadActual += dif;
            return monto;

        }  
        
        public float Recargar(int n)
        {
            float monto = (n * 50) / capacidad;
            cantidadActual += n;
            return monto;
        }
    }
}
