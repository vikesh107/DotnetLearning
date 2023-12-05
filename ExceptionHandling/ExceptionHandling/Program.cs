using System.Collections.Generic;
using System.Drawing;
using System;
namespace ExceptionHandling
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter The Size of Array");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Plese Enter The Element  of Array");
            int[] arr = new int[A];

            for (int i = 0; i < A; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Plese Enter The you want sum of Subarray");
            int M = int.Parse(Console.ReadLine());
            //arr = { 1,2,3}
            for (int i = 0; i < arr.Length; i++)
            {
                
                for (int j = i; j < arr.Length; j++)
                {
                    //int temp = 0;
                    
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write((arr[k]) + " ");
                        //Console.Write("( " + arr[k] * arr[i] + " )");
                    }

                    Console.WriteLine("");
                }

            }


        }

    }
}