namespace AnonymoMethod
{
    public class Program
    {

        public delegate int MyDelegate(int num);

        public static int Additon(int num)
        {
            return num+10;
        }
        public static int Subtraction(int num)
        {
            return num-10;
        }

        public static void UseAnyNumesParameter(MyDelegate my ,int a)
        {
            Console.WriteLine(my.Invoke(a) + "This is basically Paratametr as ");
        }
        public static void Main(string[] args)
        {
            MyDelegate del = delegate (int num)  // is't annynomus method
            {
                return num+30;
            };
            int result = del(10); 
            Console.WriteLine(result);

            MyDelegate del1 = new MyDelegate(Additon);
            Console.WriteLine(del1(20));
            del1 = new MyDelegate(Subtraction);
            Console.WriteLine(del1(20));
            

            UseAnyNumesParameter(delegate (int a) {  return a + 10; }, 10) ;

            Console.ReadLine();
        }


    }

   
}