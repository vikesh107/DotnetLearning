using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflactionExample
{
    internal class DemoExplain
    {
        static void Main(String[] args)
        {
            //Type t = Type.GetType("ReflactionExample.Demo01");

            Type t = typeof(Demo01); //yaha pr kewal class name dena hota hai

            //Demo01 demo01 = new Demo01();  // ye bhi kiya ja sakta hai
            //Type t  = demo01.GetType();

            Console.WriteLine(t.FullName);

            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo mi in methods)
            {
                Console.WriteLine(mi.Name + " : retun type" +mi.ReturnType + " : " +mi.ReturnParameter);
            }

            ConstructorInfo[] constructor = t.GetConstructors();
            foreach (ConstructorInfo mi in constructor)
            {
                Console.WriteLine(mi.Name );
            }


        }
    }
}
