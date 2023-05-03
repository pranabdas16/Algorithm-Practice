using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/add-strings/description/
    /// </summary>
    public class AddStrings
    {
        public string addStrings(string num1, string num2)
        {
            int carry = 0;
            int p1 = num1.Length - 1;
            int p2 = num2.Length - 1;
            string str = "";
            while (p1 >= 0 || p2 >= 0)
            {
                int x1 = p1 >= 0 ? num1[p1] - '0' : 0;
                int x2 = p2 >= 0 ? num2[p2] - '0' : 0;
                int value = (x1 + x2 + carry) % 10;
                carry = (x1 + x2 + carry) / 10;
                str = value.ToString() + str;
                p1--;
                p2--;
            }

            if (carry > 0)
                str = carry + str;

            return str;
            //return res.reverse().toString();

            //string longstr, shortstr;
            //if (num1.Length > num2.Length)
            //{ longstr = num1; shortstr = num2; }
            //else
            //{ longstr = num2; shortstr = num1; }
            //int lngval = longstr.Length, shortval = shortstr.Length;
            //int carry = 0, val=0, indx1 = 0, indx2 = 0;
            //indx1 = lngval; indx2 = shortval;
            //string rsltStr = "";
            //while (longstr != null && shortstr != null)
            //{
            //    int c1, c2;
            //    c1 = Convert.ToInt32(longstr[]);
            //    c2 = Convert.ToInt32(shortstr.Substring(0, shortval-1));
            //    int x1 = lngval >= 0 ? c1 : 0;
            //    int x2 = shortval >= 0 ? c2 : 0;
            //    int sum = x1 + x2 + carry;
            //    carry = 0;
            //    carry = sum % 2;
            //    val = sum / 2;
            //    rsltStr = rsltStr + val.ToString();
            //}
            //return rsltStr;
        }
    }
}
