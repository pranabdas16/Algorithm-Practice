using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    public class LongestPalindrome2
    {
        //LP =>Longest Palindrom
        //FP => First Pointer
        //NP => Next Pointer
        //LMI => Last matching Index
        int FP = 0, NP, counter = 0, LPcount, tempCount, lMI;
        string LPstr = "val", givenStr = "baabbbc";// =s
        bool IsPalindrome = false;
        public string longestPalindrome(string s)
        {
            while (FP < givenStr.Length)
            {
                NP = FP + 1;
                if ((NP - FP == 1) && (givenStr[FP] == givenStr[NP]))
                {
                    IsPalindrome = true;
                    NP += 1;
                }
                else
                {
                    IsPalindrome = false;
                    NP += 1;
                }

                if ((NP - FP == 2) && (givenStr[FP] == givenStr[NP]))
                {
                    IsPalindrome = true;
                    NP += 1;
                }
                else
                {
                    IsPalindrome = false;
                    NP += 1;
                }
                CheckPalindrom(FP, NP);

                FP += 1;
            }
            return LPstr;
        }

        private bool CheckPalindrom(int FP, int NP)
        {
            for (int i = FP; i < NP / 2; i++)
            {
                if (givenStr[FP] == givenStr[NP])
                {
                    IsPalindrome = true;
                    NP -= 1;
                }
                else
                {
                    IsPalindrome = false;
                    return false;
                }
            
            }

            return true;
        }
    }
}
