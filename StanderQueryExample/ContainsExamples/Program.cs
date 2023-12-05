using System.Diagnostics.CodeAnalysis;

namespace ContainsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "Red", "Orange", "Yellow", "Blue", "Green" };
            bool methodQuery = strings.Contains("Red");
            Console.WriteLine(methodQuery);

            bool syntexQuery = (from temp in strings
                                select temp).Contains("Red");

            Console.WriteLine(syntexQuery);

            List<Student> students = new List<Student>() {
            new Student() {sId =1 , sName = "Vikesh",sSubject ="Math" },
            new Student() {sId =6 ,sName = "Rinkesh",sSubject = "Hinid"},
            new Student() {sId =2 ,sName = "Rinkesh",sSubject = "Hinid"},
            new Student() {sId =3 ,sName = "Satyam",sSubject = "English"}

            };
            Student st = new Student() { sId = 1, sName = "Vikesh", sSubject = "Math" };
            
            bool methodQuery1 = students.Contains(new Student() { sId = 6, sName = "Rinkesh", sSubject = "Math" },new StudentComapre());
            Console.WriteLine(methodQuery1);


        }
    }

    class Student
    {
        public int sId { get; set; }
        public string sName { get; set; }
        public string sSubject { get; set; }
    }

    class StudentComapre : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            return  x.sName == y.sName && x.sId == y.sId;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
           return obj.sName.GetHashCode();
        }
    }
}