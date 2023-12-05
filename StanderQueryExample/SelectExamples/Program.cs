namespace SelectExamples
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
           new Employee(){ Id = 3,FirstName = "Satyam ",LastName = "Singh" ,Salary = 15000},
           new Employee(){ Id = 4,FirstName = "Shubham",LastName = "Yadav",Salary = 9000},
           new Employee(){ Id = 0,FirstName = "Abhay",LastName = "Abhi",Salary = 29000},
           };
            //Console.WriteLine(emp.Id + " "+ emp.FirstName + " "+ emp.LastName + " " + emp.Salary);
            //List<int>  querySyntex = (from emp in emplist orderby emp.Id select emp.Id + 10).ToList();
            //foreach (var emp in querySyntex)
            //    Console.WriteLine(emp);

            //var emplist2Query = (from emp in emplist
            //                    select new Employee()
            //                    {
            //                        Id = emp.Id,
            //                        Salary= emp.Salary,
            //                    }).ToList();

            //var senconduerySyntes =  from emp1 in emplist  orderby emp1.Id select new Student{ 
            //    stId = emp1.Id,
            //    stFullName = emp1.FirstName + " " + emp1.LastName,
            //    Address = "Vikesh"

            //};

            //foreach(var item in senconduerySyntes)
            //{
            //    Console.WriteLine(item.stId + " " + item.stFullName + " " + item.Address + " * ");
            //}

            //foreach (var emp in emplist2Query)
            //{
            //    Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName + " " + emp.Salary);
            //}


            //yaha par naam bh nahi denge onther student class ka to bhi chlenga 
            var methodQuery = emplist.Select(emp => new 
            {
                custome = emp.Id,
                custmaFullname = emp.FirstName + " " + emp.LastName,
                ektho  = "vikesh"
            });
            foreach (var emp in methodQuery)
            {
                Console.WriteLine(emp.custome + " " + emp.custmaFullname + " " + emp.ektho);
            }

            var methodQuery1 = emplist.Select(emp => new Student{ stId = emp.Id,
                stFullName = emp.FirstName + " " + emp.LastName
            });


         }
    }
  
}