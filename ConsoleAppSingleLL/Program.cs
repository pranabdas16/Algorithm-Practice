using System;
using ConsoleAppSingleLL;
using ConsoleAppSingleLL1;

namespace ConsoleAppSingleLL
{
    class Program
    {
        
		

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Console.WriteLine("**************************Linked List 1*******************************");


			Console.WriteLine("**************************Linked List 7*******************************");
			SingleLinkedList7 objSSLL1 = new SingleLinkedList7();
			objSSLL1.AddToHead(10);
			objSSLL1.AddToHead(7);
			objSSLL1.AddToHead(5);
			objSSLL1.PrintList();
            Console.WriteLine();
            objSSLL1.AddToTail(15);
            objSSLL1.AddToTail(18);
            objSSLL1.PrintList();
            Console.WriteLine();
            objSSLL1.AddToPosition(3, 17);
            objSSLL1.PrintList();
            Console.WriteLine();
            objSSLL1.RemoveAtPosition(1);
            objSSLL1.PrintList();
            Console.WriteLine();
            Console.WriteLine("Here is the Reverse List:");
			objSSLL1.ReverseList();
			objSSLL1.PrintReverseList();
            Console.WriteLine();




            Console.WriteLine("**************************Linked List 6*******************************");
            SingleLinkedList6 objSSL6 = new SingleLinkedList6();
            objSSL6.AddToHead(5);
            objSSL6.AddToHead(4);
            objSSL6.AddToHead(3);
            objSSL6.AddToHead(1);
            objSSL6.AddToTail(7);
            objSSL6.PrintList();
            Console.WriteLine();
            objSSL6.push_at(2, 4);
            objSSL6.PrintList();
            objSSL6.pop_at(6);
            Console.WriteLine();
            objSSL6.PrintList();
            Console.WriteLine("This reverse of list:");
            objSSL6.ReverseList();
            Console.ReadLine();
            
        }
    }
}
