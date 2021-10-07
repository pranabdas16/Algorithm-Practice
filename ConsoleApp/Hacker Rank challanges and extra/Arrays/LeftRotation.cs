using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra.Arrays
{
    /// <summary>
    /// Array : Left Rotation
    /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D%5B%5D=arrays
    /// Test case 8 and 9 failed due to performance issue....
    /// following is the link for performance benchmark
    /// https://support.hackerrank.com/hc/en-us/articles/1500002392722-Execution-Environment
    /// </summary>
    /// for call in Program file
    /// LeftRotation objLeftRotatin = new LeftRotation();
    //        objLeftRotatin.leftRotation();

    class LeftRotation
    {
        public void leftRotation()
        {
            List<int> a = new List<int> { 1, 2, 3, 4, 5};
            int[] inArr = a.ToArray();
            List<int> b = inArr.ToList<int>();
            int[] inputArray= { 1, 2, 3, 4, 5}; // {2, 3, 4, 5, 1}  { 3, 4, 5, 1, 2} { 4, 5, 1, 2, 3} {5, 1, 2, 3, 4}
            int[] SecondArray = new int[inputArray.Length];
            int counter = 4;
            int k = counter;
            while (k > 0)
            {
                int j = 0;
                    for (int i = 1; i <= inputArray.Length; i++)
                    {
                        if (i == inputArray.Length )
                        {
                            SecondArray[j] = inputArray[0];

                        }
                        else
                        {
                            SecondArray[j] = inputArray[i];
                        }
                            j++;
                    }
                k--;
                System.Array.Copy(SecondArray, inputArray, inputArray.Length);
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(SecondArray[i]);
            }
            Console.ReadLine();
        }
    }
}
//
/* 
 * 
 * 
 * 
 * 
 */
//
