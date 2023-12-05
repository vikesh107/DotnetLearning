namespace ExpressionStatementLamdas
{
    internal class Program
    {

        public delegate int Mydelegate(int a,int b);
        public delegate void voidDelegate(string s);
        static void Main(string[] args)
        {
           Program program = new Program();
           Mydelegate del = (a, b ) =>  a+b;

            Action<string> del1 = a => { 
                if (a.Length>5) 
                {
                    Console.WriteLine("String Ka Length 5 se bada hai");
                }
                else
                {
                    Console.WriteLine("String Ka lenght 5 se chhota hai");
                }
            };
            del1("vikesh gupta");
            Console.WriteLine(del.Invoke(12, 23));
        }

        private int Sum(int a, int b)
        {
            return a + b;
        }
    }
}