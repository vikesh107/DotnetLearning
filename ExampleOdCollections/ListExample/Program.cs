namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();   
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            foreach (int item in list) {
                Console.WriteLine(item);
            }

            //list.Clear(); //clare the list 
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            list.RemoveAll(x => x == 5);
            IEnumerator<int> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            list.Insert(0, 1);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            //LinkedList<int> ints = new LinkedList<int>();
            //ints.AddLast(1);
            //ints.AddFirst(2);
            //foreach (int item in ints)
            //{
            //    Console.WriteLine(item);
            //}

            List<Student> students = new List<Student>() { new Student { Id = 10,Name = "Vikesh"} ,
             new Student { Id = 11,Name = "Rinkesh"},
             new Student { Id = 12,Name = "Satyam"}
            };
            Student student = new Student();
            student.Id = 1; student.Name = "bhola";
            students.Add(student);
            foreach(Student itesm in students)
            {
                Console.WriteLine(itesm.Id);
                Console.WriteLine(itesm.Name);
            }

            //students.Sort();
            //foreach (Student itesm in students)
            //{
            //    Console.WriteLine(itesm.Id);
            //    Console.WriteLine(itesm.Name);
            //}
            list.Reverse();
            Console.WriteLine("---------------------");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            list.Sort();
            Console.WriteLine("---------------------");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

           



        }
    }
}