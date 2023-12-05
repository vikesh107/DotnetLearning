namespace SkipAndSkipWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var num = numbers.Skip(5);
            foreach (int i in num) {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");
            var num1 = numbers.SkipWhile(num => num < 9);
            foreach (int i in num1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");
            var num2 = numbers.SkipLast(5);
            foreach (int i in num2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");
            IEnumerable<int> thelement = numbers.Take(5).Skip(4);
            foreach (int i in thelement)
            {
                Console.WriteLine(i);
            }
        }
    }
}