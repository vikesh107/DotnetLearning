namespace Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo demo = new Demo();
            //demo.Name = "Test";
            //demo.Id = 1;
            //demo.Address = "Test Address";
            //Console.WriteLine(demo.Name + " " + demo.Address + " "+ demo.Id);

            //demo.Name = "Change test name";  // yaha se chnage kiya ja sakta hai......
            //Console.WriteLine(demo.Name + " " + demo.Address + " " + demo.Id);

            //Console.WriteLine("------------------ In Traditional Way -------------------------------");

            //Demo demo = new Demo(10);
            //demo.Name = "Test";
            //demo.Address = "Address";

            //Demo demo1 = new Demo(10); ;
            //demo.Name = "Test1";
            //demo.Address ="Address1";

            //demo1.Id = 12; ye nhibkar sakte kiuki hamne Id ke set method ko hata kr init kar diya hai...

            Demo1 demo1 = new Demo1 {
               
                name = "Test",
                address = " addresss"
            };

            Console.WriteLine(demo1.Id + " " + demo1.name + " " + demo1.address);
            //demo1.Id = 12; ye to kar hi nahi sakta mai yaar kiuki isko intit kar diya gaya hai
            demo1.name = "Test chnage";
            demo1.address = "Chnage address";

            Console.WriteLine(demo1.Id+ " "+ demo1.name + " "+demo1.address);

            var demo2 = new RecordClass(); //record class ka object banaya ja sakta hai
            var demo3 = new RecordClass { Id = 12,Name = "Vikesh Gupta",Address = "Ambikapur" };

            var  demo4 = new RecordClass { Id = demo3.Id, Name = demo3.Name, Address = "Raipur" };

            //demo3.Id = 34; ye to nhi karne denga

            Console.WriteLine(demo3.Id + " " + demo3.Name + " " + demo3.Address);
            Console.WriteLine(demo4.Id + " " + demo4.Name + " " + demo4.Address);  // yaha par value chnage hai pr same object ka value chnage nahi hai


            var demo5 = demo4 with { Address = "Bas Address Chnage" };





        }
    }
    
}