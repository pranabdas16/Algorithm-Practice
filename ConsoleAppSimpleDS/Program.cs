using System;

namespace ConsoleAppSimpleDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Stack Queue and Dictionary Execise*****************");

            //Stack1 objStack1 = new Stack1();
            //objStack1.InputStack();
            //objStack1.Print();

            //ValidParentheses objValidParentheses = new ValidParentheses();
            //objValidParentheses.Enterparentheses();
            //objValidParentheses.PrintQueue();
            //objValidParentheses.ValidateParentheses();

            ValidParenthesesDic objValidParenthesesDic = new ValidParenthesesDic();
            bool IsValidString=  objValidParenthesesDic.IsBalanced("}({ABD})");
            Console.WriteLine();
            Console.WriteLine("This string is valid:" + IsValidString);

        }
    }
}
