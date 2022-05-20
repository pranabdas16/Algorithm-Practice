using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleLL
{
    public class SingleLinkedList7
		{
			public Node7 Head;
			public Node7 Head2;
			public int List1Counter = 0;
			public int List2Counter = 0;

			public void AddToHead(int element)
			{
				Node7 newNode = new Node7();
				newNode.Data = element;
				newNode.Next = Head;
				Head = newNode;
				List1Counter++;
			}

			public void ReverseList()
			{
				Node7 tempList = Head;
				AddToHead2(tempList);

			}

			public void AddToHead2(Node7 tmpList)
			{
				while (tmpList != null)
				{
					int val = tmpList.Data;
					Node7 secondTempList = new Node7();
					secondTempList.Data = val;
					secondTempList.Next = Head2;
					Head2 = secondTempList;
				
					tmpList = tmpList.Next;
				}
			}

			public void AddToTail(int element)
			{
				if (Head == null)
					AddToHead(element);
				else
				{
					Node7 newNode = new Node7();
					newNode.Data = element;
					newNode.Next = null;

					Node7 temp = new Node7();
					temp = Head;
					while (temp.Next != null)
					{
						temp = temp.Next;
					}
					temp.Next = newNode;
					List1Counter++;
				}

			}

			public void AddToPosition(int pos, int element)
			{
				if (pos == 0)
					Console.WriteLine("Enter correct position");
				else if (pos == 1)
					AddToHead(element);
				else
				{
					Node7 tempNode = new Node7();
					tempNode = Head;
					try
					{
						for (int i = 1; i < pos - 1; i++)
						{
							tempNode = tempNode.Next;
						}
						Node7 newNode = new Node7();
						newNode.Data = element;
						newNode.Next = tempNode.Next;

						tempNode.Next = newNode;
					}
					catch (Exception)
					{
						throw;
					}
					List1Counter++;
				}

			}

			public void RemoveAtHead()
			{
				Node7 tempList = Head;

				Head = tempList.Next;
			}

			public void RemoveAtPosition(int pos)
			{
				Node7 tempList = Head;
				if (pos == 0)
					Console.WriteLine("Enter correct position");
				else if (pos == 1)
				{
					RemoveAtHead();
				}
				else
				{
					try
					{
						for (int i = 1; i < pos - 1; i++)
						{
							tempList = tempList.Next;
						}
						if (tempList.Next.Next == null)
							tempList.Next = null;
						else
							tempList.Next = tempList.Next.Next;
					}
					catch (Exception)
					{

						throw;
					}
				}
				List1Counter--;
			}

			public void PrintList()
			{
				Console.Write("Here is the List:");
				Node7 temp = new Node7();
				temp = Head;
				while (temp != null)
				{
					Console.Write($"|{temp.Data}|->");
					temp = temp.Next;
				}
				Console.WriteLine();
				Console.WriteLine($"Total number in the List {List1Counter}");
			}

			public void PrintReverseList()
			{
				Console.Write("Here is the List:");
				Node7 temp = new Node7();
				temp = Head2;
				while (temp != null)
				{
					Console.Write($"|{temp.Data}|->");
					temp = temp.Next;
				}
				Console.WriteLine();
				Console.WriteLine($"Total number in the List {List1Counter}");
			}
	
	}
}
