using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlConcesionario
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Concesionario.xml");
            foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
            {
                if (n1.HasChildNodes)
                {
                    foreach (XmlNode n2 in n1.ChildNodes)
                    {
                        string matricula = n2.Attributes["matricula"].Value;
                        Console.WriteLine("matricula: " + matricula);

                        foreach (XmlNode n3 in n2.ChildNodes)
                        {

                            Console.WriteLine(n3.Name + " " + n3.InnerText);
                        }
                    }
                }
            }
            Console.ReadLine();


        }
    }
}