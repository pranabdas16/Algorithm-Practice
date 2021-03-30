using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Simple_problem
{
    /// <summary>
    /// Program file have followning code to call this class..
    /// SimpleArraySum objs = new SimpleArraySum(); 
    /// objs.simpleArraySum();
    /// </summary>

    class SimpleArraySum
    {
        ///
        /// Simple Array sum ......
        /// 
        public void simpleArraySum()
        {
            int[] inputIntArray = { 2, 4, 7, 10 };
            int sum=0; 
            for (int i = 0; i < inputIntArray.Length; i++)
            {
                sum += inputIntArray[i];
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }

    }
}
