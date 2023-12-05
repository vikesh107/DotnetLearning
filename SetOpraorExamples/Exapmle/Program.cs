namespace Exapmle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<student> students = new List<student>() { 
           new student() {sId = 100,sName="Vikesh"},
           new student() {sId = 101,sName="Satyam"},
         

           new student() {sId = 103,sName="Rinkesh",Aid =2, Mid = 400},
           };
           List<Address> Adresses = new List<Address>()
           {
               new Address(){ Aid = 1,Aname = "Raipur",Sid = 100},
               new Address(){ Aid = 2,Aname ="Bhilai",Sid = 101},
               new Address(){ Aid = 3,Aname ="Durg",Sid = 102}
           };
           List<Mark> Marks = new List<Mark>()
           {
               new Mark(){Mid = 100, Marks =90, Sid = 100},
               new Mark(){Mid = 101, Marks =90, Sid = 101},
               new Mark(){Mid = 103, Marks =90, Sid = 108},
           };

            var data = from s in students
                       join a in Adresses on s.sId equals a.Sid
                       join m in Marks on s.sId equals m.Sid
                       select new { s, a, m };
            foreach (var item in data)
            {
                Console.WriteLine(item.s.sName);
            }

        }
    }

    public class student
    {
        public int sId { get; set; }
        public string sName { get; set; }

        public int Aid { get; set; }

        public int Mid { get; set; }
    }

    public class Address
    {
        public int Aid { get; set; }
        public string Aname { get; set; }

        public int Sid { get; set; }

    }

    public class Mark
    {
        public int Mid { get; set; }

        public int Marks { get; set; }

        public int Sid { get; set; }
    }
}