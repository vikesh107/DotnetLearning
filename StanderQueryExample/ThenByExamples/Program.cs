using System.ComponentModel.DataAnnotations;

namespace ThenByExamples
{
    internal class Program
    {

        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int Salary { get; set; }
                
        }
        static void Main(string[] args)
        {
            var emplist = new List<Employee>(){
           new Employee(){ Id = 1,FirstName= "Vikesh",LastName ="Gupta",Salary = 100000},
           new Employee(){ Id = 2,FirstName = "Rinkesh",LastName = "Gupta",Salary = 12000},
           new Employee(){ Id = 3,FirstName = "Vikesh ",LastName = "Singh" ,Salary = 15000},
           new Employee(){ Id = 4,FirstName = "Vikesh",LastName = "Yadav",Salary = 9000},
           new Employee(){ Id = 0,FirstName = "Abhishek",LastName = "Abhi",Salary = 29000},
           };

            //var syntexQuery = from emp in emplist orderby emp.FirstName thenby emp.LastName select emp;
            //foreach (var emp in syntexQuery)
            //Console.WriteLine(emp.Id + " "+ emp.FirstName + " "+ emp.LastName + " " + emp.Salary);

            //var methodQuery = emplist.OrderByDescending(x => x.FirstName).ThenBy(x=>x.LastName);
            //foreach (var emp in methodQuery)
            //Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName + " " + emp.Salary);
            // then orderby working on last oderby emp.LastName
            var Query = from emp in emplist orderby emp.FirstName orderby emp.Salary orderby emp.LastName select emp;
            foreach (var emp in Query)
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName + " " + emp.Salary);


            var mQuery = emplist.OrderBy(emp => emp.Id).OrderBy(emp => emp.Salary); //last oder bys jisme laga honga usme work karenga
            foreach (var emp in mQuery)
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName + " " + emp.Salary);

            var m1Query = emplist.Where(emp => emp.Salary > 5000).Select(employee => new
            {
                name = employee.FirstName,
                id = employee.Id,
                salary = employee.Salary

            }).OrderBy(emp => emp.salary);
            foreach (var emp in m1Query)
                Console.WriteLine(emp.name + " " + emp.id + " " + emp.salary );


        }
    }
}