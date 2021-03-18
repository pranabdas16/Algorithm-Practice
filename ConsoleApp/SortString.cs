using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SortString
    {
        public void shortstring(string myStr)
        {
            char temp;
            //string myStr = "Gautam"; // Here you can take input from user and assign to myStr variable  
            string str = myStr.ToLower();
            char[] charstr = str.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(charstr); //aagmtu  
            Console.ReadLine();

            //removeDuplicate( a, strLength);
            Console.ReadLine();
        }
    }
}
