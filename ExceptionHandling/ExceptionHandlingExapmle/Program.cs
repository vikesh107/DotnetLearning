using System.Linq.Expressions;

namespace ExceptionHandlingExapmle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter The First Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Plese Enter The Second  Number : ");
            int num2 = int.Parse(Console.ReadLine());
            try
            {
                int result = num1/num2;
                Console.WriteLine(result);
            }
            catch(NullReferenceException e)
            {
                
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)  // ye nahi chlenga ki
            {
                Console.WriteLine("DivideByZeroException hai ye");
                Console.WriteLine(e.Message);
                num2 = 12;
                try
                {
                    int result = num1 / num2;
                    Console.WriteLine(result);
                }
                catch
                {
                    try
                    {
                        int result = num1 / num2;
                        Console.WriteLine(result);
                    }finally { Console.WriteLine("Dekhet hai "); }

                }
                finally
                {
                    Console.WriteLine("Hello ji");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception hai ye");
            }
            finally
            {
                Console.WriteLine("ye chl raha hai ki nahi");
            }





        }
    }
}