using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList<int> example = new SortedLinkedList<int>();
            int i;
            example.printList();
            example.deleteItem(2);
            example.addItem(10);
            example.addItem(5);
            example.addItem(20);
            example.addItem(15);
            example.addItem(2);
            example.addItem(30);
            //example.printList();
            Console.WriteLine(example.deleteItem(35));
            Console.WriteLine(example.Search(7, out i));
            example.printList();
        }
    }
}
