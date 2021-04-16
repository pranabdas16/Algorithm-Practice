using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Pargrams....
    /// https://www.hackerrank.com/challenges/pangrams/problem
    /// Pangrams objPGRM = new Pangrams();
    /// objPGRM.pangrams();
    /// </summary>
    class Pangrams
    {
        public void pangrams()
        {
            string englishAplphabet = "abcdefghijklmnopqrstuvwxyz";
            string givenstring = "We promptly judged antique ivory buckles for the prize";
            givenstring = givenstring.ToLower();
            int j =0;
            bool isPagrams = false;
            int counter = 0; 
            string is_Pagrams = "";
            for (int i = 0; i < englishAplphabet.Length; i++)
            {
                while (j < givenstring.Length)
                {
                    if (englishAplphabet[i] == givenstring[j])
                    {
                        counter++;
                        if (counter == 26)
                        {
                            isPagrams = true;
                            break;
                        }
                        break;
                    }
                    j++;
                }
                j = 0;
                if (counter == 26)
                {
                    isPagrams = true;
                    break;
                }

            }
            if (isPagrams == true)
                is_Pagrams = "pangram";
            else
                is_Pagrams = "not pangram";

            //return is_Pagrams;

            Console.WriteLine(is_Pagrams);
            Console.WriteLine(counter);
            Console.ReadLine();


        }
    }
}
