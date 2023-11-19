using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XMLContacs
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingXMLWriter();
        }

        private static void UsingXMLWriter()
        {
            XmlWriter xmlWriter = xmlWriter.Create("UsingXmlWriter.xml");

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("Contacts");

            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteAttributeString("Phone", "8298412717");
            xmlWriter.WriteString("El Transportador");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteAttributeString("Phone", "8097817346");
            xmlWriter.WhiteAttributeString("WorkPhone", "8095789235");
            xmlWriter.WriterString("Toretto");

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}