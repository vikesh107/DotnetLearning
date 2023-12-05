namespace GenricClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example example = new Example(12);
            //Example example1 = new Example("Yaha String pass nahi kar sakte lkiuki iske cpoonstrcutor mr likjha hua ki ye bas int ype ki value leta hai");

            Example1<int> example = new Example1<int>(12);
            Example1<string> example1 = new Example1<string>("Vikesh");
            Console.WriteLine( example.getbox());
            Console.WriteLine( example1.getbox());

            Demo<int> demo  = new Demo<int>();  
            demo.MyProperty = 1;
            demo.MyProperty = 12;
            Console.WriteLine(demo.MyProperty);

            Demo<float> demo1 = new Demo<float>();
            demo1.MyProperty = 123.5f;
            Console.WriteLine(demo1.MyProperty);

            Demo<string> srt = new Demo<String>();
            srt.MyProperty = "Vikesh Gupta";
            Console.WriteLine(srt.MyProperty);
            //Console.WriteLine(example.getbox());
        }
    }

    class Example
    {
        private int box;
        public Example(int data) { 
            this.box = data;
        }
        public int getbox()
        {
            return box;
        }
    }

    class Example1<T>
    {
        private T box;
        public Example1(T data)
        {
            this.box = data;
        }
        public T getbox()
        {
            return box;
        }
    }

    class Demo<S> {
        public S MyProperty { get; set; }
    }

}