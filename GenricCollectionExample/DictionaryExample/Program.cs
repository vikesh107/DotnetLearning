using System.Collections;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> dic = new Dictionary<string, int>() { { "one",1},{ "two",2},{ "Three",3} };
            //foreach(var rntry in dic)
            //{
            //    Console.WriteLine($"The Key is {rntry.Key} and Value is {rntry.Value}");
            //}
            
            Dictionary<int,string> dictonory = new Dictionary<int,string>();
            dictonory.Add(1, "Value1");
            dictonory.Add(2, "Value2");
            dictonory.Add(3, "Value3");
            dictonory.Add(4, "Value4");
            foreach(var item in dictonory)
            {
                Console.WriteLine("The Key is " + item.Key + " The Value is " +item.Value);
            }

            Dictionary<int,string>.ValueCollection values = dictonory.Values;
            foreach(string value in values)
            {
                Console.WriteLine(value);
            }

            Dictionary<int,string>.KeyCollection ints = dictonory.Keys;
            foreach(int key in ints)
            {
                Console.WriteLine(key);
            }

            
        }

    }
}