using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    class BillDivision
    {
        /// <summary>
        /// Bill Division
        /// https://www.hackerrank.com/challenges/bon-appetit/problem
        /// BillDivision objBillDivision = new BillDivision();
        /// objBillDivision.billDivision(); 
        /// </summary>


        public void billDivision()
        {
            List<int> totalpriceList = new List<int>();
            //List<int> AnnaDeclinesList = new List<int>();
            int k =6, b = 288;
            int totalcost = 0, totalcostAnnRemov =0, totalActual=0, gross=0 ;
            totalpriceList.Add(72);
            totalpriceList.Add(53);
            totalpriceList.Add(60);
            totalpriceList.Add(66);
            totalpriceList.Add(90);
            totalpriceList.Add(62);
            totalpriceList.Add(12);
            totalpriceList.Add(31);
            totalpriceList.Add(36);
            totalpriceList.Add(94);

            foreach (int c in totalpriceList)
            {
                totalcost += c;
            }

            totalpriceList.RemoveAt(k);

            foreach (int c in totalpriceList)
            {
                totalcostAnnRemov += c;
            }

            totalActual =  totalcostAnnRemov/2;

            if (totalActual > b)
            {
                gross = totalActual - b;

                Console.WriteLine(gross);
            }
            else if (totalActual == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else if (b > totalActual)
            {
                gross = b -totalActual;

                Console.WriteLine(gross);
            }
          
            //Console.WriteLine(totalActual);
            Console.ReadLine();
        }
    }
}
