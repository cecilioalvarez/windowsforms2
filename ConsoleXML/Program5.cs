using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program5
    {
        static void Main(string[] args)
        {

            String cadena = "hola";

            for (int i=0;i<40000;i++)
            {

                cadena = cadena + "hola" + i+ "adios"+ i+ "hola2";
            }
            Console.WriteLine("termino");

            Console.ReadLine();

          

         

        }
    }
}
