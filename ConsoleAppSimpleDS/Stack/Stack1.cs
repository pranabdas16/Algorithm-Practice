using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSimpleDS
{
   public class Stack1
    {
        Stack<int> objStack = new Stack<int>();
        // Enter Interger Value....
        public void InputStack()
        {
            int i = 0;
            Console.WriteLine("How many Integer value you want to enter:");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int k = 0; k < count; k++) 
            {
                if (i == 0)
                {
                    Console.WriteLine("Enter Integer value:");
                    objStack.Push(Convert.ToInt32( Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine("Enter next Integer value:");
                    objStack.Push(Convert.ToInt32(Console.ReadLine()));
                }
                i++;
            }

        }

        public void Print()
        {
            Console.WriteLine("Here are the values:");
            foreach (var val in objStack)
            {
                Console.WriteLine(val);
            
            }
        
        }


    }
}
