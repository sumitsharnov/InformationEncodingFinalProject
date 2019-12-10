using System;
using System.Collections.Generic;
using System.Text;

namespace InformationEncoding_FinalProject
{
    class Student
    {
        public  int studentID = 200439017;
        public  string firstName = "Sumit";
        public  string lastName = "Kumar";
        public  string title = "Mr.";
        public  string linkedinProfileLink = "https://www.linkedin.com//in//sumit-kumar-57890a7b";
        public static IList<string> studentProfile = new List<string>();

        public IList<string> CallingEncryptDecrypt()
        {
            EncryptDecrypt encryptDecrypt = new EncryptDecrypt();
            string strStudentID = encryptDecrypt.EncryptAesManaged(studentID.ToString());
            title = encryptDecrypt.EncryptAesManaged(title);
            firstName = encryptDecrypt.EncryptAesManaged(firstName);
            lastName  = encryptDecrypt.EncryptAesManaged(lastName);
            linkedinProfileLink = encryptDecrypt.EncryptAesManaged(linkedinProfileLink);
            studentProfile.Add(strStudentID);
            studentProfile.Add(title);
            studentProfile.Add(firstName);
            studentProfile.Add(lastName);
            studentProfile.Add(linkedinProfileLink);
            return studentProfile;
        }
    }
}
