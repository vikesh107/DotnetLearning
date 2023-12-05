namespace LamdaExpressionWithTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<(int ,int), (int,int)> lfunc = a =>
            {
                int c = a.Item1 + a.Item2;
                int d = a.Item1 * a.Item2;
                return (c,d);
            };
            var numer = (12, 34);
            Console.WriteLine(lfunc(numer).Item1);
            Console.WriteLine(lfunc(numer).Item2);

            Action<(int, int, int, int)> mul = a => { Console.WriteLine(a.Item1 + a.Item2 + a.Item3 + a.Item4); };
            var number = (10, 20, 30, 40);
            mul(number);


            Console.ReadLine();
            


        }

        public (int,int) Math(int a,int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }
    }
}