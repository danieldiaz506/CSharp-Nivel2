using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCollection
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string nombre { get; set; }

        public virtual string Torque()
        {
            return "Nm";
        }
 
    }
}
