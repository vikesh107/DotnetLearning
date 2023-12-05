using System;
class Program
{
    static void Main(string[] args)
    {
        //Level level = new Level(); // enum ko ais bhi diclare kiya ja sakta hai lekin variable ke use karke uske method ko use nhi kar sakte

        Console.WriteLine(Level.Low); //enums ke varibale ko enum name umse dot laga ker assces kiya jata hai

        Console.WriteLine(Values.May);

        Console.WriteLine(Values1.April);// Aprile Print Honga

        //Values1 v1 = Values1.April;  ye nahi kar sakte
        //Values1 v1; //ye kar sakte hai but iska koi matlab nhi hai
        //var vikesh = new Values1(); // nahi kar sakte new keyword  ki help se
        //var vikesh; kaise hi karenge isko intilize kiya jata hai usee pehle

        dynamic vikesh;
        vikesh = Values.May;
        Console.WriteLine(vikesh + " vikesh ke dawara");

        //dynamic vikesh;
        //vikesh = Values1.June; kar sakte hai

        var vikesh1 = Values1.April;
        Console.WriteLine(vikesh1);


        Console.WriteLine();
;       Console.ReadLine();
    }
}
//An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
enum Level
{
    Low, 
    Medium,  //iskme hame data type wegera kuych nbhi batna padat ahia bas usko likh diya jata hai
    High,
}

//By default, the first item of an enum has the value 0. The second has the value 1, and so on.
enum Values
{
    January,    // 0
    February,   // 1
    March,      // 2
    April,      // 3
    May,        // 4
    June,       // 5
    July        // 6
}
//You can also assign your own enum values, and the next items will update their numbers accordingly:
enum Values1
{
    January,    // 0
    February,   // 1
    March = 4,      // 4
    April = 10,      // 10
    May,        // 11
    June,       // 12
    July        // 13
}
