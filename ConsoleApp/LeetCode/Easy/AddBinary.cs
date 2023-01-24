using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/add-binary/description/
    /// </summary>
    public class AddBinary
    {
        public string addBinary(string a, string b)
        {
            int n = a.Length, m = b.Length;
            if (n < m) return addBinary(b, a);
            int L = Math.Max(n, m);

            StringBuilder sb = new StringBuilder();
            int carry = 0, j = m - 1;
            for (int i = L - 1; i > -1; --i)
            {
                if (a[i] == '1') ++carry;
                if (j > -1 && b[j--] == '1') ++carry;

                if (carry % 2 == 1) sb.Append('1');
                else sb.Append('0');

                carry /= 2;
            }
            var rsltStr = "val";
            if (carry == 1) sb.Append('1');
            {
                string str = sb.ToString();
                rsltStr = new string(str.ToCharArray().Reverse().ToArray());
            }
            Console.WriteLine($"Sum of binary: {rsltStr}");
            return rsltStr;
        }
    }
}
