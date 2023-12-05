namespace PageginationInLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Plese Enter The User You Want to View 1 to 5");
                int perPageView = 5;
                int usePageData = int.Parse(Console.ReadLine());
                var data = getAllStudentData().Skip((usePageData - 1) * perPageView).Take(perPageView).Select(student => new {
                Name = student.Name,
                Adress = student.Address
                }).OrderByDescending(temp =>temp.Name);
                foreach (var student in data)
                {
                    Console.WriteLine(student.Name + student.Adress);
                }

            } while (true);
        }

        public static List<Student> getAllStudentData()
        {
            List<Student> studentList = new List<Student>
                {
                new Student { Id = 1, Name = "John Doe", Address = "123 Main St", Age = 20 },
                new Student { Id = 2, Name = "Jane Doe", Address = "456 Oak St", Age = 22 },
                new Student { Id = 3, Name = "Bob Smith", Address = "789 Maple St", Age = 25 },
                new Student { Id = 4, Name = "Alice Johnson", Address = "987 Pine St", Age = 22 },
                new Student { Id = 5, Name = "Chris Brown", Address = "567 Elm St", Age = 21 },
                new Student { Id = 6, Name = "Emma Watson", Address = "876 Birch St", Age = 24 },
                new Student { Id = 7, Name = "David Jones", Address = "345 Cedar St", Age = 22 },
                new Student { Id = 8, Name = "Sophia Martinez", Address = "654 Spruce St", Age = 26 },
                new Student { Id = 9, Name = "Michael Jackson", Address = "234 Fir St", Age = 27 },
                new Student { Id = 10, Name = "Olivia Davis", Address = "432 Pine St", Age = 19 },
                new Student { Id = 11, Name = "William Johnson", Address = "876 Maple St", Age = 20 },
                new Student { Id = 12, Name = "Ava Wilson", Address = "345 Oak St", Age = 23 },
                new Student { Id = 13, Name = "Ethan Taylor", Address = "789 Cedar St", Age = 21 },
                new Student { Id = 14, Name = "Mia Garcia", Address = "987 Birch St", Age = 22 },
                new Student { Id = 15, Name = "James Miller", Address = "123 Spruce St", Age = 25 },
                new Student { Id = 16, Name = "Isabella Brown", Address = "654 Fir St", Age = 24 },
                new Student { Id = 17, Name = "Logan Smith", Address = "234 Elm St", Age = 26 },
                new Student { Id = 18, Name = "Amelia Wilson", Address = "876 Cedar St", Age = 23 },
                new Student { Id = 19, Name = "Benjamin Davis", Address = "567 Birch St", Age = 22 },
                new Student { Id = 20, Name = "Charlotte Jones", Address = "876 Spruce St", Age = 21 }
                };

            return studentList;
        }

        public class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int Age { get; set; }

        }

    }
}