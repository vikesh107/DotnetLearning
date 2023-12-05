namespace GenricMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            string[] arr2 = { "Vikesh", "Rinkesh", "Deeepak" };
            Example.ShowArray(arr);
            //Example.ShowArray(arr2); ye error deta rahenga kiuki isko pata hai na yaha mai onlnt int type ka array de sakta hun
            Example.ShowArray(arr2);

        }
    }

    class Example
    {
        //public static void ShowArray(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
                
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        public static void ShowArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}