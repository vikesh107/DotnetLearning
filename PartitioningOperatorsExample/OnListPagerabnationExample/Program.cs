namespace OnListPagerabnationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfData = 3;
            int youWantPage = int.Parse(Console.ReadLine());
            List<string> list = new List<string>() {"Rinkesh 1","Vikesh 2","Harshit 3","Satyam 4","Abhishek 5","Ganga 6","Namn 7","Kahtri 8","Aman 9","Sahil 10" };
            var data = list.Skip(numberOfData* (youWantPage-1)).Take(numberOfData);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}