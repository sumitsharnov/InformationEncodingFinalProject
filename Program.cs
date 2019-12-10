using System;
using System.Collections.Generic;

namespace InformationEncoding_FinalProject
{
    class Program : Student
    {
        static void Main(string[] args)
        {
            IList<string> studentProfile = new List<string>();
            Student s = new Student();
            HtmlFileCreation htmlFileCreation = new HtmlFileCreation();
            XMLFileCreation xmlFileCreation = new XMLFileCreation();
            JSONFileCreation jsonFileCreation = new JSONFileCreation();            
            studentProfile = s.CallingEncryptDecrypt();
            htmlFileCreation.createHtmlFile(studentProfile);
            xmlFileCreation.createXMLFile(studentProfile);
            jsonFileCreation.createJsonFile();           
           System.Diagnostics.Process.Start(@"cmd.exe ", @"/c C:\\Users\\sumit\\source\repos\\ConversionTools\\200439017_xml2json.html");
        }
    }
}
