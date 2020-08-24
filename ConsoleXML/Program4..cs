using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program4
    {
        static void Main(string[] args)
        {

            XmlReader lector = new XmlTextReader("../../PersonaNueva.xml");
            int total = 0;
            List<Persona> lista = new List<Persona>();
            Persona p = new Persona(); 
            while (lector.Read())
            {

                if (lector.NodeType == XmlNodeType.Element)
                {
                    if (lector.Name.Equals("nombre"))
                    {
                        lector.Read();
                        p.Nombre = lector.Value;
                    }
                    else if (lector.Name.Equals("apellidos"))
                    {
                        lector.Read();
                        p.Apellidos = lector.Value;

                    }
                    else if (lector.Name.Equals("edad")) {

                        lector.Read();
                        p.Edad = Convert.ToInt32(lector.Value);
                        lista.Add(p);
                        p = new Persona();
                    }
                   

                    
                }

            }

            foreach (Persona persona in lista)
            {
                Console.WriteLine(persona.Nombre);
                Console.WriteLine(persona.Apellidos);
                Console.WriteLine(persona.Edad);
            }

            //Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
