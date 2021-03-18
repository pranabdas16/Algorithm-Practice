using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class RomanToInteger
    {
        public void romanToInteger()
        {
            Console.WriteLine("Enter the Roman value:");
            String str = Console.ReadLine();
            String s = str.ToUpper();

            Dictionary<string, int> dict2 = new Dictionary<string, int>()
    {
      { "M", 1000},
      { "CM", 900},
      { "D" , 500},
      { "CD", 400},
      { "C" , 100},
      { "XC" , 90},
      { "L" , 50},
      { "XL", 40},
      { "X", 10},
      { "IX", 9 },
      { "V", 5 },
      { "IV", 4 },
      { "I", 1},
    };
            var res = 0;

            while (!string.IsNullOrEmpty(s))
            {
                foreach (var ch in dict2.Keys)
                {
                    if (s.StartsWith(ch))
                    {
                        res += dict2[ch];
                        s = s.Substring(ch.Length);
                        break;
                    }
                }
            }

            Console.WriteLine(res);
            Console.ReadLine();
            //  return res;
        }
        public void text()
        {
        }
    }
}
