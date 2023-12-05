namespace DefferdAndImmediate
{
    internal class Program
    {

        public class Emmployee { 

            public int empId { get; set; }
            public string empName { get; set; }

            public int salary { get; set; }

        }
        static void Main(string[] args)
        {
            List<Emmployee> smplist = new List<Emmployee>()
            {
                new Emmployee{ empId = 1,empName = "Vikesh",salary = 10000},
                new Emmployee{ empId = 2,empName = "Satyam",salary = 12220},
                new Emmployee{ empId = 3,empName = "Ganga",salary = 10000},
                new Emmployee{ empId = 4,empName = "Naman",salary = 20000}
            };

            IEnumerable<Emmployee> result = from emp in smplist
                                            where emp.salary == 10000
                                            select emp;

            Emmployee emp1 = new Emmployee();
            emp1.empId = 5;
            emp1.empName = "Harshit";
            emp1.salary = 10000;
            smplist.Add(emp1);

            foreach(Emmployee emp in result)
            {
                Console.WriteLine($"{emp.empName} {emp.empId} this salry is {emp.salary}");
            }

            
        }
    }
}