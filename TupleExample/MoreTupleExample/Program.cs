namespace MoreTupleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var author = new Tuple<string, string, int>("Mahesh Chand", "ADO.NET Programming", 2003);
            Console.WriteLine(author.Item1);
            Console.WriteLine(author.Item2);
            Console.WriteLine(author.Item3);
            var tuple = new Tuple<string, string, int>("vikesh", "MyBooks", 2100);
            Console.WriteLine(math(tuple));

            Console.ReadLine();
        }

        public static int math(Tuple<string ,string,int> tuple)
        {
            return tuple.Item3;
        }
    }
}