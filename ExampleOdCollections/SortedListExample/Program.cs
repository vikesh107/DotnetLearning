namespace SortedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedlist1 = new SortedList<int, string>() { { 1 ,"Value 1"},{ 2,"Value 3"},{ 0,"Value 0"} };
            for (int i = 0; i < sortedlist1.Count; i++) {
                Console.WriteLine(sortedlist1.Values[i]);
            }

            sortedlist1.Add(12, "Value 12");
            sortedlist1.Add(32, "value 32");
            sortedlist1.RemoveAt(0);
            foreach (KeyValuePair<int,string> i in sortedlist1)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}