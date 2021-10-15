using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    class FizzBuzz
    {
        /// <summary>
        /// https://leetcode.com/problems/fizz-buzz/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<string> fizzBuzz(int n)
        {

            List<string> ansList = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ansList.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    ansList.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    ansList.Add("Buzz");
                }
                else
                {
                    ansList.Add("i");
                }
            }
            return ansList;
        }
    }
}
