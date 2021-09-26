using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MatrixTicTacToe
    {
        /// <summary>
        /// Tic Tac Toe simple way.....
        /// with If and else loop....
        /// </summary>
        /// <returns></returns>
        public string matrixTicTacToe()
        {
            char[,] TT =  { { 'o', 'x', 'o'},     //00, 01, 02
                            { 'o', 'x', 'o'},     //10, 11, 12
                            { 'x', 'o', 'x'} };   //20, 21, 22
            
            int i =0, j = 0;
            string p1 = "Person A";
            string p2 = "Person B";
            string draw = "Draw";
            string winner="non one it's draw";

            if ((TT[i, j] == TT[i, j + 1]) && (TT[i, j + 1] == TT[i, j + 2]))
            {
                if (TT[i, j] == 'x')
                    winner = p1;
                else if (TT[i, j] == 'o')
                    winner = p2;
                else
                    winner = draw;
            }
            // case 2nd row;
            else if ((TT[i + 1, j] == TT[i + 1, j + 1]) && (TT[i + 1, j + 1] == TT[i + 1, i + 2]))
            {
                if (TT[i + 1, j] == 'x')
                    winner = p1;
                else if (TT[i + 1, j] == 'o')
                    winner = p2;
                else
                    winner = draw;
            }
            // case 3rd row;
            else if ((TT[i + 2, j] == TT[i + 2, j + 1]) && (TT[i + 2, j + 1]) == TT[i + 2, j + 2])
            {
                if (TT[i + 2, j] == 'x')
                    winner = p1;
                else if (TT[i + 2, j] == 'o')
                    winner = p2;
                else
                    winner = draw;
            }
            // case 1st col;
            else if ((TT[i, j] == TT[i + 1, j]) && (TT[i + 1, j] == TT[i + 2, j]))
            {
                if (TT[i, j] == 'x')
                    winner = p1;
                else if (TT[i, j] == 'o')
                    winner = p2;
                else
                    winner = draw;
            }
            // case 2nd col;
            else if ((TT[i, j + 1] == TT[i + 1, j + 1]) && (TT[i + 1, j + 1] == TT[i + 1, j + 2]))
            {
                if (TT[i, j + 1] == 'x')
                    winner = p1;
                else if (TT[i, j + 1] == 'o')
                    winner = p2;
                else
                    winner = draw;
            }
            // case 3rd col;
            else if ((TT[i, j + 2] == TT[i + 1, j + 2]) && (TT[i + 1, j + 2] == TT[i + 2, j + 2]))
            {
                if (TT[i, j + 2] == 'x')
                    winner = p1;
                else if (TT[i, j + 2] == 'o')
                    winner = p2;
                else
                    winner = draw;
            }
            // case 1st criss; 
            else if ((TT[i, j] == TT[i + 1, j + 1]) && (TT[i + 1, j + 1] == TT[i + 2, j + 2]))
            {
                if (TT[i, j] == 'x')
                    winner = p1;
                else if (TT[i, j] == 'o')
                    winner = p2;
                else
                    winner = draw;
            }
            // case 2nd cross
            else if ((TT[i + 2, j]) == TT[i + 1, j + 1] && (TT[i + 1, j + 1] == TT[i, j + 2]))
            {
                if (TT[i + 2, j] == 'x')
                    winner = p1;
                else if (TT[i + 2, j] == 'o')
                    winner = p2;
                else 
                    winner = draw;
            }
            Console.WriteLine("winner is:" + winner);
            Console.ReadLine();
            return winner;
        }
    }
}
