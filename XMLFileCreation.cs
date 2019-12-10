using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace InformationEncoding_FinalProject
{
    class XMLFileCreation
    {
        public void createXMLFile(IList<string> studentProfile)
        {
            using (XmlWriter writer = XmlWriter.Create("C:\\Users\\sumit\\source\\repos\\InformationEncoding_FinalProject\\200439017.xml"))
            {
                writer.WriteStartElement("StudentProfile");
                writer.WriteElementString("StudentID", studentProfile[0]);
                writer.WriteElementString("title", studentProfile[1]);
                writer.WriteElementString("FirstName", studentProfile[2]);
                writer.WriteElementString("LastName", studentProfile[3]);
                writer.WriteElementString("LinkedinProfile", studentProfile[4]);
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }
}



