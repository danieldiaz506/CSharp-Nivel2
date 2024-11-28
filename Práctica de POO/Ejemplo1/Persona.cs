using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        //Persona: edad, sueldo, nombre
        // La clase tiene atributos que nos permiten guardar información de la persona en este caso
        private int edad;
        private string nombre;
        
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }
        //Metodos
        public string Saludar()
        {
            return "Hola soy " + nombre;
        }

        public string Saludar(string nombre)
        {
            return "Hola " + nombre + ", soy " + this.nombre;
        }
    }
}
