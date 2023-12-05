namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 6, 7, 8, 9, 10 };
            for(int i  = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]); // in one line without sapce
                Console.WriteLine(arr[i]); // next line ye currsor ko next line me le ke chle jata hai
            }
            int k = 0;
            for(;k< arr.Length;)
            {
                Console.WriteLine(arr[k]);
                k++;
            }

            //for(; ; ) { }  this is infiniy loop
            int j = 0;
            while(j< arr.Length)
            {
                Console.WriteLine(arr[j]);
                j++;
            }

            //while (true) // both are infinity loops
            //{

            //}

            //do
            //{

            //}while(true);
            Console.WriteLine("Do While Loop me ek baar loop chlta hi hai.....----------------");
            int b = 0;
            do
            {
                Console.WriteLine(arr[b]);
                b++;
            }while(b< arr.Length-1);
        }
    }
}