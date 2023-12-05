using System.Collections;

namespace NonGenricCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList(); //nonn genric type array list isme klisi bhi bhi type ka dta store kar saktehai
            //var arrylist1 = new ArrayList();     //ye to kar hi sakte hai
            //dynamic  arrylist2 = new ArrayList(); 

            arrayList.Add(1);
            arrayList.Add("Vikesh");
            arrayList.Add(123.55f);
            arrayList.Add("Rinkesh Gupta");
            arrayList.Add(12121);
            //arrayList.Add(arrayList);
            //Console.WriteLine(arrayList); // name space ka naam print karta hai System.Colllection.Arraylist

            foreach(var obj in arrayList) //it any dynamic keyword are finr but yaha jaise hi int denge ye expting de denga ki ye typt kastibng nahi kar pa raha hai
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(arrayList.Count); // this print size of aaray list

            for (int i = 0; i < arrayList.Count; i++) {
                Console.WriteLine(arrayList[i]); // isko indexing se bhi accses kiya ja sakta hai
            }

            arrayList.Insert(1, "satyam"); // ye index 1 me value store kar denga
            foreach(var itam in arrayList)
            {
                Console.WriteLine(itam);
            }

            arrayList.Remove("satyam"); //exactyl same hona  chaiiye case sansative and trim bhi hona vhiayr

            foreach (var itam in arrayList)
            {
                Console.WriteLine(itam);
            }

            arrayList.RemoveAt(1); //yaha per index diya jata hai
             
            //arrayList.RemoveAt(10); // uske count e jyda value denge t index out of range ka exption aa jayenga
            foreach (var itam in arrayList)
            {
                Console.WriteLine(itam);
            }

            arrayList.Reverse(); // ye arrya list ko reverse kar denga

            foreach (var itam in arrayList)
            {
                Console.WriteLine(itam);
            }

            //arrayList.Sort();  yaha pr error aa jayenga kiui comapre karne ke liye same typeka hona jaruri hai

            //foreach (var itam in arrayList)
            //{
            //    Console.WriteLine(itam);
            //}


        }
    }
}