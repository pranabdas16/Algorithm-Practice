using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class validParenthesis
    {
        /// <summary>
        /// Valid Parenthesis
        /// Given a string containing just the charcters (, ), {, }, [ and ] detemine if the input sting is valid.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool isValidReview()
        {
            
            Console.WriteLine("Enter the string of parenthesis");
            string str = Console.ReadLine().ToString();
            //string[] strArr = str.Split(new string[] { "\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            char[] chrArr = str.ToArray();

            Stack<char> endings = new Stack<char>();

            foreach (var c in chrArr)
            {
                Console.WriteLine(c);            
            }
            Console.ReadLine();
            return false;
        }
    }
}
