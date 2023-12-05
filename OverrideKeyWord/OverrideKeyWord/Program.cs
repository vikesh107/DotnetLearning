namespace OverrideKeyWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass subClass = new SubClass();
            subClass.methods();
            Console.ReadLine();
        }
    }
}