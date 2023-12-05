using System.Collections;

namespace GenricCollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> authors = new List<string>(2);
            Console.WriteLine(authors.Count); //bina add kiye uska size print karyenga tpo zero deta hai kiuki iska implemention time size diya jata hai or had se jyfa sizer baha bhi denge to bhi ye automatic lr lrrnga

            string[] animals = { "Cow", "Camel", "Elephant" };
            List<string> animalsList = new List<string>(animals);

            List<string> animalsList1 = new List<string>(3) { "vikesh","rinkesh","satyam",Convert.ToString(1)};

            Console.WriteLine(animalsList.Count);
            foreach (string animal in animalsList1)
            {
                Console.WriteLine(animal);
            }

            IEnumerator value = animalsList1.GetEnumerator();
            while (value.MoveNext())
            {
                Console.WriteLine("-------------");
                Console.WriteLine(value.Current);
            }
        }
    }
}