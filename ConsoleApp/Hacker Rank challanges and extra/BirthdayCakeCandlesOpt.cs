using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class BirthdayCakeCandlesOpt
    {
        /// <summary>
        /// BirthdayCakeCandlesOpt optimized....
        /// </summary>
        /// BirthdayCakeCandlesOpt objBirCake = new BirthdayCakeCandlesOpt();
        /// objBirCake.birthdayCakeCandlesOpt();
        /// This one is not optimize so creating another

        List<int> candles = new List<int>();
        public void birthdayCakeCandlesOpt()
        {
            candles.Add(3);
            candles.Add(2);
            candles.Add(1);
            candles.Add(3);
            candles.Add(4);

            int count = 0, maxheight = 0;
            foreach (int candle in candles)
            {
                if (candle > maxheight)
                {
                    maxheight = candle;
                    count = 0;
                    count++;
                }
                else if (candle == maxheight)
                {
                    count++;
                }
            }
            Console.WriteLine("Number max height candle" + count);
            Console.ReadLine();
        }
    }
}
