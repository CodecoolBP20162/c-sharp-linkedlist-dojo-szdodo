using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SinglyLinkedList
    {
        public Node Head;
        int Length;
        
        public SinglyLinkedList()
        {
            Head = new Node();
            Length = 0;
        }

        public SinglyLinkedList(object Data)
        {
            Head = new Node(Data);
            Length = 1;
        }
        
        public void Add(object Item)
        {
            if (Length == 0)
            {
                new SinglyLinkedList(Item);
                return;
            }
            Node node = Head.Next;
            while(node.hasNext())
            {
                node = node.Next;
            }
            node.Next = new Node(Item);
            Length++;
            
        }

        public void Insert(int Index, object Item)
        {
            if (Length < 0)
                return;
            if (Index > Length || Index < 0)
                throw new ArgumentException();
            Node node = Head.Next;
            for (int i = 0; i < Length; i++)
            {
                if (i == Index)
                {
                    Node NewNode = new Node(Item);
                    if (Length != Index)
                    {
                        Node next = node.Next;
                        NewNode.Next = next;
                        node.Next = NewNode;
                        Length++;
                    }
                    break;
                }
                node = node.Next;
            }
        }

        public void Remove(int Index)
        {
            Node node = Head.Next;
            for (int i = 0; i < Length; i++)
            {
                for (int j = 1; j < Length; j++)
                {
                    if (j == Index)
                    {
                        Node prevNode = (Node)this.Get(i);
                        Node NextNode = (Node)this.Get(j+1);
                        node.Next = NextNode;
                        //not done
                    }
                    node = node.Next;
                }
            }
        }

        public void Reverse()
        {

        }

        public Boolean isEmpty()
        {
            if (Head is null)
                return true;
            else
                return false;
        }

        public int Size()
        {
            int size = 0;
            Node item = Head.Next;
            while (item.hasNext())
            {
                size++;
                item = item.Next;
            }
            return Length;
        }

        public object Get(int Index)
        {
            Node node = Head.Next;
            for (int i = 0; i < Length; i++)
            {
                if (i == Index)
                {
                    break;
                }
                node = node.Next;
            }
            return node;
        }

    }
}
