using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEx
{
    public class structClass
    {
        public struct data
        {
            Stack<int> stack;
            int max { get; set; }
            int min { get; set; }

            public Stack<int> Stack
            {
                get { return stack; }
                set { stack = value;}

            }
            public int Max
            {
                get { return max; }
                set { max = value;}
            }

            public int Min
            {
                get { return min; }
                set { min = value; }
            }

        }
        public void push(int x, data dat)
        {
            dat.Stack.Push(x);
            if (x > dat.Max) dat.Max = x;
            
            if (x < dat.Min) dat.Min = x;
        }

        public int pop(data dat)
        {
            int max = 0;
            max = dat.Stack.Pop();
            return max;
        }

        public int peek(data dat)
        {
            return dat.Stack.Peek();
        }
        public int GetMaxNum(data dat)
        {
            dat.Max = dat.Stack.Peek();
            foreach (int maxNum in dat.Stack)
            {
                if (maxNum > dat.Max) dat.Max = maxNum;
            }
                return dat.Max;
        }
        public int GetMinNum(data dat)
        {
            dat.Min = dat.Stack.Peek();
            foreach (int maxNum in dat.Stack)
            {
                if (maxNum < dat.Min) dat.Min = maxNum;
            }
                return dat.Min;
        }
    }
}
