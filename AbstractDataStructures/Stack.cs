﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataStructures
{
    public class Stack
    {

        private int StackSize;
   
        public int top;
        Object[] item;

        public Stack(int capacity)
        {
            StackSize = capacity;
            item = new Object[StackSize];
            top = -1;
        }
        public bool isEmpty()
        {
            if (top == -1) return true;

            return false;
        }
        public void Push(object element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }

            else
            {

                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }
        public object Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                   return "No elements";
            }
            else
            {

                return item[top--];
            }
        }
        public object Peek()
        {
            if (isEmpty())
            {

                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top];
            }
        }


        public void Display()
        {
            for (int i = top; i > -1; i--)
            {

                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
        }

    }
}
