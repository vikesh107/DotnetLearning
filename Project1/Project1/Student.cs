using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Student
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string RollNo { get; set; }
        public string Class { get; set; }
        public List<Subjects> Subjects { get; set; }
        public Dictionary<Subjects, int> Marks { get; set; }
        public string Address { get; set; }
        public List<string> Hobbies { get; set; }
        public DateTime AddedDateTime { get; set; }

        public Student(string firstName, string middleName, string lastName, int age, string rollNo, string studentClass,
                       List<Subjects> subjects, Dictionary<Subjects, int> marks, string address, List<string> hobbies, DateTime addedDateTime)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            RollNo = rollNo;
            Class = studentClass;
            Subjects = subjects;
            Marks = marks;
            Address = address;
            Hobbies = hobbies;
            AddedDateTime = addedDateTime;
        }
    }

    delegate bool StudentFilter(Student student);
}
