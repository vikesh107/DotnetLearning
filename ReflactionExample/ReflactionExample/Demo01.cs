using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflactionExample
{
    internal class Demo01
    {
        public int Id;
        public string Name;
        public string Description;

       
        public int MyProperty { get; set; }
        public  Demo01()
        {
            Console.WriteLine("this is Defult Constructor");
        }
        public Demo01(int a,int b)
        {
            Console.WriteLine("This is Peratemise Constrctor..");
        }

        public void method1()
        {
            Console.WriteLine("This is Methos One");
        }
        public void method1(int a)
        {
            Console.WriteLine("This is Methos One for Paramterizeed");
        }

        public void method2()
        {
            Console.WriteLine("This is method threee");
        }

    }

  
}
