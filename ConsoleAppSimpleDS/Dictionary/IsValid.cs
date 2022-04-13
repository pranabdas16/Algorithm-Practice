using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSimpleDS.Dictionary
{
    class IsValid
    {
        public bool isValid(string s)
        {
            bool isValid = true;
            //'(', ')', '{', '}', '[' and ']'
            Dictionary<char, char> parentheses = new Dictionary<char, char>()
            {
                { '(', ')'},
                { '{', '}'},
                { '[', ']'}
            };

            Stack<char> bracket = new Stack<char>();

            try
            {
                foreach (char c in s)
                {

                    if (parentheses.Keys.Contains(c))
                    {
                        bracket.Push(c);
                    }
                    else if (parentheses.Values.Contains(c))
                    {
                        if (c == parentheses[bracket.FirstOrDefault()])
                        {
                            bracket.Pop();
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                    else
                        isValid = false;

                }

                if (bracket.Count > 0)
                {
                    isValid = false;
                }
            }
            catch
            {
                isValid = false;
            }

            return isValid;

        }
    }
}
