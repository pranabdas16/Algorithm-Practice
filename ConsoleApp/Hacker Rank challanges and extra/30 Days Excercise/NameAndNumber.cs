using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra._30_Days_Excercise
{
    /// <summary>
    /// Name=PhoneNumber
    /// https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem?h_r%5B%5D=next-challenge&h_r%5B%5D=next-challenge&h_v%5B%5D=zen&h_v%5B%5D=zen&isFullScreen=true&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
    /// 
    /// </summary>
    public class NameAndNumber
    {
        public void nameAndNumber()
        {
            Dictionary<string, int> nameNumber = new Dictionary<string, int>();
            List<string> searchStr = new List<string>();
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            string key, value;
            for (int i = 0; i < n; i++)
            {
                string phrase = Console.ReadLine().ToString();
                string[] word = phrase.Split(' ');
                nameNumber.Add(word[0], Convert.ToInt32(word[1]));
            }
            //for (int i = 0; i < n; i++)
            //{
            //    searchStr.Add(Console.ReadLine().ToString());
            //}
            //for (int i = 0; i < n; i++)
            string searchstr;
            while ((searchstr = Console.ReadLine()) != null)
            {
                if (nameNumber.ContainsKey(searchstr.ToString()))
                {
                    Console.WriteLine($"{searchstr.ToString()}={nameNumber[searchstr.ToString()]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                //{
                //if (nameNumber.Keys.Contains(searchStr[i]))
                //{
                //    Console.WriteLine($"{nameNumber.ElementAt(i).Key}={nameNumber.ElementAt(i).Value}");
                //}
                //else
                //{
                //    Console.WriteLine("Not found");
                //}
            }
        }
    }
}
