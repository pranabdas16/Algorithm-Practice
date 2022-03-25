using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DS
{
    class DesignerPdfViewer
    {
        public static int designerPdfViewer()// List<int> h, string word)
        {
            Dictionary<int, char> objAlpbhabet = new Dictionary<int, char>()
            {
               { 0 , 'a' }, { 1 , 'b' }, { 2 , 'c' }, { 3 , 'd' }, { 4 , 'e' }, { 5 , 'f' }, { 6 , 'g' },
               { 7 , 'h' }, { 8 , 'i' }, { 9 , 'j' }, { 10, 'k' }, { 11, 'L' }, { 12, 'M' }, { 13, 'N' },
               { 14, 'o' }, { 15, 'p' }, { 16, 'q' }, { 17, 'r' }, { 18, 's' }, { 19, 't' }, { 20, 'u' },
               { 21, 'v' }, { 22, 'w' }, { 23, 'x' }, { 24, 'y' }, { 25, 'z' }
            };
            List<char> listAlphabet = new List<char>()
            { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p','q','r',
               's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            List<int> h1 = new List<int> { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 1, 1, 5, 5, 1, 5, 2, 5, 5, 5, 5, 5, 5 };
            string word1 = "dac";
            List<int> listwordIndex = new List<int>();
            int k = 0, maxVal = 0, x = 0; Dictionary<int, char> result = new Dictionary<int, char>();
            List<int> resultList = new List<int>();
            for (int i = 0; i < word1.Length; i++)
            {
               // listwordIndex.Add(objAlpbhabet.FirstOrDefault(x => x.Value == word1[i]).Key);
            }

            while (x < listwordIndex.Count)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (listwordIndex[k] == j)
                    {
                        resultList.Add(h1[j]);
                        k++;
                        break;
                    }
                }
                x++;
            }
            for (int l = 0; l < resultList.Count; l++)
            {

                if (resultList[0] < resultList[l])
                {
                    resultList[0] = resultList[l];
                }
                maxVal = resultList[0];
            }

            return maxVal * word1.Length;
        }
    }
}
