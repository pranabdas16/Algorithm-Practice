using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class StackExercise
    {

        Stack<int> objInt = new Stack<int>();
        Stack<string> objString = new Stack<string>();
        public void stackofInt()
        {
            Console.WriteLine("Enter the integer");
            int objectInt = int.Parse(Console.ReadLine());

            for (int i= objectInt.ToString().Length; i >= 0; i-- )
            {
                int remainder = objectInt % 10; 
                objInt.Push(remainder); 
            }
            
            foreach (var d in objInt)
                {

               Console.WriteLine( objInt.Pop());
            }
            Console.ReadLine();
        }

        public void stackOfIntArry()
        {
            int[] objIntArr= { 1, 2, 3, 4, 5 };

            Stack<int> objforIntArr = new Stack<int>();

            foreach (var c in objIntArr)
            {
                objforIntArr.Push(c);
            }

            foreach (var d in objforIntArr)
            {
                Console.Write(d);
            }

            Console.ReadLine();
        }

        public void stackOfStringArray()
        {
            string[] strArry = { "Holla", "Hello", "Hi", "bonzoure" };

            foreach (var a in strArry)
            {
                objString.Push(a);
            }

            foreach (var b in objString)
            {
                Console.WriteLine(b);
            }

            Console.ReadLine();
        }
        


    }
}
