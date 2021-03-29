using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class LongestUniqueSubsttr
    {
        
        public void longestUniqueSubsttr()
        {
            string inputStr = "abcdefadvc";
            char[] inputStrArray = inputStr.ToArray();
            //int inputStrArrayLength = inputStr.Length;
            //string[] 1stStr = new string[inputStrArray.Length];
            //, 2ndStr;
            string str1, str2, finalstr;
            str1 = str2 = finalstr = "";

            for (int i = 0; i < inputStr.Length; i++)
            {
                str1 = "";
                for (int j = i + 1; j < inputStr.Length; j++)
                {
                   
                    if (inputStrArray[i] == inputStrArray[j])
                    {
                        break;
                    }
                    else
                    {
                        str1 += inputStrArray[j-1];
                    }
                }

                if (str2.Length < str1.Length)
                {
                    str2 = str1;
                }
                
            }
            Console.Write(str2);
            Console.ReadLine();

        }
    }
}
