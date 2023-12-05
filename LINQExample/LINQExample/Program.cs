using System.Linq;

namespace LINQExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> fruitlist = new Dictionary<string,string>() { { "1", "Mango" }, { "2", "Mango" }, { "1", "Mango" }, { "1", "Mango" }, { "1", "Mango" } };
            //var query = from fruit in fruitlist
            //            where fruit.Contains("an")
            //            select fruit;

            var query  = fruitlist.Where(a => a.Key == "1").ToList();


            foreach (var fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}