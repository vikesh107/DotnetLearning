namespace SinleAndSinfleORdefrult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,3,5,6,8,87 };
            //var num =  list.SingleOrDefault(num=>num<9);

            var mnum = (from temp in list select temp).SingleOrDefault(num => num > 900);

            //var num1 = (from temp in list select temp).Single(num => num > 900);



            Console.WriteLine(mnum);
            Console.ReadLine();
        }
    }
}