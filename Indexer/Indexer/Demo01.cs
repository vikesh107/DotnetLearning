using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Demo01
    {
        int[] arr =new int[7];
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set { 
                if(value > 0)
                {
                    arr[index] = value;
                }
                
            }
        }
    }
}
