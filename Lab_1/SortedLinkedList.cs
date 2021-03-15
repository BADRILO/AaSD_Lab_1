using System;

namespace Lab_1
{
    class SortedLinkedList
    {
        private int len;
        private Node first;

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
        public void addItem(int item)
        {
            if (this.IsEmpty() || item < first.Data)
            {
                Node node = new Node(item, first);
                first = node;
                len++;
            }
            else
            {
                Node lower_node  = first;
                Node bigger_node = first.Next;

                while (true)
                {
                    if (bigger_node == null || item < bigger_node.Data)
                    {
                        Node node = new Node(item, bigger_node);
                        lower_node.Next = node;
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
                Node pointer = first;
                for (int i = 1; pointer != null;)
                {
                    Console.WriteLine($"Node №{i++}: {pointer.Data}");
                    pointer = pointer.Next;
                }
            }          
            Console.WriteLine();
        }
        public int? deleteItem(int item)
        {
            if (this.IsEmpty())
                Console.WriteLine("There is nothing to delete!\n");
            else if (first.Data == item)
            {
                first = first.Next;
                len--;
                return item;
            }
            else
            {
                Node prev_node = first;
                Node curr_node = first.Next;

                while (curr_node != null)
                {
                    if (curr_node.Data == item)
                    {
                        prev_node.Next = curr_node.Next;
                        len--;
                        return item;
                    }
                    curr_node = curr_node.Next;
                    prev_node = prev_node.Next;
                }
            }
            return null;
        }
        public bool Search(int item, out int? item_out)
        {
            Node node = first;

            while (node != null)
            {
                if (node.Data == item)
                {
                    item_out = item;
                    return true;
                }
                node = node.Next;
            }
            item_out = null;
            return false;
        }
        //public SortedLinkedList copyReverse()
        //{
            //SortedLinkedList list_out = new SortedLinkedList();

            //if (this.IsEmpty())
            //    return list_out;
            //else
            //{
            //    for (Node node = first; node != null; node = node.Next)
            //    {
            //        Node n = new Node(node.Data, list_out.first);

            //    }
            //    return list_out;
            //}
        //}
        private void append(int item)
        {
            Node node = new Node(item, first);
            first = node;
            len++;
        }
    }
}
