namespace LinqExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myintlist = new List<int>();
            myintlist.Add(1);               
            myintlist.Add(2);
            myintlist.Add(3);
            myintlist.Add(4);               
            myintlist.Add(5);
            myintlist.Add(6);              
            myintlist.Add(7);
            myintlist.Add(8);
            int  result = (from myint in myintlist where myint>5 select myint).Count();
            IEnumerable<int> resumtByMethod = myintlist.Where(x => x > 0);
            int resultimidiateByMethod = myintlist.Where(x => x > 0).Count();
            int i = 0;
            myintlist.Add(30);
            foreach (int x in resumtByMethod)
            {
                i++;

            }
            Console.WriteLine(i);
            Console.WriteLine(resultimidiateByMethod);

            myintlist.Add(10);
            Console.WriteLine(result);
            Console.WriteLine(resumtByMethod);
        }
    }
}