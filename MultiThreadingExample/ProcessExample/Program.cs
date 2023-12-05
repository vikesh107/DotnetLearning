using System.Diagnostics;

namespace ProcessExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var p =  Process.GetProcessesByName("Taskmgr");
            foreach (var process in p)
            {
                process.Kill(true);
            }
        }
    }
}