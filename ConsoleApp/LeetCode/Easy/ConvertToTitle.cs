using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LeetCode.Easy
{
    /// <summary>
    /// Excel sheet column title
    /// https://leetcode.com/problems/excel-sheet-column-title/description/
    /// </summary>
    public class ConvertToTitle
    {
        public string convertToTitle(int columnNumber)
        {
            var result = string.Empty;
            while (columnNumber > 0)
            {
                columnNumber--;
                result = Convert.ToChar((columnNumber % 26) + 'A') + result;
                columnNumber /= 26;
            }
            Console.WriteLine($"Here is the reult:{result}");
            return result;
        }
    }
}
