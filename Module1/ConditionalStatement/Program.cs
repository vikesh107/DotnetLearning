using System;

namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter 2 no ");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a is greather");
            }
            else if(a < b)
            {
                Console.WriteLine("b is greather");
            }
            else
            {
                Console.WriteLine("both are Equals");
            }
            Console.ReadLine();
        }
    }
}