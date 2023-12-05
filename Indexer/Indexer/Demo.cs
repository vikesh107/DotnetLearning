using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Demo
    {
        private int[] age = new int[3];
        public int this[int i]
        {
            get
            {
                return age[i];
            }
            set
            {
                age[i] = value;
            }
        }
    }
}
