namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {    


            int a, b;
            Console.WriteLine("enter 2 no ");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("-----------------if else if if-------------------------");
            if (a > b)
            {
                Console.WriteLine("a is greather");
            }
            else if (a < b)
            {
                Console.WriteLine("b is greather");
            }
            else
            {
                Console.WriteLine("both are Equals");
            }

            Console.WriteLine("-----------------if else-------------------------");

            if (a < b)
            {
                Console.WriteLine("B bada hai");
            }
            else
            {
                Console.WriteLine("this will run ater fail the if condditon");
            }


            Console.WriteLine("-----------------Switch case-------------------------");
            Console.WriteLine("choose the following color Red for 1, Green for 2, green for pink 3");
            int ch = Int32.Parse(Console.ReadLine());
            getdata(ch);


            Console.WriteLine("-----------------Switch case for boolean-------------------------");
            var boool = Convert.ToBoolean(Console.ReadLine());
            getdataboolean(boool);


            Console.ReadLine();
        }

        public static  void getdata(int ch)
        {
            
           
            switch (ch)
            {
                case 1:
                    Console.WriteLine("you choose Red");
                    break;
                case 2:
                    Console.WriteLine("you choose Green");
                    break;
                case 3:
                    Console.WriteLine("you choose Pink");
                    break;  // break dena mendotory hai nahi to Compile time error denga ji
                default:
                    Console.WriteLine("you cant choose correct color");
                    break;
            }
        }


        public static void getdataboolean(bool ch)
        {


            switch (ch)
            {
                case true:
                    Console.WriteLine("you choose True");
                    break;
                case false:
                    Console.WriteLine("you choose false");
                    break;
                default:
                    Console.WriteLine("you cant choose correct color"); //this code is unreachable beacuse condtito is false ya true
                    break;
            }
        }
    }
}