namespace ThredExample
{

    internal class Program
    {

        public static void func1(int a)
        {
            Thread.Sleep(3000);
            for (int i = 0; i < 50; i++)
            {
                
                Console.WriteLine("This is Funation One = " + i + a);
            }
        }
        public static void func2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("This is Funation two = " + i);

                if (i == 5)
                {
                    Console.WriteLine("Thread is going to Sleep for 3 sec ..");
                    Console.WriteLine(Thread.CurrentThread.Name); // get the current thread Name
                    
                    Thread.Sleep(3000);
                }

              
            }
        }
        public static void func3()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("This is Funation Three = " + i);
            }
        }

        static void Main(string[] args)
        {

            Thread t1 = new Thread(() => func1(10)); // pass parameter using lamda Expression
            //Thread t1 = new Thread(new ParameterizedThreadStart(func1)); // why it's not working
            //if you pass the parameter on Thread Function then you use Lamda Function.
            Thread t2 = new Thread(new ThreadStart(Program.func2));
            Thread t3 = new Thread(func3);
            t2.Name = "t2 Thread"; // set the tread Name
            
          
            t1.Start();
            t1.Join(); // t1 thread is compledted then called onther thread
            t2.Start();
            t3.Start();
            try
            {
                //t1.Abort();
                t2.Abort();
            }
            catch(ThreadAbortException tea)
            {
                Console.WriteLine("Ecception Occur");
            }
            

           
            Console.WriteLine("Thread t has terminated !");

            Console.ReadLine();


        }
    }
}