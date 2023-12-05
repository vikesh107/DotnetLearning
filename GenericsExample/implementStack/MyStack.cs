using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementStack
{
    internal class MyStack<T>
    {
        T[] myStack = new T[4];
        int currentSize = -1;
        //int count;
        public void push(T a)
        {
            currentSize = currentSize + 1;
            myStack[currentSize] = a;
        }

        public int Count { 
          get { return currentSize +1; }
           
        } 

        public void pop()
        {
            Console.WriteLine(myStack[currentSize]);
            currentSize--;
        }
    }
}
