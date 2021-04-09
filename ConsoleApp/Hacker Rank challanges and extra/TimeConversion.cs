using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Given a time in 12 hour AM/PM format, conver it to military (24-hour) time...
    /// https://www.hackerrank.com/challenges/time-conversion/problem
    /// Following two lines for Program.cs file to call this functionality....
    /// TimeConversion objTimeConversion = new TimeConversion();
    /// objTimeConversion.timeConversion("");
    /// </summary>
    class TimeConversion
    {
        public void timeConversion(string s)
        {
            string str = s;
            str = "12:45:54PM"; // this will be comment when run program which can give input through function.
            char[] strArry = str.ToArray();
            string militaryHour="";
            string strDefultMilitaryHour = "12:00:00";
            char[] charDefultMilitaryHour = strDefultMilitaryHour.ToArray();
            int firstIntdfltvalue = int.Parse(charDefultMilitaryHour[0].ToString());
            int secondIntdfltvalue = int.Parse(charDefultMilitaryHour[1].ToString());

            if ('1' == strArry[0] && '2' == strArry[1] && "A" == strArry[8].ToString().ToUpper() && "M" == strArry[9].ToString().ToUpper())
            {
                militaryHour = "00";
                for (int i = 2; i < strArry.Length - 2; i++)
                {
                    militaryHour += strArry[i].ToString();
                }
            }
            else if ('1' == strArry[0] && '2' == strArry[1] && "P" == strArry[8].ToString().ToUpper() && "M" == strArry[9].ToString().ToUpper())
            {
                militaryHour = "12";
                for (int i = 2; i < strArry.Length - 2; i++)
                {
                    militaryHour += strArry[i].ToString();
                }
            }
            else if ("P" == strArry[8].ToString().ToUpper() && "M" == strArry[9].ToString().ToUpper())
            {
                strDefultMilitaryHour = str;
                firstIntdfltvalue += int.Parse(strArry[0].ToString());
                secondIntdfltvalue += int.Parse(strArry[1].ToString());

                // Char temp = char.Parse(firstIntdfltvalue.ToString());
                charDefultMilitaryHour[0] = char.Parse(firstIntdfltvalue.ToString());
                charDefultMilitaryHour[1] = char.Parse(secondIntdfltvalue.ToString());

                // militaryHour = charDefultMilitaryHour.ToString();
                for (int i = 0; i < 2; i++)
                {
                    militaryHour += charDefultMilitaryHour[i].ToString();
                }
                for (int i = 2; i < strArry.Length-2; i++)
                {
                    militaryHour += strArry[i].ToString();
                }
            }
            else if ("A" == strArry[8].ToString().ToUpper() && "M" == strArry[9].ToString().ToUpper())
            {
                for (int i = 0; i < str.Length - 2; i++)
                { 
                militaryHour += strArry[i].ToString();
                }
            
            }


                Console.WriteLine(militaryHour);
            Console.ReadLine();

        }
    }
}
