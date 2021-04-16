using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// MarsExploration
    /// https://www.hackerrank.com/challenges/mars-exploration/problem
    /// To call this funtion we need to write following code in Program.cs
    /// MarsExplorationSOS objMESOS = new MarsExplorationSOS();
    /// objMESOS.marsExplorationSOS();
    /// </summary>
    class MarsExplorationSOS
    {
        public void marsExplorationSOS()
        {
            string recievedSignal = "SOSSPSSQSSOR";
            string expectedSignal = "";
            char[] objSos = { 'S', 'O', 'S' };
            int rcvdSignalLength = recievedSignal.Length;
            int n = 0, i = 0, counter =0 ;
            while (n < rcvdSignalLength)
            {
                expectedSignal += objSos[i];
                i++;
                if (i > 2)
                    i = 0;
                n++;
            }
            for (int j = 0; j < rcvdSignalLength; j++)
            {
                if (recievedSignal[j] != expectedSignal[j])
                {
                    counter++;
                }
            }
            //return counter;
            Console.WriteLine(expectedSignal);
            Console.WriteLine(rcvdSignalLength);
            Console.WriteLine("Difference of output is: "+ counter);
            Console.ReadLine();
        }
    }
}
