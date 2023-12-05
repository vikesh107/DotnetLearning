namespace CodeByVijaySir
{

    public delegate A2 MyDelegate(int a); 
    public class Program
    {
        static void Main(string[] args)
        {
            A2 a2 = new A2();
            var B1 = a2.B1;
            var B2 = a2.B2;
            var B3 = a2.B3;
            var B4 = a2.B4;
            var B5 = a2.B5;
            var a = (B1 + B2 + B3 + B4 + B5 - B1 - B2 - B3 - B4 - B5);
            Console.WriteLine(a);  //  nothing to print
            a.Invoke(10); // it's shows warning a and excute that they show Unhandled exception. System.NullReferenceException exception
            Console.ReadLine();

        }
    }

    public class A2
    {
        public A2 B1(int a)
        {
            Console.WriteLine("This is B1 Method" + a);
            return this;
        }
        public A2 B2(int a)
        {
            Console.WriteLine("This is B2 Method"+ a);
            return (this);
        }
        public A2 B3(int a)
        {
            Console.WriteLine("This is B3 Method"+a);
            return (this);
        }
        public A2 B4(int a)
        {
            Console.WriteLine("This is B4 Method"+a);
            return (this);
        }
        public A2 B5(int a)
        {
            Console.WriteLine("This is B5 Method"+a);
            return (this);
        }

    }
}