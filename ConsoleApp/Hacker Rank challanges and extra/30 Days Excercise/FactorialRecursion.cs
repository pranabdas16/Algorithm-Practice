using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra._30_Days_Excercise
{
   public class FactorialRecursion
    {
        FactorialRecursion objRec;

        public int factVal(int element)
        {
            if (element == 0)
            {
                return 1;
            }
            return element * factVal(element - 1);   
        }
    }
}
