using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackLib
{
    public class MyStack
    {
        int[] value = new int[20];

        public int Count { get; private set; }

        public void Push(int value)
        {
            this.value[Count] = value;
            this.Count++;
        }

        public int Pop()
        {
            this.Count--;
            return this.value[Count];
        }

    }
}
