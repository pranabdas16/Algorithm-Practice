using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankConsoleApp.LeetCode
{
   public class PascalTriangle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> resultList = new List<IList<int>>();
            List<int> currentList = new List<int>();
            IList<int> previousList = new List<int>();

            //Add to current list for that for that level....
            for (int i =0; i< numRows; i++)
            {
                if (resultList.Count != 0)
                {
                    previousList = resultList[i-1];
                }

                if ((i == 0) && (numRows >=1) )
                {
                    currentList.Add(1);
                }
                else if ((i == 1) && numRows == 2)
                {
                    currentList.Add(1);
                    currentList.Add(1);
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if(j==0)
                            currentList.Add(1);
                        else if(j==1)
                        {
                            for (int k = 0; k < previousList.Count - 1; k++)
                            {
                                int sum = previousList[k] + previousList[k + 1];
                                currentList.Add(sum);
                                sum = 0;
                            }
                        }
                        if (j == 2)
                        {
                            currentList.Add(1);
                        }
                    }
                    
                }
                resultList.Add(currentList); // Add new list to final result list.....
                currentList = new List<int>();  // Create new list to add new list inside list.

            }
            foreach (List<int> c in resultList)
            {
                foreach (int val in c)
                {
                    Console.Write( $"{val},");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            IList<IList<int>> newResult = new List<IList<int>>();
            newResult = resultList;
            return resultList;
        }
    }
}
