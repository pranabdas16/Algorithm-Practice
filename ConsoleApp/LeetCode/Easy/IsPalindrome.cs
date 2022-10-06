using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    class IsPalindrome
    {
        public bool isPalindrome()//int x)
        {
            int x1 = 10;
            string str = x1.ToString();
            bool result = false;
            int [] givenArray = x1.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            int n = givenArray.Count();

            int j = n;
            for (int i = 0; i <= n / 2; i++)
            {
                if (givenArray[i] == givenArray[j-1])
                    result = true;
                else
                {
                    result = false;
                    Console.WriteLine($"{result}");
                    return result;
                }
                j--;
            }
            Console.WriteLine($"{result}");
            return result;
        }
    }
}
