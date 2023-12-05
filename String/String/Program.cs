using System;

namespace vikesh
{
    class Program
    {
        static void Main(string[] ars)
        {
            string str = "Vikesh Kumar Gupta";
            string vikes = str.Substring(1);  //ye phla index chhor bke are index de denga 
            Console.WriteLine(vikes);
            string vikesh = str.Substring(7,2); //ye Ku denga 7 index ke badd 2 tho de enga 
            Console.WriteLine(vikesh);
        }
    }
}