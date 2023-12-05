namespace MultiThreadingExample
{
    internal class Program
    {

        public static void func1()
        {
            
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("This is Funation One = " + i);
            }
        }
        public static void func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is Funation two = " + i);

                if (i == 5)
                {
                    Console.WriteLine("Thread is going to Sleep for 3 sec ..");
                    Thread.Sleep(3000);
                }
            }
        }
        public static void func3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is Funation Three = " + i);
            }
        }

        static void Main(string[] args)
        {
            //Thread t = Thread.CurrentThread;
            //t.Name = "Main Thread"; //bydefult Threda ka namm nhi hota.
            //Console.WriteLine("Running the  Thred "+ t.Name);

            Program.func1(); // aafter complition fun1 tyen excute Funation two ther was only thred this is by defult thread.
            Program.func2();  // functin have thread.slepp there was this is excute three second then comple after that fuc3 is called  
            Program.func3();    
            Console.ReadLine();

            // show this is problem beacuse you give some complex data conction then they completed then excuted. so we create three Thred Example in ThredExample.
        }
    }
}