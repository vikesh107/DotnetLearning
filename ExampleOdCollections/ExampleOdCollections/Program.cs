using System.Collections;

namespace ExampleOdCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr_list = new ArrayList();
            arr_list.Capacity = 3; //Gets or sets the number of elements that the ArrayList can contain.
            //Console.WriteLine(arr_list.IsFixedSize);  	Gets a value indicating whether the ArrayList has a fixed size.
            //Console.WriteLine(arr_list.IsReadOnly);  Gets a value indicating whether the ArrayList is read-only.
            arr_list.Add("Vikesh0");
            arr_list.Add("Vikesh1");
            arr_list.Add("Vikesh2");
            arr_list.Add("Vikesh3");
            arr_list.Add("Vikesh4");
            arr_list.Add("Vikesh5");

            foreach (var item in arr_list)
            {
                Console.WriteLine(item);
            }

            arr_list.Insert(2, "Rinkesh");

            IEnumerable objects = arr_list;

            IEnumerator item01 = objects.GetEnumerator();
            while (item01.MoveNext())
            {
                Console.WriteLine((string)(item01.Current));
            }


            arr_list.Remove("Vikesh0"); // that's remove the Value you pass the as a parameter
            Console.WriteLine("-----------");
            foreach (var item in arr_list)
            {

                Console.WriteLine(item);
            }

            arr_list.RemoveAt(3);   //remove the element of index 3
            Console.WriteLine("-----------");
            foreach (var item in arr_list)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine(arr_list.Contains(300)); // if this is contanis the value then they return ture or false value jst like there this is return false value
            Console.WriteLine(arr_list.Contains("Vikesh2")); //this is return true value

            //arr_list.Add(200);
            arr_list.Sort();  //they sort the arrylist according they presnt type in arrylist

            //Console.WriteLine("-----------");
            //foreach (var item in arr_list)    // they give the error becuse in this int value prestbne
            //{

            //    Console.WriteLine(item);
            //}

            Console.WriteLine("-----------");
            foreach (var item in arr_list)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine(arr_list.IndexOf("Vikesh1")); // return the index of Vikesh1 (1)

            var arr1 = new string[arr_list.Count];
            arr_list.CopyTo(arr1, 0);
            Console.WriteLine("-----Copy To------");
            foreach (var item in arr1)
            {

                Console.WriteLine(item);
            }


            Console.WriteLine("Object Intrilizer and get the value with the help of index...");
            ArrayList arrylist1 = new ArrayList() { "vikesh", 1, 34, 5, 756.7f };
            for (int i = 0; i < arrylist1.Count; i++)
            {
                Console.WriteLine(arrylist1[i]);
            }
        
        }
    }
}