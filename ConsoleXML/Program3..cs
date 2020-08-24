using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program3
    {
        static void Main(string[] args)
        {


            XmlReader lector = new XmlTextReader("../../PersonaNueva.xml");
            int total = 0;
            while (lector.Read())
            {
                //Console.WriteLine(lector.Name);

                if (lector.NodeType==XmlNodeType.Element)
                {

                    if (lector.Name.Equals("edad"))
                    {
                       lector.Read();
                       total+=Convert.ToInt32(lector.Value);
                       
                    }
                }
            }

            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
