using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-words-in-a-string-iii/
    /// I have submitted the faster one on leet code submission....
    /// </summary>
    class ReverseWords
    {
        string sb1="";
        List<string> strList = new List<string>();
        public string reverseWords(string s)
        {
            s = "Let's take LeetCode contest"; 
            char[] stringChar = s.ToCharArray();
            byte[] ascIIchar = Encoding.ASCII.GetBytes(stringChar);
            

            int totalLength = stringChar.Length;
            int n = 0; 
            int i = 0;
            char temp;
            string str;

                for (i = 0; i <= totalLength-1; i++)
                {
                    if (ascIIchar[i] == 32 || i==totalLength-1)
                    {
                        if (i == totalLength - 1)
                        {
                            strList.Add(stringChar[i].ToString());
                        }
                        reverseTheWord(strList, ascIIchar[i]);
                        strList.Clear();
                        //break;
                    }
                    else
                    {
                        strList.Add(stringChar[i].ToString());
                    }
            }
            Console.Write(sb1);
            
            return sb1;
        }
        void reverseTheWord(List<string> objstr, Byte objascII)
        {
            
            for (int i = objstr.Count-1; i >=0; i--)
            {
                sb1 += objstr[i].ToString();
            }
            if (objascII == 32)
            {
                sb1 += " ";
            }
            else 
            {
            //do nothing....
            }
        }
    }
}
