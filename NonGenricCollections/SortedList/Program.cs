using System.Collections;

namespace SortedList1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Hashtable hs = new Hashtable() { { "key4", "value3" }, { "key2", "value2" }, { 1, "value 3" } }; this is possible in Hastable
            //foreach (var item in hs)
            //{
            //    //Console.WriteLine(item.Key + " hat value is"+ item.Value);
            //    Console.WriteLine(item);
            //}

            SortedList sortedList = new SortedList() { { "key4","value4"},{ "key2","value2"} , { "key0", "value0" }, { "key10", "value10" } }; //key ke hisab se sort karta hai to agr type hi diiferene honga isen 

            //sortedList.Add(1, "showing erroe"); // System.InvalidOperationException karenga
            foreach (var item in sortedList) {
                //Console.WriteLine(item.Key + " hat value is"+ item.Value);
                Console.WriteLine(item);
            }


            //SortedList sortedList2 = new SortedList() { { 1, "value3" }, { 3, "value2" }, { 1, "value 3" } }; // same key nahi diya ja sakta hai sorted list me oe 
            //or same tyoe ka key hona chiaye isme
            //foreach (var item in sortedList2)
            //{
            //    //Console.WriteLine(item.Key + " hat value is"+ item.Value);
            //    Console.WriteLine(item);
            //}

            //SortedList sortedList1 = new SortedList() { { "key4", "value3" }, { "key2", "value2" }, { 1, "value 3" } }; // this is not possible
            //foreach (var item in sortedList1)
            //{
            //    //Console.WriteLine(item.Key + " hat value is"+ item.Value);
            //    Console.WriteLine(item);
            //}
           
            Console.WriteLine(sortedList.Count); 
            Console.WriteLine(sortedList.ContainsKey("key10"));   //true
            Console.WriteLine(sortedList.ContainsValue("value10")); //true
            sortedList.Clear();
            Console.WriteLine(sortedList.Count);




        }
    }
}