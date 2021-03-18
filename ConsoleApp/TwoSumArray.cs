using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// Sum two array value..
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// </summary>
    class TwoSumArray
    {
        public void twoSumArray()
        {
            int[] srcArry = { 2, 3, 5, 7, 11 };
            int arrayLength, val1, val2, trgtValue = 12;
            arrayLength = srcArry.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength - 1; j++)
                {
                    if (srcArry[i] + srcArry[j] == trgtValue)
                    {
                        val1 = i;
                        val2 = j;
                        Console.Write("Return value: [" + val1 + "," + val2 + "]");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
        }
    }

