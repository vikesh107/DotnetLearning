using SealedClass;
using System;
namespace vikesh
{
    class Program
    {
        static void Main(string[] ars)
        {
            SealdClass sealdClass = new SealdClass();

            sealdClass.Commenting();

            UseSeladClass useSeladClass = new UseSeladClass(); //seald class ka object to bana sakte hai

            string fullname = useSeladClass.FulllName();   //isse ham ye object ko dubara drived nahi kran tha karke kar rahe hai

            Console.WriteLine(fullname);

            Console.ReadLine();

        }
    }

    //class demo : SealdClass --- this is not possible beacuse parents class are seald class
    //{

    //}\

}
