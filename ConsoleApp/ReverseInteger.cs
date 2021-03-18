using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ReverseInteger
    {
        public void reverseInteger(int x)
        {
            long res = 0;
            while (x != 0)
            {
                res = res * 10 + x % 10;
                x = x / 10;
            }

            if (res < int.MinValue || res > int.MaxValue)
            {
                //return 0;
                Console.Write("");
            }
            else {
                Console.Write(res);
            }
        }
    }
}
