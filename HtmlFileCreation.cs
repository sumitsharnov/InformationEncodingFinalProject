using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InformationEncoding_FinalProject
{
    class HtmlFileCreation
    {
        public void createHtmlFile(IList<string> studentProfile)
        {
            using (FileStream fs = new FileStream("C:\\Users\\sumit\\source\\repos\\InformationEncoding_FinalProject\\200439017.htm", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    foreach(string studentProfileData in studentProfile)
                    {
                        string studentProfileValue = string.Empty;

                        if (studentProfileData.StartsWith("https"))
                        {
                             studentProfileValue = string.Format("<p><a href = {0}>My Linkedin Profile</a></p>", studentProfileData);
                             w.WriteLine(studentProfileValue);
                        }
                        else
                        {
                            studentProfileValue = string.Format("<p>{0}</p>", studentProfileData);
                            w.WriteLine(studentProfileValue);
                        }
                    }
                }
            }        
        }
    }
}
    
