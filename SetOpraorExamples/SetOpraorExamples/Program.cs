using System.Reflection.Metadata.Ecma335;

namespace SetOpraorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,1, 3, 4, 5, };
            int[] arr1 = { 1, 2, 3,7,8,9 };

            var mq = arr.Union(arr1);   
            foreach (int i in mq)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=====");
            var mq1 = arr.Intersect(arr1);
            foreach(int i in mq1)
                Console.WriteLine(i);

            Console.WriteLine("=====");
            var mq2 = arr.Distinct();
            foreach (int i in mq2)
                Console.WriteLine(i);

            List<String> list = new List<String>();
            list.Add("A");
            list.Add("B");  
            list.Add("C");
            list.Add("A");
            list.Add("a");
            list.Add("D");
            var sq = list.Distinct();
            var sq1 = list.Distinct(StringComparer.OrdinalIgnoreCase);
            Console.WriteLine("------------------------");
            foreach (string i in sq)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");
            foreach (string i in sq1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------");
            var value = arr.Except(arr1);
            foreach (var i in value)
            {
                Console.WriteLine(i);
            }


        }
    }
}