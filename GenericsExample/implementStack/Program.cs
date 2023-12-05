namespace implementStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyStack stack = new MyStack();
            //stack.push(10);
            //stack.push(20);
            //stack.push(30);
            //stack.push(40);
            //Console.WriteLine(stack.Count);
            //stack.pop();
            //Console.WriteLine(stack.Count);
            //stack.pop();
            //stack.pop();
            //stack.pop();
            //stack.pop();
            //Console.WriteLine(stack.Count);

            MyStack<int> stack = new MyStack<int>();    
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            foreach (int i in stack)
            {

            }
        }
    }
}