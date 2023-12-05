using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public class DatatypesConversion
    {
        static void Main(string[] args)
        {
            int intvaule = 20;
            float f = intvaule;
            Console.WriteLine(f); //implicit type conversion

            float fValue = 123.89f;
            int a = (int)fValue;  //explicit type conversion
            int a1 = Convert.ToInt32(fValue);

            Console.WriteLine(a1); // 124 here id .5 uppr then this is consider floor value and leass then .5 then go for ceeeling value

            Console.WriteLine(a);  // here print 123 due to data loss and onnly print what data are store

            //int a3 = Int32.Parse(fValue); // can't convert  showying error

            Console.WriteLine("--------------------------------------");
            CheckParse("12345");
            CheckParse("123,456,7787");
            CheckParse("  123345   ");
            CheckParse("-1234");
            CheckParse("123.456"); //not possiblr
            CheckParse("12.98"); //not possible


            Console.WriteLine("---------------Convert Flot To int------------------");
            flotToInt(123.7f);
            flotToInt(1345.00f);
            flotToInt(1233.89f);
            flotToInt(123.5f);
            flotToInt(123.49f);

            Console.ReadLine();
        }

        public static void CheckParse(String input)
        {
            try 
            {
                int a;
                int b;
                a = Convert.ToInt32(input);
                Console.WriteLine(a + " This is using Converst Class");
                b = Int32.Parse(input);
                Console.WriteLine(b + " This is using Parse Method");

            } catch(FormatException)
            {
                Console.WriteLine("Can't Parsed '{0}'", input);
            }
        }

        public static void flotToInt(float input)
        {
            int a = Convert.ToInt32(input);
            Console.WriteLine(a + " Using Convert Class");

            //int b = Int32.Parse(input); ye to eerorhi dega ye only straing ke liye use kiya jata hai

            int c = (int)input;
            Console.WriteLine(c + " Using Type Casting");


        }
    }
}
