using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InformationEncoding_FinalProject
{
    class JSONFileCreation
    {
        public void createJsonFile()
        {
            Student s = new Student();

            string jsonResult = JsonConvert.SerializeObject(s);

            string path = @"C:\\Users\\sumit\\source\\repos\\InformationEncoding_FinalProject\\200439017.json";

            using (var tw = new StreamWriter(path, false))
            {
                tw.WriteLine(jsonResult.ToString());
                tw.Close();
            }
        }
    }
}
