using System.Collections;

namespace HashTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hashtable hashtable = new Hashtable() { { "key1", "value1" }, { "key2", "value 2" }, { "key3", "value 3" } };
            //Hashtable hashtable = new Hashtable() { { "1", "vikesh" }, { 1, "Rinkesh" }, { 8, "Satyam" }, { "Key", 23 } };
            //foreach (string key in hashtable)
            //{
            //    Console.WriteLine(key);
            //}

            Console.WriteLine("-------------");
            foreach (string key in hashtable.Keys) {  //this print without oder
                Console.WriteLine(key);
            }
            Console.WriteLine("-------------");
            foreach (string key in hashtable.Values) {
                Console.WriteLine(key);
            }
            Console.WriteLine(hashtable.Count);
            hashtable.Add("key11", "value11");
            foreach(DictionaryEntry items in hashtable)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine(hashtable.Contains("key1"));
            Console.WriteLine(hashtable.ContainsKey("key2"));
            Console.WriteLine(hashtable.ContainsValue("value1"));

           hashtable.Remove("key1");
           IEnumerator enumerator = hashtable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}