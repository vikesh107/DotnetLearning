using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{

    class DemoTest {
       public string firstname = "Vikesh";
    }


    sealed class UseSeladClass : DemoTest
    {
        public string FulllName()
        {
            return firstname + " Gupta";
        }
    }

    
}
