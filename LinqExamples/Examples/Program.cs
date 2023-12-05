namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> fruitlist = new Dictionary<string, string>() { { "1", "Mango" }, { "2", "Mango" }, { "3", "Mango" }, { "4", "Mango" }, { "5", "Mango" } };
            //var query = from fruit in fruitlist
            //            where fruit.Contains("an")
            //            select fruit;

            var query = fruitlist.Where(a => a.Key == "8").ToList();

            IEnumerable<KeyValuePair<string, string>> values = from kpv in fruitlist where kpv.Key == "2" select kpv;


            //foreach (var fruit in values)
            //{
            //    Console.WriteLine(fruit.Value);
            //}
           

        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public int  Salary { get; set; }
       
        }
    }
}