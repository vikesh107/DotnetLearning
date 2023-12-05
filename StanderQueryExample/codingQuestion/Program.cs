using System.Data;

namespace codingQuestion
{
    internal class Program
    { 
        //Given a string S of size N and an integer K.Your task is to reverse every substring of size K from the start position.

          //Note: 
         //1. If a particular character is already reversed, don't consider it in next substring.
         //2. In case you don't have K characters while forming substring just consider the remaining characters as substring.

        //Input: S = "ABCDEF", K = 3
        //Output: CBAFED

        //Input: S = "12345", K = 2
        //Output: 21435
        static void Main(string[] args)
        {
            String str = "ABCDE";
            int N = str.Length;
            string revers_string = "";
            int K = 3;
            int j = 0;
            for (int i = 0; i < Math.Ceiling((decimal)N/K); i++)
            {
                char[] arry = str.Substring(j, K).ToCharArray();
                Array.Reverse(arry);
                Console.WriteLine(arry);

                if (K + K > str.Length)
                {
                    K = str.Length;
                }
                else
                {
                    K = K + K;
                }
                j = K + 1;
                Console.WriteLine("-------------------------");

            }
           

        }
    }
}