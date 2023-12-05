using System.Xml.Schema;

namespace JoinsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studemt> ineer = new List<Studemt>()
            {
                new Studemt(){sId = 1,sName = "Vikesh Gupta",sAddressId = 1},
                new Studemt(){sId = 2,sName = "Rinkesh Gupta",sAddressId=2},
                new Studemt(){sId = 12,sName = "Satyam Gupta" ,sAddressId=3},
                new Studemt(){sId = 7,sName = "Harshit",sAddressId = 0},
                new Studemt(){sId = 8,sName = "Gnagadhar",sAddressId = 4},
            };

            List<Address> outer = new List<Address>()
            {
                new Address(){aId = 1,aAddress="Ambikapur, Chhattisgarh",aPinCode=497235},
                new Address(){aId = 2,aAddress="Raipur, Chhattisgarh",aPinCode=497001},
                new Address(){aId = 3,aAddress="Bilaspur, Chhattisgarh",aPinCode=213212},
                new Address(){aId = 8,aAddress="Surajpur, Chhattisgarh",aPinCode=492125},
                new Address(){aId = 4,aAddress="Bhilai, Chhattisgarh",aPinCode=490020},
            };

            var sq = from s in ineer
                     join a in outer
                     on s.sAddressId equals a.aId
                     select new
                     {
                         Name = s.sName,
                         Adress = a.aAddress,
                         StudentId = s.sId
                     };


            var mq = ineer.Join(outer, s => s.sAddressId, a => a.aId, (stemp, atemp) => new { Name = stemp.sName,Adress = atemp.aAddress });
           


            var letsq = from tem in ineer select new
            {
                Name = tem.sName,
                StudentId = tem.sId
            };
            foreach (var s in letsq)
                Console.WriteLine(s.Name + s.StudentId);
            Console.WriteLine("-------------------------------");
            var lestsq1 = from s in ineer
                          let name = s.sName + " " + s.sId
                          select new {
                              name1 = name
                          };

            foreach (var t1 in lestsq1)
                Console.WriteLine(t1.name1);
            Console.WriteLine("-------------------------------");




            Console.WriteLine(sq.Count());

            foreach (var student1 in sq)
                Console.WriteLine(student1.Name + " " + student1.Adress + " " + student1.StudentId);




        }
    }

    public class Studemt
    {
        public int sId { get; set; }
        public string sName { get; set; }
        public int sAddressId { get; set; }

    }

    public class Address
    {
        public int aId { get; set; }
        public string aAddress { get; set; }

        public int aPinCode { get; set; }
    }
}