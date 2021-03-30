using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Simple_problem
{
    /// <summary>
    /// Compare the Triplets and give points on the basis whic crosspingind is bigger....
    /// https://www.hackerrank.com/challenges/compare-the-triplets/problem
    /// following two line commented are for program.cs to call this function......
    /// CompareTheTriplets objc = new CompareTheTriplets();
    /// objc.compareTheTriplets();
    /// </summary>
    class CompareTheTriplets
    {
        List<int> a;
        List<int> b;
        int n = 3;
        int countAlice =0;
        int countBob =0;

        public void compareTheTriplets()
        {
            Console.Write("Enter the interger list values: ");
            a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            Console.Write("Enter another interger list values: ");
            b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            for (int i = 0; i < n; i++)
            {
                if (a[i] > b[i])
                {
                    countAlice++;
                }
                else if (a[i] < b[i])
                {
                    countBob++;
                }
            }
            List<int> result = new List<int>();
            result.Add(countAlice);
            result.Add(countBob);
           // return result;
            Console.ReadLine();
        }

        
    }
}
