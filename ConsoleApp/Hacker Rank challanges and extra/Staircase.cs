using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class Staircase
    {
        public void staircase()
        {
            int n = 6, l = 1;

            while (n > 0)
            {
                for (int i = n; i > 1; i--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < l; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                l++;
                n--;
            }
            Console.ReadLine();
        }
    }
}
