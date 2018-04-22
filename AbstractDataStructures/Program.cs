using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(3);
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            stack.Pop();
            stack.Display();
        }
    }
}
