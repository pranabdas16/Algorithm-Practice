using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Simple_problem
{
    class AVeryBigSum
    {
        public void aVeryBigSum()
        {
            int n =0; 
            Console.WriteLine("Enter the how many number need to enter: ");
            n = Convert.ToInt32(Console.ReadLine());

            long[] bigArray = new long[n];

            long sumValue=0;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the long value: ");
                bigArray[i] = Convert.ToInt64(Console.ReadLine());
            }

            //Console.WriteLine("Following are entered:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(bigArray[i]);
            //}

            for (int i = 0; i < n; i++)
            {
                sumValue += bigArray[i];
            }


            Console.WriteLine(sumValue);

            Console.ReadLine();
        }

    }
}
