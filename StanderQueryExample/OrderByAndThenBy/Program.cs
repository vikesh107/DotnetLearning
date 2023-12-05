using System.ComponentModel.DataAnnotations;

namespace OrderByAndThenBy
{
    internal class Program
    {

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int  Salary { get; set; }
        }
        static void Main(string[] args)
        {
            //var datasorce = new List<int>() { 2, 67, 2, 4, 78, 90, 34, 22, 454, 67, 89, 00, 21, 45 };

            //var numbersInOrder = (from num in datasorce
            //                     orderby num descending
            //                     select num).ToArray();

            //Console.WriteLine(numbersInOrder);
            //foreach (int num in numbersInOrder)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("----------------------");
            //var numberOrdrByMrthod = datasorce.OrderBy(x=>x>20).OrderBy(y=>y).OrderByDescending(z=>z).OrderByDescending(h=>h).OrderBy(x=>x).OrderByDescending(l=>l);   // isme lemda expression me batana padenga na ki kaise karn hai jisko ham x diye hai
            //foreach (int num in numberOrdrByMrthod)
            //    Console.WriteLine(num);


            //var mylist = new List<string>() { "Vikesh","Rinkesh","Abhishek","Gnaga","Basnt","Abhay","Harshit"};
            //var synQuery = (from item in mylist orderby item select item).ToList(); 

            //var mrthQuery =   mylist.OrderBy(x => x).ToList();
            //foreach (var item in mrthQuery)
            //{
            //    Console.WriteLine(item);
            //}

            List<Employee> emplist= new List<Employee>() { 
            new Employee{Id = 1,Name = "Vikesh Gupta",Salary = 10000},
            new Employee {Id = 2,Name =  "Rinkesh Gupta", Salary = 12000},
            new Employee {Id = 8, Name = "Gangadhar ",Salary = 15000},
            new Employee {Id = 5,Name = "Satyam Gupta",Salary = 3000}
            };    

            //var synbtxQuery = (from emp in emplist orderby emp.Id select emp).ToList();
            //Console.WriteLine(synbtxQuery.GetType());
            //foreach (var emp in synbtxQuery)
            //{
            //    Console.WriteLine($"{emp.Id} {emp.Name} and this salry is {emp.Salary}");
            //}

            var MrthodSyntes  = emplist.OrderBy(x=>x.Id).Select(x=>x.Id).ToList();
            Console.WriteLine(MrthodSyntes.GetType());

            var methodSyntes = emplist.Where(x => x.Id>2).OrderBy(x => x.Name);
            foreach (var liest in methodSyntes)
            {
                Console.WriteLine(liest.Name +  liest.Id + liest.Salary);
            }



            Console.ReadLine();
        }
    }
}