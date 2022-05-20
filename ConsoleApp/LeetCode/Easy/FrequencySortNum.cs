using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/sort-array-by-increasing-frequency/
    /// 
    /// </summary>
    public class FrequencySortNum
    {
        public int[] freuencySortNum(int [] nums)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            int[] giveNums = { 2, 3, 1, 3, 2};
            List<int> resultList = new List<int>();
            int[] resulArry ;
            int currentVal =0;
            for (int i = 0; i < giveNums.Length; i++)
            {
                if (numDict.ContainsKey(giveNums[i]))
                {
                    int count;
                    numDict.TryGetValue(giveNums[i], out count);
                    numDict[giveNums[i]] = count + 1;
                }
                else
                {
                    numDict.Add(giveNums[i], 1);
                }
            }
            int counter = 0;
            foreach(var dictval in numDict)
            { 
                if(dictval.Value > 1)
                {
                    if (counter == 0)
                        currentVal = dictval.Value;
                    else
                    {
                        if (currentVal != dictval.Value)
                        {
                            currentVal = dictval.Value;
                        }
                        counter++;
                    }

                    counter++;
                }
            }
            //private IEnumerable<int> val;
           // var val = new Dictionary<int, int>(); ;
            if (counter > 1)
            {
               var val = numDict.OrderByDescending(x => x.Value);
                foreach (var v in val)
                {
                    int limit = v.Value;
                    while (limit > 0)
                    {
                        resultList.Add(v.Key);
                        limit--;
                    }
                }
            }
            else
            {
              var val = numDict.OrderBy(x => x.Value);
                foreach (var v in val)
                {
                    int limit = v.Value;
                    while (limit > 0)
                    {
                        resultList.Add(v.Key);
                        limit--;
                    }
                }
            }
            
            resulArry = resultList.ToArray();
            Console.WriteLine("**************************************");
            foreach (var c in resulArry)
            {
                Console.Write(c);
            }
            return resulArry;
        }

    }
}
