using System;

namespace ConsoleAppLinkedList
{
    
    public class Test
    {
        
        
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double objD;
            string str, str1;
            str1 = "Helooo";
            Console.WriteLine("Hello World!");

            //Console.WriteLine(objD.ToString("0.0"));

            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }


            Console.ReadLine();
        }
    }
}
