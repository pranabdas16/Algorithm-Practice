using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    class CountGoodNumbers
    {
        /// <summary>
        /// https://leetcode.com/problems/count-good-numbers/
        /// </summary>
        /// <param name="n"></param>

        public void countGoodNumbers(long n)
        {
            int[] givenArray = new int[n];
            Dictionary<int, long> objListVal = new Dictionary<int, long>();
            long minLmt, maxLmt;
            string strMinLmt = "1"; string strMaxLmt ="9";
            minLmt = 0;
            maxLmt = 9;
            if (n > 1)
            {
                int i = 1;
                while (i < n)
                {
                    strMinLmt = strMinLmt + "0";
                    strMaxLmt = strMaxLmt + "9";
                    i++;
                }
                minLmt = int.Parse(strMinLmt);
                maxLmt = int.Parse(strMaxLmt);
            }
            //int givenNum = 11;
            if (n == 1)
            {
                int j = 0;
                for (int i = 0; i < 10; i = i + 2)
                {
                    objListVal.Add(j, i);
                    j++;
                }
            }
            else
            {
                int j = 0;
                while(minLmt < maxLmt)
                {
                    bool evenOdd, flag; evenOdd = true; flag = true;
                    long[] str = new long[minLmt.ToString().Length];
                    long local = minLmt, temp;
                    string str1 = minLmt.ToString();
                    for (int i = 0; i < minLmt.ToString().Length; i++)
                    {
                        str[i] = long.Parse(str1[i].ToString());
                       
                    }

                    for (int i = 0; i < maxLmt.ToString().Length; i++)
                    {
                        switch (evenOdd)  // to make the logic on 1st case always even check and 2n case prime check and so on....
                        {
                            case true:
                                if (IsEven(str[i]))
                                    flag = true;
                                else
                                    flag = false;
                                break;
                            case false:
                                if (IsPrimeNumber(str[i]))
                                    flag = true;
                                else
                                    flag = false;
                                break;
                        }
                        if (flag == false) //make the flag false not to make not to add on the dictionary...
                        {
                            break;
                        }
                        if (evenOdd)        // This is for forloop to have first even second odd and so on...
                            evenOdd = false;
                        else
                            evenOdd = true;
                    }
                    if (flag)  // if flag is true than will add in the dictionary......
                    {
                        objListVal.Add(j, minLmt);
                        j++;
                    }

                        minLmt++;
                }
            }
            Console.WriteLine(string.Join("Good numbers are : {0}", objListVal.Count));
            }


        public bool IsEven(long givenNum)
        {
            if ((givenNum % 2) == 0)
            {
                return true;
            }
            else
            return false;
        }
        public bool IsPrimeNumber(long givenNum)
        {
            if (givenNum == 2 || givenNum == 3 || givenNum == 5 || givenNum == 7)
                return true;
            else
            return false;
            /*
            int flag = 0;

            for (int i = 2; i < givenNum / 2; i++)
            {
                if ((givenNum % i) == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Given number is Prime: {0}", givenNum);
                return true;
            }
            else
            {
                Console.WriteLine("Given number is Not Prime: {0}", givenNum);
                return false;
            }
            */
        }
    }
}
