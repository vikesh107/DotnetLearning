namespace FirstAndFirstDefult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>() { "Vikesh","Rinkesh","Satyam","Abhishek","Vaj"};

            var synTextQuery = (from brotehr in mylist orderby brotehr select brotehr).First();
            Console.WriteLine(synTextQuery); 

            //var synTextQuery3 = (from brotehr in mylist where brotehr == "Vikesh1" select brotehr).First() ;
            //Console.WriteLine(synTextQuery3);  Syetem.ivaid Oportio n

            var synTextQuery1 = (from brotehr in mylist where brotehr == "Vikesh1" select brotehr).FirstOrDefault();
            Console.WriteLine(synTextQuery1); //null print kar denga

            var MethodQuery = mylist.Where(e=>e.Length < 2 ).FirstOrDefault();
            Console.WriteLine("Method Query Ka output = "+MethodQuery);

            //var MethodQuery1 = mylist.Where(e => e.Length < 2).First();   // this print System.InvalidOperationException
            //Console.WriteLine("Method Query Ka output = " + MethodQuery1);

            var MethodQuery2 = mylist.Where(name =>  name.Length <= 3 ).OrderBy(name =>name ).First();
            Console.WriteLine(MethodQuery2);
        }
    }
}