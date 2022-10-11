using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// </summary>
    public class Reverse
    {
        public int reverse(int x)
        {
            int val, result;
            try
            {
                val = Convert.ToInt32(x);
                string newStr = "";
                string str = val.ToString();
                int totalLength, positive;
                if (x >= 0)
                {
                    totalLength = str.Length - 1;
                    positive = 1;
                }
                else
                {
                    str = str.Substring(1);
                    totalLength = str.Length -1;
                    positive = 0;
                }
                for (int i = totalLength; i >= 0; i--)
                {
                    newStr = newStr + str[i];
                }
                    try
                    {
                        if (positive == 0)
                        {
                            newStr = "-" + newStr;
                        }
                        
                    }
                    catch
                    {
                        return 0;
                    }
                    
                
                result = Convert.ToInt32(newStr);
                return result;
            }
            catch
            {
                return 0;
            }
        }
    }
}
