using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode
{
    class ValidNumber
    {
        /// <summary>
        /// https://leetcode.com/problems/valid-number/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsNumber(string s)
        {
            //Ascii 065 090 (A to Z)
            //Ascii 097 122(a to z)

            //Ascii 48 50(0 to 9)

            //Ascii 46(.)

            //69 - E    43:+ 45:-
            //101 - e

            bool result = false;
            char[] charArray = s.ToCharArray();
            Byte[] ascIIChar = Encoding.ASCII.GetBytes(charArray);
            int n = 0;
            int signCounter = 0; int preECounter = 0; int postECounter = 0; int dotCounter = 0;

            while(n < s.Length)
            {
                if (101 > ascIIChar[n] && ascIIChar[n] <= 122)
                {
                    result = false;
                    return result;
                }
                else if (97 >= ascIIChar[n] && ascIIChar[n] < 101)
                {
                    result = false;
                    return result;
                }
                else if (69 > ascIIChar[n] && ascIIChar[n] <= 90)
                {
                    result = false;
                    return result;
                }
                else if (65 >= ascIIChar[n] && ascIIChar[n] < 69)
                {
                    result = false;
                    return result;
                }
                else if (43 == ascIIChar[n] || 45 == ascIIChar[n])
                {
                    signCounter++;
                    if (signCounter == 2)
                    {
                        result = false;
                        return result;
                    }
                }
                else if (46 == ascIIChar[n])
                {
                    dotCounter++;
                }
                else if (48 >= ascIIChar[n] && ascIIChar[n] <= 50)
                {

                    if (dotCounter == 0)
                    {
                        preECounter++;
                    }
                    else if (dotCounter == 1)
                    {
                        postECounter++;
                    }
                }

                n++;
            }

            return result;

        }
    }
}
