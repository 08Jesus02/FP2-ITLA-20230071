using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XMLLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = @"/Users/angelj.soriano/Todo ITLA/3/Fundamentos de Programacion 2/FP2-ITLA-20230071/XML-Ejercicios/XMLLinqEjercicio/store.xml";

            XElement storeXML = XElement.Load(filename);

            var beers = from e in storeXML.Element("beers").Elements("beer")
                        select e;

            foreach (var beer in beers)
            {
                Console.WriteLine(beer.Value);
            }
        }
    }
}