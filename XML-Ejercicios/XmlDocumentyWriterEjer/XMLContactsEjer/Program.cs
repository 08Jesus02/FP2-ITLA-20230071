using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace XMLContacs
{
    class Program
    {
        static void Main(string[] args)
        {
            // UsingXmlWriter();
            UsingXmlDocument();
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

        private static void UsingXmlDocument()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode rootNode = xmlDoc.CreateElement("Contacs");
            xmlDoc.AppendChild(rootNode);

            XmlNode contactNode = xmlDoc.CreateElement("Contact");
            XmlAttribute attribute = xmlDoc.CreateAttribute("Phone");
            attribute.Value = "8298412717";
            contactNode.Attributes.Append(attribute);
            contactNode.InnerText = "El Transportador";
            rootNode.AppendChild(contactNode);

            contactNode = xmlDoc.CreateElement("Contact");
            attribute = xmlDoc.CreateAttribute("Phone");
            attribute.Value = "8097817346";
            contactNode.Attributes.Append(attribute);
            attribute = xmlDoc.CreateAttribute("WorkPhone");
            attribute.Value = "8095789235";
            contactNode.Attributes.Append(attribute);
            contactNode.InnerText = "Torretto";
            rootNode.AppendChild(contactNode);

            xmlDoc.Save("UsingXmlDocument.xml");
        }
    }
}
