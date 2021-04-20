using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Camel Case...
    /// https://www.hackerrank.com/challenges/camelcase/problem?h_r=next-challenge&h_v=zen
    ///  CamelCase objCC = new CamelCase();
    ///  objCC.camelCase("OneTwoThree");
    /// </summary>
    class CamelCase
    {
        public void camelCase(string s)
        {
            s = "oneTwoThree";
            char[] objcharArray = s.ToArray();
            int count = 1;
            if (objcharArray.Length > 1)
            {
                foreach (char c in objcharArray)
                {
                    if (c == char.ToUpper(c))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
