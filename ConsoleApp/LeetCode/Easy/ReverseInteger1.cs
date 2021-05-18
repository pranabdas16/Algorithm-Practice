using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
   public class ReverseInteger1
    {
        /// <summary>
        /// ReverseInteger1 objrvrs = new ReverseInteger1();
        /// objrvrs.reverseInteger(123);
        /// </summary>
        /// <param name="x"></param>
        public void reverseInteger(int x)
        {
            string str="";
            while (x != 0) // 123
            {
                str += x % 10;
               x= x / 10;
            }
            Console.WriteLine(str);
            Console.ReadLine();
            
        }
    }
}
