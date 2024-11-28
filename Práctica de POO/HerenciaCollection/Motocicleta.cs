using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCollection
{
    internal class Motocicleta : Vehiculo, TwoWheels
    {
        
        
        
        public string dosRuedas()
        {
            return "Andando en dos ruedas...";
        }

        public override string Torque()
        {
            return "119 Nm";
        }
    }
}
