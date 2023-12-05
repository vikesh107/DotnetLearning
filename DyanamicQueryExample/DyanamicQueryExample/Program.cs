using System.Linq;
using System.Linq.Dynamic.Core;

namespace DyanamicQueryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 6, 8, 3, 1, 54, 8, 4 };
            string value = Console.ReadLine();
             
            var expresssion = $"x=> x>{value}";
            var data = arr.AsQueryable().Where(expresssion);
            
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}