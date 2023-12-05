using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace AnyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,54,6,7};

            List<Student> students = new List<Student>() {
            new Student() {sId =1 , sName = "Vikesh",sSubject = new List<string>(){ "Hindi","English","Math"}, sMarks = 90 },
            new Student() {sId =6 ,sName = "Rinkesh",sSubject = new List<string>(){ "Hindi1","English1","Math1"},sMarks = 89},
            new Student() {sId =2 ,sName = "Rinkesh",sSubject = new List<string>(){ "Hindi11","English11","Math"}, sMarks = 30},
            new Student() {sId =3 ,sName = "Satyam",sSubject = new List<string>(){ "Hindi111","English","Math111"}, sMarks = 75}

            };

            //var syntextData = from student in students where student.sSubject.Any(sub => (sub == "Math"  ||  sub == "English")) select student;
            //var MethodSyntex = students.Where(num => num.sSubject.Any(num => num == "Math")).ToList();
            //foreach ( var student in MethodSyntex)
            //{
            //    Console.WriteLine(student.sMarks + student.sName);
            //}
            //var AllSyntexQuesry = (from s in students select s).All(num => num.sMarks > 90);
            //var AllMethodQuery = students.All(num => num.sMarks > 90);
            //Console.WriteLine(AllMethodQuery);
            //List<string> stringlist = new List<string>() { "Red", "Orange", "Green", "Yellow", "White" };


            ////var MethodQuery = stringlist.SelectMany(num => num).Where(num => num=='e');

            //var SyntexQuery =  from tmep in stringlist from  ch in tmep select ch;
            //foreach (char method in SyntexQuery)
            //    Console.WriteLine(method);


            //var syntexQuery = from temp in students from temp1 in temp.sSubject  where  temp1 == "Math" select temp;
            //foreach (var student in syntexQuery)
            //{
            //    Console.WriteLine(student);
            //}

            var SyntexQuery = from temp in students  select new 
            {
                sId = temp.sId,
                    sName = temp.sName,
            };

           foreach (var student in SyntexQuery)
            {
                Console.WriteLine(student.sName + student.sId);
            }

            var MethodQuery = students.Select(student => new Student()
            {
               sId=student.sId,
               sName = student.sName,
                sMarks = student.sMarks,
            });

            var k = (from student in students select student).First(0);

            var ekMethod = from temp in MethodQuery
                           select new
                           {
                               name = temp.sName,
                           };
            foreach(var method in ekMethod)
                Console.WriteLine(method.name);


        }
    }

    class Student
    {
        public int sId { get; set; }
        public string sName { get; set; }
        public List<string> sSubject { get; set; }

        public int sMarks { get;  set; }
    }
}