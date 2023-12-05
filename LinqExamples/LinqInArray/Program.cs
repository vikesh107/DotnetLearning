namespace LinqInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
            new Student { Id = 1, Name = "Alice", Age = 20 },
            new Student { Id = 2, Name = "Bob", Age = 22 },
            new Student { Id = 3, Name = "Charlie", Age = 21 }
            };

            var query = (from student in students
                        where student.Age > 20
                        select new { student.Name, student.Age }).ToList();

            foreach (var result in query)
            {
                Console.WriteLine($"Name: {result.Name}, Age: {result.Age} ");
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}