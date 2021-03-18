using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    class StackIntSimple
    {
        public void stackIntegerSimple(int value)
        {
            string str = value.ToString();
            char[] charArray = str.ToCharArray();
            int[] intArry = new int[] { value };

            Stack<int> objStackInt = new Stack<int>(intArry);

            for (int i = 0; i < intArry.Length - 1; i++)
            {
                objStackInt.Push (intArry[i]);

            }

            foreach (var c in objStackInt)
            {
                Console.Write(c + ",");
            }
            Console.ReadLine();

        }
    }
}
