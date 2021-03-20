using System;

namespace Lab_1
{
    class SortedLinkedList<T>
    {
        private int len;
        private Node<T> first;

        public int Len
        {
            get {return len;}
        }
        public SortedLinkedList()
        {
            this.len = 0;
            this.first = null;
        }
        public bool IsEmpty()
        {
            return len == 0;
        }
        public void addItem(T item)
        {
            if (this.IsEmpty() || item < first)
            {
                Node<T> node = new Node<T>(item, first);
                first = node;
                len++;
            }
            else
            {
                Node<T> lower_node  = first;
                Node<T> bigger_node = first.Next;

                while (true)
                {
                    if (bigger_node == null || item < bigger_node)
                    {
                        Node<T> new_node = new Node<T>(item, bigger_node);
                        lower_node.Next = new_node;
                        len++;
                        break;
                    }
                    bigger_node = bigger_node.Next;
                    lower_node = lower_node.Next;
                }
            }
        }
        public void printList()
        {
            if (this.IsEmpty())
                Console.WriteLine("List is empty!");
            else
            {
                Node<T> pointer = first;
                for (int i = 1; pointer != null;)
                {
                    Console.WriteLine($"Node №{i++}: {pointer.Data}");
                    pointer = pointer.Next;
                }
            }          
            Console.WriteLine();
        }
        public T deleteItem(T item)
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("There is nothing to delete!\n");
            }
            else if (first.Data.Equals(item))
            {
                first = first.Next;
                len--;
                return item;
            }
            else
            {
                Node<T> prev_node = first;
                Node<T> curr_node = first.Next;

                while (curr_node != null)
                {
                    if (curr_node.Data.Equals(item))
                    {
                        prev_node.Next = curr_node.Next;
                        len--;
                        return item;
                    }
                    curr_node = curr_node.Next;
                    prev_node = prev_node.Next;
                }
            }
            return default(T);
        }

        public bool Search(T item, out T item_out)
        {
            Node<T> node = first;

            while (node != null)
            {
                if (node.Data.Equals(item))
                {
                    item_out = item;
                    return true;
                }
                node = node.Next;
            }
            item_out = default(T);
            return false;
        }
        //public SortedLinkedList copyReverse()
        //{
        //    SortedLinkedList list_out = new SortedLinkedList();

        //    for (Node<T> node = this.first; node != null; node = node.Next)
        //        list_out.append(node.Data);

        //    return list_out;
        //}
        private void append(T item)
        {
            Node<T> node = new Node<T>(item, first);
            first = node;
            len++;
        }
    }
}
