namespace LamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ye lamda expression ka example hai
            Mydelegate mydel = (a) => a * a;  //this is exxpersion lambda not a statment, ye implicite retunr karta hai..

            Mydelegate mydel1 = (a) =>    //this is statemnet lambda, ye implicite kuch return nahi karta 
            {
                int b = a + a;
                return b;
            };
            Console.WriteLine(mydel.Invoke(10));
            Console.WriteLine(mydel1(039));

            // ye Anonumus function ka exampkle dekh lete hai 

            Mydelegate mydel2 = delegate (int num)
            {
                return 10+num;
            };

            Console.WriteLine(mydel2(20));
        }
    }
}

public delegate int Mydelegate(int a);  //outSide the nameSpace bhi delegate ko use kar sakte hai