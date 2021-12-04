using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }

        public Node()
        {

        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

        public void AddToBeginning(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
        }

        public void AddSort(int data)
        {
            if (next == null)
                next = new Node(data);
            else if (next.data > data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSort(data);
            }
        }


        public void DeleteLast()
        {
            if(next != null)
            {
                if (next.next == null)
                    next = null;
                else
                {
                    Node temp = new Node();
                    temp = next;
                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                }
                    
            }
        }

        public void print()
        {
            Console.Write("|" + data + "->");
            if (next != null)
            {
                next.print();
            }
        }
    }
}
