using System;

namespace Lab_1
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
