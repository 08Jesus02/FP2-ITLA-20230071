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
            var filename = @"C:\Users\Angel Brito\source\repos\FP2-ITLA-20230071\XMLLinqEjercicio\store.xml";

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