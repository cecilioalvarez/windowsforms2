using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument documento = new XmlDocument();
            XmlElement elemento = 
                documento.CreateElement("persona");
            documento.AppendChild(elemento);
            XmlElement nombre =
                documento.CreateElement("nombre");
            nombre.InnerText = "pedro";
            elemento.AppendChild(nombre);

           XmlAttribute attributo= documento.CreateAttribute("telefono");
            attributo.InnerText = "123456";
            elemento.Attributes.Append(attributo);
            XmlElement apellidos =
                documento.CreateElement("apellidos");
            apellidos.InnerText = "alvarez";
            elemento.AppendChild(apellidos);

            XmlElement edad =
                documento.CreateElement("edad");
            edad.InnerText = "20";
            elemento.AppendChild(edad);
            XmlWriter escritor = 
                new XmlTextWriter("persona.xml",null);
            documento.Save(escritor);
            Console.ReadLine();

        }
    }
}
