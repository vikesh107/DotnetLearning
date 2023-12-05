using System.Threading.Channels;

namespace AsyncAndAwaitExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DoAsyncWork();
            Task1();
            Task2();
            Task3();

            

            
            Console.ReadLine();
        }

        public static async void Task1()
        {
             await Task.Run(() =>
            {
                Console.WriteLine("Task 1 Started...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 1 is Completed....");
            });
        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 Started...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 2 is Completed....");
            });
            
        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 Started...");
                Thread.Sleep(1000);
                Console.WriteLine("Task 3 is Completed....");
            });
            Thread.Sleep(1000);
            await Task.Run(() => {
                Console.WriteLine("Ye Check Karne ke liye dekha ja raha hai ki uppr wale lamda await ka wait karenga ki nahi");

            });


            await Console.Out.WriteLineAsync("Hello i am Super Hero..");
        }

        public static async Task downloadData()
        {
            await Task.Delay(1000);
            await Console.Out.WriteLineAsync("Hello");
        }

        public static async void DoAsyncWork()
        {
            Console.WriteLine("Start of async method");

            // Call the asynchronous method using await
             await downloadData();

            Console.WriteLine("Async method completed: ");
        }

        public static async Task<String> Mydowork()
        {
            return "Hello";
        }

    }
}