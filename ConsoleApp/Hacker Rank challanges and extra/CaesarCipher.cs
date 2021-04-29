using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class CaesarCipher
    {
        /// <summary>
        /// Caesar Cipher
        /// https://www.hackerrank.com/challenges/caesar-cipher-1/problem
        /// 
        /// </summary>
        public void caesarCipher()
        {
            char[] OrgAlphabet = { 'a', 'b', 'c', 'd','e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n','o','p', 'q','r','s','t','u','v','w','x','y','z' };///, 'e', 'f', 'g'};
            char[] rotAlphabet = new char[OrgAlphabet.Length];
            string strAlp = new string(OrgAlphabet);
            string strInput = "www.abc.xy";
            char[] charOutput = new char[strInput.Length];
            string strOut="";
            
                     
            int k = 87;
            int j = 0;
            for (int i = 0; i < OrgAlphabet.Length; i++)
            {

                if (i + k == OrgAlphabet.Length)
                {
                    rotAlphabet[i] = OrgAlphabet[j];
                }
                else if (i + k > OrgAlphabet.Length)
                {
                    j++;
                    rotAlphabet[i] = OrgAlphabet[j];
                }
                else
                {
                    rotAlphabet[i] = OrgAlphabet[i + k]; 
                }
            }

            //for (int x = 0; x < OrgAlphabet.Length; x++)
            //{
            //    Console.WriteLine(rotAlphabet[x]);
            //}
            int n = 0;

            //Console.WriteLine(strAlp);
            
            for (int i = 0; i < strInput.Length; i++)
            {
                string c = strInput[i].ToString().ToLower();
                if (strAlp.Contains(c))
                {
                    char[] ccheck = strInput[i].ToString().ToArray();
                    bool b = char.IsUpper(ccheck[0]);
                    
                        n = strAlp.IndexOf(c);
                    if(b)
                    charOutput[i] = char.ToUpper( rotAlphabet[n]);
                    else
                    charOutput[i] = rotAlphabet[n];
                   //strOut[i] += rotAlphabet[n];
                }
                else
                {
                    charOutput[i] = strInput[i];
                }
            }
            strOut = new string(charOutput);
            Console.WriteLine(strOut);
            Console.ReadLine();

        }
    }
}
