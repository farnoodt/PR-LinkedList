using System;


namespace PR_LinkedList
{
    public class MyList
    {
        public Node headNode;
        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddtoFirst(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }


        public void AddSort(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (headNode.data > data)
            {
                AddtoFirst(data);
            }
            else
            {
                headNode.AddSort(data);
            }
        }

        public void Delete_Beginning()
        {
            if(headNode != null)
                headNode = headNode.next;
        }

        public void Delete_Last()
        {
            if(headNode != null)
            {
                if (headNode.next == null)
                {
                    headNode = null;
                }
                else
                {
                    headNode.DeleteLast();
                }
            }
        }

        public void reverse()
        {
            Node rev = headNode;
            Node temp = headNode;
            Node curr = headNode.next;

            rev.next = null;

            while (curr != null)
            {
                temp = curr.next;
                curr.next = rev;
                rev = curr;
                curr = temp;
            }
            headNode = rev;
        }
        public void print()
        {
            //Console.Write("|" + headNode.data +"->");
            //if (headNode.next != null)
            //    headNode.next.print();

            if (headNode != null)
                headNode.print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList ML = new MyList();
            //ML.AddToEnd(10);
            //ML.AddToEnd(11);
            //ML.AddToEnd(12);
            //ML.AddtoFirst(9);
            ML.AddSort(3); 
            ML.AddSort(6);
            ML.AddSort(2);
            ML.AddSort(5);
            //ML.Delete_Last();
            ML.reverse();
            ML.print();

        }
    }
}
