using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideKeyWord
{
    public class SubClass: BaseClass
    {
        public override void methods()
        {
            base.methods();
            Console.WriteLine("This is SubClass Methods");
            
        }
    }
}
