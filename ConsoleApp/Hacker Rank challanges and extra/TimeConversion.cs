using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Given a time in 12 hour AM/PM format, conver it to military (24-hour) time.
    /// </summary>
    class TimeConversion
    {
        public void timeConversion(string str)
        {
            str = "10:00:00PM";
            char[] strArry = str.ToArray();
            string militaryHour="";
            string strDefultMilitaryHour = "12:00:00";
            char[] charDefultMilitaryHour = strDefultMilitaryHour.ToArray(); 


            if ('1' == strArry[0] && '2' == strArry[1] && "A" == strArry[8].ToString().ToUpper() && "M" == strArry[9].ToString().ToUpper())
            { 
                militaryHour = "00:00:00";
            }
            if ("P" == strArry[8].ToString().ToUpper() && "M" == strArry[9].ToString().ToUpper())
            {
                charDefultMilitaryHour[0] += strArry[0];
                charDefultMilitaryHour[1] += strArry[1];

                militaryHour = charDefultMilitaryHour.ToString();
            }


            Console.WriteLine(militaryHour);
            Console.ReadLine();

        }
    }
}
