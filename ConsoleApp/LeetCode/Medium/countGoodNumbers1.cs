using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    class CountGoodNumbers1
    {
        public void countGoodNumbers1()//long n)
        {
            long n1 = 4;
            int j = 0;
            int counter = 0;
            List<long> listOfNo = new List<long>();
            while (j.ToString().Length <= n1)
            {
                //if (Math.Pow(2, j) % 2 == 0)
                //{
                listOfNo.Add(j);
                counter++;
                // }
                j = j + 2;
            }
            Console.WriteLine(string.Join(",", listOfNo));
            Console.WriteLine("Here is the count of Good Numbers: {0}", counter);
        }
    }
}
