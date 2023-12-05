namespace AggregrateFunctionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arrint =new List<int>() {0, 2, 7, 1, 8, 5, 3, 8 };
            int data = arrint.ElementAt(arrint.Count-2);
            int data2 = (from temp in arrint select temp).ElementAt(arrint.Count -2 );
            Console.WriteLine(data);


            int value = arrint.Min(num=>num);
           
            int valu1 = (from n in arrint select n).Max();
            
            Console.WriteLine(valu1);

            List<string> stringLsit = new List<string>() { "xcdfcdfdfdfdfdfdfrdf", "Rinkesh", "Satyam", "Abhishek","K" };
            string x = stringLsit.Min();
            Console.WriteLine(x);
            int sum =  stringLsit.Sum(num => num.Length);
            Console.WriteLine(sum + " This is All String Of Sum...");
            int value3 = arrint.Sum(numm =>numm);
            Console.WriteLine(value3);

            double value4 = arrint.Average(num=>num*8);
            Console.WriteLine(value4);

            double value5 = (from num in arrint select num).Average();
            Console.WriteLine(value5);



        }
    }
}