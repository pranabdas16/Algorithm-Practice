using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Search
{
    class StringSearch1
    {
        public void stringSearch1()
        {
            string phrase = "The most basic approach is to loop through the search phrases, and search through the text each phrase," +
                "one by one. This approach does not scale well. Searching for a string inside another has the complexity O(n)." +
                "Repeating that for m search phrases leads to the awful O(m * n).The (likely only) upside of a direct approach" +
                "that it is simple to implement, as apparent in the following C# snippet:.";

            string strToFind = "Th";
            List<string> strList = phrase.Split(' ').ToList();
            List<string> subString = new List<string>();
            foreach (string item in strList)
            {
                if (!String.IsNullOrEmpty(FindSubString(item, strToFind)))
                {
                    subString.Add(item);
                }
            }

            
        }

        public string FindSubString(string str, string substr)
        {
            string result = string.Empty;
            List<int> pos = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().ToLower() == substr[0].ToString().ToLower())
                {
                    pos.Add(i);
                }
            }
            if (pos.Count() > 0)
            {
                for (int j = pos[0]; j < str.Length-1; j++)
                {
                    if (str[j + 1].ToString().ToLower() == substr[1].ToString().ToLower())
                    {
                        result = str;
                    }
                }
            }
           return result;
        }
    }
}
