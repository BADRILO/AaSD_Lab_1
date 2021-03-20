using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList<string> example = new SortedLinkedList<string>();
            example.printList();
            example.deleteItem("a");
            example.addItem("boi432gf78");
            example.addItem("casfs");
            example.addItem("dajgf8473tf");
            example.addItem("efio3gt489t6r");
            example.addItem("182fg48");
            example.addItem("0iluw4yfg347");
            example.printList();
            Console.WriteLine(example.deleteItem("0"));
            Console.WriteLine(example.Search("1", out string i));
            example.printList();
        }
    }
}
