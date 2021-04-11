using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Super Redeuded String....
    /// https://www.hackerrank.com/challenges/reduced-string/problem
    /// SuperReducedString objSRS = new SuperReducedString();
    /// objSRS.superReducedString("aabbac");
    /// </summary>
    class SuperReducedString
    {

        public void superReducedString(string s)
        {
            s = "ppffccmmssnnhhbbmmggxxaaooeeqqeennffzzaaeeyyaaggggeessvvssggbbccnnrrjjxxuuzzbbjjrruuaaccaaoommkkkkxx";
            List<char> objChar = new List<char>(s);
            string returnStr ="";
            for(int i = 1; i < objChar.Count; i++)
            {
                if (objChar[i] == objChar[i - 1])
                {
                    objChar.RemoveAt(i-1);
                    objChar.RemoveAt(i-1);
                     i=0   ;
                }
            }
            if (objChar.Count == 0)
            {
                returnStr = "Empty String";
            }
            foreach (char c in objChar)
            {
                returnStr += c;
            } 

            Console.WriteLine(returnStr);
            Console.ReadLine();
        }
    }
}
