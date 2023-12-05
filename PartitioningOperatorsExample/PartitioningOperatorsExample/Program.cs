namespace PartitioningOperatorsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 5 ,4 , 1, 3, 9, 8, 6, 7, 2, 0 };
            IEnumerable<int> take5Element = numbers.Take(90);
            int value1 = numbers.Take(numbers.Count() - 1).Last();
            Console.WriteLine(value1);
            foreach (int element in take5Element)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------");
            int[] numbers1 = { 5, 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var num = numbers1.TakeLast(2).First();
            Console.WriteLine(num);
            Console.WriteLine("-------------------------");

            IEnumerable<int> valuesdata = numbers1.TakeWhile((num,temp) => num > temp);
            foreach (int element in valuesdata)
                Console.WriteLine(element);
            //foreach (int element in num)
            //{
            //    Console.WriteLine(element);
            //}

        }
    }
}