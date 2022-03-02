using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Search
{
   public class StringSearch
    {
        public List<string> stringSearch()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string inputStr = "The most basic approach is to loop through the search phrases, and search through the text each phrase, one by one. This approach does not scale well. Searching for a string inside another has the complexity O(n). Repeating that for m search phrases leads to the awful O(m * n).The (likely only) upside of a direct approach that it is simple to implement, as apparent in the following C# snippet:.";
            string[] givenStr = inputStr.Split(delimiterChars);
            string searhStr = "Th";
            int counter = 0, k =0;
            List<string> result = new List<string>();
            foreach (string PortionStrng in givenStr)
            {
                counter = 0;
                k = 0;
                for (int i = 0; i < PortionStrng.Length; i++)
                {
                    if (searhStr[k].ToString().ToLower() == PortionStrng[i].ToString().ToLower())
                    {
                        counter++;
                        if (counter == 2) /// consecutive Th and upper or lower case of Th //
                        {
                            result.Add(PortionStrng);
                        }
                        k++;
                    }
                }
            }
            return result;
        }
    }
}
