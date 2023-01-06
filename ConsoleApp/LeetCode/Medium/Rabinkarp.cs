using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    public class Rabinkarp
    {
        //pat = "aab";
        //txt = "babaacbabaab";
        public Rabinkarp()//public void rabinkarp(string pat, string txt)
        {
            string pat = "aab";
            string txt = "babaacbabaab";   
            int n = txt.Length;
            int m = pat.Length;
            int calcPat = 0, calctxt = 0;

            foreach (char c in pat)
            {
                int val = c;
                calcPat += val;
            }

            int k = 0;
            while(k < n-m+1)
            {
                calctxt = 0;
                string str = "";
                for (int i = k; i < k+m; i++)
                {
                    int val = txt[i];
                    calctxt += val;
                    str += txt[i];
                        if ((calcPat == calctxt) && (pat == str))
                        {
                            Console.WriteLine($"Here is the matching value: {calctxt} | {str} and starting index: {k} , end index {i}");
                        }
                }
                k++;
            }
        }
    }
}
