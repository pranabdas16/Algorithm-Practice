using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
   public class PowerXN
    {
        public double powerXN(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            double ans = 1;
            for (long i = 0; i < N; i++)
                ans = ans * x;
            return ans;
            double val = x, result = 0;
            if (n > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    result = val * x;
                    val = result;
                }
                return result;
            }
            else if (n == 1)
            {
                return x;
            }
            else if (n == 0)
            {
                return 1;
            }
            else if (n == -1)
            {
                return 1 / x;
            }
            else if (n < 0)
            {
                n = -1 * n;
                for (int i = 1; i < n; i++)
                {
                    result = val * x;
                    val = result;
                }
                return 1 / result;
            }
            else
            {
                return 0;
            }
        }
    }
}
