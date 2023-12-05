namespace TaskExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task t1 = new Task(PrintInfo);
            //Task t2 = new Task(PrintInfo1);
            //Task t3 = new Task(PrintInfo2);
            //t1.Start(); 
            //t2.Start(); 
            //t3.Start(); 


            //Task t2 = Task.Factory.StartNew(PrintInfo1);
            //Task t3 = Task.Factory.StartNew(PrintInfo2);
            //Task t1 = Task.Factory.StartNew(PrintInfo);


            Task t1 = Task.Run(() => PrintInfo(10));
            
            Task t2 = Task.Run(() => PrintInfo1());
            Task t3 = Task.Run(()=>PrintInfo2());

            Console.ReadLine(); 
        }

        public static void PrintInfo(int a)
        {
            Console.WriteLine("Task is Sleep For 4 second PrintInfo" + a);
            Task.Delay(8000).Wait();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("PrintInfo " + i);
               
               
            }
        }
        public static void PrintInfo1()
        {
            Console.WriteLine("Task is Sleep For 2 second PrintInfo1");
            Thread.Sleep(2000);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("PrintInfo1 " + i);
                Thread.Sleep(500);
            }
        }
        public static void PrintInfo2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("PrintInfo2 " + i);
            }
        }
    }
}