using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangmnetSystem
{
    
    public static class ExtensionMethodClass
    {
        
        public static void GetStudent(this FilterStudentsClass ob,Student students1)
        {
            Console.WriteLine("\nGet The student:");



            Console.WriteLine($"----------------------");
            Console.WriteLine($"Name: {students1.FirstName} {students1.MiddleName} {students1.LastName}");
            Console.WriteLine($"Age: {students1.Age}");
            Console.WriteLine($"Roll No: {students1.RollNo}");
            Console.WriteLine($"Class: {students1.Class}");

            // Display other properties like Subjects, Marks, Address, Hobbies, etc.
            if (students1.Subjects != null && students1.Subjects.Count > 0)
            {
                Console.WriteLine($"Subjects: {string.Join(", ", students1.Subjects)}");
            }

            if (students1.Marks != null && students1.Marks.Count > 0)
            {
                Console.WriteLine("Marks:");
                foreach (var subject in students1.Marks.Keys)
                {
                    Console.WriteLine($"  {subject}: {students1.Marks[subject]}");
                }
                //Console.WriteLine("---------------");  aas a squre braket me bhi print karwa sakte hai
                //foreach(KeyValuePair<String,int> sub in student.Marks)
                //{
                //Console.WriteLine(sub);
                //}
            }

            if (!string.IsNullOrEmpty(students1.Address))
            {
                Console.WriteLine($"Address: {students1.Address}");
            }

            if (students1.Hobbies != null && students1.Hobbies.Count > 0)
            {
                Console.WriteLine($"Hobbies: {string.Join(", ", students1.Hobbies)}");
            }

            Console.WriteLine($"Added Date-Time: {students1.AddedDateTime}");
            Console.WriteLine($"Total Marks : {students1.TotalMark}");
            Console.WriteLine($"----------------------\n");

        }
    }
}
