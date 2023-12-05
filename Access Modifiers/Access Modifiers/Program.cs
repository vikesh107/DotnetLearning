using System;
namespace AccessModifiers 
{ 
     class Program : ProtectedModifire
    {
        class test1
        {
            int num1;  //this is bydefult private
            public int num2; 
        
        }
        static void Main(string[] ars)
        {
            test1 test1 = new test1();
            //test1.num1 = 10 it's not possible becuse hame pata hai ki c# me by defulat jo accses modifires rahet hai eo private rahte hai.
            test1.num2 = 20; //this is accesibale becuse this is public
            Console.WriteLine(test1.num2);
       

            //Class1 c1 =new Class1(); nahi ban sakte kiuki ye error denga hammne isko private bana rakha hai iskje ocnstructor ko

            Class1 c1 = new Class1(); 
            Console.ReadLine();

            ProtectedModifire pf = new ProtectedModifire();
            //pf.num_1 = 30; nahi kar sdakta jab tk main class isko inharite nhi kar deti accha inharite karwa dete hai tab dekhte 
            pf.num_3 = 20;
            Console.WriteLine(pf.num_3);
        }
    }
}


