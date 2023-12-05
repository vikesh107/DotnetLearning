namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StudentManager studentManager = new StudentManager();

                // Menu
                while (true)
                {
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Get All Students");
                    Console.WriteLine("3. Filter Students");
                    // Add other menu options...

                    Console.WriteLine("Enter your choice:");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            String FirstName = Console.ReadLine();
                            String MiddleName = Console.ReadLine();
                            String LastName = Console.ReadLine();
                            String Age = Console.ReadLine();
                            String RollNo = Console.ReadLine();
                            String Class = Console.ReadLine();
                            String FirstName = Console.ReadLine();
                            String FirstName = Console.ReadLine();
                            String FirstName = Console.ReadLine();
                            String FirstName = Console.ReadLine();

                            Student st = new Student();

                            break;

                        case "2":
                            // Get All Students logic with exception handling
                            break;

                        case "3":
                            // Filter Students logic with exception handling
                            break;

                            // Other cases for menu options...
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                // You may want to log the exception or handle it differently based on your requirements
            }
        }
    }
}