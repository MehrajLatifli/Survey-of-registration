using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_of__registration
{
    [Serializable]
    public class Database
    {
        public Database(string name, string surname, string yourFatherName, string dateTime, string educationDegree, string workExperience)
        {
            Name = name;
            Surname = surname;
            YourFatherName = yourFatherName;
            DateTime = dateTime;
            EducationDegree = educationDegree;
            WorkExperience = workExperience;


            ID = DBID++;
        }

        public Database()
        {
            ID = DBID++;
        }

        public int ID { get; set; }
        public static int DBID { get; set; } = 1;
        public string Name { get; set; }
        public string Surname { get; set;}
        public string YourFatherName { get; set; }
        public string DateTime { get; set; }
        public string EducationDegree { get; set; }
        public string WorkExperience { get; set; }


        public override string ToString()
        {
            return $" \n {ID.ToString()} \n {Name} \n {Surname} \n {YourFatherName} \n {EducationDegree} \n{WorkExperience} \n{DateTime} \n";
        }
    }
}
