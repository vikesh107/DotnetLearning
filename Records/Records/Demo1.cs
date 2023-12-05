using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    public class Demo1
    {
        public int Id { get; init; }  // ab ye immutable ho gaya hai buddy
        public string name { get; set; }
        public string address { get; set; }
    }
}
