using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Simple_problem
{
    class ListSample
    {
        /// <summary>
        /// Diagonal Difference......
        /// Given a square matrix, calculate the absolute difference between the sums of it's diagonals....
        /// Below is the code for program.cs commnented to call...
        /// ListSample objLustLIst = new ListSample();
        /// objLustLIst.listSample();
        /// </summary>
        
        List<int> arr = new List<int>();
        List<int> arr1 = new List<int>();
        List<int> arr2 = new List<int>();

        List<List<int>> lustlist = new List<List<int>>();
        public void listSample()
        {
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);

            arr1.Add(4);
            arr1.Add(6);
            arr1.Add(6);

            arr2.Add(7);
            arr2.Add(8);
            arr2.Add(9);

            lustlist.Add(arr);
            lustlist.Add(arr1);
            lustlist.Add(arr2);

            //2 3 4
            //4 5 6
            //7 8 9
            int d1 = 0, d2 = 0, n;
            n = lustlist.Count;
            Console.WriteLine("count of n: " + n);
            for (int i = 0; i < lustlist.Count; i++)
            { 
                for(int j = 0; j < lustlist[i].Count; j++)
                {
                   
                    //Just to print above commnented value..
                    Console.Write(lustlist[i][j] + "[" + i + "][" + j +"]  ");
                    if (i == j)
                        d1 += lustlist[i][j];
                    if (i == n - j - 1)
                        d2 += lustlist[i][j];
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Value of d1: " + d1 + "and d2: " + d2);
            Console.WriteLine();
            if (d1 > d2)
            {
                d1 = (d1 - d2);
            }
            else if (d2 > d1)
            {
                d1 = (d2 - d1);
            }
            else if (d1 == d2)
            {
                d1 = 0;
            }
            Console.WriteLine(d1);
            Console.ReadLine();
        }
    }
}
