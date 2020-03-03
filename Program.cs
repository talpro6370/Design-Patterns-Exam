using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StackEx.structClass;

namespace StackEx
{
    class Program
    {
        static void Main(string[] args)
        {
            structClass str = new structClass();
            data d = new data();
            d.Stack = new Stack<int>();
            int maxNum = 0,minNum=0,temp=0;
           
            str.push(5, d);
            int s = d.Max;
            str.push(14, d);
            str.push(44, d);
            str.push(2, d);
            str.push(48, d);
            maxNum = str.GetMaxNum(d);
            minNum = str.GetMinNum(d);
            temp = str.pop(d);
            maxNum = str.GetMaxNum(d);
            Console.WriteLine($"{maxNum }{minNum}");


        }
        //public static void push(int x,Stack<int> stack)
        //{
        //    stack.Push(x);
        //}
        //public static int pop(int x, Stack<int> stack)
        //{
        //    return stack.Pop();
        //}
        //public static int peek(int x, Stack<int> stack)
        //{
        //    return stack.Peek();
        //}
        //public void  PrintMaxValueNum(Stack<int> stack)
        //{
        //    Console.WriteLine(stack.Max());
        //}
        //public void PrintMinValueNum(Stack<int> stack)
        //{
        //    Console.WriteLine(stack.Min());
        //}
    }
}
