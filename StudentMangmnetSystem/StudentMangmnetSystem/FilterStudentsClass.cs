using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangmnetSystem
{
    delegate void ErrorMessage(string s1, string s2);
    public class FilterStudentsClass
    {
        static ErrorMessage obj1 = PrintErrorMessage;
        public static void FilterByName(List<Student> student)
        {
            
            Console.Write("FirstName :");
            string FirstName = Console.ReadLine().Trim().ToLower();
            Console.Write("MiddleName :");
            string MiddleName  = Console.ReadLine().Trim().ToLower();
            Console.Write("LastName :");
            string LastName = Console.ReadLine().Trim().ToLower();
            int i = 0;
            foreach (Student s in student)
            {
                string SfirstName = s.FirstName.Trim().ToLower();
                string sMiddleName = s.FirstName.Trim().ToLower();
                string sLastName = s.FirstName.Trim().ToLower();
                if (SfirstName.Equals(FirstName) && sMiddleName.Equals(MiddleName) && sLastName.Equals(LastName))
                {
                    FilterStudentsClass ob = new FilterStudentsClass();
                    ob.GetStudent(s);
                    i++;
                }
            }
            if (i == 0)
            {
                obj1.Invoke("Name", FirstName);
            }
            
        }

        public static void FilterByClass(List<Student> student) {
            Console.Write("(Class First for : 1 / Class Second for : 2 / Class Third for : 3/Class Fourth for : 4/Class Fifth for :5) Class : ");
            int Class = int.Parse(Console.ReadLine());
            int i = 0;
            foreach (Student s in student)
            {
                if(s.Class == (StudentClass)Class)
                {
                    FilterStudentsClass ob = new FilterStudentsClass();
                    ob.GetStudent(s);
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine($"No Data Found With Specific Class: {Class}");
            }

        } public static void FilterBySubject(List<Student> student) {
            Console.Write("Please Enter The Subject By Sperating Comma :");
            //List<string> subjectsList = Console.ReadLine().Trim().Split(',').ToList();
            //subjectsList.Sort();

            //foreach (Student s in student)
            //{
            //    List<string> studentSubjectList = s.Subjects.ToList();
            //    stu
            //    if (AreListsEqual(subjectsList, s.Subjects.Sort()){

            //    }
            //}

            //foreach (string subject in subjectsList) for all school
            //{
            //    foreach (Student s in student) { 
            //        if(s.Subjects.Contains(subject))
            //        {

            //         FilterStudentsClass filterStudentsClass = new FilterStudentsClass();
            //         filterStudentsClass.GetStudent(s);

            //        }

            //    }
            //}
            string Subjects = Console.ReadLine().Trim();
            int i = 0;
            foreach (Student s in student)
            {
                string getStudentSubject = string.Join(",", s.Subjects);
                if(Subjects.Equals(getStudentSubject))
                {
                    FilterStudentsClass filterStudentsClass = new FilterStudentsClass();
                    filterStudentsClass.GetStudent(s);
                }
            }
            if (i == 0)
            {
                obj1.Invoke("Subjects", Subjects);
            }



        } public static void FilterByAddress(List<Student> student) {
            Console.Write("Please Enter Address :");
            string enterAdress = Console.ReadLine().Trim().ToLower();
            int i = 0;
            foreach (Student s in student)
            {
                string str = s.Address.ToString().Trim().ToLower();
                if (str.Equals(enterAdress))
                {
                    FilterStudentsClass filterStudentsClass = new FilterStudentsClass();
                    filterStudentsClass.GetStudent(s);
                    i++;
                }
            }
            if(i == 0)
            {
                obj1.Invoke("Address", enterAdress);
            }

        } public static void FilterByHobbies(List<Student> student) {
           
                Console.Write("Please Enter The Hobbies By Sperating Comma :");
                string Hobbies = Console.ReadLine().Trim();
                int i = 0;
                foreach (Student s in student)
                {

                    string getStudentHobiess = string.Join(",", s.Hobbies); //get all hobiess of every Student
                    if (Hobbies.Equals(getStudentHobiess))
                    {
                        FilterStudentsClass filterStudentsClass = new FilterStudentsClass();
                        filterStudentsClass.GetStudent(s);
                    }
                }
                if (i == 0)
                {
                obj1.Invoke("Hobbies", Hobbies);
                }



        } public static void FilterByDateAndTime(List<Student> student) {
            Console.Write("Please Enter The date This Formate MM/DD/YYYY 00:00:00 PM/AM :");
            string enterDateAndTime = Console.ReadLine().Trim().ToLower();
            int i = 0;
            foreach (Student s in student)
            {
                string str = s.AddedDateTime.ToString().Trim().ToLower();
                if (str.Equals(enterDateAndTime))
                {
                    FilterStudentsClass filterStudentsClass = new FilterStudentsClass();
                    filterStudentsClass.GetStudent(s);
                }
            }
            if (i == 0)
            {
                obj1.Invoke("Date And Time", enterDateAndTime);
            }
        }

        public static void PrintErrorMessage(String s1, String s2)
        {
            Console.WriteLine($"No Data Found With Specific {s1} : {s2}");
        }

        //static bool AreListsEqual<T>(List<T> list1, List<T> list2)
        //{
        //    if (list1.Count != list2.Count)
        //    {
        //        return false;
        //    }

        //    for (int i = 0; i < list1.Count; i++)
        //    {
        //        if (!EqualityComparer<T>.Default.Equals(list1[i], list2[i]))
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}



    }
}






