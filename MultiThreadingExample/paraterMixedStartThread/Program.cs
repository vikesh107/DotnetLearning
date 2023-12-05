namespace MultithreadingDemo
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();
            // Create an instance of ParameterizedThreadStart delegate
            ParameterizedThreadStart parameterizedThreadStart =
                new ParameterizedThreadStart(Number.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            // Pass the traget number to the start function, which
            // will then be passed automatically to PrintNumbers() function
            T1.Start(target,"vikiesh");
        }
    }
    class Number
    {
        public static void PrintNumbers(object target,string name)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i + "" + name);
                }
            }
        }
    }
}