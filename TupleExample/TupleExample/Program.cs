namespace TupleExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Tuple<int,int> tupleObject = program.Math(12, 10);
            Console.WriteLine(tupleObject.Item1);
            Console.WriteLine(tupleObject.Item2);


            var tubleObject1 = program.Math(120, 100);
            //Tuple<int,int> tubleObject1 = program.Math(12, 10);     ye bhi kar sakte hai kiuki apne ko ide haiki waha se tuple hi return aa raha hai.
            Console.WriteLine(tubleObject1.Item1);
            Console.WriteLine(tubleObject1.Item2);

            var tupleObject2 = program.Math2(10, 20);
            Console.WriteLine(tupleObject2.sum);
            Console.WriteLine(tupleObject2.product);
            //Console.WriteLine(tupleObject2.Item1);
            //Console.WriteLine(tupleObject2.Item2);

            var (Sum1, Product1) = program.Math2(13, 10);
            Console.WriteLine(Sum1);  
            Console.WriteLine(Product1);



            Console.ReadLine();
        }

        public Tuple<int,int> Math(int a,int b)
        {
            int c = a + b;
            int d = a * b;
            Tuple<int,int> tuple =  Tuple.Create(c, d); 
            return tuple;
        }

        public (int,int) Math1(int a,int b)
        {
            int c = a + b;
            int d = a * b;
            return (c,d);

        }

        public (int sum,int product) Math2(int a,int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }
    }
}