using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class SameName
    {
        private string name;
        private int age;

        public int myage
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public string Name { get { return name; } set { name = value; } }

        

    }
}
