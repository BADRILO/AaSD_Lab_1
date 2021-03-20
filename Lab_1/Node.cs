using System;

namespace Lab_1
{
    class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data, Node<T> next)
        {
            this.Data = data;
            this.Next = next;
        }

        public static bool operator <(T i, Node<T> node)
        {
            if (i is int)
            {
                int item = Int32.Parse(i.ToString());
                int node_data = Int32.Parse(node.Data.ToString());
                return item < node_data;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >(T a, Node<T> b)
        {
            return true;
        }
    }
}
