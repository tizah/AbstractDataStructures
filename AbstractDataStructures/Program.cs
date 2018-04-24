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
            int[] array = new int[4];
            //default value in array if its not assinged is equals to zero { 0 }
            array[0] = 1;
            array[2] = 4;
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(array[i]);
            }
            //Stack stack = new Stack(3);
            ////stack.Push(10);
            ////stack.Push(20);
            ////stack.Push(30);
            ////stack.Push(40);
            //stack.Pop();
            //stack.Display();

            //linked list
            List list = new List();
            list.insertAtFront("Banana");
            list.insertAtFront("Apple");
            list.insertAtEnd("Guava");
            list.insertAtEnd("Orange");
            list.print();

            Console.WriteLine(list.front());

            Console.WriteLine(list.tail());

            list.remove("Banana");
            list.print();

            Console.WriteLine("\nPress any key to continue..");
            Console.ReadKey();
        }
    }
}
