using PartialClass;
using System;
namespace vikesh
{
    class Program 
    {
        static void Main(string[] ars)
        {
            SameName t1 = new SameName();
            t1.Name = "Vikesh Gupta";
            t1.myage = 12;
            t1.getname();

            TestForInterFace testForInterFace = new TestForInterFace();
            testForInterFace.show();

            Console.ReadLine();
        }
    }

    class TestForInterFace :  iSameName1
    { 
       

        public void show()
        {
            Console.WriteLine("Vikesh Gupta 1");
        }


    }

    partial interface iSameName
    {
        void show();
    }
    partial interface iSameName1
    {
        //void show(); same name ka method  to de hi nahi sakte
        void show();
    }

 

}
