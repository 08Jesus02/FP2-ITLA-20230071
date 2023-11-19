using System;
using System.Collections.Generic;
using System.Xml;

namespace XMLContacs
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingXmlWriter();
        }

        private static void UsingXmlWriter()
        {
            XmlWriter xmlWriter = XmlWriter.Create("UsingXmlWriter.xml");

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("Contacts");

            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteAttributeString("Phone", "8298412717");
            xmlWriter.WriteString("El Transportador");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteAttributeString("Phone", "8097817346");
            xmlWriter.WriteAttributeString("WorkPhone", "8095789235");
            xmlWriter.WriteString("Toretto");

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
