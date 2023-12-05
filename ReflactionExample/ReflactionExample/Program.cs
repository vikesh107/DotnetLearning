using System.Reflection;

namespace ReflactionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Type t = c.GetType();
            Console.WriteLine(t.FullName);
            

            Type type = typeof(Car);
            Console.WriteLine(type.Name);
            

            MethodInfo[] men = type.GetMethods();
            foreach(MethodInfo member in men)
            {
                Console.WriteLine(member.Name);
            }

            MemberInfo[] meberinfor = t.GetMembers();
            Console.WriteLine(meberinfor.Length);

            MemberInfo[] meberoutfor1 = type.GetMembers();
            Console.WriteLine(meberoutfor1.Length);


            Console.WriteLine("MemberInfo Name  -----------------------");
            foreach (MemberInfo info in meberinfor)
            {
                Console.WriteLine(info.Name);
            }


            Console.ReadLine();
        }
    }
}