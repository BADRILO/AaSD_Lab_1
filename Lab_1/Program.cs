using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList<int> example = new SortedLinkedList<int>();
            example.printList();
            example.deleteItem(5);
            example.addItem(4);
            example.addItem(7);
            example.addItem(1);
            example.addItem(6);
            example.addItem(89);
            example.addItem(56);
            Console.WriteLine("Elements added\n");
            example.printList();
            Console.WriteLine(example.deleteItem(5));
            Console.WriteLine(example.deleteItem(6));
            example.printList();
            Console.WriteLine(example.Search(88, out int i));
            Console.WriteLine(example.Search( 1, out int j));
            LinkedList<int> q = example.copyReverse();
            Console.WriteLine("Reverse List:\n");
            q.printList();
            Console.WriteLine("Added element to example\n");
            example.addItem(144);
            Console.WriteLine($"Deleted element from q: {q.deleteItem(56)}\n"); 
            q.printList();
            example.printList();

            Console.WriteLine("\n\nSortedLinkedList with strings\n\n");

            SortedLinkedList<string> str_example = new SortedLinkedList<string>();
            str_example.printList();
            str_example.deleteItem("abc");
            str_example.addItem("F");
            str_example.addItem("B");
            str_example.addItem("z");
            str_example.addItem("algorithm");
            str_example.addItem("structure");
            str_example.addItem("hello");
            Console.WriteLine("Elements added\n");
            str_example.printList();
            Console.WriteLine(str_example.deleteItem("list"));
            Console.WriteLine(str_example.deleteItem("hello"));
            str_example.printList();
            Console.WriteLine(str_example.Search("array", out string k));
            Console.WriteLine(str_example.Search("B", out string o));
            LinkedList<string> rev_list = str_example.copyReverse();
            Console.WriteLine("Reverse List:\n");
            rev_list.printList();
            Console.WriteLine("Added element to str_example\n");
            str_example.addItem("program");
            Console.WriteLine($"Deleted element from rev_list: {rev_list.deleteItem("z")}\n");
            rev_list.printList();
            str_example.printList();
        }
    }
}
