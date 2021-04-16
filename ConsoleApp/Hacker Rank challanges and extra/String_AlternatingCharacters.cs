using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class AlternatingCharacters
    {
        /// <summary>
        /// Alernating Characters....
        /// https://www.hackerrank.com/challenges/alternating-characters/problem
        /// Following two line of code to call following function using Program.cs
        /// AlternatingCharacters objAC = new AlternatingCharacters();
        /// objAC.alternatingCharacters();
        /// </summary>
        public void alternatingCharacters()
        {
            string strInput = "BABABA";
            List<char> listStrInput = new List<char>(0);
            listStrInput = strInput.ToCharArray().ToList();
            int n = listStrInput.Count;
            int Counter = 0; 
            for (int i = 0; i < n; i++)
            {
                if(i+1 < listStrInput.Count)
                if (listStrInput[i] == listStrInput[i + 1])
                {
                    listStrInput.RemoveAt(i + 1);
                        Counter++;
                        i--;
                }
            }
            Console.WriteLine(Counter);
            Console.ReadLine();
        }

    }
}
