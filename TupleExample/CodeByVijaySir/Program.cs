namespace CodeByVijaySir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyMaxTupleNested = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18, 19, 20, 21)));
            Console.WriteLine($"My original tuple: {MyMaxTupleNested}");
            Console.WriteLine($"First element of the outest tuple: {MyMaxTupleNested.Item1}");
            Console.WriteLine($"First level of nesting: {MyMaxTupleNested.Rest}");
            Console.WriteLine($"First level of nesting: {MyMaxTupleNested.Rest.Item1.Item4}"); // by vijay sir what is output 8 
            Console.WriteLine($"Second level of nesting: {MyMaxTupleNested.Rest.Item1.Rest.Item1}");
            Console.ReadLine();
        }
    }
}