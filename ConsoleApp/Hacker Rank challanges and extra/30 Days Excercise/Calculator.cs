using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra._30_Days_Excercise
{
   public class Calculator
    {
        string ex = string.Empty;
        public int Power(int n, int p)
        {
            try
            {
                if (n > 0 && p > 0)
                {
                    // Console.WriteLine("n and p should be non-negative");
                    // throw new ApplicationException("n and p should be non-negative");
                   return Convert.ToInt32(Math.Pow(n, p));

                }
                else if(n < 0 ||  p < 0)
                {
                    throw new ApplicationException("n and p should be non-negative");
                }
                return -1;
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("n and p should be non-negative");
            }
            finally
            { 
                //do nothing
            }
            return -1;
        }
    }
}
