using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
   public class CommonChars
    {
        public IList<string> CommonChar(string[] words)
        {
            List<string> str = new List<string>();
            List<string> resultStr = new List<string>();
            int k = 0, count =0, n=0;
            str = words.ToList();
            string result="";
            string firstStr = str[0].ToString();

            while (k < firstStr.Length - 1)
            {
                count = 0;
                for (int i = 1; i <= str.Count - 1; i++)
                {
                    foreach (char c in str[i])
                    {
                        if (c == firstStr[k])
                        {
                            count++;
                            str.RemoveAt(k);
                            break;
                        }
                    }
                    if((i == str.Count-1) && (count == str.Count-1))
                    {
                        resultStr.Add(firstStr[k].ToString());
                        n++;
                    }
                }
                k++;
            }
            
            return resultStr;
        }
    }
}
