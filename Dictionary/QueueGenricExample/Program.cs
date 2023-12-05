namespace QueueGenricExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            //var tupke1 = ("vikesh ", 12, "rinkes", ("rajesh", "ramesh", 12), 34);
            //Console.WriteLine(tupke1.Item4.Item3);
            Console.WriteLine("-----------------------");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Contains(4));
            Console.WriteLine(queue.Peek());
        }
    }
}