using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Apple and Orange....
    /// https://www.hackerrank.com/challenges/apple-and-orange/problem?h_r=next-challenge&h_v=zen
    /// Following two lines are to call this function/Class in Program.cs 
    /// AppleAndOrange objAAO = new AppleAndOrange();
    /// objAAO.appleAndOrange(2, 3,4,5);
    /// </summary>
    class AppleAndOrange
    {

        public void appleAndOrange(int s, int t, int a, int b)//, int[] apples, int[] oranges)
        {
            a = 4; b = 12; s = 7; t = 10;
            int[] apples = { 2,3,-4};
            int[] oranges = { 3, -2, -4};
            int countApple = 0, countOrange =0; 

            for (int i = 0; i < apples.Length; i++)
            {
                apples[i] = a + apples[i];

                if (apples[i] >= s && apples[i] <= t)
                {
                    countApple++;
                }
            }

            for (int j = 0; j < oranges.Length; j++)
            {
                oranges[j] = b + oranges[j];

                if( oranges[j] >= s && oranges[j] <= t)
                {
                    countOrange++;
                }
            }

            Console.WriteLine(countApple);
            Console.WriteLine(countOrange);
            Console.ReadLine();
        }
    }
}
