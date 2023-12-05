using System;
namespace vikesh
{

    class Program 
    {
        static void Main(string[] ars)
        {

            MyStruct2 myStruct2= new MyStruct2();
            myStruct2.getSetName = "Vikesh Gupta";
            myStruct2.getSetAge  = 10;
            Console.WriteLine(myStruct2.getSetName + " "+ myStruct2.getSetAge);


            MyStruct3 md;
            md.name = "Rikesh Gupta";
            md.age = 30;
            Console.WriteLine(md.name + " "+ md.age);

            md.myStruyctMethod();
            Console.ReadLine(); 
        }





    }

    public  struct MyStruct //is type to selaed hota  hai iskoo private nahi banya ja sakta
    {
        private string name;  // yaha pr value asssighn nhi kiya ja sakta hai
        public int age;
        //vikesh() yaha par keal paratermize construct banya ja sakta hai
        //{
        //}

        public MyStruct(string name, int age) //in struct paratmerize xontructor are possible
        {
            this.name = name;
            this.age = age;
        }
    }
    //point to be noted ham enumm me data type ni bnata te hai isliye uska objedct create nhi kar sakte hai

    public struct MyStruct2
    {
        private string name;
        public int age;

        public int getSetAge { get; set; }
        public string getSetName { get; set; }  

    }

    public struct MyStruct3
    {
        public int age;
        public string name;

        public void  myStruyctMethod()
        {
            Console.WriteLine("Hello I am Struct Method");
        }
    }


}