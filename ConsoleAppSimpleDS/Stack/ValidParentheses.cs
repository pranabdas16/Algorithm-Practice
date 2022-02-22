using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSimpleDS
{
   public class ValidParentheses
    {
        Stack<char> objStack = new Stack<char>();
        Queue<char> objQueue = new Queue<char>();

        public void Enterparentheses()
        {
            Console.WriteLine("enter the parentheses as input value:");
            string str = Convert.ToString(Console.ReadLine());
            foreach (char c in str)
            {
                objQueue.Enqueue(c);
            }
        }

        public void PrintQueue()
        {
            Console.Write("Value of Queue:");
            foreach(char c in objQueue)
            {
                Console.Write(" " + c + "->");
            }
        }

        public void ValidateParentheses()
        {
            char prevChar, currntChar;
            prevChar = '\0';
            foreach (var c in objQueue)
            {
                currntChar = c;
                if (prevChar == currntChar)
                {
                    objStack.TryPop(out currntChar);
                }
                else
                {
                    objStack.Push(currntChar);
                }
                prevChar = c;
            }
            PrintStack();
        }

        public void PrintStack()
        {
            Console.WriteLine("List of Stack:");
            foreach (char c in objStack)
            {
                Console.Write(" " + c + "->");
            }
        }
    }
}
