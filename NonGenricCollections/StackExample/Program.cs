using System.Collections;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();
            stack.Push("rinkesh");
            stack.Push("vikesh");
            stack.Push("satyam");
            Console.WriteLine(stack.Peek());
            System.Console.WriteLine(stack);
            foreach (var item in stack)
            {
                Console.WriteLine(item);              
            }


            Stack satck1 = new Stack(stack);  //yaha pr stack ka value pura stack me aa kar store ho gaya
            Console.WriteLine(satck1.Count);

            IEnumerator iemunator = stack.GetEnumerator();
            while (iemunator.MoveNext())
            {
                Console.WriteLine(iemunator.Current);
            }



            //Queue q = new Queue() { "vikesh", "rinkesh" }; ye queue me bhi nahi kar sakte hai
            Queue q1 = new Queue();
            q1.Enqueue("hello");
            q1.Enqueue("Hi");
            q1.Enqueue("How are You");
            Console.WriteLine(q1.Count);
            q1.Dequeue();
            Console.WriteLine(q1.Count);
            
            Console.WriteLine(q1.Peek());

        }
    }
}