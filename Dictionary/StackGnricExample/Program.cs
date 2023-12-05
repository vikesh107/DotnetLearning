namespace StackGnricExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);

            foreach (int i in stack1)
            {
                Console.WriteLine(i);
            }

            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> stack2 = new Stack<int>(arr);
            stack2.Push(3);
            foreach (int i in stack2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(stack2.Contains(3));

            stack2.Pop(); //it's remove the top of the element that's remove 3 
            foreach (int i in stack2)
            {
                Console.WriteLine(i);
            }
            stack2.Pop(); //and it's remove 4
            Console.WriteLine(stack2.Peek());
        }
    }
}