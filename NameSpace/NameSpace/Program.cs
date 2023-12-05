using System;
using VikeshNameSpace; //ye mai naya namesapce craete kiya hun jis ka us emai yaha kar sakta hun with the help or same name ka name space creatre kar sakte hai
//or ye jo name space create kar rahe hai na or class usi direcotry me rhna chiaye nhi to nahi milenga or bname 
//It is not possible to use any access specifiers like private, public etc with a namespace declarations.
namespace VikeshNameSpace  //implicitly have public access and this is not modifiable. 
{

    //The namespace elements can't be explicitly declared as private or protected

    //name ke class or member ko private or protect nhi kiya ja sakta
     class MyClass  //yaha pr isko private or protect nhi diya ja sakta
    {
        public MyClass()
        {
            Console.WriteLine("My Class");
        }
    }
    class MyClient
    {
        public static void Main()
        {
            MyClass mc = new MyClass();// Displays 'My Class'
            Class1 n1 = new Class1();
        }
    }
}