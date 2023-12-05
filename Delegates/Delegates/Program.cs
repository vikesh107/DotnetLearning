namespace Delegates
{
    public class Program
    {

        public delegate void Calculation(int a,int b);

        public static void Addition(int a,int b)
        {
            Console.WriteLine("The addition is = " + (a + b));
        }
        public static void Subtraction(int a, int b)
        {
            Console.WriteLine("The Subtraction is = " + (a - b));
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("The Multiplication is = " + (a * b));
        }
        public static void Division(int a, int b)
        {
            Console.WriteLine("The Division is = " + a/b);

        }

        static void Main(string[] args)
        {
            Calculation obj = Addition;
            obj(10, 20);
            obj.Invoke(34, 56);

            obj = Subtraction; obj(10, 20);
            obj = Multiplication; obj(10, 20);
            obj = Division; obj(100, 20);
            Demo d1 = new Demo();
            
            setDelegate setDel = d1.setValue;
            setDel(019);

            getDelegate getDel = d1.getValue;
            int num = getDel();
            Console.WriteLine(num);
        }

        
    }


}

    