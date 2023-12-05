namespace MulticastDelegates
{

    public delegate void multicastdeleGate(int a,int b);
    internal class Program
    {

        public void Addition(int a,int b)
        {
            Console.WriteLine("This is Addition Method");
            Console.WriteLine(a + b);
        }

        public void Subtraction(int a,int b)
        {
            Console.WriteLine("This is Subtraction Method");
            Console.WriteLine(a - b);
        }
        public static void multiplication(int a, int b)
        {
            Console.WriteLine("This is multiplication Method");
            Console.WriteLine(a* b);
        }
        public  void division(int a, int b)
        {
            Console.WriteLine("This is division Method");
            Console.WriteLine(a/b);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            multicastdeleGate del = program.Addition;
            del = del + new multicastdeleGate(program.Subtraction) + multiplication + program.division;
            del(26, 13);

            //del = del - program.Subtraction;  // yaha par total method me subtraction method subtract ho jayenga
            //del(12, 13);

            ////del = del - program.Addition;  // yaha par total method me addtition method subtract ho jayenga to null bachenga to ye rror de denga simple hai
            ////del(12, 13);

            //del = program.Subtraction + del; //yaha pr pehle bSubtraction ka method ka object6 banenga then uske baad 
            //del(23, 13);

        }
    }

}