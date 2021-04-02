using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// BirthdayCakeCandles....
    /// </summary>
    ///BirthdayCakeCandles objBirCake = new BirthdayCakeCandles();
    ///objBirCake.birthdayCakeCandles();
    ///This one is not optimize so creating another
    class BirthdayCakeCandles
    {
        List<int> candles = new List<int>();


        public void birthdayCakeCandles()
        {
            candles.Add(3);
            candles.Add(2);
            candles.Add(1); 
            candles.Add(3);
            candles.Add(4);
            int index, counter = 0, max = 0;

            for (int i = 0; i < candles.Count - 1; i++)
            {
                for (int j = i+1; j < candles.Count; j++)
                {
                    if (candles[i] > candles[j])
                    {
                        if (max < candles[i])
                        {
                            max = candles[i];
                            index = i;
                        }

                    }
                    if (candles[j] > candles[i])
                    {
                        if (max < candles[j])
                        {
                            max = candles[j];
                            index = j;
                        }

                    }
                }
            }
            for (int j = 0; j < candles.Count; j++)
            {
                if (candles[j] == max)
                {
                    counter++;
                }
            }

            Console.WriteLine("Number of talest candles: " + counter);
            Console.WriteLine("length of talest candles: " + max);
            Console.ReadLine();



        }


    }
}
