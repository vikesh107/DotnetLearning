using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    public class Demo //: RecordClass cat't possible becouse record kjo record hi inharote kar sakta hai
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Address { get; set; }   this is mutable
        //how to amke id are imutable in traditional way...
        public Demo(int Num)
        {
            Id = Num;
        }
        public int Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
