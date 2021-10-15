using System;
using System.Collections;

namespace NonGenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack();
            obj.Push("Hello");
            obj.Push(10);
            obj.Push(true);
            //Printing all in LIFO
            foreach (object o in obj)
            {
                Console.WriteLine(o + " ");
            }
            //Printing top
            Console.WriteLine(obj.Peek());
            //Printing top and removing
            Console.WriteLine(obj.Pop());
        }
    }
}
