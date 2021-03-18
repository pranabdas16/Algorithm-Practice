using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class commonPrefix
    {
        ///Find longest common Prefix using character by charcter matching....
        public string CommonPrefix(string[] arr, int n)
        {
            int minlen = FindMinLength(arr, n);

            string result = "";
            char current;

            for (int i = 0; i < minlen; i++)
            {

                current = arr[0][i];

                for (int j = 1; j < n; j++)
                {
                    if (arr[j][i] != current)
                    {
                        return result;
                    }
                }
                result += (current);
            }

            return result;

        }

        int FindMinLength(string[] arr, int n)
        {
            int min = arr[0].Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i].Length < min)
                {
                    min = arr[i].Length;
                }
            }
            return (min);
        }
    }
}

