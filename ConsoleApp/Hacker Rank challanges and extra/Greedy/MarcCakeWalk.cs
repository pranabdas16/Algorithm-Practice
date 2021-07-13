using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Mark Cake Walk
    /// https://www.hackerrank.com/challenges/marcs-cakewalk/problem
    /// MarcCakeWalk objMCW = new MarcCakeWalk();
    /// objMCW.marcCakeWalk();
    /// </summary>
    public class MarcCakeWalk
    {
        public void marcCakeWalk()
        {
            Stopwatch objClock = new Stopwatch();
            objClock.Start();
            List<int> calories = new List<int>();
            calories.Add(7);
            calories.Add(4);
            calories.Add(9);
            calories.Add(6);

            int i = 1;
            int j = i;
            int temp = 0;
            while (i < calories.Count)
            {
                j = i;

                while (j > 0 && calories[j - 1] > calories[j])
                {
                    temp = calories[j];
                    calories[j] = calories[j-1];
                    calories[j - 1] = temp;

                    j--;
                }

                i++;
            }
            Console.WriteLine(string.Join(",", calories));
            Console.WriteLine("Above worked");
            for (int k = 0; k < calories.Count; k++)
            {
                Console.WriteLine(calories[k]);           
            }

            int x = calories.Count-1;
            int y = 0; double z =0;
            while (x >= 0)
            {
                z +=calories[x] * Math.Pow(2, y);
                y++;
                x--;
            }
            long ll = long.Parse(z.ToString());
            Console.WriteLine("Marc Cake Walk value: "+ z);
            objClock.Stop();


                
                
         }
    }
}
