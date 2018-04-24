using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataStructures
{
    public class Node
    {
        public object item;
        public Node next;

        public Node()
        {
            
        }

        public Node(object item)
        {
            this.item = item;
        }
     
    }
    public class List
    {

        

        private int length;
        private Node head, lastnode;

        public List()
        {
            length = 0;
            head = null;
        }

        public int Length
        {
            get { return length; }
        }

        public bool isEmpty()
        {
            return length == 0;
        }

        public Node search(Object item)
        {
            Node nodeptr = head;
            while (nodeptr != null)
            {
                if (nodeptr.item.ToString().Equals(item.ToString()))
                {
                    break;
                }
                nodeptr = nodeptr.next;
            }
            return nodeptr;
        }

        public void remove(Object item)
        {
            Node nodeptr = head;
            Node prevptr = null;

            while (nodeptr != null)
            {
                if (nodeptr.item.ToString().Equals(item.ToString()))
                {
                    break;
                }
                prevptr = nodeptr;
                nodeptr = nodeptr.next;
            }
            if (nodeptr != null)
            {
                prevptr.next = nodeptr.next;
                length--;
            }
            else
            {
                Console.WriteLine("Can't Remove! Item not found.");
            }

        }

        public Object front()
        {
            if (!isEmpty())
            {
                return head.item;
            }
            else
            {
                Console.WriteLine("Error! The list is empty.");
                return "";
            }
        }

        public Object tail()
        {
            if (!isEmpty())
            {
                return lastnode.item;
            }
            else
            {
                Console.WriteLine("Error! The list is empty.");
                return "";
            }
        }

        public void insertAtEnd(object item)
        {
            length++;

            var node = new Node(item);

            if (head == null)
            {
                head = node;
            }
            else
            {
                lastnode.next = node;
            }

            // Makes newly added node the current node
            lastnode = node;
        }

        public void insertAtFront(object item)
        {
            length++;

            head = new Node()
            {
                next = head,
                item = item
            };

            if (length == 1)
                lastnode = head;
        }

        public override string ToString()
        {
            Node nodeptr = head;
            string nodes = "";

            while (nodeptr != null)
            {
                nodes += nodeptr.item + " ";
                nodeptr = nodeptr.next;
            }
            return nodes;
        }

        public void print()
        {
            Console.WriteLine(ToString());
        }


    }
}
