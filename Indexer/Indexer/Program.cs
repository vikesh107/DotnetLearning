namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1[0] = 10; d1[1] = 20;
            d1[2] = 30;
            Console.WriteLine(d1[2]);
        }
    }
}