using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Hacker Rank Question 
    /// https://www.hackerrank.com/challenges/30-review-loop/problem?h_r%5B%5D=next-challenge&h_r%5B%5D=next-challenge&h_v%5B%5D=zen&h_v%5B%5D=zen&isFullScreen=true
    /// </summary>
    class SpaceStringSwitchCase
    {
        public void SpaceString()
        {
            List<string> str = new List<string>();
            List<string> strAnthr = new List<string>();
            int n, count = 0;
            //  Console.WriteLine("Enter number of string:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //  Console.WriteLine("Enter string:");
                str.Add(Console.ReadLine().ToString());
            }
            //string objStr = str[i].ToString();
            string targetStr, objStr;
            for (int i = 0; i < n; i++)
            {
                string str1 = "", str2 = ""; int j, l = 0;
                objStr = str[i].ToString();
                for (int k = 0; k < objStr.Length; k++)
                {
                    if (k % 2 == 0)
                    {
                        str1 = str1 + objStr[k].ToString();
                        //j++;
                    }
                    else
                    {
                        str2 = str2 + objStr[k].ToString();
                        //l++;
                    }
                }
                targetStr = str1 + str2;
                strAnthr.Add(targetStr);
            }

            for (int i = 0; i < n; i++)
            {
                objStr = strAnthr[i].ToString();
                for (int k = 0; k < objStr.Length; k++)
                {
                    int IsEvenOdd = objStr.Length % 2;
                    switch (IsEvenOdd)
                    {
                        case 0:
                            if (k < objStr.Length / 2)
                            {
                                Console.Write(objStr[k].ToString());
                            }
                            else
                            {
                                if (count == 0)
                                    Console.Write(" ");

                                Console.Write(objStr[k].ToString());

                                count++;
                            }
                            break;
                        case 1:
                            if (k <= objStr.Length / 2)
                            {
                                Console.Write(objStr[k].ToString());
                            }
                            else
                            {
                                if (count == 0)
                                    Console.Write(" ");

                                Console.Write(objStr[k].ToString());

                                count++;
                            }
                            break;
                    }
                    //if (k < objStr.Length / 2)
                    //{
                    //    Console.Write(objStr[k].ToString());
                    //}
                    //else
                    //{
                    //    if (count == 0)
                    //        Console.Write(" ");

                    //    Console.Write(objStr[k].ToString());

                    //    count++;
                    //}
                }
                Console.WriteLine();
                count = 0;
            }
        }
    }
}
