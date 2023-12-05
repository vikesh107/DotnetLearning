namespace VirtualKeyWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Animal obj1 = new Animal();
            obj1.makeSound(); // this called animal method


            Animal animal = new Cat();
            animal.makeSound(); // ye CAT ke mthod ko call karenga

            Cat obj = new Cat();
            obj.makeSound();   // ye to cat ke method ko hi call karenga
            Console.ReadLine(); 
        }
    }
}