using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3Phone
{
    internal class Phone
    {
        public Phone(string modelo, string marca) 
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        
        private string modelo;
        private string marca;
        private int codigoOperador;

        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefono { get; set; }
        
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto + "....";
        }
    }
}
