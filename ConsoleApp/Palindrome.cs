using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public class Palindrome
    {
        public void palindrome()
        {
            Console.WriteLine("Enter the inter value to check palindrom:");
            int x = int.Parse(Console.ReadLine());
            int actualNum = x;
            int reversePlndrm = 0;
            while (x > 0)
            {
                reversePlndrm = reversePlndrm * 10 + x % 10;
                x = x / 10;

            }

            if (actualNum == reversePlndrm)
            {
                Console.WriteLine("Provided number is Palindrom");
            }
            else
            {
                Console.WriteLine("Not a palindrom");
            }

            Console.ReadLine();

        }
    }
}
