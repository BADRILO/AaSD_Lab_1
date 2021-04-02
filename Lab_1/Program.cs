using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList<char> example = new SortedLinkedList<char>();
            example.printList();
            example.deleteItem('a');
            example.addItem('g');
            example.addItem('a');
            example.addItem('b');
            example.addItem('z');
            example.addItem('6');
            example.addItem('U');
            example.printList();
            Console.WriteLine(example.deleteItem('z'));
            Console.WriteLine(example.Search('U', out char i));
            LinkedList<char> q = example.copyReverse();
            q.printList();
            example.printList();
            example.addItem('R');
            Console.WriteLine(q.deleteItem('b')); 
            example.printList();
            q.printList();
            Console.WriteLine($"{q.Len}, {example.Len}");
        }
    }
}
