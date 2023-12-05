using System.Collections;

namespace NGHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("key1", "Value 1");
            table.Add("key2", "Value2");
            //table.Add(null, "value"); it's shows warning and it's can't becouse ye sare kaam runtime mehota hai to us time ye expestion de denga or aise warning deta rahenga
            table.Add("key3", 3);
            table.Add("key4", "Value4");
            //Console.WriteLine(table); yaha pr ye System.Collection.Hastable print honga
            foreach (var key in table) {
                Console.WriteLine(key);  //isme data krey valu the the [] isme print honga but Oder nhi pata honga
            }

            foreach(DictionaryEntry entry in table)  // DictionaryEntry me type cast kar sakte hai kiuki iska bhi value key value me hota hai
            {
                Console.WriteLine(entry.Key);
                Console.WriteLine(entry.Value);
            }

            //without using Add mrethod can we add element in arraylist
            //var arryalist = new ArrayList() { "vikiesh",1, "Rinkesh Gupta",1234.567f};
            //foreach(var entry in arryalist)
            //{
            //    Console.WriteLine(entry);
            //}

            Hashtable hashtable1 = new Hashtable() { { 1,"Vikesh"},{ "key1","Value 1"},{ "key2","Value 2" },{ "key3","value 3"} };
            foreach (DictionaryEntry entry in hashtable1)
            {
                Console.WriteLine(entry.Key + " The Value of "+ entry.Value);
                
            }
            Console.WriteLine(hashtable1.Count + " This is Before Clear");

            hashtable1.Remove("key1");

            foreach (DictionaryEntry entry in hashtable1)
            {
                Console.WriteLine(entry.Key + " The Value of ek after remove key value " + entry.Value);

            }


            Console.WriteLine(hashtable1.ContainsValue("Value 2"));
            Console.WriteLine(hashtable1.ContainsKey("key2"));
            Console.WriteLine(hashtable1.Contains("Value 2"));
            Console.WriteLine(hashtable1.Contains("key2"));



            hashtable1.Clear();
            Console.WriteLine(hashtable1.Count + " This is after Clear");

            Console.WriteLine("hashtable1 clear hua ki nahi dekhne ke liye");
            foreach (DictionaryEntry entry in hashtable1)
            {
                Console.WriteLine("ye Chl raha hai__ ");
                Console.WriteLine(entry.Key);
                Console.WriteLine(entry.Value);
            }
        }
    }
}