using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms001
{
    class Persona
    {
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get; set; }
        public int edad { get; set; }
    }
}
