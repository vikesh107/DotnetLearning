namespace GroupbyExample
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Salary { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           var emplist = new List<Employee>(){
           new Employee(){ Id = 1,FirstName= "Vikesh",LastName ="Gupta",Salary = 100000},
           new Employee(){ Id = 2,FirstName = "Rinkesh",LastName = "Gupta",Salary = 12000},
           new Employee(){ Id = 3,FirstName = "Satyam ",LastName = "Singh" ,Salary = 15000},
           new Employee(){ Id = 4,FirstName = "Harshit",LastName =  "Gupta",Salary = 9000},
           new Employee(){ Id = 0,FirstName = "Abhishek",LastName = "Singh",Salary = 29000},
           };

            var syntexQuery = from emp in emplist
                              group emp by emp.LastName into newgroup
                              orderby newgroup.Key
                              select newgroup.Select(temp => temp.FirstName).OrderBy(temp=>temp);

            var syntexQuery1 = from emp in emplist
                              group emp by emp.LastName into newgroup
                              orderby newgroup.Key
                              select newgroup.OrderBy(temp => temp.FirstName);

            var databytSyntxc = from emp in emplist
                                group emp by emp.LastName into newgroup
                                orderby newgroup.Key descending
                                
                                select newgroup;
            foreach (var emp in databytSyntxc)
            {
                foreach (var item in emp)
                {
                    Console.WriteLine(item.FirstName + " "+ item.LastName);
                }
            }

            var MethodQuery11 =  emplist.GroupBy(temp=>temp.LastName).OrderBy(temp=>temp.Key).Select(temp=>temp.OrderBy(value => value.FirstName));


            var MethodSyntex = emplist.GroupBy(temp => temp.LastName).OrderBy(temp => temp.Key).Select(temp => temp.Select(x=>x.FirstName).OrderBy(x=>x));


            //var MethodSyntex = emplist.GroupBy(temp => temp.LastName).OrderBy(temp => temp.Key).Select(temp => temp.Select(x => x.FirstName).OrderBy(x => x));




            //Console.WriteLine(syntexQuery.GetType());
            //foreach (var method in syntexQuery)
            //    foreach(var emp in method)
            //        Console.WriteLine(emp.FirstName + " "+ emp.LastName);
            //Console.WriteLine("---------------------------------------------------------------");
            //Console.WriteLine(MethodSyntex.GetType());
            //foreach (var method in MethodSyntex)
            //    foreach (var emp in method)
            //        Console.WriteLine(emp.FirstName + " " + emp.LastName);
            //foreach (var emp in syntexQuery)
            //{
            //    Console.WriteLine(emp.Key);
            //    foreach (var txt in emp)
            //        Console.WriteLine(txt.FirstName + " " + txt.LastName);
            //}

            var data = from emp in emplist
                       group emp by emp.LastName into newGroup
                       orderby newGroup.Key descending
                       select new
                       {
                           Key = newGroup.Key,
                           LastName = newGroup.OrderBy(x => x.Salary).ToList(); 
                       };

            var data = emplist.GroupBy(emp=>emp.LastName).OrderBy(emp => emp.Key).Select(s=>s.OrderBy(k=>k.Salary))

            


        }
    }
}