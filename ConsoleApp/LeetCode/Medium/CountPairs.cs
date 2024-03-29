﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Medium
{
    class CountPairs
    {
        /// <summary>
        /// https://leetcode.com/problems/count-good-meals/
        /// </summary>
        /// <returns></returns>
        public int countPairs()//int[] deliciousness)
        {
            int result = 0;
            //int[] givenArray = { 1, 1, 1, 3, 3, 3, 7 };//deliciousness; //
            int[] givenArray = { 1, 0, 86, 42, 5815, 2377, 26, 8166, 101, 155, 4, 4, 10278, 22490, 86, 42, 302, 1746, 279, 1769, 1675, 373, 2, 0, 0, 8, 2304, 1792, 1, 1, 40, 24, 8490, 24278, 11, 21, 332, 180, 1947, 14437, 8, 8, 74, 4022, 1245, 803, 97, 31, 255, 257, 33, 479, 362, 150, 109, 147, 42, 470, 8, 8, 34, 94, 0, 16, 999, 25, 94, 34, 839, 185, 26, 6, 12, 4, 1, 0, 1, 1, 8751, 24017, 100, 28, 267, 1781, 2, 6, 7, 57, 884, 1164, 4, 0, 92, 36, 210, 46, 357, 7835, 51, 77, 227, 7965, 7941, 8443, 2966, 29802, 596, 428, 0, 16, 29059, 3709, 7040, 1152, 3408, 29360, 8, 8, 1180, 868, 4106, 12278, 0, 1, 1, 15, 12, 4, 8, 120, 1546, 502, 1, 0, 984, 3112, 12, 4, 0, 8, 219, 37, 49, 975, 1, 1, 6395, 1797, 1281, 767, 4005, 12379, 52, 460, 2658, 1438, 4, 0, 5, 3, 6, 58, 11, 5, 24327, 8441, 4, 0, 5046, 27722, 0, 1, 83, 429, 15546, 838, 312, 200, 33, 95, 486, 26, 99, 3997, 7557, 635, 131, 381, 1144, 904, 3776, 320, 40, 472, 22, 42, 1, 1, 5, 3, 858, 1190, 1928, 2168, 8, 0, 669, 355, 1034, 15350, 104, 152, 91, 165, 755, 32013, 24, 40, 619, 1429, 22368, 10400, 25146, 7622, 474, 550, 522, 1526, 22, 10, 6, 1018, 6, 10, 1, 1, 241, 1807, 0, 2, 2218, 30550, 553, 471, 1, 7, 23, 105, 1401, 647, 180, 76, 1041, 3055, 95, 33, 14, 242, 187, 69, 0, 4, 1, 3, 526, 1522, 504, 8, 1417, 2679, 112, 16, 1956, 92, 331, 181, 46, 82, 914, 110, 1263, 785, 5, 3, 12126, 20642, 208, 7984, 20603, 12165, 15378, 1006, 3924, 4268, 2756, 1340, 1, 1, 11588, 4796, 1, 0, 941, 83, 3411, 29357, 28, 100, 1011, 13, 0, 2, 1, 15, 1887, 14497, 46, 82, 17, 15, 3188, 5004, 2250, 1846, 7334, 858, 1744, 2352, 47, 17, 7009, 1183, 85, 427, 0, 2, 31, 33, 6495, 1697, 115, 13, 9, 7, 329, 183, 772, 252, 3478, 618, 110, 1938, 15, 49, 1007, 17, 14869, 17899, 0, 8, 1, 7, 31, 33, 6, 2, 1, 0, 11599, 21169, 3, 5, 7, 1, 10777, 5607, 3, 13, 1, 0, 7129, 25639, 2, 0, 517, 1531, 2743, 13641, 28251, 4517, 130, 126, 2, 6, 25436, 7332, 1, 0, 1, 3, 1472, 6720, 975, 49, 108, 20, 115, 141, 679, 1369, 2549, 1547, 305, 207, 2, 6, 5, 11, 15, 17, 0, 1, 11, 21, 2833, 5359, 988, 3108, 0, 1, 659, 1389, 5797, 10587, 797, 227, 245, 11, 13, 499, 35, 221, 928, 3168, 567, 457, 56, 968, 115, 141, 225, 287, 370, 142, 9655, 6729, 0, 4, 56, 968, 33, 31, 3801, 295, 22605, 10163, 54, 458, 201, 823, 13006, 3378, 28, 4, 1, 0, 1231, 6961, 159, 97, 43, 21, 0, 2, 8, 0, 2674, 30094, 1, 0, 527, 497, 4095, 28673, 22, 10, 20627, 12141, 294, 218, 5085, 3107, 1, 1, 5541, 27227, 4489, 3703 };
            int n = 0;
            int log = 1;
            //Dictionary<string, string> objTargetval = new Dictionary<string, string>();
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            while (n < givenArray.Length)
            { 
                for(int i = n+1; i < givenArray.Length; i++)
                {
                    while( log < 60 && (givenArray[n] + givenArray[i]) >= Math.Pow(2, log))
                    {
                        if ((givenArray[n] + givenArray[i]) == Math.Pow(2, log))
                        {
                            a.Add(givenArray[n]);
                            b.Add(givenArray[i]);
                        }
                        else if((givenArray[n] + givenArray[i]) < Math.Pow(2, log))
                        {
                           // break;
                        }
                        else
                        { 
                        //do nothing;
                        }
                            log++;
                    }
                    log = 0;
                }
                n++;
            }
            result = a.Count;
            Console.WriteLine("Total count is : {0}", result);
            return result; 
        
        }
    }
}
