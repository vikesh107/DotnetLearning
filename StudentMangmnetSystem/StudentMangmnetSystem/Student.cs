using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangmnetSystem
{
    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int RollNo { get; set; }
        public StudentClass Class { get; set; }
        public List<string> Subjects { get; set; }
        public Dictionary<string, int> Marks { get; set; }
        public string Address { get; set; }
        public List<string> Hobbies { get; set; }
        public DateTime AddedDateTime { get; set; }
        public int TotalMark { get; set; }
    }
}
