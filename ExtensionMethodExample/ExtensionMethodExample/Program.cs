namespace ExtensionMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.MyExtensionMethod();
            var (Sum, Product) = demo.Math(20, 30);
            Console.WriteLine(Sum);
            Console.WriteLine(Product);

            int a = demo.func3(10); //same name ke banenye to wo jo perent nhi matlb jo iska parests honga usko call kar denga mtlb jo phle define hua hai usko kar denga

            int a1 = 20; // int ek struct hai toh maine iske andr ek method inculde kar diya hai
            bool result =  a1.isGreaterThen(20);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
    //why static 
    public static class MyClass
    {
        public static  void MyExtensionMethod(this Demo p) //why this?
        {
            Console.WriteLine("This is my extension Method" );
        }

        public static (int Sum,int Product) Math(this Demo p,int a,int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }

        public static bool isGreaterThen(this int i,int value)  //it's called binding parameter isme first possition me bindinf paratmert hon chiye
        {
            return i> value;
        }

        public static int  func3(this Demo p,int a)
        {
            Console.WriteLine("This is First Func3 viukeh");
            return a;

        }
    }
}