using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class LinkedList<T>: SortedLinkedList<T>
    {
        public LinkedList()
        {
            this.len = 0;
            this.first = null;
        }

        public void append(T item)
        {
            Node<T> node = new Node<T>(item, first);
            first = node;
            len++;
        }
    }
}
