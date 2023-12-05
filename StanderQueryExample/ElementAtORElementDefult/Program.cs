using System.Security.Cryptography;

namespace ElementAtORElementDefult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intist = new List<int>() { 1, 3, 65, 2, 45, 22, 4, 67, 41, 134, 567, 899 };
            //Console.WriteLine(intist.ElementAt(12));   this prodece System.ArgumentoutOf range Exapetion
            int value =  intist.ElementAt(0); //1
            int value2 = intist.ElementAtOrDefault(12); //yaha per arthematic opoertion perforem kar saktye hai or yaha pr outpur Zero Aaaeynga.


            var stringlist = new List<String>() { "Vikesh", "Rinkesh", "Satyam", "Harshit", "Naveeen" };
            string valustr = stringlist.ElementAt(0);
            Console.WriteLine(valustr);
            string syntxQuery = (from temp in stringlist select temp ).ElementAt(0);
            Console.WriteLine(syntxQuery);

            string syntxQuery1 = (from temp in stringlist select temp).ElementAtOrDefault(10);
            Console.WriteLine(syntxQuery1);

        }
    }
}