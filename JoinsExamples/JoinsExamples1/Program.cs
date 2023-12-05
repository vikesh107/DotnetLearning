using System.Net;
using System.Runtime.InteropServices;

namespace JoinsExamples1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studemt> Students = new List<Studemt>()
            {
                new Studemt(){sId = 1,sName = "Vikesh Gupta",sAddressId = 1},
                new Studemt(){sId = 2,sName = "Rinkesh Gupta",sAddressId=2},
                new Studemt(){sId = 12,sName = "Satyam Gupta" ,sAddressId=3},
                new Studemt(){sId = 7,sName = "Harshit"},
                new Studemt(){sId = 8,sName = "Gnagadhar",sAddressId = 4},
            };

            List<Address> Adreeses = new List<Address>()
            {
                new Address(){aId = 1,aAddress="Ambikapur, Chhattisgarh",aPinCode=497235},
                new Address(){aId = 2,aAddress="Raipur, Chhattisgarh",aPinCode=497001},
                new Address(){aId = 3,aAddress="Bilaspur, Chhattisgarh",aPinCode=213212},
                new Address(){aId = 8,aAddress="Surajpur, Chhattisgarh",aPinCode=492125},
                new Address(){aId = 4,aAddress="Raipur, Chhattisgarh",aPinCode=490020},
            };

            var data = Students.Join(Adreeses, student => student.sAddressId, adress => adress.aId, (student, address) => new
            {
                Name = student.sName,
                Addres = address.aAddress

            });

            var data1 = from stu in Students
                        join add in Adreeses
                        on stu.sAddressId equals add.aId
                        select new { stu, add };

            var data2 = from stu in Students
                        join add in Adreeses
                        on stu.sAddressId equals add.aId
                        where add.aAddress.Contains("Raipur")
                        select new { stu, add };



            var data3 = Students.Join(Adreeses, stu => stu.sAddressId, add => add.aId, (stu, add) => new
            {
                stu,
                add

            }).Where(result => result.add.aAddress.Contains("Ra"));
           
            



            Console.ReadLine();
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