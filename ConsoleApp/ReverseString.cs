using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ReverseString
    {
        public void reverseString(string str)
        {
            char[] StrChar = str.ToCharArray();
            string newstr ="";

            for (int i = StrChar.Length-1; i >= 0; i--)
            {
                newstr = newstr + StrChar[i];
            }
            Console.WriteLine(newstr);
            Console.ReadLine();
        }
    }
}
