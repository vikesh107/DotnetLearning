using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate int getDelegate(); // yaha par iski implemation nahi deni hoti hai

    public delegate void setDelegate(int num);
    public class Demo
    {
        private int num;

        public int getValue()
        {
            return num;
        }

        public void setValue(int num)
        {
            this.num = num; 
        }

    }
}
