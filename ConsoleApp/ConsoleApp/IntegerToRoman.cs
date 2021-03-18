using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// Need to work on this. 
    /// Should need to follow RomantoInteger.
    /// </summary>
    class IntegerToRoman
    {
        void integerToRoman(string s)
        {
            Dictionary<char, int> dict3 = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
        
        
            var res = 0;
            var pre = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                var cur = dict3[s[i]];
                res += pre > cur ? -cur : cur;
                pre = cur;
            }

         //   return res;
        }
    
    }//
    }//
//}//
